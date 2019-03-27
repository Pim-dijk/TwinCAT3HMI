// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var UpdateAlarmDBForAlarmWord = function (AlarmDB, AlarmWordServer, AlarmWordInternal, AlarmMessageList) {
        console.log('Updating the alarmDB for: ' + AlarmWordServer.__symbol.__expression.__name);

        //console.log(AlarmDB);
        //console.log(AlarmWordServer);
        //console.log(AlarmWordInternal);
        //console.log(AlarmMessageList);

        // Get the locale information
        var timeZone = TcHmi.Locale.get();
        // Create date object with current date time
        var date = new Date();
        // Convert the date object to local time object
        var dateTimeString = date.toLocaleString(timeZone);

        var alarmSymbol = AlarmDB.__symbol.__expression.__expression;
        var alarmDBSymbol = new TcHmi.Symbol(alarmSymbol);
        var alarmDB = alarmDBSymbol.read();
                
        TcHmi.Symbol.readEx2(AlarmWordServer.__symbol.__expression.__expression, function (data) {
            if (data.error === 0) {
                // Get server symbol value, write to internal value
                var serverValue = data.value;
                var symbol = new TcHmi.Symbol(AlarmWordInternal.__symbol.__expression.__expression);
                var result = symbol.read();
                result.Data = serverValue;
                symbol.write(result);
                //console.log(symbol.read());


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
                        if (binArray[i] === '1') {
                            // 1
                            //console.log("This one doesn't exist yet!");
                            jsonEntry['Test1'] = (i + offset);
                            jsonEntry['Test2'] = date;
                            jsonEntry['Test3'] = result.AlarmGroup.text;
                            jsonEntry['Test4'] = alarmStrings[timeZone][(i + offset)];
                            //console.log(jsonEntry);
                            alarmDB[(i + offset)] = jsonEntry;
                            jsonEntry = {};
                        }
                    } if (exists && (binArray[i] === '0')) {
                        // 0
                        //console.log('Already exists, deleting!');
                        delete alarmDB[(i + offset)];
                    }
                };
                
                //console.log(alarmDB);
                // Write to alarmDB Symbol
                alarmDBSymbol.write(alarmDB, function (data) {
                    if (data.error === TcHmi.Errors.NONE) {
                        // Handle success... 
                        console.log('alarmDB updated..');
                    } else {
                        // Handle error... 
                        console.log(data);
                    }
                });

            } else {
                console.log('error...');
                console.log(data);
            }
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
    
    TcHmi.Functions.registerFunction('UpdateAlarmDBForAlarmWord', UpdateAlarmDBForAlarmWord);
})(TcHmi);