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
    ///The SensorNotification recording.
    /// </summary>
    [TestModule("5125e464-d6eb-4985-962e-72ad19b3ab11", ModuleType.Recording, 1)]
    public partial class SensorNotification : ITestModule
    {
        /// <summary>
        /// Holds an instance of the IntelliSync_BVTRepository repository.
        /// </summary>
        public static IntelliSync_BVTRepository repo = IntelliSync_BVTRepository.Instance;

        static SensorNotification instance = new SensorNotification();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SensorNotification()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SensorNotification Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(0));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.RCTUIImageViewAnimated1' at Center", repo.ComPentairPentairhome.RCTUIImageViewAnimated1Info, new RecordItemIndex(1));
            repo.ComPentairPentairhome.RCTUIImageViewAnimated1.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Notifications1' at Center", repo.ComPentairPentairhome.Notifications1Info, new RecordItemIndex(3));
            repo.ComPentairPentairhome.Notifications1.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.RCTView2' at Center", repo.ComPentairPentairhome.RCTView2Info, new RecordItemIndex(5));
            repo.ComPentairPentairhome.RCTView2.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.RCTView2' at Center", repo.ComPentairPentairhome.RCTView2Info, new RecordItemIndex(7));
            repo.ComPentairPentairhome.RCTView2.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            Delay.Duration(1000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "sensorNotification", repo.ComPentairPentairhome.NotificationsAllNotificationsPushNot1, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.AssetsSrcCommonFeatureImagesIconBac' at Center", repo.ComPentairPentairhome.AssetsSrcCommonFeatureImagesIconBacInfo, new RecordItemIndex(10));
            repo.ComPentairPentairhome.AssetsSrcCommonFeatureImagesIconBac.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(11));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.RCTView9' at Center", repo.ComPentairPentairhome.RCTView9Info, new RecordItemIndex(12));
            repo.ComPentairPentairhome.RCTView9.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(13));
            Delay.Duration(300, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}