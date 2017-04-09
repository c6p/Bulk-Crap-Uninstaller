﻿using System.ComponentModel;
using System.Windows.Forms;
using BrightIdeasSoftware;
using BulkCrapUninstaller.Controls;
using BulkCrapUninstaller.Functions.Tracking;

namespace BulkCrapUninstaller.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.advancedFilters1 = new BulkCrapUninstaller.Controls.AdvancedFilters();
            this.listViewPanel = new System.Windows.Forms.Panel();
            this.uninstallerObjectListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnDisplayName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPublisher = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnRating = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDisplayVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnInstallDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnStartup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIs64 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnUninstallString = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAbout = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnInstallSource = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnInstallLocation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnUninstallerKind = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSystemComponent = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProtected = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnRegistryKeyName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnGuid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnQuietUninstallString = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSelAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelNone = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelInv = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonWindowSearcher = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUninstall = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonProperties = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.donateButton = new System.Windows.Forms.ToolStripStatusLabel();
            this.settingsSidebarPanel = new System.Windows.Forms.Panel();
            this.propertiesSidebar = new BulkCrapUninstaller.Controls.PropertiesSidebar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdvFiltering = new System.Windows.Forms.Button();
            this.filterEditor1 = new UninstallTools.Controls.FilterEditor();
            this.uninstallListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uninstallContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quietUninstallContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualUninstallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallUsingMsiExecContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiInstallContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiUninstallContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiQuietUninstallContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToClipboardContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.fullInformationCopyContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programNameCopyContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUIDProductCodeCopyContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullRegistryPathCopyContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallStringCopyContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRegistryEntryContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.openInExplorerContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installLocationOpenInExplorerContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallerLocationOpenInExplorerContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceLocationOpenInExplorerContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWebPageContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookUpOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.rateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadUninstallersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadUninstallerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showColorLegendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStatusbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.useSystemThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.addWindowsFeaturesToTheListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWindowsStoreAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findByWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quietUninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedClipCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.copyFullInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alternativeToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualUninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiUninstalltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableAutostartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.createBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openKeyInRegeditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanUpProgramFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStartupManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallFromDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.openProgramsAndFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSystemRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSetupWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallBCUninstallToolstripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBackupFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.globalHotkeys1 = new Klocman.Subsystems.GlobalHotkeys();
            this.splashScreen1 = new Klocman.Forms.SplashScreen();
            this.usageTracker = new BulkCrapUninstaller.Functions.Tracking.UsageTracker();
            this.viewUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.listViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uninstallerObjectListView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.settingsSidebarPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.uninstallListContextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.advancedFilters1);
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewPanel);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            // 
            // advancedFilters1
            // 
            resources.ApplyResources(this.advancedFilters1, "advancedFilters1");
            this.advancedFilters1.Name = "advancedFilters1";
            // 
            // listViewPanel
            // 
            this.listViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPanel.Controls.Add(this.uninstallerObjectListView);
            resources.ApplyResources(this.listViewPanel, "listViewPanel");
            this.listViewPanel.Name = "listViewPanel";
            // 
            // uninstallerObjectListView
            // 
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnDisplayName);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnPublisher);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnRating);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnDisplayVersion);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnInstallDate);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnSize);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnStartup);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnIs64);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnUninstallString);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnAbout);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnInstallSource);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnInstallLocation);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnUninstallerKind);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnSystemComponent);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnProtected);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnRegistryKeyName);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnGuid);
            this.uninstallerObjectListView.AllColumns.Add(this.olvColumnQuietUninstallString);
            this.uninstallerObjectListView.AllowColumnReorder = true;
            this.uninstallerObjectListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uninstallerObjectListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.uninstallerObjectListView.CellEditUseWholeCell = false;
            this.uninstallerObjectListView.CheckBoxes = true;
            this.uninstallerObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnDisplayName,
            this.olvColumnPublisher,
            this.olvColumnRating,
            this.olvColumnDisplayVersion,
            this.olvColumnInstallDate,
            this.olvColumnSize,
            this.olvColumnStartup,
            this.olvColumnIs64,
            this.olvColumnUninstallString,
            this.olvColumnAbout,
            this.olvColumnInstallSource,
            this.olvColumnInstallLocation,
            this.olvColumnUninstallerKind,
            this.olvColumnSystemComponent,
            this.olvColumnProtected,
            this.olvColumnRegistryKeyName,
            this.olvColumnGuid,
            this.olvColumnQuietUninstallString});
            this.uninstallerObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.uninstallerObjectListView, "uninstallerObjectListView");
            this.uninstallerObjectListView.FullRowSelect = true;
            this.uninstallerObjectListView.GridLines = true;
            this.uninstallerObjectListView.HideSelection = false;
            this.uninstallerObjectListView.Name = "uninstallerObjectListView";
            this.uninstallerObjectListView.ShowGroups = false;
            this.uninstallerObjectListView.ShowImagesOnSubItems = true;
            this.uninstallerObjectListView.ShowItemToolTips = true;
            this.uninstallerObjectListView.SortGroupItemsByPrimaryColumn = false;
            this.uninstallerObjectListView.UseCompatibleStateImageBehavior = false;
            this.uninstallerObjectListView.UseFilterIndicator = true;
            this.uninstallerObjectListView.UseHyperlinks = true;
            this.uninstallerObjectListView.View = System.Windows.Forms.View.Details;
            this.uninstallerObjectListView.VirtualMode = true;
            this.uninstallerObjectListView.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.uninstallerObjectListView_CellEditStarting);
            this.uninstallerObjectListView.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.uninstallerObjectListView_CellRightClick);
            this.uninstallerObjectListView.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.RefreshStatusbarTotalLabel);
            this.uninstallerObjectListView.SelectionChanged += new System.EventHandler(this.uninstallerObjectListView_SelectedChanged);
            this.uninstallerObjectListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.uninstallerObjectListView_SelectedChanged);
            this.uninstallerObjectListView.Click += new System.EventHandler(this.uninstallerObjectListView_Click);
            this.uninstallerObjectListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uninstallerObjectListView_KeyDown);
            this.uninstallerObjectListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleListViewMenuKeystroke);
            // 
            // olvColumnDisplayName
            // 
            this.olvColumnDisplayName.Hideable = false;
            resources.ApplyResources(this.olvColumnDisplayName, "olvColumnDisplayName");
            // 
            // olvColumnPublisher
            // 
            resources.ApplyResources(this.olvColumnPublisher, "olvColumnPublisher");
            // 
            // olvColumnRating
            // 
            this.olvColumnRating.IsEditable = false;
            this.olvColumnRating.MaximumWidth = 80;
            this.olvColumnRating.MinimumWidth = 80;
            this.olvColumnRating.Searchable = false;
            resources.ApplyResources(this.olvColumnRating, "olvColumnRating");
            this.olvColumnRating.UseFiltering = false;
            // 
            // olvColumnDisplayVersion
            // 
            resources.ApplyResources(this.olvColumnDisplayVersion, "olvColumnDisplayVersion");
            // 
            // olvColumnInstallDate
            // 
            this.olvColumnInstallDate.IsEditable = false;
            resources.ApplyResources(this.olvColumnInstallDate, "olvColumnInstallDate");
            // 
            // olvColumnSize
            // 
            this.olvColumnSize.Searchable = false;
            resources.ApplyResources(this.olvColumnSize, "olvColumnSize");
            // 
            // olvColumnStartup
            // 
            this.olvColumnStartup.AspectName = "";
            resources.ApplyResources(this.olvColumnStartup, "olvColumnStartup");
            // 
            // olvColumnIs64
            // 
            this.olvColumnIs64.AspectName = "Is64Bit";
            resources.ApplyResources(this.olvColumnIs64, "olvColumnIs64");
            // 
            // olvColumnUninstallString
            // 
            resources.ApplyResources(this.olvColumnUninstallString, "olvColumnUninstallString");
            // 
            // olvColumnAbout
            // 
            this.olvColumnAbout.Hyperlink = true;
            this.olvColumnAbout.IsEditable = false;
            resources.ApplyResources(this.olvColumnAbout, "olvColumnAbout");
            // 
            // olvColumnInstallSource
            // 
            resources.ApplyResources(this.olvColumnInstallSource, "olvColumnInstallSource");
            // 
            // olvColumnInstallLocation
            // 
            resources.ApplyResources(this.olvColumnInstallLocation, "olvColumnInstallLocation");
            // 
            // olvColumnUninstallerKind
            // 
            resources.ApplyResources(this.olvColumnUninstallerKind, "olvColumnUninstallerKind");
            // 
            // olvColumnSystemComponent
            // 
            resources.ApplyResources(this.olvColumnSystemComponent, "olvColumnSystemComponent");
            // 
            // olvColumnProtected
            // 
            this.olvColumnProtected.AspectName = "IsProtected";
            resources.ApplyResources(this.olvColumnProtected, "olvColumnProtected");
            // 
            // olvColumnRegistryKeyName
            // 
            resources.ApplyResources(this.olvColumnRegistryKeyName, "olvColumnRegistryKeyName");
            // 
            // olvColumnGuid
            // 
            resources.ApplyResources(this.olvColumnGuid, "olvColumnGuid");
            // 
            // olvColumnQuietUninstallString
            // 
            resources.ApplyResources(this.olvColumnQuietUninstallString, "olvColumnQuietUninstallString");
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(22, 22);
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator22,
            this.toolStripButtonSelAll,
            this.toolStripButtonSelNone,
            this.toolStripButtonSelInv,
            this.toolStripSeparator23,
            this.toolStripButtonWindowSearcher,
            this.toolStripSeparator21,
            this.toolStripButtonUninstall,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButtonProperties,
            this.toolStripSeparator24,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.TabStop = true;
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ReloadUninstallers);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            resources.ApplyResources(this.toolStripSeparator22, "toolStripSeparator22");
            // 
            // toolStripButtonSelAll
            // 
            this.toolStripButtonSelAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonSelAll, "toolStripButtonSelAll");
            this.toolStripButtonSelAll.Name = "toolStripButtonSelAll";
            // 
            // toolStripButtonSelNone
            // 
            this.toolStripButtonSelNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonSelNone, "toolStripButtonSelNone");
            this.toolStripButtonSelNone.Name = "toolStripButtonSelNone";
            // 
            // toolStripButtonSelInv
            // 
            this.toolStripButtonSelInv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonSelInv, "toolStripButtonSelInv");
            this.toolStripButtonSelInv.Name = "toolStripButtonSelInv";
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            resources.ApplyResources(this.toolStripSeparator23, "toolStripSeparator23");
            // 
            // toolStripButtonWindowSearcher
            // 
            this.toolStripButtonWindowSearcher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonWindowSearcher.Image = global::BulkCrapUninstaller.Properties.Resources.centerline;
            resources.ApplyResources(this.toolStripButtonWindowSearcher, "toolStripButtonWindowSearcher");
            this.toolStripButtonWindowSearcher.Name = "toolStripButtonWindowSearcher";
            this.toolStripButtonWindowSearcher.Click += new System.EventHandler(this.OpenWindowSearcher);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            resources.ApplyResources(this.toolStripSeparator21, "toolStripSeparator21");
            // 
            // toolStripButtonUninstall
            // 
            resources.ApplyResources(this.toolStripButtonUninstall, "toolStripButtonUninstall");
            this.toolStripButtonUninstall.Name = "toolStripButtonUninstall";
            this.toolStripButtonUninstall.Click += new System.EventHandler(this.RunLoudUninstall);
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.RunQuietUninstall);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // toolStripButtonProperties
            // 
            this.toolStripButtonProperties.Image = global::BulkCrapUninstaller.Properties.Resources.properties;
            resources.ApplyResources(this.toolStripButtonProperties, "toolStripButtonProperties");
            this.toolStripButtonProperties.Name = "toolStripButtonProperties";
            this.toolStripButtonProperties.Click += new System.EventHandler(this.OpenProperties);
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            resources.ApplyResources(this.toolStripSeparator24, "toolStripSeparator24");
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::BulkCrapUninstaller.Properties.Resources.settings;
            resources.ApplyResources(this.toolStripButton7, "toolStripButton7");
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::BulkCrapUninstaller.Properties.Resources.information_circle;
            resources.ApplyResources(this.toolStripButton8, "toolStripButton8");
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.openHelpToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelStatus,
            this.toolStripLabelSize,
            this.toolStripLabelTotal,
            this.donateButton});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // toolStripLabelStatus
            // 
            this.toolStripLabelStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripLabelStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripLabelStatus.Name = "toolStripLabelStatus";
            resources.ApplyResources(this.toolStripLabelStatus, "toolStripLabelStatus");
            this.toolStripLabelStatus.Spring = true;
            this.toolStripLabelStatus.TextChanged += new System.EventHandler(this.toolStripLabelStatus_TextChanged);
            // 
            // toolStripLabelSize
            // 
            resources.ApplyResources(this.toolStripLabelSize, "toolStripLabelSize");
            this.toolStripLabelSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripLabelSize.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripLabelSize.Name = "toolStripLabelSize";
            // 
            // toolStripLabelTotal
            // 
            resources.ApplyResources(this.toolStripLabelTotal, "toolStripLabelTotal");
            this.toolStripLabelTotal.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripLabelTotal.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripLabelTotal.Name = "toolStripLabelTotal";
            // 
            // donateButton
            // 
            resources.ApplyResources(this.donateButton, "donateButton");
            this.donateButton.BackgroundImage = global::BulkCrapUninstaller.Properties.Resources.donate_button;
            this.donateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.donateButton.IsLink = true;
            this.donateButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 2);
            this.donateButton.Name = "donateButton";
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // settingsSidebarPanel
            // 
            resources.ApplyResources(this.settingsSidebarPanel, "settingsSidebarPanel");
            this.settingsSidebarPanel.Controls.Add(this.propertiesSidebar);
            this.settingsSidebarPanel.Controls.Add(this.label1);
            this.settingsSidebarPanel.Controls.Add(this.groupBox1);
            this.settingsSidebarPanel.Name = "settingsSidebarPanel";
            // 
            // propertiesSidebar
            // 
            resources.ApplyResources(this.propertiesSidebar, "propertiesSidebar");
            this.propertiesSidebar.InvalidEnabled = true;
            this.propertiesSidebar.Name = "propertiesSidebar";
            this.propertiesSidebar.OrphansEnabled = true;
            this.propertiesSidebar.ProtectedEnabled = true;
            this.propertiesSidebar.StoreAppsEnabled = true;
            this.propertiesSidebar.SysCompEnabled = true;
            this.propertiesSidebar.UpdatesEnabled = true;
            this.propertiesSidebar.WinFeaturesEnabled = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.buttonAdvFiltering);
            this.groupBox1.Controls.Add(this.filterEditor1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // buttonAdvFiltering
            // 
            resources.ApplyResources(this.buttonAdvFiltering, "buttonAdvFiltering");
            this.buttonAdvFiltering.Name = "buttonAdvFiltering";
            this.buttonAdvFiltering.UseVisualStyleBackColor = true;
            this.buttonAdvFiltering.Click += new System.EventHandler(this.buttonAdvFiltering_Click);
            // 
            // filterEditor1
            // 
            resources.ApplyResources(this.filterEditor1, "filterEditor1");
            this.filterEditor1.Name = "filterEditor1";
            this.filterEditor1.ShowAsSearch = true;
            // 
            // uninstallListContextMenuStrip
            // 
            this.uninstallListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uninstallContextMenuStripItem,
            this.quietUninstallContextMenuStripItem,
            this.manualUninstallToolStripMenuItem1,
            this.uninstallUsingMsiExecContextMenuStripItem,
            this.toolStripSeparator3,
            this.runToolStripMenuItem,
            this.toolStripSeparator8,
            this.copyToClipboardContextMenuStripItem,
            this.deleteRegistryEntryContextMenuStripItem,
            this.renameContextMenuStripItem,
            this.toolStripSeparator6,
            this.openInExplorerContextMenuStripItem,
            this.openWebPageContextMenuStripItem,
            this.lookUpOnlineToolStripMenuItem,
            this.rateToolStripMenuItem,
            this.toolStripSeparator7,
            this.propertiesContextMenuStripItem});
            this.uninstallListContextMenuStrip.Name = "uninstallListContextMenuStrip";
            resources.ApplyResources(this.uninstallListContextMenuStrip, "uninstallListContextMenuStrip");
            this.uninstallListContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.UpdateUninstallListContextMenuStrip);
            // 
            // uninstallContextMenuStripItem
            // 
            resources.ApplyResources(this.uninstallContextMenuStripItem, "uninstallContextMenuStripItem");
            this.uninstallContextMenuStripItem.Name = "uninstallContextMenuStripItem";
            this.uninstallContextMenuStripItem.Click += new System.EventHandler(this.RunLoudUninstall);
            // 
            // quietUninstallContextMenuStripItem
            // 
            resources.ApplyResources(this.quietUninstallContextMenuStripItem, "quietUninstallContextMenuStripItem");
            this.quietUninstallContextMenuStripItem.Name = "quietUninstallContextMenuStripItem";
            this.quietUninstallContextMenuStripItem.Click += new System.EventHandler(this.RunQuietUninstall);
            // 
            // manualUninstallToolStripMenuItem1
            // 
            this.manualUninstallToolStripMenuItem1.Name = "manualUninstallToolStripMenuItem1";
            resources.ApplyResources(this.manualUninstallToolStripMenuItem1, "manualUninstallToolStripMenuItem1");
            this.manualUninstallToolStripMenuItem1.Click += new System.EventHandler(this.RunAdvancedUninstall);
            // 
            // uninstallUsingMsiExecContextMenuStripItem
            // 
            this.uninstallUsingMsiExecContextMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiInstallContextMenuStripItem,
            this.msiUninstallContextMenuStripItem,
            this.msiQuietUninstallContextMenuStripItem});
            this.uninstallUsingMsiExecContextMenuStripItem.Name = "uninstallUsingMsiExecContextMenuStripItem";
            resources.ApplyResources(this.uninstallUsingMsiExecContextMenuStripItem, "uninstallUsingMsiExecContextMenuStripItem");
            // 
            // msiInstallContextMenuStripItem
            // 
            this.msiInstallContextMenuStripItem.Name = "msiInstallContextMenuStripItem";
            resources.ApplyResources(this.msiInstallContextMenuStripItem, "msiInstallContextMenuStripItem");
            this.msiInstallContextMenuStripItem.Click += new System.EventHandler(this.msiInstallContextMenuStripItem_Click);
            // 
            // msiUninstallContextMenuStripItem
            // 
            this.msiUninstallContextMenuStripItem.Name = "msiUninstallContextMenuStripItem";
            resources.ApplyResources(this.msiUninstallContextMenuStripItem, "msiUninstallContextMenuStripItem");
            this.msiUninstallContextMenuStripItem.Click += new System.EventHandler(this.msiUninstallContextMenuStripItem_Click);
            // 
            // msiQuietUninstallContextMenuStripItem
            // 
            this.msiQuietUninstallContextMenuStripItem.Name = "msiQuietUninstallContextMenuStripItem";
            resources.ApplyResources(this.msiQuietUninstallContextMenuStripItem, "msiQuietUninstallContextMenuStripItem");
            this.msiQuietUninstallContextMenuStripItem.Click += new System.EventHandler(this.msiQuietUninstallContextMenuStripItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            resources.ApplyResources(this.runToolStripMenuItem, "runToolStripMenuItem");
            this.runToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.runToolStripMenuItem_DropDownItemClicked);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // copyToClipboardContextMenuStripItem
            // 
            this.copyToClipboardContextMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripSeparator9,
            this.fullInformationCopyContextMenuStripItem,
            this.programNameCopyContextMenuStripItem,
            this.gUIDProductCodeCopyContextMenuStripItem,
            this.fullRegistryPathCopyContextMenuStripItem,
            this.uninstallStringCopyContextMenuStripItem});
            resources.ApplyResources(this.copyToClipboardContextMenuStripItem, "copyToClipboardContextMenuStripItem");
            this.copyToClipboardContextMenuStripItem.Name = "copyToClipboardContextMenuStripItem";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            this.toolStripMenuItem9.Click += new System.EventHandler(this.OpenAdvancedClipboardCopy);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // fullInformationCopyContextMenuStripItem
            // 
            this.fullInformationCopyContextMenuStripItem.Name = "fullInformationCopyContextMenuStripItem";
            resources.ApplyResources(this.fullInformationCopyContextMenuStripItem, "fullInformationCopyContextMenuStripItem");
            this.fullInformationCopyContextMenuStripItem.Click += new System.EventHandler(this.ClipboardCopyFullInformation);
            // 
            // programNameCopyContextMenuStripItem
            // 
            this.programNameCopyContextMenuStripItem.Name = "programNameCopyContextMenuStripItem";
            resources.ApplyResources(this.programNameCopyContextMenuStripItem, "programNameCopyContextMenuStripItem");
            this.programNameCopyContextMenuStripItem.Click += new System.EventHandler(this.ClipboardCopyProgramName);
            // 
            // gUIDProductCodeCopyContextMenuStripItem
            // 
            this.gUIDProductCodeCopyContextMenuStripItem.Name = "gUIDProductCodeCopyContextMenuStripItem";
            resources.ApplyResources(this.gUIDProductCodeCopyContextMenuStripItem, "gUIDProductCodeCopyContextMenuStripItem");
            this.gUIDProductCodeCopyContextMenuStripItem.Click += new System.EventHandler(this.ClipboardCopyGuids);
            // 
            // fullRegistryPathCopyContextMenuStripItem
            // 
            this.fullRegistryPathCopyContextMenuStripItem.Name = "fullRegistryPathCopyContextMenuStripItem";
            resources.ApplyResources(this.fullRegistryPathCopyContextMenuStripItem, "fullRegistryPathCopyContextMenuStripItem");
            this.fullRegistryPathCopyContextMenuStripItem.Click += new System.EventHandler(this.ClipboardCopyRegistryPath);
            // 
            // uninstallStringCopyContextMenuStripItem
            // 
            this.uninstallStringCopyContextMenuStripItem.Name = "uninstallStringCopyContextMenuStripItem";
            resources.ApplyResources(this.uninstallStringCopyContextMenuStripItem, "uninstallStringCopyContextMenuStripItem");
            this.uninstallStringCopyContextMenuStripItem.Click += new System.EventHandler(this.ClipboardCopyUninstallString);
            // 
            // deleteRegistryEntryContextMenuStripItem
            // 
            this.deleteRegistryEntryContextMenuStripItem.Name = "deleteRegistryEntryContextMenuStripItem";
            resources.ApplyResources(this.deleteRegistryEntryContextMenuStripItem, "deleteRegistryEntryContextMenuStripItem");
            this.deleteRegistryEntryContextMenuStripItem.Click += new System.EventHandler(this.DeleteRegistryEntries);
            // 
            // renameContextMenuStripItem
            // 
            this.renameContextMenuStripItem.Name = "renameContextMenuStripItem";
            resources.ApplyResources(this.renameContextMenuStripItem, "renameContextMenuStripItem");
            this.renameContextMenuStripItem.Click += new System.EventHandler(this.RenameEntries);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // openInExplorerContextMenuStripItem
            // 
            this.openInExplorerContextMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installLocationOpenInExplorerContextMenuStripItem,
            this.uninstallerLocationOpenInExplorerContextMenuStripItem,
            this.sourceLocationOpenInExplorerContextMenuStripItem});
            resources.ApplyResources(this.openInExplorerContextMenuStripItem, "openInExplorerContextMenuStripItem");
            this.openInExplorerContextMenuStripItem.Name = "openInExplorerContextMenuStripItem";
            // 
            // installLocationOpenInExplorerContextMenuStripItem
            // 
            this.installLocationOpenInExplorerContextMenuStripItem.Name = "installLocationOpenInExplorerContextMenuStripItem";
            resources.ApplyResources(this.installLocationOpenInExplorerContextMenuStripItem, "installLocationOpenInExplorerContextMenuStripItem");
            this.installLocationOpenInExplorerContextMenuStripItem.Click += new System.EventHandler(this.OpenInstallLocation);
            // 
            // uninstallerLocationOpenInExplorerContextMenuStripItem
            // 
            this.uninstallerLocationOpenInExplorerContextMenuStripItem.Name = "uninstallerLocationOpenInExplorerContextMenuStripItem";
            resources.ApplyResources(this.uninstallerLocationOpenInExplorerContextMenuStripItem, "uninstallerLocationOpenInExplorerContextMenuStripItem");
            this.uninstallerLocationOpenInExplorerContextMenuStripItem.Click += new System.EventHandler(this.OpenUninstallerLocation);
            // 
            // sourceLocationOpenInExplorerContextMenuStripItem
            // 
            this.sourceLocationOpenInExplorerContextMenuStripItem.Name = "sourceLocationOpenInExplorerContextMenuStripItem";
            resources.ApplyResources(this.sourceLocationOpenInExplorerContextMenuStripItem, "sourceLocationOpenInExplorerContextMenuStripItem");
            this.sourceLocationOpenInExplorerContextMenuStripItem.Click += new System.EventHandler(this.OpenInstallationSource);
            // 
            // openWebPageContextMenuStripItem
            // 
            this.openWebPageContextMenuStripItem.Name = "openWebPageContextMenuStripItem";
            resources.ApplyResources(this.openWebPageContextMenuStripItem, "openWebPageContextMenuStripItem");
            this.openWebPageContextMenuStripItem.Click += new System.EventHandler(this.OpenAssociatedWebPage);
            // 
            // lookUpOnlineToolStripMenuItem
            // 
            this.lookUpOnlineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem15,
            this.toolStripMenuItem16});
            resources.ApplyResources(this.lookUpOnlineToolStripMenuItem, "lookUpOnlineToolStripMenuItem");
            this.lookUpOnlineToolStripMenuItem.Name = "lookUpOnlineToolStripMenuItem";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            resources.ApplyResources(this.toolStripMenuItem15, "toolStripMenuItem15");
            this.toolStripMenuItem15.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            resources.ApplyResources(this.toolStripMenuItem16, "toolStripMenuItem16");
            this.toolStripMenuItem16.Click += new System.EventHandler(this.alternativeToToolStripMenuItem_Click);
            // 
            // rateToolStripMenuItem
            // 
            this.rateToolStripMenuItem.Image = global::BulkCrapUninstaller.Properties.Resources.star;
            this.rateToolStripMenuItem.Name = "rateToolStripMenuItem";
            resources.ApplyResources(this.rateToolStripMenuItem, "rateToolStripMenuItem");
            this.rateToolStripMenuItem.Click += new System.EventHandler(this.rateToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // propertiesContextMenuStripItem
            // 
            resources.ApplyResources(this.propertiesContextMenuStripItem, "propertiesContextMenuStripItem");
            this.propertiesContextMenuStripItem.Image = global::BulkCrapUninstaller.Properties.Resources.magnifybrowse;
            this.propertiesContextMenuStripItem.Name = "propertiesContextMenuStripItem";
            this.propertiesContextMenuStripItem.Click += new System.EventHandler(this.OpenProperties);
            // 
            // exportDialog
            // 
            this.exportDialog.DefaultExt = "txt";
            this.exportDialog.FileName = "New BCUninstaller Export";
            resources.ApplyResources(this.exportDialog, "exportDialog");
            this.exportDialog.RestoreDirectory = true;
            this.exportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportDialog_FileOk);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.basicOperationsToolStripMenuItem,
            this.advancedOperationsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debugToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadUninstallersToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadUninstallerListToolStripMenuItem,
            this.exportSelectedToolStripMenuItem,
            this.toolStripSeparator10,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            // 
            // reloadUninstallersToolStripMenuItem
            // 
            resources.ApplyResources(this.reloadUninstallersToolStripMenuItem, "reloadUninstallersToolStripMenuItem");
            this.reloadUninstallersToolStripMenuItem.Name = "reloadUninstallersToolStripMenuItem";
            this.reloadUninstallersToolStripMenuItem.Click += new System.EventHandler(this.ReloadUninstallers);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // loadUninstallerListToolStripMenuItem
            // 
            resources.ApplyResources(this.loadUninstallerListToolStripMenuItem, "loadUninstallerListToolStripMenuItem");
            this.loadUninstallerListToolStripMenuItem.Name = "loadUninstallerListToolStripMenuItem";
            this.loadUninstallerListToolStripMenuItem.Click += new System.EventHandler(this.OpenUninstallLists);
            // 
            // exportSelectedToolStripMenuItem
            // 
            this.exportSelectedToolStripMenuItem.Name = "exportSelectedToolStripMenuItem";
            resources.ApplyResources(this.exportSelectedToolStripMenuItem, "exportSelectedToolStripMenuItem");
            this.exportSelectedToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showColorLegendToolStripMenuItem,
            this.displayToolbarToolStripMenuItem,
            this.displayStatusbarToolStripMenuItem,
            this.displaySettingsToolStripMenuItem,
            this.toolStripSeparator12,
            this.useSystemThemeToolStripMenuItem,
            this.toolStripSeparator20,
            this.viewUpdatesToolStripMenuItem,
            this.addWindowsFeaturesToTheListToolStripMenuItem,
            this.viewWindowsStoreAppsToolStripMenuItem,
            this.findByWindowToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // showColorLegendToolStripMenuItem
            // 
            this.showColorLegendToolStripMenuItem.Name = "showColorLegendToolStripMenuItem";
            resources.ApplyResources(this.showColorLegendToolStripMenuItem, "showColorLegendToolStripMenuItem");
            // 
            // displayToolbarToolStripMenuItem
            // 
            this.displayToolbarToolStripMenuItem.Checked = true;
            this.displayToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayToolbarToolStripMenuItem.Name = "displayToolbarToolStripMenuItem";
            resources.ApplyResources(this.displayToolbarToolStripMenuItem, "displayToolbarToolStripMenuItem");
            // 
            // displayStatusbarToolStripMenuItem
            // 
            this.displayStatusbarToolStripMenuItem.Checked = true;
            this.displayStatusbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayStatusbarToolStripMenuItem.Name = "displayStatusbarToolStripMenuItem";
            resources.ApplyResources(this.displayStatusbarToolStripMenuItem, "displayStatusbarToolStripMenuItem");
            // 
            // displaySettingsToolStripMenuItem
            // 
            this.displaySettingsToolStripMenuItem.Checked = true;
            this.displaySettingsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displaySettingsToolStripMenuItem.Name = "displaySettingsToolStripMenuItem";
            resources.ApplyResources(this.displaySettingsToolStripMenuItem, "displaySettingsToolStripMenuItem");
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            // 
            // useSystemThemeToolStripMenuItem
            // 
            this.useSystemThemeToolStripMenuItem.Checked = true;
            this.useSystemThemeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useSystemThemeToolStripMenuItem.Name = "useSystemThemeToolStripMenuItem";
            resources.ApplyResources(this.useSystemThemeToolStripMenuItem, "useSystemThemeToolStripMenuItem");
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            resources.ApplyResources(this.toolStripSeparator20, "toolStripSeparator20");
            // 
            // addWindowsFeaturesToTheListToolStripMenuItem
            // 
            this.addWindowsFeaturesToTheListToolStripMenuItem.Name = "addWindowsFeaturesToTheListToolStripMenuItem";
            resources.ApplyResources(this.addWindowsFeaturesToTheListToolStripMenuItem, "addWindowsFeaturesToTheListToolStripMenuItem");
            this.addWindowsFeaturesToTheListToolStripMenuItem.Click += new System.EventHandler(this.addWindowsFeaturesToTheListToolStripMenuItem_Click);
            // 
            // viewWindowsStoreAppsToolStripMenuItem
            // 
            this.viewWindowsStoreAppsToolStripMenuItem.Name = "viewWindowsStoreAppsToolStripMenuItem";
            resources.ApplyResources(this.viewWindowsStoreAppsToolStripMenuItem, "viewWindowsStoreAppsToolStripMenuItem");
            this.viewWindowsStoreAppsToolStripMenuItem.Click += new System.EventHandler(this.viewWindowsStoreAppsToolStripMenuItem_Click);
            // 
            // findByWindowToolStripMenuItem
            // 
            this.findByWindowToolStripMenuItem.Image = global::BulkCrapUninstaller.Properties.Resources.centerline;
            this.findByWindowToolStripMenuItem.Name = "findByWindowToolStripMenuItem";
            resources.ApplyResources(this.findByWindowToolStripMenuItem, "findByWindowToolStripMenuItem");
            this.findByWindowToolStripMenuItem.Click += new System.EventHandler(this.OpenWindowSearcher);
            // 
            // searchToolStripMenuItem
            // 
            resources.ApplyResources(this.searchToolStripMenuItem, "searchToolStripMenuItem");
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // basicOperationsToolStripMenuItem
            // 
            this.basicOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uninstallToolStripMenuItem,
            this.quietUninstallToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem8,
            this.toolStripMenuItem1,
            this.toolStripMenuItem14,
            this.onlineSearchToolStripMenuItem,
            this.rateToolStripMenuItem1,
            this.toolStripSeparator15,
            this.propertiesToolStripMenuItem});
            resources.ApplyResources(this.basicOperationsToolStripMenuItem, "basicOperationsToolStripMenuItem");
            this.basicOperationsToolStripMenuItem.Name = "basicOperationsToolStripMenuItem";
            this.basicOperationsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.basicOperationsToolStripMenuItem_DropDownOpening);
            // 
            // uninstallToolStripMenuItem
            // 
            resources.ApplyResources(this.uninstallToolStripMenuItem, "uninstallToolStripMenuItem");
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.RunLoudUninstall);
            // 
            // quietUninstallToolStripMenuItem
            // 
            resources.ApplyResources(this.quietUninstallToolStripMenuItem, "quietUninstallToolStripMenuItem");
            this.quietUninstallToolStripMenuItem.Name = "quietUninstallToolStripMenuItem";
            this.quietUninstallToolStripMenuItem.Click += new System.EventHandler(this.RunQuietUninstall);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedClipCopyToolStripMenuItem,
            this.toolStripSeparator11,
            this.copyFullInformationToolStripMenuItem,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            // 
            // advancedClipCopyToolStripMenuItem
            // 
            this.advancedClipCopyToolStripMenuItem.Name = "advancedClipCopyToolStripMenuItem";
            resources.ApplyResources(this.advancedClipCopyToolStripMenuItem, "advancedClipCopyToolStripMenuItem");
            this.advancedClipCopyToolStripMenuItem.Click += new System.EventHandler(this.OpenAdvancedClipboardCopy);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // copyFullInformationToolStripMenuItem
            // 
            this.copyFullInformationToolStripMenuItem.Name = "copyFullInformationToolStripMenuItem";
            resources.ApplyResources(this.copyFullInformationToolStripMenuItem, "copyFullInformationToolStripMenuItem");
            this.copyFullInformationToolStripMenuItem.Click += new System.EventHandler(this.ClipboardCopyFullInformation);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            resources.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
            this.toolStripMenuItem10.Click += new System.EventHandler(this.ClipboardCopyProgramName);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            resources.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
            this.toolStripMenuItem11.Click += new System.EventHandler(this.ClipboardCopyGuids);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
            this.toolStripMenuItem12.Click += new System.EventHandler(this.ClipboardCopyRegistryPath);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            resources.ApplyResources(this.toolStripMenuItem13, "toolStripMenuItem13");
            this.toolStripMenuItem13.Click += new System.EventHandler(this.ClipboardCopyUninstallString);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Click += new System.EventHandler(this.OpenInstallLocation);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Click += new System.EventHandler(this.OpenUninstallerLocation);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.Click += new System.EventHandler(this.OpenInstallationSource);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            resources.ApplyResources(this.toolStripMenuItem14, "toolStripMenuItem14");
            this.toolStripMenuItem14.Click += new System.EventHandler(this.OpenAssociatedWebPage);
            // 
            // onlineSearchToolStripMenuItem
            // 
            this.onlineSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem,
            this.alternativeToToolStripMenuItem});
            resources.ApplyResources(this.onlineSearchToolStripMenuItem, "onlineSearchToolStripMenuItem");
            this.onlineSearchToolStripMenuItem.Name = "onlineSearchToolStripMenuItem";
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            resources.ApplyResources(this.googleToolStripMenuItem, "googleToolStripMenuItem");
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // alternativeToToolStripMenuItem
            // 
            this.alternativeToToolStripMenuItem.Name = "alternativeToToolStripMenuItem";
            resources.ApplyResources(this.alternativeToToolStripMenuItem, "alternativeToToolStripMenuItem");
            this.alternativeToToolStripMenuItem.Click += new System.EventHandler(this.alternativeToToolStripMenuItem_Click);
            // 
            // rateToolStripMenuItem1
            // 
            this.rateToolStripMenuItem1.Image = global::BulkCrapUninstaller.Properties.Resources.star;
            this.rateToolStripMenuItem1.Name = "rateToolStripMenuItem1";
            resources.ApplyResources(this.rateToolStripMenuItem1, "rateToolStripMenuItem1");
            this.rateToolStripMenuItem1.Click += new System.EventHandler(this.rateToolStripMenuItem_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            resources.ApplyResources(this.toolStripSeparator15, "toolStripSeparator15");
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Image = global::BulkCrapUninstaller.Properties.Resources.properties;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            resources.ApplyResources(this.propertiesToolStripMenuItem, "propertiesToolStripMenuItem");
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.OpenProperties);
            // 
            // advancedOperationsToolStripMenuItem
            // 
            this.advancedOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualUninstallToolStripMenuItem,
            this.msiUninstalltoolStripMenuItem,
            this.toolStripSeparator14,
            this.renameToolStripMenuItem,
            this.disableAutostartToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator5,
            this.createBackupToolStripMenuItem,
            this.openKeyInRegeditToolStripMenuItem});
            resources.ApplyResources(this.advancedOperationsToolStripMenuItem, "advancedOperationsToolStripMenuItem");
            this.advancedOperationsToolStripMenuItem.Name = "advancedOperationsToolStripMenuItem";
            this.advancedOperationsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.advancedOperationsToolStripMenuItem_DropDownOpening);
            // 
            // manualUninstallToolStripMenuItem
            // 
            resources.ApplyResources(this.manualUninstallToolStripMenuItem, "manualUninstallToolStripMenuItem");
            this.manualUninstallToolStripMenuItem.Name = "manualUninstallToolStripMenuItem";
            this.manualUninstallToolStripMenuItem.Click += new System.EventHandler(this.RunAdvancedUninstall);
            // 
            // msiUninstalltoolStripMenuItem
            // 
            this.msiUninstalltoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.msiUninstalltoolStripMenuItem.Name = "msiUninstalltoolStripMenuItem";
            resources.ApplyResources(this.msiUninstalltoolStripMenuItem, "msiUninstalltoolStripMenuItem");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.msiInstallContextMenuStripItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Click += new System.EventHandler(this.msiUninstallContextMenuStripItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Click += new System.EventHandler(this.msiQuietUninstallContextMenuStripItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            resources.ApplyResources(this.toolStripSeparator14, "toolStripSeparator14");
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            resources.ApplyResources(this.renameToolStripMenuItem, "renameToolStripMenuItem");
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.RenameEntries);
            // 
            // disableAutostartToolStripMenuItem
            // 
            this.disableAutostartToolStripMenuItem.Name = "disableAutostartToolStripMenuItem";
            resources.ApplyResources(this.disableAutostartToolStripMenuItem, "disableAutostartToolStripMenuItem");
            this.disableAutostartToolStripMenuItem.Click += new System.EventHandler(this.disableAutostartToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteRegistryEntries);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // createBackupToolStripMenuItem
            // 
            this.createBackupToolStripMenuItem.Name = "createBackupToolStripMenuItem";
            resources.ApplyResources(this.createBackupToolStripMenuItem, "createBackupToolStripMenuItem");
            this.createBackupToolStripMenuItem.Click += new System.EventHandler(this.CreateRegistryBackup);
            // 
            // openKeyInRegeditToolStripMenuItem
            // 
            this.openKeyInRegeditToolStripMenuItem.Name = "openKeyInRegeditToolStripMenuItem";
            resources.ApplyResources(this.openKeyInRegeditToolStripMenuItem, "openKeyInRegeditToolStripMenuItem");
            this.openKeyInRegeditToolStripMenuItem.Click += new System.EventHandler(this.OpenInRegedit);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanUpProgramFilesToolStripMenuItem,
            this.openStartupManagerToolStripMenuItem,
            this.uninstallFromDirectoryToolStripMenuItem,
            this.toolStripSeparator13,
            this.openProgramsAndFeaturesToolStripMenuItem,
            this.openSystemRestoreToolStripMenuItem,
            this.toolStripSeparator19,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            this.toolsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.toolsToolStripMenuItem_DropDownOpening);
            // 
            // cleanUpProgramFilesToolStripMenuItem
            // 
            resources.ApplyResources(this.cleanUpProgramFilesToolStripMenuItem, "cleanUpProgramFilesToolStripMenuItem");
            this.cleanUpProgramFilesToolStripMenuItem.Name = "cleanUpProgramFilesToolStripMenuItem";
            this.cleanUpProgramFilesToolStripMenuItem.Click += new System.EventHandler(this.cleanUpProgramFilesToolStripMenuItem_Click);
            // 
            // openStartupManagerToolStripMenuItem
            // 
            resources.ApplyResources(this.openStartupManagerToolStripMenuItem, "openStartupManagerToolStripMenuItem");
            this.openStartupManagerToolStripMenuItem.Name = "openStartupManagerToolStripMenuItem";
            this.openStartupManagerToolStripMenuItem.Click += new System.EventHandler(this.openStartupManagerToolStripMenuItem_Click);
            // 
            // uninstallFromDirectoryToolStripMenuItem
            // 
            this.uninstallFromDirectoryToolStripMenuItem.Image = global::BulkCrapUninstaller.Properties.Resources.layer;
            this.uninstallFromDirectoryToolStripMenuItem.Name = "uninstallFromDirectoryToolStripMenuItem";
            resources.ApplyResources(this.uninstallFromDirectoryToolStripMenuItem, "uninstallFromDirectoryToolStripMenuItem");
            this.uninstallFromDirectoryToolStripMenuItem.Click += new System.EventHandler(this.uninstallFromDirectoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            resources.ApplyResources(this.toolStripSeparator13, "toolStripSeparator13");
            // 
            // openProgramsAndFeaturesToolStripMenuItem
            // 
            this.openProgramsAndFeaturesToolStripMenuItem.Name = "openProgramsAndFeaturesToolStripMenuItem";
            resources.ApplyResources(this.openProgramsAndFeaturesToolStripMenuItem, "openProgramsAndFeaturesToolStripMenuItem");
            this.openProgramsAndFeaturesToolStripMenuItem.Click += new System.EventHandler(this.openProgramsAndFeaturesToolStripMenuItem_Click);
            // 
            // openSystemRestoreToolStripMenuItem
            // 
            this.openSystemRestoreToolStripMenuItem.Name = "openSystemRestoreToolStripMenuItem";
            resources.ApplyResources(this.openSystemRestoreToolStripMenuItem, "openSystemRestoreToolStripMenuItem");
            this.openSystemRestoreToolStripMenuItem.Click += new System.EventHandler(this.openSystemRestoreToolStripMenuItem_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            resources.ApplyResources(this.toolStripSeparator19, "toolStripSeparator19");
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHelpToolStripMenuItem,
            this.startSetupWizardToolStripMenuItem,
            this.toolStripSeparator16,
            this.checkForUpdatesToolStripMenuItem,
            this.submitFeedbackToolStripMenuItem,
            this.toolStripSeparator18,
            this.resetSettingsToolStripMenuItem,
            this.uninstallBCUninstallToolstripMenuItem,
            this.toolStripSeparator17,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownOpening += new System.EventHandler(this.helpToolStripMenuItem_DropDownOpening);
            // 
            // openHelpToolStripMenuItem
            // 
            this.openHelpToolStripMenuItem.Image = global::BulkCrapUninstaller.Properties.Resources.information_circle;
            this.openHelpToolStripMenuItem.Name = "openHelpToolStripMenuItem";
            resources.ApplyResources(this.openHelpToolStripMenuItem, "openHelpToolStripMenuItem");
            this.openHelpToolStripMenuItem.Click += new System.EventHandler(this.openHelpToolStripMenuItem_Click);
            // 
            // startSetupWizardToolStripMenuItem
            // 
            this.startSetupWizardToolStripMenuItem.Name = "startSetupWizardToolStripMenuItem";
            resources.ApplyResources(this.startSetupWizardToolStripMenuItem, "startSetupWizardToolStripMenuItem");
            this.startSetupWizardToolStripMenuItem.Click += new System.EventHandler(this.StartSetupWizard);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            resources.ApplyResources(this.toolStripSeparator16, "toolStripSeparator16");
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            resources.ApplyResources(this.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // submitFeedbackToolStripMenuItem
            // 
            resources.ApplyResources(this.submitFeedbackToolStripMenuItem, "submitFeedbackToolStripMenuItem");
            this.submitFeedbackToolStripMenuItem.Name = "submitFeedbackToolStripMenuItem";
            this.submitFeedbackToolStripMenuItem.Click += new System.EventHandler(this.OpenSubmitFeedbackWindow);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            resources.ApplyResources(this.toolStripSeparator18, "toolStripSeparator18");
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            resources.ApplyResources(this.resetSettingsToolStripMenuItem, "resetSettingsToolStripMenuItem");
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.ResetSettingsDialog);
            // 
            // uninstallBCUninstallToolstripMenuItem
            // 
            this.uninstallBCUninstallToolstripMenuItem.Name = "uninstallBCUninstallToolstripMenuItem";
            resources.ApplyResources(this.uninstallBCUninstallToolstripMenuItem, "uninstallBCUninstallToolstripMenuItem");
            this.uninstallBCUninstallToolstripMenuItem.Click += new System.EventHandler(this.uninstallBCUninstallToolstripMenuItem_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            resources.ApplyResources(this.toolStripSeparator17, "toolStripSeparator17");
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            resources.ApplyResources(this.debugToolStripMenuItem, "debugToolStripMenuItem");
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.OpenDebugWindow);
            // 
            // createBackupFileDialog
            // 
            this.createBackupFileDialog.DefaultExt = "reg";
            this.createBackupFileDialog.FileName = "New Uninstaller Backup";
            resources.ApplyResources(this.createBackupFileDialog, "createBackupFileDialog");
            this.createBackupFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.createBackupFileDialog_FileOk);
            // 
            // globalHotkeys1
            // 
            this.globalHotkeys1.ContainerControl = this;
            this.globalHotkeys1.StopWhenFormIsDisabled = true;
            this.globalHotkeys1.SuppressKeyPresses = true;
            // 
            // splashScreen1
            // 
            this.splashScreen1.AutomaticallyClose = false;
            this.splashScreen1.ContainerControl = this;
            this.splashScreen1.SplashScreenImage = global::BulkCrapUninstaller.Properties.Resources._bcu_logo;
            // 
            // usageTracker
            // 
            this.usageTracker.ContainerControl = this;
            // 
            // viewUpdatesToolStripMenuItem
            // 
            this.viewUpdatesToolStripMenuItem.Name = "viewUpdatesToolStripMenuItem";
            resources.ApplyResources(this.viewUpdatesToolStripMenuItem, "viewUpdatesToolStripMenuItem");
            this.viewUpdatesToolStripMenuItem.Click += new System.EventHandler(this.viewUpdatesToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.settingsSidebarPanel);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.listViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uninstallerObjectListView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.settingsSidebarPanel.ResumeLayout(false);
            this.settingsSidebarPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.uninstallListContextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        internal ObjectListView uninstallerObjectListView;
        internal OLVColumn olvColumnDisplayName;
        internal OLVColumn olvColumnPublisher;
        internal OLVColumn olvColumnDisplayVersion;
        internal OLVColumn olvColumnUninstallString;
        internal OLVColumn olvColumnInstallDate;
        internal OLVColumn olvColumnIs64;
        internal OLVColumn olvColumnGuid;
        internal OLVColumn olvColumnSize;
        internal OLVColumn olvColumnInstallSource;
        internal OLVColumn olvColumnInstallLocation;
        internal OLVColumn olvColumnUninstallerKind;
        internal OLVColumn olvColumnAbout;
        internal OLVColumn olvColumnRegistryKeyName;
        internal OLVColumn olvColumnSystemComponent;
        internal OLVColumn olvColumnQuietUninstallString;
        internal OLVColumn olvColumnProtected;
        private SaveFileDialog exportDialog;
        private ContextMenuStrip uninstallListContextMenuStrip;
        private ToolStripMenuItem uninstallContextMenuStripItem;
        private ToolStripMenuItem propertiesContextMenuStripItem;
        private Panel settingsSidebarPanel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem reloadUninstallersToolStripMenuItem;
        private ToolStripMenuItem exportSelectedToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem displayToolbarToolStripMenuItem;
        private ToolStripMenuItem displaySettingsToolStripMenuItem;
        private ToolStripMenuItem basicOperationsToolStripMenuItem;
        private ToolStripMenuItem quietUninstallToolStripMenuItem;
        private ToolStripMenuItem propertiesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openHelpToolStripMenuItem;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private ToolStripMenuItem resetSettingsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButtonUninstall;
        private ToolStripButton toolStripButtonProperties;
        private Label label1;
        private SaveFileDialog createBackupFileDialog;
        private ToolStripMenuItem quietUninstallContextMenuStripItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem copyToClipboardContextMenuStripItem;
        private ToolStripMenuItem fullInformationCopyContextMenuStripItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem programNameCopyContextMenuStripItem;
        private ToolStripMenuItem gUIDProductCodeCopyContextMenuStripItem;
        private ToolStripMenuItem fullRegistryPathCopyContextMenuStripItem;
        private ToolStripMenuItem uninstallStringCopyContextMenuStripItem;
        private ToolStripMenuItem deleteRegistryEntryContextMenuStripItem;
        private ToolStripMenuItem renameContextMenuStripItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem openInExplorerContextMenuStripItem;
        private ToolStripMenuItem installLocationOpenInExplorerContextMenuStripItem;
        private ToolStripMenuItem uninstallerLocationOpenInExplorerContextMenuStripItem;
        private ToolStripMenuItem sourceLocationOpenInExplorerContextMenuStripItem;
        private ToolStripMenuItem openWebPageContextMenuStripItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem uninstallUsingMsiExecContextMenuStripItem;
        private ToolStripMenuItem msiInstallContextMenuStripItem;
        private ToolStripMenuItem msiUninstallContextMenuStripItem;
        private ToolStripMenuItem msiQuietUninstallContextMenuStripItem;
        private ToolStripMenuItem uninstallToolStripMenuItem;
        private ToolStripMenuItem useSystemThemeToolStripMenuItem;
        private ToolStripMenuItem submitFeedbackToolStripMenuItem;
        private ToolStripMenuItem loadUninstallerListToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem copyFullInformationToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem advancedOperationsToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem msiUninstalltoolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem openKeyInRegeditToolStripMenuItem;
        private ToolStripMenuItem createBackupToolStripMenuItem;
        private ToolStripMenuItem lookUpOnlineToolStripMenuItem;
        private ToolStripMenuItem onlineSearchToolStripMenuItem;
        private PropertiesSidebar propertiesSidebar;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem uninstallBCUninstallToolstripMenuItem;
        private UsageTracker usageTracker;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripLabelStatus;
        private ToolStripStatusLabel toolStripLabelSize;
        private ToolStripStatusLabel toolStripLabelTotal;
        private ToolStripMenuItem displayStatusbarToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem openProgramsAndFeaturesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem manualUninstallToolStripMenuItem1;
        private ToolStripMenuItem manualUninstallToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem startSetupWizardToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator18;
        private ToolStripStatusLabel donateButton;
        private ToolStripSeparator toolStripSeparator19;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem cleanUpProgramFilesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator20;
        private ToolStripMenuItem searchToolStripMenuItem;
        internal Klocman.Subsystems.GlobalHotkeys globalHotkeys1;
        private ToolStripMenuItem showColorLegendToolStripMenuItem;
        private GroupBox groupBox1;
        private ToolStripSeparator toolStripSeparator21;
        private ToolStripButton toolStripButtonSelAll;
        private ToolStripButton toolStripButtonSelInv;
        private ToolStripButton toolStripButtonSelNone;
        private ToolStripSeparator toolStripSeparator22;
        private ToolStripMenuItem openStartupManagerToolStripMenuItem;
        internal OLVColumn olvColumnStartup;
        private Panel listViewPanel;
        private ToolStripMenuItem disableAutostartToolStripMenuItem;
        internal OLVColumn olvColumnRating;
        private ToolStripMenuItem rateToolStripMenuItem;
        private ToolStripMenuItem rateToolStripMenuItem1;
        private ToolStripButton toolStripButtonWindowSearcher;
        private ToolStripSeparator toolStripSeparator23;
        private ToolStripMenuItem findByWindowToolStripMenuItem;
        private ToolStripMenuItem viewWindowsStoreAppsToolStripMenuItem;
        internal UninstallTools.Controls.FilterEditor filterEditor1;
        private Button buttonAdvFiltering;
        private ToolStripSeparator toolStripSeparator24;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private AdvancedFilters advancedFilters1;
        private ToolStripMenuItem advancedClipCopyToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem addWindowsFeaturesToTheListToolStripMenuItem;
        private ToolStripMenuItem uninstallFromDirectoryToolStripMenuItem;
        private ToolStripMenuItem googleToolStripMenuItem;
        private ToolStripMenuItem alternativeToToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem openSystemRestoreToolStripMenuItem;
        private Klocman.Forms.SplashScreen splashScreen1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem viewUpdatesToolStripMenuItem;
    }
}
