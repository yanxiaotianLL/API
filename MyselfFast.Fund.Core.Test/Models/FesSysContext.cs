using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using FescoFast.Collect.Core.Test.Models.Mapping;

namespace FescoFast.Collect.Core.Test.Models
{
    public partial class FesSysContext : DbContext
    {
        static FesSysContext()
        {
            Database.SetInitializer<FesSysContext>(null);
        }

        public FesSysContext()
            : base("Name=FesSysContext")
        {
        }

        public DbSet<ApiInputLog> ApiInputLogs { get; set; }
        public DbSet<ApiOutputLog> ApiOutputLogs { get; set; }
        public DbSet<D_JC_Address> D_JC_Address { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<T_Admin_Account> T_Admin_Account { get; set; }
        public DbSet<T_Admin_AcountRole> T_Admin_AcountRole { get; set; }
        public DbSet<T_Admin_Depart> T_Admin_Depart { get; set; }
        public DbSet<T_Admin_Menu> T_Admin_Menu { get; set; }
        public DbSet<T_Admin_MenuData> T_Admin_MenuData { get; set; }
        public DbSet<T_Admin_MenuData_RolePrivilege> T_Admin_MenuData_RolePrivilege { get; set; }
        public DbSet<T_Admin_Role> T_Admin_Role { get; set; }
        public DbSet<T_Admin_RoleData> T_Admin_RoleData { get; set; }
        public DbSet<T_Admin_RoleData_RolePrivilege> T_Admin_RoleData_RolePrivilege { get; set; }
        public DbSet<T_Admin_RolePrivilege> T_Admin_RolePrivilege { get; set; }
        public DbSet<T_Article> T_Article { get; set; }
        public DbSet<T_FundBussinessName> T_FundBussinessName { get; set; }
        public DbSet<T_JC_Account> T_JC_Account { get; set; }
        public DbSet<T_JC_DataItem> T_JC_DataItem { get; set; }
        public DbSet<T_JC_DataItemTemp> T_JC_DataItemTemp { get; set; }
        public DbSet<T_JC_File> T_JC_File { get; set; }
        public DbSet<T_JC_Task> T_JC_Task { get; set; }
        public DbSet<T_JC_TaskUnit> T_JC_TaskUnit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApiInputLogMap());
            modelBuilder.Configurations.Add(new ApiOutputLogMap());
            modelBuilder.Configurations.Add(new D_JC_AddressMap());
            modelBuilder.Configurations.Add(new LogMap());
            modelBuilder.Configurations.Add(new T_Admin_AccountMap());
            modelBuilder.Configurations.Add(new T_Admin_AcountRoleMap());
            modelBuilder.Configurations.Add(new T_Admin_DepartMap());
            modelBuilder.Configurations.Add(new T_Admin_MenuMap());
            modelBuilder.Configurations.Add(new T_Admin_MenuDataMap());
            modelBuilder.Configurations.Add(new T_Admin_MenuData_RolePrivilegeMap());
            modelBuilder.Configurations.Add(new T_Admin_RoleMap());
            modelBuilder.Configurations.Add(new T_Admin_RoleDataMap());
            modelBuilder.Configurations.Add(new T_Admin_RoleData_RolePrivilegeMap());
            modelBuilder.Configurations.Add(new T_Admin_RolePrivilegeMap());
            modelBuilder.Configurations.Add(new T_ArticleMap());
            modelBuilder.Configurations.Add(new T_FundBussinessNameMap());
            modelBuilder.Configurations.Add(new T_JC_AccountMap());
            modelBuilder.Configurations.Add(new T_JC_DataItemMap());
            modelBuilder.Configurations.Add(new T_JC_DataItemTempMap());
            modelBuilder.Configurations.Add(new T_JC_FileMap());
            modelBuilder.Configurations.Add(new T_JC_TaskMap());
            modelBuilder.Configurations.Add(new T_JC_TaskUnitMap());
        }
    }
}
