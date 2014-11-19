using GMap.NET;
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

        public Marker(PointLatLng latLong, Bitmap image) : base(latLong)
        {
            this.image = image;

        }

        public override void OnRender(Graphics g)
        {
            base.OnRender(g);
            CenterMarker();
            g.DrawImageUnscaled(image, new Point(x, y));

        }

        private void CenterMarker()
        {
            x = LocalPosition.X - (image.Width / 2);
            y = LocalPosition.Y - image.Height;
        }




    }
}
