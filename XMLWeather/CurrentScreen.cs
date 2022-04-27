using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;

            double tempCurrent = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp));
            tempLabel.Text = tempCurrent.ToString("#°C");

            if (tempCurrent > 0)
            {
                maxOutput.Text = tempCurrent.ToString("#°C");
            }
            else
            {
                maxOutput.Text = "0°C";
            }


            double lowTemp = Math.Round(Convert.ToDouble(Form1.days[0].tempLow));
            minOutput.Text = lowTemp.ToString("#°C");
            if (lowTemp > 0)
            {
                maxOutput.Text = lowTemp.ToString("#°C");
            }
            else
            {
                maxOutput.Text = "0°C";
            }

            double highTemp = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh));
            if (highTemp > 0)
            {
                maxOutput.Text = highTemp.ToString("#°C");
            }
            else
            {
                maxOutput.Text = "0°C";
            }
            
            cloudCoverLabel.Text = Form1.days[0].condition;

            int conditionCode = Convert.ToInt32(Form1.days[0].precipitation);

            if (conditionCode >=200 && conditionCode < 600)
            {
                weatherImageBox.Image = Properties.Resources.rain2;
                BackColor = Color.SlateBlue;
            }

            else if (conditionCode >= 600 && conditionCode < 700)
            {
                weatherImageBox.Image = Properties.Resources.snow1;
                BackColor = Color.Gray;
            }

            else if (conditionCode >= 800 && conditionCode < 803)
            {
                weatherImageBox.Image = Properties.Resources.sunny;
                BackColor = Color.Maroon;
            }

            else if (conditionCode >= 803)
            {
                weatherImageBox.Image = Properties.Resources.cloudy;
                BackColor = Color.Gray;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
