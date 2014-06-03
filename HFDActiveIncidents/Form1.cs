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
        private const string _viewMapColumnName = "ViewMap";
        private readonly string _windowTitle;
        private ActiveIncidentResult _wsresult;
        private DataGridViewButtonColumn _buttonColumn;

        public Form1()
        {
            InitializeComponent();
            _windowTitle = Application.ProductName + " v" + System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
            _buttonColumn = null;
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
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = _wsresult.ActiveIncidentDataTable;
                dataGridView1.Columns["XCoord"].Visible = false;
                dataGridView1.Columns["YCoord"].Visible = false;
                dataGridView1.Columns["NumberOfUnits"].Visible = false;
                dataGridView1.Columns["AlarmLevel"].Visible = false;
                dataGridView1.Columns["CallTimeOpened"].Visible = false;
                dataGridView1.Columns["DateRetrieved"].Visible = false;
                dataGridView1.Columns["Agency"].Width = 45;
                dataGridView1.Columns["KeyMap"].Width = 55;
                dataGridView1.Columns["Latitude"].Width = 65;
                dataGridView1.Columns["Longitude"].Width = 65;
                dataGridView1.Columns["CombinedResponse"].Width = 60;
                dataGridView1.Columns["AlarmLevelInt"].Width = 55;
                dataGridView1.Columns["NumberOfUnitsInt"].Width = 55;
                dataGridView1.Columns["CombinedResponse"].HeaderText = "Combined Response";
                dataGridView1.Columns["NumberOfUnitsInt"].HeaderText = "# Units";
                dataGridView1.Columns["AlarmLevelInt"].HeaderText = "Alarm Level";
                dataGridView1.Columns["CallTimeOpenedDT"].HeaderText = "Call Time Opened";

                if (_buttonColumn == null)
                {
                    _buttonColumn = new DataGridViewButtonColumn
                    {
                        Name = _viewMapColumnName,
                        HeaderText = String.Empty,
                        Text = "View Map",
                        DisplayIndex = 8,
                        UseColumnTextForButtonValue = true
                    };

                    dataGridView1.Columns.Add(_buttonColumn);
                }
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

        private void LaunchGoogleMaps(double dblLatitude, double dblLongitude)
        {
            string strQuery = String.Format("{0}, {1}", dblLatitude, dblLongitude);

            Process process = Process.Start("http://maps.google.com/maps?q="
                + System.Uri.EscapeDataString(strQuery));
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

                LaunchGoogleMaps(incident.Latitude, incident.Longitude);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells.  
            if (e.RowIndex < 0 ||
                e.ColumnIndex != dataGridView1.Columns[_viewMapColumnName].Index)
            {
                return;
            }

            try
            {
                ActiveIncidentRecord incident = (ActiveIncidentRecord)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                LaunchGoogleMaps(incident.Latitude, incident.Longitude);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
