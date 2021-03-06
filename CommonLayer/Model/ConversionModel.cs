﻿/// ================================================
/// File    : ConversionModel.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

#region CommonLayer.Model
namespace CommonLayer.Model
{
    /// <summary>
    /// Model Class For Quantity.
    /// </summary>
    #region ConversionModel
    public class ConversionModel
    {
        /// <summary>
        /// constructor
        /// </summary>
        #region ConversionModel
        public ConversionModel()
        {
            Id = 0;
            Value = 0;
            OperationType = null;
            Result = 0;
        }
        #endregion

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="decimal(18,2)")]
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Value { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string OperationType { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public decimal Result { get; set; }
    }
    #endregion
}
#endregion
