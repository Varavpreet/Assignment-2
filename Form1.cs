using System;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private PieChartControl pieChartControl1;
        private ListBox listBoxLegend;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            pieChartControl1 = new PieChartControl
            {
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(300, 300),
                Name = "pieChartControl1"
            };

            listBoxLegend = new ListBox
            {
                Location = new System.Drawing.Point(340, 20),
                Size = new System.Drawing.Size(200, 300),
                Name = "listBoxLegend"
            };

            this.Controls.Add(pieChartControl1);
            this.Controls.Add(listBoxLegend);
        }

        private void btnDrawgraph_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputData.Text))
            {
                MessageBox.Show("Please enter numbers separated by commas.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var numbers = inputData.Text.Split(',')
                                            .Select(num => double.TryParse(num.Trim(), out double result) ? result : throw new FormatException())
                                            .ToList();

                if (numbers.Any(n => n <= 0))
                {
                    MessageBox.Show("All numbers should be positive.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pieChartControl1.SetData(numbers);
                listBoxLegend.Items.Clear();
                listBoxLegend.Items.AddRange(pieChartControl1.LegendInfo.ToArray());
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Ensure all entries are valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
