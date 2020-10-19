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
            double current = Convert.ToDouble(Form1.days[0].currentTemp);
            tempLabel.Text = current.ToString("##") + " \u00B0";

            double feelsLike = Convert.ToDouble(Form1.days[0].feelsLike);
            feelLabel.Text = feelsLike.ToString("##") + " \u00B0";

            double low = Convert.ToDouble(Form1.days[0].tempLow);
            minOutput.Text = low.ToString("##") + " \u00B0";

            double high = Convert.ToDouble(Form1.days[0].tempHigh);
            maxOutput.Text = high.ToString("##") + " \u00B0";

             double conditionCur = Convert.ToDouble(Form1.days[0].condition);
            //double conditionCur = 521;
            #region Condition
            if (conditionCur == 800)
            {
                currentWeather.Text = "Clear Sky";
                BackColor = Color.DeepSkyBlue;
                currentWeatherBox.BackgroundImage = Properties.Resources.clearSky;
            }
            else if (conditionCur > 800 && conditionCur < 805)
            {
                currentWeather.Text = "Cloudy";
                BackColor = Color.SlateGray;
                currentWeatherBox.BackgroundImage = Properties.Resources.cloudy;
            }
            else if (conditionCur > 700 && conditionCur < 782)
            {
                currentWeather.Text = "Fog";
                BackColor = Color.SlateGray;
                currentWeatherBox.BackgroundImage = Properties.Resources.atmosphere;
            }
            else if (conditionCur > 599 && conditionCur < 623)
            {
                currentWeather.Text = "Snow";
                BackColor = Color.Gainsboro;
                currentWeatherBox.BackgroundImage = Properties.Resources.snow;
            }
            else if (conditionCur > 519 && conditionCur < 532)
            {
                currentWeather.Text = "Rain";
                BackColor = Color.Gainsboro;
                currentWeatherBox.BackgroundImage = Properties.Resources.showerRain;
            }
            else if (conditionCur > 499 && conditionCur < 512)
            {
                currentWeather.Text = "Rain";
                BackColor = Color.CornflowerBlue;
                currentWeatherBox.BackgroundImage = Properties.Resources.rain;
            }
            else if (conditionCur > 299 && conditionCur < 322)
            {
                currentWeather.Text = "Drizzle";
                BackColor = Color.CornflowerBlue;
                currentWeatherBox.BackgroundImage = Properties.Resources.rain;
            }
            else if (conditionCur > 199 && conditionCur < 233)
            {
                currentWeather.Text = "ThunderStorm";
                BackColor = Color.DimGray;
                currentWeatherBox.BackgroundImage = Properties.Resources.thunderstorm;
            }
            #endregion
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void tempLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
