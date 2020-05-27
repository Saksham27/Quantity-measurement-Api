/// ================================================
/// File    : QuantityController.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
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

        /// <summary>
        /// Post Method for inputting the value with option and performing conversion
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        #region Conversion
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
        #endregion

        /// <summary>
        /// Get Method for getting list of all the performed conversions
        /// </summary>
        /// <returns></returns>
        #region GetAllConversions
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
        #endregion

        /// <summary>
        /// Get method for getting specific conversion given it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        #region GetConversionbyId
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
        #endregion

        /// <summary>
        /// Delete method for deleting a specific conversion given it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        #region GetConversionbyId
        [Route("conversion/{id}")]
        [HttpDelete("conversion/{id}")]
        public IActionResult C([FromRoute]int id)
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
        #endregion

        /// <summary>
        /// Post Method for inputting the value with option and performing comparison
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        #region Comparison
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
        #endregion

        /// <summary>
        /// Get Method for getting list of all the performed comparison
        /// </summary>
        /// <returns></returns>
        #region GetAllComparisons
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
        #endregion

        /// <summary>
        /// Get method for getting specific comparison given it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        #region GetComparisonbyId
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
        #endregion

        /// <summary>
        /// Delete method for deleting a specific comparison given it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        #region DeleteCompariosnById
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
        #endregion
    }
}