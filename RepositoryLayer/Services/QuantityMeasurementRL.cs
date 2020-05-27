/// ================================================
/// File    : QuantityMeasurementRL.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
using CommonLayer.Model;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace RepositoryLayer.Services
{
    public class QuantityMeasurementRL : IQuantityMeasurementRL
    {
        private QuantityDBContext dBContext;

        public QuantityMeasurementRL(QuantityDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        /// <summary>
        /// Method to take a value and option and convert
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        #region Conversion
        public ConversionModel Conversion(ConversionModel quantity)
        {
            bool isOptionValid = Enum.TryParse<ConversionOptions>(quantity.OperationType, true, out ConversionOptions option);
            if (isOptionValid)
            {
                try
                {
                    var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@inputId",
                            SqlDbType =  SqlDbType.Int,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = (int)option
                        },
                        new SqlParameter() {
                            ParameterName = "@inputValue",
                            SqlDbType =  SqlDbType.Float,
                            Direction = ParameterDirection.Input,
                            Value = quantity.Value
                        }};
                    ConversionModel output = dBContext.Conversions.FromSql("[dbo].[spConvert] @inputId, @inputValue", param).FirstOrDefault();
                    dBContext.SaveChanges();
                    return output;
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
            else
            {
                return quantity;
            }    
        }
        #endregion

        /// <summary>
        /// Method to get all conversion List
        /// </summary>
        /// <returns></returns>
        #region GetAllConverisons
        public List<ConversionModel> GetAllConverisons()
        {
            try
            {
                return dBContext.Conversions.ToList();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion

        /// <summary>
        /// Method to return a specific conversion provided it's Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        #region GetConversionbyId
        public ConversionModel GetConversionbyId(int Id)
        {
            try
            {
                ConversionModel quantity = dBContext.Conversions.Find(Id);
                return quantity;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion

        /// <summary>
        /// Method to delete an perviously performed converison provided it''s Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        #region DeleteConversionById
        public ConversionModel DeleteConversionById(int Id)
        {
            try
            {
                ConversionModel quantity = dBContext.Conversions.Find(Id);
                if (quantity != null)
                {
                    dBContext.Conversions.Remove(quantity);
                    dBContext.SaveChanges();
                }
                return quantity;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        #endregion

        /// <summary>
        /// Method to take a 2 values and thier untis and compare
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        #region Comparison
        public ComparisonModel Comparison(ComparisonModel model)
        {
            bool isUnitOneValid = Enum.TryParse<Unit>(model.ValueOneUnit, true, out Unit unitOne);
            bool isUnitTwoValid = Enum.TryParse<Unit>(model.ValueTwoUnit, true, out Unit unitTwo);
            if(isUnitOneValid && isUnitTwoValid)
            {
                try
                {
                    var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@inputFirstId",
                            SqlDbType =  SqlDbType.Int,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = (int)unitOne
                        },
                        new SqlParameter() {
                            ParameterName = "@inputfirstValue",
                            SqlDbType =  SqlDbType.Float,
                            Direction = ParameterDirection.Input,
                            Value = model.ValueOne
                        },
                        new SqlParameter() {
                            ParameterName = "@inputSecondId",
                            SqlDbType =  SqlDbType.Int,
                            Direction = ParameterDirection.Input,
                            Value = (int)unitTwo
                        },
                        new SqlParameter() {
                            ParameterName = "@inputSecondValue",
                            SqlDbType =  SqlDbType.Float,
                            Direction = ParameterDirection.Input,
                            Value = model.ValueTwo
                        }};
                    ComparisonModel output = dBContext.Comparisons.FromSql("[dbo].[spCompare] @inputFirstId, @inputfirstValue, @inputSecondId, @inputSecondValue", param).FirstOrDefault();
                    dBContext.SaveChanges();
                    return output;
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
            else
            {
                return model;
            }
        }
        #endregion

        /// <summary>
        /// Method to get all comparison List
        /// </summary>
        /// <returns></returns>
        #region GetAllComparisons
        public List<ComparisonModel> GetAllComparisons()
        {
            try
            {
                return dBContext.Comparisons.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion

        /// <summary>
        /// Method to return a specific comparison provided it's Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        #region GetComparisonbyId
        public ComparisonModel GetComparisonbyId(int Id)
        {
            try
            {
                ComparisonModel quantity = dBContext.Comparisons.Find(Id);
                return quantity;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion

        /// <summary>
        /// Method to delete an perviously performed comparison provided it's Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        #region DeleteComparisonById
        public ComparisonModel DeleteComparisonById(int Id)
        {
            try
            {
                ComparisonModel quantity = dBContext.Comparisons.Find(Id);

                if (quantity != null)
                {
                    dBContext.Comparisons.Remove(quantity);
                    dBContext.SaveChanges();
                }
                return quantity;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        #endregion
    }
}
