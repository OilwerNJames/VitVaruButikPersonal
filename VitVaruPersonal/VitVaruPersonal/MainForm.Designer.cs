namespace VitVaruPersonal
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.txtArtikelnummer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTarbort = new System.Windows.Forms.Button();
            this.btnLäggtill = new System.Windows.Forms.Button();
            this.rdbLäggtill = new System.Windows.Forms.RadioButton();
            this.rdbUppdatera = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLagersaldo = new System.Windows.Forms.TextBox();
            this.txtEnergiklass = new System.Windows.Forms.TextBox();
            this.txtVarugrupp = new System.Windows.Forms.TextBox();
            this.txtInköpsris = new System.Windows.Forms.TextBox();
            this.txtProduktBeskrivning = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtTillverkare = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnamn = new System.Windows.Forms.Label();
            this.txtPris = new System.Windows.Forms.TextBox();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(133, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(311, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.txtArtikelnummer);
            this.grpbox.Controls.Add(this.label10);
            this.grpbox.Controls.Add(this.btnTarbort);
            this.grpbox.Controls.Add(this.btnLäggtill);
            this.grpbox.Controls.Add(this.rdbLäggtill);
            this.grpbox.Controls.Add(this.rdbUppdatera);
            this.grpbox.Controls.Add(this.label6);
            this.grpbox.Controls.Add(this.txtLagersaldo);
            this.grpbox.Controls.Add(this.txtEnergiklass);
            this.grpbox.Controls.Add(this.txtVarugrupp);
            this.grpbox.Controls.Add(this.txtInköpsris);
            this.grpbox.Controls.Add(this.txtProduktBeskrivning);
            this.grpbox.Controls.Add(this.txtModel);
            this.grpbox.Controls.Add(this.txtTillverkare);
            this.grpbox.Controls.Add(this.label8);
            this.grpbox.Controls.Add(this.label7);
            this.grpbox.Controls.Add(this.label5);
            this.grpbox.Controls.Add(this.label4);
            this.grpbox.Controls.Add(this.label3);
            this.grpbox.Controls.Add(this.label2);
            this.grpbox.Controls.Add(this.label1);
            this.grpbox.Controls.Add(this.lblnamn);
            this.grpbox.Controls.Add(this.txtPris);
            this.grpbox.Controls.Add(this.txtNamn);
            this.grpbox.Location = new System.Drawing.Point(14, 39);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(399, 337);
            this.grpbox.TabIndex = 2;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Results";
            // 
            // txtArtikelnummer
            // 
            this.txtArtikelnummer.Location = new System.Drawing.Point(119, 288);
            this.txtArtikelnummer.Name = "txtArtikelnummer";
            this.txtArtikelnummer.Size = new System.Drawing.Size(144, 20);
            this.txtArtikelnummer.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Artikelnummer";
            // 
            // btnTarbort
            // 
            this.btnTarbort.Location = new System.Drawing.Point(297, 191);
            this.btnTarbort.Name = "btnTarbort";
            this.btnTarbort.Size = new System.Drawing.Size(75, 65);
            this.btnTarbort.TabIndex = 17;
            this.btnTarbort.Text = "Tar Bort Vara";
            this.btnTarbort.UseVisualStyleBackColor = true;
            this.btnTarbort.Click += new System.EventHandler(this.btnTarbort_Click);
            // 
            // btnLäggtill
            // 
            this.btnLäggtill.Location = new System.Drawing.Point(297, 35);
            this.btnLäggtill.Name = "btnLäggtill";
            this.btnLäggtill.Size = new System.Drawing.Size(75, 70);
            this.btnLäggtill.TabIndex = 16;
            this.btnLäggtill.Text = "Lägg till produkt";
            this.btnLäggtill.UseVisualStyleBackColor = true;
            this.btnLäggtill.Click += new System.EventHandler(this.btnLäggtill_Click);
            // 
            // rdbLäggtill
            // 
            this.rdbLäggtill.AutoSize = true;
            this.rdbLäggtill.Checked = true;
            this.rdbLäggtill.Location = new System.Drawing.Point(105, 14);
            this.rdbLäggtill.Name = "rdbLäggtill";
            this.rdbLäggtill.Size = new System.Drawing.Size(77, 17);
            this.rdbLäggtill.TabIndex = 15;
            this.rdbLäggtill.TabStop = true;
            this.rdbLäggtill.Text = "Lägg till Ny";
            this.rdbLäggtill.UseVisualStyleBackColor = true;
            this.rdbLäggtill.CheckedChanged += new System.EventHandler(this.rdbLäggtill_CheckedChanged);
            // 
            // rdbUppdatera
            // 
            this.rdbUppdatera.AutoSize = true;
            this.rdbUppdatera.Location = new System.Drawing.Point(188, 14);
            this.rdbUppdatera.Name = "rdbUppdatera";
            this.rdbUppdatera.Size = new System.Drawing.Size(75, 17);
            this.rdbUppdatera.TabIndex = 14;
            this.rdbUppdatera.Text = "Uppdatera";
            this.rdbUppdatera.UseVisualStyleBackColor = true;
            this.rdbUppdatera.CheckedChanged += new System.EventHandler(this.rdbUppdatera_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Energiklass";
            // 
            // txtLagersaldo
            // 
            this.txtLagersaldo.Location = new System.Drawing.Point(119, 262);
            this.txtLagersaldo.Name = "txtLagersaldo";
            this.txtLagersaldo.Size = new System.Drawing.Size(27, 20);
            this.txtLagersaldo.TabIndex = 13;
            // 
            // txtEnergiklass
            // 
            this.txtEnergiklass.Location = new System.Drawing.Point(119, 236);
            this.txtEnergiklass.Name = "txtEnergiklass";
            this.txtEnergiklass.Size = new System.Drawing.Size(144, 20);
            this.txtEnergiklass.TabIndex = 12;
            // 
            // txtVarugrupp
            // 
            this.txtVarugrupp.Location = new System.Drawing.Point(119, 210);
            this.txtVarugrupp.Name = "txtVarugrupp";
            this.txtVarugrupp.Size = new System.Drawing.Size(144, 20);
            this.txtVarugrupp.TabIndex = 11;
            // 
            // txtInköpsris
            // 
            this.txtInköpsris.Location = new System.Drawing.Point(119, 184);
            this.txtInköpsris.Name = "txtInköpsris";
            this.txtInköpsris.Size = new System.Drawing.Size(144, 20);
            this.txtInköpsris.TabIndex = 10;
            // 
            // txtProduktBeskrivning
            // 
            this.txtProduktBeskrivning.Location = new System.Drawing.Point(119, 140);
            this.txtProduktBeskrivning.Multiline = true;
            this.txtProduktBeskrivning.Name = "txtProduktBeskrivning";
            this.txtProduktBeskrivning.Size = new System.Drawing.Size(144, 38);
            this.txtProduktBeskrivning.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(119, 114);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(144, 20);
            this.txtModel.TabIndex = 8;
            // 
            // txtTillverkare
            // 
            this.txtTillverkare.Location = new System.Drawing.Point(119, 89);
            this.txtTillverkare.Name = "txtTillverkare";
            this.txtTillverkare.Size = new System.Drawing.Size(144, 20);
            this.txtTillverkare.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lagersaldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Varugrupp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Inköpspris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Produktbeskrivning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tillverkare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pris";
            // 
            // lblnamn
            // 
            this.lblnamn.AutoSize = true;
            this.lblnamn.Location = new System.Drawing.Point(80, 40);
            this.lblnamn.Name = "lblnamn";
            this.lblnamn.Size = new System.Drawing.Size(35, 13);
            this.lblnamn.TabIndex = 2;
            this.lblnamn.Text = "Namn";
            // 
            // txtPris
            // 
            this.txtPris.Location = new System.Drawing.Point(119, 63);
            this.txtPris.Name = "txtPris";
            this.txtPris.Size = new System.Drawing.Size(144, 20);
            this.txtPris.TabIndex = 1;
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(119, 37);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(144, 20);
            this.txtNamn.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Sök Artikellnummer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 392);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "MainForm";
            this.Text = "VitvaruPersonal";
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Button btnTarbort;
        private System.Windows.Forms.Button btnLäggtill;
        private System.Windows.Forms.RadioButton rdbLäggtill;
        private System.Windows.Forms.RadioButton rdbUppdatera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLagersaldo;
        private System.Windows.Forms.TextBox txtEnergiklass;
        private System.Windows.Forms.TextBox txtVarugrupp;
        private System.Windows.Forms.TextBox txtInköpsris;
        private System.Windows.Forms.TextBox txtProduktBeskrivning;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtTillverkare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnamn;
        private System.Windows.Forms.TextBox txtPris;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArtikelnummer;
        private System.Windows.Forms.Label label10;
    }
}

