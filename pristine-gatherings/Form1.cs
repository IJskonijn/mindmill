﻿using System;
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
using GMap.NET.MapProviders;

namespace PristineGatherings
{
    public partial class Form1 : Form
    {
        private GMapOverlay markersOverlay; // Layer of markers.
        private List<MapEvent> eventsList; // List of all the events on the map;

        public GMapOverlay MarkersOverlay
        {
            get { return markersOverlay; }
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = Screen.PrimaryScreen.Bounds.Size;          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize map:
            gmap.MapProvider = GMap.NET.MapProviders.OpenStreetMapQuestProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(48.74894534, 16.12792969); // Centering the map over Europe at startup;
            gmap.OnMarkerEnter += gmap_OnMarkerEnter;
            gmap.OnMarkerLeave += gmap_OnMarkerLeave;
            gmap.OnMarkerClick += gmap_OnMarkerClick;
            //gmap.MouseClick += gmap_OnMapClick;
            gmap.Size = this.Size;
            gmap.ShowCenter = false; // Disables blue middle marker.

            markersOverlay = new GMapOverlay();
            this.eventsList = new List<MapEvent>();
            
            gmap.Overlays.Add(markersOverlay);

            TestPlaceSomeEventsOnMap(); // Test placing events on map.

            // Zoom in and out by one to update the markers.
            gmap.Zoom = gmap.Zoom + 1;
            gmap.Zoom = gmap.Zoom - 1;

        }

        // Deletes the marker when it is clicked.
        void gmap_OnMarkerClick(object item, MouseEventArgs e)
        {
            Console.WriteLine("Before marker delete");
            Console.WriteLine("Markers: " + markersOverlay.Markers.Count);
            Console.WriteLine("Events: " + eventsList.Count);

            if (item is Marker)
            {
                Marker eventToDelete = item as Marker;
                foreach (MapEvent mapEvent in eventsList)
                {
                    if (mapEvent.Marker.Equals(eventToDelete))
                    {
                        markersOverlay.Markers.Remove(eventToDelete);
                        markersOverlay.Control.Invalidate();
                        mapEvent.IsDeleted = true;
                        break;
                    }
                }

                Console.WriteLine("After marker delete");
                Console.WriteLine("Markers: " + markersOverlay.Markers.Count);
                Console.WriteLine("Events: " + eventsList.Count);

                gmap.Invalidate();         
            }
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
        //private void gmap_OnMapClick(object obj, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        double lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
        //        double lng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;

        //        markersOverlay.Markers.Add(new Marker(new PointLatLng(lat, lng), PristineGatherings.Properties.Resources.map_marker));
        //        markersOverlay.Control.Invalidate();
        //    }

        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new Form2(this);
        }

        public void ShowRegister()
        {
            new Form3();
        }

        /*
         * Test method to add some markers at the keyword place.
         */
        private void TestPlaceSomeEventsOnMap()
        {
            eventsList.Add(new MapEvent("Lieven de Keystraat, Almere, Flevoland, Nederland, 1333PA, Nederland", gmap, this));
            eventsList.Add(new MapEvent("Germany, Berlin", gmap, this));
            eventsList.Add(new MapEvent("Ukraine", gmap, this));
            eventsList.Add(new MapEvent("Tokyo", gmap, this));
            eventsList.Add(new MapEvent("Larache", gmap, this));
            eventsList.Add(new MapEvent("Zwolle", gmap, this));

        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            string upload = Application.StartupPath + @"\Upload\profile.jpg";

            if (System.IO.File.Exists(upload))
            {
                System.IO.File.Delete(upload);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
