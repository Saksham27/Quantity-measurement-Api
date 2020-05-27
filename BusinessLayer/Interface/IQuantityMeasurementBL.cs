using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IQuantityMeasurementBL
    {
        Response<ConversionModel> Conversion(ConversionModel quantity);
        Response<ConversionModel> GetAllConverisons();
        Response<ConversionModel> GetConversionbyId(int Id);
        Response<ConversionModel> DeleteConversionById(int Id);

        Response<ComparisonModel> Comparison(ComparisonModel quantity);
        Response<ComparisonModel> GetAllComparisons();
        Response<ComparisonModel> GetComparisonbyId(int Id);
        Response<ComparisonModel> DeleteComparisonById(int Id);
    }
}
