//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
    
	/// <summary>
    /// [T_Admin_Depart]
    /// </summary>
    public partial class T_Admin_Depart:BaseEntity
    {
      
		/// <summary>
		/// [DepartName]
		/// </summary>
		  public string DepartName { get; set; }
		      
		/// <summary>
		/// [DepartDescription]
		/// </summary>
		  public string DepartDescription { get; set; }
		      
		/// <summary>
		/// [ParentID]
		/// </summary>
		  public Nullable<int> ParentID { get; set; }
		      
      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public string CreateAdmin { get; set; }
		      
		/// <summary>
		/// [UpdateAdmin]
		/// </summary>
		  public string UpdateAdmin { get; set; }
		      
      
		/// <summary>
		/// [DepartLeader]
		/// </summary>
		  public string DepartLeader { get; set; }
		      
		/// <summary>
		/// [LeaderEmail]
		/// </summary>
		  public string LeaderEmail { get; set; }
		      
		/// <summary>
		/// [SortValue]
		/// </summary>
		  public Nullable<int> SortValue { get; set; }
		      
		/// <summary>
		/// [DepartCode]
		/// </summary>
		  public string DepartCode { get; set; }
		      
		/// <summary>
		/// [IsLeaf]
		/// </summary>
		  public Nullable<bool> IsLeaf { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
		      
    }
}
