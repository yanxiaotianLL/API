//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
	/// <summary>
    /// [T_Admin_Menu]
    /// </summary>
    public partial class T_Admin_Menu:BaseEntity
    {
      
		/// <summary>
		/// [MenuName]
		/// </summary>
		  public string MenuName { get; set; }
		      
		/// <summary>
		/// [MenuDescription]
		/// </summary>
		  public string MenuDescription { get; set; }
		      
		/// <summary>
		/// [Url]
		/// </summary>
		  public string Url { get; set; }
		      
		/// <summary>
		/// [ParentID]
		/// </summary>
		  public Nullable<int> ParentID { get; set; }
		      
		/// <summary>
		/// [SortValue]
		/// </summary>
		  public Nullable<int> SortValue { get; set; }
		      
      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public string CreateAdmin { get; set; }
		      
		/// <summary>
		/// [UpdateAdmin]
		/// </summary>
		  public string UpdateAdmin { get; set; }
		      
      
		/// <summary>
		/// [IsDefault]
		/// </summary>
		  public Nullable<int> IsDefault { get; set; }
		      
		/// <summary>
		/// [Icon]
		/// </summary>
		  public string Icon { get; set; }
		      
		/// <summary>
		/// [MenuCode]
		/// </summary>
		  public string MenuCode { get; set; }
		      
		/// <summary>
		/// [IsLeaf]
		/// </summary>
		  public bool IsLeaf { get; set; }
		      
		/// <summary>
		/// [ControllerName]
		/// </summary>
		  public string ControllerName { get; set; }
		      
		/// <summary>
		/// [ActionName]
		/// </summary>
		  public string ActionName { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
		      
    }
}
