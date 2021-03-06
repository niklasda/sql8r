﻿using System.Drawing;

namespace SQL8r.WinForms.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("MainToolbar");
            Infragistics.Win.UltraWinDock.DockAreaPane dockAreaPane1 = new Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedLeft, new System.Guid("ef936a82-2991-4add-a711-dbfda168db1d"));
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane1 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("751197ae-2391-4a7f-9063-ff0b4a071e1c"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("ef936a82-2991-4add-a711-dbfda168db1d"), -1);
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane2 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("59491827-2d5c-4db5-ad9d-c340def8b20b"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("ef936a82-2991-4add-a711-dbfda168db1d"), -1);
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel1 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel2 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel3 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            this.tvwSqlObjects = new Infragistics.Win.UltraWinTree.UltraTree();
            this.TreeImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsFiles = new System.Windows.Forms.ToolStrip();
            this.tsbNewProject = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenProject = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemoveFile = new System.Windows.Forms.ToolStripButton();
            this.tsbAddFileFolder = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbAddSqlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAddCSharpFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAddVbNetFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddExistingFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tvwProject = new Infragistics.Win.UltraWinTree.UltraTree();
            this.mdiManager = new Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(this.components);
            this._MainForm_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.tbManager = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._MainForm_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._MainForm_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._MainForm_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.dockManager = new Infragistics.Win.UltraWinDock.UltraDockManager(this.components);
            this.MainFormUnpinnedTabAreaLeft = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this.MainFormUnpinnedTabAreaRight = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this.MainFormUnpinnedTabAreaTop = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this.MainFormUnpinnedTabAreaBottom = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this.MainFormAutoHideControl = new Infragistics.Win.UltraWinDock.AutoHideControl();
            this.windowDockingArea1 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
            this.dockableWindow2 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.dockableWindow1 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.sbMain = new Infragistics.Win.UltraWinStatusBar.UltraStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.tvwSqlObjects)).BeginInit();
            this.panel1.SuspendLayout();
            this.tsFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvwProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.windowDockingArea1.SuspendLayout();
            this.dockableWindow2.SuspendLayout();
            this.dockableWindow1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwSqlObjects
            // 
            this.tvwSqlObjects.AllowDrop = true;
            this.tvwSqlObjects.HideSelection = false;
            this.tvwSqlObjects.ImageList = this.TreeImageList;
            this.tvwSqlObjects.Location = new System.Drawing.Point(0, 18);
            this.tvwSqlObjects.Name = "tvwSqlObjects";
            this.tvwSqlObjects.Size = new System.Drawing.Size(218, 448);
            this.tvwSqlObjects.TabIndex = 23;
            // 
            // TreeImageList
            // 
            this.TreeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImageList.ImageStream")));
            this.TreeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeImageList.Images.SetKeyName(0, "closedfolder.png");
            this.TreeImageList.Images.SetKeyName(1, "openfolder.png");
            this.TreeImageList.Images.SetKeyName(2, "delete.png");
            this.TreeImageList.Images.SetKeyName(3, "goldenkey.png");
            this.TreeImageList.Images.SetKeyName(4, "table.png");
            this.TreeImageList.Images.SetKeyName(5, "silverkey.png");
            this.TreeImageList.Images.SetKeyName(6, "screen.png");
            this.TreeImageList.Images.SetKeyName(7, "view.png");
            this.TreeImageList.Images.SetKeyName(8, "edit.png");
            this.TreeImageList.Images.SetKeyName(9, "search.png");
            this.TreeImageList.Images.SetKeyName(10, "bulb.png");
            this.TreeImageList.Images.SetKeyName(11, "23.png");
            this.TreeImageList.Images.SetKeyName(12, "image2.png");
            this.TreeImageList.Images.SetKeyName(13, "CSharp.png");
            this.TreeImageList.Images.SetKeyName(14, "folder.png");
            this.TreeImageList.Images.SetKeyName(15, "sql.png");
            this.TreeImageList.Images.SetKeyName(16, "vb.png");
            this.TreeImageList.Images.SetKeyName(17, "Database1.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tsFiles);
            this.panel1.Controls.Add(this.tvwProject);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 448);
            this.panel1.TabIndex = 23;
            // 
            // tsFiles
            // 
            this.tsFiles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewProject,
            this.tsbOpenProject,
            this.tsbSaveProject,
            this.toolStripSeparator,
            this.tsbRemoveFile,
            this.tsbAddFileFolder});
            this.tsFiles.Location = new System.Drawing.Point(0, 0);
            this.tsFiles.Name = "tsFiles";
            this.tsFiles.Padding = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.tsFiles.Size = new System.Drawing.Size(218, 25);
            this.tsFiles.TabIndex = 0;
            // 
            // tsbNewProject
            // 
            this.tsbNewProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewProject.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewProject.Image")));
            this.tsbNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewProject.Name = "tsbNewProject";
            this.tsbNewProject.Size = new System.Drawing.Size(23, 22);
            this.tsbNewProject.Text = "&New Project";
            // 
            // tsbOpenProject
            // 
            this.tsbOpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenProject.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenProject.Image")));
            this.tsbOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenProject.Name = "tsbOpenProject";
            this.tsbOpenProject.Size = new System.Drawing.Size(23, 22);
            this.tsbOpenProject.Text = "&Open Project";
            // 
            // tsbSaveProject
            // 
            this.tsbSaveProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveProject.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveProject.Image")));
            this.tsbSaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveProject.Name = "tsbSaveProject";
            this.tsbSaveProject.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveProject.Text = "&Save Project";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRemoveFile
            // 
            this.tsbRemoveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveFile.Image")));
            this.tsbRemoveFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbRemoveFile.Name = "tsbRemoveFile";
            this.tsbRemoveFile.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveFile.Text = "Remove File";
            // 
            // tsbAddFileFolder
            // 
            this.tsbAddFileFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddFileFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddSqlFile,
            this.tsbAddCSharpFile,
            this.tsbAddVbNetFile,
            this.tsbAddFolder,
            this.toolStripMenuItem1,
            this.tsbAddExistingFile});
            this.tsbAddFileFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddFileFolder.Image")));
            this.tsbAddFileFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFileFolder.Name = "tsbAddFileFolder";
            this.tsbAddFileFolder.Size = new System.Drawing.Size(32, 22);
            this.tsbAddFileFolder.Text = "Add File/Folder";
            // 
            // tsbAddSqlFile
            // 
            this.tsbAddSqlFile.Image = global::SQL8r.WinForms.Properties.Resources.NewDocumentHS;
            this.tsbAddSqlFile.Name = "tsbAddSqlFile";
            this.tsbAddSqlFile.Size = new System.Drawing.Size(160, 22);
            this.tsbAddSqlFile.Text = "Add SQL File";
            // 
            // tsbAddCSharpFile
            // 
            this.tsbAddCSharpFile.Image = global::SQL8r.WinForms.Properties.Resources.NewDocumentHS;
            this.tsbAddCSharpFile.Name = "tsbAddCSharpFile";
            this.tsbAddCSharpFile.Size = new System.Drawing.Size(160, 22);
            this.tsbAddCSharpFile.Text = "Add C# File";
            // 
            // tsbAddVbNetFile
            // 
            this.tsbAddVbNetFile.Image = global::SQL8r.WinForms.Properties.Resources.NewDocumentHS;
            this.tsbAddVbNetFile.Name = "tsbAddVbNetFile";
            this.tsbAddVbNetFile.Size = new System.Drawing.Size(160, 22);
            this.tsbAddVbNetFile.Text = "Add VB.NET File";
            // 
            // tsbAddFolder
            // 
            this.tsbAddFolder.Image = global::SQL8r.WinForms.Properties.Resources.NewFolderHS;
            this.tsbAddFolder.Name = "tsbAddFolder";
            this.tsbAddFolder.Size = new System.Drawing.Size(160, 22);
            this.tsbAddFolder.Text = "Add Folder";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // tsbAddExistingFile
            // 
            this.tsbAddExistingFile.Image = global::SQL8r.WinForms.Properties.Resources.DocumentHS;
            this.tsbAddExistingFile.Name = "tsbAddExistingFile";
            this.tsbAddExistingFile.Size = new System.Drawing.Size(160, 22);
            this.tsbAddExistingFile.Text = "Add Existing File";
            // 
            // tvwProject
            // 
            this.tvwProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwProject.ColumnSettings.AllowCellEdit = Infragistics.Win.UltraWinTree.AllowCellEdit.Full;
            this.tvwProject.HideSelection = false;
            this.tvwProject.ImageList = this.TreeImageList;
            this.tvwProject.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tvwProject.Location = new System.Drawing.Point(0, 25);
            this.tvwProject.Name = "tvwProject";
            this.tvwProject.Size = new System.Drawing.Size(218, 423);
            this.tvwProject.TabIndex = 23;
            // 
            // mdiManager
            // 
            this.mdiManager.MdiParent = this;
            this.mdiManager.SettingsKey = "MainForm.mdiManager";
            this.mdiManager.ViewStyle = Infragistics.Win.UltraWinTabbedMdi.ViewStyle.Office2007;
            // 
            // _MainForm_Toolbars_Dock_Area_Left
            // 
            this._MainForm_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._MainForm_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._MainForm_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 4;
            this._MainForm_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 51);
            this._MainForm_Toolbars_Dock_Area_Left.Name = "_MainForm_Toolbars_Dock_Area_Left";
            this._MainForm_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(4, 490);
            this._MainForm_Toolbars_Dock_Area_Left.ToolbarsManager = this.tbManager;
            // 
            // tbManager
            // 
            this.tbManager.DesignerFlags = 0;
            this.tbManager.DockWithinContainer = this;
            this.tbManager.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            this.tbManager.FormDisplayStyle = Infragistics.Win.UltraWinToolbars.FormDisplayStyle.RoundedSizable;
            this.tbManager.ImageListSmall = this.TreeImageList;
            this.tbManager.Ribbon.ApplicationMenuButtonImage = ((System.Drawing.Image)(resources.GetObject("tbManager.Ribbon.ApplicationMenuButtonImage")));
            this.tbManager.Ribbon.Caption = "SQL8r 0.17 - BETA - Øredev.org";
            this.tbManager.Ribbon.Visible = true;
            this.tbManager.SettingsKey = "MainForm.tbManager";
            this.tbManager.ShowFullMenusDelay = 500;
            ultraToolbar1.DockedColumn = 0;
            ultraToolbar1.DockedRow = 0;
            ultraToolbar1.Text = "MainToolbar";
            this.tbManager.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar1});
            // 
            // _MainForm_Toolbars_Dock_Area_Right
            // 
            this._MainForm_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._MainForm_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._MainForm_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 4;
            this._MainForm_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(878, 51);
            this._MainForm_Toolbars_Dock_Area_Right.Name = "_MainForm_Toolbars_Dock_Area_Right";
            this._MainForm_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(4, 490);
            this._MainForm_Toolbars_Dock_Area_Right.ToolbarsManager = this.tbManager;
            // 
            // _MainForm_Toolbars_Dock_Area_Top
            // 
            this._MainForm_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._MainForm_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._MainForm_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._MainForm_Toolbars_Dock_Area_Top.Name = "_MainForm_Toolbars_Dock_Area_Top";
            this._MainForm_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(882, 51);
            this._MainForm_Toolbars_Dock_Area_Top.ToolbarsManager = this.tbManager;
            // 
            // _MainForm_Toolbars_Dock_Area_Bottom
            // 
            this._MainForm_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._MainForm_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._MainForm_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 541);
            this._MainForm_Toolbars_Dock_Area_Bottom.Name = "_MainForm_Toolbars_Dock_Area_Bottom";
            this._MainForm_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(882, 0);
            this._MainForm_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.tbManager;
            // 
            // dockManager
            // 
            this.dockManager.CaptionButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton;
            this.dockManager.CaptionStyle = Infragistics.Win.UltraWinDock.CaptionStyle.Office2007;
            dockAreaPane1.ChildPaneStyle = Infragistics.Win.UltraWinDock.ChildPaneStyle.TabGroup;
            dockableControlPane1.Control = this.tvwSqlObjects;
            dockableControlPane1.OriginalControlBounds = new System.Drawing.Rectangle(434, 272, 121, 97);
            dockableControlPane1.Size = new System.Drawing.Size(100, 100);
            dockableControlPane1.Text = "Database";
            dockableControlPane2.Control = this.panel1;
            dockableControlPane2.OriginalControlBounds = new System.Drawing.Rectangle(473, 180, 201, 337);
            appearance27.FontData.BoldAsString = "False";
            dockableControlPane2.Settings.ActiveSlidingGroupAppearance = appearance27;
            dockableControlPane2.Size = new System.Drawing.Size(100, 100);
            dockableControlPane2.Text = "Files";
            dockAreaPane1.Panes.AddRange(new Infragistics.Win.UltraWinDock.DockablePaneBase[] {
            dockableControlPane1,
            dockableControlPane2});
            dockAreaPane1.SelectedTabIndex = 1;
            dockAreaPane1.Size = new System.Drawing.Size(218, 490);
            this.dockManager.DockAreas.AddRange(new Infragistics.Win.UltraWinDock.DockAreaPane[] {
            dockAreaPane1});
            this.dockManager.DragIndicatorStyle = Infragistics.Win.UltraWinDock.DragIndicatorStyle.VisualStudio2008Vista;
            this.dockManager.DragWindowStyle = Infragistics.Win.UltraWinDock.DragWindowStyle.OutlineWithIndicators;
            this.dockManager.HostControl = this;
            this.dockManager.SettingsKey = "MainForm.dockManager";
            this.dockManager.UnpinnedTabStyle = Infragistics.Win.UltraWinTabs.TabStyle.Office2007Ribbon;
            this.dockManager.WindowStyle = Infragistics.Win.UltraWinDock.WindowStyle.Office2007;
            // 
            // MainFormUnpinnedTabAreaLeft
            // 
            this.MainFormUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainFormUnpinnedTabAreaLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormUnpinnedTabAreaLeft.Location = new System.Drawing.Point(4, 51);
            this.MainFormUnpinnedTabAreaLeft.Name = "MainFormUnpinnedTabAreaLeft";
            this.MainFormUnpinnedTabAreaLeft.Owner = this.dockManager;
            this.MainFormUnpinnedTabAreaLeft.Size = new System.Drawing.Size(0, 490);
            this.MainFormUnpinnedTabAreaLeft.TabIndex = 12;
            // 
            // MainFormUnpinnedTabAreaRight
            // 
            this.MainFormUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainFormUnpinnedTabAreaRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormUnpinnedTabAreaRight.Location = new System.Drawing.Point(878, 51);
            this.MainFormUnpinnedTabAreaRight.Name = "MainFormUnpinnedTabAreaRight";
            this.MainFormUnpinnedTabAreaRight.Owner = this.dockManager;
            this.MainFormUnpinnedTabAreaRight.Size = new System.Drawing.Size(0, 490);
            this.MainFormUnpinnedTabAreaRight.TabIndex = 13;
            // 
            // MainFormUnpinnedTabAreaTop
            // 
            this.MainFormUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainFormUnpinnedTabAreaTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormUnpinnedTabAreaTop.Location = new System.Drawing.Point(4, 51);
            this.MainFormUnpinnedTabAreaTop.Name = "MainFormUnpinnedTabAreaTop";
            this.MainFormUnpinnedTabAreaTop.Owner = this.dockManager;
            this.MainFormUnpinnedTabAreaTop.Size = new System.Drawing.Size(874, 0);
            this.MainFormUnpinnedTabAreaTop.TabIndex = 14;
            // 
            // MainFormUnpinnedTabAreaBottom
            // 
            this.MainFormUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainFormUnpinnedTabAreaBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormUnpinnedTabAreaBottom.Location = new System.Drawing.Point(4, 541);
            this.MainFormUnpinnedTabAreaBottom.Name = "MainFormUnpinnedTabAreaBottom";
            this.MainFormUnpinnedTabAreaBottom.Owner = this.dockManager;
            this.MainFormUnpinnedTabAreaBottom.Size = new System.Drawing.Size(874, 0);
            this.MainFormUnpinnedTabAreaBottom.TabIndex = 15;
            // 
            // MainFormAutoHideControl
            // 
            this.MainFormAutoHideControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormAutoHideControl.Location = new System.Drawing.Point(25, 156);
            this.MainFormAutoHideControl.Name = "MainFormAutoHideControl";
            this.MainFormAutoHideControl.Owner = this.dockManager;
            this.MainFormAutoHideControl.Size = new System.Drawing.Size(100, 385);
            this.MainFormAutoHideControl.TabIndex = 16;
            // 
            // windowDockingArea1
            // 
            this.windowDockingArea1.Controls.Add(this.dockableWindow2);
            this.windowDockingArea1.Controls.Add(this.dockableWindow1);
            this.windowDockingArea1.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowDockingArea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowDockingArea1.Location = new System.Drawing.Point(4, 51);
            this.windowDockingArea1.Name = "windowDockingArea1";
            this.windowDockingArea1.Owner = this.dockManager;
            this.windowDockingArea1.Size = new System.Drawing.Size(223, 490);
            this.windowDockingArea1.TabIndex = 17;
            // 
            // dockableWindow2
            // 
            this.dockableWindow2.Controls.Add(this.tvwSqlObjects);
            this.dockableWindow2.Location = new System.Drawing.Point(-10000, 0);
            this.dockableWindow2.Name = "dockableWindow2";
            this.dockableWindow2.Owner = this.dockManager;
            this.dockableWindow2.Size = new System.Drawing.Size(218, 468);
            this.dockableWindow2.TabIndex = 25;
            // 
            // dockableWindow1
            // 
            this.dockableWindow1.Controls.Add(this.panel1);
            this.dockableWindow1.Location = new System.Drawing.Point(0, 0);
            this.dockableWindow1.Name = "dockableWindow1";
            this.dockableWindow1.Owner = this.dockManager;
            this.dockableWindow1.Size = new System.Drawing.Size(218, 468);
            this.dockableWindow1.TabIndex = 26;
            // 
            // sbMain
            // 
            appearance11.BorderColor3DBase = System.Drawing.Color.Black;
            this.sbMain.Appearance = appearance11;
            this.sbMain.Location = new System.Drawing.Point(0, 541);
            this.sbMain.Name = "sbMain";
            ultraStatusPanel1.BorderStyle = Infragistics.Win.UIElementBorderStyle.WindowsVista;
            ultraStatusPanel1.Key = "pCaption";
            ultraStatusPanel1.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.AutoStatusText;
            ultraStatusPanel1.Width = 250;
            ultraStatusPanel2.Key = "pProgress";
            ultraStatusPanel2.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.Progress;
            ultraStatusPanel3.BorderStyle = Infragistics.Win.UIElementBorderStyle.WindowsVista;
            ultraStatusPanel3.Key = "pAuto";
            ultraStatusPanel3.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Spring;
            ultraStatusPanel3.Width = 300;
            this.sbMain.Panels.AddRange(new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel[] {
            ultraStatusPanel1,
            ultraStatusPanel2,
            ultraStatusPanel3});
            this.sbMain.Size = new System.Drawing.Size(882, 23);
            this.sbMain.TabIndex = 23;
            this.sbMain.Text = "ultraStatusBar1";
            this.sbMain.ViewStyle = Infragistics.Win.UltraWinStatusBar.ViewStyle.Office2007;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 564);
            this.Controls.Add(this.MainFormAutoHideControl);
            this.Controls.Add(this.windowDockingArea1);
            this.Controls.Add(this.MainFormUnpinnedTabAreaTop);
            this.Controls.Add(this.MainFormUnpinnedTabAreaBottom);
            this.Controls.Add(this.MainFormUnpinnedTabAreaLeft);
            this.Controls.Add(this.MainFormUnpinnedTabAreaRight);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Top);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Bottom);
            this.Controls.Add(this.sbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "SQL8r";
            ((System.ComponentModel.ISupportInitialize)(this.tvwSqlObjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsFiles.ResumeLayout(false);
            this.tsFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvwProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.windowDockingArea1.ResumeLayout(false);
            this.dockableWindow2.ResumeLayout(false);
            this.dockableWindow1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager mdiManager;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Top;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Bottom;
        public Infragistics.Win.UltraWinToolbars.UltraToolbarsManager tbManager;
        public Infragistics.Win.UltraWinDock.UltraDockManager dockManager;
        private Infragistics.Win.UltraWinDock.WindowDockingArea windowDockingArea1;
        public Infragistics.Win.UltraWinDock.AutoHideControl MainFormAutoHideControl;
        public Infragistics.Win.UltraWinDock.UnpinnedTabArea MainFormUnpinnedTabAreaTop;
        public Infragistics.Win.UltraWinDock.UnpinnedTabArea MainFormUnpinnedTabAreaBottom;
        public Infragistics.Win.UltraWinDock.UnpinnedTabArea MainFormUnpinnedTabAreaLeft;
        public Infragistics.Win.UltraWinDock.UnpinnedTabArea MainFormUnpinnedTabAreaRight;
        public Infragistics.Win.UltraWinTree.UltraTree tvwProject;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow2;
        public Infragistics.Win.UltraWinTree.UltraTree tvwSqlObjects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsFiles;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        public System.Windows.Forms.ToolStripButton tsbNewProject;
        public System.Windows.Forms.ToolStripButton tsbOpenProject;
        public System.Windows.Forms.ToolStripButton tsbSaveProject;
        public System.Windows.Forms.ToolStripButton tsbRemoveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem tsbAddSqlFile;
        public System.Windows.Forms.ToolStripMenuItem tsbAddFolder;
        public System.Windows.Forms.ToolStripMenuItem tsbAddExistingFile;
        public System.Windows.Forms.ToolStripSplitButton tsbAddFileFolder;
        public System.Windows.Forms.ToolStripMenuItem tsbAddCSharpFile;
        public System.Windows.Forms.ToolStripMenuItem tsbAddVbNetFile;
        public System.Windows.Forms.ImageList TreeImageList;
        public Infragistics.Win.UltraWinStatusBar.UltraStatusBar sbMain;

    }
}