using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace FlightsStats
{
    public partial class Interface : Form
    {
        private model model;
        private Flight[] flights;

        public Interface()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(39.680269, -97.723161);
            gmap.ShowCenter = false;
        }

        OpenFileDialog dialog = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
           dialog.Filter = "CSV Files|*.csv|TXT Files|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = dialog.FileName;
                String line;
                try
                {
                    StreamReader sr = new StreamReader(dialog.FileName);
                    string[] lines = System.IO.File.ReadAllLines(dialog.FileName);
                    flights = new Flight[lines.Length - 1];
                    line = "";

                    for (int i = 1; i < lines.Length; i++)
                    {
                        String[] data = lines[i].Split(',');
                        Flight f = new Flight(data[5], data[24], data[15], data[34], data[45],data[7]);
                        flights[i - 1] = f;
                    }

                    sr.Close();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                dataGridView1.DataSource = flights;
            }
        }
    }
}
