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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {

            //double tempCurrent = Convert.ToDouble(Form1.days[0].currentTemp);
            //tempLabel.Text = tempCurrent.ToString("#°C");


            date1.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;

            date2.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;

            date3.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;

            date4.Text = DateTime.Now.AddDays(4).DayOfWeek.ToString();
            min4.Text = Form1.days[4].tempLow;
            max4.Text = Form1.days[4].tempHigh;

            date5.Text = DateTime.Now.AddDays(5).DayOfWeek.ToString();
            min5.Text = Form1.days[5].tempLow;
            max5.Text = Form1.days[5].tempHigh;


            date6.Text = DateTime.Now.AddDays(6).DayOfWeek.ToString();
            min6.Text = Form1.days[6].tempLow;
            max6.Text = Form1.days[6].tempHigh;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }


    }
}
