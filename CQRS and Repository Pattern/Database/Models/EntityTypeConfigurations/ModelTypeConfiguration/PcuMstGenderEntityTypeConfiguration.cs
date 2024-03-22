using CQRS_and_Repository_Pattern.Database.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_and_Repository_Pattern.Database.Model.EntityTypeConfigurations.ModelTypeConfiguration
{
    public class PcuMstGenderEntityTypeConfiguration : EntityTypeConfiguration<PcuMstGender>
    {
        public PcuMstGenderEntityTypeConfiguration(ModelBuilder modelBuilder)
            : base(modelBuilder)
        {
            builder.HasKey(t => new { t.GEND_ID, t.GEND_CODE });
            builder.ToTable("pcu_mst_gender");
        }
    }
}
