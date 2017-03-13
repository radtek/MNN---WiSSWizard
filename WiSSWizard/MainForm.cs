using System;
using System.Drawing;
using System.Windows.Forms;

using Actemium.Diagnostics;


namespace Actemium.WiSSWizard
{
  public partial class MainForm : DevComponents.DotNetBar.Office2007RibbonForm
  {
    const string CLASSNAME = "MainForm";
       
    public Boolean ShowBusyBox
    {
      get { return pnlBusy.Visible; }
      set
      {
        pnlMain.Enabled = !value;
        Application.DoEvents();

        pnlBusy.Visible = value;

        if (value)
        {
          pnlMain.SuspendLayout();
          pnlBusy.Refresh();
        }
        else
        {
          pnlMain.ResumeLayout();
          pnlMain.Refresh();
        }

        this.Cursor = value ? Cursors.WaitCursor : Cursors.Default;
      }
    }


    public MainForm()
    {
      try
      {
        InitializeComponent();

        NavigationHandler.MainForm = this;
        NavigationHandler.TrgPanel = pnlMain;
        

      }
      catch (Exception ex)
      {
        Trace.WriteError("()", "MainForm", CLASSNAME, ex);
        throw;
      }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      try
      {
        tmrMainRefresh.Start();

        ddbStatusStripActions.DropDownItems.Clear();
        AddHistoryAction("The WissWizard is started.");


        lblStatusStripTime.Text = String.Format("{0:dd-MM-yyyy HH:mm:ss}", DateTime.Now);

        SetAuthorisation();

        NavigationHandler.Navigate(NavigationItems.Home, pnlMain);
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", "MainForm_Load", CLASSNAME, ex);

        String text = string.Format("The application has an error occurred."
                            + "\n\nThe error occurred while starting the application."
                            + "Unfortunately, the application can not continue and will be closed now."
                            + "\nIf this problem persists, please contact with Actemium."
                            + "\nMake a note in this case, the message and the time.");

        MessageBox.Show(text, "Application fault", MessageBoxButtons.OK, MessageBoxIcon.Error);

        this.Close();
      }
    }

      
  public class MyClass
    {
        public void Process()
        {
            Console.WriteLine("Process() begin");
            Console.WriteLine("Process() end");
        }
    }  ////////////////////////////////
    public bool RestorePointIsCreated
    {
        get
        {
            return _restorePointIsCreated;
        }
        set
        {
            _restorePointIsCreated = value;
        }
    } private bool _restorePointIsCreated = false;

    /////////////////////////////



