﻿namespace snorbert.Controls
{
    partial class ControlRules
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlRules));
            this.lblPagingRules = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.btnPagingLastPage = new System.Windows.Forms.Button();
            this.listEvents = new BrightIdeasSoftware.FastObjectListView();
            this.ctxMenuEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenuPayload = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSignature = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopySourceIp = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopySourcePort = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopyDestIp = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopyDestPort = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopyHost = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopyTimestamp = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopyPayloadAscii = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopyCid = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopySid = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopySigName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuCopyAcknowledgment = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopyAcknowledgmentSet = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuCopyAcknowledgmentClear = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuExclude = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuExtractIpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuExtractIpInfoUniqueSource = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuExtractIpInfoUniqueSourceList = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuExtractIpInfoUniqueSourceCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuExtractIpInfoUniqueDestination = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuExtractIpInfoUniqueDestinationList = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuExtractIpInfoUniqueDestinationCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuExportCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuExportRules = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuNwQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuNwQuerySrcToDst = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuNwQuerySrcPriorTraffic = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuNwQueryDstPriorTraffic = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSep5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMenuCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPagingPreviousPage = new System.Windows.Forms.Button();
            this.btnPagingNextPage = new System.Windows.Forms.Button();
            this.btnPagingFirstPage = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.chkIncludeAcknowledged = new System.Windows.Forms.CheckBox();
            this.cboSensor = new System.Windows.Forms.ComboBox();
            this.lblSensor = new System.Windows.Forms.Label();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cboTimeTo = new System.Windows.Forms.ComboBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRule = new System.Windows.Forms.Label();
            this.cboRule = new System.Windows.Forms.ComboBox();
            this.cboTimeFrom = new System.Windows.Forms.ComboBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.controlEventInfo = new snorbert.Controls.ControlEventInfo();
            this.ctxMenuNwQuerySrcToDstEventTimestamps = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listEvents)).BeginInit();
            this.ctxMenuEvent.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPagingRules
            // 
            this.lblPagingRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPagingRules.Location = new System.Drawing.Point(56, 175);
            this.lblPagingRules.Name = "lblPagingRules";
            this.lblPagingRules.Size = new System.Drawing.Size(755, 24);
            this.lblPagingRules.TabIndex = 20;
            this.lblPagingRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            this.splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.btnPagingLastPage);
            this.splitter.Panel1.Controls.Add(this.listEvents);
            this.splitter.Panel1.Controls.Add(this.btnPagingPreviousPage);
            this.splitter.Panel1.Controls.Add(this.btnPagingNextPage);
            this.splitter.Panel1.Controls.Add(this.btnPagingFirstPage);
            this.splitter.Panel1.Controls.Add(this.lblPagingRules);
            this.splitter.Panel1.Controls.Add(this.panelTop);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.controlEventInfo);
            this.splitter.Size = new System.Drawing.Size(866, 404);
            this.splitter.SplitterDistance = 200;
            this.splitter.TabIndex = 21;
            // 
            // btnPagingLastPage
            // 
            this.btnPagingLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagingLastPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPagingLastPage.Image")));
            this.btnPagingLastPage.Location = new System.Drawing.Point(841, 175);
            this.btnPagingLastPage.Name = "btnPagingLastPage";
            this.btnPagingLastPage.Size = new System.Drawing.Size(25, 25);
            this.btnPagingLastPage.TabIndex = 25;
            this.btnPagingLastPage.UseVisualStyleBackColor = true;
            this.btnPagingLastPage.Click += new System.EventHandler(this.btnPagingLastPage_Click);
            // 
            // listEvents
            // 
            this.listEvents.AlternateRowBackColor = System.Drawing.Color.White;
            this.listEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listEvents.ContextMenuStrip = this.ctxMenuEvent;
            this.listEvents.FullRowSelect = true;
            this.listEvents.HeaderUsesThemes = false;
            this.listEvents.HideSelection = false;
            this.listEvents.Location = new System.Drawing.Point(0, 58);
            this.listEvents.Name = "listEvents";
            this.listEvents.ShowCommandMenuOnRightClick = true;
            this.listEvents.ShowGroups = false;
            this.listEvents.ShowItemCountOnGroups = true;
            this.listEvents.Size = new System.Drawing.Size(865, 114);
            this.listEvents.SortGroupItemsByPrimaryColumn = false;
            this.listEvents.TabIndex = 21;
            this.listEvents.UseCompatibleStateImageBehavior = false;
            this.listEvents.UseFilterIndicator = true;
            this.listEvents.UseFiltering = true;
            this.listEvents.View = System.Windows.Forms.View.Details;
            this.listEvents.VirtualMode = true;
            this.listEvents.SelectedIndexChanged += new System.EventHandler(this.listEvents_SelectedIndexChanged);
            this.listEvents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listEvents_KeyDown);
            this.listEvents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listEvents_MouseDoubleClick);
            // 
            // ctxMenuEvent
            // 
            this.ctxMenuEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuPayload,
            this.ctxMenuSignature,
            this.toolStripMenuItem1,
            this.ctxMenuCopy,
            this.toolStripMenuItem3,
            this.ctxMenuCopyAcknowledgment,
            this.ctxMenuSep1,
            this.ctxMenuExclude,
            this.ctxMenuSep2,
            this.ctxMenuExtractIpInfo,
            this.ctxMenuSep3,
            this.ctxMenuExport,
            this.ctxMenuSep4,
            this.ctxMenuNwQuery,
            this.ctxMenuSep5,
            this.ctxMenuCommands});
            this.ctxMenuEvent.Name = "ctxMenuEvent";
            this.ctxMenuEvent.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctxMenuEvent.Size = new System.Drawing.Size(189, 266);
            this.ctxMenuEvent.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenuEvent_Opening);
            // 
            // ctxMenuPayload
            // 
            this.ctxMenuPayload.Name = "ctxMenuPayload";
            this.ctxMenuPayload.Size = new System.Drawing.Size(188, 22);
            this.ctxMenuPayload.Text = "Payload";
            this.ctxMenuPayload.Click += new System.EventHandler(this.ctxMenuPayload_Click);
            // 
            // ctxMenuSignature
            // 
            this.ctxMenuSignature.Name = "ctxMenuSignature";
            this.ctxMenuSignature.Size = new System.Drawing.Size(188, 22);
            this.ctxMenuSignature.Text = "Signature";
            this.ctxMenuSignature.Click += new System.EventHandler(this.ctxMenuSignature_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // ctxMenuCopy
            // 
            this.ctxMenuCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuCopySourceIp,
            this.ctxMenuCopySourcePort,
            this.ctxMenuCopyDestIp,
            this.ctxMenuCopyDestPort,
            this.ctxMenuCopyHost,
            this.ctxMenuCopyTimestamp,
            this.ctxMenuCopyPayloadAscii,
            this.ctxMenuCopyCid,
            this.ctxMenuCopySid,
            this.ctxMenuCopySigName});
            this.ctxMenuCopy.Name = "ctxMenuCopy";
            this.ctxMenuCopy.Size = new System.Drawing.Size(188, 22);
            this.ctxMenuCopy.Text = "Copy";
            // 
            // ctxMenuCopySourceIp
            // 
            this.ctxMenuCopySourceIp.Name = "ctxMenuCopySourceIp";
            this.ctxMenuCopySourceIp.Size = new System.Drawing.Size(159, 22);
            this.ctxMenuCopySourceIp.Text = "Source IP";
            this.ctxMenuCopySourceIp.Click += new System.EventHandler(this.ctxMenuCopySourceIp_Click);
            // 
            // ctxMenuCopySourcePort
            // 
            this.ctxMenuCopySourcePort.Name = "ctxMenuCopySourcePort";
            this.ctxMenuCopySourcePort.Size = new System.Drawing.Size(159, 22);
            this.ctxMenuCopySourcePort.Text = "Source Port";
            this.ctxMenuCopySourcePort.Click += new System.EventHandler(this.ctxMenuCopySourcePort_Click);
            // 
            // ctxMenuCopyDestIp
            // 
            this.ctxMenuCopyDestIp.Name = "ctxMenuCopyDestIp";
            this.ctxMenuCopyDestIp.Size = new System.Drawing.Size(159, 22);
            this.ctxMenuCopyDestIp.Text = "Destination IP";
            this.ctxMenuCopyDestIp.Click += new System.EventHandler(this.ctxMenuCopyDestIp_Click);
            // 
            // ctxMenuCopyDestPort
            // 
            this.ctxMenuCopyDestPort.Name = "ctxMenuCopyDestPort";
            this.ctxMenuCopyDestPort.Size = new System.Drawing.Size(159, 22);
            this.ctxMenuCopyDestPort.Text = "Destination Port";
            this.ctxMenuCopyDestPort.Click += new System.EventHandler(this.ctxMenuCopyDestPort_Click);
            // 
            // ctxMenuCopyHost
            // 
            this.ctxMenuCopyHost.Name = "ctxMenuCopyHost";
            this.ctxMenuCopyHost.Size = new System.Drawing.Size(159, 22);
            this.ctxMenuCopyHost.Text = "Host";
            this.ctxMenuCopyHost.Click += new System.EventHandler(this.ctxMenuCopyHost_Click);
            // 
            // ctxMenuCopyTimestamp
            // 
            this.ctxMenuCopyTimestamp.Name = "ctxMenuCopyTimestamp";
            this.ctxMenuCopyTimestamp.Size = new System.Drawing.Size(159, 22);
            this.ctxMenuCopyTimestamp.Text = "Timestamp";
            this.ctxMenuCopyTimestamp.Click += new System.EventHandler(this.ctxMenuCopyTimestamp_Click);
            // 
            // ctxMenuCopyPayloadAscii
            // 
            this.ctxMenuCopyPayloadAscii.Name = "ctxMenuCopyPayloadAscii";
            this.ctxMenuCopyPayloadAscii.Size = new System.Drawing.Size(159, 22);
            this.ctxMenuCopyPayloadAscii.Text = "Payload (ASCII)";
            this.ctxMenuCopyPayloadAscii.Click += new System.EventHandler(this.ctxMenuCopyPayloadAscii_Click);
            // 
            // ctxMenuCopyCid
            // 
            this.ctxMenuCopyCid.Name = "ctxMenuCopyCid";
            this.ctxMenuCopyCid.Size = new System.Drawing.Size(159, 22);
            this.ctxMenuCopyCid.Text = "CID";
            this.ctxMenuCopyCid.Click += new System.EventHandler(this.ctxMenuCopyCid_Click);
            // 
            // ctxMenuCopySid
            // 
            this.ctxMenuCopySid.Name = "ctxMenuCopySid";
            this.ctxMenuCopySid.Size = new System.Drawing.Size(159, 22);
            this.ctxMenuCopySid.Text = "SID";
            this.ctxMenuCopySid.Click += new System.EventHandler(this.ctxMenuCopySid_Click);
            // 
            // ctxMenuCopySigName
            // 
            this.ctxMenuCopySigName.Name = "ctxMenuCopySigName";
            this.ctxMenuCopySigName.Size = new System.Drawing.Size(159, 22);
            this.ctxMenuCopySigName.Text = "Signature Name";
            this.ctxMenuCopySigName.Click += new System.EventHandler(this.ctxMenuCopySigName_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 6);
            // 
            // ctxMenuCopyAcknowledgment
            // 
            this.ctxMenuCopyAcknowledgment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuCopyAcknowledgmentSet,
            this.ctxMenuCopyAcknowledgmentClear});
            this.ctxMenuCopyAcknowledgment.Name = "ctxMenuCopyAcknowledgment";
            this.ctxMenuCopyAcknowledgment.Size = new System.Drawing.Size(188, 22);
            this.ctxMenuCopyAcknowledgment.Text = "Acknowledgment";
            // 
            // ctxMenuCopyAcknowledgmentSet
            // 
            this.ctxMenuCopyAcknowledgmentSet.Name = "ctxMenuCopyAcknowledgmentSet";
            this.ctxMenuCopyAcknowledgmentSet.Size = new System.Drawing.Size(101, 22);
            this.ctxMenuCopyAcknowledgmentSet.Text = "Set";
            this.ctxMenuCopyAcknowledgmentSet.Click += new System.EventHandler(this.ctxMenuAcknowledgmentSet_Click);
            // 
            // ctxMenuCopyAcknowledgmentClear
            // 
            this.ctxMenuCopyAcknowledgmentClear.Name = "ctxMenuCopyAcknowledgmentClear";
            this.ctxMenuCopyAcknowledgmentClear.Size = new System.Drawing.Size(101, 22);
            this.ctxMenuCopyAcknowledgmentClear.Text = "Clear";
            this.ctxMenuCopyAcknowledgmentClear.Click += new System.EventHandler(this.ctxMenuAcknowledgmentClear_Click);
            // 
            // ctxMenuSep1
            // 
            this.ctxMenuSep1.Name = "ctxMenuSep1";
            this.ctxMenuSep1.Size = new System.Drawing.Size(185, 6);
            // 
            // ctxMenuExclude
            // 
            this.ctxMenuExclude.Name = "ctxMenuExclude";
            this.ctxMenuExclude.Size = new System.Drawing.Size(188, 22);
            this.ctxMenuExclude.Text = "Exclude";
            this.ctxMenuExclude.Click += new System.EventHandler(this.ctxMenuExclude_Click);
            // 
            // ctxMenuSep2
            // 
            this.ctxMenuSep2.Name = "ctxMenuSep2";
            this.ctxMenuSep2.Size = new System.Drawing.Size(185, 6);
            // 
            // ctxMenuExtractIpInfo
            // 
            this.ctxMenuExtractIpInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuExtractIpInfoUniqueSource,
            this.ctxMenuExtractIpInfoUniqueDestination});
            this.ctxMenuExtractIpInfo.Name = "ctxMenuExtractIpInfo";
            this.ctxMenuExtractIpInfo.Size = new System.Drawing.Size(188, 22);
            this.ctxMenuExtractIpInfo.Text = "Extract IP Information";
            // 
            // ctxMenuExtractIpInfoUniqueSource
            // 
            this.ctxMenuExtractIpInfoUniqueSource.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuExtractIpInfoUniqueSourceList,
            this.ctxMenuExtractIpInfoUniqueSourceCsv});
            this.ctxMenuExtractIpInfoUniqueSource.Name = "ctxMenuExtractIpInfoUniqueSource";
            this.ctxMenuExtractIpInfoUniqueSource.Size = new System.Drawing.Size(175, 22);
            this.ctxMenuExtractIpInfoUniqueSource.Text = "Unique Source";
            // 
            // ctxMenuExtractIpInfoUniqueSourceList
            // 
            this.ctxMenuExtractIpInfoUniqueSourceList.Name = "ctxMenuExtractIpInfoUniqueSourceList";
            this.ctxMenuExtractIpInfoUniqueSourceList.Size = new System.Drawing.Size(95, 22);
            this.ctxMenuExtractIpInfoUniqueSourceList.Text = "List";
            this.ctxMenuExtractIpInfoUniqueSourceList.Click += new System.EventHandler(this.ctxMenuExtractIpInfoUniqueSourceList_Click);
            // 
            // ctxMenuExtractIpInfoUniqueSourceCsv
            // 
            this.ctxMenuExtractIpInfoUniqueSourceCsv.Name = "ctxMenuExtractIpInfoUniqueSourceCsv";
            this.ctxMenuExtractIpInfoUniqueSourceCsv.Size = new System.Drawing.Size(95, 22);
            this.ctxMenuExtractIpInfoUniqueSourceCsv.Text = "CSV";
            this.ctxMenuExtractIpInfoUniqueSourceCsv.Click += new System.EventHandler(this.ctxMenuExtractIpInfoUniqueSourceCsv_Click);
            // 
            // ctxMenuExtractIpInfoUniqueDestination
            // 
            this.ctxMenuExtractIpInfoUniqueDestination.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuExtractIpInfoUniqueDestinationList,
            this.ctxMenuExtractIpInfoUniqueDestinationCsv});
            this.ctxMenuExtractIpInfoUniqueDestination.Name = "ctxMenuExtractIpInfoUniqueDestination";
            this.ctxMenuExtractIpInfoUniqueDestination.Size = new System.Drawing.Size(175, 22);
            this.ctxMenuExtractIpInfoUniqueDestination.Text = "Unique Destination";
            // 
            // ctxMenuExtractIpInfoUniqueDestinationList
            // 
            this.ctxMenuExtractIpInfoUniqueDestinationList.Name = "ctxMenuExtractIpInfoUniqueDestinationList";
            this.ctxMenuExtractIpInfoUniqueDestinationList.Size = new System.Drawing.Size(95, 22);
            this.ctxMenuExtractIpInfoUniqueDestinationList.Text = "List";
            this.ctxMenuExtractIpInfoUniqueDestinationList.Click += new System.EventHandler(this.ctxMenuExtractIpInfoUniqueDestinationList_Click);
            // 
            // ctxMenuExtractIpInfoUniqueDestinationCsv
            // 
            this.ctxMenuExtractIpInfoUniqueDestinationCsv.Name = "ctxMenuExtractIpInfoUniqueDestinationCsv";
            this.ctxMenuExtractIpInfoUniqueDestinationCsv.Size = new System.Drawing.Size(95, 22);
            this.ctxMenuExtractIpInfoUniqueDestinationCsv.Text = "CSV";
            this.ctxMenuExtractIpInfoUniqueDestinationCsv.Click += new System.EventHandler(this.ctxMenuExtractIpInfoUniqueDestinationCsv_Click);
            // 
            // ctxMenuSep3
            // 
            this.ctxMenuSep3.Name = "ctxMenuSep3";
            this.ctxMenuSep3.Size = new System.Drawing.Size(185, 6);
            // 
            // ctxMenuExport
            // 
            this.ctxMenuExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuExportAll,
            this.ctxMenuExportCurrent,
            this.toolStripMenuItem2,
            this.ctxMenuExportRules});
            this.ctxMenuExport.Name = "ctxMenuExport";
            this.ctxMenuExport.Size = new System.Drawing.Size(188, 22);
            this.ctxMenuExport.Text = "Export";
            // 
            // ctxMenuExportAll
            // 
            this.ctxMenuExportAll.Name = "ctxMenuExportAll";
            this.ctxMenuExportAll.Size = new System.Drawing.Size(180, 22);
            this.ctxMenuExportAll.Text = "All Events";
            this.ctxMenuExportAll.Click += new System.EventHandler(this.ctxMenuExportAll_Click);
            // 
            // ctxMenuExportCurrent
            // 
            this.ctxMenuExportCurrent.Name = "ctxMenuExportCurrent";
            this.ctxMenuExportCurrent.Size = new System.Drawing.Size(180, 22);
            this.ctxMenuExportCurrent.Text = "Current Page Events";
            this.ctxMenuExportCurrent.Click += new System.EventHandler(this.ctxMenuExportCurrent_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // ctxMenuExportRules
            // 
            this.ctxMenuExportRules.Name = "ctxMenuExportRules";
            this.ctxMenuExportRules.Size = new System.Drawing.Size(180, 22);
            this.ctxMenuExportRules.Text = "Rules";
            this.ctxMenuExportRules.Click += new System.EventHandler(this.ctxMenuExportRules_Click);
            // 
            // ctxMenuSep4
            // 
            this.ctxMenuSep4.Name = "ctxMenuSep4";
            this.ctxMenuSep4.Size = new System.Drawing.Size(185, 6);
            // 
            // ctxMenuNwQuery
            // 
            this.ctxMenuNwQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuNwQuerySrcToDst,
            this.ctxMenuNwQuerySrcToDstEventTimestamps,
            this.ctxMenuNwQuerySrcPriorTraffic,
            this.ctxMenuNwQueryDstPriorTraffic});
            this.ctxMenuNwQuery.Name = "ctxMenuNwQuery";
            this.ctxMenuNwQuery.Size = new System.Drawing.Size(188, 22);
            this.ctxMenuNwQuery.Text = "NetWitness Query";
            // 
            // ctxMenuNwQuerySrcToDst
            // 
            this.ctxMenuNwQuerySrcToDst.Name = "ctxMenuNwQuerySrcToDst";
            this.ctxMenuNwQuerySrcToDst.Size = new System.Drawing.Size(256, 22);
            this.ctxMenuNwQuerySrcToDst.Text = "Src <- -> Dest (Last 24 Hours)";
            this.ctxMenuNwQuerySrcToDst.Click += new System.EventHandler(this.ctxMenuNwQuerySrcToDst_Click);
            // 
            // ctxMenuNwQuerySrcPriorTraffic
            // 
            this.ctxMenuNwQuerySrcPriorTraffic.Name = "ctxMenuNwQuerySrcPriorTraffic";
            this.ctxMenuNwQuerySrcPriorTraffic.Size = new System.Drawing.Size(256, 22);
            this.ctxMenuNwQuerySrcPriorTraffic.Text = "Source Prior Traffic ";
            this.ctxMenuNwQuerySrcPriorTraffic.Click += new System.EventHandler(this.ctxMenuNwQuerySrcPriorTraffic_Click);
            // 
            // ctxMenuNwQueryDstPriorTraffic
            // 
            this.ctxMenuNwQueryDstPriorTraffic.Name = "ctxMenuNwQueryDstPriorTraffic";
            this.ctxMenuNwQueryDstPriorTraffic.Size = new System.Drawing.Size(256, 22);
            this.ctxMenuNwQueryDstPriorTraffic.Text = "Destination Prior Traffic ";
            this.ctxMenuNwQueryDstPriorTraffic.Click += new System.EventHandler(this.ctxMenuNwQueryDstPriorTraffic_Click);
            // 
            // ctxMenuSep5
            // 
            this.ctxMenuSep5.Name = "ctxMenuSep5";
            this.ctxMenuSep5.Size = new System.Drawing.Size(185, 6);
            // 
            // ctxMenuCommands
            // 
            this.ctxMenuCommands.Name = "ctxMenuCommands";
            this.ctxMenuCommands.Size = new System.Drawing.Size(188, 22);
            this.ctxMenuCommands.Text = "Commands";
            // 
            // btnPagingPreviousPage
            // 
            this.btnPagingPreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPagingPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPagingPreviousPage.Image")));
            this.btnPagingPreviousPage.Location = new System.Drawing.Point(27, 175);
            this.btnPagingPreviousPage.Name = "btnPagingPreviousPage";
            this.btnPagingPreviousPage.Size = new System.Drawing.Size(25, 25);
            this.btnPagingPreviousPage.TabIndex = 23;
            this.btnPagingPreviousPage.UseVisualStyleBackColor = true;
            this.btnPagingPreviousPage.Click += new System.EventHandler(this.btnPagingPreviousPage_Click);
            // 
            // btnPagingNextPage
            // 
            this.btnPagingNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagingNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPagingNextPage.Image")));
            this.btnPagingNextPage.Location = new System.Drawing.Point(813, 175);
            this.btnPagingNextPage.Name = "btnPagingNextPage";
            this.btnPagingNextPage.Size = new System.Drawing.Size(25, 25);
            this.btnPagingNextPage.TabIndex = 24;
            this.btnPagingNextPage.UseVisualStyleBackColor = true;
            this.btnPagingNextPage.Click += new System.EventHandler(this.btnPagingNextPage_Click);
            // 
            // btnPagingFirstPage
            // 
            this.btnPagingFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPagingFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPagingFirstPage.Image")));
            this.btnPagingFirstPage.Location = new System.Drawing.Point(-1, 175);
            this.btnPagingFirstPage.Name = "btnPagingFirstPage";
            this.btnPagingFirstPage.Size = new System.Drawing.Size(25, 25);
            this.btnPagingFirstPage.TabIndex = 22;
            this.btnPagingFirstPage.UseVisualStyleBackColor = true;
            this.btnPagingFirstPage.Click += new System.EventHandler(this.btnPagingFirstPage_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.chkIncludeAcknowledged);
            this.panelTop.Controls.Add(this.cboSensor);
            this.panelTop.Controls.Add(this.lblSensor);
            this.panelTop.Controls.Add(this.cboPriority);
            this.panelTop.Controls.Add(this.lblPriority);
            this.panelTop.Controls.Add(this.label31);
            this.panelTop.Controls.Add(this.cboTimeTo);
            this.panelTop.Controls.Add(this.dtpDateTo);
            this.panelTop.Controls.Add(this.lblDate);
            this.panelTop.Controls.Add(this.lblRule);
            this.panelTop.Controls.Add(this.cboRule);
            this.panelTop.Controls.Add(this.cboTimeFrom);
            this.panelTop.Controls.Add(this.dtpDateFrom);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(866, 57);
            this.panelTop.TabIndex = 20;
            // 
            // chkIncludeAcknowledged
            // 
            this.chkIncludeAcknowledged.AutoSize = true;
            this.chkIncludeAcknowledged.Location = new System.Drawing.Point(676, 4);
            this.chkIncludeAcknowledged.Name = "chkIncludeAcknowledged";
            this.chkIncludeAcknowledged.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIncludeAcknowledged.Size = new System.Drawing.Size(147, 19);
            this.chkIncludeAcknowledged.TabIndex = 33;
            this.chkIncludeAcknowledged.Text = "Include Acknowledged";
            this.chkIncludeAcknowledged.UseVisualStyleBackColor = true;
            // 
            // cboSensor
            // 
            this.cboSensor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSensor.FormattingEnabled = true;
            this.cboSensor.Location = new System.Drawing.Point(528, 1);
            this.cboSensor.Name = "cboSensor";
            this.cboSensor.Size = new System.Drawing.Size(144, 23);
            this.cboSensor.TabIndex = 32;
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.Location = new System.Drawing.Point(482, 4);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(42, 15);
            this.lblSensor.TabIndex = 31;
            this.lblSensor.Text = "Sensor";
            // 
            // cboPriority
            // 
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(416, 1);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(59, 23);
            this.cboPriority.TabIndex = 30;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(368, 4);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(45, 15);
            this.lblPriority.TabIndex = 29;
            this.lblPriority.Text = "Priority";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(182, 4);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(21, 15);
            this.label31.TabIndex = 28;
            this.label31.Text = "To";
            // 
            // cboTimeTo
            // 
            this.cboTimeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeTo.FormattingEnabled = true;
            this.cboTimeTo.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cboTimeTo.Location = new System.Drawing.Point(314, 1);
            this.cboTimeTo.Name = "cboTimeTo";
            this.cboTimeTo.Size = new System.Drawing.Size(50, 23);
            this.cboTimeTo.TabIndex = 27;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(210, 1);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.ShowCheckBox = true;
            this.dtpDateTo.Size = new System.Drawing.Size(99, 23);
            this.dtpDateTo.TabIndex = 26;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(7, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 15);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "From";
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Location = new System.Drawing.Point(8, 34);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(30, 15);
            this.lblRule.TabIndex = 22;
            this.lblRule.Text = "Rule";
            // 
            // cboRule
            // 
            this.cboRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboRule.DropDownHeight = 300;
            this.cboRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRule.FormattingEnabled = true;
            this.cboRule.IntegralHeight = false;
            this.cboRule.Location = new System.Drawing.Point(43, 29);
            this.cboRule.Name = "cboRule";
            this.cboRule.Size = new System.Drawing.Size(823, 24);
            this.cboRule.TabIndex = 21;
            this.cboRule.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboRule_DrawItem);
            this.cboRule.DropDownClosed += new System.EventHandler(this.cboRule_DropDownClosed);
            // 
            // cboTimeFrom
            // 
            this.cboTimeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeFrom.FormattingEnabled = true;
            this.cboTimeFrom.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cboTimeFrom.Location = new System.Drawing.Point(127, 1);
            this.cboTimeFrom.Name = "cboTimeFrom";
            this.cboTimeFrom.Size = new System.Drawing.Size(50, 23);
            this.cboTimeFrom.TabIndex = 20;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(44, 1);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(78, 23);
            this.dtpDateFrom.TabIndex = 19;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(841, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // controlEventInfo
            // 
            this.controlEventInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEventInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlEventInfo.Location = new System.Drawing.Point(0, 0);
            this.controlEventInfo.Name = "controlEventInfo";
            this.controlEventInfo.Size = new System.Drawing.Size(866, 200);
            this.controlEventInfo.TabIndex = 1;
            // 
            // ctxMenuNwQuerySrcToDstEventTimestamps
            // 
            this.ctxMenuNwQuerySrcToDstEventTimestamps.Name = "ctxMenuNwQuerySrcToDstEventTimestamps";
            this.ctxMenuNwQuerySrcToDstEventTimestamps.Size = new System.Drawing.Size(256, 22);
            this.ctxMenuNwQuerySrcToDstEventTimestamps.Text = "Src <- -> Dest (Event Timestamps)";
            this.ctxMenuNwQuerySrcToDstEventTimestamps.Click += new System.EventHandler(this.ctxMenuNwQuerySrcToDstEventTimestamps_Click);
            // 
            // ControlRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ControlRules";
            this.Size = new System.Drawing.Size(866, 404);
            this.Load += new System.EventHandler(this.Control_Load);
            this.Resize += new System.EventHandler(this.ControlRules_Resize);
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listEvents)).EndInit();
            this.ctxMenuEvent.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPagingRules;
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.Button btnPagingLastPage;
        private BrightIdeasSoftware.FastObjectListView listEvents;
        private System.Windows.Forms.Button btnPagingPreviousPage;
        private System.Windows.Forms.Button btnPagingNextPage;
        private System.Windows.Forms.Button btnPagingFirstPage;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cboTimeTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.ComboBox cboRule;
        private System.Windows.Forms.ComboBox cboTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Button btnRefresh;
        private ControlEventInfo controlEventInfo;
        private System.Windows.Forms.ContextMenuStrip ctxMenuEvent;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopySourceIp;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopySourcePort;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopyDestIp;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopyDestPort;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopySid;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopySigName;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopyTimestamp;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopyPayloadAscii;
        private System.Windows.Forms.ToolStripSeparator ctxMenuSep1;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExclude;
        private System.Windows.Forms.ToolStripSeparator ctxMenuSep2;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExtractIpInfo;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExtractIpInfoUniqueSource;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExtractIpInfoUniqueDestination;
        private System.Windows.Forms.ToolStripSeparator ctxMenuSep3;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExport;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExportAll;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExportCurrent;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuPayload;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator ctxMenuSep4;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuNwQuery;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuNwQuerySrcToDst;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuNwQuerySrcPriorTraffic;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopyHost;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExportRules;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuNwQueryDstPriorTraffic;
        private System.Windows.Forms.ComboBox cboSensor;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.ToolStripSeparator ctxMenuSep5;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCommands;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopyAcknowledgment;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopyAcknowledgmentSet;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopyAcknowledgmentClear;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSignature;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuCopyCid;
        private System.Windows.Forms.CheckBox chkIncludeAcknowledged;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExtractIpInfoUniqueSourceList;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExtractIpInfoUniqueSourceCsv;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExtractIpInfoUniqueDestinationList;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExtractIpInfoUniqueDestinationCsv;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuNwQuerySrcToDstEventTimestamps;
    }
}
