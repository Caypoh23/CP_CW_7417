using CP_CW_7417.Client.SwipesCollectionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace CP_CW_7417.Client
{
    public partial class SwipesCollectionManagementForm : Form
    {
        SwipesCollectionServiceClient _client = new SwipesCollectionServiceClient();

        private static bool _canProceed;

        public SwipesCollectionManagementForm() =>
            InitializeComponent();

        private void SwipesCollectionManagementForm_Load(object sender, EventArgs e) =>
            FillDatabaseGrid();

        private void btnStart_Click(object sender, EventArgs e)
        {
            EnableButton(false);
            _client.StartCollectingSwipes();
            if (!backgroundWorker1.IsBusy) backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            var terminals = new List<Terminal>();

            _canProceed = false;

            while (!_canProceed)
            {
                terminals = _client.GetStatus().ToList();
                _canProceed = IsProcessFinished(terminals);
                UpdateTable(terminals);
                Thread.Sleep(100);
            }

            EnableButton(true);
            FillDatabaseGrid();
        }

        // check if process is finished using linq
        private bool IsProcessFinished(List<Terminal> terminals) =>
            terminals.Where(p => p.SwipeStatus == SwipeStatus.Waiting || p.SwipeStatus == SwipeStatus.InProcess).Count() == 0;

        private void UpdateTable(List<Terminal> terminals)
        {
            dgvTerminals.Invoke((MethodInvoker)delegate
            {
                dgvTerminals.DataSource = terminals;
            });
        }

        // enable or disable the button so that the user cannot start the procedure multiple times
        private void EnableButton(bool isEnabled)
        {
            btnStart.Invoke((MethodInvoker)delegate
            {
                btnStart.Enabled = isEnabled;
            });
        }

        // fill the form with database information
        private void FillDatabaseGrid()
        {
            dgvDatabase.Invoke((MethodInvoker)delegate
            {
                dgvDatabase.DataSource = _client.GetAllSwipes();
            });
        }
        
        // change the color of rows depending on status
        private void dgvTerminals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                SwipeStatus status = (SwipeStatus)e.Value;

                switch (status)
                {
                    case SwipeStatus.Finished:
                        e.CellStyle.BackColor = Color.LightGreen;
                        break;
                    case SwipeStatus.InProcess:
                        e.CellStyle.BackColor = Color.LightGoldenrodYellow;
                        break;
                    default:
                        e.CellStyle.BackColor = Color.LightGray;
                        break;
                }
            }
        }
    }
}