    #region Navigation Handling
    private void btnAbout_Click(object sender, EventArgs e)
    {
      try
      {
        using (Actemium.Windows.Forms.AboutForm dialog = new Actemium.Windows.Forms.AboutForm(System.Reflection.Assembly.GetExecutingAssembly()))
        {
          dialog.ShowDialog();
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", "btnAbout_Click", CLASSNAME, ex);
        throw;
      }
    }

    private void btnNavigation_Click(object sender, EventArgs e)
    {
      try
      {
        Trace.WriteVerbose("()", "btnNavigation_Click", CLASSNAME);

        Int32 NagivationItemId;

        Type type = sender.GetType();
        Object TagValue = null;

        switch (type.Name)
        {
          case "ToolStripMenuItem":
            TagValue = ((ToolStripMenuItem)sender).Tag;
            break;
          case "Button":
            TagValue = ((Button)sender).Tag;
            break;
          case "ButtonItem":
            TagValue = ((DevComponents.DotNetBar.ButtonItem)sender).Tag;
            break;
          default:
            break;
        }

        if (!Int32.TryParse(TagValue.ToString(), out NagivationItemId))
          throw new ApplicationException("Menubutton has an incorrect Id");

        if (NagivationItemId == (int)NavigationItems.Help)
          ShowHelp();
        else if (!NavigationHandler.Navigate((NavigationItems)NagivationItemId, pnlMain))
          AddHistoryAction(String.Format("Navigate to '{0}' incorrect.", (NavigationItems)NagivationItemId));
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", "btnSubMenuNavigation_Click", CLASSNAME, ex);
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    
    public void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
      try
      {
        Boolean navigate = false;
        NavigationItems NavigationItem = NavigationItems.NoSelection;

        #region Funtion keys
        if (e.Modifiers == Keys.None)
        {
          switch (e.KeyCode)
          {
            case Keys.F1:
              e.Handled = true;
              ShowHelp();
              break;
          }
        }
        #endregion

        if (navigate && NavigationItem != NavigationItems.NoSelection)
        {
          e.Handled = true;
          NavigationHandler.Navigate(NavigationItem, pnlMain);
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", "MainForm_KeyDown", CLASSNAME, ex);
        throw;
      }
    }

    private void ShowHelp()
    {
      try
      {
        //new popupBLISSHelp().Show();
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", "btnHelp_Click", CLASSNAME, ex);
        ThrowExceptionToUser("Help", "btnHelp_Click");
      }
    }
    #endregion

    #region Form Events Handling
    private void StatusStrip_Resize(object sender, EventArgs e)
    {
      try
      {
        ddbStatusStripActions.Size = new System.Drawing.Size(StatusStrip.Size.Width - 400, ddbStatusStripActions.Size.Height);
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", "StatusStrip_Resize", CLASSNAME, ex);
        ThrowExceptionToUser("Application", "StatusStrip_Resize");
      }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        string message1 = "Are you sure you want to terminate the configuration?";
        string caption1 = "Stop?";
        string message2 = "Do you want to undo the settings that have been made?";
        string caption2 = "Settings rollback";
        string message3 = "Are you sure you want to end the configuration, without making any change setting?";
        string caption3 = "Stop?";
      
      try
      {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            if(MainProgram.CheckIfthereAreChanges)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message1, caption1, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                   
                    CtrlHome.GetConfigClass.ConfSetMicrosoftBaslineSecurityAnalyzer.KillMBSAProcessesByClosing("mbsacli");
                    if (CtrlHome.GetConfigClass.CheckWindowsRestorePointisCreated())
                    {
                        result = MessageBox.Show(message2, caption2, buttons);
                        // Closes the parent form.
                        if (result == System.Windows.Forms.DialogResult.No)
                        {
                            //this.Close();
                            Application.Exit();
                        }
                        else
                        {
                            e.Cancel = true;
                            //instellingen ongedaan maken
                            CtrlHome.GetConfigClass.RestoreSettings();
                        }
                    }
                    else
                    {
                        
                        //this.Close();
                        Application.Exit();
                    }
                }
                else
                {
                    e.Cancel = true;

                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message3, caption3, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        else if(e.CloseReason == CloseReason.ApplicationExitCall)
        {
            e.Cancel = false;
            
        }

        if (!e.Cancel)
        {
          ShowBusyBox = true;
        }
      }
      catch
      {
      }
    }

    private void tmrMainRefresh_Tick(object sender, EventArgs e)
    {
      try
      {
        lblStatusStripTime.Text = String.Format("{0:dd-MM-yyyy HH:mm:ss}", DateTime.Now);     
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", "tmrMainRefresh_Tick", CLASSNAME, ex);
        ThrowExceptionToUser("Applicatie", "tmrMainRefresh_Tick");
      }
    }

    private void PnlMain_Resize(object sender, EventArgs e)
    {
      pnlBusy.Location = new Point((this.Size.Width - pnlBusy.Size.Width) / 2, (this.Size.Height - pnlBusy.Size.Height) / 2);
    }
    #endregion

    #region General Public Methods
    public void AddHistoryAction(String description)
    {
      try
      {
        ddbStatusStripActions.Text = string.Format("{0:dd-MM-yyyy HH:mm}: {1}", DateTime.Now, description);
        ddbStatusStripActions.DropDownItems.Add(ddbStatusStripActions.Text);

        if (ddbStatusStripActions.DropDownItems.Count > 99)
          ddbStatusStripActions.DropDownItems.RemoveAt(0);
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "AddHistoryAction", CLASSNAME, ex, description);
        throw;
      }
    }

    public void ThrowExceptionToUser(String title, String method)
    {
        String text = string.Format("The application has an error occurred."
                              + "\n\nThe error occurred while starting the application."
                              + "Unfortunately, the application can not continue and will be closed now."
                              + "\nIf this problem persists, please contact with Actemium."
                              + "\nMake a note in this case, the message and the time."
                                  , title, method);

      MessageBox.Show(text, "Application fault", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void SetAuthorisation()
    {
      try
      {
          GenerateMenu();
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", "SetAuthorisation", CLASSNAME, ex);
        throw;
      }
    }
    #endregion

    #region Generate Menu
    private void GenerateMenu()
    {
      try
      {
        this.ribbonControlHeader.SuspendLayout();
        this.ribbonControlHeader.Items.Clear();

        foreach (NavigationTabItem item in Settings.Navigation.TabItems)
        {
          if (item.Count > 0)
          {
            DevComponents.DotNetBar.RibbonTabItem tabItem = GetRibbonTab(item);
            if (tabItem.Panel != null)
              ribbonControlHeader.Items.Add(tabItem);
          }
          else
          {
            DevComponents.DotNetBar.ButtonItem button = GetRibbonButton(item, true);
            if (button.Enabled)
              ribbonControlHeader.Items.Add(button);
          }

        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", "GenerateMenu", CLASSNAME, ex);
        throw;
      }
      finally
      {

        this.ribbonControlHeader.RecalcLayout();
        this.ribbonControlHeader.ResumeLayout(true);
      }

    }

    private DevComponents.DotNetBar.ButtonItem GetRibbonButton(NavigationTabItem tabItem, Boolean header)
    {
      try
      {
        DevComponents.DotNetBar.ButtonItem buttonItem = new DevComponents.DotNetBar.ButtonItem();
        buttonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
        buttonItem.HotFontBold = true;
        buttonItem.ImagePaddingHorizontal = 8;
        buttonItem.SubItemsExpandWidth = 14;

        if (header)
          buttonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Left;
        else
        {
          buttonItem.FixedSize = new System.Drawing.Size(90, 30);
          buttonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
        }

        if (tabItem.Tag.Length > 0)
        {
          buttonItem.Tag = tabItem.Tag;
          buttonItem.Click += new System.EventHandler(this.btnNavigation_Click);
        }
        buttonItem.Text = tabItem.Name;
        buttonItem.KeyTips = tabItem.KeyTips.Length > 0 ? tabItem.KeyTips : null;
        buttonItem.Image = tabItem.Image.Length > 0 ? (Bitmap)Actemium.WiSSWizard.Properties.Resources.ResourceManager.GetObject(tabItem.Image) : null;

        buttonItem.Enabled = true;

        buttonItem.RecalcSize();

        return buttonItem;
      }
      catch (Exception ex)
      {
        Trace.WriteError("'({0},{1})", "GetRibbonButton", CLASSNAME, ex, tabItem, header);
        throw;
      }
    }

    private DevComponents.DotNetBar.RibbonTabItem GetRibbonTab(NavigationTabItem tabItem)
    {
      try
      {
        DevComponents.DotNetBar.RibbonTabItem ribbonTabItem = new DevComponents.DotNetBar.RibbonTabItem();
        ribbonTabItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
        ribbonTabItem.HotFontBold = true;
        ribbonTabItem.ImagePaddingHorizontal = 8;
        ribbonTabItem.SubItemsExpandWidth = 14;

        if (tabItem.Tag.Length > 0)
        {
          ribbonTabItem.Tag = tabItem.Tag;
          ribbonTabItem.Click += new System.EventHandler(this.btnNavigation_Click);
        }
        ribbonTabItem.Text = tabItem.Name;
        ribbonTabItem.KeyTips = tabItem.KeyTips.Length > 0 ? tabItem.KeyTips : null;
        ribbonTabItem.Image = tabItem.Image.Length > 0 ? (Bitmap)Actemium.WiSSWizard.Properties.Resources.ResourceManager.GetObject(tabItem.Image) : null;

        if (tabItem.Count > 0)
        {
          DevComponents.DotNetBar.RibbonPanel ribbonPanel = GetRibbonPanel();

          foreach (NavigationTabBar bar in tabItem)
          {
            DevComponents.DotNetBar.RibbonBar ribbonBar = GetRibbonBar(bar);
            if (ribbonBar.Items.Count > 0)
              ribbonPanel.Controls.Add(ribbonBar);
          }

          if (ribbonPanel.Controls.Count > 0)
          {
            ribbonControlHeader.Controls.Add(ribbonPanel);
            ribbonTabItem.Panel = ribbonPanel;
          }
        }

        ribbonTabItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Left;
        ribbonTabItem.RecalcSize();

        return ribbonTabItem;
      }
      catch (Exception ex)
      {
        Trace.WriteError("'({0})", "GetRibbonTab", CLASSNAME, ex, tabItem);
        throw;
      }
    }

    private DevComponents.DotNetBar.RibbonPanel GetRibbonPanel()
    {
      DevComponents.DotNetBar.RibbonPanel ribbonPanel = new DevComponents.DotNetBar.RibbonPanel();
      ribbonControlHeader.Controls.Add(ribbonPanel);
      ribbonPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
      ribbonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      ribbonPanel.Location = new System.Drawing.Point(0, 71);
      ribbonPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
      ribbonPanel.Size = new System.Drawing.Size(1016, 67);
      ribbonPanel.TabIndex = 0;
      ribbonPanel.Visible = false;

      return ribbonPanel;
    }

    private DevComponents.DotNetBar.RibbonBar GetRibbonBar(NavigationTabBar tabBar)
    {
      DevComponents.DotNetBar.RibbonBar ribbonBar = new DevComponents.DotNetBar.RibbonBar();
      ribbonBar.AutoOverflowEnabled = true;
      ribbonBar.Dock = System.Windows.Forms.DockStyle.Left;

      foreach (NavigationTabItem buttonItem in tabBar)
      {
        DevComponents.DotNetBar.ButtonItem button = GetRibbonButton(buttonItem, false);
        if (button.Enabled)
          ribbonBar.Items.Add(button);
      }

      ribbonBar.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
      ribbonBar.Location = new System.Drawing.Point(3, 0);
      ribbonBar.Size = new System.Drawing.Size(519, 64);
      ribbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
      ribbonBar.TabIndex = 1;
      ribbonBar.Text = tabBar.ShowName ? tabBar.Name : "";
      ribbonBar.TitleVisible = true;

      return ribbonBar;
    }
    #endregion



  }
}