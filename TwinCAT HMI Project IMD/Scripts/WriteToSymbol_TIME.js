// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var WriteToSymbol_TIME = function (ctx,SymbolString,Value) {
        //console.log(SymbolString);
        //console.log(Value);

        var value = 'PT';
        value += (Value / 1000);
        value += 'S';
        //console.log(value);
        
        TcHmi.Symbol.writeEx(SymbolString, value, function (data) {
            if (data.error === TcHmi.Errors.NONE) {
                // Handle success... 
                ctx.success();
            } else {
                // Handle error... 
                console.log(data);
            }
        });
    };
    
    TcHmi.Functions.registerFunction('WriteToSymbol_TIME', WriteToSymbol_TIME);
})(TcHmi);