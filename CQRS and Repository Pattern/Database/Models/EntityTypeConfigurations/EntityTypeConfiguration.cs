using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_and_Repository_Pattern.Database.Model.EntityTypeConfigurations
{
    public abstract class EntityTypeConfiguration<TEntity> where TEntity : class
    {
        protected readonly EntityTypeBuilder<TEntity> builder;
        public EntityTypeConfiguration(ModelBuilder modelBuilder)
        {
            builder = modelBuilder.Entity<TEntity>();
        }
    }
}
