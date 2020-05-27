/// ================================================
/// File    : QuantityDBContext.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
using CommonLayer.Model;
using Microsoft.EntityFrameworkCore;

#region RepositoryLayer
namespace RepositoryLayer
{
    #region QuantityDBContext
    public class QuantityDBContext : DbContext
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="options"></param>
        #region QuantityDBContext
        public QuantityDBContext(DbContextOptions<QuantityDBContext> options) : base(options)
        { 
        
        }
        #endregion

        public DbSet<ConversionModel> Conversions { get; set; }

        public DbSet<ComparisonModel> Comparisons { get; set; }
    }
    #endregion
}
#endregion