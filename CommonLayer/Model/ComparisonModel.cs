/// ================================================
/// File    : ComparisonModel.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#region CommonLayer.Model
namespace CommonLayer.Model
{
    #region ComparisonModel
    public class ComparisonModel
    {
        /// <summary>
        /// constructor
        /// </summary>
        #region ComparisonModel
        public ComparisonModel()
        {
            ValueOne = 0;
            ValueOneUnit = null;
            ValueTwo = 0;
            ValueTwoUnit = null;
            Result = null;
        }
        #endregion

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal ValueOne { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string ValueOneUnit { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal ValueTwo { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string ValueTwoUnit { get; set; }

        public string Result { get; set; }
    }
    #endregion
}
#endregion