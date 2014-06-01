using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;

namespace HFDActiveIncidents
{
    public partial class Form1 : Form
    {
        private readonly string _windowTitle;
        private ActiveIncidentResult _wsresult;

        public Form1()
        {
            InitializeComponent();
            _windowTitle = Application.ProductName + " v" + System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = _windowTitle;
            timerRefresh.Interval = 1000 * 60 * 5; // 5 minutes

            timerRefresh_Tick(this, new EventArgs());
            timerRefresh.Start();
        }

        private async void timerRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                Text = _windowTitle + " - Loading Data";
                _wsresult = await GetData();
                dataGridView1.DataSource = _wsresult.ActiveIncidentDataTable;
                dataGridView1.Columns["XCoord"].Visible = false;
                dataGridView1.Columns["YCoord"].Visible = false;
                dataGridView1.Columns["NumberOfUnits"].HeaderText = "# Units";
            }
            finally
            {
                Text = _windowTitle;
            }
        }

        private async Task<ActiveIncidentResult> GetData()
        {
            var data = await Task.Run<ActiveIncidentResult>( async () => {
                using (var client = new HFDApp.WebService1SoapClient())
                {
                    var response = await client.GetIncidentsAsync();
                    var json = response.Body.GetIncidentsResult;
                    _wsresult = JsonConvert.DeserializeObject<ActiveIncidentResult>(json);
                };
                return _wsresult;
            });

            return data;
        }

        private void googleMapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
                return;

            DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
            DataGridViewRow selectedRow = selectedCell.OwningRow;

            try
            {
                ActiveIncidentRecord incident = (ActiveIncidentRecord)selectedRow.DataBoundItem;

                //object objValue = selectedCell.Value;
                //if (objValue == null || (!(objValue is string)))
                //    return;

                //string strValue = (string)objValue;

                //Process process = Process.Start("http://maps.google.com/maps?q=" + System.Uri.EscapeDataString(strValue));

                string strQuery = String.Format("{0}, {1}", incident.Latitude, incident.Longitude);

                Process process = Process.Start("http://maps.google.com/maps?q=" 
                    + System.Uri.EscapeDataString(strQuery));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
