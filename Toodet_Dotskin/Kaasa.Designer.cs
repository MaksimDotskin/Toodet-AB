namespace Toodet_Dotskin
{
    partial class Kaasa
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxToodet = new System.Windows.Forms.ListBox();
            this.Kat_box = new System.Windows.Forms.ComboBox();
            this.btnOstukorvile = new System.Windows.Forms.Button();
            this.btnOstukorvist = new System.Windows.Forms.Button();
            this.btnMaksma = new System.Windows.Forms.Button();
            this.btnToode = new System.Windows.Forms.Button();
            this.lblSumma = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTervitamine = new System.Windows.Forms.Label();
            this.listBoxOstukorv = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kassa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tooted";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(689, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ostukorv";
            // 
            // listBoxToodet
            // 
            this.listBoxToodet.FormattingEnabled = true;
            this.listBoxToodet.Location = new System.Drawing.Point(12, 158);
            this.listBoxToodet.Name = "listBoxToodet";
            this.listBoxToodet.Size = new System.Drawing.Size(264, 212);
            this.listBoxToodet.TabIndex = 23;
            // 
            // Kat_box
            // 
            this.Kat_box.FormattingEnabled = true;
            this.Kat_box.Location = new System.Drawing.Point(17, 89);
            this.Kat_box.Name = "Kat_box";
            this.Kat_box.Size = new System.Drawing.Size(120, 21);
            this.Kat_box.TabIndex = 25;
            this.Kat_box.SelectedIndexChanged += new System.EventHandler(this.Kat_box_SelectedIndexChanged);
            // 
            // btnOstukorvile
            // 
            this.btnOstukorvile.Location = new System.Drawing.Point(348, 158);
            this.btnOstukorvile.Name = "btnOstukorvile";
            this.btnOstukorvile.Size = new System.Drawing.Size(75, 23);
            this.btnOstukorvile.TabIndex = 26;
            this.btnOstukorvile.Text = ">";
            this.btnOstukorvile.UseVisualStyleBackColor = true;
            this.btnOstukorvile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOstukorvist
            // 
            this.btnOstukorvist.Location = new System.Drawing.Point(348, 197);
            this.btnOstukorvist.Name = "btnOstukorvist";
            this.btnOstukorvist.Size = new System.Drawing.Size(75, 23);
            this.btnOstukorvist.TabIndex = 27;
            this.btnOstukorvist.Text = "<";
            this.btnOstukorvist.UseVisualStyleBackColor = true;
            this.btnOstukorvist.Click += new System.EventHandler(this.btnOstukorvist_Click);
            // 
            // btnMaksma
            // 
            this.btnMaksma.Location = new System.Drawing.Point(643, 415);
            this.btnMaksma.Name = "btnMaksma";
            this.btnMaksma.Size = new System.Drawing.Size(145, 23);
            this.btnMaksma.TabIndex = 29;
            this.btnMaksma.Text = "Maksma";
            this.btnMaksma.UseVisualStyleBackColor = true;
            // 
            // btnToode
            // 
            this.btnToode.Location = new System.Drawing.Point(17, 415);
            this.btnToode.Name = "btnToode";
            this.btnToode.Size = new System.Drawing.Size(145, 23);
            this.btnToode.TabIndex = 31;
            this.btnToode.Text = "Toodet";
            this.btnToode.UseVisualStyleBackColor = true;
            this.btnToode.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSumma.Location = new System.Drawing.Point(379, 399);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(0, 39);
            this.lblSumma.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(282, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 126);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(345, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "Summa";
            // 
            // lblTervitamine
            // 
            this.lblTervitamine.AutoSize = true;
            this.lblTervitamine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblTervitamine.Location = new System.Drawing.Point(12, 5);
            this.lblTervitamine.Name = "lblTervitamine";
            this.lblTervitamine.Size = new System.Drawing.Size(0, 39);
            this.lblTervitamine.TabIndex = 36;
            // 
            // listBoxOstukorv
            // 
            this.listBoxOstukorv.FormattingEnabled = true;
            this.listBoxOstukorv.Location = new System.Drawing.Point(524, 158);
            this.listBoxOstukorv.Name = "listBoxOstukorv";
            this.listBoxOstukorv.Size = new System.Drawing.Size(264, 212);
            this.listBoxOstukorv.TabIndex = 37;
            // 
            // Kaasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOstukorv);
            this.Controls.Add(this.lblTervitamine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.btnToode);
            this.Controls.Add(this.btnMaksma);
            this.Controls.Add(this.btnOstukorvist);
            this.Controls.Add(this.btnOstukorvile);
            this.Controls.Add(this.Kat_box);
            this.Controls.Add(this.listBoxToodet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kaasa";
            this.Text = "Kaasa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxToodet;
        private System.Windows.Forms.ComboBox Kat_box;
        private System.Windows.Forms.Button btnOstukorvile;
        private System.Windows.Forms.Button btnOstukorvist;
        private System.Windows.Forms.Button btnMaksma;
        private System.Windows.Forms.Button btnToode;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTervitamine;
        private System.Windows.Forms.ListBox listBoxOstukorv;
    }
}