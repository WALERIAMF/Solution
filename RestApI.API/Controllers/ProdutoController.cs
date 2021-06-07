using Microsoft.AspNetCore.Mvc;
using RestApi.Application.Dtos;
using RestApi.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto ApplicationServiceProduto)
        {
            _applicationServiceProduto = ApplicationServiceProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id));
        }
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();
                _applicationServiceProduto.Add(produtoDto);
                return Ok("Cliente Cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();
                _applicationServiceProduto.Remove(produtoDto);
                return Ok("Cliente Removido com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
