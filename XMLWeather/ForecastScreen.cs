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
          
            double minOne = Convert.ToDouble(Form1.days[1].tempLow);
            min1.Text = minOne.ToString("#°C");
            double maxOne = Convert.ToDouble(Form1.days[1].tempHigh);
            max1.Text = maxOne.ToString("#°C");


            date2.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();

            double minTwo = Convert.ToDouble(Form1.days[2].tempLow);
            min2.Text = minTwo.ToString("#°C");
            double maxTwo = Convert.ToDouble(Form1.days[2].tempHigh);
            max2.Text = maxTwo.ToString("#°C");


            date3.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();

            double minThree = Convert.ToDouble(Form1.days[3].tempLow);
            min3.Text = minThree.ToString("#°C");
            double maxThree = Convert.ToDouble(Form1.days[3].tempHigh);
            max3.Text = maxThree.ToString("#°C");


            date4.Text = DateTime.Now.AddDays(4).DayOfWeek.ToString();

            double minFour = Convert.ToDouble(Form1.days[4].tempLow);
            min4.Text = minFour.ToString("#°C");
            double maxFour = Convert.ToDouble(Form1.days[4].tempHigh);
            max4.Text = maxFour.ToString("#°C");


            date5.Text = DateTime.Now.AddDays(5).DayOfWeek.ToString();

            double minFive = Convert.ToDouble(Form1.days[5].tempLow);
            min5.Text = minFive.ToString("#°C");
            double maxFive = Convert.ToDouble(Form1.days[5].tempHigh);
            max5.Text = maxFive.ToString("#°C");


            date6.Text = DateTime.Now.AddDays(6).DayOfWeek.ToString();

            double minSix = Convert.ToDouble(Form1.days[6].tempLow);
            min6.Text = minSix.ToString("#°C");
            double maxSix = Convert.ToDouble(Form1.days[6].tempHigh);
            max6.Text = maxSix.ToString("#°C");
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
