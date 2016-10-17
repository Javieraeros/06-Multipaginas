using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Input.Inking;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace _06_Multipaginas_Canvas
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Paint : Page
    {
        //private bool lapizActivo;
        public Paint()
        {
            this.InitializeComponent();
            lienzo.InkPresenter.InputDeviceTypes = Windows.UI.Core.CoreInputDeviceTypes.Mouse | Windows.UI.Core.CoreInputDeviceTypes.Touch;
            lienzo.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
            //lapizActivo = true;
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

       private void btnLapizGoma_Click(object sender, RoutedEventArgs e)
        {
            if (lienzo.InkPresenter.InputProcessingConfiguration.Mode == InkInputProcessingMode.Inking)
            {
                lienzo.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Erasing;
                //lapizActivo = false;
                btnLapizGoma.Content = "Escribe";
                /*Otra forma de hacerlo:
                 * Button btn = (Button)sender;
                btn.Content = "Escribe";
                */
            }
            else
            {
                lienzo.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
                btnLapizGoma.Content = "Borra";
                //lapizActivo = true;
            }
        }
    }
}
