using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddinExpress.MSO;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace MyAddin69
{
    /// <summary>
    ///   Add-in Express Add-in Module
    /// </summary>
    [GuidAttribute("8DA65CFB-ADB1-4176-A99F-42FD53C698E9"), ProgId("MyAddin69.AddinModule")]
    public partial class AddinModule : AddinExpress.MSO.ADXAddinModule
    {
        private bool _inInlineResponseMode;

        public AddinModule()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            // Please add any initialization code to the AddinInitialize event handler
        }
 
        #region Add-in Express automatic code
 
        // Required by Add-in Express - do not modify
        // the methods within this region
 
        public override System.ComponentModel.IContainer GetContainer()
        {
            if (components == null)
                components = new System.ComponentModel.Container();
            return components;
        }
 
        [ComRegisterFunctionAttribute]
        public static void AddinRegister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXRegister(t);
        }
 
        [ComUnregisterFunctionAttribute]
        public static void AddinUnregister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXUnregister(t);
        }
 
        public override void UninstallControls()
        {
            base.UninstallControls();
        }

        #endregion

        public static new AddinModule CurrentInstance 
        {
            get
            {
                return AddinExpress.MSO.ADXAddinModule.CurrentInstance as AddinModule;
            }
        }

        public Outlook._Application OutlookApp
        {
            get
            {
                return (HostApplication as Outlook._Application);
            }
        }

        private void OutlookEvents_ExplorerInlineResponseEx(object sender, object itemObject, object sourceObject)
        {
            _inInlineResponseMode = true;
            UpdateVisibility();
        }

        private void OutlookEvents_ExplorerInlineResponseCloseEx(object sender, object sourceObject)
        {
            _inInlineResponseMode = false;
            UpdateVisibility();
        }

        private void OutlookEvents_ExplorerFolderSwitch(object sender, object explorer)
        {
        }

        private async void OutlookEvents_ExplorerSelectionChange(object sender, object explorer)
        {
            try
            {
                await Task.Delay(1000);
                UpdateVisibility();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void OutlookEvents_NewExplorer(object sender, object explorer)
        {
            _inInlineResponseMode = false;
            UpdateVisibility();
        }

        private void UpdateVisibility()
        {
            try
            {
                if (_inInlineResponseMode)
                {
                    this.Sidebar1.GetCurrentForm()?.Hide();
                    this.Sidebar2.GetCurrentForm()?.Show();
                }
                else
                {
                    this.Sidebar1.GetCurrentForm()?.Show();
                    this.Sidebar2.GetCurrentForm()?.Hide();
                }

                this.Bottombar.GetCurrentForm()?.Hide();
            }
            catch (NullReferenceException e)
            {
                // don't care now
            }

        }
    }
}

