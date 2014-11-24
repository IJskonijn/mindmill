using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PristineGatherings
{
    public class MapEvent
    {
        private Marker marker;
        private PointLatLng worldLocation;
        //private string eventName;
        //private string eventInformation;
        private bool isDeleted;

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        internal Marker Marker
        {
            get { return marker; }
            set { marker = value; }
        }

        public MapEvent(string locationKeywords, GMapControl gmap, Form1 mainView)
        {
            this.isDeleted = false;

            GeoCoderStatusCode status = GeoCoderStatusCode.Unknow;
            PointLatLng? pos = GMapProviders.GoogleMap.GetPoint(locationKeywords, out status);

            if(pos != null && status == GeoCoderStatusCode.G_GEO_SUCCESS)
            {
                this.worldLocation = pos.Value;
                marker = new Marker(gmap, pos.Value, PristineGatherings.Properties.Resources.map_marker);
                mainView.MarkersOverlay.Markers.Add(marker);
                mainView.MarkersOverlay.Control.Invalidate(); 

            }
            else
            {
                MessageBox.Show("Location not found.");
            }

            
        }

    }
}
