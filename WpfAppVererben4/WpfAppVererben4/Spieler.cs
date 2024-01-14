using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfAppVererben4
{
    class Spieler
    {
        protected double posx = 700;//Platzhalter
        protected double posy = 200;
        protected Canvas canvasSpieler;//using System.Windows.Controls hinzufügen
        protected ImageBrush spielerMalen;//using System.Windows.Media; hinzufügen
        protected int speed;//Schrittgröße pro Key.Down

        public Canvas CanvasSpieler
        {
            get { return canvasSpieler; }
            set { canvasSpieler = value; }
        }

        public double Posx
        {
            get { return posx; }
            set { posx = value; }
        }

        public double Posy
        {
            get { return posy; }
            set { posy = value; }
        }

        public double Speed
        {
            get { return speed; }
        }

        public Spieler()
        {
            //Die Bilddateien müssen in den Ordner bin/Debug und dann mit RMT
            //ProjektmappenExplorer auf Dateiname/Hinzufügen/Vorhandens Element
            canvasSpieler = new Canvas();
            spielerMalen = new ImageBrush();
           spielerMalen.ImageSource = new BitmapImage(new Uri(@"einstein.png", UriKind.Relative));
            canvasSpieler.Background = spielerMalen;
            speed = -5;//sonst sind die Pfeiltasten vertauscht,da links oben Punkt 0
        }

        public void Zeichnen()//siehe mit alles
        {
            Canvas.SetLeft(canvasSpieler, posx);//Position im Canvas(Element,Position)
            Canvas.SetTop(canvasSpieler, posy);
            canvasSpieler.Width = 50;
            canvasSpieler.Height = 100;
        
        }

        
    }
}

