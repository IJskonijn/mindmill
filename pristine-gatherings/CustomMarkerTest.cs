using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace PristineGatherings
{
    class CustomMarkerTest : GMap.NET.WindowsForms.GMapMarker
    {
        private Bitmap image;

        public CustomMarkerTest(PointLatLng x, Bitmap image) : base(x)
        {
            this.image = image;
               
        }
        public override void OnRender(System.Drawing.Graphics g)
        {
            g.DrawImageUnscaled(image, LocalPosition);
 	        base.OnRender(g);

        }
        public void Enlarge()
        {
            Size = new Size(100,100);
        }

        public void MakeSmall()
        {
            Size = new Size(64, 64);
        }

    }
}
