using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication1.Application.Dtos;
using WebApplication1.Application.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteApplication clienteApplication;

        public ClienteController(IClienteApplication clienteApplication)
        {
            this.clienteApplication = clienteApplication;
        }

        [HttpGet]
        public ActionResult<IEnumerable<String>> Get()
        {
            return Ok(clienteApplication.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<String> Get(string id)
        {
            return Ok(clienteApplication.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {

            if (clienteDto == null)
                return NotFound();

            try
            {
                clienteApplication.Add(clienteDto);
                return Ok("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {

            if (clienteDto == null)
                return NotFound();

            try
            {
                clienteApplication.Update(clienteDto);
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {

            if (clienteDto == null)
                return NotFound();

            try
            {
                clienteApplication.Remove(clienteDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
