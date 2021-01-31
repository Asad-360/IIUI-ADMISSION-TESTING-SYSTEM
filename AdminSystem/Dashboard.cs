using System;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
namespace AdminSystem
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            string[] seriesArray = { "Cats", "Dogs" };
            int[] pointsArray = { 1, 2 };

            // Set palette.
     //       this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart1.Titles.Add("Pets");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
           //     Series series = this.chart1.Series.Add(seriesArray[i]);

                // Add point.
             //   series.Points.Add(pointsArray[i]);
            }

        }


        public static Dashboard _Dashboard;
        public static Dashboard Instance
        {
            get
            {
                if (_Dashboard == null)
                    _Dashboard = new Dashboard();
                return _Dashboard;
            }
        }




    }
}
