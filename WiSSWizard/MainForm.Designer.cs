namespace Actemium.WiSSWizard
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
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.tssNavLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.ddbStatusStripActions = new System.Windows.Forms.ToolStripDropDownButton();
            this.lblStatusStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tmrMainRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlBusy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bpBusyIcon = new System.Windows.Forms.PictureBox();
            this.dasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonControlHeader = new DevComponents.DotNetBar.RibbonControl();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btnStartAbout = new DevComponents.DotNetBar.ButtonItem();
            this.btnStartExit = new DevComponents.DotNetBar.ButtonItem();
            this.StatusStrip.SuspendLayout();
            this.pnlBusy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpBusyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.AccessibleDescription = "StatusBar";
            this.StatusStrip.AccessibleName = "StatusBar";
            this.StatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.StatusStrip.AllowMerge = false;
            this.StatusStrip.BackColor = System.Drawing.Color.Silver;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssNavLocation,
            this.ddbStatusStripActions,
            this.lblStatusStripTime});
            this.StatusStrip.Location = new System.Drawing.Point(4, 474);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusStrip.Size = new System.Drawing.Size(622, 24);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "StatusStrip";
            this.StatusStrip.Resize += new System.EventHandler(this.StatusStrip_Resize);
            // 
            // tssNavLocation
            // 
            this.tssNavLocation.AutoSize = false;
            this.tssNavLocation.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssNavLocation.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.tssNavLocation.Name = "tssNavLocation";
            this.tssNavLocation.Size = new System.Drawing.Size(83, 19);
            this.tssNavLocation.Text = "   Initializing...";
            this.tssNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ddbStatusStripActions
            // 
            this.ddbStatusStripActions.BackColor = System.Drawing.Color.Silver;
            this.ddbStatusStripActions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbStatusStripActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbStatusStripActions.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.ddbStatusStripActions.Name = "ddbStatusStripActions";
            this.ddbStatusStripActions.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.ddbStatusStripActions.ShowDropDownArrow = false;
            this.ddbStatusStripActions.Size = new System.Drawing.Size(58, 22);
            this.ddbStatusStripActions.Text = "--:-- : ---";
            this.ddbStatusStripActions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusStripTime
            // 
            this.lblStatusStripTime.AutoSize = false;
            this.lblStatusStripTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatusStripTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblStatusStripTime.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.lblStatusStripTime.Name = "lblStatusStripTime";
            this.lblStatusStripTime.Size = new System.Drawing.Size(125, 19);
            this.lblStatusStripTime.Text = "-- - -- - ---- --:--";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightGray;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(4, 145);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(622, 329);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Resize += new System.EventHandler(this.PnlMain_Resize);
            // 
            // tmrMainRefresh
            // 
            this.tmrMainRefresh.Interval = 1000;
            this.tmrMainRefresh.Tick += new System.EventHandler(this.tmrMainRefresh_Tick);
            // 
            // pnlBusy
            // 
            this.pnlBusy.BackColor = System.Drawing.Color.DarkGray;
            this.pnlBusy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusy.Controls.Add(this.label1);
            this.pnlBusy.Controls.Add(this.bpBusyIcon);
            this.pnlBusy.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pnlBusy.Location = new System.Drawing.Point(174, 203);
            this.pnlBusy.Name = "pnlBusy";
            this.pnlBusy.Size = new System.Drawing.Size(250, 70);
            this.pnlBusy.TabIndex = 4;
            this.pnlBusy.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please be patient.";
            // 
            // bpBusyIcon
            // 
            this.bpBusyIcon.Location = new System.Drawing.Point(58, 20);
            this.bpBusyIcon.Name = "bpBusyIcon";
            this.bpBusyIcon.Size = new System.Drawing.Size(32, 32);
            this.bpBusyIcon.TabIndex = 0;
            this.bpBusyIcon.TabStop = false;
            // 
            // dasToolStripMenuItem
            // 
            this.dasToolStripMenuItem.Name = "dasToolStripMenuItem";
            this.dasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // ribbonControlHeader
            // 
            this.ribbonControlHeader.AntiAlias = false;
            this.ribbonControlHeader.CanCustomize = false;
            this.ribbonControlHeader.CaptionHeight = 14;
            this.ribbonControlHeader.CaptionVisible = true;
            this.ribbonControlHeader.CategorizeMode = DevComponents.DotNetBar.eCategorizeMode.Categories;
            this.ribbonControlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControlHeader.EnableQatPlacement = false;
            this.ribbonControlHeader.Expanded = false;
            this.ribbonControlHeader.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControlHeader.Location = new System.Drawing.Point(4, 1);
            this.ribbonControlHeader.MdiSystemItemVisible = false;
            this.ribbonControlHeader.Name = "ribbonControlHeader";
            this.ribbonControlHeader.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver;
            this.ribbonControlHeader.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControlHeader.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton1});
            this.ribbonControlHeader.Size = new System.Drawing.Size(622, 144);
            this.ribbonControlHeader.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControlHeader.TabGroupHeight = 14;
            this.ribbonControlHeader.TabIndex = 26;
            this.ribbonControlHeader.Text = "WiSS - Wizard";
            this.ribbonControlHeader.TitleText = "WiSS - Wizard";
            this.ribbonControlHeader.UseCustomizeDialog = false;
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.AutoExpandOnClick = true;
            this.office2007StartButton1.CanCustomize = false;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.Image = ((System.Drawing.Image)(resources.GetObject("office2007StartButton1.Image")));
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.KeyTips = "F";
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.office2007StartButton1.Tag = "NO_TRANSLATE";
            this.office2007StartButton1.Text = "Start<u>&M</u>enu";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            this.itemContainer1.Tag = "NO_TRANSLATE";
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3});
            this.itemContainer2.Tag = "NO_TRANSLATE";
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnStartAbout,
            this.btnStartExit});
            this.itemContainer3.Tag = "NO_TRANSLATE";
            // 
            // btnStartAbout
            // 
            this.btnStartAbout.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnStartAbout.Image")));
            this.btnStartAbout.ImagePaddingHorizontal = 8;
            this.btnStartAbout.Name = "btnStartAbout";
            this.btnStartAbout.SubItemsExpandWidth = 24;
            this.btnStartAbout.Text = "  About";
            this.btnStartAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnStartExit
            // 
            this.btnStartExit.BeginGroup = true;
            this.btnStartExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartExit.Image = ((System.Drawing.Image)(resources.GetObject("btnStartExit.Image")));
            this.btnStartExit.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnStartExit.ImagePaddingHorizontal = 8;
            this.btnStartExit.Name = "btnStartExit";
            this.btnStartExit.SubItemsExpandWidth = 24;
            this.btnStartExit.Text = "  Exit";
            this.btnStartExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(630, 500);
            this.Controls.Add(this.pnlBusy);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ribbonControlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 500);
            this.MinimumSize = new System.Drawing.Size(630, 500);
            this.Name = "MainForm";
            this.Text = "Security checklist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.pnlBusy.ResumeLayout(false);
            this.pnlBusy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpBusyIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip StatusStrip;
    private System.Windows.Forms.ToolStripDropDownButton ddbStatusStripActions;
    private System.Windows.Forms.ToolStripStatusLabel lblStatusStripTime;
    private System.Windows.Forms.Panel pnlMain;
    private System.Windows.Forms.Timer tmrMainRefresh;
    private System.Windows.Forms.Panel pnlBusy;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox bpBusyIcon;
    private System.Windows.Forms.ToolStripMenuItem dasToolStripMenuItem;
    private DevComponents.DotNetBar.RibbonControl ribbonControlHeader;
    private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
    private DevComponents.DotNetBar.ItemContainer itemContainer1;
    private DevComponents.DotNetBar.ItemContainer itemContainer2;
    private DevComponents.DotNetBar.ItemContainer itemContainer3;
    private DevComponents.DotNetBar.ButtonItem btnStartAbout;
    private DevComponents.DotNetBar.ButtonItem btnStartExit;
    private System.Windows.Forms.ToolStripStatusLabel tssNavLocation;
  }
}

