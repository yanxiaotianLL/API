


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace FescoFast.Fund.Core.Domain.Admin
{
    
	/// <summary>
    /// [T_Helo_MsgLog]
    /// </summary>
    public partial class T_Helo_MsgLog:BaseEntity
    {
      
		/// <summary>
		/// [MobileNo]
		/// </summary>
		  public string MobileNo { get; set; }
		      
		/// <summary>
		/// [Sendtime]
		/// </summary>
		  public System.DateTime Sendtime { get; set; }
		      
		/// <summary>
		/// [TrySendtime]
		/// </summary>
		  public System.DateTime TrySendtime { get; set; }
		      
		/// <summary>
		/// [TryTimes]
		/// </summary>
		  public int TryTimes { get; set; }
		      
		/// <summary>
		/// [Status]
		/// </summary>
		  public int Status { get; set; }
		      
		/// <summary>
		/// [isNeedTry]
		/// </summary>
		  public int isNeedTry { get; set; }
		      
		/// <summary>
		/// [MsgContent]
		/// </summary>
		  public string MsgContent { get; set; }
		      
		/// <summary>
		/// [errorContent]
		/// </summary>
		  public string errorContent { get; set; }
		      
		/// <summary>
		/// [IsDel]
		/// </summary>
		  public int IsDel { get; set; }
		      
		/// <summary>
		/// [ElectType]
		/// </summary>
		  public string ElectType { get; set; }
		      
		/// <summary>
		/// [ElectSource]
		/// </summary>
		  public string ElectSource { get; set; }
		      
		/// <summary>
		/// [IsNowSend]
		/// </summary>
		  public int IsNowSend { get; set; }
		      
      
    }
}
