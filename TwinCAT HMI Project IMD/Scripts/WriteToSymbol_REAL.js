// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var WriteToSymbol_REAL = function (ctx, SymbolString, Value) {
        //console.log(Value);
        
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
        symbol.destroy();
        symbol = null;
    };
    
    TcHmi.Functions.registerFunction('WriteToSymbol_REAL', WriteToSymbol_REAL);
})(TcHmi);