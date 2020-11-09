


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace FescoFast.Fund.Core.Domain.Admin
{
    
	/// <summary>
    /// [T_Helo_Img]
    /// </summary>
    public partial class T_Helo_Img:BaseEntity
    {
      
		/// <summary>
		/// [ImgUrl]
		/// </summary>
		  public string ImgUrl { get; set; }
		      
		/// <summary>
		/// [ImgTitle]
		/// </summary>
		  public string ImgTitle { get; set; }
		      
		/// <summary>
		/// [ImgState]
		/// </summary>
		  public int ImgState { get; set; }
		      
		/// <summary>
		/// [ToUrl]
		/// </summary>
		  public string ToUrl { get; set; }
		      
		/// <summary>
		/// [ImgIndex]
		/// </summary>
		  public int ImgIndex { get; set; }
		      
		/// <summary>
		/// [ImgPlace]
		/// </summary>
		  public int ImgPlace { get; set; }
		      
		/// <summary>
		/// [ImgBackColor]
		/// </summary>
		  public string ImgBackColor { get; set; }
		      
		/// <summary>
		/// [BeginTime]
		/// </summary>
		  public System.DateTime BeginTime { get; set; }
		      
		/// <summary>
		/// [EndTime]
		/// </summary>
		  public System.DateTime EndTime { get; set; }
		      
      
		/// <summary>
		/// [CreateUser]
		/// </summary>
		  public string CreateUser { get; set; }
		      
      
		/// <summary>
		/// [UpdateUser]
		/// </summary>
		  public string UpdateUser { get; set; }
		      
    }
}
