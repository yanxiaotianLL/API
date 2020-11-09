//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
	/// <summary>
    /// [T_Admin_RoleData_RolePrivilege]
    /// </summary>
    public partial class T_Admin_RoleData_RolePrivilege:BaseEntity
    {
      
		/// <summary>
		/// [RoleID]
		/// </summary>
		  public Nullable<int> RoleID { get; set; }
		      
		/// <summary>
		/// [RoleDataID]
		/// </summary>
		  public Nullable<int> RoleDataID { get; set; }
		      
      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public string CreateAdmin { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
		      
    }
}
