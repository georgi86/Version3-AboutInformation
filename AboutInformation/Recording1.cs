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
using System.IO;

namespace AboutInformation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("af1d782a-97a0-47db-8462-5b04891bf21d", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AboutInformationRepository repository.
        /// </summary>
        public static AboutInformationRepository repo = AboutInformationRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            string strBigModeCaptionText = "Measure";

            bool bBigMode = true;

            try
            {
                Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.MeasureText' at Center.", repo.SnapXUntitled.MeasureTextInfo, new RecordItemIndex(0));
                repo.SnapXUntitled.MeasureText.MoveTo();
                Delay.Milliseconds(200);

                bBigMode = repo.SnapXUntitled.MeasureText.TextValue.CompareTo(strBigModeCaptionText) == 0 && repo.SnapXUntitled.MeasureText.Visible;
            }
            catch (Exception ex)
            {

            }

            if (!bBigMode)

                repo.SnapXUntitled.SwitchToSensor.Click();
                Delay.Milliseconds(200);                        
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at Center.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(2));
            repo.SnapXUntitled.TitleBar.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(3));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'h'.", new RecordItemIndex(4));
            Keyboard.Press("h");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'a'.", new RecordItemIndex(5));
            Keyboard.Press("a");
            Delay.Milliseconds(0);

                        
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AboutSNAPX.TextOne' at Center.", repo.AboutSNAPX.TextOneInfo, new RecordItemIndex(6));
            repo.AboutSNAPX.TextOne.Click();
            Delay.Milliseconds(200);

            string strCheckOne = repo.AboutSNAPX.TextOne.TextValue;
            string strHardcodedCheckOne = "SNAP-X For Windows\nVersion 2.09.14 Apr 30 2018 \nDatabase Version: 101\nSerial Number #SFD2001052\nCPU: 7.22; TruLight: Firmware Revision A\r\n\nCSB: Yes (newer)\nVideo board: Pylon Camera\nSentinel ID: 9096EE9F-6BF57B2D-0F2C1BED-2296D25F";

            UtilityRun.ComparingText(strCheckOne, strHardcodedCheckOne);
            Delay.Milliseconds(200);
            

            //repo.AboutSNAPX.TextTwo.TextValue
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AboutSNAPX.TextTwo' at Center.", repo.AboutSNAPX.TextTwoInfo, new RecordItemIndex(7));
            repo.AboutSNAPX.TextTwo.Click();

            string strCheckTwo = repo.AboutSNAPX.TextTwo.TextValue;
            string strHardcodedCheckTwo = "For license renewal:";

            UtilityRun.ComparingText(strCheckTwo, strHardcodedCheckTwo);
            Delay.Milliseconds(200);


            //repo.AboutSNAPX.TextTwoo.TextValue
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AboutSNAPX.TextTwoo' at Center.", repo.AboutSNAPX.TextTwooInfo, new RecordItemIndex(8));
            repo.AboutSNAPX.TextTwoo.MoveTo();

            string strCheckSecondTwo = repo.AboutSNAPX.TextTwoo.TextValue;
            string strCheckHardcodedSecondTwo = "www.qvii.com/renew";

            UtilityRun.ComparingText(strCheckSecondTwo, strCheckHardcodedSecondTwo);
            Delay.Milliseconds(200);


            //repo.AboutSNAPX.TextThree.TextValue
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AboutSNAPX.TextThree' at Center.", repo.AboutSNAPX.TextThreeInfo, new RecordItemIndex(9));
            repo.AboutSNAPX.TextThree.Click();

            string strCheckThree = repo.AboutSNAPX.TextThree.TextValue;
            string strHardcodedCheckThree = "Copyright © 2001 - 2018 by Quality Vision International, Inc.\nAll Rights Reserved.";

            UtilityCopyRight.CopyRightText(strCheckThree, strHardcodedCheckThree);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(10));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
