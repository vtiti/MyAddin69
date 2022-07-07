namespace MyAddin69
{
    partial class AddinModule
    {
        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;
 
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FormsManager = new AddinExpress.OL.ADXOlFormsManager(this.components);
            this.Sidebar1 = new AddinExpress.OL.ADXOlFormsCollectionItem(this.components);
            this.Sidebar2 = new AddinExpress.OL.ADXOlFormsCollectionItem(this.components);
            this.Bottombar = new AddinExpress.OL.ADXOlFormsCollectionItem(this.components);
            this.OutlookEvents = new AddinExpress.MSO.ADXOutlookAppEvents(this.components);
            // 
            // FormsManager
            // 
            this.FormsManager.Items.Add(this.Sidebar1);
            this.FormsManager.Items.Add(this.Sidebar2);
            this.FormsManager.Items.Add(this.Bottombar);
            this.FormsManager.SetOwner(this);
            // 
            // Sidebar1
            // 
            this.Sidebar1.Cached = AddinExpress.OL.ADXOlCachingStrategy.OneInstanceForAllFolders;
            this.Sidebar1.ExplorerItemTypes = AddinExpress.OL.ADXOlExplorerItemTypes.olMailItem;
            this.Sidebar1.ExplorerLayout = AddinExpress.OL.ADXOlExplorerLayout.RightReadingPane;
            this.Sidebar1.FormClassName = "MyAddin69.SidebarForm1";
            this.Sidebar1.IsHiddenStateAllowed = false;
            this.Sidebar1.RestoreFromMinimizedState = true;
            this.Sidebar1.UseOfficeThemeForBackground = false;
            // 
            // Sidebar2
            // 
            this.Sidebar2.Cached = AddinExpress.OL.ADXOlCachingStrategy.OneInstanceForAllFolders;
            this.Sidebar2.ExplorerItemTypes = AddinExpress.OL.ADXOlExplorerItemTypes.olMailItem;
            this.Sidebar2.ExplorerLayout = AddinExpress.OL.ADXOlExplorerLayout.RightReadingPane;
            this.Sidebar2.FormClassName = "MyAddin69.SidebarForm2";
            this.Sidebar2.IsHiddenStateAllowed = false;
            this.Sidebar2.RestoreFromMinimizedState = true;
            this.Sidebar2.UseOfficeThemeForBackground = false;
            // 
            // Bottombar
            // 
            this.Bottombar.Cached = AddinExpress.OL.ADXOlCachingStrategy.OneInstanceForAllFolders;
            this.Bottombar.ExplorerItemTypes = AddinExpress.OL.ADXOlExplorerItemTypes.olMailItem;
            this.Bottombar.ExplorerLayout = AddinExpress.OL.ADXOlExplorerLayout.BottomReadingPane;
            this.Bottombar.FormClassName = "MyAddin69.BottombarForm";
            this.Bottombar.IsHiddenStateAllowed = false;
            this.Bottombar.RestoreFromMinimizedState = true;
            this.Bottombar.UseOfficeThemeForBackground = false;
            // 
            // OutlookEvents
            // 
            this.OutlookEvents.NewExplorer += new AddinExpress.MSO.ADXOlExplorer_EventHandler(this.OutlookEvents_NewExplorer);
            this.OutlookEvents.ExplorerFolderSwitch += new AddinExpress.MSO.ADXOlExplorer_EventHandler(this.OutlookEvents_ExplorerFolderSwitch);
            this.OutlookEvents.ExplorerSelectionChange += new AddinExpress.MSO.ADXOlExplorer_EventHandler(this.OutlookEvents_ExplorerSelectionChange);
            this.OutlookEvents.ExplorerInlineResponseEx += new AddinExpress.MSO.ADXOlExplorerInlineResponseEx_EventHandler(this.OutlookEvents_ExplorerInlineResponseEx);
            this.OutlookEvents.ExplorerInlineResponseCloseEx += new AddinExpress.MSO.ADXOlExplorerInlineResponseCloseEx_EventHandler(this.OutlookEvents_ExplorerInlineResponseCloseEx);
            // 
            // AddinModule
            // 
            this.AddinName = "MyAddin69";
            this.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaOutlook;

        }
        #endregion

        private AddinExpress.OL.ADXOlFormsManager FormsManager;
        private AddinExpress.OL.ADXOlFormsCollectionItem Sidebar1;
        private AddinExpress.OL.ADXOlFormsCollectionItem Sidebar2;
        private AddinExpress.OL.ADXOlFormsCollectionItem Bottombar;
        private AddinExpress.MSO.ADXOutlookAppEvents OutlookEvents;
    }
}

