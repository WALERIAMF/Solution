using Microsoft.AspNetCore.Mvc;
using RestApi.Application.Dtos;
using RestApi.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IApplicationServiceClient _applicationServiceClient;

        public ClientController(IApplicationServiceClient ApplicationServiceClient)
        {
            _applicationServiceClient = ApplicationServiceClient;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceClient.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceClient.GetById(id));
        }
        [HttpPost]
        public ActionResult Post([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();
                _applicationServiceClient.Add(clientDto);
                return Ok("Cliente Cadastrado com sucesso");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();
                _applicationServiceClient.Remove(clientDto);
                return Ok("Cliente Removido com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
