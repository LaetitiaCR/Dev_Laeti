
namespace WinsFormsAppCRUD
{
    partial class FrmFournisseurCmdes
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.litBoxCmdeFourni = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(341, 222);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // litBoxCmdeFourni
            // 
            this.litBoxCmdeFourni.FormattingEnabled = true;
            this.litBoxCmdeFourni.ItemHeight = 20;
            this.litBoxCmdeFourni.Location = new System.Drawing.Point(319, 74);
            this.litBoxCmdeFourni.Name = "litBoxCmdeFourni";
            this.litBoxCmdeFourni.Size = new System.Drawing.Size(120, 84);
            this.litBoxCmdeFourni.TabIndex = 4;
            // 
            // FrmFournisseurCmdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.litBoxCmdeFourni);
            this.Controls.Add(this.listView1);
            this.Name = "FrmFournisseurCmdes";
            this.Text = "FrmFournisseurCmdes";
            this.Load += new System.EventHandler(this.FrmFournisseurCmdes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox litBoxCmdeFourni;
    }
}