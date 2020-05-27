/// ================================================
/// File    : ConversionOptions.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
#region CommonLayer.Model
namespace CommonLayer.Model
{
    /// <summary>
    /// enumeration for conversion options
    /// </summary>
    #region ConversionOptions
    public enum ConversionOptions 
    {
        // Enum For Length Conversion Operations. 
        InchToFeet = 1, FeetToInch,
        InchToYard, YardToInch, 
        FeetToYard, YardToFeet,  

        // Enum For Weight Conversion Operations.
        GramToKg, KgToGram,
        KgToTonne, TonneToKg,
        GramToTonne, TonneToGram,

        // Enum For Volume Conversion Operations.
        LitreToMl, MlToLitre,

        // Enum For Temperature Conversion Operations.
        CToF, FToC
    }
    #endregion
}
#endregion