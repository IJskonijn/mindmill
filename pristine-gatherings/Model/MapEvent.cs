using GMap.NET;
using GMap.NET.MapProviders;
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
        private string eventName;
        private string eventInformation;
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

        public MapEvent(string locationKeywords, Form1 gmap)
        {
            this.isDeleted = false;

            GeoCoderStatusCode status = GeoCoderStatusCode.Unknow;
            PointLatLng? pos = GMapProviders.GoogleMap.GetPoint(locationKeywords, out status);

            if(pos != null && status == GeoCoderStatusCode.G_GEO_SUCCESS)
            {
                marker = new Marker(pos.Value, PristineGatherings.Properties.Resources.map_marker);
                gmap.MarkersOverlay.Markers.Add(marker);
                gmap.MarkersOverlay.Control.Invalidate(); 
            }
            else
            {
                MessageBox.Show("Location not found.");
            }

            
        }

    }
}
