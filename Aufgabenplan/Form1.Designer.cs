namespace Aufgabenplan
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_bt = new System.Windows.Forms.Button();
            this.Aufgabe_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_bt
            // 
            this.Start_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_bt.Location = new System.Drawing.Point(140, 213);
            this.Start_bt.Name = "Start_bt";
            this.Start_bt.Size = new System.Drawing.Size(100, 45);
            this.Start_bt.TabIndex = 0;
            this.Start_bt.Text = "Starten";
            this.Start_bt.UseVisualStyleBackColor = true;
            this.Start_bt.Click += new System.EventHandler(this.Start_bt_Click);
            // 
            // Aufgabe_lb
            // 
            this.Aufgabe_lb.AutoSize = true;
            this.Aufgabe_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aufgabe_lb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aufgabe_lb.Location = new System.Drawing.Point(80, 63);
            this.Aufgabe_lb.Name = "Aufgabe_lb";
            this.Aufgabe_lb.Size = new System.Drawing.Size(241, 39);
            this.Aufgabe_lb.TabIndex = 1;
            this.Aufgabe_lb.Text = "Aufgabenplan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Aufgabe_lb);
            this.Controls.Add(this.Start_bt);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "Aufgabenplan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_bt;
        private System.Windows.Forms.Label Aufgabe_lb;
    }
}

