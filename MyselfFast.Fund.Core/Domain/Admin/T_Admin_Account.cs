//



using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
	/// <summary>
    /// [T_Admin_Account]
    /// </summary>
    public partial class T_Admin_Account:BaseEntity
    {
      
		/// <summary>
		/// [DepartID]
		/// </summary>
		  public int DepartID { get; set; }
		      
		/// <summary>
		/// [UserName]
		/// </summary>
		  public string UserName { get; set; }
		      
		/// <summary>
		/// [RealName]
		/// </summary>
		  public string RealName { get; set; }
		      
		/// <summary>
		/// [Password]
		/// </summary>
		  public string Password { get; set; }
		      
		/// <summary>
		/// [Email]
		/// </summary>
		  public string Email { get; set; }
		      
		/// <summary>
		/// [Telephone]
		/// </summary>
		  public string Telephone { get; set; }
		      
		/// <summary>
		/// [DepartName]
		/// </summary>
		  public string DepartName { get; set; }
		      
      
      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public string CreateAdmin { get; set; }
		      
		/// <summary>
		/// [UpdateAdmin]
		/// </summary>
		  public string UpdateAdmin { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
		      
    }
}
