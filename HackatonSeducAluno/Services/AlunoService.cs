using System;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;


namespace HackatonSeducAluno
{
    public class AlunoService
    {

        //public static async Task<List<Aluno>> ObterAluno()
        //{
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            //client.DefaultRequestHeaders.Add("Cookie", "ARRAffinity=796fcc73bba1317072cfe2bcb59b4cf7d89a1c4adf366b51d7d84fe022aee5ff");
        //            var json = await client.GetStringAsync("http://govhackseduc.azurewebsites.net/tables/Aluno?ZUMO-API-VERSION=2.0.0");
        //            var alunos = JsonConvert.DeserializeObject<List<Aluno>>(json);
        //            return alunos;
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        throw;
        //    }

        //}


        public async Task<List<Aluno>> ObterAluno()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var RestUrl = "http://govhackseduc.azurewebsites.net/tables/Aluno?ZUMO-API-VERSION=2.0.0";
                    var uri = new Uri(string.Format(RestUrl, string.Empty));

                    var response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var alunos = JsonConvert.DeserializeObject<List<Aluno>>(content);
                        return alunos;
                    }
                }
                return null;
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
