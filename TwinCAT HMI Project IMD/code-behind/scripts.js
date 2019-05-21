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