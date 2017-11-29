namespace knockoutDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<cwgc_feedback> cwgc_feedback { get; set; }
        public virtual DbSet<exam_exname> exam_exname { get; set; }
        public virtual DbSet<exam_userlist> exam_userlist { get; set; }
        public virtual DbSet<kcsx_difficultylevel> kcsx_difficultylevel { get; set; }
        public virtual DbSet<kcsx_flageducation> kcsx_flageducation { get; set; }
        public virtual DbSet<kcsx_task> kcsx_task { get; set; }
        public virtual DbSet<kcsx_taskdetail> kcsx_taskdetail { get; set; }
        public virtual DbSet<kcsx_taskowner> kcsx_taskowner { get; set; }
        public virtual DbSet<kcsx_taskownerdetail> kcsx_taskownerdetail { get; set; }
        public virtual DbSet<kcsx_taskstate> kcsx_taskstate { get; set; }
        public virtual DbSet<kcsx_taskstatisticalstate> kcsx_taskstatisticalstate { get; set; }
        public virtual DbSet<kcsx_tasktype> kcsx_tasktype { get; set; }
        public virtual DbSet<kcsx_taskuseranswerstate> kcsx_taskuseranswerstate { get; set; }
        public virtual DbSet<kcsx_taskuserlogs> kcsx_taskuserlogs { get; set; }
        public virtual DbSet<kcsx_topic_chartfillavacantpositionaddon> kcsx_topic_chartfillavacantpositionaddon { get; set; }
        public virtual DbSet<kcsx_topic_chartfillavacantpositionansuser> kcsx_topic_chartfillavacantpositionansuser { get; set; }
        public virtual DbSet<kcsx_topic_fillavacantpositionaddon> kcsx_topic_fillavacantpositionaddon { get; set; }
        public virtual DbSet<kcsx_topic_fillavacantpositionansuser> kcsx_topic_fillavacantpositionansuser { get; set; }
        public virtual DbSet<kcsx_topic_objectivequestionaddon> kcsx_topic_objectivequestionaddon { get; set; }
        public virtual DbSet<kcsx_topic_objectivequestionansuser> kcsx_topic_objectivequestionansuser { get; set; }
        public virtual DbSet<kcsx_topicmodel> kcsx_topicmodel { get; set; }
        public virtual DbSet<kcsx_topicoptiondetail> kcsx_topicoptiondetail { get; set; }
        public virtual DbSet<kcsx_topicoptionmodel> kcsx_topicoptionmodel { get; set; }
        public virtual DbSet<kcsx_topicquestion> kcsx_topicquestion { get; set; }
        public virtual DbSet<kcsx_topictype> kcsx_topictype { get; set; }
        public virtual DbSet<kp_billing> kp_billing { get; set; }
        public virtual DbSet<kp_billinganswer> kp_billinganswer { get; set; }
        public virtual DbSet<kp_billingcommoditycode> kp_billingcommoditycode { get; set; }
        public virtual DbSet<kp_billinginvoice> kp_billinginvoice { get; set; }
        public virtual DbSet<kp_billinginvoicecommodity> kp_billinginvoicecommodity { get; set; }
        public virtual DbSet<kp_billingusercode> kp_billingusercode { get; set; }
        public virtual DbSet<kp_redinvoice> kp_redinvoice { get; set; }
        public virtual DbSet<sc_accountachievement> sc_accountachievement { get; set; }
        public virtual DbSet<sc_accountans> sc_accountans { get; set; }
        public virtual DbSet<sc_accountansuser> sc_accountansuser { get; set; }
        public virtual DbSet<sc_accountansusermanual> sc_accountansusermanual { get; set; }
        public virtual DbSet<sc_accountansusermanualstate> sc_accountansusermanualstate { get; set; }
        public virtual DbSet<sc_accountque> sc_accountque { get; set; }
        public virtual DbSet<sc_accquepic> sc_accquepic { get; set; }
        public virtual DbSet<sc_adminuser> sc_adminuser { get; set; }
        public virtual DbSet<sc_app_getui_pushmessage> sc_app_getui_pushmessage { get; set; }
        public virtual DbSet<sc_app_message_getui> sc_app_message_getui { get; set; }
        public virtual DbSet<sc_app_mobileinfo> sc_app_mobileinfo { get; set; }
        public virtual DbSet<sc_app_refreshtokens> sc_app_refreshtokens { get; set; }
        public virtual DbSet<sc_balance> sc_balance { get; set; }
        public virtual DbSet<sc_balanceanswer> sc_balanceanswer { get; set; }
        public virtual DbSet<sc_balanceitem> sc_balanceitem { get; set; }
        public virtual DbSet<sc_breakdown> sc_breakdown { get; set; }
        public virtual DbSet<sc_breakdowndetail> sc_breakdowndetail { get; set; }
        public virtual DbSet<sc_case> sc_case { get; set; }
        public virtual DbSet<sc_cashieranswer> sc_cashieranswer { get; set; }
        public virtual DbSet<sc_cashiercollect> sc_cashiercollect { get; set; }
        public virtual DbSet<sc_cashierpaper> sc_cashierpaper { get; set; }
        public virtual DbSet<sc_cashierseal> sc_cashierseal { get; set; }
        public virtual DbSet<sc_cashiertopic> sc_cashiertopic { get; set; }
        public virtual DbSet<sc_cashieruseranswer> sc_cashieruseranswer { get; set; }
        public virtual DbSet<sc_cashieruserlook> sc_cashieruserlook { get; set; }
        public virtual DbSet<sc_cashieruserreply> sc_cashieruserreply { get; set; }
        public virtual DbSet<sc_cashieruserreset> sc_cashieruserreset { get; set; }
        public virtual DbSet<sc_cashrecord> sc_cashrecord { get; set; }
        public virtual DbSet<sc_class> sc_class { get; set; }
        public virtual DbSet<sc_collection> sc_collection { get; set; }
        public virtual DbSet<sc_company> sc_company { get; set; }
        public virtual DbSet<sc_companytaxitems> sc_companytaxitems { get; set; }
        public virtual DbSet<sc_config> sc_config { get; set; }
        public virtual DbSet<sc_feedback> sc_feedback { get; set; }
        public virtual DbSet<sc_general> sc_general { get; set; }
        public virtual DbSet<sc_industry> sc_industry { get; set; }
        public virtual DbSet<sc_jzsydiy> sc_jzsydiy { get; set; }
        public virtual DbSet<sc_loginhistory> sc_loginhistory { get; set; }
        public virtual DbSet<sc_logs> sc_logs { get; set; }
        public virtual DbSet<sc_module> sc_module { get; set; }
        public virtual DbSet<sc_notice> sc_notice { get; set; }
        public virtual DbSet<sc_onepersonpneaccountsupport> sc_onepersonpneaccountsupport { get; set; }
        public virtual DbSet<sc_order> sc_order { get; set; }
        public virtual DbSet<sc_orderlog> sc_orderlog { get; set; }
        public virtual DbSet<sc_phonecode> sc_phonecode { get; set; }
        public virtual DbSet<sc_picvalidatecode> sc_picvalidatecode { get; set; }
        public virtual DbSet<sc_profit> sc_profit { get; set; }
        public virtual DbSet<sc_profitanswer> sc_profitanswer { get; set; }
        public virtual DbSet<sc_profititem> sc_profititem { get; set; }
        public virtual DbSet<sc_reset> sc_reset { get; set; }
        public virtual DbSet<sc_school> sc_school { get; set; }
        public virtual DbSet<sc_subject> sc_subject { get; set; }
        public virtual DbSet<sc_subjectremain> sc_subjectremain { get; set; }
        public virtual DbSet<sc_subsummary> sc_subsummary { get; set; }
        public virtual DbSet<sc_taccount> sc_taccount { get; set; }
        public virtual DbSet<sc_taccount_user> sc_taccount_user { get; set; }
        public virtual DbSet<sc_tie> sc_tie { get; set; }
        public virtual DbSet<sc_user> sc_user { get; set; }
        public virtual DbSet<sc_useraccansmanual> sc_useraccansmanual { get; set; }
        public virtual DbSet<sc_useraccviewanalysismanual> sc_useraccviewanalysismanual { get; set; }
        public virtual DbSet<sc_useraddress> sc_useraddress { get; set; }
        public virtual DbSet<sc_userrole> sc_userrole { get; set; }
        public virtual DbSet<sc_usersubjectperiodinitanswerrecord> sc_usersubjectperiodinitanswerrecord { get; set; }
        public virtual DbSet<sc_usertype> sc_usertype { get; set; }
        public virtual DbSet<tax_answer> tax_answer { get; set; }
        public virtual DbSet<tax_case> tax_case { get; set; }
        public virtual DbSet<tax_credentials> tax_credentials { get; set; }
        public virtual DbSet<tax_project> tax_project { get; set; }
        public virtual DbSet<tax_rate> tax_rate { get; set; }
        public virtual DbSet<tax_time> tax_time { get; set; }
        public virtual DbSet<tax_topic> tax_topic { get; set; }
        public virtual DbSet<tax_useranswer> tax_useranswer { get; set; }
        public virtual DbSet<tax_userlook> tax_userlook { get; set; }
        public virtual DbSet<tax_userperiod> tax_userperiod { get; set; }
        public virtual DbSet<tax_userquarter> tax_userquarter { get; set; }
        public virtual DbSet<tax_userreport> tax_userreport { get; set; }
        public virtual DbSet<tax_usertopic> tax_usertopic { get; set; }
        public virtual DbSet<vod_archives> vod_archives { get; set; }
        public virtual DbSet<vod_arctype> vod_arctype { get; set; }
        public virtual DbSet<sc_accountansgeneralledgermanual> sc_accountansgeneralledgermanual { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cwgc_feedback>()
                .Property(e => e.username)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cwgc_feedback>()
                .Property(e => e.arctitle)
                .IsUnicode(false);

            modelBuilder.Entity<cwgc_feedback>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<cwgc_feedback>()
                .Property(e => e.ftype)
                .IsUnicode(false);

            modelBuilder.Entity<cwgc_feedback>()
                .Property(e => e.msg)
                .IsUnicode(false);

            modelBuilder.Entity<exam_exname>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<exam_exname>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<exam_exname>()
                .Property(e => e.SchoolId)
                .IsUnicode(false);

            modelBuilder.Entity<exam_exname>()
                .Property(e => e.ExName)
                .IsUnicode(false);

            modelBuilder.Entity<exam_exname>()
                .Property(e => e.Duration)
                .HasPrecision(10, 0);

            modelBuilder.Entity<exam_exname>()
                .Property(e => e.Createuser)
                .IsUnicode(false);

            modelBuilder.Entity<exam_userlist>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<exam_userlist>()
                .Property(e => e.ExId)
                .IsUnicode(false);

            modelBuilder.Entity<exam_userlist>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<exam_userlist>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<exam_userlist>()
                .Property(e => e.UpdateUser)
                .IsUnicode(false);

            modelBuilder.Entity<exam_userlist>()
                .Property(e => e.Score)
                .HasPrecision(10, 0);

            modelBuilder.Entity<kcsx_difficultylevel>()
                .Property(e => e.DifficultyName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_flageducation>()
                .Property(e => e.FlagName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_task>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_task>()
                .Property(e => e.SchoolId)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_task>()
                .Property(e => e.ClassIds)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_task>()
                .Property(e => e.TaskName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_task>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_task>()
                .Property(e => e.UpdateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskowner>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskownerdetail>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskstate>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskstate>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskstatisticalstate>()
                .Property(e => e.StatisticalStateName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskstatisticalstate>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_tasktype>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskuseranswerstate>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskuseranswerstate>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskuseranswerstate>()
                .Property(e => e.StateTextColor)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskuseranswerstate>()
                .Property(e => e.StateImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskuserlogs>()
                .Property(e => e.UserType)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskuserlogs>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskuserlogs>()
                .Property(e => e.OperaterType)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_taskuserlogs>()
                .Property(e => e.OperaterContent)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_chartfillavacantpositionaddon>()
                .Property(e => e.TopicDesignHtml)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_chartfillavacantpositionaddon>()
                .Property(e => e.TopicDisplayHtml)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_chartfillavacantpositionaddon>()
                .Property(e => e.CorrectAnswerHtml)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_chartfillavacantpositionaddon>()
                .Property(e => e.UpdateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_chartfillavacantpositionansuser>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_chartfillavacantpositionansuser>()
                .Property(e => e.UserAswer)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_chartfillavacantpositionansuser>()
                .Property(e => e.FirstUserAnswer)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_fillavacantpositionaddon>()
                .Property(e => e.CorrectAnswerJson)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_fillavacantpositionansuser>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_fillavacantpositionansuser>()
                .Property(e => e.Aswer)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_objectivequestionaddon>()
                .Property(e => e.SelectItemsJson)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_objectivequestionaddon>()
                .Property(e => e.CorrectSelect)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_objectivequestionaddon>()
                .Property(e => e.UpdateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_objectivequestionansuser>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_objectivequestionansuser>()
                .Property(e => e.Aswer)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topic_objectivequestionansuser>()
                .Property(e => e.FirstAnswer)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicmodel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicmodel>()
                .Property(e => e.ViewPatch)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicmodel>()
                .Property(e => e.TopicRecordAddOnTableName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicmodel>()
                .Property(e => e.TopicStandardAnswerTableName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicmodel>()
                .Property(e => e.TopicUserAnswerTableName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicoptiondetail>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicoptiondetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicoptiondetail>()
                .Property(e => e.UpdateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicoptionmodel>()
                .Property(e => e.OptionModelName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicoptionmodel>()
                .Property(e => e.Desc)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicoptionmodel>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicoptionmodel>()
                .Property(e => e.UpdateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicquestion>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicquestion>()
                .Property(e => e.Tips)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicquestion>()
                .Property(e => e.PicContent)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicquestion>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicquestion>()
                .Property(e => e.AnswerAnalysis)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicquestion>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topicquestion>()
                .Property(e => e.UpdateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topictype>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topictype>()
                .Property(e => e.CoverPhoto)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topictype>()
                .Property(e => e.FlagEducationIds)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topictype>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topictype>()
                .Property(e => e.AddUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kcsx_topictype>()
                .Property(e => e.UpdateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billing>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billing>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billing>()
                .Property(e => e.ControlValue)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinganswer>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinganswer>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingcommoditycode>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingcommoditycode>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingcommoditycode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingcommoditycode>()
                .Property(e => e.Tax)
                .HasPrecision(5, 2);

            modelBuilder.Entity<kp_billingcommoditycode>()
                .Property(e => e.SimpleCode)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingcommoditycode>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.InvoiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.InvoiceNum)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.CustomerNum)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.Sku)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.Util)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.Tax)
                .HasPrecision(5, 2);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.GoodName)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.InformationAccount)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.InformationCode)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoice>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoicecommodity>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoicecommodity>()
                .Property(e => e.Sku)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoicecommodity>()
                .Property(e => e.Util)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billinginvoicecommodity>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<kp_billinginvoicecommodity>()
                .Property(e => e.Tax)
                .HasPrecision(5, 2);

            modelBuilder.Entity<kp_billinginvoicecommodity>()
                .Property(e => e.GoodName)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingusercode>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingusercode>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingusercode>()
                .Property(e => e.CustomerNum)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingusercode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingusercode>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingusercode>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<kp_billingusercode>()
                .Property(e => e.ParentCode)
                .IsUnicode(false);

            modelBuilder.Entity<kp_redinvoice>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<kp_redinvoice>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.SchoolId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.StudentID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.IndustryName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.PeriodName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.Score)
                .HasPrecision(3, 2);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.AchievementType)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountachievement>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountans>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountans>()
                .Property(e => e.QueId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountans>()
                .Property(e => e.ToMoney)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_accountans>()
                .Property(e => e.LoanMoney)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_accountans>()
                .Property(e => e.SubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountans>()
                .Property(e => e.ParentSubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountans>()
                .Property(e => e.SubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountans>()
                .Property(e => e.SubjectNameForDiy)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountans>()
                .Property(e => e.SubjectLevelOneName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountans>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansuser>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansuser>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansuser>()
                .Property(e => e.QueId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansuser>()
                .Property(e => e.UserAnswerAbsname)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansuser>()
                .Property(e => e.UserAnswerSubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansuser>()
                .Property(e => e.UserAnswerSubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansuser>()
                .Property(e => e.UserAnswerSubjectLevelOneName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansuser>()
                .Property(e => e.UserAnswerToMoney)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_accountansuser>()
                .Property(e => e.UserAnswerLoanMoney)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_accountansusermanual>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansusermanual>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansusermanual>()
                .Property(e => e.QueId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansusermanual>()
                .Property(e => e.UserAnswerAbsname)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansusermanual>()
                .Property(e => e.UserAnswerSubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansusermanual>()
                .Property(e => e.UserAnswerSubjectLevelOneName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansusermanual>()
                .Property(e => e.UserAnswerToMoney)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_accountansusermanual>()
                .Property(e => e.UserAnswerLoanMoney)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_accountansusermanualstate>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansusermanualstate>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansusermanualstate>()
                .Property(e => e.QueId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountque>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountque>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountque>()
                .Property(e => e.QueDesc)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountque>()
                .Property(e => e.AbsName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountque>()
                .Property(e => e.Anlysisi)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountque>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountque>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accquepic>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accquepic>()
                .Property(e => e.QueId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accquepic>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accquepic>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_adminuser>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_adminuser>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_adminuser>()
                .Property(e => e.NickName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_adminuser>()
                .Property(e => e.Pwd)
                .IsUnicode(false);

            modelBuilder.Entity<sc_adminuser>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<sc_adminuser>()
                .Property(e => e.Roles)
                .IsUnicode(false);

            modelBuilder.Entity<sc_adminuser>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_getui_pushmessage>()
                .Property(e => e.ClientId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_getui_pushmessage>()
                .Property(e => e.TransmissionContent)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_getui_pushmessage>()
                .Property(e => e.AppIdList)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_getui_pushmessage>()
                .Property(e => e.PhoneTypeList)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_getui_pushmessage>()
                .Property(e => e.ProvinceList)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_getui_pushmessage>()
                .Property(e => e.TagList)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_getui_pushmessage>()
                .Property(e => e.TaskContentId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_getui_pushmessage>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_message_getui>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_message_getui>()
                .Property(e => e.GetuiID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_message_getui>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_message_getui>()
                .Property(e => e.Body)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_message_getui>()
                .Property(e => e.Image01)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_message_getui>()
                .Property(e => e.Image02)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_message_getui>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_mobileinfo>()
                .Property(e => e.OperaterType)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_mobileinfo>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_mobileinfo>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_mobileinfo>()
                .Property(e => e.MobileClientId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_mobileinfo>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_refreshtokens>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_refreshtokens>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<sc_app_refreshtokens>()
                .Property(e => e.ProtectedTicket)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balance>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balance>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balanceanswer>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balanceanswer>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balanceanswer>()
                .Property(e => e.AnswerContent)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balanceitem>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balanceitem>()
                .Property(e => e.ItemFrom)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balanceitem>()
                .Property(e => e.ItemType)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balanceitem>()
                .Property(e => e.Pistion)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balanceitem>()
                .Property(e => e.Method)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balanceitem>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<sc_balanceitem>()
                .Property(e => e.Rule)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdown>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdown>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdown>()
                .Property(e => e.SubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdown>()
                .Property(e => e.ParentSubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdown>()
                .Property(e => e.SubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdown>()
                .Property(e => e.SubjectNamefordiy)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdown>()
                .Property(e => e.VouchNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdown>()
                .Property(e => e.AbsName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdown>()
                .Property(e => e.Direct)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdown>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdowndetail>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdowndetail>()
                .Property(e => e.BdId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdowndetail>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdowndetail>()
                .Property(e => e.AbsName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_breakdowndetail>()
                .Property(e => e.Direct)
                .IsUnicode(false);

            modelBuilder.Entity<sc_case>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_case>()
                .Property(e => e.ComId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_case>()
                .Property(e => e.CaseDate)
                .IsUnicode(false);

            modelBuilder.Entity<sc_case>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieranswer>()
                .Property(e => e.SortNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieranswer>()
                .Property(e => e.AnswerContent)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieranswer>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieranswer>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieranswer>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashiercollect>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashierpaper>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashierpaper>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashierpaper>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashierpaper>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashierseal>()
                .Property(e => e.ImgPath)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashierseal>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashierseal>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashiertopic>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashiertopic>()
                .Property(e => e.SubTitle)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashiertopic>()
                .Property(e => e.Describes)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashiertopic>()
                .Property(e => e.ImgPath)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashiertopic>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashiertopic>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieruseranswer>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieruseranswer>()
                .Property(e => e.SortNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieruseranswer>()
                .Property(e => e.AnswerContent)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieruseranswer>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieruserlook>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieruserreply>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashieruserreset>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashrecord>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashrecord>()
                .Property(e => e.year)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashrecord>()
                .Property(e => e.month)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashrecord>()
                .Property(e => e.day)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashrecord>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_cashrecord>()
                .Property(e => e.AbsName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_class>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<sc_collection>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_collection>()
                .Property(e => e.QueId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_collection>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.ComName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.LogoImg)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.ArtImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.BusinessLicenseVpath)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.ComAddress)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.ComArtificial)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.ComBank)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.ComAccount)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.InsId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.ComCapital)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.Taxer)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.AccountManager)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.Scope)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_company>()
                .Property(e => e.CasesJson)
                .IsUnicode(false);

            modelBuilder.Entity<sc_companytaxitems>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_companytaxitems>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_companytaxitems>()
                .Property(e => e.TaxName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_companytaxitems>()
                .Property(e => e.TaxRate)
                .IsUnicode(false);

            modelBuilder.Entity<sc_companytaxitems>()
                .Property(e => e.CalcMethod)
                .IsUnicode(false);

            modelBuilder.Entity<sc_companytaxitems>()
                .Property(e => e.PaymentTaxMethod)
                .IsUnicode(false);

            modelBuilder.Entity<sc_companytaxitems>()
                .Property(e => e.TaxDesc)
                .IsUnicode(false);

            modelBuilder.Entity<sc_companytaxitems>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<sc_companytaxitems>()
                .Property(e => e.LastUpdateUser)
                .IsUnicode(false);

            modelBuilder.Entity<sc_config>()
                .Property(e => e.ConfigKey)
                .IsUnicode(false);

            modelBuilder.Entity<sc_config>()
                .Property(e => e.ConfigName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_config>()
                .Property(e => e.ConfigValue)
                .IsUnicode(false);

            modelBuilder.Entity<sc_config>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<sc_config>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<sc_config>()
                .Property(e => e.UpdateUser)
                .IsUnicode(false);

            modelBuilder.Entity<sc_feedback>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_feedback>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_feedback>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<sc_feedback>()
                .Property(e => e.FeedbackImages)
                .IsUnicode(false);

            modelBuilder.Entity<sc_feedback>()
                .Property(e => e.ContactInfo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_feedback>()
                .Property(e => e.ClientId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_feedback>()
                .Property(e => e.UserIpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<sc_feedback>()
                .Property(e => e.ManageRemark)
                .IsUnicode(false);

            modelBuilder.Entity<sc_general>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_general>()
                .Property(e => e.SubjectId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_general>()
                .Property(e => e.AbsName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_general>()
                .Property(e => e.Direct)
                .IsUnicode(false);

            modelBuilder.Entity<sc_industry>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_industry>()
                .Property(e => e.IndustryName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_industry>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<sc_industry>()
                .Property(e => e.FilePath1)
                .IsUnicode(false);

            modelBuilder.Entity<sc_industry>()
                .Property(e => e.FilePath2)
                .IsUnicode(false);

            modelBuilder.Entity<sc_industry>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<sc_industry>()
                .Property(e => e.LastUpdateUser)
                .IsUnicode(false);

            modelBuilder.Entity<sc_jzsydiy>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_jzsydiy>()
                .Property(e => e.QueId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_jzsydiy>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_jzsydiy>()
                .Property(e => e.SubjectLevelOneName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_jzsydiy>()
                .Property(e => e.SubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_loginhistory>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_loginhistory>()
                .Property(e => e.SessionId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_logs>()
                .Property(e => e.ObjectType)
                .IsUnicode(false);

            modelBuilder.Entity<sc_logs>()
                .Property(e => e.OperaterType)
                .IsUnicode(false);

            modelBuilder.Entity<sc_logs>()
                .Property(e => e.OperateName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_logs>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<sc_logs>()
                .Property(e => e.UrlPath)
                .IsUnicode(false);

            modelBuilder.Entity<sc_logs>()
                .Property(e => e.OperaterDescribe)
                .IsUnicode(false);

            modelBuilder.Entity<sc_logs>()
                .Property(e => e.ClientBrowserInfo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_module>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_module>()
                .Property(e => e.ModuleName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_module>()
                .Property(e => e.ModuleCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_module>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_notice>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<sc_notice>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<sc_notice>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_notice>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_onepersonpneaccountsupport>()
                .Property(e => e.ClientID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_onepersonpneaccountsupport>()
                .Property(e => e.ClientIP)
                .IsUnicode(false);

            modelBuilder.Entity<sc_onepersonpneaccountsupport>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_onepersonpneaccountsupport>()
                .Property(e => e.BrowserInfo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_order>()
                .Property(e => e.OrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_order>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_order>()
                .Property(e => e.DiscountCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_order>()
                .Property(e => e.OrderPrice)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_order>()
                .Property(e => e.TicketHead)
                .IsUnicode(false);

            modelBuilder.Entity<sc_order>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sc_order>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<sc_order>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<sc_order>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<sc_orderlog>()
                .Property(e => e.OrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_orderlog>()
                .Property(e => e.RequestData)
                .IsUnicode(false);

            modelBuilder.Entity<sc_orderlog>()
                .Property(e => e.ResponseData)
                .IsUnicode(false);

            modelBuilder.Entity<sc_phonecode>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<sc_phonecode>()
                .Property(e => e.SMSCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_phonecode>()
                .Property(e => e.SMSType)
                .IsUnicode(false);

            modelBuilder.Entity<sc_picvalidatecode>()
                .Property(e => e.ValidateCodeKey)
                .IsUnicode(false);

            modelBuilder.Entity<sc_picvalidatecode>()
                .Property(e => e.ValidateCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_picvalidatecode>()
                .Property(e => e.ValidateCodeType)
                .IsUnicode(false);

            modelBuilder.Entity<sc_picvalidatecode>()
                .Property(e => e.ClientIp)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profit>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profitanswer>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profitanswer>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profitanswer>()
                .Property(e => e.AnswerContent)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profititem>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profititem>()
                .Property(e => e.ItemFrom)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profititem>()
                .Property(e => e.ItemType)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profititem>()
                .Property(e => e.Pistion)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profititem>()
                .Property(e => e.Method)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profititem>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<sc_profititem>()
                .Property(e => e.Rule)
                .IsUnicode(false);

            modelBuilder.Entity<sc_reset>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_reset>()
                .Property(e => e.ResetType)
                .IsUnicode(false);

            modelBuilder.Entity<sc_reset>()
                .Property(e => e.ResetDataJsonBackup)
                .IsUnicode(false);

            modelBuilder.Entity<sc_reset>()
                .Property(e => e.RunSql)
                .IsUnicode(false);

            modelBuilder.Entity<sc_reset>()
                .Property(e => e.OperaterResult)
                .IsUnicode(false);

            modelBuilder.Entity<sc_school>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_school>()
                .Property(e => e.SchoolFullName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_school>()
                .Property(e => e.SchoolName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_school>()
                .Property(e => e.SchoolCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_school>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subject>()
                .Property(e => e.CompanyID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subject>()
                .Property(e => e.ParentNodeID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subject>()
                .Property(e => e.NodeID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subject>()
                .Property(e => e.SubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subject>()
                .Property(e => e.SubjectNameForDiy)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subject>()
                .Property(e => e.AmountBorrow)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_subject>()
                .Property(e => e.AmountLoan)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_subject>()
                .Property(e => e.DirectRule)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subject>()
                .Property(e => e.DirectCalc)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subject>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.ParentSubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.SubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.SubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.SubjectNameForDiy)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.DirectRule)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.DirectPreCalc)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.DirectRemainCalc)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.AmountPreBorrow)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.AmountPreLoan)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.AmountNowBorrow)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.AmountNowLoan)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.AmountRemainBorrow)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.AmountRemainLoan)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_subjectremain>()
                .Property(e => e.Lastedit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subsummary>()
                .Property(e => e.Caseid)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subsummary>()
                .Property(e => e.Subjectname)
                .IsUnicode(false);

            modelBuilder.Entity<sc_subsummary>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount>()
                .Property(e => e.SubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount>()
                .Property(e => e.Amount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_taccount>()
                .Property(e => e.Direct)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount_user>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount_user>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount_user>()
                .Property(e => e.SubjectName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount_user>()
                .Property(e => e.VoucherNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount_user>()
                .Property(e => e.Amount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_taccount_user>()
                .Property(e => e.Direct)
                .IsUnicode(false);

            modelBuilder.Entity<sc_taccount_user>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_tie>()
                .Property(e => e.SchoolNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_tie>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<sc_tie>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<sc_tie>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.NickName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.ActivationNo)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.MobileNumber)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.SchoolId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.UserRoleId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.UserTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.StudentID)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.LastLoginBrowser)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.LastLoginIp)
                .IsUnicode(false);

            modelBuilder.Entity<sc_user>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraccansmanual>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraccansmanual>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraccansmanual>()
                .Property(e => e.PeriodId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraccansmanual>()
                .Property(e => e.QueId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraccviewanalysismanual>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraccviewanalysismanual>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraccviewanalysismanual>()
                .Property(e => e.PeriodId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraccviewanalysismanual>()
                .Property(e => e.QueId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraddress>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraddress>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraddress>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraddress>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<sc_useraddress>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sc_userrole>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_userrole>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_usersubjectperiodinitanswerrecord>()
                .Property(e => e.AnsId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_usersubjectperiodinitanswerrecord>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_usersubjectperiodinitanswerrecord>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_usersubjectperiodinitanswerrecord>()
                .Property(e => e.SubjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<sc_usersubjectperiodinitanswerrecord>()
                .Property(e => e.BorrowAnswer)
                .HasPrecision(14, 2);

            modelBuilder.Entity<sc_usersubjectperiodinitanswerrecord>()
                .Property(e => e.LoanAnswer)
                .HasPrecision(14, 2);

            modelBuilder.Entity<sc_usertype>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_usertype>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_usertype>()
                .Property(e => e.TypeDesc)
                .IsUnicode(false);

            modelBuilder.Entity<sc_usertype>()
                .Property(e => e.LastEdit)
                .IsUnicode(false);

            modelBuilder.Entity<tax_answer>()
                .Property(e => e.WZNo)
                .IsUnicode(false);

            modelBuilder.Entity<tax_answer>()
                .Property(e => e.HNo)
                .IsUnicode(false);

            modelBuilder.Entity<tax_answer>()
                .Property(e => e.HValue)
                .IsUnicode(false);

            modelBuilder.Entity<tax_answer>()
                .Property(e => e.LNo)
                .IsUnicode(false);

            modelBuilder.Entity<tax_answer>()
                .Property(e => e.LValue)
                .IsUnicode(false);

            modelBuilder.Entity<tax_answer>()
                .Property(e => e.AnswerContent)
                .IsUnicode(false);

            modelBuilder.Entity<tax_answer>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<tax_answer>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<tax_answer>()
                .Property(e => e.Special)
                .IsUnicode(false);

            modelBuilder.Entity<tax_answer>()
                .Property(e => e.FrontLoad)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.TaxType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.LogoImg)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.DiscernNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.OrganName)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.SysTime)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<tax_case>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<tax_credentials>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tax_credentials>()
                .Property(e => e.Rate)
                .IsUnicode(false);

            modelBuilder.Entity<tax_credentials>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<tax_credentials>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<tax_project>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tax_project>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<tax_project>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<tax_rate>()
                .Property(e => e.Per)
                .IsUnicode(false);

            modelBuilder.Entity<tax_rate>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<tax_rate>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tax_rate>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<tax_rate>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<tax_time>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tax_time>()
                .Property(e => e.Quarter)
                .IsUnicode(false);

            modelBuilder.Entity<tax_time>()
                .Property(e => e.Year)
                .IsUnicode(false);

            modelBuilder.Entity<tax_time>()
                .Property(e => e.Month)
                .IsUnicode(false);

            modelBuilder.Entity<tax_time>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<tax_time>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<tax_topic>()
                .Property(e => e.TaxType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_topic>()
                .Property(e => e.TableType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_topic>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tax_topic>()
                .Property(e => e.Adder)
                .IsUnicode(false);

            modelBuilder.Entity<tax_topic>()
                .Property(e => e.Editer)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.TableType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.WZNo)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.HNo)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.HValue)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.LNo)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.LValue)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.AnswerContent)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.Special)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.RowSpan)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.ColSpan)
                .IsUnicode(false);

            modelBuilder.Entity<tax_useranswer>()
                .Property(e => e.FrontLoad)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userlook>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userperiod>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userperiod>()
                .Property(e => e.Year)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userperiod>()
                .Property(e => e.Month)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userperiod>()
                .Property(e => e.TaxType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userperiod>()
                .Property(e => e.TableType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userquarter>()
                .Property(e => e.TimeNo)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userquarter>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userquarter>()
                .Property(e => e.Year)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userquarter>()
                .Property(e => e.Quarter)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userquarter>()
                .Property(e => e.TaxType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userquarter>()
                .Property(e => e.TableType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userreport>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userreport>()
                .Property(e => e.TableType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userreport>()
                .Property(e => e.HValue)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userreport>()
                .Property(e => e.LValue)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userreport>()
                .Property(e => e.AnswerContent)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userreport>()
                .Property(e => e.RowSpan)
                .IsUnicode(false);

            modelBuilder.Entity<tax_userreport>()
                .Property(e => e.ColSpan)
                .IsUnicode(false);

            modelBuilder.Entity<tax_usertopic>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<tax_usertopic>()
                .Property(e => e.Quarter)
                .IsUnicode(false);

            modelBuilder.Entity<tax_usertopic>()
                .Property(e => e.Year)
                .IsUnicode(false);

            modelBuilder.Entity<tax_usertopic>()
                .Property(e => e.Month)
                .IsUnicode(false);

            modelBuilder.Entity<tax_usertopic>()
                .Property(e => e.TaxType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_usertopic>()
                .Property(e => e.TableType)
                .IsUnicode(false);

            modelBuilder.Entity<tax_usertopic>()
                .Property(e => e.DeclareTime)
                .IsUnicode(false);

            modelBuilder.Entity<tax_usertopic>()
                .Property(e => e.TaxTime)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.TypeId)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.CourseId)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.Flag)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.ArcRank)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.VodName)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.shorttitle)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.writer)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.source)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.litpic)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.keywords)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.filename)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.dutyadmin)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<vod_archives>()
                .Property(e => e.LastEditorUserName)
                .IsUnicode(false);

            modelBuilder.Entity<vod_arctype>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<vod_arctype>()
                .Property(e => e.ReId)
                .IsUnicode(false);

            modelBuilder.Entity<vod_arctype>()
                .Property(e => e.TopId)
                .IsUnicode(false);

            modelBuilder.Entity<vod_arctype>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<vod_arctype>()
                .Property(e => e.TypeDir)
                .IsUnicode(false);

            modelBuilder.Entity<vod_arctype>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<vod_arctype>()
                .Property(e => e.KeyWords)
                .IsUnicode(false);

            modelBuilder.Entity<vod_arctype>()
                .Property(e => e.SeoTitle)
                .IsUnicode(false);

            modelBuilder.Entity<vod_arctype>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<vod_arctype>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansgeneralledgermanual>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansgeneralledgermanual>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansgeneralledgermanual>()
                .Property(e => e.QueId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansgeneralledgermanual>()
                .Property(e => e.SubjectId)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansgeneralledgermanual>()
                .Property(e => e.VoucherNumber)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansgeneralledgermanual>()
                .Property(e => e.UserAnswerAbsname)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansgeneralledgermanual>()
                .Property(e => e.UserAnswerBrowerMoney)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_accountansgeneralledgermanual>()
                .Property(e => e.UserAnswerLoanMoney)
                .HasPrecision(12, 2);

            modelBuilder.Entity<sc_accountansgeneralledgermanual>()
                .Property(e => e.UserLoanType)
                .IsUnicode(false);

            modelBuilder.Entity<sc_accountansgeneralledgermanual>()
                .Property(e => e.Balance)
                .HasPrecision(12, 2);
        }
    }
}
