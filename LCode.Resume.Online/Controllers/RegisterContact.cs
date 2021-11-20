using LCode.NETCore.Base._5._0.Comunicacion;
using LCode.NETCore.Base._5._0.Logs;
using LCode.Resume.Online.DataBase.Contextos.v1_0;
using LCode.Resume.Online.Models;
using LCode.Resume.Online.Models.v1_0;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LCode.Resume.Online.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterContact : ControllerBase
    {
        Contexto contexto = new Contexto();
        // POST api/<RegisterContact>
        [HttpPost]
        public async Task<ResponseSite> Post([FromForm] Contact value)
        {
            ResponseSite ResponseS = new ResponseSite();
            try
            {
                if (!string.IsNullOrEmpty(value.Recaptcha))
                {
                    Api api = new Api();
                    string RecResponse = api.Post("https://www.google.com/recaptcha/api/siteverify?secret=6LdqmCAUAAAAANONcPUkgVpTSGGqm60cabVMVaON&response=" + value.Recaptcha, null);
                    RecaptchaResponse Response = JsonConvert.DeserializeObject<RecaptchaResponse>(RecResponse);
                    if (Response.success)
                    {
                        contexto.Contact_Registry.Add(value);
                        await contexto.SaveChangesAsync();
                        ResponseS.type = "success";
                        ResponseS.message = "Thank you! Gracias! Grazie! Danke Sehr! O Brigado!.";
                    }
                    else
                    {
                        ResponseS.type = "danger";
                        ResponseS.message = "Please click on the reCAPTCHA box.";
                    }
                }
                else
                {
                    ResponseS.type = "danger";
                    ResponseS.message = "Please click on the reCAPTCHA box.";
                }
                return ResponseS;
            }
            catch (Exception ex)
            {
                ResponseS.type = "danger";
                ResponseS.message = "An error has ocurred, please retry later! Sorry ;)";
                await Evento.ErrorAsync(ex);
                return ResponseS;
            }
        }
    }
}
