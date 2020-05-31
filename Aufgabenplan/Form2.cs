using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabenplan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            NeuAufgabe_dtp.Format = DateTimePickerFormat.Time;
            NeuAufgabe_dtp.ShowUpDown = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Aktuelle_zeit_lb.Text = DateTime.Now.ToLongTimeString();
        }

        private void Save_bt_Click(object sender, EventArgs e)
        {
            string[] aufgaben = new string[4];
            string[] zeitpunkt = new string[4];
            int i = Convert.ToInt32(AnzahlAufgaben_lb.Text);
            aufgaben[i] = NeuAufgabe_txtbox.Text;
            zeitpunkt[i] = NeuAufgabe_dtp.Text;

            Aufgabenliste_txtbox.Text += aufgaben[i] + Environment.NewLine;
            Datumliste_txtbox.Text += zeitpunkt[i] + Environment.NewLine;


            i = i + 1;
            AnzahlAufgaben_lb.Text = Convert.ToString(i);

            

        }
        
        private void Erinnerung()
        {
            
        }
        

    }
}
