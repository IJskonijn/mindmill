using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PristineGatherings
{
    class Marker : GMap.NET.WindowsForms.GMapMarker
    {
        private Bitmap image;
        private int x;
        private int y;

        public Marker(GMapControl gmap, PointLatLng latLong, Bitmap image) : base(latLong)
        {
            this.image = image;
            base.Size = image.Size;
            CenterMarker();
                    
        }

        public override void OnRender(Graphics g)
        {
            base.OnRender(g);
            CenterMarker();
            g.DrawImageUnscaled(image, new Point(x, y));

        }

        private void CenterMarker()
        {
            this.x = LocalPosition.X - (image.Width / 2);
            this.y = LocalPosition.Y - image.Height;      
        }




    }
}
