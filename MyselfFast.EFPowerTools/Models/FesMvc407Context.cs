using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using FescoFast.EFPowerTools.Models.Mapping;

namespace FescoFast.EFPowerTools.Models
{
    public partial class FesMvc407Context : DbContext
    {
        static FesMvc407Context()
        {
            Database.SetInitializer<FesMvc407Context>(null);
        }

        public FesMvc407Context()
            : base("Name=FesMvc407Context")
        {
        }

        public DbSet<C_561_FEN_ERROR> C_561_FEN_ERROR { get; set; }
        public DbSet<C_T_ALL> C_T_ALL { get; set; }
        public DbSet<C_T_HAS> C_T_HAS { get; set; }
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<Hm_Diaocha> Hm_Diaocha { get; set; }
        public DbSet<Hm_Guanggaohits> Hm_Guanggaohits { get; set; }
        public DbSet<Hm_Hlrvistst> Hm_Hlrvistst { get; set; }
        public DbSet<Hm_Hotlinks> Hm_Hotlinks { get; set; }
        public DbSet<Hm_Jibie> Hm_Jibie { get; set; }
        public DbSet<Hm_Mails> Hm_Mails { get; set; }
        public DbSet<Hm_Mails_Yg_Re> Hm_Mails_Yg_Re { get; set; }
        public DbSet<Hm_mailsender> Hm_mailsender { get; set; }
        public DbSet<Hm_Points> Hm_Points { get; set; }
        public DbSet<Hm_Sql_Log> Hm_Sql_Log { get; set; }
        public DbSet<Hm_Visit> Hm_Visit { get; set; }
        public DbSet<Hm_Wxtempcodeuser> Hm_Wxtempcodeuser { get; set; }
        public DbSet<Hth_S_Blacklist> Hth_S_Blacklist { get; set; }
        public DbSet<Hth_S_Disease> Hth_S_Disease { get; set; }
        public DbSet<Hth_S_Log> Hth_S_Log { get; set; }
        public DbSet<Hth_S_Pack> Hth_S_Pack { get; set; }
        public DbSet<Hth_S_SetAudit> Hth_S_SetAudit { get; set; }
        public DbSet<Hth_T_Actual> Hth_T_Actual { get; set; }
        public DbSet<Hth_T_Audit> Hth_T_Audit { get; set; }
        public DbSet<Hth_T_Audit_Order> Hth_T_Audit_Order { get; set; }
        public DbSet<Hth_T_CommonHospital> Hth_T_CommonHospital { get; set; }
        public DbSet<Hth_T_Cost> Hth_T_Cost { get; set; }
        public DbSet<Hth_T_CostImgSort> Hth_T_CostImgSort { get; set; }
        public DbSet<Hth_T_Deduct> Hth_T_Deduct { get; set; }
        public DbSet<Hth_T_DeductType> Hth_T_DeductType { get; set; }
        public DbSet<Hth_T_Drug> Hth_T_Drug { get; set; }
        public DbSet<Hth_T_FinancialStatistics> Hth_T_FinancialStatistics { get; set; }
        public DbSet<Hth_T_GloablSettings> Hth_T_GloablSettings { get; set; }
        public DbSet<Hth_T_Hospital> Hth_T_Hospital { get; set; }
        public DbSet<Hth_T_Hospital_New> Hth_T_Hospital_New { get; set; }
        public DbSet<Hth_T_ImgAttr> Hth_T_ImgAttr { get; set; }
        public DbSet<Hth_T_ImgAttrText> Hth_T_ImgAttrText { get; set; }
        public DbSet<Hth_T_ImgSort> Hth_T_ImgSort { get; set; }
        public DbSet<Hth_T_IsLookIndex> Hth_T_IsLookIndex { get; set; }
        public DbSet<Hth_T_Jurisdiction> Hth_T_Jurisdiction { get; set; }
        public DbSet<Hth_T_ModifyRecord> Hth_T_ModifyRecord { get; set; }
        public DbSet<Hth_T_OcrReason> Hth_T_OcrReason { get; set; }
        public DbSet<Hth_T_Order> Hth_T_Order { get; set; }
        public DbSet<Hth_T_OrderData> Hth_T_OrderData { get; set; }
        public DbSet<Hth_T_OrderImg> Hth_T_OrderImg { get; set; }
        public DbSet<Hth_T_OrderWrap> Hth_T_OrderWrap { get; set; }
        public DbSet<Hth_T_OrderWrapItem> Hth_T_OrderWrapItem { get; set; }
        public DbSet<Hth_T_PosDrug> Hth_T_PosDrug { get; set; }
        public DbSet<Hth_T_Position> Hth_T_Position { get; set; }
        public DbSet<Hth_T_Position_New> Hth_T_Position_New { get; set; }
        public DbSet<Hth_T_Section> Hth_T_Section { get; set; }
        public DbSet<Hth_T_SerAuditText> Hth_T_SerAuditText { get; set; }
        public DbSet<Hth_T_TempHistoryOrder> Hth_T_TempHistoryOrder { get; set; }
        public DbSet<Menutemp> Menutemps { get; set; }
        public DbSet<Newprice> Newprices { get; set; }
        public DbSet<Renzhengdata> Renzhengdatas { get; set; }
        public DbSet<ROLE_BAK> ROLE_BAK { get; set; }
        public DbSet<Sys_Flrole> Sys_Flrole { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<T_Act_Abdate> T_Act_Abdate { get; set; }
        public DbSet<T_Act_Active> T_Act_Active { get; set; }
        public DbSet<T_Act_Appointlimittime> T_Act_Appointlimittime { get; set; }
        public DbSet<T_Act_Appointment> T_Act_Appointment { get; set; }
        public DbSet<T_Act_Appointmententeranswer> T_Act_Appointmententeranswer { get; set; }
        public DbSet<T_Act_AppointmentFitnesscard> T_Act_AppointmentFitnesscard { get; set; }
        public DbSet<T_Act_Appointmentlimit> T_Act_Appointmentlimit { get; set; }
        public DbSet<T_Act_AppointmentProject> T_Act_AppointmentProject { get; set; }
        public DbSet<T_Act_Appointteday> T_Act_Appointteday { get; set; }
        public DbSet<T_Act_Productbuy> T_Act_Productbuy { get; set; }
        public DbSet<T_Act_Productordertemp> T_Act_Productordertemp { get; set; }
        public DbSet<T_Act_Reginput> T_Act_Reginput { get; set; }
        public DbSet<T_Act_Reginput_Extend> T_Act_Reginput_Extend { get; set; }
        public DbSet<T_Act_Registration> T_Act_Registration { get; set; }
        public DbSet<T_Admin_Account> T_Admin_Account { get; set; }
        public DbSet<T_Admin_AcountRole> T_Admin_AcountRole { get; set; }
        public DbSet<T_Admin_Depart> T_Admin_Depart { get; set; }
        public DbSet<T_Admin_Menu> T_Admin_Menu { get; set; }
        public DbSet<T_Admin_MenuData> T_Admin_MenuData { get; set; }
        public DbSet<T_Admin_MenuData_RolePrivilege> T_Admin_MenuData_RolePrivilege { get; set; }
        public DbSet<T_Admin_Role> T_Admin_Role { get; set; }
        public DbSet<T_Admin_RoleData> T_Admin_RoleData { get; set; }
        public DbSet<T_Admin_RoleData_RolePrivilege> T_Admin_RoleData_RolePrivilege { get; set; }
        public DbSet<T_Admin_RolePrivilege> T_Admin_RolePrivilege { get; set; }
        public DbSet<T_Art_Article> T_Art_Article { get; set; }
        public DbSet<T_Art_Col> T_Art_Col { get; set; }
        public DbSet<T_Art_Pinglun> T_Art_Pinglun { get; set; }
        public DbSet<T_Art_Pinglun_Back> T_Art_Pinglun_Back { get; set; }
        public DbSet<T_Art_Type> T_Art_Type { get; set; }
        public DbSet<T_Backword> T_Backword { get; set; }
        public DbSet<T_Bas_Dayset> T_Bas_Dayset { get; set; }
        public DbSet<T_Ben_FlexSelect> T_Ben_FlexSelect { get; set; }
        public DbSet<T_Ben_MyfamilyInfoOrder> T_Ben_MyfamilyInfoOrder { get; set; }
        public DbSet<T_Ben_MyfamilyInformation> T_Ben_MyfamilyInformation { get; set; }
        public DbSet<T_Ben_Plan_Extend> T_Ben_Plan_Extend { get; set; }
        public DbSet<T_Benefit_Leave> T_Benefit_Leave { get; set; }
        public DbSet<T_Budbeijing> T_Budbeijing { get; set; }
        public DbSet<T_Budbeijing2> T_Budbeijing2 { get; set; }
        public DbSet<T_Budshanghai> T_Budshanghai { get; set; }
        public DbSet<T_Budtianjin> T_Budtianjin { get; set; }
        public DbSet<T_Building> T_Building { get; set; }
        public DbSet<T_Canmakename> T_Canmakename { get; set; }
        public DbSet<T_Clb_Clubs> T_Clb_Clubs { get; set; }
        public DbSet<T_Clb_Members> T_Clb_Members { get; set; }
        public DbSet<T_Code_Hospital> T_Code_Hospital { get; set; }
        public DbSet<T_Code_ProvCity> T_Code_ProvCity { get; set; }
        public DbSet<T_Code_ProvCity_Jd> T_Code_ProvCity_Jd { get; set; }
        public DbSet<T_Complaints> T_Complaints { get; set; }
        public DbSet<T_Email> T_Email { get; set; }
        public DbSet<T_Email_Birthday> T_Email_Birthday { get; set; }
        public DbSet<T_Email_ins> T_Email_ins { get; set; }
        public DbSet<T_Email_ins_tail> T_Email_ins_tail { get; set; }
        public DbSet<T_Email_Send> T_Email_Send { get; set; }
        public DbSet<T_Exam_User_Import> T_Exam_User_Import { get; set; }
        public DbSet<T_Exam_User_Import_His> T_Exam_User_Import_His { get; set; }
        public DbSet<T_ExImportFiles> T_ExImportFiles { get; set; }
        public DbSet<T_Exm_AssessmentResult> T_Exm_AssessmentResult { get; set; }
        public DbSet<T_Exm_Card> T_Exm_Card { get; set; }
        public DbSet<T_Exm_Fls> T_Exm_Fls { get; set; }
        public DbSet<T_Exm_Fls_User> T_Exm_Fls_User { get; set; }
        public DbSet<T_Exm_Grade> T_Exm_Grade { get; set; }
        public DbSet<T_Exm_Item> T_Exm_Item { get; set; }
        public DbSet<T_Exm_Jigou> T_Exm_Jigou { get; set; }
        public DbSet<T_Exm_Jigou_test> T_Exm_Jigou_test { get; set; }
        public DbSet<T_Exm_Msg> T_Exm_Msg { get; set; }
        public DbSet<T_Exm_Ord_Dept> T_Exm_Ord_Dept { get; set; }
        public DbSet<T_Exm_Order> T_Exm_Order { get; set; }
        public DbSet<T_Exm_Order_Bak> T_Exm_Order_Bak { get; set; }
        public DbSet<T_Exm_OrderDetail> T_Exm_OrderDetail { get; set; }
        public DbSet<T_Exm_Package> T_Exm_Package { get; set; }
        public DbSet<T_Exm_PackageBag> T_Exm_PackageBag { get; set; }
        public DbSet<T_Exm_Packagetemp> T_Exm_Packagetemp { get; set; }
        public DbSet<T_Exm_Pjigou> T_Exm_Pjigou { get; set; }
        public DbSet<T_Exm_Pkg_Config> T_Exm_Pkg_Config { get; set; }
        public DbSet<T_Exm_Pkg_Item> T_Exm_Pkg_Item { get; set; }
        public DbSet<T_Exm_Pro_Fls> T_Exm_Pro_Fls { get; set; }
        public DbSet<T_Exm_Project> T_Exm_Project { get; set; }
        public DbSet<T_Exm_Project_Users> T_Exm_Project_Users { get; set; }
        public DbSet<T_Exm_ProjectDictionary> T_Exm_ProjectDictionary { get; set; }
        public DbSet<T_Exm_Prom> T_Exm_Prom { get; set; }
        public DbSet<T_Exm_Report> T_Exm_Report { get; set; }
        public DbSet<T_Exm_Report_Dic> T_Exm_Report_Dic { get; set; }
        public DbSet<T_Exm_Report_Item> T_Exm_Report_Item { get; set; }
        public DbSet<T_Exm_Teday> T_Exm_Teday { get; set; }
        public DbSet<T_Exm_Tuan> T_Exm_Tuan { get; set; }
        public DbSet<T_Exm_Tuan_Ins> T_Exm_Tuan_Ins { get; set; }
        public DbSet<T_Exm_User> T_Exm_User { get; set; }
        public DbSet<T_Exm_User_Ext> T_Exm_User_Ext { get; set; }
        public DbSet<T_Exm_User201608021703> T_Exm_User201608021703 { get; set; }
        public DbSet<T_Exm_words> T_Exm_words { get; set; }
        public DbSet<T_Exm_words_fesnewtest> T_Exm_words_fesnewtest { get; set; }
        public DbSet<T_ExportFiles> T_ExportFiles { get; set; }
        public DbSet<T_ExportGys> T_ExportGys { get; set; }
        public DbSet<T_Fes_Addr> T_Fes_Addr { get; set; }
        public DbSet<T_Fes_Admin_Manager> T_Fes_Admin_Manager { get; set; }
        public DbSet<T_Fes_Admin_Menu> T_Fes_Admin_Menu { get; set; }
        public DbSet<T_Fes_Admin_Oper_Note> T_Fes_Admin_Oper_Note { get; set; }
        public DbSet<T_Fes_Admin_Part> T_Fes_Admin_Part { get; set; }
        public DbSet<T_Fes_Admin_Role> T_Fes_Admin_Role { get; set; }
        public DbSet<T_Fes_Admin_Role_Tail> T_Fes_Admin_Role_Tail { get; set; }
        public DbSet<T_Fes_Audit> T_Fes_Audit { get; set; }
        public DbSet<T_Fes_BenefitsProductFileInfo> T_Fes_BenefitsProductFileInfo { get; set; }
        public DbSet<T_Fes_BenefitsProductInfo> T_Fes_BenefitsProductInfo { get; set; }
        public DbSet<T_Fes_Business_Fls> T_Fes_Business_Fls { get; set; }
        public DbSet<T_Fes_BusinessOfMgr> T_Fes_BusinessOfMgr { get; set; }
        public DbSet<T_Fes_Document> T_Fes_Document { get; set; }
        public DbSet<T_Fes_Fls> T_Fes_Fls { get; set; }
        public DbSet<T_Fes_Fls_Account> T_Fes_Fls_Account { get; set; }
        public DbSet<T_Fes_Fls_Bus> T_Fes_Fls_Bus { get; set; }
        public DbSet<T_Fes_Fls_Fennote> T_Fes_Fls_Fennote { get; set; }
        public DbSet<T_Fes_Fls_Fennote_ins> T_Fes_Fls_Fennote_ins { get; set; }
        public DbSet<T_Fes_Fls_Notice> T_Fes_Fls_Notice { get; set; }
        public DbSet<T_Fes_Fls_NoticeType> T_Fes_Fls_NoticeType { get; set; }
        public DbSet<T_Fes_FlsOfMgr> T_Fes_FlsOfMgr { get; set; }
        public DbSet<T_Fes_Menu> T_Fes_Menu { get; set; }
        public DbSet<T_Fes_Menu_Fls> T_Fes_Menu_Fls { get; set; }
        public DbSet<T_Fes_OneCardIns_Base> T_Fes_OneCardIns_Base { get; set; }
        public DbSet<T_Fes_Question> T_Fes_Question { get; set; }
        public DbSet<T_Fes_Safeuser_Ins> T_Fes_Safeuser_Ins { get; set; }
        public DbSet<T_Fes_Salfuser> T_Fes_Salfuser { get; set; }
        public DbSet<T_Fes_Shouaddr> T_Fes_Shouaddr { get; set; }
        public DbSet<T_Fes_User> T_Fes_User { get; set; }
        public DbSet<T_Fes_User_Account> T_Fes_User_Account { get; set; }
        public DbSet<T_Fes_User_Account_Isreg_Bak> T_Fes_User_Account_Isreg_Bak { get; set; }
        public DbSet<T_FES_USER_BAK> T_FES_USER_BAK { get; set; }
        public DbSet<T_Fes_User_Cardnote> T_Fes_User_Cardnote { get; set; }
        public DbSet<T_Fes_User_Check_Note> T_Fes_User_Check_Note { get; set; }
        public DbSet<T_Fes_User_Ext> T_Fes_User_Ext { get; set; }
        public DbSet<T_Fes_User_Fenback_ins> T_Fes_User_Fenback_ins { get; set; }
        public DbSet<T_Fes_User_Fenback_ins_tail> T_Fes_User_Fenback_ins_tail { get; set; }
        public DbSet<T_Fes_User_FenBakFesco_Log> T_Fes_User_FenBakFesco_Log { get; set; }
        public DbSet<T_Fes_User_Fennote> T_Fes_User_Fennote { get; set; }
        public DbSet<T_Fes_User_Fennote_ins> T_Fes_User_Fennote_ins { get; set; }
        public DbSet<T_Fes_User_Fennote_ins_tail> T_Fes_User_Fennote_ins_tail { get; set; }
        public DbSet<T_Fes_User_For_Deleted> T_Fes_User_For_Deleted { get; set; }
        public DbSet<T_Fes_User_Frostfen_ins> T_Fes_User_Frostfen_ins { get; set; }
        public DbSet<T_Fes_User_Frostfen_ins_tail> T_Fes_User_Frostfen_ins_tail { get; set; }
        public DbSet<T_Fes_User_Isreg_Bak> T_Fes_User_Isreg_Bak { get; set; }
        public DbSet<T_Fes_User_Leave_Note> T_Fes_User_Leave_Note { get; set; }
        public DbSet<T_Fes_User_Log> T_Fes_User_Log { get; set; }
        public DbSet<T_Fes_User_Power_ins> T_Fes_User_Power_ins { get; set; }
        public DbSet<T_Fes_User_Power_ins_tail> T_Fes_User_Power_ins_tail { get; set; }
        public DbSet<T_Fes_User_Role> T_Fes_User_Role { get; set; }
        public DbSet<T_Fes_User_SafeCheck> T_Fes_User_SafeCheck { get; set; }
        public DbSet<T_Fes_Userverify> T_Fes_Userverify { get; set; }
        public DbSet<T_FOURONE_CODE> T_FOURONE_CODE { get; set; }
        public DbSet<T_FOURONE_SET> T_FOURONE_SET { get; set; }
        public DbSet<T_FOURONE_SET_TAIL> T_FOURONE_SET_TAIL { get; set; }
        public DbSet<T_Gds_Area> T_Gds_Area { get; set; }
        public DbSet<T_Gds_AskCause> T_Gds_AskCause { get; set; }
        public DbSet<T_Gds_BackCard> T_Gds_BackCard { get; set; }
        public DbSet<T_Gds_Base> T_Gds_Base { get; set; }
        public DbSet<T_Gds_Base_Ys1> T_Gds_Base_Ys1 { get; set; }
        public DbSet<T_Gds_Base_Ys2> T_Gds_Base_Ys2 { get; set; }
        public DbSet<T_Gds_Cang> T_Gds_Cang { get; set; }
        public DbSet<T_Gds_Click> T_Gds_Click { get; set; }
        public DbSet<T_Gds_Col> T_Gds_Col { get; set; }
        public DbSet<T_Gds_Dan> T_Gds_Dan { get; set; }
        public DbSet<T_Gds_Dan_BckList> T_Gds_Dan_BckList { get; set; }
        public DbSet<T_Gds_Dan_ChgList> T_Gds_Dan_ChgList { get; set; }
        public DbSet<T_Gds_Dan_Cost_Back> T_Gds_Dan_Cost_Back { get; set; }
        public DbSet<T_Gds_Dan_Costs> T_Gds_Dan_Costs { get; set; }
        public DbSet<T_Gds_Dan_Ext> T_Gds_Dan_Ext { get; set; }
        public DbSet<T_Gds_Dan_For_UserType> T_Gds_Dan_For_UserType { get; set; }
        public DbSet<T_Gds_Dan_Interface_Note> T_Gds_Dan_Interface_Note { get; set; }
        public DbSet<T_Gds_Dan_Pay> T_Gds_Dan_Pay { get; set; }
        public DbSet<T_Gds_Dan_Pay_Notify> T_Gds_Dan_Pay_Notify { get; set; }
        public DbSet<T_Gds_Dan_Payed_Notify> T_Gds_Dan_Payed_Notify { get; set; }
        public DbSet<T_Gds_Dan_PayNote> T_Gds_Dan_PayNote { get; set; }
        public DbSet<T_Gds_Dan_Sends> T_Gds_Dan_Sends { get; set; }
        public DbSet<T_Gds_Dan_Sends_Tele_Err> T_Gds_Dan_Sends_Tele_Err { get; set; }
        public DbSet<T_Gds_Dan_Tail> T_Gds_Dan_Tail { get; set; }
        public DbSet<T_Gds_Dan_temp> T_Gds_Dan_temp { get; set; }
        public DbSet<T_Gds_Dan_temp_ins> T_Gds_Dan_temp_ins { get; set; }
        public DbSet<T_Gds_Dan_Tui> T_Gds_Dan_Tui { get; set; }
        public DbSet<T_Gds_Gys> T_Gds_Gys { get; set; }
        public DbSet<T_Gds_Links> T_Gds_Links { get; set; }
        public DbSet<T_Gds_No_Wake> T_Gds_No_Wake { get; set; }
        public DbSet<T_Gds_OneceCard> T_Gds_OneceCard { get; set; }
        public DbSet<T_Gds_Pinglun> T_Gds_Pinglun { get; set; }
        public DbSet<T_Gds_Pinglun_Back> T_Gds_Pinglun_Back { get; set; }
        public DbSet<T_Gds_Plan_Des> T_Gds_Plan_Des { get; set; }
        public DbSet<T_Gds_Pub_Col> T_Gds_Pub_Col { get; set; }
        public DbSet<T_Gds_Pubtail> T_Gds_Pubtail { get; set; }
        public DbSet<T_Gds_Searchs> T_Gds_Searchs { get; set; }
        public DbSet<T_Gds_ShoppingCar> T_Gds_ShoppingCar { get; set; }
        public DbSet<T_Gds_TeleCard> T_Gds_TeleCard { get; set; }
        public DbSet<T_Gds_Trademark> T_Gds_Trademark { get; set; }
        public DbSet<T_Gds_Whole> T_Gds_Whole { get; set; }
        public DbSet<T_Gds_Whole_Pay> T_Gds_Whole_Pay { get; set; }
        public DbSet<T_Gds_Whole_PayNote> T_Gds_Whole_PayNote { get; set; }
        public DbSet<T_Gds_Whole_Tail> T_Gds_Whole_Tail { get; set; }
        public DbSet<T_Gds_Wuliu> T_Gds_Wuliu { get; set; }
        public DbSet<T_Gds_Wuliu_Paras> T_Gds_Wuliu_Paras { get; set; }
        public DbSet<T_Gds_Yunfei> T_Gds_Yunfei { get; set; }
        public DbSet<T_GJJZQ_Accessory> T_GJJZQ_Accessory { get; set; }
        public DbSet<T_GJJZQ_AnswerList> T_GJJZQ_AnswerList { get; set; }
        public DbSet<T_GJJZQ_Apply> T_GJJZQ_Apply { get; set; }
        public DbSet<T_GJJZQ_Material> T_GJJZQ_Material { get; set; }
        public DbSet<T_GJJZQ_ResultTurn> T_GJJZQ_ResultTurn { get; set; }
        public DbSet<T_GJJZQ_TitleTurn> T_GJJZQ_TitleTurn { get; set; }
        public DbSet<T_Helo_Img> T_Helo_Img { get; set; }
        public DbSet<T_Helo_Menu_Ext> T_Helo_Menu_Ext { get; set; }
        public DbSet<T_Helo_MsgLog> T_Helo_MsgLog { get; set; }
        public DbSet<T_HK_BussinessItem> T_HK_BussinessItem { get; set; }
        public DbSet<T_HK_Dictionary> T_HK_Dictionary { get; set; }
        public DbSet<T_HK_Hokou_Transfer> T_HK_Hokou_Transfer { get; set; }
        public DbSet<T_HK_Hukou_Lend> T_HK_Hukou_Lend { get; set; }
        public DbSet<T_HK_Order> T_HK_Order { get; set; }
        public DbSet<T_HK_OrderItem> T_HK_OrderItem { get; set; }
        public DbSet<T_HK_Task> T_HK_Task { get; set; }
        public DbSet<T_HK_TaskDetail> T_HK_TaskDetail { get; set; }
        public DbSet<T_Imp_DefaultOrder_Note> T_Imp_DefaultOrder_Note { get; set; }
        public DbSet<T_Imp_DefaultOrder_Tail> T_Imp_DefaultOrder_Tail { get; set; }
        public DbSet<T_Imp_NewUser_Note> T_Imp_NewUser_Note { get; set; }
        public DbSet<T_Imp_NewUser_Tail> T_Imp_NewUser_Tail { get; set; }
        public DbSet<T_Ind_BankOfChina> T_Ind_BankOfChina { get; set; }
        public DbSet<T_Ind_ColResidence> T_Ind_ColResidence { get; set; }
        public DbSet<T_Ind_Contract> T_Ind_Contract { get; set; }
        public DbSet<T_Ind_ContractFile> T_Ind_ContractFile { get; set; }
        public DbSet<T_Ind_Delivery> T_Ind_Delivery { get; set; }
        public DbSet<T_Ind_Detail> T_Ind_Detail { get; set; }
        public DbSet<T_Ind_EmployeeCard> T_Ind_EmployeeCard { get; set; }
        public DbSet<T_Ind_EmployeeCardFile> T_Ind_EmployeeCardFile { get; set; }
        public DbSet<T_Ind_Formality> T_Ind_Formality { get; set; }
        public DbSet<T_Ind_Guide> T_Ind_Guide { get; set; }
        public DbSet<T_Ind_ParOrgRelation> T_Ind_ParOrgRelation { get; set; }
        public DbSet<T_Ind_PersonalFile> T_Ind_PersonalFile { get; set; }
        public DbSet<T_Ind_ProveOrder> T_Ind_ProveOrder { get; set; }
        public DbSet<T_Ind_ProveRecord> T_Ind_ProveRecord { get; set; }
        public DbSet<T_Ind_Token> T_Ind_Token { get; set; }
        public DbSet<T_IndExm_Ext> T_IndExm_Ext { get; set; }
        public DbSet<T_IndExm_Mail> T_IndExm_Mail { get; set; }
        public DbSet<T_IndExm_Temp> T_IndExm_Temp { get; set; }
        public DbSet<T_Inputval> T_Inputval { get; set; }
        public DbSet<T_Int_Tokenuser> T_Int_Tokenuser { get; set; }
        public DbSet<T_Jt_Card> T_Jt_Card { get; set; }
        public DbSet<T_Mdc_Medical> T_Mdc_Medical { get; set; }
        public DbSet<T_Mdc_Medicaluserinfo> T_Mdc_Medicaluserinfo { get; set; }
        public DbSet<T_Mem_Benefitcard> T_Mem_Benefitcard { get; set; }
        public DbSet<T_Mem_Benefityouhui> T_Mem_Benefityouhui { get; set; }
        public DbSet<T_Mem_Leaveword> T_Mem_Leaveword { get; set; }
        public DbSet<T_MicrAct_Abdate> T_MicrAct_Abdate { get; set; }
        public DbSet<T_MicrAct_Active> T_MicrAct_Active { get; set; }
        public DbSet<T_MicrAct_Card> T_MicrAct_Card { get; set; }
        public DbSet<T_MicrAct_Files> T_MicrAct_Files { get; set; }
        public DbSet<T_MicrAct_Member> T_MicrAct_Member { get; set; }
        public DbSet<T_MicrAct_PromoCode> T_MicrAct_PromoCode { get; set; }
        public DbSet<T_MicrAct_Reginput_Extend> T_MicrAct_Reginput_Extend { get; set; }
        public DbSet<T_MicrAct_Registration> T_MicrAct_Registration { get; set; }
        public DbSet<T_Ocean_EmployeeBenefits> T_Ocean_EmployeeBenefits { get; set; }
        public DbSet<T_Onl_Canmakename> T_Onl_Canmakename { get; set; }
        public DbSet<T_Onl_IFInfo> T_Onl_IFInfo { get; set; }
        public DbSet<T_Onl_MainTmp> T_Onl_MainTmp { get; set; }
        public DbSet<T_Onl_Prove> T_Onl_Prove { get; set; }
        public DbSet<T_Onl_Prove_Tail> T_Onl_Prove_Tail { get; set; }
        public DbSet<T_Onl_Tmp> T_Onl_Tmp { get; set; }
        public DbSet<T_Onl_Use> T_Onl_Use { get; set; }
        public DbSet<T_Onl_Workexp> T_Onl_Workexp { get; set; }
        public DbSet<T_Report_BizCost> T_Report_BizCost { get; set; }
        public DbSet<T_Rpt_Define> T_Rpt_Define { get; set; }
        public DbSet<T_Rpt_Define_Tail> T_Rpt_Define_Tail { get; set; }
        public DbSet<T_Rpt_Gen_Note> T_Rpt_Gen_Note { get; set; }
        public DbSet<T_Rpt_Oper> T_Rpt_Oper { get; set; }
        public DbSet<T_Rpt_Rol> T_Rpt_Rol { get; set; }
        public DbSet<T_Sch_FenType> T_Sch_FenType { get; set; }
        public DbSet<T_Sch_FstPage_Plans> T_Sch_FstPage_Plans { get; set; }
        public DbSet<T_Sch_Import_Errors> T_Sch_Import_Errors { get; set; }
        public DbSet<T_Sch_Plan> T_Sch_Plan { get; set; }
        public DbSet<T_Sch_Plan_Ext> T_Sch_Plan_Ext { get; set; }
        public DbSet<T_Sch_Plan_Fls> T_Sch_Plan_Fls { get; set; }
        public DbSet<T_Sch_Plan_Type> T_Sch_Plan_Type { get; set; }
        public DbSet<T_Sch_Plan_User> T_Sch_Plan_User { get; set; }
        public DbSet<T_Sch_Zheng_Interface> T_Sch_Zheng_Interface { get; set; }
        public DbSet<T_Scmsg_Changebus> T_Scmsg_Changebus { get; set; }
        public DbSet<T_Scmsg_ChangebusDet> T_Scmsg_ChangebusDet { get; set; }
        public DbSet<T_SendMsgTel> T_SendMsgTel { get; set; }
        public DbSet<T_Seq> T_Seq { get; set; }
        public DbSet<T_Sohu_Dan_ReTransfer> T_Sohu_Dan_ReTransfer { get; set; }
        public DbSet<T_Sohu_Sends_Errors> T_Sohu_Sends_Errors { get; set; }
        public DbSet<T_Sys_Calendar> T_Sys_Calendar { get; set; }
        public DbSet<T_Sys_ExportFiles> T_Sys_ExportFiles { get; set; }
        public DbSet<T_Sys_File> T_Sys_File { get; set; }
        public DbSet<T_Sys_Gds_Dan_Buynum_Message> T_Sys_Gds_Dan_Buynum_Message { get; set; }
        public DbSet<T_Sys_Guanggao> T_Sys_Guanggao { get; set; }
        public DbSet<T_Sys_IdCardInfo> T_Sys_IdCardInfo { get; set; }
        public DbSet<T_Sys_ImportFiles> T_Sys_ImportFiles { get; set; }
        public DbSet<T_Sys_Mails> T_Sys_Mails { get; set; }
        public DbSet<T_Sys_Mails_Yg> T_Sys_Mails_Yg { get; set; }
        public DbSet<T_Sys_Msg> T_Sys_Msg { get; set; }
        public DbSet<T_Sys_Notice> T_Sys_Notice { get; set; }
        public DbSet<T_Sys_PhoneCode> T_Sys_PhoneCode { get; set; }
        public DbSet<T_Sys_Planuser_Same_Message> T_Sys_Planuser_Same_Message { get; set; }
        public DbSet<T_Sys_QrCode> T_Sys_QrCode { get; set; }
        public DbSet<T_Sys_ServiceCenter> T_Sys_ServiceCenter { get; set; }
        public DbSet<T_Sys_Smtp> T_Sys_Smtp { get; set; }
        public DbSet<T_Task_Fls_MainType> T_Task_Fls_MainType { get; set; }
        public DbSet<T_Task_Fls_Menu> T_Task_Fls_Menu { get; set; }
        public DbSet<T_Task_Fls_Type> T_Task_Fls_Type { get; set; }
        public DbSet<T_Task_MainType> T_Task_MainType { get; set; }
        public DbSet<T_Task_Menu_Ext> T_Task_Menu_Ext { get; set; }
        public DbSet<T_Task_Menu_Ext_Fls> T_Task_Menu_Ext_Fls { get; set; }
        public DbSet<T_Task_Note> T_Task_Note { get; set; }
        public DbSet<T_Task_Note_Tail> T_Task_Note_Tail { get; set; }
        public DbSet<T_Task_Type> T_Task_Type { get; set; }
        public DbSet<T_Tb_dictionarylist> T_Tb_dictionarylist { get; set; }
        public DbSet<T_Tb_dictionarylistTemp> T_Tb_dictionarylistTemp { get; set; }
        public DbSet<T_Tb_User_Ext1> T_Tb_User_Ext1 { get; set; }
        public DbSet<T_Tb_User_Ext1_20161129> T_Tb_User_Ext1_20161129 { get; set; }
        public DbSet<T_Tb_User_Ext2> T_Tb_User_Ext2 { get; set; }
        public DbSet<T_Tb_User_Ext2_20161129> T_Tb_User_Ext2_20161129 { get; set; }
        public DbSet<T_Tb_User_Ext3> T_Tb_User_Ext3 { get; set; }
        public DbSet<T_Tb_User_Ext3_20161129> T_Tb_User_Ext3_20161129 { get; set; }
        public DbSet<T_Tb_User_Ext4> T_Tb_User_Ext4 { get; set; }
        public DbSet<T_Tb_User_Ext4_20161129> T_Tb_User_Ext4_20161129 { get; set; }
        public DbSet<T_Tb_User_Ext5> T_Tb_User_Ext5 { get; set; }
        public DbSet<T_Tb_User_Ext5_20161129> T_Tb_User_Ext5_20161129 { get; set; }
        public DbSet<T_Tb_User_Ext6> T_Tb_User_Ext6 { get; set; }
        public DbSet<T_Tb_User_Ext6_20161129> T_Tb_User_Ext6_20161129 { get; set; }
        public DbSet<T_Tb_User_Ext7> T_Tb_User_Ext7 { get; set; }
        public DbSet<T_Tot_User_Fen_Month> T_Tot_User_Fen_Month { get; set; }
        public DbSet<T_Usr_Liuyan> T_Usr_Liuyan { get; set; }
        public DbSet<T_Yy_plan> T_Yy_plan { get; set; }
        public DbSet<T_Yy_record> T_Yy_record { get; set; }
        public DbSet<T_ZP_Area> T_ZP_Area { get; set; }
        public DbSet<T_ZP_Company> T_ZP_Company { get; set; }
        public DbSet<T_ZP_Disarea> T_ZP_Disarea { get; set; }
        public DbSet<T_ZP_Job> T_ZP_Job { get; set; }
        public DbSet<T_ZP_Perappjob> T_ZP_Perappjob { get; set; }
        public DbSet<T_ZP_Userinfo> T_ZP_Userinfo { get; set; }
        public DbSet<temp_Sohu> temp_Sohu { get; set; }
        public DbSet<tuv2016all> tuv2016all { get; set; }
        public DbSet<tuv2016allNew> tuv2016allNew { get; set; }
        public DbSet<Useropen> Useropens { get; set; }
        public DbSet<Vote_Info> Vote_Info { get; set; }
        public DbSet<Vote_Resault> Vote_Resault { get; set; }
        public DbSet<Wei_TempMsg> Wei_TempMsg { get; set; }
        public DbSet<Wx_Huodong_Code> Wx_Huodong_Code { get; set; }
        public DbSet<X_SENDS> X_SENDS { get; set; }
        public DbSet<zhuanhua> zhuanhuas { get; set; }
        public DbSet<zp_area> zp_area { get; set; }
        public DbSet<zp_company> zp_company { get; set; }
        public DbSet<zp_disarea> zp_disarea { get; set; }
        public DbSet<zp_job> zp_job { get; set; }
        public DbSet<zp_perappjob> zp_perappjob { get; set; }
        public DbSet<zp_userinfo> zp_userinfo { get; set; }
        public DbSet<HM_DISCUZ> HM_DISCUZ { get; set; }
        public DbSet<Hth_OrderAndWrap_Info> Hth_OrderAndWrap_Info { get; set; }
        public DbSet<HV_TASKTAIL> HV_TASKTAIL { get; set; }
        public DbSet<TEMP_COLUMN> TEMP_COLUMN { get; set; }
        public DbSet<TEMP_DEFAULT> TEMP_DEFAULT { get; set; }
        public DbSet<V_Act_Registration> V_Act_Registration { get; set; }
        public DbSet<V_CD_PROVINCE> V_CD_PROVINCE { get; set; }
        public DbSet<V_CD_XIAN> V_CD_XIAN { get; set; }
        public DbSet<V_Exm_Teday_Jigou> V_Exm_Teday_Jigou { get; set; }
        public DbSet<V_Fes_Safe_User> V_Fes_Safe_User { get; set; }
        public DbSet<V_Fes_User_Fenback_ins_tail> V_Fes_User_Fenback_ins_tail { get; set; }
        public DbSet<V_Fes_User_FenFrost_ins_tail> V_Fes_User_FenFrost_ins_tail { get; set; }
        public DbSet<V_Fes_User_Fennote> V_Fes_User_Fennote { get; set; }
        public DbSet<V_Fes_User_Fennote_ins_tail> V_Fes_User_Fennote_ins_tail { get; set; }
        public DbSet<V_Gds_Base> V_Gds_Base { get; set; }
        public DbSet<V_Gds_Cang> V_Gds_Cang { get; set; }
        public DbSet<V_Gds_Col_Rl> V_Gds_Col_Rl { get; set; }
        public DbSet<V_Gds_ColTail> V_Gds_ColTail { get; set; }
        public DbSet<V_Gds_Dan> V_Gds_Dan { get; set; }
        public DbSet<V_Gds_Dan_0> V_Gds_Dan_0 { get; set; }
        public DbSet<V_Gds_Dan_1> V_Gds_Dan_1 { get; set; }
        public DbSet<V_Gds_Dan_3> V_Gds_Dan_3 { get; set; }
        public DbSet<V_Gds_Dan_4> V_Gds_Dan_4 { get; set; }
        public DbSet<V_Gds_Dan_6> V_Gds_Dan_6 { get; set; }
        public DbSet<V_Gds_Dan_Tui> V_Gds_Dan_Tui { get; set; }
        public DbSet<V_Gds_PubTail> V_Gds_PubTail { get; set; }
        public DbSet<V_Gds_PubTail_ext> V_Gds_PubTail_ext { get; set; }
        public DbSet<V_IndExm_Mail> V_IndExm_Mail { get; set; }
        public DbSet<V_Mdc_Medical> V_Mdc_Medical { get; set; }
        public DbSet<V_Mem_Leaveword> V_Mem_Leaveword { get; set; }
        public DbSet<V_MicrAct_PromoCode> V_MicrAct_PromoCode { get; set; }
        public DbSet<V_MicrAct_Registration> V_MicrAct_Registration { get; set; }
        public DbSet<V_MicrActiveRecord> V_MicrActiveRecord { get; set; }
        public DbSet<v_productordertemp> v_productordertemp { get; set; }
        public DbSet<V_Que_Wake> V_Que_Wake { get; set; }
        public DbSet<V_Sch_Plan_User> V_Sch_Plan_User { get; set; }
        public DbSet<V_Sys_Locked_Table> V_Sys_Locked_Table { get; set; }
        public DbSet<V_Task_Fls_MainType> V_Task_Fls_MainType { get; set; }
        public DbSet<V_TASK_MENU_EXT_FLS> V_TASK_MENU_EXT_FLS { get; set; }
        public DbSet<V_Task_Note> V_Task_Note { get; set; }
        public DbSet<V_TASK_TAIL> V_TASK_TAIL { get; set; }
        public DbSet<V_Task_Tasktype> V_Task_Tasktype { get; set; }
        public DbSet<V_Task_Wake> V_Task_Wake { get; set; }
        public DbSet<V_Tgds_Pubtail> V_Tgds_Pubtail { get; set; }
        public DbSet<vwdnt_users> vwdnt_users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new C_561_FEN_ERRORMap());
            modelBuilder.Configurations.Add(new C_T_ALLMap());
            modelBuilder.Configurations.Add(new C_T_HASMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new Hm_DiaochaMap());
            modelBuilder.Configurations.Add(new Hm_GuanggaohitsMap());
            modelBuilder.Configurations.Add(new Hm_HlrviststMap());
            modelBuilder.Configurations.Add(new Hm_HotlinksMap());
            modelBuilder.Configurations.Add(new Hm_JibieMap());
            modelBuilder.Configurations.Add(new Hm_MailsMap());
            modelBuilder.Configurations.Add(new Hm_Mails_Yg_ReMap());
            modelBuilder.Configurations.Add(new Hm_mailsenderMap());
            modelBuilder.Configurations.Add(new Hm_PointsMap());
            modelBuilder.Configurations.Add(new Hm_Sql_LogMap());
            modelBuilder.Configurations.Add(new Hm_VisitMap());
            modelBuilder.Configurations.Add(new Hm_WxtempcodeuserMap());
            modelBuilder.Configurations.Add(new Hth_S_BlacklistMap());
            modelBuilder.Configurations.Add(new Hth_S_DiseaseMap());
            modelBuilder.Configurations.Add(new Hth_S_LogMap());
            modelBuilder.Configurations.Add(new Hth_S_PackMap());
            modelBuilder.Configurations.Add(new Hth_S_SetAuditMap());
            modelBuilder.Configurations.Add(new Hth_T_ActualMap());
            modelBuilder.Configurations.Add(new Hth_T_AuditMap());
            modelBuilder.Configurations.Add(new Hth_T_Audit_OrderMap());
            modelBuilder.Configurations.Add(new Hth_T_CommonHospitalMap());
            modelBuilder.Configurations.Add(new Hth_T_CostMap());
            modelBuilder.Configurations.Add(new Hth_T_CostImgSortMap());
            modelBuilder.Configurations.Add(new Hth_T_DeductMap());
            modelBuilder.Configurations.Add(new Hth_T_DeductTypeMap());
            modelBuilder.Configurations.Add(new Hth_T_DrugMap());
            modelBuilder.Configurations.Add(new Hth_T_FinancialStatisticsMap());
            modelBuilder.Configurations.Add(new Hth_T_GloablSettingsMap());
            modelBuilder.Configurations.Add(new Hth_T_HospitalMap());
            modelBuilder.Configurations.Add(new Hth_T_Hospital_NewMap());
            modelBuilder.Configurations.Add(new Hth_T_ImgAttrMap());
            modelBuilder.Configurations.Add(new Hth_T_ImgAttrTextMap());
            modelBuilder.Configurations.Add(new Hth_T_ImgSortMap());
            modelBuilder.Configurations.Add(new Hth_T_IsLookIndexMap());
            modelBuilder.Configurations.Add(new Hth_T_JurisdictionMap());
            modelBuilder.Configurations.Add(new Hth_T_ModifyRecordMap());
            modelBuilder.Configurations.Add(new Hth_T_OcrReasonMap());
            modelBuilder.Configurations.Add(new Hth_T_OrderMap());
            modelBuilder.Configurations.Add(new Hth_T_OrderDataMap());
            modelBuilder.Configurations.Add(new Hth_T_OrderImgMap());
            modelBuilder.Configurations.Add(new Hth_T_OrderWrapMap());
            modelBuilder.Configurations.Add(new Hth_T_OrderWrapItemMap());
            modelBuilder.Configurations.Add(new Hth_T_PosDrugMap());
            modelBuilder.Configurations.Add(new Hth_T_PositionMap());
            modelBuilder.Configurations.Add(new Hth_T_Position_NewMap());
            modelBuilder.Configurations.Add(new Hth_T_SectionMap());
            modelBuilder.Configurations.Add(new Hth_T_SerAuditTextMap());
            modelBuilder.Configurations.Add(new Hth_T_TempHistoryOrderMap());
            modelBuilder.Configurations.Add(new MenutempMap());
            modelBuilder.Configurations.Add(new NewpriceMap());
            modelBuilder.Configurations.Add(new RenzhengdataMap());
            modelBuilder.Configurations.Add(new ROLE_BAKMap());
            modelBuilder.Configurations.Add(new Sys_FlroleMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new T_Act_AbdateMap());
            modelBuilder.Configurations.Add(new T_Act_ActiveMap());
            modelBuilder.Configurations.Add(new T_Act_AppointlimittimeMap());
            modelBuilder.Configurations.Add(new T_Act_AppointmentMap());
            modelBuilder.Configurations.Add(new T_Act_AppointmententeranswerMap());
            modelBuilder.Configurations.Add(new T_Act_AppointmentFitnesscardMap());
            modelBuilder.Configurations.Add(new T_Act_AppointmentlimitMap());
            modelBuilder.Configurations.Add(new T_Act_AppointmentProjectMap());
            modelBuilder.Configurations.Add(new T_Act_AppointtedayMap());
            modelBuilder.Configurations.Add(new T_Act_ProductbuyMap());
            modelBuilder.Configurations.Add(new T_Act_ProductordertempMap());
            modelBuilder.Configurations.Add(new T_Act_ReginputMap());
            modelBuilder.Configurations.Add(new T_Act_Reginput_ExtendMap());
            modelBuilder.Configurations.Add(new T_Act_RegistrationMap());
            modelBuilder.Configurations.Add(new T_Admin_AccountMap());
            modelBuilder.Configurations.Add(new T_Admin_AcountRoleMap());
            modelBuilder.Configurations.Add(new T_Admin_DepartMap());
            modelBuilder.Configurations.Add(new T_Admin_MenuMap());
            modelBuilder.Configurations.Add(new T_Admin_MenuDataMap());
            modelBuilder.Configurations.Add(new T_Admin_MenuData_RolePrivilegeMap());
            modelBuilder.Configurations.Add(new T_Admin_RoleMap());
            modelBuilder.Configurations.Add(new T_Admin_RoleDataMap());
            modelBuilder.Configurations.Add(new T_Admin_RoleData_RolePrivilegeMap());
            modelBuilder.Configurations.Add(new T_Admin_RolePrivilegeMap());
            modelBuilder.Configurations.Add(new T_Art_ArticleMap());
            modelBuilder.Configurations.Add(new T_Art_ColMap());
            modelBuilder.Configurations.Add(new T_Art_PinglunMap());
            modelBuilder.Configurations.Add(new T_Art_Pinglun_BackMap());
            modelBuilder.Configurations.Add(new T_Art_TypeMap());
            modelBuilder.Configurations.Add(new T_BackwordMap());
            modelBuilder.Configurations.Add(new T_Bas_DaysetMap());
            modelBuilder.Configurations.Add(new T_Ben_FlexSelectMap());
            modelBuilder.Configurations.Add(new T_Ben_MyfamilyInfoOrderMap());
            modelBuilder.Configurations.Add(new T_Ben_MyfamilyInformationMap());
            modelBuilder.Configurations.Add(new T_Ben_Plan_ExtendMap());
            modelBuilder.Configurations.Add(new T_Benefit_LeaveMap());
            modelBuilder.Configurations.Add(new T_BudbeijingMap());
            modelBuilder.Configurations.Add(new T_Budbeijing2Map());
            modelBuilder.Configurations.Add(new T_BudshanghaiMap());
            modelBuilder.Configurations.Add(new T_BudtianjinMap());
            modelBuilder.Configurations.Add(new T_BuildingMap());
            modelBuilder.Configurations.Add(new T_CanmakenameMap());
            modelBuilder.Configurations.Add(new T_Clb_ClubsMap());
            modelBuilder.Configurations.Add(new T_Clb_MembersMap());
            modelBuilder.Configurations.Add(new T_Code_HospitalMap());
            modelBuilder.Configurations.Add(new T_Code_ProvCityMap());
            modelBuilder.Configurations.Add(new T_Code_ProvCity_JdMap());
            modelBuilder.Configurations.Add(new T_ComplaintsMap());
            modelBuilder.Configurations.Add(new T_EmailMap());
            modelBuilder.Configurations.Add(new T_Email_BirthdayMap());
            modelBuilder.Configurations.Add(new T_Email_insMap());
            modelBuilder.Configurations.Add(new T_Email_ins_tailMap());
            modelBuilder.Configurations.Add(new T_Email_SendMap());
            modelBuilder.Configurations.Add(new T_Exam_User_ImportMap());
            modelBuilder.Configurations.Add(new T_Exam_User_Import_HisMap());
            modelBuilder.Configurations.Add(new T_ExImportFilesMap());
            modelBuilder.Configurations.Add(new T_Exm_AssessmentResultMap());
            modelBuilder.Configurations.Add(new T_Exm_CardMap());
            modelBuilder.Configurations.Add(new T_Exm_FlsMap());
            modelBuilder.Configurations.Add(new T_Exm_Fls_UserMap());
            modelBuilder.Configurations.Add(new T_Exm_GradeMap());
            modelBuilder.Configurations.Add(new T_Exm_ItemMap());
            modelBuilder.Configurations.Add(new T_Exm_JigouMap());
            modelBuilder.Configurations.Add(new T_Exm_Jigou_testMap());
            modelBuilder.Configurations.Add(new T_Exm_MsgMap());
            modelBuilder.Configurations.Add(new T_Exm_Ord_DeptMap());
            modelBuilder.Configurations.Add(new T_Exm_OrderMap());
            modelBuilder.Configurations.Add(new T_Exm_Order_BakMap());
            modelBuilder.Configurations.Add(new T_Exm_OrderDetailMap());
            modelBuilder.Configurations.Add(new T_Exm_PackageMap());
            modelBuilder.Configurations.Add(new T_Exm_PackageBagMap());
            modelBuilder.Configurations.Add(new T_Exm_PackagetempMap());
            modelBuilder.Configurations.Add(new T_Exm_PjigouMap());
            modelBuilder.Configurations.Add(new T_Exm_Pkg_ConfigMap());
            modelBuilder.Configurations.Add(new T_Exm_Pkg_ItemMap());
            modelBuilder.Configurations.Add(new T_Exm_Pro_FlsMap());
            modelBuilder.Configurations.Add(new T_Exm_ProjectMap());
            modelBuilder.Configurations.Add(new T_Exm_Project_UsersMap());
            modelBuilder.Configurations.Add(new T_Exm_ProjectDictionaryMap());
            modelBuilder.Configurations.Add(new T_Exm_PromMap());
            modelBuilder.Configurations.Add(new T_Exm_ReportMap());
            modelBuilder.Configurations.Add(new T_Exm_Report_DicMap());
            modelBuilder.Configurations.Add(new T_Exm_Report_ItemMap());
            modelBuilder.Configurations.Add(new T_Exm_TedayMap());
            modelBuilder.Configurations.Add(new T_Exm_TuanMap());
            modelBuilder.Configurations.Add(new T_Exm_Tuan_InsMap());
            modelBuilder.Configurations.Add(new T_Exm_UserMap());
            modelBuilder.Configurations.Add(new T_Exm_User_ExtMap());
            modelBuilder.Configurations.Add(new T_Exm_User201608021703Map());
            modelBuilder.Configurations.Add(new T_Exm_wordsMap());
            modelBuilder.Configurations.Add(new T_Exm_words_fesnewtestMap());
            modelBuilder.Configurations.Add(new T_ExportFilesMap());
            modelBuilder.Configurations.Add(new T_ExportGysMap());
            modelBuilder.Configurations.Add(new T_Fes_AddrMap());
            modelBuilder.Configurations.Add(new T_Fes_Admin_ManagerMap());
            modelBuilder.Configurations.Add(new T_Fes_Admin_MenuMap());
            modelBuilder.Configurations.Add(new T_Fes_Admin_Oper_NoteMap());
            modelBuilder.Configurations.Add(new T_Fes_Admin_PartMap());
            modelBuilder.Configurations.Add(new T_Fes_Admin_RoleMap());
            modelBuilder.Configurations.Add(new T_Fes_Admin_Role_TailMap());
            modelBuilder.Configurations.Add(new T_Fes_AuditMap());
            modelBuilder.Configurations.Add(new T_Fes_BenefitsProductFileInfoMap());
            modelBuilder.Configurations.Add(new T_Fes_BenefitsProductInfoMap());
            modelBuilder.Configurations.Add(new T_Fes_Business_FlsMap());
            modelBuilder.Configurations.Add(new T_Fes_BusinessOfMgrMap());
            modelBuilder.Configurations.Add(new T_Fes_DocumentMap());
            modelBuilder.Configurations.Add(new T_Fes_FlsMap());
            modelBuilder.Configurations.Add(new T_Fes_Fls_AccountMap());
            modelBuilder.Configurations.Add(new T_Fes_Fls_BusMap());
            modelBuilder.Configurations.Add(new T_Fes_Fls_FennoteMap());
            modelBuilder.Configurations.Add(new T_Fes_Fls_Fennote_insMap());
            modelBuilder.Configurations.Add(new T_Fes_Fls_NoticeMap());
            modelBuilder.Configurations.Add(new T_Fes_Fls_NoticeTypeMap());
            modelBuilder.Configurations.Add(new T_Fes_FlsOfMgrMap());
            modelBuilder.Configurations.Add(new T_Fes_MenuMap());
            modelBuilder.Configurations.Add(new T_Fes_Menu_FlsMap());
            modelBuilder.Configurations.Add(new T_Fes_OneCardIns_BaseMap());
            modelBuilder.Configurations.Add(new T_Fes_QuestionMap());
            modelBuilder.Configurations.Add(new T_Fes_Safeuser_InsMap());
            modelBuilder.Configurations.Add(new T_Fes_SalfuserMap());
            modelBuilder.Configurations.Add(new T_Fes_ShouaddrMap());
            modelBuilder.Configurations.Add(new T_Fes_UserMap());
            modelBuilder.Configurations.Add(new T_Fes_User_AccountMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Account_Isreg_BakMap());
            modelBuilder.Configurations.Add(new T_FES_USER_BAKMap());
            modelBuilder.Configurations.Add(new T_Fes_User_CardnoteMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Check_NoteMap());
            modelBuilder.Configurations.Add(new T_Fes_User_ExtMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Fenback_insMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Fenback_ins_tailMap());
            modelBuilder.Configurations.Add(new T_Fes_User_FenBakFesco_LogMap());
            modelBuilder.Configurations.Add(new T_Fes_User_FennoteMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Fennote_insMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Fennote_ins_tailMap());
            modelBuilder.Configurations.Add(new T_Fes_User_For_DeletedMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Frostfen_insMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Frostfen_ins_tailMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Isreg_BakMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Leave_NoteMap());
            modelBuilder.Configurations.Add(new T_Fes_User_LogMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Power_insMap());
            modelBuilder.Configurations.Add(new T_Fes_User_Power_ins_tailMap());
            modelBuilder.Configurations.Add(new T_Fes_User_RoleMap());
            modelBuilder.Configurations.Add(new T_Fes_User_SafeCheckMap());
            modelBuilder.Configurations.Add(new T_Fes_UserverifyMap());
            modelBuilder.Configurations.Add(new T_FOURONE_CODEMap());
            modelBuilder.Configurations.Add(new T_FOURONE_SETMap());
            modelBuilder.Configurations.Add(new T_FOURONE_SET_TAILMap());
            modelBuilder.Configurations.Add(new T_Gds_AreaMap());
            modelBuilder.Configurations.Add(new T_Gds_AskCauseMap());
            modelBuilder.Configurations.Add(new T_Gds_BackCardMap());
            modelBuilder.Configurations.Add(new T_Gds_BaseMap());
            modelBuilder.Configurations.Add(new T_Gds_Base_Ys1Map());
            modelBuilder.Configurations.Add(new T_Gds_Base_Ys2Map());
            modelBuilder.Configurations.Add(new T_Gds_CangMap());
            modelBuilder.Configurations.Add(new T_Gds_ClickMap());
            modelBuilder.Configurations.Add(new T_Gds_ColMap());
            modelBuilder.Configurations.Add(new T_Gds_DanMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_BckListMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_ChgListMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_Cost_BackMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_CostsMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_ExtMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_For_UserTypeMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_Interface_NoteMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_PayMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_Pay_NotifyMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_Payed_NotifyMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_PayNoteMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_SendsMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_Sends_Tele_ErrMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_TailMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_tempMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_temp_insMap());
            modelBuilder.Configurations.Add(new T_Gds_Dan_TuiMap());
            modelBuilder.Configurations.Add(new T_Gds_GysMap());
            modelBuilder.Configurations.Add(new T_Gds_LinksMap());
            modelBuilder.Configurations.Add(new T_Gds_No_WakeMap());
            modelBuilder.Configurations.Add(new T_Gds_OneceCardMap());
            modelBuilder.Configurations.Add(new T_Gds_PinglunMap());
            modelBuilder.Configurations.Add(new T_Gds_Pinglun_BackMap());
            modelBuilder.Configurations.Add(new T_Gds_Plan_DesMap());
            modelBuilder.Configurations.Add(new T_Gds_Pub_ColMap());
            modelBuilder.Configurations.Add(new T_Gds_PubtailMap());
            modelBuilder.Configurations.Add(new T_Gds_SearchsMap());
            modelBuilder.Configurations.Add(new T_Gds_ShoppingCarMap());
            modelBuilder.Configurations.Add(new T_Gds_TeleCardMap());
            modelBuilder.Configurations.Add(new T_Gds_TrademarkMap());
            modelBuilder.Configurations.Add(new T_Gds_WholeMap());
            modelBuilder.Configurations.Add(new T_Gds_Whole_PayMap());
            modelBuilder.Configurations.Add(new T_Gds_Whole_PayNoteMap());
            modelBuilder.Configurations.Add(new T_Gds_Whole_TailMap());
            modelBuilder.Configurations.Add(new T_Gds_WuliuMap());
            modelBuilder.Configurations.Add(new T_Gds_Wuliu_ParasMap());
            modelBuilder.Configurations.Add(new T_Gds_YunfeiMap());
            modelBuilder.Configurations.Add(new T_GJJZQ_AccessoryMap());
            modelBuilder.Configurations.Add(new T_GJJZQ_AnswerListMap());
            modelBuilder.Configurations.Add(new T_GJJZQ_ApplyMap());
            modelBuilder.Configurations.Add(new T_GJJZQ_MaterialMap());
            modelBuilder.Configurations.Add(new T_GJJZQ_ResultTurnMap());
            modelBuilder.Configurations.Add(new T_GJJZQ_TitleTurnMap());
            modelBuilder.Configurations.Add(new T_Helo_ImgMap());
            modelBuilder.Configurations.Add(new T_Helo_Menu_ExtMap());
            modelBuilder.Configurations.Add(new T_Helo_MsgLogMap());
            modelBuilder.Configurations.Add(new T_HK_BussinessItemMap());
            modelBuilder.Configurations.Add(new T_HK_DictionaryMap());
            modelBuilder.Configurations.Add(new T_HK_Hokou_TransferMap());
            modelBuilder.Configurations.Add(new T_HK_Hukou_LendMap());
            modelBuilder.Configurations.Add(new T_HK_OrderMap());
            modelBuilder.Configurations.Add(new T_HK_OrderItemMap());
            modelBuilder.Configurations.Add(new T_HK_TaskMap());
            modelBuilder.Configurations.Add(new T_HK_TaskDetailMap());
            modelBuilder.Configurations.Add(new T_Imp_DefaultOrder_NoteMap());
            modelBuilder.Configurations.Add(new T_Imp_DefaultOrder_TailMap());
            modelBuilder.Configurations.Add(new T_Imp_NewUser_NoteMap());
            modelBuilder.Configurations.Add(new T_Imp_NewUser_TailMap());
            modelBuilder.Configurations.Add(new T_Ind_BankOfChinaMap());
            modelBuilder.Configurations.Add(new T_Ind_ColResidenceMap());
            modelBuilder.Configurations.Add(new T_Ind_ContractMap());
            modelBuilder.Configurations.Add(new T_Ind_ContractFileMap());
            modelBuilder.Configurations.Add(new T_Ind_DeliveryMap());
            modelBuilder.Configurations.Add(new T_Ind_DetailMap());
            modelBuilder.Configurations.Add(new T_Ind_EmployeeCardMap());
            modelBuilder.Configurations.Add(new T_Ind_EmployeeCardFileMap());
            modelBuilder.Configurations.Add(new T_Ind_FormalityMap());
            modelBuilder.Configurations.Add(new T_Ind_GuideMap());
            modelBuilder.Configurations.Add(new T_Ind_ParOrgRelationMap());
            modelBuilder.Configurations.Add(new T_Ind_PersonalFileMap());
            modelBuilder.Configurations.Add(new T_Ind_ProveOrderMap());
            modelBuilder.Configurations.Add(new T_Ind_ProveRecordMap());
            modelBuilder.Configurations.Add(new T_Ind_TokenMap());
            modelBuilder.Configurations.Add(new T_IndExm_ExtMap());
            modelBuilder.Configurations.Add(new T_IndExm_MailMap());
            modelBuilder.Configurations.Add(new T_IndExm_TempMap());
            modelBuilder.Configurations.Add(new T_InputvalMap());
            modelBuilder.Configurations.Add(new T_Int_TokenuserMap());
            modelBuilder.Configurations.Add(new T_Jt_CardMap());
            modelBuilder.Configurations.Add(new T_Mdc_MedicalMap());
            modelBuilder.Configurations.Add(new T_Mdc_MedicaluserinfoMap());
            modelBuilder.Configurations.Add(new T_Mem_BenefitcardMap());
            modelBuilder.Configurations.Add(new T_Mem_BenefityouhuiMap());
            modelBuilder.Configurations.Add(new T_Mem_LeavewordMap());
            modelBuilder.Configurations.Add(new T_MicrAct_AbdateMap());
            modelBuilder.Configurations.Add(new T_MicrAct_ActiveMap());
            modelBuilder.Configurations.Add(new T_MicrAct_CardMap());
            modelBuilder.Configurations.Add(new T_MicrAct_FilesMap());
            modelBuilder.Configurations.Add(new T_MicrAct_MemberMap());
            modelBuilder.Configurations.Add(new T_MicrAct_PromoCodeMap());
            modelBuilder.Configurations.Add(new T_MicrAct_Reginput_ExtendMap());
            modelBuilder.Configurations.Add(new T_MicrAct_RegistrationMap());
            modelBuilder.Configurations.Add(new T_Ocean_EmployeeBenefitsMap());
            modelBuilder.Configurations.Add(new T_Onl_CanmakenameMap());
            modelBuilder.Configurations.Add(new T_Onl_IFInfoMap());
            modelBuilder.Configurations.Add(new T_Onl_MainTmpMap());
            modelBuilder.Configurations.Add(new T_Onl_ProveMap());
            modelBuilder.Configurations.Add(new T_Onl_Prove_TailMap());
            modelBuilder.Configurations.Add(new T_Onl_TmpMap());
            modelBuilder.Configurations.Add(new T_Onl_UseMap());
            modelBuilder.Configurations.Add(new T_Onl_WorkexpMap());
            modelBuilder.Configurations.Add(new T_Report_BizCostMap());
            modelBuilder.Configurations.Add(new T_Rpt_DefineMap());
            modelBuilder.Configurations.Add(new T_Rpt_Define_TailMap());
            modelBuilder.Configurations.Add(new T_Rpt_Gen_NoteMap());
            modelBuilder.Configurations.Add(new T_Rpt_OperMap());
            modelBuilder.Configurations.Add(new T_Rpt_RolMap());
            modelBuilder.Configurations.Add(new T_Sch_FenTypeMap());
            modelBuilder.Configurations.Add(new T_Sch_FstPage_PlansMap());
            modelBuilder.Configurations.Add(new T_Sch_Import_ErrorsMap());
            modelBuilder.Configurations.Add(new T_Sch_PlanMap());
            modelBuilder.Configurations.Add(new T_Sch_Plan_ExtMap());
            modelBuilder.Configurations.Add(new T_Sch_Plan_FlsMap());
            modelBuilder.Configurations.Add(new T_Sch_Plan_TypeMap());
            modelBuilder.Configurations.Add(new T_Sch_Plan_UserMap());
            modelBuilder.Configurations.Add(new T_Sch_Zheng_InterfaceMap());
            modelBuilder.Configurations.Add(new T_Scmsg_ChangebusMap());
            modelBuilder.Configurations.Add(new T_Scmsg_ChangebusDetMap());
            modelBuilder.Configurations.Add(new T_SendMsgTelMap());
            modelBuilder.Configurations.Add(new T_SeqMap());
            modelBuilder.Configurations.Add(new T_Sohu_Dan_ReTransferMap());
            modelBuilder.Configurations.Add(new T_Sohu_Sends_ErrorsMap());
            modelBuilder.Configurations.Add(new T_Sys_CalendarMap());
            modelBuilder.Configurations.Add(new T_Sys_ExportFilesMap());
            modelBuilder.Configurations.Add(new T_Sys_FileMap());
            modelBuilder.Configurations.Add(new T_Sys_Gds_Dan_Buynum_MessageMap());
            modelBuilder.Configurations.Add(new T_Sys_GuanggaoMap());
            modelBuilder.Configurations.Add(new T_Sys_IdCardInfoMap());
            modelBuilder.Configurations.Add(new T_Sys_ImportFilesMap());
            modelBuilder.Configurations.Add(new T_Sys_MailsMap());
            modelBuilder.Configurations.Add(new T_Sys_Mails_YgMap());
            modelBuilder.Configurations.Add(new T_Sys_MsgMap());
            modelBuilder.Configurations.Add(new T_Sys_NoticeMap());
            modelBuilder.Configurations.Add(new T_Sys_PhoneCodeMap());
            modelBuilder.Configurations.Add(new T_Sys_Planuser_Same_MessageMap());
            modelBuilder.Configurations.Add(new T_Sys_QrCodeMap());
            modelBuilder.Configurations.Add(new T_Sys_ServiceCenterMap());
            modelBuilder.Configurations.Add(new T_Sys_SmtpMap());
            modelBuilder.Configurations.Add(new T_Task_Fls_MainTypeMap());
            modelBuilder.Configurations.Add(new T_Task_Fls_MenuMap());
            modelBuilder.Configurations.Add(new T_Task_Fls_TypeMap());
            modelBuilder.Configurations.Add(new T_Task_MainTypeMap());
            modelBuilder.Configurations.Add(new T_Task_Menu_ExtMap());
            modelBuilder.Configurations.Add(new T_Task_Menu_Ext_FlsMap());
            modelBuilder.Configurations.Add(new T_Task_NoteMap());
            modelBuilder.Configurations.Add(new T_Task_Note_TailMap());
            modelBuilder.Configurations.Add(new T_Task_TypeMap());
            modelBuilder.Configurations.Add(new T_Tb_dictionarylistMap());
            modelBuilder.Configurations.Add(new T_Tb_dictionarylistTempMap());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext1Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext1_20161129Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext2Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext2_20161129Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext3Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext3_20161129Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext4Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext4_20161129Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext5Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext5_20161129Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext6Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext6_20161129Map());
            modelBuilder.Configurations.Add(new T_Tb_User_Ext7Map());
            modelBuilder.Configurations.Add(new T_Tot_User_Fen_MonthMap());
            modelBuilder.Configurations.Add(new T_Usr_LiuyanMap());
            modelBuilder.Configurations.Add(new T_Yy_planMap());
            modelBuilder.Configurations.Add(new T_Yy_recordMap());
            modelBuilder.Configurations.Add(new T_ZP_AreaMap());
            modelBuilder.Configurations.Add(new T_ZP_CompanyMap());
            modelBuilder.Configurations.Add(new T_ZP_DisareaMap());
            modelBuilder.Configurations.Add(new T_ZP_JobMap());
            modelBuilder.Configurations.Add(new T_ZP_PerappjobMap());
            modelBuilder.Configurations.Add(new T_ZP_UserinfoMap());
            modelBuilder.Configurations.Add(new temp_SohuMap());
            modelBuilder.Configurations.Add(new tuv2016allMap());
            modelBuilder.Configurations.Add(new tuv2016allNewMap());
            modelBuilder.Configurations.Add(new UseropenMap());
            modelBuilder.Configurations.Add(new Vote_InfoMap());
            modelBuilder.Configurations.Add(new Vote_ResaultMap());
            modelBuilder.Configurations.Add(new Wei_TempMsgMap());
            modelBuilder.Configurations.Add(new Wx_Huodong_CodeMap());
            modelBuilder.Configurations.Add(new X_SENDSMap());
            modelBuilder.Configurations.Add(new zhuanhuaMap());
            modelBuilder.Configurations.Add(new zp_areaMap());
            modelBuilder.Configurations.Add(new zp_companyMap());
            modelBuilder.Configurations.Add(new zp_disareaMap());
            modelBuilder.Configurations.Add(new zp_jobMap());
            modelBuilder.Configurations.Add(new zp_perappjobMap());
            modelBuilder.Configurations.Add(new zp_userinfoMap());
            modelBuilder.Configurations.Add(new HM_DISCUZMap());
            modelBuilder.Configurations.Add(new Hth_OrderAndWrap_InfoMap());
            modelBuilder.Configurations.Add(new HV_TASKTAILMap());
            modelBuilder.Configurations.Add(new TEMP_COLUMNMap());
            modelBuilder.Configurations.Add(new TEMP_DEFAULTMap());
            modelBuilder.Configurations.Add(new V_Act_RegistrationMap());
            modelBuilder.Configurations.Add(new V_CD_PROVINCEMap());
            modelBuilder.Configurations.Add(new V_CD_XIANMap());
            modelBuilder.Configurations.Add(new V_Exm_Teday_JigouMap());
            modelBuilder.Configurations.Add(new V_Fes_Safe_UserMap());
            modelBuilder.Configurations.Add(new V_Fes_User_Fenback_ins_tailMap());
            modelBuilder.Configurations.Add(new V_Fes_User_FenFrost_ins_tailMap());
            modelBuilder.Configurations.Add(new V_Fes_User_FennoteMap());
            modelBuilder.Configurations.Add(new V_Fes_User_Fennote_ins_tailMap());
            modelBuilder.Configurations.Add(new V_Gds_BaseMap());
            modelBuilder.Configurations.Add(new V_Gds_CangMap());
            modelBuilder.Configurations.Add(new V_Gds_Col_RlMap());
            modelBuilder.Configurations.Add(new V_Gds_ColTailMap());
            modelBuilder.Configurations.Add(new V_Gds_DanMap());
            modelBuilder.Configurations.Add(new V_Gds_Dan_0Map());
            modelBuilder.Configurations.Add(new V_Gds_Dan_1Map());
            modelBuilder.Configurations.Add(new V_Gds_Dan_3Map());
            modelBuilder.Configurations.Add(new V_Gds_Dan_4Map());
            modelBuilder.Configurations.Add(new V_Gds_Dan_6Map());
            modelBuilder.Configurations.Add(new V_Gds_Dan_TuiMap());
            modelBuilder.Configurations.Add(new V_Gds_PubTailMap());
            modelBuilder.Configurations.Add(new V_Gds_PubTail_extMap());
            modelBuilder.Configurations.Add(new V_IndExm_MailMap());
            modelBuilder.Configurations.Add(new V_Mdc_MedicalMap());
            modelBuilder.Configurations.Add(new V_Mem_LeavewordMap());
            modelBuilder.Configurations.Add(new V_MicrAct_PromoCodeMap());
            modelBuilder.Configurations.Add(new V_MicrAct_RegistrationMap());
            modelBuilder.Configurations.Add(new V_MicrActiveRecordMap());
            modelBuilder.Configurations.Add(new v_productordertempMap());
            modelBuilder.Configurations.Add(new V_Que_WakeMap());
            modelBuilder.Configurations.Add(new V_Sch_Plan_UserMap());
            modelBuilder.Configurations.Add(new V_Sys_Locked_TableMap());
            modelBuilder.Configurations.Add(new V_Task_Fls_MainTypeMap());
            modelBuilder.Configurations.Add(new V_TASK_MENU_EXT_FLSMap());
            modelBuilder.Configurations.Add(new V_Task_NoteMap());
            modelBuilder.Configurations.Add(new V_TASK_TAILMap());
            modelBuilder.Configurations.Add(new V_Task_TasktypeMap());
            modelBuilder.Configurations.Add(new V_Task_WakeMap());
            modelBuilder.Configurations.Add(new V_Tgds_PubtailMap());
            modelBuilder.Configurations.Add(new vwdnt_usersMap());
        }
    }
}
