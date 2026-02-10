using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krasniqi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GgTBerechnen_Click(object sender, EventArgs e)
        {
            // Eingaben prüfen
            if (!int.TryParse(txt1.Text, out int a) ||
                !int.TryParse(txt2.Text, out int b))
            {
                txt3.Text = "Ungültige Eingabe!";
                return;
            }

            // GGT berechnen
            int ggt = BerechneGgt(a, b);

            // Ergebnis anzeigen
            txt3.Text = ggt.ToString();
        }

        private int BerechneGgt(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);

            while (y != 0)
            {
                int rest = x % y;
                x = y;
                y = rest;
            }

            return x;
        }
    }
}