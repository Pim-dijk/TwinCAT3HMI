// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {
    // If you want to unregister an event outside the event code you need to use the return value of the method register()
    var destroyOnInitialized = TcHmi.EventProvider.register('onInitialized', function (e, data) {
        // This event will be raised only once, so we can free resources. 
        // It's best practice to use destroy function of the event object within the callback function to avoid conflicts.
        e.destroy();
        // ----------------------
        // Place your code here!
        // ----------------------
    }); 

    var readDB = TcHmi.EventProvider.register('readFromDB', function (e, data) {
        //Werkt niet, alleen in IE
        //var connection = new ActiveXObject("ADODB.Connection");

        //var connectionstring = "Data Source=wwww; Initial Catalog=storage.db;Provider=SQLOLEDB";
        //connection.Open(connectionstring);

        //rs.Open("SELECT * FROM JSTest", connection);
        //rs.MoveFirst
        //while (!rs.eof) {
        //    console.log(rs.fields(1));
        //    rs.movenext;
        //}

        //rs.close;
        //connection.close;

        //
        
        
        //var conn = SQL.connect({
        //    Driver: "SQLite",
        //    Database: "C:\\Users\\Pim\\School\\OneDrive for Business 2.0\\OneDrive - Graafschap College\\Documenten\\Afstudeerstage\\Backup\\storage.db"
        //});

        //var result = conn.query("SELECT * FROM JSTest;");
        //if (result.isValid == false) {
        //    test.log("Result is not valid, maybe no entries in database?")
        //} else {
        //    while (result.isValid) {
        //        // do something with the result
        //        var id = result.value(0)
        //        var text = result.value(1)
        //        //test.log(id + forename + surname + email + phone)
        //        //addEntry(forename, surname, email, phone)
        //        result.toNext();
        //        console.log(id + ' - ' + text);
        //    }
        //}

        
        function createDatabase() {
            try {
                if (window.openDatabase) {
                    var shortName = 'C:/Users/Pim/Documents/GitHub/TwinCAT3HMI/TwinCAT HMI Project IMD/code-behind/storage.db';
                    var version = '1.0';
                    var displayName = 'storage';
                    var maxSize = 65536; // in bytes
                    db = openDatabase(shortName, version, displayName, maxSize);
                }
            } catch (e) {
                alert(e);
            }
        }

        createDatabase();

        //readDB();
    });

    // get a list of all users and send them to the provided target control
    var userDataGrid = TcHmi.EventProvider.register('fillUserDataGrid', function (e, data) {
        //console.log("This is my code behind function...");
        var target = TcHmi.Controls.get(data);
        //console.log(data);
        //console.log(target);

        var targetArray = [];

        TcHmi.Server.UserManagement.listUsers(function (data) {
            if (data.error === TcHmi.Errors.NONE) {
                //console.log("Userlist data... ");
                //console.log(data);
                $.each(data.userDetails, function (key, user) {
                    if (key.startsWith('__')) {
                        //console.log('Username starts with "__"');
                        return;
                    }
                    var userData = {};
                    userData['name'] = key;
                    var groups = [];
                    $.each(user.groups, function (key, value) {
                        if (value.startsWith('__')) {
                            return;
                        }
                        var groupEntry = [];
                        groupEntry['text'] = value;
                        groupEntry['value'] = value;
                        //groups.push(groupEntry);
                        groups.push(value);
                    });
                    userData['group'] = groups;
                    userData['locale'] = user.locale;
                    userData['enabled'] = user.enabled;
                    userData['autoLogout'] = user.autoLogout;
                    //userData['group'] = JSON.stringify(user.groups);
                    targetArray.push(userData);
                });
                target.setSrcData(targetArray);

            } else {
                // Error
                console.log(data);
            }
        });

        // destorys this function, making it a 1 time use function
        //userDataGrid();
    });
    
})(TcHmi);
