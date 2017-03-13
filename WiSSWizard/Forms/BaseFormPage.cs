using System;
using System.Windows.Forms;


namespace Actemium.WiSSWizard
{
  public class BaseFormPage : DevComponents.DotNetBar.Office2007Form
  {
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseFormPage));
      this.SuspendLayout();
      // 
      // BaseFormPage
      // 
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(1272, 639);
      this.ControlBox = false;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "BaseFormPage";
      this.ResumeLayout(false);

    }

    
    public MainForm mainForm
    {
      get { return _mainForm; }
      set { _mainForm = value; }
    } private MainForm _mainForm;

    public NavigationItems NavigationItem
    {
      get { return _navigationItem; }
    } protected NavigationItems _navigationItem;

    public String Title
    {
      get { return _title; }
    } protected String _title;

    public Boolean IsActivated
    {
      get { return _isActivated; }
    } private Boolean _isActivated;
    
    public Boolean ShowBusyBox
    {
      get 
      {
        if (mainForm != null)
          return mainForm.Controls["pnlBusy"].Visible;
        else
          return false;
      }
      set 
      {
        if (mainForm != null)
        {
          mainForm.Controls["pnlMain"].Enabled = !value;
          mainForm.Controls["pnlBusy"].Visible = value;
          mainForm.Controls["pnlBusy"].Refresh();
          mainForm.Cursor = value ? Cursors.WaitCursor : Cursors.Default;
          System.Windows.Forms.Application.DoEvents();
        }
      }
    }


    protected void ShowErrorOK(String text, String caption)
    {
      MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public virtual void GiveFocusFromMain(){}
    public virtual void ActivateFromMain()
    {
      if (mainForm != null)
        ((ToolStripStatusLabel)((StatusStrip)mainForm.Controls["StatusStrip"]).Items["tssNavLocation"]).Text = "   " + _title;

      _isActivated = true;
    }
    public virtual void DeActivateFromMain()
    {
      _isActivated = false;
    }
    public virtual void RefreshFromMain() {}

  }
}