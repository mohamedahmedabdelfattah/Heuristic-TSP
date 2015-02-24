using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HeuristicTSP
{
    public partial class MainForm : Form
    {
        int NumberOfCities = -1;
        double Distance = 0;
        string StartingCity = null;
        bool ex = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            table.ColumnCount = 0;
            table.RowCount = 0;
            txtFactorialN.Text = "";
            txtNumberOfCyclicGroups.Text = "";
            txtNumberofStringsPerGroup.Text = "";
            txtShortestPath.Text = "";
            txtDistance.Text = "";
        }

        private void RestoreDefaults()
        {
            try
            {
                for (int x = 0; x < NumberOfCities + 1; x++)
                {
                    for (int i = 0; i < NumberOfCities + 1; i++)
                    {
                        table[x, i].ReadOnly = false;
                    }
                }

                for (int x = 0; x < NumberOfCities + 1; x++)
                {
                    for (int i = 0; i < NumberOfCities + 1; i++)
                    {
                        if (i == x && x != 0)
                        {
                            table[i, x].Value = "X";
                            table[i, x].ReadOnly = true;
                        }
                    }
                }

                for (int x = 0; x < NumberOfCities + 1; x++)
                {
                    table[0, x].ReadOnly = true;
                    table[x, 0].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void ConstructTable()
        {
            try
            {
                table.ColumnCount = NumberOfCities + 1;
                table.RowCount = NumberOfCities + 1;
                btnCheckPath.Enabled = false;
                btnGo.Enabled = false;
                txtNumberOfCities.Enabled = false;
                btnCalculate.Enabled = false;
                btnCalculateAll.Enabled = false;
                btnRandom.Enabled = false;
                btnEx.Enabled = false;
                bgConstructTable.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private double Factorial(double number)
        {
            try
            {
                if (number <= 1)
                    return 1;
                else
                    return number * Factorial(number - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return -1;
            }
        }

        private bool CanStart()
        {
            try
            {
                for (int x = 1; x < NumberOfCities + 1; x++)
                {
                    for (int i = 1; i < NumberOfCities + 1; i++)
                    {
                        if (table[x, i].ReadOnly != true)
                        {
                            try
                            {
                                if (table[x, i].Value.ToString() == null)
                                    return false;
                                else
                                    return true;
                            }
                            catch
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        private double PathDistance()
        {
            double Distance = 0.0;

            int[] Cities = new int[NumberOfCities + 1];

            for (int x = 0; x < NumberOfCities + 1; x++)
            {
                for (int i = 1; i < NumberOfCities + 1; i++)
                {
                    if (txtPath.Text[x].ToString() == table[0, i].Value.ToString())
                    {
                        Cities[x] = i;
                    }
                }
            }

            for (int x = 0; x < NumberOfCities + 1; x++)
            {
                try
                {
                    Distance += double.Parse(table[Cities[x - 1], Cities[x]].Value.ToString());
                }
                catch { }
            }

            return Distance;
        }

        private int Minimum(int row)
        {
            try
            {
                int IndexOfMinValue = -1;
                double MinValue = 9999999999.9999999999;

                for (int x = 1; x < NumberOfCities + 1; x++)
                {
                    if (table[x, row].ReadOnly != true)
                    {
                        if (double.Parse(table[x, row].Value.ToString()) < MinValue)
                        {
                            MinValue = double.Parse(table[x, row].Value.ToString());
                            IndexOfMinValue = x;
                        }
                    }
                }

                for (int x = 0; x < NumberOfCities + 1; x++)
                {
                    table[IndexOfMinValue, x].ReadOnly = true;
                }

                Distance += MinValue;
                return IndexOfMinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return -1;
            }
        }

        private void BestPath()
        {
            txtShortestPath.Text = "";
            txtDistance.Text = "";
            Distance = 0;

            int[] Rows = new int[NumberOfCities];
            int StartingRow = -1;

            // Starting Row
            for (int i = 1; i < NumberOfCities + 1; i++)
            {
                if (table[0, i].Value.ToString() == StartingCity)
                {
                    StartingRow = i;
                    break;
                }
            }

            for (int x = 0; x < NumberOfCities + 1; x++)
            {
                table[StartingRow, x].ReadOnly = true;
            }

            Rows[0] = StartingRow;
            for (int x = 1; x < NumberOfCities; x++)
            {
                Rows[x] = Minimum(Rows[x - 1]);
            }

            RestoreDefaults();

            foreach (int i in Rows)
            {
                txtShortestPath.Text += table[0, i].Value.ToString();
            }
            txtShortestPath.Text += StartingCity;

            Distance += double.Parse(table[Rows[NumberOfCities - 1], StartingRow].Value.ToString());
            txtDistance.Text = Distance.ToString();
        }

        private void BestOfAll()
        {
            for (int y = 1; y < NumberOfCities + 1; y++)
            {
                Distance = 0;

                int[] Rows = new int[NumberOfCities];

                for (int x = 0; x < NumberOfCities + 1; x++)
                {
                    table[y, x].ReadOnly = true;
                }

                Rows[0] = y;
                for (int x = 1; x < NumberOfCities; x++)
                {
                    Rows[x] = Minimum(Rows[x - 1]);
                }

                RestoreDefaults();

                // output each path
                foreach (int i in Rows)
                {
                    table[y, NumberOfCities + 1].Value += table[0, i].Value.ToString();
                }
                table[y, NumberOfCities + 1].Value += table[0, Rows[0]].Value.ToString();

                // Output each Distance
                Distance += double.Parse(table[Rows[NumberOfCities - 1], Rows[0]].Value.ToString());
                table[y, NumberOfCities + 2].Value = Distance.ToString();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm.CheckForIllegalCrossThreadCalls = false;
        }

        private void MainFrm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.R:
                    Application.Restart();
                    break;
            }
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            new AboutFrm().ShowDialog();
        }

        private void bgConstructTable_DoWork(object sender, DoWorkEventArgs e)
        {
            if (bgConstructTable.CancellationPending == true || (bgConstructTable.CancellationPending == true && bgConstructTable.IsBusy == true))
                e.Cancel = true;
            else
            {
                try
                {
                    int s = 97;
                    int b = 1;
                    string sb = null;
                    for (int i = 1; i < NumberOfCities + 1; i++)
                    {
                        if (s == 123)
                        {
                            s = 97;
                            sb = b.ToString();
                            b++;
                        }

                        table[0, i].Value = System.Text.Encoding.Default.GetString(new byte[1] { Convert.ToByte(s) }) + sb;
                        table[i, 0].Value = System.Text.Encoding.Default.GetString(new byte[1] { Convert.ToByte(s) }) + sb;
                        s++;
                    }

                    for (int x = 0; x < NumberOfCities + 1; x++)
                    {
                        for (int i = 0; i < NumberOfCities + 1; i++)
                        {
                            if (i == x && x != 0)
                            {
                                table[i, x].Value = "X";
                                table[i, x].ReadOnly = true;
                            }
                        }
                    }

                    for (int x = 0; x < NumberOfCities + 1; x++)
                    {
                        table[0, x].ReadOnly = true;
                        table[x, 0].ReadOnly = true;
                    }

                    if (ex == true)
                    {
                        double[] data = { 0.7, 0.6, 0.35, 0.45, 1.5, 3.6, 2.1, 4.5, 6.0, 2.5, 5.5, 1.2, 0.4, 0.3, 1.1 };

                        int d = 0;
                        for (int x = 1; x < NumberOfCities + 1; x++)
                        {
                            for (int i = x + 1; i < NumberOfCities + 1; i++)
                            {
                                table[i, x].Value = data[d];
                                d++;
                            }
                        }

                        ex = false;
                    }

                    table[0, 0].Value = "City";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void bgConstructTable_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCheckPath.Enabled = true;
            btnGo.Enabled = true;
            txtNumberOfCities.Enabled = true;
            btnCalculate.Enabled = true;
            btnCalculateAll.Enabled = true;
            btnRandom.Enabled = true;
            btnEx.Enabled = true;
        }

        private void table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int c = e.ColumnIndex;
            int r = e.RowIndex;
            try { table[r, c].Value = table[c, r].Value; }
            catch { }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumberOfCities.Text == "")
                {
                    MessageBox.Show("Number of Cities must be specified.", "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    ClearAll();

                    NumberOfCities = int.Parse(txtNumberOfCities.Text);
                    double uNumberOfCities = (double)NumberOfCities;

                    if (NumberOfCities > 1)
                    {
                        if (NumberOfCities <= 100)
                        {
                            txtFactorialN.Text = Factorial(uNumberOfCities).ToString();
                            if (NumberOfCities > 2)
                            {
                                txtNumberOfCyclicGroups.Text = (Factorial(NumberOfCities) / (2 * NumberOfCities)).ToString();
                                txtNumberofStringsPerGroup.Text = (Factorial(NumberOfCities) / (Factorial(NumberOfCities) / (2 * NumberOfCities))).ToString();
                            }
                            else
                            {
                                txtNumberOfCyclicGroups.Text = "1";
                                txtNumberofStringsPerGroup.Text = "2";
                            }
                            ConstructTable();
                        }
                        else
                        {
                            MessageBox.Show("Number of Cities must be:\r\nless than 100 to be handled\r\nless than 3249 to process with some time\r\nand less than 99999 for computers to process.", "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Number of Cities must be greater than 1 to accomplish a round trip.", "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                btnCalculate.Enabled = false;

                if (CanStart() == true)
                {
                    if (txtStartingCity.Text == "")
                        MessageBox.Show("Please specify a Starting City.", "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    else
                    {
                        StartingCity = txtStartingCity.Text;
                        BestPath();
                    }
                }
                else
                {
                    MessageBox.Show("All distances must be filled.", "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                btnCalculate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCalculateAll_Click(object sender, EventArgs e)
        {
            try
            {
                btnCalculateAll.Enabled = false;
                txtShortestPath.Text = "";
                txtDistance.Text = "";

                if (CanStart() == true)
                {
                    if (table.Rows.Count > NumberOfCities + 1)
                    {
                        for (int x = 1; x < NumberOfCities + 1; x++)
                        {
                            for (int i = NumberOfCities + 1; i < NumberOfCities + 3; i++)
                            {
                                table[x, i].Value = "";
                            }
                        }
                    }
                    else
                    {
                        table.Rows.Add(2);
                        table[0, NumberOfCities + 1].Value = "Path";
                        table[0, NumberOfCities + 2].Value = "Distance";
                        for (int x = 0; x < NumberOfCities + 1; x++)
                        {
                            for (int i = NumberOfCities + 1; i < NumberOfCities + 3; i++)
                            {
                                table[x, i].ReadOnly = true;
                            }
                        }
                    }
                    BestOfAll();
                }
                else
                {
                    MessageBox.Show("All distances must be filled.", "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                btnCalculateAll.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
                txtPath.Text = "";
                txtNumberOfCities.Text = "6";
                txtStartingCity.Text = "";
                txtShortestPath.Text = "";
                txtDistance.Text = "";
                btnGo.PerformClick();
                ex = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            txtPath.Text = "";
            txtStartingCity.Text = "";
            txtShortestPath.Text = "";
            txtDistance.Text = "";
            bgRandom.RunWorkerAsync();
        }

        private void bgRandom_DoWork(object sender, DoWorkEventArgs e)
        {
            if (bgRandom.CancellationPending == true || (bgRandom.CancellationPending == true && bgRandom.IsBusy == true))
                e.Cancel = true;
            else
            {
                try
                {
                    btnRandom.Enabled = false;
                    Random r = new Random();
                    for (int x = 0; x < NumberOfCities + 1; x++)
                    {
                        for (int i = x; i < NumberOfCities + 1; i++)
                        {
                            if (table[x, i].ReadOnly != true)
                            {
                                table[x, i].Value = r.Next(1, 10);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void bgRandom_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnRandom.Enabled = true;
        }

        private void txtNumberOfCities_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberOfCities.Text == "")
            {
                btnGo.Enabled = false;
            }
            else
            {
                btnGo.Enabled = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bgConstructTable.CancelAsync();
            bgRandom.CancelAsync();
        }

        private void btnCheckPath_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("First enter a Path 'String' to check.", "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    if (txtPath.Text[0] == txtPath.Text[txtPath.Text.Length - 1])
                    {
                        if (txtPath.Text.Length == NumberOfCities + 1)
                        {
                            int[] Cities = new int[NumberOfCities + 1];
                            for (int x = 0; x < NumberOfCities + 1; x++)
                            {
                                for (int i = 1; i < NumberOfCities + 1; i++)
                                {
                                    if (txtPath.Text[x].ToString() == table[0, i].Value.ToString())
                                    {
                                        Cities[x] = i;
                                    }
                                }
                            }

                            int right = -1;
                            for (int x = 0; x < NumberOfCities + 1; x++)
                            {
                                for (int i = 0; i < NumberOfCities + 1; i++)
                                {
                                    if (i != x)
                                    {
                                        if (Cities[x] != Cities[i])
                                            right = 0;
                                        else
                                            right = -1;
                                    }
                                }
                            }

                            if (right == 0)
                            {
                                double dis = PathDistance();
                                MessageBox.Show("Path: \"" + txtPath.Text + "\"gives a total Distance: \"" + dis + "\"\r\n\r\n" + "Your path looks Ok but be aware that it may not be the best.", "Heuristic TSP - Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Path.\r\nValidation requires cycling through all the cities once and finishing with a round trip.", "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Path.\r\nValidation requires cycling through all the cities once and finishing with a round trip.", "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Path.\r\nValidation requires cycling through all the cities once and finishing with a round trip.", "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, "Heuristic TSP - Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
            }
        }

    }
}