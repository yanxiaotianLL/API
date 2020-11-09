


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace FescoFast.Fund.Core.Domain.Admin
{
    
	/// <summary>
    /// [T_Helo_Menu_Ext]
    /// </summary>
    public partial class T_Helo_Menu_Ext:BaseEntity
    {
      
		/// <summary>
		/// [ParentBy]
		/// </summary>
		  public string ParentBy { get; set; }
		      
		/// <summary>
		/// [OrderBy]
		/// </summary>
		  public string OrderBy { get; set; }
		      
		/// <summary>
		/// [MenuText]
		/// </summary>
		  public string MenuText { get; set; }
		      
		/// <summary>
		/// [Url]
		/// </summary>
		  public string Url { get; set; }
		      
		/// <summary>
		/// [Oldurl]
		/// </summary>
		  public string Oldurl { get; set; }
		      
		/// <summary>
		/// [Menutype]
		/// </summary>
		  public int Menutype { get; set; }
		      
    }
}
