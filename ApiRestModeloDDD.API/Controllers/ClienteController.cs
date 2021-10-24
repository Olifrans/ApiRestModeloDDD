using ApiRestModeloDDD.App.Dtos;
using ApiRestModeloDDD.App.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApiRestModeloDDD.API.Controllers
{
    [Route("[controller]")]
    //[Route("cliente/")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            this._applicationServiceCliente = applicationServiceCliente;
        }

        //Get api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Buscar()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

        //Get Id api/values
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Buscar(int id)
        {
            return Ok(_applicationServiceCliente.GetById(id));
        }

        //Post api/values
        [HttpPost]
        public ActionResult Adcionar([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Add(clienteDto);
                return Ok("Cliente cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Put api/values
        [HttpPut]
        public ActionResult Atualizar([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Update(clienteDto);
                return Ok("Cliente atualizado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Put api/values
        [HttpDelete]
        public ActionResult Excluir([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Remove(clienteDto);
                return Ok("Cliente removido com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}