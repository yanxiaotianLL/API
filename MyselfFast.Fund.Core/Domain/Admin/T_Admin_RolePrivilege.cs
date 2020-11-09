//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
	/// <summary>
    /// [T_Admin_RolePrivilege]
    /// </summary>
    public partial class T_Admin_RolePrivilege:BaseEntity
    {
      
		/// <summary>
		/// [RoleID]
		/// </summary>
		  public int RoleID { get; set; }
		      
		/// <summary>
		/// [MenuID]
		/// </summary>
		  public int MenuID { get; set; }
		      
      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public string CreateAdmin { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
		      
    }
}
