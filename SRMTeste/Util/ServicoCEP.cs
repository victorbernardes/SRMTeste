using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SRMTeste.Util
{
    public class ServicoCEP
    {
        public List<string> BuscarCEP(string cep)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cep + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível");
                    return new List<string>();
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            //devolve um JSON, poderia usar a dll do Newtonsoft e deserializar ele 
                            //em um objeto de endereco como alternativa
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            return response.Split('\n').ToList();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                return new List<string>();
            }
            return new List<string>();
        }
    }
}
