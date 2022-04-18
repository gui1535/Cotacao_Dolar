using CotacaoDolar.Classes;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;

namespace CotacaoDolar
{
    public partial class FormCotacaoDolar : Form
    {
        public FormCotacaoDolar()
        {
            InitializeComponent();
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // String para URL
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=093a3e05";

            // Bloco
            using (HttpClient client = new HttpClient())
            {
                // Tratando erro
                try
                {
                    // Var responsavel pela requisição Get
                    var response = client.GetAsync(strURL).Result;

                    // Verificar se obteve sucesso na requisição
                    if (response.IsSuccessStatusCode == true)
                    {
                        // String de resultado
                        var resultado = response.Content.ReadAsStringAsync().Result;

                        // Pegar o resultado e deserializar para o objeto
                        Mercado mercado = JsonConvert.DeserializeObject<Mercado>(resultado);

                        // Formatando e atribuindo resultados
                        lbMstCompra.Text = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mercado.Moeda.Compra);
                        lbMstVenda.Text = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mercado.Moeda.Venda);
                        lbMsrVariacao.Text = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", mercado.Moeda.Variacao / 100);
                    }
                    else
                    {
                        lbMstCompra.Text = "-";
                        lbMstVenda.Text = "-";
                        lbMsrVariacao.Text = "-";
                    }
                }
                catch (Exception ex)
                {
                    lbMstCompra.Text = "-";
                    lbMstVenda.Text = "-";
                    lbMsrVariacao.Text = "-";

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
