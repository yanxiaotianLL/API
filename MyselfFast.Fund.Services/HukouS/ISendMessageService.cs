using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Domain.Hukou;
using myselfFast.Fund.Services.DTO.Request.Hukou;
using myselfFast.Fund.Services.DTO.Response.Hukou;
using myselfFast.Fund.Core.Domain.ExportImport;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Component.Logging;
using myselfFast.Component.MsgMobile;

namespace myselfFast.Fund.Services.HukouS
{
    public interface ISendMessageService : IBaseService<V_HK_Order_List>
    {
        string SendMessage(string tId);
        string SendMessageQianchu(string tId);
    }
}
