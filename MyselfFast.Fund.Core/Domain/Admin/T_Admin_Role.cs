//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
	/// <summary>
    /// [T_Admin_Role]
    /// </summary>
    public partial class T_Admin_Role:BaseEntity
    {
      
		/// <summary>
		/// [RoleName]
		/// </summary>
		  public string RoleName { get; set; }
		      
		/// <summary>
		/// [RoleDescription]
		/// </summary>
		  public string RoleDescription { get; set; }
		      
      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public string CreateAdmin { get; set; }
		      
		/// <summary>
		/// [UpdateAdmin]
		/// </summary>
		  public string UpdateAdmin { get; set; }
		      
      
		/// <summary>
		/// [SortValue]
		/// </summary>
		  public Nullable<int> SortValue { get; set; }
		      
		/// <summary>
		/// [RoleCode]
		/// </summary>
		  public string RoleCode { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
		      
    }
}
