using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Judith_Tech_Weather.Entities;

namespace Judith_Tech_Weather
{
    public partial class Form1 : Form
    {
        CityWeatherManager CityWeatherManager = new CityWeatherManager();
        public Form1()
        {
            InitializeComponent();
            GetCurrentTempBtn.Enabled = false;
        }

        private void StartRequestBtn_Click(object sender, EventArgs e)
        {
            string cityname = CityTextBox.Text;
            int milliseconds = int.Parse(SecondeTextBox.Text) * 1000;

            Task task = CityWeatherManager.StartAutoRequset(cityname, milliseconds);

            if(task.Status == TaskStatus.Running || task.Status == TaskStatus.WaitingToRun)
                StartRequestBtn.Enabled = false;

            GetCurrentTempBtn.Enabled=true;
        }

        private void StopRequestBtn_Click(object sender, EventArgs e)
        {
            CityWeatherManager.StopAutoRequset();
            StartRequestBtn.Enabled = true;
        }

        private void GetCurrentTempBtn_Click(object sender, EventArgs e)
        {
            float[] temperature = CityWeatherManager.GetCurrentTempFromFile();

            CityTempResultC.Text = $"{temperature[0]}C°";
            CityTempResultsF.Text = $"{temperature[1]}F°";
        }
    }
}
