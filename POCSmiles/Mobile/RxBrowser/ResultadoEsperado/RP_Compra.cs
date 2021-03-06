﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace POCSmiles.Mobile.RxBrowser.ResultadoEsperado
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RP_Compra recording.
    /// </summary>
    [TestModule("15af5180-ac1d-4666-a1f6-b6d4d5805bb7", ModuleType.Recording, 1)]
    public partial class RP_Compra : ITestModule
    {
        /// <summary>
        /// Holds an instance of the POCSmiles.SmilesRepository repository.
        /// </summary>
        public static POCSmiles.SmilesRepository repo = POCSmiles.SmilesRepository.Instance;

        static RP_Compra instance = new RP_Compra();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RP_Compra()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RP_Compra Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Dispositivo.
        /// </summary>
        [TestVariable("da3e43bb-7e4d-42d3-af80-4010368868c5")]
        public string Dispositivo
        {
            get { return repo.Dispositivo; }
            set { repo.Dispositivo = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RxBrowser.Dom.Validacao_MilhasCompradasSucesso'.", repo.RxBrowser.Dom.Validacao_MilhasCompradasSucessoInfo, new RecordItemIndex(0));
            Validate.Exists(repo.RxBrowser.Dom.Validacao_MilhasCompradasSucessoInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.RxBrowser.Self, false, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Touch Gestures", "Swipe gesture with direction 'Up (270°)' starting from 'Center' with distance '1.0' with swipe duration'500ms' and step count '0' on item 'RxBrowser.Dom'.", repo.RxBrowser.Dom.SelfInfo, new RecordItemIndex(2));
            repo.RxBrowser.Dom.Self.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "1.0"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.RxBrowser.Self, false, new RecordItemIndex(3));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
