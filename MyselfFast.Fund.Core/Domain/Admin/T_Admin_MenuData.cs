//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
	/// <summary>
    /// [T_Admin_MenuData]
    /// </summary>
    public partial class T_Admin_MenuData:BaseEntity
    {
      
		/// <summary>
		/// [MenuID]
		/// </summary>
		  public int MenuID { get; set; }
		      
		/// <summary>
		/// [DataKey]
		/// </summary>
		  public string DataKey { get; set; }
		      
		/// <summary>
		/// [DataValue]
		/// </summary>
		  public string DataValue { get; set; }
		      
		/// <summary>
		/// [IsDefault]
		/// </summary>
		  public Nullable<bool> IsDefault { get; set; }
		      
      
      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public string CreateAdmin { get; set; }
		      
		/// <summary>
		/// [UpdateAdmin]
		/// </summary>
		  public string UpdateAdmin { get; set; }
		      
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
