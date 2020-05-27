using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuantityMeasurementAPI.Controllers
{
    [Route("api/quantityMeasurement")]
    [ApiController]
    public class QuantityController : ControllerBase
    {
        private IQuantityMeasurementBL quantityMeasurementBL;

        public QuantityController(IQuantityMeasurementBL quantityMeasurementBL)
        { 
            this.quantityMeasurementBL = quantityMeasurementBL;
        }

        [Route("conversion")]
        [HttpPost]
        public IActionResult Conversion([FromBody]ConversionModel quantity)
        {
            try
            {
                Response<ConversionModel> response = quantityMeasurementBL.Conversion(quantity);
                if (response.Success == true)
                {
                    return Ok(new { response.Success, response.Message, response.Data });
                }
                else
                {
                    return Ok(new { response.Success, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success=false , message=exception.Message });
            }
        }

        [Route("conversion")]
        [HttpGet]
        public IActionResult GetAllConversions()
        {
            try
            {
                Response<ConversionModel> response = quantityMeasurementBL.GetAllConverisons();
                if (response.Success == true)
                {
                    return Ok(new { response.Success, response.Message, response.Data });
                }
                else
                {
                    return Ok(new { response.Success, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success=false, message=exception.Message});
            }
        }

        [Route("conversion/{id}")]
        [HttpGet("conversion/{id}")]
        public IActionResult GetConversionbyId([FromRoute]int id)
        {
            try
            {
                Response<ConversionModel> response = quantityMeasurementBL.GetConversionbyId(id);
                if (response.Success == true)
                {
                    return Ok(new { response.Success, response.Message, response.Data });
                }
                else
                {
                    return Ok(new { response.Success, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }

        [Route("conversion/{id}")]
        [HttpDelete("conversion/{id}")]
        public IActionResult DeleteConversionById([FromRoute]int id)
        {
            try
            {
                Response<ConversionModel> response = quantityMeasurementBL.DeleteConversionById(id);
                if (response.Success == true)
                {
                    return Ok(new { response.Success, response.Message, response.Data });
                }
                else
                {
                    return Ok(new { response.Success, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }

        [Route("comparison")]
        [HttpPost]
        public IActionResult Comparison([FromBody]ComparisonModel quantity)
        {
            try
            {
                Response<ComparisonModel> response = quantityMeasurementBL.Comparison(quantity);
                if (response.Success == true)
                {
                    return Ok(new { response.Success, response.Message, response.Data });
                }
                else
                {
                    return Ok(new { response.Success, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }

        [Route("comparison")]
        [HttpGet]
        public IActionResult GetAllComparisons()
        {
            try
            {
                Response<ComparisonModel> response = quantityMeasurementBL.GetAllComparisons();
                if (response.Success == true)
                {
                    return Ok(new { response.Success, response.Message, response.Data });
                }
                else
                {
                    return Ok(new { response.Success, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }

        [Route("comparison/{id}")]
        [HttpGet("comparison/{id}")]
        public IActionResult GetComparisonbyId([FromRoute]int id)
        {
            try
            {
                Response<ComparisonModel> response = quantityMeasurementBL.GetComparisonbyId(id);
                if (response.Success == true)
                {
                    return Ok(new { response.Success, response.Message, response.Data });
                }
                else
                {
                    return Ok(new { response.Success, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }

        [Route("comparison/{id}")]
        [HttpDelete("comparison/{id}")]
        public IActionResult DeleteCompariosnById([FromRoute]int id)
        {
            try
            {
                Response<ComparisonModel> response = quantityMeasurementBL.DeleteComparisonById(id);
                if (response.Success == true)
                {
                    return Ok(new { response.Success, response.Message, response.Data });
                }
                else
                {
                    return Ok(new { response.Success, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { Success = false, message = exception.Message });
            }
        }
    }
}