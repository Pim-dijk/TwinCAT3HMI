// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var CreateGantryBinding = function (SymbolString,Control,PropertyToBindTo) {

        //console.log(SymbolString);
        //console.log(Control);
        //console.log(PropertyToBindTo);

        var property = PropertyToBindTo ? PropertyToBindTo : "Symbol";

        var ASideSymbol = new TcHmi.Symbol('%i%_IsASide%/i%');
        var ASide = ASideSymbol.read();

        var value = "%s%";

        if (ASide) {
            value += TcHmi.Functions.Beckhoff.FormatString(SymbolString, 'A');
        } else {
            value += TcHmi.Functions.Beckhoff.FormatString(SymbolString, 'B');
        }


        value += "%/s%";
        console.log(value);

        ASideSymbol.destroy();
        ASideSymbol = null;

        if (Control) {
            TcHmi.Binding.createEx(value, 'set' + property, Control);
        }

    };
    
    TcHmi.Functions.registerFunction('CreateGantryBinding', CreateGantryBinding);
})(TcHmi);