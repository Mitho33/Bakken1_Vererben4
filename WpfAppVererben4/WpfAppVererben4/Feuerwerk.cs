using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfAppVererben4
{
    class Feuerwerk:Spieler
    {
        public Feuerwerk() : base()
        {

            spielerMalen.ImageSource = new BitmapImage(new Uri(@"Feuerwerk.png", UriKind.Relative));
            canvasSpieler.Width = 400;
            canvasSpieler.Height = 500;

        }
    }
}
