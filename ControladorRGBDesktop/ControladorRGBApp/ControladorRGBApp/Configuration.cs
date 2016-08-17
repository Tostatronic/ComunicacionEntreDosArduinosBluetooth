using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ControladorRGBApp
{
    public partial class Configuration : Form
    {
        ArduinoComunication configuration = new ArduinoComunication();
        string[] eP;
        public Configuration()
        {
            InitializeComponent();
            cmbSeleccion.SelectedIndex = 0;
            try
            {
                eP = configuration.ExistingPortsOnly();
                cmbSeleccion.Items.AddRange(configuration.ExistingPorts());
            }
            catch (SensorNotFoundExceptio e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbCancel_MouseClick(object sender, MouseEventArgs e)
        {
            Thread.Sleep(1000);
            this.Close();
        }

        private void pcbOk_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbSeleccion.SelectedIndex != 0)
            {
                Form1 frm1 = new Form1(cmbSeleccion.SelectedIndex - 1,eP);
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un puerto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
