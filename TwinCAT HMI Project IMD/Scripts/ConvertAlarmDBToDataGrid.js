// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var ConvertAlarmDBToDataGrid = function (Target,AlarmDB,AlarmMessageList) {
        console.log('Converting the alarmDB to datagrid');

        // Convert datetime to current selected locale for display
        // set the message to the current locale string
        // Does NOT alter the AlarmDB

        // Target to send the data to
        var target = TcHmi.Controls.get(Target);
        //console.log(target);
        // Get the locale information
        var timeZone = TcHmi.Locale.get();
        // The Array that holds the alarms
        var json = [];
        // Locally stored alarms
        var alarmDB = {};
        alarmDB = AlarmDB;
        //console.log(alarmDB);
        // List of alarm messages
        var alarmStrings = AlarmMessageList;
        //console.log(alarmStrings);

        // foreach registered alarm, convert the time and message to the set locale
        $.each(alarmDB, function (key, value) {
            // make new Date object with the datetime from the alarm entry
            var dateTime = new Date(value.Test2);
            // convert it to the local format
            var localDateTime = dateTime.toLocaleString(timeZone);
            // set the new value
            value.Test2 = localDateTime;
            // set the message to the local value
            value.Test4 = alarmStrings[timeZone][value.Test1];
            // add it to the array
            json.push(value);
        });
        // send the array to the data target
        target.setSrcData(json);

    };
    
    TcHmi.Functions.registerFunction('ConvertAlarmDBToDataGrid', ConvertAlarmDBToDataGrid);
})(TcHmi);