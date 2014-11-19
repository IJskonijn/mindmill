using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace PristineGatherings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.Bounds.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize map:
            gmap.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(48.74894534, 16.12792969); // Centering the map over Europe at startup;
            gmap.OnMarkerEnter += gmap_OnMarkerEnter;
            gmap.OnMarkerLeave += gmap_OnMarkerLeave;
            gmap.OnMarkerClick += gmap_OnMarkerClick;
            gmap.MouseClick += gmap_OnMapClick;
            gmap.Size = this.Size;

            GMapOverlay markersOverlay = new GMapOverlay(gmap, "markers");
            //GMapMarker marker = new CustomMarkerTest(new PointLatLng(-25.966688, 32.580528), PristineGatherings.Properties.Resources.simple_mapmarker);
            GMapMarker marker = new Marker(new PointLatLng(52.50108592, 6.07904501), PristineGatherings.Properties.Resources.map_marker);

            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void gmap_OnMarkerLeave(GMapMarker item)
        {
            if (item is CustomMarkerTest)
            {
                (item as CustomMarkerTest).MakeSmall();
            }
        }

        private void gmap_OnMarkerEnter(GMapMarker item)
        {
            if (item is CustomMarkerTest)
            {
                (item as CustomMarkerTest).Enlarge();
            }
        }

        /*
         * Adds a new marker at the mouse location if left mouse button is pressed.
         */
        private void gmap_OnMapClick(object obj, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                GMapOverlay markersOverlay = new GMapOverlay(gmap, "markers");

                double lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;

                markersOverlay.Markers.Add(new Marker(new PointLatLng(lat, lng), PristineGatherings.Properties.Resources.map_marker));
                gmap.Overlays.Add(markersOverlay);
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new Form2();
        }
    }
}
