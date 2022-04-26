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

            double tempCurrent = Convert.ToDouble(Form1.days[0].currentTemp);
            tempLabel.Text = tempCurrent.ToString("#°C");

            double lowTemp = Convert.ToDouble(Form1.days[0].tempLow);
            minOutput.Text = lowTemp.ToString("#°C");

            double highTemp = Convert.ToDouble(Form1.days[0].tempHigh);
            maxOutput.Text = highTemp.ToString("#°C");
           
            
            cloudCoverLabel.Text = Form1.days[0].condition;

            int conditionCode = Convert.ToInt32(Form1.days[0].precipitation);

            if (conditionCode >=200 && conditionCode < 600)
            {
                weatherImageBox.Image = Properties.Resources.rain1;
            }

            else if (conditionCode >= 600 && conditionCode < 700)
            {
                weatherImageBox.Image = Properties.Resources.snow1;
            }

            else if (conditionCode >= 800 && conditionCode < 803)
            {
                weatherImageBox.Image = Properties.Resources.sunny;
            }

            else if (conditionCode >= 803)
            {
                weatherImageBox.Image = Properties.Resources.cloudy;
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
