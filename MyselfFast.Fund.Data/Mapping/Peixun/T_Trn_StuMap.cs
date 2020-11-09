//
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using myselfFast.Fund.Core.Domain.Peixun;

namespace myselfFast.Fund.Data.Mapping.Peixun
{
    public class T_Trn_StuMap : myselfFastEntityTypeConfiguration<T_Trn_Stu>
    {
        public T_Trn_StuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PersonName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PersonId)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LabelIds)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Trn_Stu");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.PersonName).HasColumnName("PersonName");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.CardType).HasColumnName("CardType");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.ActiveTime).HasColumnName("ActiveTime");
            this.Property(t => t.LabelIds).HasColumnName("LabelIds");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EditUserId).HasColumnName("EditUserId");
            this.Property(t => t.EditTime).HasColumnName("EditTime");
        }
    }
}
