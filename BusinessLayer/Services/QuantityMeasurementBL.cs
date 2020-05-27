/// ================================================
/// File    : QuantityMeasurementBL.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    /// <summary>
    /// service Class for business logic implementation 
    /// </summary>
    public class QuantityMeasurementBL : IQuantityMeasurementBL
    {
        /// <summary>
        /// instance of repo layer service
        /// </summary>
        private IQuantityMeasurementRL quantityMeasurementRL;

        /// <summary>
        /// construcotr
        /// </summary>
        /// <param name="quantityMeasurementRL"></param>
        public QuantityMeasurementBL(IQuantityMeasurementRL quantityMeasurementRL)
        {
            this.quantityMeasurementRL = quantityMeasurementRL;
        }

        /// <summary>
        /// Business layer logic for conversion Method
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        #region Conversion
        public Response<ConversionModel> Conversion(ConversionModel quantity)
        {
            try
            {
                Response<ConversionModel> response = new Response<ConversionModel>();
                ConversionModel model = quantityMeasurementRL.Conversion(quantity);

                if (model.Result !=0 )
                {
                    response.Success = true;
                    response.Message = "Conversion successful";
                    response.Data.Add(model);
                }else
                {
                    response.Success = false;
                    response.Message = "Conversion failed";
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion

        /// <summary>
        /// Business layer login for GetAllConversions Method
        /// </summary>
        /// <returns></returns>
        #region GetAllConverisons
        public Response<ConversionModel> GetAllConverisons()
        {
            try
            {
                Response<ConversionModel> response = new Response<ConversionModel>();
                List<ConversionModel> dataList =  this.quantityMeasurementRL.GetAllConverisons();
                if(dataList.Count == 0)
                {
                    response.Success = false;
                    response.Message = "No Conversions has been performed yet.";
                }
                else
                {
                    response.Success = true;
                    response.Message = "Here are all the Conversions";
                    response.Data = dataList;
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion

        /// <summary>
        /// Business layer login for GetConversionbyId Method
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        #region GetConversionbyId
        public Response<ConversionModel> GetConversionbyId(int Id)
        {
            try
            {
                Response<ConversionModel> response = new Response<ConversionModel>();
                ConversionModel model = new ConversionModel();
                model =  this.quantityMeasurementRL.GetConversionbyId(Id);
                if (model is null)
                {
                    response.Success = false;
                    response.Message = "No such conversion exists.";                  
                }
                else
                {
                    response.Success = true;
                    response.Message = "Here is the requested conversion";
                    response.Data.Add(model);
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion

        /// <summary>
        /// business layer login for DeleteConversionbyId Method
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        #region DeleteConversionById
        public Response<ConversionModel> DeleteConversionById(int Id)
        {
            try
            {
                Response<ConversionModel> response = new Response<ConversionModel>();
                ConversionModel model =  this.quantityMeasurementRL.DeleteConversionById(Id);
                if (model is null)
                {
                    response.Success = false;
                    response.Message = "No such conversion exists.";             
                }
                else
                {
                    response.Success = true;
                    response.Message = "Deletion Successful !!! This is the conversion which has been deleted.";
                    response.Data.Add(model);
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion

        /// <summary>
        /// Business layer logic for comparison Method
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        #region Comparison
        public Response<ComparisonModel> Comparison(ComparisonModel quantity)
        {
            try
            {
                Response<ComparisonModel> response = new Response<ComparisonModel>();
                ComparisonModel model = new ComparisonModel();
                model = quantityMeasurementRL.Comparison(quantity);

                if (model.Result != null)
                {
                    response.Success = true;
                    response.Message = "Here are comparison results";
                    response.Data.Add(model);
                }else
                {
                    response.Success = false;
                    response.Message = "Invalid units used. Please use valid Units";
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion

        /// <summary>
        /// Business layer login for GetAllComparisons Method
        /// </summary>
        /// <returns></returns>
        #region GetAllComparisons
        public Response<ComparisonModel> GetAllComparisons()
        {
            try
            {
                Response<ComparisonModel> response = new Response<ComparisonModel>();
                List<ComparisonModel> dataList = this.quantityMeasurementRL.GetAllComparisons();
                if (dataList.Count == 0)
                {
                    response.Success = false;
                    response.Message = "No Comparisons has been performed yet.";
                }
                else
                {
                    response.Success = true;
                    response.Message = "Here are all the Comparisons";
                    response.Data = dataList;
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion

        /// <summary>
        /// Business layer login for GetComparisonbyId Method
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        #region GetComparisonbyId
        public Response<ComparisonModel> GetComparisonbyId(int Id)
        {
            try
            {
                Response<ComparisonModel> response = new Response<ComparisonModel>();
                ComparisonModel model = new ComparisonModel();
                model = this.quantityMeasurementRL.DeleteComparisonById(Id);
                if (model is null)
                {
                    response.Success = false;
                    response.Message = "No such comparison exists.";
                }
                else
                {
                    response.Success = true;
                    response.Message = "Here is the requested comparison";
                    response.Data.Add(model);
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion

        /// <summary>
        /// business layer login for DeleteConversionbyId Method
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        #region DeleteComparisonById
        public Response<ComparisonModel> DeleteComparisonById(int Id)
        {
            try
            {
                Response<ComparisonModel> response = new Response<ComparisonModel>();
                ComparisonModel model = this.quantityMeasurementRL.DeleteComparisonById(Id);
                if (model is null)
                {
                    response.Success = false;
                    response.Message = "No such comparison exists.";
                }
                else
                {
                    response.Success = true;
                    response.Message = "Deletion Successful !!! This is the comparison which has been deleted.";
                    response.Data.Add(model);
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion
    }
}
