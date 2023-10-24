using System;
using System.Windows.Forms;

namespace unit_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                double fromValue = Convert.ToDouble(textBox1.Text);

                // Define conversion factors
                const double meterToKilometer = 0.001;
                const double meterToCentimeter = 100;
                const double meterToMillimeter = 1000;

                double result = fromValue;

                // Perform unit conversion based on selected units
                if (comboBox1.SelectedItem.ToString() == "Meter")
                {
                    if (comboBox2.SelectedItem.ToString() == "Kilometer")
                        result = fromValue * meterToKilometer;
                    else if (comboBox2.SelectedItem.ToString() == "Centimeter")
                        result = fromValue * meterToCentimeter;
                    else if (comboBox2.SelectedItem.ToString() == "Millimeter")
                        result = fromValue * meterToMillimeter;
                }

                // Display the result
                textBox2.Text = result.ToString();
            }

            else
            {
                MessageBox.Show("Please select units for conversion.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
