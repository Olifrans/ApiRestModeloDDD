using ApiRestModeloDDD.App.Dtos;
using ApiRestModeloDDD.App.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApiRestModeloDDD.API.Controllers
{
    [Route("[controller]")]
    //[Route("produto/")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            this._applicationServiceProduto = applicationServiceProduto;
        }

        //Get api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Buscar()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        //Get Id api/values
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Buscar(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id));
        }

        //Post api/values
        [HttpPost]
        public ActionResult Adcionar([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Add(produtoDto);
                return Ok("Produto cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Put api/values
        [HttpPut]
        public ActionResult Atualizar([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Update(produtoDto);
                return Ok("Produto atualizado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Put api/values
        [HttpDelete]
        public ActionResult Excluir([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Remove(produtoDto);
                return Ok("Produto removido com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}