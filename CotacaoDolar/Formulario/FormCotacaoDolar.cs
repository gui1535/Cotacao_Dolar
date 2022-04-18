using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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
                // Var responsavel pela requisição Get
                var response = client.GetAsync(strURL).Result;

                // Verificar se obteve sucesso na requisição
                if (response.IsSuccessStatusCode == true)
                {
                    // String de resultado
                    var resultado = response.Content.ReadAsStringAsync().Result;
                }
            }
        }
    }
}
