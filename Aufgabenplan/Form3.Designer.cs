namespace Aufgabenplan
{
    partial class Form3
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
            this.Erinnerung_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Erinnerung_lb
            // 
            this.Erinnerung_lb.AutoSize = true;
            this.Erinnerung_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erinnerung_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Erinnerung_lb.Location = new System.Drawing.Point(21, 30);
            this.Erinnerung_lb.MaximumSize = new System.Drawing.Size(369, 25);
            this.Erinnerung_lb.MinimumSize = new System.Drawing.Size(369, 25);
            this.Erinnerung_lb.Name = "Erinnerung_lb";
            this.Erinnerung_lb.Size = new System.Drawing.Size(369, 25);
            this.Erinnerung_lb.TabIndex = 0;
            this.Erinnerung_lb.Text = "Du hast eine Aufgabe zuerledigen";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(411, 85);
            this.Controls.Add(this.Erinnerung_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1500, 0);
            this.MaximumSize = new System.Drawing.Size(411, 85);
            this.MinimumSize = new System.Drawing.Size(411, 85);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Erinnerung_lb;
    }
}