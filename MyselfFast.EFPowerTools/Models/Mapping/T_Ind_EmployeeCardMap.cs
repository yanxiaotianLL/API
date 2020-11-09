using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FescoFast.EFPowerTools.Models.Mapping
{
    public class T_Ind_EmployeeCardMap : EntityTypeConfiguration<T_Ind_EmployeeCard>
    {
        public T_Ind_EmployeeCardMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.RegistrationNum)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ResidenceAdd)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.AgencyAdd)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CradValidity)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Resume)
                .HasMaxLength(4000);

            this.Property(t => t.PhotoProveInfo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.IdCopyProveInfo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AgencyCopyProveInfo)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.EmpCardProveInfo)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Ind_EmployeeCard");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FesId).HasColumnName("FesId");
            this.Property(t => t.SubmitFileType).HasColumnName("SubmitFileType");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.DeliveryId).HasColumnName("DeliveryId");
            this.Property(t => t.IsMerge).HasColumnName("IsMerge");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.RegistrationNum).HasColumnName("RegistrationNum");
            this.Property(t => t.ResidenceAdd).HasColumnName("ResidenceAdd");
            this.Property(t => t.AgencyAdd).HasColumnName("AgencyAdd");
            this.Property(t => t.CradValidity).HasColumnName("CradValidity");
            this.Property(t => t.Resume).HasColumnName("Resume");
            this.Property(t => t.PhotoStatus).HasColumnName("PhotoStatus");
            this.Property(t => t.PhotoProveInfo).HasColumnName("PhotoProveInfo");
            this.Property(t => t.IdCopyStatus).HasColumnName("IdCopyStatus");
            this.Property(t => t.IdCopyProveInfo).HasColumnName("IdCopyProveInfo");
            this.Property(t => t.AgencyCopyStatus).HasColumnName("AgencyCopyStatus");
            this.Property(t => t.AgencyCopyProveInfo).HasColumnName("AgencyCopyProveInfo");
            this.Property(t => t.EmpCardStatus).HasColumnName("EmpCardStatus");
            this.Property(t => t.EmpCardProveInfo).HasColumnName("EmpCardProveInfo");
            this.Property(t => t.FormalityId).HasColumnName("FormalityId");
        }
    }
}
