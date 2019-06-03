// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    // TimeToRun : How long the screen should be displayed, in seconds
    // ControlTargetID : The id of the control that is the screen overlay
    // TargetSymbol : The symbol that stores and displays the time that is left
    var CleanScreen = function (TimeToRun,ControlTargetID,TargetSymbol) {
                        
        var timeLeft = TimeToRun;

        var TimeLeftSymbol = new TcHmi.Symbol(TargetSymbol.__symbol.__expression.__expression);
        var targetControl = TcHmi.Controls.get(ControlTargetID);
        targetControl.setVisibility('Visible');
        TimeLeftSymbol.write(timeLeft);
        
        var interval = setInterval(displayTime, 1000);

        function displayTime() {
            timeLeft--;
            TimeLeftSymbol.write(timeLeft);

            if (timeLeft <= 0) {
                stopInterval();
                targetControl.setVisibility('Collapsed');
            }
        }

        function stopInterval() {
            clearInterval(interval);
        }
    };
    
    TcHmi.Functions.registerFunction('CleanScreen', CleanScreen);
})(TcHmi);