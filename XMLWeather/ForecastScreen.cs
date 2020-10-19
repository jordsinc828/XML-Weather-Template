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
            date1.Text = Form1.days[1].date;

            double low1 = Convert.ToDouble(Form1.days[1].tempLow);
            min1.Text = low1.ToString("##") + " \u00B0";

            double high1 = Convert.ToDouble(Form1.days[1].tempHigh);
            max1.Text = high1.ToString("##") + " \u00B0";
            #region Day 1 condition

            double conditionDay1 = Convert.ToDouble(Form1.days[1].condition);

            if (conditionDay1 == 800)
            {
                weatherDay1.BackgroundImage = Properties.Resources.clearSky;
            }
            else if (conditionDay1 > 800 && conditionDay1 < 805)
            {               
                weatherDay1.BackgroundImage = Properties.Resources.cloudy;
            }
            else if (conditionDay1 > 700 && conditionDay1 < 782)
            {
                weatherDay1.BackgroundImage = Properties.Resources.atmosphere;
            }
            else if (conditionDay1 > 599 && conditionDay1 < 623)
            {
                weatherDay1.BackgroundImage = Properties.Resources.snow;
            }
            else if (conditionDay1 > 499 && conditionDay1 < 532)
            {
                weatherDay1.BackgroundImage = Properties.Resources.rain;
            }
            else if (conditionDay1 > 299 && conditionDay1 < 322)
            {
                weatherDay1.BackgroundImage = Properties.Resources.rain;
            }
            else if (conditionDay1 > 199 && conditionDay1 < 233)
            {
                weatherDay1.BackgroundImage = Properties.Resources.thunderstorm;
            }
            #endregion

            date2.Text = Form1.days[2].date;

            double low2 = Convert.ToDouble(Form1.days[2].tempLow);
            min2.Text = low2.ToString("##") + " \u00B0";

            double high2 = Convert.ToDouble(Form1.days[2].tempHigh);
            max2.Text = high2.ToString("##") + " \u00B0";
            #region  Day 2 condition
            double conditionDay2 = Convert.ToDouble(Form1.days[2].condition);

            if (conditionDay2 == 800)
            {
                weatherDay2.BackgroundImage = Properties.Resources.clearSky;
            }
            else if (conditionDay2 > 800 && conditionDay2 < 805)
            {
                weatherDay2.BackgroundImage = Properties.Resources.cloudy;
            }
            else if (conditionDay2 > 700 && conditionDay2 < 782)
            {
                weatherDay2.BackgroundImage = Properties.Resources.atmosphere;
            }
            else if (conditionDay2 > 599 && conditionDay2 < 623)
            {
                weatherDay2.BackgroundImage = Properties.Resources.snow;
            }
            else if (conditionDay2 > 499 && conditionDay2 < 532)
            {
                weatherDay2.BackgroundImage = Properties.Resources.rain;
            }
            else if (conditionDay2 > 299 && conditionDay2 < 322)
            {
                weatherDay2.BackgroundImage = Properties.Resources.rain;
            }
            else if (conditionDay2 > 199 && conditionDay2 < 233)
            {
                weatherDay2.BackgroundImage = Properties.Resources.thunderstorm;
            }
            #endregion

            date3.Text = Form1.days[3].date;

            double low3 = Convert.ToDouble(Form1.days[3].tempLow);
            min3.Text = low3.ToString("##") + " \u00B0";

            double high3 = Convert.ToDouble(Form1.days[3].tempHigh);
            max3.Text = high3.ToString("##") + " \u00B0";
            #region Day 3 condition
            double conditionDay3 = Convert.ToDouble(Form1.days[3].condition);

            if (conditionDay3 == 800)
            {
                weatherDay1.BackgroundImage = Properties.Resources.clearSky;
            }
            else if (conditionDay3 > 800 && conditionDay3 < 805)
            {
                weatherDay3.BackgroundImage = Properties.Resources.cloudy;
            }
            else if (conditionDay3 > 700 && conditionDay3 < 782)
            {
                weatherDay3.BackgroundImage = Properties.Resources.atmosphere;
            }
            else if (conditionDay3 > 599 && conditionDay3 < 623)
            {
                weatherDay3.BackgroundImage = Properties.Resources.snow;
            }
            else if (conditionDay3 > 499 && conditionDay3 < 532)
            {
                weatherDay3.BackgroundImage = Properties.Resources.rain;
            }
            else if (conditionDay3 > 299 && conditionDay3 < 322)
            {
                weatherDay3.BackgroundImage = Properties.Resources.rain;
            }
            else if (conditionDay3 > 199 && conditionDay3 < 233)
            {
                weatherDay3.BackgroundImage = Properties.Resources.thunderstorm;
            }
            #endregion

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
