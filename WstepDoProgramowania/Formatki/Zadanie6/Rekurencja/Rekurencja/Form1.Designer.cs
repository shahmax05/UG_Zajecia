namespace Rekurencja
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
            this.lbStruktura = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSprawdz = new System.Windows.Forms.Button();
            this.tbSciezka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbStruktura
            // 
            this.lbStruktura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStruktura.FormattingEnabled = true;
            this.lbStruktura.ItemHeight = 16;
            this.lbStruktura.Location = new System.Drawing.Point(31, 107);
            this.lbStruktura.Margin = new System.Windows.Forms.Padding(4);
            this.lbStruktura.Name = "lbStruktura";
            this.lbStruktura.Size = new System.Drawing.Size(956, 244);
            this.lbStruktura.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(30, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(203, 64);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Kliknij dwukrotnie, aby wskazać katalog";
            // 
            // btnSprawdz
            // 
            this.btnSprawdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSprawdz.Location = new System.Drawing.Point(749, 18);
            this.btnSprawdz.Margin = new System.Windows.Forms.Padding(4);
            this.btnSprawdz.Name = "btnSprawdz";
            this.btnSprawdz.Size = new System.Drawing.Size(240, 65);
            this.btnSprawdz.TabIndex = 17;
            this.btnSprawdz.Text = "Wyświetl strukturę katalogu";
            this.btnSprawdz.UseVisualStyleBackColor = true;
            this.btnSprawdz.Click += new System.EventHandler(this.btnSprawdz_Click);
            // 
            // tbSciezka
            // 
            this.tbSciezka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSciezka.Location = new System.Drawing.Point(255, 49);
            this.tbSciezka.Margin = new System.Windows.Forms.Padding(4);
            this.tbSciezka.Name = "tbSciezka";
            this.tbSciezka.Size = new System.Drawing.Size(467, 31);
            this.tbSciezka.TabIndex = 16;
            this.tbSciezka.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSciezka_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 368);
            this.Controls.Add(this.lbStruktura);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSprawdz);
            this.Controls.Add(this.tbSciezka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStruktura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSprawdz;
        private System.Windows.Forms.TextBox tbSciezka;
    }
}

