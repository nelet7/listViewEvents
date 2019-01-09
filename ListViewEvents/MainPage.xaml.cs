using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ListViewEvents
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void imageView_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(imageView).Position.X;
            double y = e.GetCurrentPoint(imageView).Position.Y;
            this.listView.Items.Insert(0, "La imagen ha sido presionada en x = " + x + "e y = " + y + ".");
        }

        private void imageView_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(imageView).Position.X;
            double y = e.GetCurrentPoint(imageView).Position.Y;
            this.listView.Items.Insert(0, "El puntero ha sido movida en x = " + x + "e y = " + y + ".");
        }

        private void imageView_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(imageView).Position.X;
            double y = e.GetCurrentPoint(imageView).Position.Y;
            this.listView.Items.Insert(0, "El puntero ha sido soltado en x = " + x + "e y = " + y + ".");
        }

        private void imageView_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(imageView).Position.X;
            double y = e.GetCurrentPoint(imageView).Position.Y;
            this.listView.Items.Insert(0, "El puntero ha entrado por x = " + x + "e y = " + y + ".");
        }

        private void imageView_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(imageView).Position.X;
            double y = e.GetCurrentPoint(imageView).Position.Y;
            this.listView.Items.Insert(0, "El puntero ha salido por x = " + x + "e y = " + y + ".");
        }

        private void imageView_PointerCanceled(object sender, PointerRoutedEventArgs e)
        {
            this.listView.Items.Insert(0, "El puntero ha sido cancelado");
        }

        private void imageView_PointerCaptureLost(object sender, PointerRoutedEventArgs e)
        {
            this.listView.Items.Insert(0, "La captura del puntero se ha perdido");
        }

        private void imageView_PointerWheelChanged(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(imageView).Position.X;
            double y = e.GetCurrentPoint(imageView).Position.Y;
            this.listView.Items.Insert(0, "La rueda del ratón ha cambiado de valor en x = " + x + "e y = " + y + ".");
        }

        private void imageView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            imageView.Opacity -= 0.1;
        }

        private void imageView_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            imageView.Opacity = 1.0;
        }

        private void imageView_Holding(object sender, HoldingRoutedEventArgs e)
        {
            this.listView.Items.Clear();
        }
    }
}
