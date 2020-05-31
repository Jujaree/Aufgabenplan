namespace Aufgabenplan
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NeuAufgabe_txtbox = new System.Windows.Forms.TextBox();
            this.NeuAufgabe_dtp = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Save_bt = new System.Windows.Forms.Button();
            this.Löschen_bt = new System.Windows.Forms.Button();
            this.Aufgabenliste_txtbox = new System.Windows.Forms.TextBox();
            this.Aktuelle_zeit_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.min_npd = new System.Windows.Forms.NumericUpDown();
            this.Erinnerung_lb = new System.Windows.Forms.Label();
            this.Minuten_lb = new System.Windows.Forms.Label();
            this.AnzahlAufgaben_lb = new System.Windows.Forms.Label();
            this.Aufgaben_lb = new System.Windows.Forms.Label();
            this.Datumliste_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.min_npd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neue Aufgabe";
            // 
            // NeuAufgabe_txtbox
            // 
            this.NeuAufgabe_txtbox.Location = new System.Drawing.Point(12, 34);
            this.NeuAufgabe_txtbox.Name = "NeuAufgabe_txtbox";
            this.NeuAufgabe_txtbox.Size = new System.Drawing.Size(181, 20);
            this.NeuAufgabe_txtbox.TabIndex = 1;
            // 
            // NeuAufgabe_dtp
            // 
            this.NeuAufgabe_dtp.Location = new System.Drawing.Point(200, 34);
            this.NeuAufgabe_dtp.Name = "NeuAufgabe_dtp";
            this.NeuAufgabe_dtp.Size = new System.Drawing.Size(200, 20);
            this.NeuAufgabe_dtp.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Save_bt
            // 
            this.Save_bt.Location = new System.Drawing.Point(12, 61);
            this.Save_bt.Name = "Save_bt";
            this.Save_bt.Size = new System.Drawing.Size(74, 23);
            this.Save_bt.TabIndex = 3;
            this.Save_bt.Text = "Speichern";
            this.Save_bt.UseVisualStyleBackColor = true;
            this.Save_bt.Click += new System.EventHandler(this.Save_bt_Click);
            // 
            // Löschen_bt
            // 
            this.Löschen_bt.Location = new System.Drawing.Point(117, 61);
            this.Löschen_bt.Name = "Löschen_bt";
            this.Löschen_bt.Size = new System.Drawing.Size(76, 23);
            this.Löschen_bt.TabIndex = 4;
            this.Löschen_bt.Text = "Löschen";
            this.Löschen_bt.UseVisualStyleBackColor = true;
            // 
            // Aufgabenliste_txtbox
            // 
            this.Aufgabenliste_txtbox.Location = new System.Drawing.Point(16, 268);
            this.Aufgabenliste_txtbox.Multiline = true;
            this.Aufgabenliste_txtbox.Name = "Aufgabenliste_txtbox";
            this.Aufgabenliste_txtbox.Size = new System.Drawing.Size(271, 264);
            this.Aufgabenliste_txtbox.TabIndex = 5;
            // 
            // Aktuelle_zeit_lb
            // 
            this.Aktuelle_zeit_lb.AutoSize = true;
            this.Aktuelle_zeit_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aktuelle_zeit_lb.Location = new System.Drawing.Point(717, 13);
            this.Aktuelle_zeit_lb.Name = "Aktuelle_zeit_lb";
            this.Aktuelle_zeit_lb.Size = new System.Drawing.Size(51, 16);
            this.Aktuelle_zeit_lb.TabIndex = 6;
            this.Aktuelle_zeit_lb.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Abgabezeitpunkt";
            // 
            // min_npd
            // 
            this.min_npd.Location = new System.Drawing.Point(293, 64);
            this.min_npd.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.min_npd.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.min_npd.Name = "min_npd";
            this.min_npd.Size = new System.Drawing.Size(57, 20);
            this.min_npd.TabIndex = 8;
            this.min_npd.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Erinnerung_lb
            // 
            this.Erinnerung_lb.AutoSize = true;
            this.Erinnerung_lb.Location = new System.Drawing.Point(226, 66);
            this.Erinnerung_lb.Name = "Erinnerung_lb";
            this.Erinnerung_lb.Size = new System.Drawing.Size(61, 13);
            this.Erinnerung_lb.TabIndex = 9;
            this.Erinnerung_lb.Text = "Erinnerung:";
            // 
            // Minuten_lb
            // 
            this.Minuten_lb.AutoSize = true;
            this.Minuten_lb.Location = new System.Drawing.Point(356, 66);
            this.Minuten_lb.Name = "Minuten_lb";
            this.Minuten_lb.Size = new System.Drawing.Size(23, 13);
            this.Minuten_lb.TabIndex = 10;
            this.Minuten_lb.Text = "min";
            // 
            // AnzahlAufgaben_lb
            // 
            this.AnzahlAufgaben_lb.AutoSize = true;
            this.AnzahlAufgaben_lb.Location = new System.Drawing.Point(16, 120);
            this.AnzahlAufgaben_lb.Name = "AnzahlAufgaben_lb";
            this.AnzahlAufgaben_lb.Size = new System.Drawing.Size(13, 13);
            this.AnzahlAufgaben_lb.TabIndex = 11;
            this.AnzahlAufgaben_lb.Text = "0";
            // 
            // Aufgaben_lb
            // 
            this.Aufgaben_lb.AutoSize = true;
            this.Aufgaben_lb.Location = new System.Drawing.Point(33, 120);
            this.Aufgaben_lb.Name = "Aufgaben_lb";
            this.Aufgaben_lb.Size = new System.Drawing.Size(53, 13);
            this.Aufgaben_lb.TabIndex = 12;
            this.Aufgaben_lb.Text = "Aufgaben";
            // 
            // Datumliste_txtbox
            // 
            this.Datumliste_txtbox.Location = new System.Drawing.Point(294, 268);
            this.Datumliste_txtbox.Multiline = true;
            this.Datumliste_txtbox.Name = "Datumliste_txtbox";
            this.Datumliste_txtbox.Size = new System.Drawing.Size(106, 264);
            this.Datumliste_txtbox.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Datumliste_txtbox);
            this.Controls.Add(this.Aufgaben_lb);
            this.Controls.Add(this.AnzahlAufgaben_lb);
            this.Controls.Add(this.Minuten_lb);
            this.Controls.Add(this.Erinnerung_lb);
            this.Controls.Add(this.min_npd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Aktuelle_zeit_lb);
            this.Controls.Add(this.Aufgabenliste_txtbox);
            this.Controls.Add(this.Löschen_bt);
            this.Controls.Add(this.Save_bt);
            this.Controls.Add(this.NeuAufgabe_dtp);
            this.Controls.Add(this.NeuAufgabe_txtbox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form2";
            this.Text = "Aufgabenplan";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.min_npd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NeuAufgabe_txtbox;
        private System.Windows.Forms.DateTimePicker NeuAufgabe_dtp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Save_bt;
        private System.Windows.Forms.Button Löschen_bt;
        private System.Windows.Forms.TextBox Aufgabenliste_txtbox;
        private System.Windows.Forms.Label Aktuelle_zeit_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown min_npd;
        private System.Windows.Forms.Label Erinnerung_lb;
        private System.Windows.Forms.Label Minuten_lb;
        private System.Windows.Forms.Label AnzahlAufgaben_lb;
        private System.Windows.Forms.Label Aufgaben_lb;
        private System.Windows.Forms.TextBox Datumliste_txtbox;
    }
}