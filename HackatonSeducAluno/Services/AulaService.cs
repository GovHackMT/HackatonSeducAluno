using System;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using HackatonSeducAluno;
using System.Text;

namespace HackatonSeducAula
{
    public class AulaService
    {


        public async Task<List<Aula>> ObterAula()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var RestUrl = "http://govhackseduc.azurewebsites.net/tables/Aula?ZUMO-API-VERSION=2.0.0";
                    var uri = new Uri(string.Format(RestUrl, string.Empty));

                    var response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var aulas = JsonConvert.DeserializeObject<List<Aula>>(content);
                        return aulas;
                    }
                }
                return null;
            }
            catch (Exception e)
            {

                throw;
            }

        }


        public async Task Incluir(Aula aula, bool isNewItem = false)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var RestUrl = "http://govhackseduc.azurewebsites.net/tables/Aula?ZUMO-API-VERSION=2.0.0";
                    //var uri = new Uri(string.Format(RestUrl, string.Empty));
                    var json = new StringContent(JsonConvert.SerializeObject(aula), Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(RestUrl, json);
                    if (response.IsSuccessStatusCode)
                    {
                        //var content = await response.Content.ReadAsStringAsync();
                        //var aulas = JsonConvert.DeserializeObject<List<AulaAtividade>>(content);
                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
