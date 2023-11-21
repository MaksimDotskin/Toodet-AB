namespace Toodet_Dotskin
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kat_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lisa_kat_butt = new System.Windows.Forms.Button();
            this.label_hind = new System.Windows.Forms.Label();
            this.textBox_hind = new System.Windows.Forms.TextBox();
            this.textBox_toode = new System.Windows.Forms.TextBox();
            this.label_toode = new System.Windows.Forms.Label();
            this.textBox_kogus = new System.Windows.Forms.TextBox();
            this.label_kogus = new System.Windows.Forms.Label();
            this.button_lisa = new System.Windows.Forms.Button();
            this.button_Uuenda = new System.Windows.Forms.Button();
            this.button_Kustuta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Kat_box
            // 
            this.Kat_box.FormattingEnabled = true;
            this.Kat_box.Location = new System.Drawing.Point(82, 234);
            this.Kat_box.Name = "Kat_box";
            this.Kat_box.Size = new System.Drawing.Size(120, 21);
            this.Kat_box.TabIndex = 1;
            this.Kat_box.SelectedIndexChanged += new System.EventHandler(this.Kat_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategooriad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lisa_kat_butt
            // 
            this.lisa_kat_butt.Location = new System.Drawing.Point(231, 234);
            this.lisa_kat_butt.Name = "lisa_kat_butt";
            this.lisa_kat_butt.Size = new System.Drawing.Size(120, 21);
            this.lisa_kat_butt.TabIndex = 3;
            this.lisa_kat_butt.Text = "Lisa kategooriat";
            this.lisa_kat_butt.UseVisualStyleBackColor = true;
            // 
            // label_hind
            // 
            this.label_hind.AutoSize = true;
            this.label_hind.Location = new System.Drawing.Point(12, 214);
            this.label_hind.Name = "label_hind";
            this.label_hind.Size = new System.Drawing.Size(35, 13);
            this.label_hind.TabIndex = 5;
            this.label_hind.Text = "Hind: ";
            // 
            // textBox_hind
            // 
            this.textBox_hind.Location = new System.Drawing.Point(82, 207);
            this.textBox_hind.Name = "textBox_hind";
            this.textBox_hind.Size = new System.Drawing.Size(120, 20);
            this.textBox_hind.TabIndex = 12;
            this.textBox_hind.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_toode
            // 
            this.textBox_toode.Location = new System.Drawing.Point(82, 154);
            this.textBox_toode.Name = "textBox_toode";
            this.textBox_toode.Size = new System.Drawing.Size(120, 20);
            this.textBox_toode.TabIndex = 14;
            // 
            // label_toode
            // 
            this.label_toode.AutoSize = true;
            this.label_toode.Location = new System.Drawing.Point(12, 161);
            this.label_toode.Name = "label_toode";
            this.label_toode.Size = new System.Drawing.Size(41, 13);
            this.label_toode.TabIndex = 13;
            this.label_toode.Text = "Toode:";
            // 
            // textBox_kogus
            // 
            this.textBox_kogus.Location = new System.Drawing.Point(82, 181);
            this.textBox_kogus.Name = "textBox_kogus";
            this.textBox_kogus.Size = new System.Drawing.Size(120, 20);
            this.textBox_kogus.TabIndex = 16;
            // 
            // label_kogus
            // 
            this.label_kogus.AutoSize = true;
            this.label_kogus.Location = new System.Drawing.Point(12, 188);
            this.label_kogus.Name = "label_kogus";
            this.label_kogus.Size = new System.Drawing.Size(40, 13);
            this.label_kogus.TabIndex = 15;
            this.label_kogus.Text = "Kogus:";
            // 
            // button_lisa
            // 
            this.button_lisa.Location = new System.Drawing.Point(416, 261);
            this.button_lisa.Name = "button_lisa";
            this.button_lisa.Size = new System.Drawing.Size(120, 21);
            this.button_lisa.TabIndex = 17;
            this.button_lisa.Text = "Lisa";
            this.button_lisa.UseVisualStyleBackColor = true;
            this.button_lisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Uuenda
            // 
            this.button_Uuenda.Location = new System.Drawing.Point(542, 261);
            this.button_Uuenda.Name = "button_Uuenda";
            this.button_Uuenda.Size = new System.Drawing.Size(120, 21);
            this.button_Uuenda.TabIndex = 18;
            this.button_Uuenda.Text = "Uuenda";
            this.button_Uuenda.UseVisualStyleBackColor = true;
            // 
            // button_Kustuta
            // 
            this.button_Kustuta.Location = new System.Drawing.Point(668, 261);
            this.button_Kustuta.Name = "button_Kustuta";
            this.button_Kustuta.Size = new System.Drawing.Size(120, 21);
            this.button_Kustuta.TabIndex = 19;
            this.button_Kustuta.Text = "Kustuta";
            this.button_Kustuta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Kustuta);
            this.Controls.Add(this.button_Uuenda);
            this.Controls.Add(this.button_lisa);
            this.Controls.Add(this.textBox_kogus);
            this.Controls.Add(this.label_kogus);
            this.Controls.Add(this.textBox_toode);
            this.Controls.Add(this.label_toode);
            this.Controls.Add(this.textBox_hind);
            this.Controls.Add(this.label_hind);
            this.Controls.Add(this.lisa_kat_butt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kat_box);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Kat_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lisa_kat_butt;
        private System.Windows.Forms.Label label_hind;
        private System.Windows.Forms.TextBox textBox_hind;
        private System.Windows.Forms.TextBox textBox_toode;
        private System.Windows.Forms.Label label_toode;
        private System.Windows.Forms.TextBox textBox_kogus;
        private System.Windows.Forms.Label label_kogus;
        private System.Windows.Forms.Button button_lisa;
        private System.Windows.Forms.Button button_Uuenda;
        private System.Windows.Forms.Button button_Kustuta;
    }
}

