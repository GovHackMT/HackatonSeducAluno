using System;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HackatonSeducAluno
{
    public class AulaAtividadeService
    {
        public async Task Incluir(AulaAtividade aulaAtividade, bool isNewItem = false)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var RestUrl = "http://govhackseduc.azurewebsites.net/tables/AulaAtividade?ZUMO-API-VERSION=2.0.0";
                    //var uri = new Uri(string.Format(RestUrl, string.Empty));
                    var json = new StringContent(JsonConvert.SerializeObject(aulaAtividade), Encoding.UTF8, "application/json");

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

        public async Task Atualizar(AulaAtividade aulaAtividade, bool isNewItem = false)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var RestUrl = "http://govhackseduc.azurewebsites.net/tables/AulaAtividade?ZUMO-API-VERSION=2.0.0";
                    //var uri = new Uri(string.Format(RestUrl, string.Empty));
                    var json = new StringContent(JsonConvert.SerializeObject(aulaAtividade), Encoding.UTF8,"application/json");

                    var response = await client.PutAsync(RestUrl, json);
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

        public async Task<List<AulaAtividade>> ObterAulaAtividade()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var RestUrl = "http://govhackseduc.azurewebsites.net/tables/AulaAtividade?ZUMO-API-VERSION=2.0.0";
                    var uri = new Uri(string.Format(RestUrl, string.Empty));

                    var response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var aulaAtividades = JsonConvert.DeserializeObject<List<AulaAtividade>>(content);
                        return aulaAtividades;
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
