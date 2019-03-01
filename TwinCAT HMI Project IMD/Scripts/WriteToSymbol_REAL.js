// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var WriteToSymbol_REAL = function (ctx, SymbolString, Value) {
        
        //console.log("Symbol: ");
        //console.log(SymbolString);
        //console.log("CalcTextbox: ");
        //console.log(KeyboardString + '.TcHmiTextbox_calc');

        //console.log(Symbolstring.__symbol.__expression.__expression);
        //var textbox = TcHmi.Controls.get(KeyboardString + '.TcHmiTextbox_calc');
        //var text = parseFloat(textbox.getText());

        //console.log(text);

        //TcHmi.Symbol.write(Symbolstring, TcHmi.SymbolType.Server, text, function (data) {
        //    if (data.error === TcHmi.Errors.NONE) {
        //        // Handle success... 
        //        console.log("Success: ");
        //        console.log(data.response);
        //    } else {
        //        // Handle error... 
        //        console.log("Error: ");
        //        console.log(data.error);
        //    }
        //});

        // Create new Symbol object from string, and write the value to it
        var symbol = new TcHmi.Symbol(SymbolString);
        symbol.write(Value, function (data) {
            if (data.error === TcHmi.Errors.NONE) {
                // Handle success... 
                //console.log(data.response);
                ctx.success();
            } else {
                // Handle error... 
                //console.log(data.error);
            }
        });

        //TcHmi.Symbol.writeEx(Symbolstring.__symbol.__expression.__expression, text, function (data) {
        //    if (data.error === TcHmi.Errors.NONE) {
        //        // Handle success... 
        //        console.log("Success: ");
        //        console.log(data.response);
        //    } else {
        //        // Handle error... 
        //        console.log("Error: ");
        //        console.log(data.error);
        //    }
        //});
    };
    
    TcHmi.Functions.registerFunction('WriteToSymbol_REAL', WriteToSymbol_REAL);
})(TcHmi);