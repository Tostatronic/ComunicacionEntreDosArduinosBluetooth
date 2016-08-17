using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControladorRGBApp
{
    public partial class Form1 : Form
    {
        int indexPort;
        ArduinoComunication ardC = new ArduinoComunication();
        public Form1(int indexPort,string[] ports)
        {
            InitializeComponent();
            this.indexPort = indexPort;
            ardC.initializeSensor(indexPort, ports);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            nudR.Value = scbR.Value;
            ChangeColor();
        }

        private void scbG_Scroll(object sender, ScrollEventArgs e)
        {
            nudG.Value = scbG.Value;
            ChangeColor();
        }

        private void scbB_Scroll(object sender, ScrollEventArgs e)
        {
            nudB.Value = scbB.Value;
            ChangeColor();
        }
        private void ChangeColor()
        {
            pctBColorRGB.BackColor = Color.FromArgb((int)nudR.Value, (int)nudG.Value, (int)nudB.Value);
        }

        private void nudR_ValueChanged(object sender, EventArgs e)
        {
            scbR.Value = (int)nudR.Value;
            ChangeColor();
        }

        private void nudG_ValueChanged(object sender, EventArgs e)
        {
            scbG.Value = (int)nudG.Value;
            ChangeColor();
        }

        private void nudB_ValueChanged(object sender, EventArgs e)
        {
            scbB.Value = (int)nudB.Value;
            ChangeColor();
        }

        private void btnAsingColor_Click(object sender, EventArgs e)
        {
            ardC.WriteColorRGB((Int16)nudR.Value, (Int16)nudG.Value, (Int16)nudB.Value);
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            if (cd1.ShowDialog() == DialogResult.OK)
            {
                Color clr = cd1.Color;
                nudR.Value=clr.R;
                nudG.Value = clr.G;
                nudB.Value = clr.B;
            }
        }
    }
}
