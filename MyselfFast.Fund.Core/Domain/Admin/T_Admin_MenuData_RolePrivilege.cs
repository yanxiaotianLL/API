//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
	/// <summary>
    /// [T_Admin_MenuData_RolePrivilege]
    /// </summary>
    public partial class T_Admin_MenuData_RolePrivilege:BaseEntity
    {
		/// <summary>
		/// [RolePrivilegeID]
		/// </summary>
		  public int RolePrivilegeID { get; set; }
		      
		/// <summary>
		/// [MenuDataID]
		/// </summary>
		  public int MenuDataID { get; set; }
		      
      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public string CreateAdmin { get; set; }
		      
		/// <summary>
		/// [SortValue]
		/// </summary>
		  public Nullable<int> SortValue { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
      
    }
}
