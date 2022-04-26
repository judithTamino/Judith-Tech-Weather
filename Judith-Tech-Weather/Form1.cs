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
using Judith_Tech_Weather.Model;

namespace Judith_Tech_Weather
{
    public partial class Form1 : Form
    {
        CityWeatherManager CityWeatherManager = new CityWeatherManager();
        public Form1()
        {
            InitializeComponent();
            GetCurrentTempBtn.Enabled = false;

            CityWeatherManager.SaveToDB();
            ShowCityNameAndTemp();
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CityWeatherManager.AddToList(textBox1.Text);
            ShowCityNameAndTemp();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            CityWeatherManager.UpdateCityTemp();
        }

        private void ShowCityNameAndTemp()
        {
            Dictionary<string, CityWeatherData> cityList = CityWeatherManager.GetCityWeatherTable();
            dataGridView1.Rows.Clear();
            
            foreach (CityWeatherData city in cityList.Values)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = city.location.name;
                row.Cells[1].Value = $"{city.current.temp_c}C°";
                row.Cells[2].Value = $"{city.current.temp_f}F°";
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
