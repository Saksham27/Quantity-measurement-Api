using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IQuantityMeasurementRL
    {
        ConversionModel Conversion(ConversionModel quantity);
        List<ConversionModel> GetAllConverisons();
        ConversionModel GetConversionbyId(int Id);
        ConversionModel DeleteConversionById(int Id);

        ComparisonModel Comparison(ComparisonModel model);
        List<ComparisonModel> GetAllComparisons();
        ComparisonModel GetComparisonbyId(int Id);
        ComparisonModel DeleteComparisonById(int Id);
    }
}
