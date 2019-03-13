﻿// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var ConvertAlarmWordsToDataGrid = function (TargetControl, AlarmWordList, AlarmMessageList, AlarmDB) {
        console.log("Calling js function: " + new Date());

        // Target to send the data to
        var target = TcHmi.Controls.get(TargetControl);
        // Get the locale information
        var timeZone = TcHmi.Locale.get();
        // Create date object with current date time
        var date = new Date();
        // Convert the date object to local time object
        var dateTimeString = date.toLocaleString(timeZone);
        // The Array that holds the alarms
        var json = [];
        var allAlarms = AlarmWordList;
        var count = 0;
        var length = Object.keys(allAlarms).length;
        var alarmSymbol = AlarmDB.__symbol.__expression.__expression;
        var alarmDBSymbol = new TcHmi.Symbol(alarmSymbol);
        var alarmDB = alarmDBSymbol.read();
        // uncomment to reset the DB
        //alarmDB = {};

        $.each(allAlarms, function (key, value) {
            // Read the server side symbol alarm value
            TcHmi.Symbol.readEx2(value, function (data) {
                count++;
                if (data.error === 0) {
                    // Get server symbol value, write to internal value
                    var serverValue = data.value;
                    var symbol = new TcHmi.Symbol(key);
                    var result = symbol.read();
                    result.Data = serverValue;
                    symbol.write(result);


                    // Convert the DINT value to Binary
                    var offset = result.AlarmBeginNr;
                    var dint = serverValue;
                    var binary = convertToBin(dint);

                    // Turn the string into an Array
                    // Reverse the array, to get the correct order		
                    var binArray = binary.split("");
                    binArray.reverse();

                    // Object with all the alarmstrings
                    var alarmStrings = AlarmMessageList;
                    var jsonEntry = {};

                    // Loop through array and if it's 1, get the correct alarm message for it
                    for (var i = 0; i < binArray.length; i++) {
                        var exists = false;
                        var x = 0;
                        x = (i + offset);
                        if (doesExistInDB(x)) {
                            exists = true;
                        };
                        if (!exists) {
                            //console.log("This one doesn't exists yet!");
                            if (binArray[i] === '1') {
                                // 1
                                jsonEntry['Test1'] = (i + offset);
                                jsonEntry['Test2'] = date;
                                jsonEntry['Test3'] = result.AlarmGroup.text;
                                jsonEntry['Test4'] = alarmStrings[timeZone][(i + offset)];
                                alarmDB[(i + offset)] = jsonEntry;
                                jsonEntry = {};
                            }
                        } if (exists && (binArray[i] === '0')) {
                            // 0
                            delete alarmDB[(i + offset)];
                        }
                    };

                    // Check if we are at the end of the AlarmWordList
                    // If so, write to target control
                    if (count >= length) {
                        
                        // Write to alarmDB Symbol
                        alarmDBSymbol.write(alarmDB, function (data) {
                            if (data.error === TcHmi.Errors.NONE) {
                                // Handle success... 
                            } else {
                                // Handle error... 
                                console.log(data);
                            }
                        });

                        // Write each value from alarmDB to json
                        $.each(alarmDB, function (key, value) {
                            var dateTime = new Date(value.Test2);
                            var localeDateTime = dateTime.toLocaleString(timeZone);
                            value.Test2 = localeDateTime;
                            value.Test4 = alarmStrings[timeZone][value.Test1];
                            json.push(value);
                        });
                        // set json as data for the target
                        target.setSrcData(json);
                    }
                } else {
                    console.log(data.error);
                }
            });
        });
        
        function convertToBin(dint) {
            // nMask must be between -2147483648 and 2147483647
            for (var nFlag = 0, nShifted = dint, sMask = ""; nFlag < 32;
                nFlag++ , sMask += String(nShifted >>> 31), nShifted <<= 1);
            return sMask;
        };

        function doesExistInDB(index) {
            //console.log("Does this exists in the DB?");
            //console.log(alarmDB[index]);
            if (alarmDB[index] !== undefined) {
                return true;
            } else {
                return false;
            }
        };
    };
    
    TcHmi.Functions.registerFunction('ConvertAlarmWordsToDataGrid', ConvertAlarmWordsToDataGrid);
})(TcHmi);