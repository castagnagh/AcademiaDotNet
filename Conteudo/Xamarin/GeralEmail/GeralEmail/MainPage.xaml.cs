using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GeralEmail
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btEnviar.Clicked += BtEnviar_Clicked;
            btCalcular.Clicked += BtCalcular_Clicked;
        }

        private void BtEnviar_Clicked(object sender, EventArgs e)
        {
            string nomeCompleto = nomeComp.Text;

            string[] nomes = nomeComp.Text.Split(' ');
            string emailGerado = "";

            if (nomes.Length >= 2)
            {
                string primeroNome = nomes[0].ToLower();
                string segundoNome = nomes[1].ToLower();

                emailGerado = segundoNome + primeroNome + "@ufn.edu.br";

            }
            lbEmailGerado.Text = emailGerado;

        }

        private void BtCalcular_Clicked(object sender, EventArgs e)
        {
           
            double pesoValor = double.Parse(peso.Text);
            double alturaValor = double.Parse(altura.Text);

            if (alturaValor > 3)
            {
                alturaValor /= 100; 
            }

            double imc = pesoValor / (alturaValor * alturaValor);
            lbImc.Text = imc.ToString("F2");
        }
    }
}
