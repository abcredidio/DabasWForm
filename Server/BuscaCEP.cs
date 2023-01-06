using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace CadClientesProdutosWForm.Server
{
    internal class BuscaCEP
    {
        internal async void FindCep(TextBox textbox, TextBox endereco , TextBox bairro, TextBox uf, TextBox cidade)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage resposta = await
                httpClient.GetAsync($"https://viacep.com.br/ws/{textbox.Text}/json/");

            if (resposta.IsSuccessStatusCode)
            {
                string resultado = await resposta.Content.ReadAsStringAsync();

                dynamic json = JsonConvert.DeserializeObject<dynamic>(resultado);

                endereco.Text = json.logradouro;
                bairro.Text = json.bairro;
                uf.Text = json.uf;
                cidade.Text = json.localidade;
            }
        }

    }
}
