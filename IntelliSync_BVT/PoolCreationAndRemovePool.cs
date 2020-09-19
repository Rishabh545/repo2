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
    ///The PoolCreationAndRemovePool recording.
    /// </summary>
    [TestModule("e127880a-2389-4f22-b652-577c32529119", ModuleType.Recording, 1)]
    public partial class PoolCreationAndRemovePool : ITestModule
    {
        /// <summary>
        /// Holds an instance of the IntelliSync_BVTRepository repository.
        /// </summary>
        public static IntelliSync_BVTRepository repo = IntelliSync_BVTRepository.Instance;

        static PoolCreationAndRemovePool instance = new PoolCreationAndRemovePool();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PoolCreationAndRemovePool()
        {
            PoolName = "TestPool";
            PoolVolume = "12233";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PoolCreationAndRemovePool Instance
        {
            get { return instance; }
        }

#region Variables

        string _PoolName;

        /// <summary>
        /// Gets or sets the value of variable PoolName.
        /// </summary>
        [TestVariable("b0dd0015-39a9-439c-84ae-5de64afb035b")]
        public string PoolName
        {
            get { return _PoolName; }
            set { _PoolName = value; }
        }

        string _PoolVolume;

        /// <summary>
        /// Gets or sets the value of variable PoolVolume.
        /// </summary>
        [TestVariable("510eb860-46e2-4349-a027-ed765c0aff7d")]
        public string PoolVolume
        {
            get { return _PoolVolume; }
            set { _PoolVolume = value; }
        }

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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.PoolInfo' at Center", repo.ComPentairPentairhome.PoolInfoInfo, new RecordItemIndex(0));
            repo.ComPentairPentairhome.PoolInfo.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ADDANEWPOOL' at Center", repo.ComPentairPentairhome.ADDANEWPOOLInfo, new RecordItemIndex(1));
            repo.ComPentairPentairhome.ADDANEWPOOL.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Outdoor' at Center", repo.ComPentairPentairhome.OutdoorInfo, new RecordItemIndex(2));
            repo.ComPentairPentairhome.Outdoor.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$PoolName' on item 'ComPentairPentairhome.PoolName1'.", repo.ComPentairPentairhome.PoolName1Info, new RecordItemIndex(3));
            repo.ComPentairPentairhome.PoolName1.Element.SetAttributeValue("Text", PoolName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$PoolVolume' on item 'ComPentairPentairhome.Volume'.", repo.ComPentairPentairhome.VolumeInfo, new RecordItemIndex(4));
            repo.ComPentairPentairhome.Volume.Element.SetAttributeValue("Text", PoolVolume);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Done' at Center", repo.ComPentairPentairhome.DoneInfo, new RecordItemIndex(5));
            repo.ComPentairPentairhome.Done.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Up (270°)' starting from 'Center' with distance '250' with swipe duration'800ms' and step count '0' on item 'ComPentairPentairhome.Volume1'.", repo.ComPentairPentairhome.Volume1Info, new RecordItemIndex(6));
            repo.ComPentairPentairhome.Volume1.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "250"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "800ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.SelectAddress' at Center", repo.ComPentairPentairhome.SelectAddressInfo, new RecordItemIndex(7));
            repo.ComPentairPentairhome.SelectAddress.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Container27367SW30thAveNewberry' at Center", repo.ComPentairPentairhome.Container27367SW30thAveNewberryInfo, new RecordItemIndex(8));
            repo.ComPentairPentairhome.Container27367SW30thAveNewberry.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Save' at Center", repo.ComPentairPentairhome.SaveInfo, new RecordItemIndex(9));
            repo.ComPentairPentairhome.Save.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(10));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.TestPool' at Center", repo.ComPentairPentairhome.TestPoolInfo, new RecordItemIndex(11));
            repo.ComPentairPentairhome.TestPool.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Up (270°)' starting from 'Center' with distance '100' with swipe duration'800ms' and step count '0' on item 'ComPentairPentairhome.Address'.", repo.ComPentairPentairhome.AddressInfo, new RecordItemIndex(12));
            repo.ComPentairPentairhome.Address.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "100"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "800ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.REMOVEPOOL' at Center", repo.ComPentairPentairhome.REMOVEPOOLInfo, new RecordItemIndex(13));
            repo.ComPentairPentairhome.REMOVEPOOL.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(14));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.RCTView1' at Center", repo.ComPentairPentairhome.RCTView1Info, new RecordItemIndex(15));
            repo.ComPentairPentairhome.RCTView1.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(16));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
