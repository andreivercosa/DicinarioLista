using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ListaMunicipios.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ListaMunicipios
{
    public partial class MainPage : ContentPage
    {

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            Dictionary<string, string> conteudo = new Dictionary<string, string>();
            conteudo.Add("Professor", "Ramon");
            conteudo.Add("Aluno", "Michael");
            conteudo.Add("Mito", "Lula");
            conteudo.Add("Oraculo", "Dilma");


            List<Mestre> listaMestre = new List<Mestre>();

            foreach(KeyValuePair<string,string> conteudoDaLista in conteudo)
            {
                Mestre mestre = new Mestre();
                mestre.nome = conteudoDaLista.Value;
                mestre.tipo = conteudoDaLista.Key;

                listaMestre.Add(mestre);
            }


            listaMunicipio.ItemsSource = listaMestre;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
