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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AboutInformation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the AboutInformationRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("8264ebdb-0d57-4db4-9401-5ef68af10f86")]
    public partial class AboutInformationRepository : RepoGenBaseFolder
    {
        static AboutInformationRepository instance = new AboutInformationRepository();
        AboutInformationRepositoryFolders.SnapXUntitledAppFolder _snapxuntitled;
        AboutInformationRepositoryFolders.AboutSNAPXAppFolder _aboutsnapx;

        /// <summary>
        /// Gets the singleton class instance representing the AboutInformationRepository element repository.
        /// </summary>
        [RepositoryFolder("8264ebdb-0d57-4db4-9401-5ef68af10f86")]
        public static AboutInformationRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public AboutInformationRepository() 
            : base("AboutInformationRepository", "/", null, 0, false, "8264ebdb-0d57-4db4-9401-5ef68af10f86", ".\\RepositoryImages\\AboutInformationRepository8264ebdb.rximgres")
        {
            _snapxuntitled = new AboutInformationRepositoryFolders.SnapXUntitledAppFolder(this);
            _aboutsnapx = new AboutInformationRepositoryFolders.AboutSNAPXAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("8264ebdb-0d57-4db4-9401-5ef68af10f86")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SnapXUntitled folder.
        /// </summary>
        [RepositoryFolder("1fd00114-f4e7-43f3-9400-3162767513b6")]
        public virtual AboutInformationRepositoryFolders.SnapXUntitledAppFolder SnapXUntitled
        {
            get { return _snapxuntitled; }
        }

        /// <summary>
        /// The AboutSNAPX folder.
        /// </summary>
        [RepositoryFolder("44b9a994-51bb-4ed2-bdcd-c5aed93e8d89")]
        public virtual AboutInformationRepositoryFolders.AboutSNAPXAppFolder AboutSNAPX
        {
            get { return _aboutsnapx; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class AboutInformationRepositoryFolders
    {
        /// <summary>
        /// The SnapXUntitledAppFolder folder.
        /// </summary>
        [RepositoryFolder("1fd00114-f4e7-43f3-9400-3162767513b6")]
        public partial class SnapXUntitledAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebarInfo;
            RepoItemInfo _measuretextInfo;
            RepoItemInfo _switchtosensorInfo;

            /// <summary>
            /// Creates a new SnapXUntitled  folder.
            /// </summary>
            public SnapXUntitledAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SNAPXUntitled", "/form[@title='SNAP-X - [Untitled]']", parentFolder, 30000, null, true, "1fd00114-f4e7-43f3-9400-3162767513b6", "")
            {
                _titlebarInfo = new RepoItemInfo(this, "TitleBar", "element[@controlid='94']", 30000, null, "8ba74a64-3384-48ed-9e01-f0765c7d519e");
                _measuretextInfo = new RepoItemInfo(this, "MeasureText", "container[@controlid='59648']/form[@title='Untitled']//text[@controlid='2394']", 30000, null, "72a11f55-a704-4c3e-953e-363400002587");
                _switchtosensorInfo = new RepoItemInfo(this, "SwitchToSensor", "container[@controlid='59648']/form[@title='Untitled']/?/?/element[@controlid='59650']/element[@controlid='59648']/toolbar[@controlid='59392']/button[@commandid='40029']", 30000, null, "2040c2b2-d5a8-4756-b628-26d23a154f0d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1fd00114-f4e7-43f3-9400-3162767513b6")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1fd00114-f4e7-43f3-9400-3162767513b6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar item.
            /// </summary>
            [RepositoryItem("8ba74a64-3384-48ed-9e01-f0765c7d519e")]
            public virtual Ranorex.Unknown TitleBar
            {
                get
                {
                    return _titlebarInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The TitleBar item info.
            /// </summary>
            [RepositoryItemInfo("8ba74a64-3384-48ed-9e01-f0765c7d519e")]
            public virtual RepoItemInfo TitleBarInfo
            {
                get
                {
                    return _titlebarInfo;
                }
            }

            /// <summary>
            /// The MeasureText item.
            /// </summary>
            [RepositoryItem("72a11f55-a704-4c3e-953e-363400002587")]
            public virtual Ranorex.Text MeasureText
            {
                get
                {
                    return _measuretextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The MeasureText item info.
            /// </summary>
            [RepositoryItemInfo("72a11f55-a704-4c3e-953e-363400002587")]
            public virtual RepoItemInfo MeasureTextInfo
            {
                get
                {
                    return _measuretextInfo;
                }
            }

            /// <summary>
            /// The SwitchToSensor item.
            /// </summary>
            [RepositoryItem("2040c2b2-d5a8-4756-b628-26d23a154f0d")]
            public virtual Ranorex.Button SwitchToSensor
            {
                get
                {
                    return _switchtosensorInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The SwitchToSensor item info.
            /// </summary>
            [RepositoryItemInfo("2040c2b2-d5a8-4756-b628-26d23a154f0d")]
            public virtual RepoItemInfo SwitchToSensorInfo
            {
                get
                {
                    return _switchtosensorInfo;
                }
            }
        }

        /// <summary>
        /// The AboutSNAPXAppFolder folder.
        /// </summary>
        [RepositoryFolder("44b9a994-51bb-4ed2-bdcd-c5aed93e8d89")]
        public partial class AboutSNAPXAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _textoneInfo;
            RepoItemInfo _texttwoInfo;
            RepoItemInfo _texttwooInfo;
            RepoItemInfo _textthreeInfo;

            /// <summary>
            /// Creates a new AboutSNAPX  folder.
            /// </summary>
            public AboutSNAPXAppFolder(RepoGenBaseFolder parentFolder) :
                    base("AboutSNAPX", "/form[@title='About SNAP-X']", parentFolder, 30000, null, true, "44b9a994-51bb-4ed2-bdcd-c5aed93e8d89", "")
            {
                _textoneInfo = new RepoItemInfo(this, "TextOne", "text[@controlid='1928']", 30000, null, "9c6a0375-e3c2-438b-9e1f-b6b384a05c10");
                _texttwoInfo = new RepoItemInfo(this, "TextTwo", "text[@controlid='3211']", 30000, null, "fc4e4729-c004-4877-b350-0a931aa9512a");
                _texttwooInfo = new RepoItemInfo(this, "TextTwoo", "text[@controlid='3212']", 30000, null, "6fb24ffd-65fa-41fb-a945-7e9517b2e1cd");
                _textthreeInfo = new RepoItemInfo(this, "TextThree", "text[@controlid='3208']", 30000, null, "c1807826-7376-4999-b239-54f5f5f8dfd2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("44b9a994-51bb-4ed2-bdcd-c5aed93e8d89")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("44b9a994-51bb-4ed2-bdcd-c5aed93e8d89")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TextOne item.
            /// </summary>
            [RepositoryItem("9c6a0375-e3c2-438b-9e1f-b6b384a05c10")]
            public virtual Ranorex.Text TextOne
            {
                get
                {
                    return _textoneInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TextOne item info.
            /// </summary>
            [RepositoryItemInfo("9c6a0375-e3c2-438b-9e1f-b6b384a05c10")]
            public virtual RepoItemInfo TextOneInfo
            {
                get
                {
                    return _textoneInfo;
                }
            }

            /// <summary>
            /// The TextTwo item.
            /// </summary>
            [RepositoryItem("fc4e4729-c004-4877-b350-0a931aa9512a")]
            public virtual Ranorex.Text TextTwo
            {
                get
                {
                    return _texttwoInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TextTwo item info.
            /// </summary>
            [RepositoryItemInfo("fc4e4729-c004-4877-b350-0a931aa9512a")]
            public virtual RepoItemInfo TextTwoInfo
            {
                get
                {
                    return _texttwoInfo;
                }
            }

            /// <summary>
            /// The TextTwoo item.
            /// </summary>
            [RepositoryItem("6fb24ffd-65fa-41fb-a945-7e9517b2e1cd")]
            public virtual Ranorex.Text TextTwoo
            {
                get
                {
                    return _texttwooInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TextTwoo item info.
            /// </summary>
            [RepositoryItemInfo("6fb24ffd-65fa-41fb-a945-7e9517b2e1cd")]
            public virtual RepoItemInfo TextTwooInfo
            {
                get
                {
                    return _texttwooInfo;
                }
            }

            /// <summary>
            /// The TextThree item.
            /// </summary>
            [RepositoryItem("c1807826-7376-4999-b239-54f5f5f8dfd2")]
            public virtual Ranorex.Text TextThree
            {
                get
                {
                    return _textthreeInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TextThree item info.
            /// </summary>
            [RepositoryItemInfo("c1807826-7376-4999-b239-54f5f5f8dfd2")]
            public virtual RepoItemInfo TextThreeInfo
            {
                get
                {
                    return _textthreeInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}