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
    ///The Loginn recording.
    /// </summary>
    [TestModule("e9da4b57-cf44-4e8e-9432-bd16a9d669fd", ModuleType.Recording, 1)]
    public partial class Loginn : ITestModule
    {
        /// <summary>
        /// Holds an instance of the IntelliSync_BVTRepository repository.
        /// </summary>
        public static IntelliSync_BVTRepository repo = IntelliSync_BVTRepository.Instance;

        static Loginn instance = new Loginn();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Loginn()
        {
            Email = "qaqa08@mailinator.com";
            Password = "Pentair@123";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Loginn Instance
        {
            get { return instance; }
        }

#region Variables

        string _Email;

        /// <summary>
        /// Gets or sets the value of variable Email.
        /// </summary>
        [TestVariable("c454fe1f-b720-4f06-8a07-c265c44379d4")]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        string _Password;

        /// <summary>
        /// Gets or sets the value of variable Password.
        /// </summary>
        [TestVariable("87a677e7-631b-411e-8c3f-1eb0ca5d74b0")]
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$Email' on item 'ComPentairPentairhome1.LoginTextInputEmail'.", repo.ComPentairPentairhome1.LoginTextInputEmailInfo, new RecordItemIndex(0));
            repo.ComPentairPentairhome1.LoginTextInputEmail.Element.SetAttributeValue("Text", Email);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$Password' on item 'ComPentairPentairhome1.LoginTextInputPassword'.", repo.ComPentairPentairhome1.LoginTextInputPasswordInfo, new RecordItemIndex(2));
            repo.ComPentairPentairhome1.LoginTextInputPassword.Element.SetAttributeValue("Text", Password);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome1.login11' at Center", repo.ComPentairPentairhome1.login11Info, new RecordItemIndex(3));
            repo.ComPentairPentairhome1.login11.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(4));
            Delay.Duration(30000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
