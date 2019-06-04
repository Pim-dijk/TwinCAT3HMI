// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var CreateBindingPIDControllerSettings = function (SymbolString,Control, BindToProperty) {
        //console.log(SymbolString);
        //console.log(Control);
        //console.log(BindToProperty);

        var property = BindToProperty ? BindToProperty : "Value";

        var ASideSymbol = new TcHmi.Symbol('%i%_IsASide%/i%');
        var TopSideSymbol = new TcHmi.Symbol('%i%_IsTopSide%/i%');
        var ASide = ASideSymbol.read();
        var TopSide = TopSideSymbol.read();

        var numberSymbol = new TcHmi.Symbol('%i%_SetNumber%/i%')
        var number = numberSymbol.read();

        var value = "%s%";

        if (ASide) {
            if (TopSide) {
                value += TcHmi.Functions.Beckhoff.FormatString(SymbolString, 'Top', 'A', number);
            } else {
                value += TcHmi.Functions.Beckhoff.FormatString(SymbolString, 'Bottom', 'A', number);
            }
        } else {
            if (TopSide) {
                value += TcHmi.Functions.Beckhoff.FormatString(SymbolString, 'Top', 'B', number);
            } else {
                value += TcHmi.Functions.Beckhoff.FormatString(SymbolString, 'Bottom', 'B', number);
            }
        }
        value += "%/s%";
        //console.log(value);

        ASideSymbol.destroy();
        ASideSymbol = null;
        TopSideSymbol.destroy();
        TopSideSymbol = null;
        numberSymbol.destroy();
        numberSymbol = null;

        if (Control) {
            TcHmi.Binding.createEx(value, 'set' + property, Control);
        }

    };
    
    TcHmi.Functions.registerFunction('CreateBindingPIDControllerSettings', CreateBindingPIDControllerSettings);
})(TcHmi);