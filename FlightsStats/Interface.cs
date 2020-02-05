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
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Model;

namespace FlightsStats
{
    public partial class Interface : Form
    {
        private model model;
        private Flight[] flights;
        private GMapOverlay markers;

        public Interface()
        {
            InitializeComponent();
            cbDate.Visible = false;
            cbOrigin.Visible = false;
            cbDestination.Visible = false;
            cbAirlineID.Visible = false;
            tbFlightID.Visible = false;
            split1.Visible = false;
            split2.Visible = false;
            split3.Visible = false;
            panelLateral.Location = new Point(-260, 0);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(39.680269, -97.723161);
            gmap.ShowCenter = false;

            markers = new GMapOverlay("markers");
            gmap.Overlays.Add(markers);
        }

        OpenFileDialog dialog = new OpenFileDialog();
        Boolean active = false;
        private void button1_Click(object sender, EventArgs e)
        {
            dialog.Filter = "CSV Files|*.csv|TXT Files|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = dialog.FileName;
                try
                {
                    StreamReader sr = new StreamReader(dialog.FileName);
                    string[] lines = System.IO.File.ReadAllLines(dialog.FileName);
                    flights = new Flight[lines.Length - 1];
                    for (int i = 1; i < lines.Length; i++)
                    {
                        String[] data = lines[i].Split(';');
                        Flight f = new Flight(data[5], data[15], data[25], data[34], data[45],data[9], data[7]);
                        flights[i - 1] = f;
                        int da = cbDate.FindString(data[5]);
                        int o = cbOrigin.FindString(data[15]);
                        int de = cbDestination.FindString(data[25]);
                        int a = cbAirlineID.FindString(data[7]);
                        if (da == -1)
                            cbDate.Items.Add(data[5]);
                        if (o == -1)
                            cbOrigin.Items.Add(data[15]);
                        if (de == -1)
                            cbDestination.Items.Add(data[25]);
                        if (a == -1)
                            cbAirlineID.Items.Add(data[7]);

                        Mark();
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

        public void Mark()
        {
            /*GMapOverlay markers = new GMapOverlay("markers");
            GMap.NET.PointLatLng point = new GMap.NET.PointLatLng(39.680269, -97.723161);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.arrow);
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);*/

            GMarkerGoogle mark = new GMarkerGoogle(new GMap.NET.PointLatLng(39.680269, -97.723161), GMarkerGoogleType.green);
            markers.Markers.Add(mark);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(active == false)
            {
                active = true;
                panelLateral.Location = new Point(9,0);
                cbDate.Visible = true;
                cbOrigin.Visible = true;
                cbDestination.Visible = true;
                cbAirlineID.Visible = true; 
                tbFlightID.Visible = true;
                split1.Visible = true;
                split2.Visible = true;
                split3.Visible = true;
            }
            else
            {
                active = false;
                panelLateral.Location = new Point(-260, 0);
                cbDate.Visible = false;
                cbOrigin.Visible = false;
                cbDestination.Visible = false;
                cbAirlineID.Visible = false;
                tbFlightID.Visible = false;
                split1.Visible = false;
                split2.Visible = false;
                split3.Visible = false;
            }
                
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbDate.SelectedIndex;
            Flight[] flightCB = new Flight[flights.Length];
            for(int i = 0; i < flights.Length; i++)
            {
                if (flights[i].Date.Equals(cbDate.Items[index].ToString()))
                {
                    flightCB[i] = new Flight(flights[i].Date, flights[i].Origin, flights[i].Destination, flights[i].DepartureDelay, flights[i].ArriveDelay, flights[i].FlightId, flights[i].AirlineId);
                }
            }
            dataGridView1.DataSource = flightCB;
        }

        private void cbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbOrigin.SelectedIndex;
            Flight[] flightCB = new Flight[flights.Length];
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].Origin.Equals(cbOrigin.Items[index].ToString()))
                {
                    flightCB[i] = new Flight(flights[i].Date, flights[i].Origin, flights[i].Destination, flights[i].DepartureDelay, flights[i].ArriveDelay, flights[i].FlightId, flights[i].AirlineId);
                }
            }
            dataGridView1.DataSource = flightCB;
        }

        private void cbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbDestination.SelectedIndex;
            Flight[] flightCB = new Flight[flights.Length];
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].Date.Equals(cbDestination.Items[index].ToString()))
                {
                    flightCB[i] = new Flight(flights[i].Date, flights[i].Origin, flights[i].Destination, flights[i].DepartureDelay, flights[i].ArriveDelay, flights[i].FlightId, flights[i].AirlineId);
                }
            }
            dataGridView1.DataSource = flightCB;
        }

        private void cbAirlineID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbAirlineID.SelectedIndex;
            Flight[] flightCB = new Flight[flights.Length];
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].Date.Equals(cbAirlineID.Items[index].ToString()))
                {
                    flightCB[i] = new Flight(flights[i].Date, flights[i].Origin, flights[i].Destination, flights[i].DepartureDelay, flights[i].ArriveDelay, flights[i].FlightId, flights[i].AirlineId);
                }
            }
            dataGridView1.DataSource = flightCB;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            String id = tbFlightID.Text;
            Flight[] flightCB = new Flight[1];
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].FlightId.Equals(id))
                {
                    flightCB[0] = new Flight(flights[i].Date, flights[i].Origin, flights[i].Destination, flights[i].DepartureDelay, flights[i].ArriveDelay, flights[i].FlightId, flights[i].AirlineId); 
                }
            }
            dataGridView1.DataSource = flightCB;
            tbFlightID.Text = "";
        }
    }
}
