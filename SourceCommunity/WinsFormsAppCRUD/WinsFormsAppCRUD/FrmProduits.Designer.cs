
namespace WinsFormsAppCRUD
{
    partial class FrmProduits
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
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.lblProduits = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblStockAlerte = new System.Windows.Forms.Label();
            this.lbltockPhysique = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.lblUniteMesure = new System.Windows.Forms.Label();
            this.txtBoxCode = new System.Windows.Forms.TextBox();
            this.txtBoxLibelle = new System.Windows.Forms.TextBox();
            this.txtBoxStockAlerte = new System.Windows.Forms.TextBox();
            this.txtBoxStockPhysique = new System.Windows.Forms.TextBox();
            this.txtBoxQte = new System.Windows.Forms.TextBox();
            this.txtBoxUniteMesure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxProduits
            // 
            this.listBoxProduits.FormattingEnabled = true;
            this.listBoxProduits.ItemHeight = 20;
            this.listBoxProduits.Location = new System.Drawing.Point(81, 83);
            this.listBoxProduits.Name = "listBoxProduits";
            this.listBoxProduits.Size = new System.Drawing.Size(120, 84);
            this.listBoxProduits.TabIndex = 0;
            this.listBoxProduits.SelectedIndexChanged += new System.EventHandler(this.listBoxProduits_SelectedIndexChanged);
            // 
            // lblProduits
            // 
            this.lblProduits.AutoSize = true;
            this.lblProduits.Location = new System.Drawing.Point(97, 26);
            this.lblProduits.Name = "lblProduits";
            this.lblProduits.Size = new System.Drawing.Size(134, 20);
            this.lblProduits.TabIndex = 1;
            this.lblProduits.Text = "Liste des produits";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(406, 55);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(47, 20);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(406, 117);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(54, 20);
            this.lblLibelle.TabIndex = 3;
            this.lblLibelle.Text = "Libellé";
            // 
            // lblStockAlerte
            // 
            this.lblStockAlerte.AutoSize = true;
            this.lblStockAlerte.Location = new System.Drawing.Point(406, 172);
            this.lblStockAlerte.Name = "lblStockAlerte";
            this.lblStockAlerte.Size = new System.Drawing.Size(107, 20);
            this.lblStockAlerte.TabIndex = 4;
            this.lblStockAlerte.Text = "Stoch d\'alerte";
            // 
            // lbltockPhysique
            // 
            this.lbltockPhysique.AutoSize = true;
            this.lbltockPhysique.Location = new System.Drawing.Point(406, 236);
            this.lbltockPhysique.Name = "lbltockPhysique";
            this.lbltockPhysique.Size = new System.Drawing.Size(117, 20);
            this.lbltockPhysique.TabIndex = 5;
            this.lbltockPhysique.Text = "Stock physique";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Location = new System.Drawing.Point(402, 285);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(134, 20);
            this.lblQte.TabIndex = 6;
            this.lblQte.Text = "Quantité annuelle";
            // 
            // lblUniteMesure
            // 
            this.lblUniteMesure.AutoSize = true;
            this.lblUniteMesure.Location = new System.Drawing.Point(406, 333);
            this.lblUniteMesure.Name = "lblUniteMesure";
            this.lblUniteMesure.Size = new System.Drawing.Size(126, 20);
            this.lblUniteMesure.TabIndex = 7;
            this.lblUniteMesure.Text = "Unité de mesure";
            // 
            // txtBoxCode
            // 
            this.txtBoxCode.Location = new System.Drawing.Point(559, 55);
            this.txtBoxCode.Name = "txtBoxCode";
            this.txtBoxCode.Size = new System.Drawing.Size(100, 26);
            this.txtBoxCode.TabIndex = 8;
            // 
            // txtBoxLibelle
            // 
            this.txtBoxLibelle.Location = new System.Drawing.Point(559, 111);
            this.txtBoxLibelle.Name = "txtBoxLibelle";
            this.txtBoxLibelle.Size = new System.Drawing.Size(100, 26);
            this.txtBoxLibelle.TabIndex = 9;
            // 
            // txtBoxStockAlerte
            // 
            this.txtBoxStockAlerte.Location = new System.Drawing.Point(559, 166);
            this.txtBoxStockAlerte.Name = "txtBoxStockAlerte";
            this.txtBoxStockAlerte.Size = new System.Drawing.Size(100, 26);
            this.txtBoxStockAlerte.TabIndex = 10;
            // 
            // txtBoxStockPhysique
            // 
            this.txtBoxStockPhysique.Location = new System.Drawing.Point(559, 236);
            this.txtBoxStockPhysique.Name = "txtBoxStockPhysique";
            this.txtBoxStockPhysique.Size = new System.Drawing.Size(100, 26);
            this.txtBoxStockPhysique.TabIndex = 11;
            // 
            // txtBoxQte
            // 
            this.txtBoxQte.Location = new System.Drawing.Point(559, 285);
            this.txtBoxQte.Name = "txtBoxQte";
            this.txtBoxQte.Size = new System.Drawing.Size(100, 26);
            this.txtBoxQte.TabIndex = 12;
            // 
            // txtBoxUniteMesure
            // 
            this.txtBoxUniteMesure.Location = new System.Drawing.Point(559, 333);
            this.txtBoxUniteMesure.Name = "txtBoxUniteMesure";
            this.txtBoxUniteMesure.Size = new System.Drawing.Size(100, 26);
            this.txtBoxUniteMesure.TabIndex = 13;
            // 
            // FrmProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxUniteMesure);
            this.Controls.Add(this.txtBoxQte);
            this.Controls.Add(this.txtBoxStockPhysique);
            this.Controls.Add(this.txtBoxStockAlerte);
            this.Controls.Add(this.txtBoxLibelle);
            this.Controls.Add(this.txtBoxCode);
            this.Controls.Add(this.lblUniteMesure);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.lbltockPhysique);
            this.Controls.Add(this.lblStockAlerte);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblProduits);
            this.Controls.Add(this.listBoxProduits);
            this.Name = "FrmProduits";
            this.Text = "FrmProduits";
            this.Load += new System.EventHandler(this.FrmProduits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.Label lblProduits;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblStockAlerte;
        private System.Windows.Forms.Label lbltockPhysique;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.Label lblUniteMesure;
        private System.Windows.Forms.TextBox txtBoxCode;
        private System.Windows.Forms.TextBox txtBoxLibelle;
        private System.Windows.Forms.TextBox txtBoxStockAlerte;
        private System.Windows.Forms.TextBox txtBoxStockPhysique;
        private System.Windows.Forms.TextBox txtBoxQte;
        private System.Windows.Forms.TextBox txtBoxUniteMesure;
    }
}