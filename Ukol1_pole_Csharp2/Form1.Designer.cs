namespace Ukol1_pole_Csharp2
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cisloN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vzestup = new System.Windows.Forms.RadioButton();
            this.sestup = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generovani = new System.Windows.Forms.Button();
            this.seř_pole = new System.Windows.Forms.TextBox();
            this.org_pole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cisloN
            // 
            this.cisloN.Location = new System.Drawing.Point(99, 54);
            this.cisloN.Name = "cisloN";
            this.cisloN.Size = new System.Drawing.Size(87, 20);
            this.cisloN.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kolik chceš\r\ngenerovat čísel ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Řadit:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vzestup
            // 
            this.vzestup.AutoSize = true;
            this.vzestup.Location = new System.Drawing.Point(99, 116);
            this.vzestup.Name = "vzestup";
            this.vzestup.Size = new System.Drawing.Size(75, 17);
            this.vzestup.TabIndex = 16;
            this.vzestup.Text = "Vzestupně";
            this.vzestup.UseVisualStyleBackColor = true;
            // 
            // sestup
            // 
            this.sestup.AutoSize = true;
            this.sestup.Checked = true;
            this.sestup.Location = new System.Drawing.Point(99, 93);
            this.sestup.Name = "sestup";
            this.sestup.Size = new System.Drawing.Size(70, 17);
            this.sestup.TabIndex = 15;
            this.sestup.TabStop = true;
            this.sestup.Text = "Sestupně";
            this.sestup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seřazené pole:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Originální pole:";
            // 
            // generovani
            // 
            this.generovani.Location = new System.Drawing.Point(99, 139);
            this.generovani.Name = "generovani";
            this.generovani.Size = new System.Drawing.Size(87, 38);
            this.generovani.TabIndex = 12;
            this.generovani.Text = "Generuj";
            this.generovani.UseVisualStyleBackColor = true;
            this.generovani.Click += new System.EventHandler(this.generovani_Click);
            // 
            // seř_pole
            // 
            this.seř_pole.Location = new System.Drawing.Point(192, 25);
            this.seř_pole.Multiline = true;
            this.seř_pole.Name = "seř_pole";
            this.seř_pole.ReadOnly = true;
            this.seř_pole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.seř_pole.Size = new System.Drawing.Size(76, 152);
            this.seř_pole.TabIndex = 11;
            // 
            // org_pole
            // 
            this.org_pole.Location = new System.Drawing.Point(12, 25);
            this.org_pole.Multiline = true;
            this.org_pole.Name = "org_pole";
            this.org_pole.ReadOnly = true;
            this.org_pole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.org_pole.Size = new System.Drawing.Size(78, 152);
            this.org_pole.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 192);
            this.Controls.Add(this.cisloN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vzestup);
            this.Controls.Add(this.sestup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generovani);
            this.Controls.Add(this.seř_pole);
            this.Controls.Add(this.org_pole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Úkol1 pole C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cisloN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton vzestup;
        private System.Windows.Forms.RadioButton sestup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generovani;
        private System.Windows.Forms.TextBox seř_pole;
        private System.Windows.Forms.TextBox org_pole;
    }
}

