namespace Actemium.WiSSWizard
{
  partial class CtrlError
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
    /// the contents of this method met the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblTemp = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblTemp
      // 
      this.lblTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblTemp.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTemp.Location = new System.Drawing.Point(178, 144);
      this.lblTemp.Name = "lblTemp";
      this.lblTemp.Size = new System.Drawing.Size(673, 325);
      this.lblTemp.TabIndex = 0;
      this.lblTemp.Text = "---";
      this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // CtrlError
      // 
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(1016, 639);
      this.ControlBox = false;
      this.Controls.Add(this.lblTemp);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "CtrlError";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblTemp;



  }
}