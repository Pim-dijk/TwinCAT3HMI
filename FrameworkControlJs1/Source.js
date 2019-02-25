// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

/*
 * Generated 2/13/2019 8:46:06 AM
 * Copyright Pim 2019
 * 
 * destinationdirectory:        C:\Users\Pim\Downloads\20171718_TwinCAT Project IMD\FrameworkControlJs1
 * TcHmi_DefaultParameters:     [$guid1$, 5c0cd14a-c92b-4320-aa6e-3a1dab1ea1af] | [$guid2$, 713b12b9-8c1b-413b-996e-a6663aaa4449] | [$guid3$, 34e3d1c6-79b6-4094-9ec0-c0e7acf0f0a1] | [$guid4$, a06103ba-ce70-445f-b442-432f2e6c4f38] | [$guid5$, b2f31d9f-357b-435d-ab93-09d0c5186b7d] | [$guid6$, 063cbf0d-c89e-4b54-9a04-052e741d28c7] | [$guid7$, f1f10e68-2b45-47fb-9ce0-04ccba32e988] | [$guid8$, 6880bd26-37a7-41ed-99c3-cf4866b50003] | [$guid9$, 4e8f764e-0cc9-453b-98a4-f619b59e5b0a] | [$guid10$, cfb9dd1e-ef7f-42eb-b59f-3ed31cc95f01] | [$time$, 2/13/2019 8:46:06 AM] | [$year$, 2019] | [$username$, Pim] | [$userdomain$, LAPTOP-IQO77BGT] | [$machinename$, LAPTOP-IQO77BGT] | [$clrversion$, 4.0.30319.42000] | [$registeredorganization$, ] | [$runsilent$, False] | [$targetframeworkversion$, 4.6.1] | [$solutiondirectory$, C:\Users\Pim\Downloads\20171718_TwinCAT Project IMD\] | [$projectname$, FrameworkControlJs1] | [$safeprojectname$, FrameworkControlJs1] | [$currentuiculturename$, en-US] | [$installpath$, C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\] | [$specifiedsolutionname$, FrameworkControlJs1] | [$exclusiveproject$, False] | [$destinationdirectory$, C:\Users\Pim\Downloads\20171718_TwinCAT Project IMD\FrameworkControlJs1]
 * projectname_tchmi:           FrameworkControlJs1
 * projectname_tchmi_dashcase:  framework-control-js1
 * safeprojectname:             FrameworkControlJs1
 * projectname:                 FrameworkControlJs1
 */

/**
*  Namespace: TcHmi
*  [REQUIRED]
*/
(function (TcHmi) {
    /**
    *  Namespace: TcHmi.Controls
    *  [REQUIRED]
    */
    (function (Controls) {
        /**
         *  Namespace: TcHmi.Controls.Custom
         *  [CUSTOM]
         */
        var Custom;
        (function (Custom) {
            /** FrameworkControlJs1 object */
            var FrameworkControlJs1 = (function (_super) {
                __extends(FrameworkControlJs1, _super);

                /*
                Attribute philosophy
                --------------------
                - Local variables are not set while definition in class, so they have the value 'undefined'.
                - On compile the Framework sets the value from HTML or from theme (possibly 'null') via normal setters
                - The "changed detection" in the setter will result in processing the value only once while compile
                - Attention: If we have a Server Binding on an Attribute the setter can be very late or never (leaving the value = undefined).
                */

                /**
                 * @description Constructor of the control
                 * @param {JQuery} element Element from HTML (internal, do not use)
                 * @param {JQuery} pcElement precompiled Element (internal, do not use)
                 * @param {TcHmi.Controls.ControlAttributeList} attrs Attributes defined in HTML in a special format (internal, do not use)
                 * @returns {void}
                 */
                function FrameworkControlJs1(element, pcElement, attrs) {
                    /** Call base constructor */
                    _super.call(this, element, pcElement, attrs);

                }
                /** 
                * @description Is called during control initialize phase before attribute setter are called based on initial html dom values. 
                * @returns {void}
                */
                FrameworkControlJs1.prototype.__previnit = function () {
                    /** Handle template elements. Should be done before call to __previnit of super class. */
                    this.__elementTemplateRoot = this.__element.find('.framework-control-js1-template');
                    
                    /** Call __previnit of super class with the correct instance. */
                    _super.prototype.__previnit.call(this);
                };
                /** 
                 * @description Is called during control initialize phase after attribute setter have been called based on it's default or initial html dom values. 
                 * @returns {void}
                 */
                FrameworkControlJs1.prototype.__init = function () {
                    /** Call __init of super class with the correct instance. */
                    _super.prototype.__init.call(this);

                };
                /**
                * @description Is called after the control instance gets part of the current DOM.
                * Is only allowed to be called from the framework itself!
                * @returns {void}
                */
                FrameworkControlJs1.prototype.__attach = function () {
                    /** Call __attach of super class with the correct instance. */
                    _super.prototype.__attach.call(this);

                    /**
                     * Initialize everything which is only available while the control is part of the active dom.
                     */
                };
                /**
                * @description Is called after the control instance is no longer part of the current DOM.
                * Is only allowed to be called from the framework itself!
                * @returns {void}
                */
                FrameworkControlJs1.prototype.__detach = function () {
                    /** Call __detach of super class with the correct instance. */
                    _super.prototype.__detach.call(this);

                    /**
                     * Disable everything which is not needed while the control is not part of the active dom.
                     * No need to listen to events for example!
                     */
                };
                /**
                * @description Destroy the current control instance. 
                * Will be called automatically if system destroys control!
                * @returns {void}
                */
                FrameworkControlJs1.prototype.destroy = function () {
                    /** Call destroy of super class with the correct instance. */
                    _super.prototype.destroy.call(this);

                    /**
                    * Free resources like child controls etc.
                    */
                };

                return FrameworkControlJs1;
            })(TcHmi.Controls.System.TcHmiControl);
            Custom.FrameworkControlJs1 = FrameworkControlJs1;
        })(Custom = Controls.Custom || (Controls.Custom = {}));
        /**
        * Register control...
        */
        Controls.register('framework-control-js1', Custom.FrameworkControlJs1, 'Custom/FrameworkControlJs1/', 'Custom/FrameworkControlJs1/Template.html');
    })(Controls = TcHmi.Controls || (TcHmi.Controls = {}));
})(TcHmi);