using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaContatos
{
   public class PaginaContato : ContentPage
    {
        ListView listView = new ListView();
        List<Models.Contato> Contatos = new List<Models.Contato>();
        Entry nomeUsuario, foneUsuario;
        public PaginaContato()
        {
          
            Label header = new Label
            {
                Text = "Adicionar Contato",
                HorizontalOptions = LayoutOptions.Center
                
            };
            //Placeholder	The default text that will appear in the control.
            nomeUsuario = new Entry { Placeholder = "Nome"};
            foneUsuario = new Entry { Placeholder = "Fone" };
            Button addUser = new Button
            {
                Text = "Adicionar",
                HorizontalOptions = LayoutOptions.Center
            };
            addUser.Clicked += AddUser_Clicked;

            Content = new StackLayout
            {
                Children = { header, nomeUsuario, foneUsuario, addUser, listView }
            };

        }

        private void AddUser_Clicked(object sender, EventArgs e)
        {
            var contato = new Models.Contato()
            {
                Nome = nomeUsuario.Text,
                Fone = foneUsuario.Text
            };
            Contatos.Add(contato);
            listView.ItemsSource = Contatos;
        }
    }
}
