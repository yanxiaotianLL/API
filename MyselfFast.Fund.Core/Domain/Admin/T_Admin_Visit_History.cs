


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.Admin
{
    [Serializable]
	/// <summary>
    /// [T_Admin_Visit_History]
    /// </summary>
    public partial class T_Admin_Visit_History:BaseEntity
    {
      
		/// <summary>
		/// [Ip]
		/// </summary>
		  public string Ip { get; set; }
		      
      
      
      
		/// <summary>
		/// [RawUrl]
		/// </summary>
		  public string RawUrl { get; set; }
		      
		/// <summary>
		/// [UrlReferrer]
		/// </summary>
		  public string UrlReferrer { get; set; }
		      
		/// <summary>
		/// [UserAgent]
		/// </summary>
		  public string UserAgent { get; set; }
		      
		/// <summary>
		/// [UserName]
		/// </summary>
		  public string UserName { get; set; }
		      
		/// <summary>
		/// [UserId]
		/// </summary>
		  public Nullable<int> UserId { get; set; }
          public string Controller { get; set; }
          public string Action { get; set; }
          public bool IsDelete { get; set; }
          public DateTime CreateTime { get; set; }
		      
    }
}
