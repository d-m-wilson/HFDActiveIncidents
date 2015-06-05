using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace HFDActiveIncidents
{
    public partial class Form1 : Form
    {
        private const int _exceptionTextMaxLength = 768;
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
                timerRefresh.Stop();
                Text = _windowTitle + " - Loading Data";
                lblLoading.Show();
                Refresh();

                _wsresult = await GetData();

                grdIncidents.DataSource = _wsresult.ActiveIncidentDataTable;
                grdIncidents.Columns["XCoord"].Visible = false;
                grdIncidents.Columns["YCoord"].Visible = false;
                grdIncidents.Columns["NumberOfUnits"].Visible = false;
                grdIncidents.Columns["AlarmLevel"].Visible = false;
                grdIncidents.Columns["CallTimeOpened"].Visible = false;
                grdIncidents.Columns["DateRetrieved"].Visible = false;
                grdIncidents.Columns["Agency"].Width = 45;
                grdIncidents.Columns["KeyMap"].Width = 55;
                grdIncidents.Columns["Latitude"].Width = 65;
                grdIncidents.Columns["Longitude"].Width = 65;
                grdIncidents.Columns["CombinedResponse"].Width = 60;
                grdIncidents.Columns["AlarmLevelInt"].Width = 55;
                grdIncidents.Columns["NumberOfUnitsInt"].Width = 55;
                grdIncidents.Columns["CombinedResponse"].HeaderText = "Combined Response";
                grdIncidents.Columns["NumberOfUnitsInt"].HeaderText = "# Units";
                grdIncidents.Columns["AlarmLevelInt"].HeaderText = "Alarm Level";
                grdIncidents.Columns["CallTimeOpenedDT"].HeaderText = "Call Time Opened";

                if (_buttonColumn == null)
                {
                    _buttonColumn = new DataGridViewButtonColumn
                    {
                        Name = _viewMapColumnName,
                        HeaderText = String.Empty,
                        Text = "View Map",
                        DisplayIndex = 8,
                        UseColumnTextForButtonValue = true,
                        Width = 65
                    };

                    grdIncidents.Columns.Add(_buttonColumn);
                }
            }
            catch (System.ServiceModel.FaultException ex)
            {
                StringBuilder errorMessage = new StringBuilder();
                string exceptionText = ex.ToString();

                errorMessage.Append("An error occurred while communicating with the HFD incidents web service:\n\n");
                errorMessage.Append(exceptionText.Left(_exceptionTextMaxLength));

                if (exceptionText.Length > _exceptionTextMaxLength)
                {
                    errorMessage.Append(" ...");
                }

                lblLoading.Hide();

                MessageBox.Show(
                    errorMessage.ToString(), 
                    "Unable to load incident data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: " + ex.Message);
            }
            finally
            {
                Text = _windowTitle;
                lblLoading.Hide();
                timerRefresh.Start();
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
            if (grdIncidents.SelectedCells.Count == 0)
                return;

            DataGridViewCell selectedCell = grdIncidents.SelectedCells[0];
            DataGridViewRow selectedRow = selectedCell.OwningRow;

            try
            {
                ActiveIncidentRecord incident = (ActiveIncidentRecord)selectedRow.DataBoundItem;

                LaunchGoogleMaps(incident.Latitude, incident.Longitude);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: " + ex.Message);
            }
        }

        private void grdIncidents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells.  
            if (e.RowIndex < 0 ||
                e.ColumnIndex != grdIncidents.Columns[_viewMapColumnName].Index)
            {
                return;
            }

            try
            {
                ActiveIncidentRecord incident = (ActiveIncidentRecord)grdIncidents.Rows[e.RowIndex].DataBoundItem;

                LaunchGoogleMaps(incident.Latitude, incident.Longitude);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: " + ex.Message);
            }
        }
    }
}
