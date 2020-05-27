/// ================================================
/// File    : IQuantityMeasurementRL.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
using CommonLayer.Model;
using System.Collections.Generic;

#region RepositoryLayer.Interface
namespace RepositoryLayer.Interface
{
    /// <summary>
    /// interface for repository layer
    /// </summary>
    #region IQuantityMeasurementRL
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
    #endregion
}
#endregion
