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

namespace IntelliSync_BVT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The wifi recording.
    /// </summary>
    [TestModule("7c14b661-2425-4e3f-9c58-824f175f36e6", ModuleType.Recording, 1)]
    public partial class wifi : ITestModule
    {
        /// <summary>
        /// Holds an instance of the IntelliSync_BVTRepository repository.
        /// </summary>
        public static IntelliSync_BVTRepository repo = IntelliSync_BVTRepository.Instance;

        static wifi instance = new wifi();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public wifi()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static wifi Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.WiFi' at Center", repo.ComPentairPentairhome.WiFiInfo, new RecordItemIndex(1));
            repo.ComPentairPentairhome.WiFi.Touch();
            Delay.Milliseconds(300);
            
            Report.Screenshot(ReportLevel.Info, "User", "wifi", repo.ComPentairPentairhome.WiFiNetworkSiemensSignalStrengthGoo, false, new RecordItemIndex(2));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'ComPentairPentairhome.Good'.", repo.ComPentairPentairhome.GoodInfo, new RecordItemIndex(3));
                Validate.Exists(repo.ComPentairPentairhome.GoodInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(4));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.RCTView8' at Center", repo.ComPentairPentairhome.RCTView8Info, new RecordItemIndex(5));
            repo.ComPentairPentairhome.RCTView8.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(6));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
