//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
	/// <summary>
    /// [T_Admin_RoleData]
    /// </summary>
    public partial class T_Admin_RoleData:BaseEntity
    {
      
		/// <summary>
		/// [DataValue]
		/// </summary>
		  public string DataValue { get; set; }
		      
		/// <summary>
		/// [DataKey]
		/// </summary>
		  public string DataKey { get; set; }
		      
      
		/// <summary>
		/// [IsDefault]
		/// </summary>
		  public Nullable<int> IsDefault { get; set; }
		      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public string CreateAdmin { get; set; }
		      
		/// <summary>
		/// [Icon]
		/// </summary>
		  public string Icon { get; set; }
		      
		/// <summary>
		/// [SortValue]
		/// </summary>
		  public Nullable<int> SortValue { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
		      
    }
}
