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
    ///The IntelliSyncDashboard1 recording.
    /// </summary>
    [TestModule("82d13699-9299-4b77-82be-6309a74d295c", ModuleType.Recording, 1)]
    public partial class IntelliSyncDashboard1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the IntelliSync_BVTRepository repository.
        /// </summary>
        public static IntelliSync_BVTRepository repo = IntelliSync_BVTRepository.Instance;

        static IntelliSyncDashboard1 instance = new IntelliSyncDashboard1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public IntelliSyncDashboard1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static IntelliSyncDashboard1 Instance
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
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.INTELLISYNCRDAUTO' at Center", repo.ComPentairPentairhome.INTELLISYNCRDAUTOInfo, new RecordItemIndex(1));
            repo.ComPentairPentairhome.INTELLISYNCRDAUTO.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(2));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ModeAuto' at Center", repo.ComPentairPentairhome.ModeAutoInfo, new RecordItemIndex(3));
            repo.ComPentairPentairhome.ModeAuto.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(4));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.GOTIT' at Center", repo.ComPentairPentairhome.GOTITInfo, new RecordItemIndex(5));
            repo.ComPentairPentairhome.GOTIT.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ModeAuto' at Center", repo.ComPentairPentairhome.ModeAutoInfo, new RecordItemIndex(6));
            repo.ComPentairPentairhome.ModeAuto.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.AssetsSrcCommonFeatureImagesClose2A' at Center", repo.ComPentairPentairhome.AssetsSrcCommonFeatureImagesClose2AInfo, new RecordItemIndex(7));
            repo.ComPentairPentairhome.AssetsSrcCommonFeatureImagesClose2A.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(8));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
