using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppVererben4
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Magier magier= new Magier();//Instanziierung muss hier erfolgen, da sonst if Abfrage Fehler wegen nicht vorhandener Objekte anzeigt
        private Mumie mumie = new Mumie();
        private Einstein einstein = new Einstein();
        private Bauarbeiter bauarbeiter = new Bauarbeiter();
        private Feuerwerk feuerwerk = new Feuerwerk();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void LblMagier_MD(object sender, MouseButtonEventArgs e)
        {      
            magier.Zeichnen();//hier bekommt der Magier seine Größe und Pos
            CanvasSpielerContainer.Children.Clear();
            CanvasSpielerContainer.Children.Add(magier.CanvasSpieler);//in den Container Canvas wird der Magier in einem Canvas aus der Klasse Spieler hinzugefügt
           
        }

        private void LblMumie_MD(object sender, MouseButtonEventArgs e)
        { 
            mumie.Zeichnen();
            CanvasSpielerContainer.Children.Clear();
            CanvasSpielerContainer.Children.Add(mumie.CanvasSpieler);
        }

        private void LblEinstein_MD(object sender, MouseButtonEventArgs e)
        {  
            einstein.Zeichnen();
            CanvasSpielerContainer.Children.Clear();
            CanvasSpielerContainer.Children.Add(einstein.CanvasSpieler);
        }

        private void LblBauarbeiter_MD(object sender, MouseButtonEventArgs e)
        {
            bauarbeiter.Zeichnen();
            CanvasSpielerContainer.Children.Clear();
            CanvasSpielerContainer.Children.Add(bauarbeiter.CanvasSpieler);
        }

        private void KeyDown_Tastatur(object sender, KeyEventArgs e)
        {
            if (CanvasSpielerContainer.Children.Contains(magier.CanvasSpieler))
            {         
                magier.Posx= (double)magier.CanvasSpieler.GetValue(Canvas.LeftProperty);
                magier.Posy = (double)magier.CanvasSpieler.GetValue(Canvas.TopProperty);//aktuelle Wert wird ermittelt
          
               
                if (e.Key == Key.Up)
                {
                    magier.CanvasSpieler.SetValue(Canvas.TopProperty, magier.Posy + magier.Speed);
                }
                if (e.Key == Key.Left)
                {
                    magier.CanvasSpieler.SetValue(Canvas.LeftProperty, magier.Posx + magier.Speed);
                }
                if (e.Key == Key.Right)
                {
                    magier.CanvasSpieler.SetValue(Canvas.LeftProperty, magier.Posx - magier.Speed);
                }
                if (e.Key == Key.Down)
                {
                    magier.CanvasSpieler.SetValue(Canvas.TopProperty, magier.Posy - magier.Speed);
                }

               //Positionen

                if (magier.Posx < 10)//Links
                {
                    magier.CanvasSpieler.SetValue(Canvas.LeftProperty, magier.Posx = 10);

                }
                if (magier.Posx > 900)//Rechts canvas ist 1000 breit + bereite Figur
                {
                    magier.CanvasSpieler.SetValue(Canvas.LeftProperty, magier.Posx = 900);
                }

                if (magier.Posy <0)//oben
                {
                    magier.CanvasSpieler.SetValue(Canvas.TopProperty, magier.Posy = 0);
                }

                if (magier.Posy > 300)//unten Canvas ist 450 hoch - höhe spieler
                {
                    magier.CanvasSpieler.SetValue(Canvas.TopProperty, magier.Posy = 300);
                }
                if (magier.Posx <365 && magier.Posy >215)//Loch x=15++350 y=15+200
                {
                    CanvasSpielerContainer.Children.Clear();
                    CanvasSpielerContainer.Children.Add(feuerwerk.CanvasSpieler);
                }

            }

            else if (CanvasSpielerContainer.Children.Contains(mumie.CanvasSpieler))
            {
                mumie.Posx= (double)mumie.CanvasSpieler.GetValue(Canvas.LeftProperty);
               mumie.Posy = (double)mumie.CanvasSpieler.GetValue(Canvas.TopProperty);//aktuelle Wert wird ermittelt

                if (e.Key == Key.Up)
                {
                    mumie.CanvasSpieler.SetValue(Canvas.TopProperty, mumie.Posy + mumie.Speed);
                }
                if (e.Key == Key.Left)
                {
                    mumie.CanvasSpieler.SetValue(Canvas.LeftProperty, mumie.Posx + mumie.Speed);
                }
                if (e.Key == Key.Right)
                {
                    mumie.CanvasSpieler.SetValue(Canvas.LeftProperty, mumie.Posx - mumie.Speed);
                }
                if (e.Key == Key.Down)
                {
                    mumie.CanvasSpieler.SetValue(Canvas.TopProperty, mumie.Posy - mumie.Speed);
                }

                //Positionen

                if (mumie.Posx < 10)//Links
                {
                    mumie.CanvasSpieler.SetValue(Canvas.LeftProperty, mumie.Posx = 10);

                }
                if (mumie.Posx > 900)//Rechts canvas ist 1000 breit + bereite Figur
                {
                    mumie.CanvasSpieler.SetValue(Canvas.LeftProperty, mumie.Posx = 900);
                }

                if (mumie.Posy < 0)//oben
                {
                    mumie.CanvasSpieler.SetValue(Canvas.TopProperty, mumie.Posy = 0);
                }

                if (mumie.Posy > 300)//unten Canvas ist 450 hoch - höhe spieler
                {
                    mumie.CanvasSpieler.SetValue(Canvas.TopProperty, mumie.Posy = 300);
                }
                if (mumie.Posx < 365 && mumie.Posy > 215)//Loch x=15++350 y=15+200
                {
                    CanvasSpielerContainer.Children.Clear();
                    CanvasSpielerContainer.Children.Add(feuerwerk.CanvasSpieler);
                }
            }

            else if (CanvasSpielerContainer.Children.Contains(einstein.CanvasSpieler))
            {

                einstein.Posx = (double)einstein.CanvasSpieler.GetValue(Canvas.LeftProperty);
                einstein.Posy = (double)einstein.CanvasSpieler.GetValue(Canvas.TopProperty);//aktuelle Wert wird ermittelt
                
                if (e.Key == Key.Up)
                {
                    einstein.CanvasSpieler.SetValue(Canvas.TopProperty, einstein.Posy + einstein.Speed);
                }
                if (e.Key == Key.Left)
                {
                    einstein.CanvasSpieler.SetValue(Canvas.LeftProperty, einstein.Posx + einstein.Speed);
                }
                if (e.Key == Key.Right)
                {
                    einstein.CanvasSpieler.SetValue(Canvas.LeftProperty, einstein.Posx - einstein.Speed);
                }
                if (e.Key == Key.Down)
                {
                    einstein.CanvasSpieler.SetValue(Canvas.TopProperty, einstein.Posy - einstein.Speed);
                }

                //Positionen

                if (einstein.Posx < 10)//Links
                {
                    einstein.CanvasSpieler.SetValue(Canvas.LeftProperty, einstein.Posx = 10);

                }
                if (einstein.Posx > 900)//Rechts canvas ist 1000 breit + bereite Figur
                {
                    einstein.CanvasSpieler.SetValue(Canvas.LeftProperty, einstein.Posx = 900);
                }

                if (einstein.Posy < 0)//oben
                {
                    einstein.CanvasSpieler.SetValue(Canvas.TopProperty, einstein.Posy = 0);
                }

                if (einstein.Posy > 300)//unten Canvas ist 450 hoch - höhe spieler
                {
                    einstein.CanvasSpieler.SetValue(Canvas.TopProperty, einstein.Posy = 300);
                }
                if (einstein.Posx < 365 && einstein.Posy > 215)//Loch x=15++350 y=15+200
                {
                    CanvasSpielerContainer.Children.Clear();
                    CanvasSpielerContainer.Children.Add(feuerwerk.CanvasSpieler);
                }
            }

            else if (CanvasSpielerContainer.Children.Contains(bauarbeiter.CanvasSpieler))
            {
                bauarbeiter.Posx = (double)bauarbeiter.CanvasSpieler.GetValue(Canvas.LeftProperty);
                bauarbeiter.Posy = (double)bauarbeiter.CanvasSpieler.GetValue(Canvas.TopProperty);//aktuelle Wert wird ermittelt
            
                if (e.Key == Key.Up)
                {
                   bauarbeiter.CanvasSpieler.SetValue(Canvas.TopProperty, bauarbeiter.Posy + bauarbeiter.Speed);
                }
                if (e.Key == Key.Left)
                {
                  bauarbeiter.CanvasSpieler.SetValue(Canvas.LeftProperty, bauarbeiter.Posx + bauarbeiter.Speed);
                }
                if (e.Key == Key.Right)
                {
                    bauarbeiter.CanvasSpieler.SetValue(Canvas.LeftProperty, bauarbeiter.Posx - bauarbeiter.Speed);
                }
                if (e.Key == Key.Down)
                {
                    bauarbeiter.CanvasSpieler.SetValue(Canvas.TopProperty, bauarbeiter.Posy - bauarbeiter.Speed);
                }

                //Positionen

                if (bauarbeiter.Posx < 10)//Links
                {
                    bauarbeiter.CanvasSpieler.SetValue(Canvas.LeftProperty, bauarbeiter.Posx = 10);

                }
                if (bauarbeiter.Posx > 900)//Rechts canvas ist 1000 breit + bereite Figur
                {
                    bauarbeiter.CanvasSpieler.SetValue(Canvas.LeftProperty, bauarbeiter.Posx = 900);
                }

                if (bauarbeiter.Posy < 0)//oben
                {
                    bauarbeiter.CanvasSpieler.SetValue(Canvas.TopProperty, bauarbeiter.Posy = 0);
                }

                if (bauarbeiter.Posy > 300)//unten Canvas ist 450 hoch - Höhe spieler
                {
                    bauarbeiter.CanvasSpieler.SetValue(Canvas.TopProperty, bauarbeiter.Posy = 300);
                }
                if (bauarbeiter.Posx < 365 && bauarbeiter.Posy > 215)//Loch x=15+350 y=15+200
                {
                    CanvasSpielerContainer.Children.Clear();
                    CanvasSpielerContainer.Children.Add(feuerwerk.CanvasSpieler);
                }

            }
        }

        private void Spielstart(object sender, RoutedEventArgs e)
        {
            if (CanvasSpielerContainer.Children.Contains(magier.CanvasSpieler))
            {
                Container.Children.Remove(LblMagier);
                Container.Children.Remove(LblMumie);
                Container.Children.Remove(LblEinstein);
                Container.Children.Remove(LblBauarbeiter);
            }
           else if (CanvasSpielerContainer.Children.Contains(mumie.CanvasSpieler))
            {
                Container.Children.Remove(LblMagier);
                Container.Children.Remove(LblMumie);
                Container.Children.Remove(LblEinstein);
                Container.Children.Remove(LblBauarbeiter);
            }

         else   if (CanvasSpielerContainer.Children.Contains(einstein.CanvasSpieler))
            {
                Container.Children.Remove(LblMagier);
                Container.Children.Remove(LblMumie);
                Container.Children.Remove(LblEinstein);
                Container.Children.Remove(LblBauarbeiter);
            }

         else   if (CanvasSpielerContainer.Children.Contains(bauarbeiter.CanvasSpieler))
            {
                Container.Children.Remove(LblMagier);
                Container.Children.Remove(LblMumie);
                Container.Children.Remove(LblEinstein);
                Container.Children.Remove(LblBauarbeiter);
            }
        }

        private void Ende(object sender, RoutedEventArgs e)
        {
            Close();
        }

      
      
    }
}
    

