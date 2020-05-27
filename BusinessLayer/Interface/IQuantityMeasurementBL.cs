/// ================================================
/// File    : IQuantityMeasurementBL.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
using CommonLayer.Model;

#region BusinessLayer.Interface
namespace BusinessLayer.Interface
{
    /// <summary>
    /// Interface for business layer
    /// </summary>
    #region IQuantityMeasurementBL
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
    #endregion
}
#endregion