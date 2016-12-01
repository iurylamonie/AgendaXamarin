using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaContatos
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var labelWelcome = new Label
            {
                Text = "Agenda de Contatos",
                FontSize = 80.5,
                HorizontalOptions = LayoutOptions.Center
            };
            var layout = new StackLayout
            {
               Children =
                {
                     labelWelcome
                },

            };

            Content = layout;
        }
    }
}
