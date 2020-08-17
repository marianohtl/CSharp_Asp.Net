using DgBar.Domain.Entities;
using DgBar.Domain.Interfaces;
using DgBar.Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DgBar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderManageService _OrderManageService;
        

        public OrderController(IOrderManageService orderManageService)
        {
            _OrderManageService = orderManageService;
        }


        [HttpPost("ResgistryOrder")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<SheetOrderViewModel> RegistryOrder([FromBody] SheetOrderViewModel order)
        {

            var _sheetOrder = _OrderManageService.RegistryOrder(order.IdOrder, order.IdMenu);
            SheetOrderViewModel _sheetOrderViewModel = new SheetOrderViewModel(_sheetOrder);
            if (_sheetOrderViewModel != null)
            {
                return Ok(_sheetOrderViewModel);
            }
            else
            {
                return NoContent();
            }
        }


        [HttpPost("GenerateNote")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<OrderViewModel> GenerateNote([FromBody] OrderViewModel order)
        {

            var _note = _OrderManageService.GenerateNote(order.Id);

            if (_note != null)
            {
                return Ok(_note);
            }
            else
            {
                return NoContent();
            }
        }

        [HttpDelete("ResetOrder/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult ResetOrder(int id)
        {
            var result = _OrderManageService.ResetOrder(id);

            if (result)
            {
                return Ok("Deletado com sucesso!");
            }
            else
            {
                return NoContent();
            }
        }


    }
}
