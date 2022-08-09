using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication1.Application.Dtos;
using WebApplication1.Application.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplication productApplication;

        public ProductController(IProductApplication productApplication)
        {
            this.productApplication = productApplication;
        }

        [HttpGet]
        public ActionResult<IEnumerable<String>> Get()
        {
            return Ok(productApplication.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<String> Get(string id)
        {
            return Ok(productApplication.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDto productDto)
        {
            if (productDto == null)
                return NotFound();

            try
            {
                productApplication.Add(productDto);
                return Ok("Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProductDto productDto)
        {
            if (productDto == null)
                return NotFound();

            try
            {
                productApplication.Update(productDto);
                return Ok("Produto atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpDelete()]
        public ActionResult Delete([FromBody] ProductDto productDto)
        {
            if (productDto == null)
                return NotFound();

            try
            {
                productApplication.Remove(productDto);
                return Ok("Produto removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
