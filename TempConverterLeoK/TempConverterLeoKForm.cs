using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverterLeoK
{
    public partial class frmTempConverterLeoK : Form
    {
        public frmTempConverterLeoK()
        {
            InitializeComponent();
        }

        public void ConvertCtoF(double celsius)
        {
            //declare fehrenheit
            double fahrenheit;

            //calculate the answer
            fahrenheit = ((double) (9) / (double) (5)) * celsius + 32;

            //Display the answer
            MessageBox.Show(celsius + " celsius is " + fahrenheit + " in fahrenheit.", "Celsius to Fahrenheit");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //declare celcius
            double userCelsius;

            //convert the users input to a double
            userCelsius = Convert.ToDouble(txtCelsius.Text);

            //call the procedure above
            this.ConvertCtoF(userCelsius);
        }
    }
}
