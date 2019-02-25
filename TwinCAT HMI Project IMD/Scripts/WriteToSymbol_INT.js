// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var WriteToSymbol_INT = function (Symbolstring) {
        var textbox = TcHmi.Controls.get('Calculator_1.TcHmiTextbox_calc');
        var text = parseInt(textbox.getText());
        
        var symbol = new TcHmi.Symbol(Symbolstring);
        symbol.write(text, function (data) {
            if (data.error === TcHmi.Errors.NONE) {
                // Handle success... 
                console.log(data.response);
            } else {
                // Handle error... 
                console.log(data.error);
            }
        });
    };
    
    TcHmi.Functions.registerFunction('WriteToSymbol_INT', WriteToSymbol_INT);
})(TcHmi);