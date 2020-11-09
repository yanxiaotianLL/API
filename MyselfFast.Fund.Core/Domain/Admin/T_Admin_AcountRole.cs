//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
    
	/// <summary>
    /// [T_Admin_AcountRole]
    /// </summary>
    public partial class T_Admin_AcountRole:BaseEntity
    {
      
		/// <summary>
		/// [RoleID]
		/// </summary>
		  public int RoleID { get; set; }
		      
		/// <summary>
		/// [AccountID]
		/// </summary>
		  public int AccountID { get; set; }
		      
      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public string CreateAdmin { get; set; }
		      
		/// <summary>
		/// [SortValue]
		/// </summary>
		  public string SortValue { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
    }
}
