using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
namespace AgendaContatos
{
    
    public class Agenda : TabbedPage
    {
        //Lista de Contatos
        ListView listView = new ListView();
        Button atualizarLista = new Button { Text = "Atualizar Lista", HorizontalOptions = LayoutOptions.Center };

        //Adicionar contato
        Entry nomeUsuario = new Entry { Placeholder = "Nome"};
        Entry foneUsuario = new Entry { Placeholder = "Telefone"};
        Button adicionarUsuario = new Button { Text = "Adicionar", HorizontalOptions = LayoutOptions.Center };
       

        List<Models.Contato> contatos = new List<Models.Contato>();

        public Agenda()
        {
            this.Children.Add(new ContentPage
            {
                Title = "Adicionar Contato",
                Content = new StackLayout
                {
                    Children =
                        { nomeUsuario, foneUsuario, adicionarUsuario }
                }
            });

            this.Children.Add(new ContentPage
                {
                    Title = "Lista de Contatos",
                    Content = new StackLayout
                    {
                        Children =
                        { listView, atualizarLista }
                    }
            });
            atualizarLista.Clicked += AtualizarLista_Clicked;           
            adicionarUsuario.Clicked += AdicionarUsuario_Clicked;
        }

        private void AtualizarLista_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = contatos;
        }

        private void AdicionarUsuario_Clicked(object sender, EventArgs e)
        {
            var contato = new Models.Contato { Nome = nomeUsuario.Text, Fone = foneUsuario.Text };
            contatos.Add(contato);
        }
    }
}
