using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Services.ModelExt
{
    public class PriceModel
    {
        /// <summary>
        /// 补贴金额
        /// </summary>
        public decimal? Price { get; set; }
    }
    /// <summary>
    /// 失业保险费返还Model
    /// </summary>
    public class ShiYeModel : PriceModel
    {
        /// <summary>
        /// 企业划型 0 大型企业 1 中小微企业
        /// </summary>
        public int? CompanyHX { get; set; }
        public string CompanyHXText { get; set; }
        /// <summary>
        /// 上年度12月失业保险参保人数
        /// </summary>
        public int? LastShiyeCount { get; set; }
        /// <summary>
        /// 上年度自然减员人数
        /// </summary>
        public int? LastReduceCount { get; set; }
        /// <summary>
        /// 上上年度12月失业保险参保人数
        /// </summary>
        public int? LlastShiyeCount { get; set; }
        /// <summary>
        /// 上年度缴纳失业险总金额
        /// </summary>
        public decimal? LastTotal { get; set; }
    }
    /// <summary>
    /// 新职工岗位适应性补贴Model
    /// </summary>
    public class NewStaff : PriceModel
    {
        /// <summary>
        /// 签署劳动合同一年以上且连续缴纳社会保险3个月以上的人数
        /// </summary>
        public int? PeopleCount { get; set; }
        /// <summary>
        /// 完成培训40小时人数
        /// </summary>
        public int? FinishCount { get; set; }
    }
    /// <summary>
    /// 3、岗补社补 Model
    /// </summary>
    public class StationModel : PriceModel
    {
        /// <summary>
        /// 招录类型
        /// </summary>
        public string ZhaoLuType { get; set; }
        /// <summary>
        /// 招录人数
        /// </summary>
        public int? ZhaoluCount { get; set; }
        /// <summary>
        /// 招录京籍毕业生平均工资
        /// </summary>
        public decimal? AvgPrice { get; set; }
        /// <summary>
        /// 工资标准是否不低于本市最低工资的1.2倍
        /// </summary>
        public bool? IsStandard { get; set; }
        /// <summary>
        /// 缴纳社会保险月数（只能填写6及6的倍数，不得超过18）
        /// </summary>
        public int? MonthCount { get; set; }

    }
    /// <summary>
    /// 4、见习补贴
    /// </summary>
    public class PracticeModel : PriceModel
    {
        /// <summary>
        /// 招录见习人员数量
        /// </summary>
        public int? PeopleCount { get; set; }
        /// <summary>
        /// 聘用月数
        /// </summary>
        public int? MountCount { get; set; }
    }
    /// <summary>
    /// 困难企业失业保险费返还
    /// </summary>
    public class difficultModel : PriceModel
    {
        /// <summary>
        /// 2019年12月失业保险参保人数
        /// </summary>
        public int? LastShiyeCount { get; set; }
        /// <summary>
        /// 2019年自然减员人数
        /// </summary>
        public int? LastReduceCount { get; set; }
        /// <summary>
        /// 2018年12月失业保险参保人数
        /// </summary>
        public int? LlastShiyeCount { get; set; }
        /// <summary>
        /// 2019年度月均参加失业保险人数
        /// </summary>
        public int? LastMouthShiyeCount { get; set; }
        /// <summary>
        /// 企业划型 0 大型企业 1 中小微企业
        /// </summary>
        public int? CompanyHX { get; set; }
        public string CompanyHXText { get; set; }
    }
    /// <summary>
    /// 6、一次性社会保险补贴
    /// </summary>
    public class OneModel : PriceModel
    {
        /// <summary>
        /// 2020年1-4月月均缴纳失业保险人数
        /// </summary>
        public int? NowShiyePeople { get; set; }
        /// <summary>
        /// 2019年月均缴纳失业保险人数
        /// </summary>
        public int? LastShiyePeople { get; set; }
        /// <summary>
        /// 2020年2-4月缴纳社会保险费用
        /// </summary>
        public int? NowShiyeBaoXianAmount { get; set; }
    }
    /// <summary>
    /// 7、支持开展职业技能培训
    /// </summary>
    public class OccupationSkillModel : PriceModel
    {
        /// <summary>
        /// 签署劳动合同一年以上参与2020年培训且符合40小时人数
        /// </summary>
        public int? PeopleCount { get; set; }
    }
    /// <summary>
    /// 8、以训稳岗补贴
    /// </summary>
    public class TrainKeepJobModel : PriceModel
    {
        /// <summary>
        /// 2020年5月6日-7月31日组织参加培训职工人数
        /// </summary>
        public int? PeopleCount { get; set; }
        /// <summary>
        /// 培训课时（课时只能填写20或40或60或80或100或120）
        /// </summary>
        public int? TrainHours { get; set; }
        /// <summary>
        /// 企业划型 0 大型企业 1 中小微企业
        /// </summary>
        public int? CompanyHX { get; set; }
        public string CompanyHXText { get; set; }
    }
    /// <summary>
    /// 9、临时性岗位补贴
    /// </summary>
    public class TemporaryJobModel : PriceModel
    {
        /// <summary>
        /// 2020年5月6日-7月31日组织参加培训职工人数
        /// </summary>
        public int? PeopleCount { get; set; }
        /// <summary>
        /// 企业划型 0 大型企业 1 中小微企业
        /// </summary>
        public int? CompanyHX { get; set; }
        public string CompanyHXText { get; set; }
    }
    /// <summary>
    /// 10、以工代训扩岗补贴
    /// </summary>
    public class YGDXKGModel : PriceModel
    {
        /// <summary>
        /// 企业划型 0 大型企业 1 中小微企业
        /// </summary>
        public int? CompanyHX { get; set; }
        public string CompanyHXText { get; set; }
        /// <summary>
        /// 招录本市失业登记人员、城乡就业困难人员或本市毕业年度高校毕业生人数
        /// </summary>
        public int? PeopleCount { get; set; }
        /// <summary>
        /// 招录人员就业月份数
        /// </summary>
        public int? MonthCount { get; set; }
    }

    /// <summary>
    /// 11、以工代训稳岗补贴
    /// </summary>
    public class YGDXWGModel : PriceModel
    {
        /// <summary>
        /// 企业划型 0 大型企业 1 中小微企业
        /// </summary>
        public int? CompanyHX { get; set; }
        public string CompanyHXText { get; set; }
        /// <summary>
        /// 参保职工人数
        /// </summary>
        public int? PeopleCount { get; set; }
        /// <summary>
        /// 职工以工代训月份数
        /// </summary>
        public int? MonthCount { get; set; }
    }

    /// <summary>
    /// 12、高精尖产业技能提升培训补贴
    /// </summary>
    public class HIndusSkillTraModel : PriceModel
    {
        /// <summary>
        /// 企业规模code
        /// </summary>
        public int? CompanyScaleCode { get; set; }
        /// <summary>
        /// 企业规模名称
        /// </summary>
        public string CompanyScaleName { get; set; }
        ///具备资质条件code
        public int? QualificationsCode { get; set; }
        /// <summary>
        /// 具备资质条件名称
        /// </summary>
        public string QualificationsName { get; set; }

        /// <summary>
        /// 参保培训人数
        /// </summary>
        public int? PeopleCount { get; set; }
        /// <summary>
        /// 培训总费用金额
        /// </summary>
        public decimal? TrainingTotalAmount { get; set; }

    }
}
