using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace Icarus
{
    public partial class WBB200 : Form
    {
        public WBB200()
        {
            InitializeComponent();

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "CENTER OF GRAVITY - INCHES AFTER DATUM",
                MinValue = 178.00,
                MaxValue = 200.00,
                LabelFormatter = value => value.ToString("0.00"),
                Separator = new Separator { Step = 2 }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "WHEIGHT - POUNDS",
                MinValue = 7500,
                MaxValue = 12500,
                LabelFormatter = value => value.ToString(),
                Separator = new Separator { Step = 200 }
            });

            txtTOindex.Leave += TextBox_Leave;

        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void UpdateChart()
        {
            cartesianChart1.Series.Clear();

            int zfw = int.Parse(txtZer.Text);
            int rw = int.Parse(txtRamp.Text); 
            int tow = int.Parse(txtTakeoff.Text);

            double zfIndex = double.Parse(txtZFindex.Text);
            double rwIndex = double.Parse(txtRWindex.Text);
            double toIndex = double.Parse(txtTOindex.Text);

            cartesianChart1.Series.Add(new ScatterSeries
            {
                Title = "ZFW",
                Values = new ChartValues<ObservablePoint>
            {
                new ObservablePoint(zfIndex, zfw)
            },
                Fill = System.Windows.Media.Brushes.Red, // Define a cor dos pontos da série RW
                PointGeometry = DefaultGeometries.Circle, // Define a geometria como uma bolinha
                StrokeThickness = 4 // Define o tamanho do marcador para 4 pixels

            });

            cartesianChart1.Series.Add(new ScatterSeries
            {
                Title = "RW",
                Values = new ChartValues<ObservablePoint>
            {
                new ObservablePoint(rwIndex, rw)
            },
                Fill = System.Windows.Media.Brushes.Yellow, // Define a cor dos pontos da série RW
                PointGeometry = DefaultGeometries.Circle, // Define a geometria como uma bolinha
                StrokeThickness = 4 // Define o tamanho do marcador para 4 pixels
            });

            cartesianChart1.Series.Add(new ScatterSeries
            {
                Title = "TOW",
                Values = new ChartValues<ObservablePoint>
            {
                new ObservablePoint(toIndex, tow)
            },
                Fill = System.Windows.Media.Brushes.Blue, // Define a cor dos pontos da série RW
                PointGeometry = DefaultGeometries.Circle, // Define a geometria como uma bolinha
                StrokeThickness = 4 // Define o tamanho do marcador para 4 pixels
            });
                       
            cartesianChart1.Update();
        }
               

        private void WBB200_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
