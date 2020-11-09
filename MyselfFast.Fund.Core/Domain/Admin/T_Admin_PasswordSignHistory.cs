


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
	/// <summary>
    /// [T_Admin_PasswordSignHistory]
    /// </summary>
    public partial class T_Admin_PasswordSignHistory:BaseEntity
    {
      
      
      
		/// <summary>
		/// [CreateAdmin]
		/// </summary>
		  public Nullable<System.DateTime> CreateAdmin { get; set; }
		      
		/// <summary>
		/// [Sign]
		/// </summary>
		  public string Sign { get; set; }
		      
		/// <summary>
		/// [Email]
		/// </summary>
		  public string Email { get; set; }
		      
		/// <summary>
		/// [UserName]
		/// </summary>
		  public string UserName { get; set; }
		      
		/// <summary>
		/// [Url]
		/// </summary>
		  public string Url { get; set; }

          public int AdminUserId { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
		      
    }
}
