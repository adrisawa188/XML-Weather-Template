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
