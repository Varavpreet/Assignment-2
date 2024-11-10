using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class PieChartControl : UserControl
    {
        private List<float> sectionAngles = new List<float>();
        private List<Color> sectionColors = new List<Color>();

        public PieChartControl()
        {
            InitializeComponent();
            this.Paint += PieChartControl_Paint;
        }

        public List<string> LegendInfo { get; private set; } = new List<string>();

        public void SetData(List<double> numbers)
        {
            if (numbers == null || !numbers.Any())
                throw new ArgumentException("The list of numbers cannot be null or empty.");

            double total = numbers.Sum();
            sectionAngles = numbers.Select(num => (float)(num / total * 360)).ToList();
            sectionColors = GenerateColors(numbers.Count);
            LegendInfo = GenerateLegendInfo(numbers, total);

            this.Invalidate();
        }

        private List<Color> GenerateColors(int count)
        {
            var rand = new Random();
            return Enumerable.Range(0, count)
                             .Select(_ => Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)))
                             .ToList();
        }

        private List<string> GenerateLegendInfo(List<double> numbers, double total)
        {
            return numbers.Select((num, index) =>
                $"Slice {index + 1}: {num} ({Math.Round(num / total * 100, 2)}%)").ToList();
        }

        private void PieChartControl_Paint(object sender, PaintEventArgs e)
        {
            if (!sectionAngles.Any()) return;

            Graphics g = e.Graphics;
            float startAngle = 0f;

            for (int i = 0; i < sectionAngles.Count; i++)
            {
                using (Brush brush = new SolidBrush(sectionColors[i]))
                {
                    g.FillPie(brush, 10, 10, this.Width - 20, this.Height - 20, startAngle, sectionAngles[i]);
                }

                startAngle += sectionAngles[i];
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
             
            this.Name = "PieChartControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
        }
    }
}
