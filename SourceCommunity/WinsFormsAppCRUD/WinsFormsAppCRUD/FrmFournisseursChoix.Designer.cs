
namespace WinsFormsAppCRUD
{
    partial class FrmFournisseursChoix
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
            this.comboBoxFourni = new System.Windows.Forms.ComboBox();
            this.lblChoixFourniseurs = new System.Windows.Forms.Label();
            this.butQuitter = new System.Windows.Forms.Button();
            this.listBoxFourni = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxFourni
            // 
            this.comboBoxFourni.FormattingEnabled = true;
            this.comboBoxFourni.Location = new System.Drawing.Point(285, 52);
            this.comboBoxFourni.Name = "comboBoxFourni";
            this.comboBoxFourni.Size = new System.Drawing.Size(267, 28);
            this.comboBoxFourni.TabIndex = 0;
            this.comboBoxFourni.SelectedIndexChanged += new System.EventHandler(this.comboBoxFourni_SelectedIndexChanged);
            this.comboBoxFourni.SelectedValueChanged += new System.EventHandler(this.comboboxFourni_selectedValueChanged);
            // 
            // lblChoixFourniseurs
            // 
            this.lblChoixFourniseurs.AutoSize = true;
            this.lblChoixFourniseurs.Location = new System.Drawing.Point(63, 55);
            this.lblChoixFourniseurs.Name = "lblChoixFourniseurs";
            this.lblChoixFourniseurs.Size = new System.Drawing.Size(162, 20);
            this.lblChoixFourniseurs.TabIndex = 1;
            this.lblChoixFourniseurs.Text = "Choisir un fournisseur";
            // 
            // butQuitter
            // 
            this.butQuitter.Location = new System.Drawing.Point(566, 305);
            this.butQuitter.Name = "butQuitter";
            this.butQuitter.Size = new System.Drawing.Size(110, 65);
            this.butQuitter.TabIndex = 2;
            this.butQuitter.Text = "Quitter";
            this.butQuitter.UseVisualStyleBackColor = true;
            this.butQuitter.Click += new System.EventHandler(this.butQuitter_Click);
            // 
            // listBoxFourni
            // 
            this.listBoxFourni.FormattingEnabled = true;
            this.listBoxFourni.ItemHeight = 20;
            this.listBoxFourni.Location = new System.Drawing.Point(316, 169);
            this.listBoxFourni.Name = "listBoxFourni";
            this.listBoxFourni.Size = new System.Drawing.Size(120, 84);
            this.listBoxFourni.TabIndex = 3;
            // 
            // FrmFournisseursChoix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxFourni);
            this.Controls.Add(this.butQuitter);
            this.Controls.Add(this.lblChoixFourniseurs);
            this.Controls.Add(this.comboBoxFourni);
            this.Name = "FrmFournisseursChoix";
            this.Text = "FrmFournisseursChoix";
            this.Load += new System.EventHandler(this.FrmFournisseursChoix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFourni;
        private System.Windows.Forms.Label lblChoixFourniseurs;
        private System.Windows.Forms.Button butQuitter;
        private System.Windows.Forms.ListBox listBoxFourni;
    }
}