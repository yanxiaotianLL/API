using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace myselfFast.Fund.Core.Domain.HuKouSettled
{
    [Serializable]
    public partial class T_Sys_IdCardInfo : BaseEntity
    {
        public int Id { get; set; }
        public int FesId { get; set; }
        public int Hno { get; set; }
        public string CradName { get; set; }
        public string CardId { get; set; }
        public string CardGender { get; set; }
        public string CardNation { get; set; }
        public string CardBirth { get; set; }
        public string Cardvalidate { get; set; }
        public string CardAuthority { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int Status { get; set; }
        public string CardAddress { get; set; }
        public decimal OcrLevel { get; set; }
        public string ElecMatSource { get; set; }
        public string CardNationValue { get; set; }
    }
}
