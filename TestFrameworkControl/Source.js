// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

/*
 * Generated 2/28/2019 10:08:03 AM
 * Copyright Pim 2019
 * 
 * destinationdirectory:        C:\Users\Pim\Documents\GitHub\TwinCAT3HMI\TestFrameworkControl
 * TcHmi_DefaultParameters:     [$guid1$, ec55be3d-dbc7-4773-9864-e617d138c500] | [$guid2$, 7beec8cb-0869-4c0d-bb2b-ae61902dd471] | [$guid3$, ab6d5795-b7d2-4444-b824-67bc3c5e8f5c] | [$guid4$, e3eab10a-4f61-4bb6-a3bf-2fa411c13de0] | [$guid5$, 207b101b-9091-4fa7-9601-8bdefe835fe7] | [$guid6$, 5310321f-3bc1-4a1e-9ab1-f5428b341849] | [$guid7$, 409a61c1-3080-41d1-95a4-8f727e11f22c] | [$guid8$, 7396f7c6-b836-4447-905b-b30f8a7a0aab] | [$guid9$, 107946cc-a54c-4b30-a1c2-0cb69f8ae0ac] | [$guid10$, 2c350a25-4fa0-4456-b14b-3a7cedcdda37] | [$time$, 2/28/2019 10:08:03 AM] | [$year$, 2019] | [$username$, Pim] | [$userdomain$, LAPTOP-IQO77BGT] | [$machinename$, LAPTOP-IQO77BGT] | [$clrversion$, 4.0.30319.42000] | [$registeredorganization$, ] | [$runsilent$, False] | [$targetframeworkversion$, 4.6.1] | [$solutiondirectory$, C:\Users\Pim\Documents\GitHub\TwinCAT3HMI\] | [$projectname$, TestFrameworkControl] | [$safeprojectname$, TestFrameworkControl] | [$currentuiculturename$, en-US] | [$installpath$, C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\] | [$specifiedsolutionname$, TestFrameworkControl] | [$exclusiveproject$, False] | [$destinationdirectory$, C:\Users\Pim\Documents\GitHub\TwinCAT3HMI\TestFrameworkControl]
 * projectname_tchmi:           TestFrameworkControl
 * projectname_tchmi_dashcase:  test-framework-control
 * safeprojectname:             TestFrameworkControl
 * projectname:                 TestFrameworkControl
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
            /** TestFrameworkControl object */
            var TestFrameworkControl = (function (_super) {
                __extends(TestFrameworkControl, _super);

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
                function TestFrameworkControl(element, pcElement, attrs) {
                    /** Call base constructor */
                    _super.call(this, element, pcElement, attrs);

                }
                /** 
                * @description Is called during control initialize phase before attribute setter are called based on initial html dom values. 
                * @returns {void}
                */
                TestFrameworkControl.prototype.__previnit = function () {
                    /** Handle template elements. Should be done before call to __previnit of super class. */
                    this.__elementTemplateRoot = this.__element.find('.test-framework-control-template');
                    
                    /** Call __previnit of super class with the correct instance. */
                    _super.prototype.__previnit.call(this);
                };
                /** 
                 * @description Is called during control initialize phase after attribute setter have been called based on it's default or initial html dom values. 
                 * @returns {void}
                 */
                TestFrameworkControl.prototype.__init = function () {
                    /** Call __init of super class with the correct instance. */
                    _super.prototype.__init.call(this);

                };
                /**
                * @description Is called after the control instance gets part of the current DOM.
                * Is only allowed to be called from the framework itself!
                * @returns {void}
                */
                TestFrameworkControl.prototype.__attach = function () {
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
                TestFrameworkControl.prototype.__detach = function () {
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
                TestFrameworkControl.prototype.destroy = function () {
                    /** Call destroy of super class with the correct instance. */
                    _super.prototype.destroy.call(this);

                    /**
                    * Free resources like child controls etc.
                    */
                };

                return TestFrameworkControl;
            })(TcHmi.Controls.System.TcHmiControl);
            Custom.TestFrameworkControl = TestFrameworkControl;
        })(Custom = Controls.Custom || (Controls.Custom = {}));
        /**
        * Register control...
        */
        Controls.register('test-framework-control', Custom.TestFrameworkControl, 'Custom/TestFrameworkControl/', 'Custom/TestFrameworkControl/Template.html');
    })(Controls = TcHmi.Controls || (TcHmi.Controls = {}));
})(TcHmi);