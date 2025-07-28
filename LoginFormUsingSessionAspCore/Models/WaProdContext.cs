using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoginFormUsingSessionAspCore.Models;

public partial class WaProdContext : DbContext
{
    public WaProdContext()
    {
    }

    public WaProdContext(DbContextOptions<WaProdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<ActivityHistory> ActivityHistories { get; set; }

    public virtual DbSet<CentralStudent> CentralStudents { get; set; }

    public virtual DbSet<DeMeritEvent> DeMeritEvents { get; set; }

    public virtual DbSet<DeMeritEventsHistory> DeMeritEventsHistories { get; set; }

    public virtual DbSet<DeMeritType> DeMeritTypes { get; set; }

    public virtual DbSet<DeMeritWorkOffEvent> DeMeritWorkOffEvents { get; set; }

    public virtual DbSet<DeMeritWorkOffEventsHistory> DeMeritWorkOffEventsHistories { get; set; }

    public virtual DbSet<DeMeritWorkOffType> DeMeritWorkOffTypes { get; set; }

    public virtual DbSet<DemForSatDetV> DemForSatDetVs { get; set; }

    public virtual DbSet<DemeritsV> DemeritsVs { get; set; }

    public virtual DbSet<EventSummary2V> EventSummary2Vs { get; set; }

    public virtual DbSet<EventSummaryV> EventSummaryVs { get; set; }

    public virtual DbSet<GlobalVariable> GlobalVariables { get; set; }

    public virtual DbSet<HistoryTotalDemeritsV> HistoryTotalDemeritsVs { get; set; }

    public virtual DbSet<HistoryTotalHwcattendanceV> HistoryTotalHwcattendanceVs { get; set; }

    public virtual DbSet<HistoryTotalLateHwsV> HistoryTotalLateHwsVs { get; set; }

    public virtual DbSet<HistoryTotalMeritsV> HistoryTotalMeritsVs { get; set; }

    public virtual DbSet<HistoryTotalSatAttDetV> HistoryTotalSatAttDetVs { get; set; }

    public virtual DbSet<HistoryTotalWodemeritsV> HistoryTotalWodemeritsVs { get; set; }

    public virtual DbSet<Homeroom> Homerooms { get; set; }

    public virtual DbSet<HomeroomsHistory> HomeroomsHistories { get; set; }

    public virtual DbSet<HomeworkClubAttendance> HomeworkClubAttendances { get; set; }

    public virtual DbSet<HomeworkClubAttendanceHistory> HomeworkClubAttendanceHistories { get; set; }

    public virtual DbSet<House> Houses { get; set; }

    public virtual DbSet<HouseMeritsTotalV> HouseMeritsTotalVs { get; set; }

    public virtual DbSet<HousesHistory> HousesHistories { get; set; }

    public virtual DbSet<LateHomework> LateHomeworks { get; set; }

    public virtual DbSet<LateHomeworksHistory> LateHomeworksHistories { get; set; }

    public virtual DbSet<LateHomeworksV> LateHomeworksVs { get; set; }

    public virtual DbSet<LunchOrder> LunchOrders { get; set; }

    public virtual DbSet<Lunchorders24Mar2023> Lunchorders24Mar2023s { get; set; }

    public virtual DbSet<Meal> Meals { get; set; }

    public virtual DbSet<Meals24Mar2023> Meals24Mar2023s { get; set; }

    public virtual DbSet<MeritEvent> MeritEvents { get; set; }

    public virtual DbSet<MeritEventsHistory> MeritEventsHistories { get; set; }

    public virtual DbSet<MeritType> MeritTypes { get; set; }

    public virtual DbSet<MeritWinnersV> MeritWinnersVs { get; set; }

    public virtual DbSet<MeritsV> MeritsVs { get; set; }

    public virtual DbSet<OrderPaymentDetail> OrderPaymentDetails { get; set; }

    public virtual DbSet<PizzaLunchOrder> PizzaLunchOrders { get; set; }

    public virtual DbSet<PizzaMeal> PizzaMeals { get; set; }

    public virtual DbSet<PizzaOrderPaymentDetail> PizzaOrderPaymentDetails { get; set; }

    public virtual DbSet<SatDetAttendance> SatDetAttendances { get; set; }

    public virtual DbSet<SatDetAttendanceHistory> SatDetAttendanceHistories { get; set; }

    public virtual DbSet<SatDetList> SatDetLists { get; set; }

    public virtual DbSet<SatDetListHistory> SatDetListHistories { get; set; }

    public virtual DbSet<SatDetListV> SatDetListVs { get; set; }

    public virtual DbSet<SatDetRemV> SatDetRemVs { get; set; }

    public virtual DbSet<ShopProductCart> ShopProductCarts { get; set; }

    public virtual DbSet<ShopProductPaymentDetail> ShopProductPaymentDetails { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentInfo> StudentInfos { get; set; }

    public virtual DbSet<StudentTotalsAllV> StudentTotalsAllVs { get; set; }

    public virtual DbSet<StudentTotalsAllVhistory> StudentTotalsAllVhistories { get; set; }

    public virtual DbSet<Students08nov24> Students08nov24s { get; set; }

    public virtual DbSet<StudentsHistory> StudentsHistories { get; set; }

    public virtual DbSet<TblActivityTeam> TblActivityTeams { get; set; }

    public virtual DbSet<TblActivityTeamHistory> TblActivityTeamHistories { get; set; }

    public virtual DbSet<TblAttendanceEntry> TblAttendanceEntries { get; set; }

    public virtual DbSet<TblAttendanceEntryHistory> TblAttendanceEntryHistories { get; set; }

    public virtual DbSet<TblBookLunchText> TblBookLunchTexts { get; set; }

    public virtual DbSet<TblCheckFileLayoutLunch> TblCheckFileLayoutLunches { get; set; }

    public virtual DbSet<TblClassRoom> TblClassRooms { get; set; }

    public virtual DbSet<TblCompany> TblCompanies { get; set; }

    public virtual DbSet<TblDeletedPizzaLunchOrder> TblDeletedPizzaLunchOrders { get; set; }

    public virtual DbSet<TblDepartment> TblDepartments { get; set; }

    public virtual DbSet<TblDocument> TblDocuments { get; set; }

    public virtual DbSet<TblDocumentType> TblDocumentTypes { get; set; }

    public virtual DbSet<TblEmailContent> TblEmailContents { get; set; }

    public virtual DbSet<TblEntryAttendanceInOutLog> TblEntryAttendanceInOutLogs { get; set; }

    public virtual DbSet<TblEntryAttendanceStillInV> TblEntryAttendanceStillInVs { get; set; }

    public virtual DbSet<TblEntryAttendanceStillOutV> TblEntryAttendanceStillOutVs { get; set; }

    public virtual DbSet<TblEquipment> TblEquipments { get; set; }

    public virtual DbSet<TblEvent> TblEvents { get; set; }

    public virtual DbSet<TblEvent24feb25> TblEvent24feb25s { get; set; }

    public virtual DbSet<TblEventHistory> TblEventHistories { get; set; }

    public virtual DbSet<TblEventType> TblEventTypes { get; set; }

    public virtual DbSet<TblEventTypeHistory> TblEventTypeHistories { get; set; }

    public virtual DbSet<TblGroup> TblGroups { get; set; }

    public virtual DbSet<TblGroupHistory> TblGroupHistories { get; set; }

    public virtual DbSet<TblInOutLog> TblInOutLogs { get; set; }

    public virtual DbSet<TblInOutLogHistory> TblInOutLogHistories { get; set; }

    public virtual DbSet<TblLeaveRequest> TblLeaveRequests { get; set; }

    public virtual DbSet<TblLocation> TblLocations { get; set; }

    public virtual DbSet<TblLogEmail> TblLogEmails { get; set; }

    public virtual DbSet<TblLunchOrderHistory> TblLunchOrderHistories { get; set; }

    public virtual DbSet<TblLunchSemesterDate> TblLunchSemesterDates { get; set; }

    public virtual DbSet<TblMealHistory> TblMealHistories { get; set; }

    public virtual DbSet<TblMeet> TblMeets { get; set; }

    public virtual DbSet<TblMeetType> TblMeetTypes { get; set; }

    public virtual DbSet<TblMeetsHistory> TblMeetsHistories { get; set; }

    public virtual DbSet<TblMenuAccess> TblMenuAccesses { get; set; }

    public virtual DbSet<TblMenuMaster> TblMenuMasters { get; set; }

    public virtual DbSet<TblMenuMaster20dec2024> TblMenuMaster20dec2024s { get; set; }

    public virtual DbSet<TblOrder> TblOrders { get; set; }

    public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; }

    public virtual DbSet<TblOrderPaymentDetailHistory> TblOrderPaymentDetailHistories { get; set; }

    public virtual DbSet<TblPizzaLunchOrderHistory> TblPizzaLunchOrderHistories { get; set; }

    public virtual DbSet<TblPizzaMealHistory> TblPizzaMealHistories { get; set; }

    public virtual DbSet<TblPizzaOrder> TblPizzaOrders { get; set; }

    public virtual DbSet<TblPizzaOrderPaymentDetailHistory> TblPizzaOrderPaymentDetailHistories { get; set; }

    public virtual DbSet<TblPizzaSemesterDate> TblPizzaSemesterDates { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblQualification> TblQualifications { get; set; }

    public virtual DbSet<TblReason> TblReasons { get; set; }

    public virtual DbSet<TblRequirement> TblRequirements { get; set; }

    public virtual DbSet<TblResult> TblResults { get; set; }

    public virtual DbSet<TblSetting> TblSettings { get; set; }

    public virtual DbSet<TblShopProduct> TblShopProducts { get; set; }

    public virtual DbSet<TblShopProductInventory> TblShopProductInventories { get; set; }

    public virtual DbSet<TblShopProductSchoolOrder> TblShopProductSchoolOrders { get; set; }

    public virtual DbSet<TblSportAttendance> TblSportAttendances { get; set; }

    public virtual DbSet<TblSportAttendanceHistory> TblSportAttendanceHistories { get; set; }

    public virtual DbSet<TblStillInV> TblStillInVs { get; set; }

    public virtual DbSet<TblStillOutV> TblStillOutVs { get; set; }

    public virtual DbSet<TblStudentAccessDatum> TblStudentAccessData { get; set; }

    public virtual DbSet<TblStudentAssignedSubject> TblStudentAssignedSubjects { get; set; }

    public virtual DbSet<TblStudentRequirement> TblStudentRequirements { get; set; }

    public virtual DbSet<TblSubMenuMaster> TblSubMenuMasters { get; set; }

    public virtual DbSet<TblSubMenuMaster27Sep2024> TblSubMenuMaster27Sep2024s { get; set; }

    public virtual DbSet<TblSubject> TblSubjects { get; set; }

    public virtual DbSet<TblTempActivityTeam> TblTempActivityTeams { get; set; }

    public virtual DbSet<TblTempMeal> TblTempMeals { get; set; }

    public virtual DbSet<TblTempPizzaMeal> TblTempPizzaMeals { get; set; }

    public virtual DbSet<TblTempResult> TblTempResults { get; set; }

    public virtual DbSet<TblTempSubject> TblTempSubjects { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblWebHooksPaymentDetail> TblWebHooksPaymentDetails { get; set; }

    public virtual DbSet<TblWebHooksPaymentDetailTemp> TblWebHooksPaymentDetailTemps { get; set; }

    public virtual DbSet<TblWeek> TblWeeks { get; set; }

    public virtual DbSet<TblWeightRoomGuestLogin> TblWeightRoomGuestLogins { get; set; }

    public virtual DbSet<TblWeightRoomInOutLog> TblWeightRoomInOutLogs { get; set; }

    public virtual DbSet<TblWeightRoomInOutLogHistory> TblWeightRoomInOutLogHistories { get; set; }

    public virtual DbSet<TblWeightRoomStudentStaffLogin> TblWeightRoomStudentStaffLogins { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeacherCountV> TeacherCountVs { get; set; }

    public virtual DbSet<TempPayDetail> TempPayDetails { get; set; }

    public virtual DbSet<TempStudent> TempStudents { get; set; }

    public virtual DbSet<TotalDemeritsTeacherV> TotalDemeritsTeacherVs { get; set; }

    public virtual DbSet<TotalDemeritsV> TotalDemeritsVs { get; set; }

    public virtual DbSet<TotalHwcattendanceV> TotalHwcattendanceVs { get; set; }

    public virtual DbSet<TotalHwcattendanceV1> TotalHwcattendanceV1s { get; set; }

    public virtual DbSet<TotalLateHwsTeacherV> TotalLateHwsTeacherVs { get; set; }

    public virtual DbSet<TotalLateHwsV> TotalLateHwsVs { get; set; }

    public virtual DbSet<TotalLateHwsV1> TotalLateHwsV1s { get; set; }

    public virtual DbSet<TotalMeritsTeacherV> TotalMeritsTeacherVs { get; set; }

    public virtual DbSet<TotalMeritsV> TotalMeritsVs { get; set; }

    public virtual DbSet<TotalSatAttDetV> TotalSatAttDetVs { get; set; }

    public virtual DbSet<TotalWodemeritsTeacherV> TotalWodemeritsTeacherVs { get; set; }

    public virtual DbSet<TotalWodemeritsV> TotalWodemeritsVs { get; set; }

    public virtual DbSet<TransactionResponse> TransactionResponses { get; set; }

    public virtual DbSet<VwActivityTeacherName> VwActivityTeacherNames { get; set; }

    public virtual DbSet<VwAllDatum> VwAllData { get; set; }

    public virtual DbSet<VwChampionQ> VwChampionQs { get; set; }

    public virtual DbSet<VwChampionQPre> VwChampionQPres { get; set; }

    public virtual DbSet<VwColumnsPdf> VwColumnsPdfs { get; set; }

    public virtual DbSet<VwDetailedExamSchedule> VwDetailedExamSchedules { get; set; }

    public virtual DbSet<VwEventPointCupQ> VwEventPointCupQs { get; set; }

    public virtual DbSet<VwEventPointsQ> VwEventPointsQs { get; set; }

    public virtual DbSet<VwGroupQ> VwGroupQs { get; set; }

    public virtual DbSet<VwListofActivity> VwListofActivities { get; set; }

    public virtual DbSet<VwMealsOrder> VwMealsOrders { get; set; }

    public virtual DbSet<VwMealsOrderd> VwMealsOrderds { get; set; }

    public virtual DbSet<VwNumberOfParticipant> VwNumberOfParticipants { get; set; }

    public virtual DbSet<VwNumberOfStudentsInHouse> VwNumberOfStudentsInHouses { get; set; }

    public virtual DbSet<VwOrderPlacementReport> VwOrderPlacementReports { get; set; }

    public virtual DbSet<VwPizzaOrder> VwPizzaOrders { get; set; }

    public virtual DbSet<VwPrintPizzaStickerForTeacherInfo> VwPrintPizzaStickerForTeacherInfos { get; set; }

    public virtual DbSet<VwPrintPizzaStickerInfo> VwPrintPizzaStickerInfos { get; set; }

    public virtual DbSet<VwPrintPizzaStickerInfoOld> VwPrintPizzaStickerInfoOlds { get; set; }

    public virtual DbSet<VwPrintStickerForTeacherInfo> VwPrintStickerForTeacherInfos { get; set; }

    public virtual DbSet<VwPrintStickerInfo> VwPrintStickerInfos { get; set; }

    public virtual DbSet<VwPrintStickerTeacherInfo> VwPrintStickerTeacherInfos { get; set; }

    public virtual DbSet<VwShopProductCart> VwShopProductCarts { get; set; }

    public virtual DbSet<VwSportMeritStudent> VwSportMeritStudents { get; set; }

    public virtual DbSet<VwStudentAttendanceSupportLounge> VwStudentAttendanceSupportLounges { get; set; }

    public virtual DbSet<VwStudentDetail> VwStudentDetails { get; set; }

    public virtual DbSet<VwStudentLunchCandidate> VwStudentLunchCandidates { get; set; }

    public virtual DbSet<VwStudentPizzaCandidate> VwStudentPizzaCandidates { get; set; }

    public virtual DbSet<VwTblResult> VwTblResults { get; set; }

    public virtual DbSet<VwTblShopProduct> VwTblShopProducts { get; set; }

    public virtual DbSet<VwTblShopProductInventory> VwTblShopProductInventories { get; set; }

    public virtual DbSet<VwTblWeightRoomInOutLog> VwTblWeightRoomInOutLogs { get; set; }

    public virtual DbSet<VwTblorder> VwTblorders { get; set; }

    public virtual DbSet<VwTeacherLunchCandidate> VwTeacherLunchCandidates { get; set; }

    public virtual DbSet<VwTeacherPizzaCandidate> VwTeacherPizzaCandidates { get; set; }

    public virtual DbSet<WorkOffDeMeritsV> WorkOffDeMeritsVs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-O0QQ0V87;Database=WA_Prod;User Id=sa;Password=sqlserver2008;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("PK__Activity__45F4A7F1F1A37161");

            entity.ToTable("Activity");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsArchived).HasDefaultValue(false);
            entity.Property(e => e.TeacherId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TeacherID");
            entity.Property(e => e.Term).HasMaxLength(25);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ActivityHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ActivityHistory");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsArchived).HasDefaultValue(false);
            entity.Property(e => e.SessionYear)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.TeacherId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TeacherID");
        });

        modelBuilder.Entity<CentralStudent>(entity =>
        {
            entity.HasKey(e => e.StudentCentralId).HasName("Students$PrimaryKey");

            entity.Property(e => e.StudentCentralId).HasColumnName("StudentCentralID");
            entity.Property(e => e.Dob)
                .HasPrecision(0)
                .HasColumnName("DOB");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HomeroomName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.ParentEmail).HasMaxLength(255);
            entity.Property(e => e.RegGroup)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SchoolIssuedId)
                .HasMaxLength(255)
                .HasColumnName("SchoolIssuedID");
            entity.Property(e => e.StudentGender).HasMaxLength(255);
            entity.Property(e => e.YearGroup)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<DeMeritEvent>(entity =>
        {
            entity.HasKey(e => e.DemeritEventId).HasName("DeMeritEvents$DeMeritEvents$DeMeritEvents$PrimaryKey");

            entity.Property(e => e.DemeritEventId).HasColumnName("DemeritEventID");
            entity.Property(e => e.DateEntered)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");
            entity.Property(e => e.DeMeritTypeId).HasColumnName("DeMeritTypeID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

            entity.HasOne(d => d.DeMeritType).WithMany(p => p.DeMeritEvents)
                .HasForeignKey(d => d.DeMeritTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("DeMeritEvents$DeMeritTypesDeMeritEvents");

            entity.HasOne(d => d.Student).WithMany(p => p.DeMeritEvents)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("DeMeritEvents$StudentsDeMeritEvents");

            entity.HasOne(d => d.Teacher).WithMany(p => p.DeMeritEvents)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("DeMeritEvents$TeachersDeMeritEvents");
        });

        modelBuilder.Entity<DeMeritEventsHistory>(entity =>
        {
            entity.HasKey(e => e.DemeritEventHistoryId).HasName("PK__DeMeritE__E6B58A06B71ED880");

            entity.ToTable("DeMeritEventsHistory");

            entity.Property(e => e.DemeritEventHistoryId).HasColumnName("DemeritEventHistoryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.DeMeritTypeId).HasColumnName("DeMeritTypeID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<DeMeritType>(entity =>
        {
            entity.HasKey(e => e.DemeritTypeId).HasName("DeMeritTypes$DeMeritTypes$DeMeritTypes$PrimaryKey");

            entity.Property(e => e.DemeritTypeId).HasColumnName("DemeritTypeID");
            entity.Property(e => e.DeMeritCode).HasMaxLength(15);
            entity.Property(e => e.DemeritDescription).HasMaxLength(50);
        });

        modelBuilder.Entity<DeMeritWorkOffEvent>(entity =>
        {
            entity.HasKey(e => e.DemeritWorkOffEventId).HasName("DeMeritWorkOffEvents$DeMeritWorkOffEvents$DeMeritWorkOffEvents$PrimaryKey");

            entity.Property(e => e.DemeritWorkOffEventId).HasColumnName("DemeritWorkOffEventID");
            entity.Property(e => e.DateEntered)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");
            entity.Property(e => e.DeMeritWorkOffTypeId).HasColumnName("DeMeritWorkOffTypeID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

            entity.HasOne(d => d.DeMeritWorkOffType).WithMany(p => p.DeMeritWorkOffEvents)
                .HasForeignKey(d => d.DeMeritWorkOffTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("DeMeritWorkOffEvents$DeMeritWorkOffTypesDeMeritWorkOffEvents");

            entity.HasOne(d => d.Student).WithMany(p => p.DeMeritWorkOffEvents)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("DeMeritWorkOffEvents$StudentsDeMeritWorkOffEvents");

            entity.HasOne(d => d.Teacher).WithMany(p => p.DeMeritWorkOffEvents)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("DeMeritWorkOffEvents$TeachersDeMeritWorkOffEvents");
        });

        modelBuilder.Entity<DeMeritWorkOffEventsHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DeMeritWorkOffEventsHistory");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.DeMeritWorkOffTypeId).HasColumnName("DeMeritWorkOffTypeID");
            entity.Property(e => e.DemeritWorkOffEventHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DemeritWorkOffEventHistoryID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<DeMeritWorkOffType>(entity =>
        {
            entity.HasKey(e => e.DemeritWorkOffTypeId).HasName("DeMeritWorkOffTypes$DeMeritWorkOffTypes$DeMeritWorkOffTypes$PrimaryKey");

            entity.Property(e => e.DemeritWorkOffTypeId).HasColumnName("DemeritWorkOffTypeID");
            entity.Property(e => e.WorkOffCode).HasMaxLength(10);
            entity.Property(e => e.WorkOffDescription).HasMaxLength(50);
        });

        modelBuilder.Entity<DemForSatDetV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DemForSatDetV");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<DemeritsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DemeritsV");

            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.Teacher).HasMaxLength(511);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.Type)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventSummary2V>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EventSummary2V");

            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.Teacher).HasMaxLength(511);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.Type)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventSummaryV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EventSummaryV");

            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.Teacher).HasMaxLength(511);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.Type)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GlobalVariable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GlobalVa__3214EC27A8B8E375");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(200)
                .HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<HistoryTotalDemeritsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HistoryTotalDemeritsV");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<HistoryTotalHwcattendanceV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HistoryTotalHWCAttendanceV");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<HistoryTotalLateHwsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HistoryTotalLateHWsV");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<HistoryTotalMeritsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HistoryTotalMeritsV");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<HistoryTotalSatAttDetV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HistoryTotalSatAttDetV");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<HistoryTotalWodemeritsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HistoryTotalWODemeritsV");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Woapplied).HasColumnName("WOApplied");
        });

        modelBuilder.Entity<Homeroom>(entity =>
        {
            entity.HasKey(e => e.HomeroomId).HasName("Homerooms$Homerooms$Homerooms$PrimaryKey");

            entity.Property(e => e.HomeroomId).HasColumnName("HomeroomID");
            entity.Property(e => e.HomeroomCode).HasMaxLength(255);
        });

        modelBuilder.Entity<HomeroomsHistory>(entity =>
        {
            entity.HasKey(e => e.HomeroomsHistoryid).HasName("PK__Homeroom__DAADADD958CBF574");

            entity.ToTable("HomeroomsHistory");

            entity.Property(e => e.DeletedOn)
                .HasColumnType("datetime")
                .HasColumnName("deletedOn");
            entity.Property(e => e.Deletedby)
                .HasMaxLength(200)
                .HasColumnName("deletedby");
            entity.Property(e => e.HomeroomCode).HasMaxLength(255);
            entity.Property(e => e.HomeroomId).HasColumnName("HomeroomID");
        });

        modelBuilder.Entity<HomeworkClubAttendance>(entity =>
        {
            entity.HasKey(e => e.HomeworkCludAttendId).HasName("HomeworkClubAttendance$PrimaryKey");

            entity.ToTable("HomeworkClubAttendance");

            entity.Property(e => e.HomeworkCludAttendId).HasColumnName("HomeworkCludAttendID");
            entity.Property(e => e.AttendanceDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

            entity.HasOne(d => d.Student).WithMany(p => p.HomeworkClubAttendances)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("HomeworkClubAttendance$StudentsHomeworkClubAttendance");

            entity.HasOne(d => d.Teacher).WithMany(p => p.HomeworkClubAttendances)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("HomeworkClubAttendance$TeachersHomeworkClubAttendance");
        });

        modelBuilder.Entity<HomeworkClubAttendanceHistory>(entity =>
        {
            entity.HasKey(e => e.HomeworkCludAttendHistoryId).HasName("PK__Homework__E2331600B44FE2F0");

            entity.ToTable("HomeworkClubAttendanceHistory");

            entity.Property(e => e.HomeworkCludAttendHistoryId).HasColumnName("HomeworkCludAttendHistoryID");
            entity.Property(e => e.AttendanceDate).HasPrecision(0);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);
        });

        modelBuilder.Entity<House>(entity =>
        {
            entity.HasKey(e => e.HouseId).HasName("Houses$Houses$Houses$PrimaryKey");

            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
        });

        modelBuilder.Entity<HouseMeritsTotalV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HouseMeritsTotalV");

            entity.Property(e => e.HouseName).HasMaxLength(255);
        });

        modelBuilder.Entity<HousesHistory>(entity =>
        {
            entity.HasKey(e => e.HousesHistoryId).HasName("PK__HousesHi__35BBA662C05EC4C9");

            entity.ToTable("HousesHistory");

            entity.Property(e => e.DeletedOn)
                .HasColumnType("datetime")
                .HasColumnName("deletedOn");
            entity.Property(e => e.Deletedby)
                .HasMaxLength(200)
                .HasColumnName("deletedby");
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
        });

        modelBuilder.Entity<LateHomework>(entity =>
        {
            entity.HasKey(e => e.LateHomeworkId).HasName("LateHomeworks$LateHomeworks$PK__LateHome__E297B81AF5FF6015");

            entity.Property(e => e.LateHomeworkId).HasColumnName("LateHomeworkID");
            entity.Property(e => e.DateEntered)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

            entity.HasOne(d => d.Student).WithMany(p => p.LateHomeworks)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_LateHomeworks_Students");
        });

        modelBuilder.Entity<LateHomeworksHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LateHomeworksHistory");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.LateHomeworkHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LateHomeworkHistoryID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<LateHomeworksV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LateHomeworksV");

            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.Description)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.LateHomeworkId).HasColumnName("LateHomeworkID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.Teacher).HasMaxLength(511);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.Type)
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LunchOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.IsOffline).HasDefaultValue(false);
            entity.Property(e => e.IsUpdatedOffline).HasDefaultValue(false);
            entity.Property(e => e.PricingType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentIdcard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StudentIDCard");
            entity.Property(e => e.TblWebHooksPaymentDetailId).HasColumnName("TblWebHooksPaymentDetail_Id");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Lunchorders24Mar2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lunchorders_24_mar_2023");

            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OrderID");
            entity.Property(e => e.PricingType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentIdcard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StudentIDCard");
        });

        modelBuilder.Entity<Meal>(entity =>
        {
            entity.HasKey(e => e.MeatTypeId);

            entity.Property(e => e.MeatTypeId).HasColumnName("MeatTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsArchive).HasDefaultValue(false);
            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MealDesc).HasColumnType("text");
            entity.Property(e => e.MealShortDesc).HasMaxLength(255);
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Week).HasMaxLength(255);
            entity.Property(e => e.WeekDay)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Meals24Mar2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("meals_24_mar_2023");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MealDesc).HasColumnType("text");
            entity.Property(e => e.MealShortDesc).HasMaxLength(255);
            entity.Property(e => e.MeatTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MeatTypeID");
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Week).HasMaxLength(255);
            entity.Property(e => e.WeekDay)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<MeritEvent>(entity =>
        {
            entity.HasKey(e => e.MeritEventId).HasName("MeritEvents$MeritEvents$MeritEvents$PrimaryKey");

            entity.Property(e => e.MeritEventId).HasColumnName("MeritEventID");
            entity.Property(e => e.DateEntered)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");
            entity.Property(e => e.MeritTypeId).HasColumnName("MeritTypeID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

            entity.HasOne(d => d.MeritType).WithMany(p => p.MeritEvents)
                .HasForeignKey(d => d.MeritTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("MeritEvents$MeritTypesMeritEvents");

            entity.HasOne(d => d.Student).WithMany(p => p.MeritEvents)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("MeritEvents$StudentsMeritEvents");

            entity.HasOne(d => d.Teacher).WithMany(p => p.MeritEvents)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("MeritEvents$TeachersMeritEvents");
        });

        modelBuilder.Entity<MeritEventsHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MeritEventsHistory");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.MeritEvenHistorytId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MeritEvenHistorytID");
            entity.Property(e => e.MeritTypeId).HasColumnName("MeritTypeID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MeritType>(entity =>
        {
            entity.HasKey(e => e.MeritTypeId).HasName("MeritTypes$MeritTypes$MeritTypes$PrimaryKey");

            entity.Property(e => e.MeritTypeId).HasColumnName("MeritTypeID");
            entity.Property(e => e.MeritCode).HasMaxLength(15);
            entity.Property(e => e.MeritDescription).HasMaxLength(50);
        });

        modelBuilder.Entity<MeritWinnersV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MeritWinnersV");

            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HomeroomCode).HasMaxLength(255);
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<MeritsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MeritsV");

            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.HomeroomCode).HasMaxLength(255);
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.MeritEventId).HasColumnName("MeritEventID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.Teacher).HasMaxLength(511);
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderPaymentDetail>(entity =>
        {
            entity.HasKey(e => e.OrderPaymentId);

            entity.HasIndex(e => new { e.StudentId, e.FromDate, e.ToDate }, "UQ_OrderPaymentDetails_StdID_FromDate_ToDate").IsUnique();

            entity.Property(e => e.OrderPaymentId).HasColumnName("OrderPaymentID");
            entity.Property(e => e.Cccvc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CCCVC");
            entity.Property(e => e.Ccmonth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCMonth");
            entity.Property(e => e.Ccname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCName");
            entity.Property(e => e.Ccnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCNumber");
            entity.Property(e => e.Ccyear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCYear");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullStudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HomeRoom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.PTotal).HasColumnName("pTotal");
            entity.Property(e => e.PayCash).HasDefaultValue(false);
            entity.Property(e => e.STotal).HasColumnName("sTotal");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<PizzaLunchOrder>(entity =>
        {
            entity.HasKey(e => e.PizzaOrderId);

            entity.ToTable(tb => tb.HasTrigger("trg_PizzaLunchOrders_Delete"));

            entity.Property(e => e.PizzaOrderId).HasColumnName("PizzaOrderID");
            entity.Property(e => e.IsOffline).HasDefaultValue(false);
            entity.Property(e => e.IsUpdatedOffline).HasDefaultValue(false);
            entity.Property(e => e.PizzaMealsTypeId).HasColumnName("PizzaMealsTypeID");
            entity.Property(e => e.PricingType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentIdcard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StudentIDCard");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<PizzaMeal>(entity =>
        {
            entity.HasKey(e => e.PizzaMealsTypeId);

            entity.Property(e => e.PizzaMealsTypeId).HasColumnName("PizzaMealsTypeID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsArchive).HasDefaultValue(false);
            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MealDesc).HasColumnType("text");
            entity.Property(e => e.MealShortDesc).HasMaxLength(255);
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Week).HasMaxLength(255);
            entity.Property(e => e.WeekDay)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<PizzaOrderPaymentDetail>(entity =>
        {
            entity.HasKey(e => e.PizzaOrderPaymentDetailsId);

            entity.HasIndex(e => new { e.StudentId, e.FromDate, e.ToDate }, "UQ_PizzaOrderPaymentDetails_StdID_FromDate_ToDate").IsUnique();

            entity.Property(e => e.PizzaOrderPaymentDetailsId).HasColumnName("PizzaOrderPaymentDetailsID");
            entity.Property(e => e.Cccvc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CCCVC");
            entity.Property(e => e.Ccmonth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCMonth");
            entity.Property(e => e.Ccname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCName");
            entity.Property(e => e.Ccnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCNumber");
            entity.Property(e => e.Ccyear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCYear");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullStudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HomeRoom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.PTotal).HasColumnName("pTotal");
            entity.Property(e => e.PayCash).HasDefaultValue(false);
            entity.Property(e => e.STotal).HasColumnName("sTotal");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<SatDetAttendance>(entity =>
        {
            entity.HasKey(e => e.SatDetAttendId).HasName("SatDetAttendance$PrimaryKey");

            entity.ToTable("SatDetAttendance");

            entity.Property(e => e.SatDetAttendId).HasColumnName("SatDetAttendID");
            entity.Property(e => e.AttendanceDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

            entity.HasOne(d => d.Student).WithMany(p => p.SatDetAttendances)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("SatDetAttendance$StudentsSatDetAttendance");

            entity.HasOne(d => d.Teacher).WithMany(p => p.SatDetAttendances)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("SatDetAttendance$TeachersSatDetAttendance");
        });

        modelBuilder.Entity<SatDetAttendanceHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SatDetAttendanceHistory");

            entity.Property(e => e.AttendanceDate).HasPrecision(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SatDetAttendHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SatDetAttendHistoryID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<SatDetList>(entity =>
        {
            entity.HasKey(e => e.SatDetId);

            entity.ToTable("SatDetList");

            entity.Property(e => e.SatDetId).HasColumnName("SatDetID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<SatDetListHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SatDetListHistory");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SatDetHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SatDetHistoryID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<SatDetListV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SatDetListV");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HomeroomCode).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.SatDetId).HasColumnName("SatDetID");
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.StudentHomeroomId).HasColumnName("StudentHomeroomID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<SatDetRemV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SatDetRemV");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HomeroomCode).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<ShopProductCart>(entity =>
        {
            entity.HasKey(e => e.CartProductId).HasName("PK__ShopProd__ABC4498350E07C44");

            entity.ToTable("ShopProductCart");

            entity.Property(e => e.CartProductId).HasColumnName("CartProductID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.OrderQuantity).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.OrderStatus).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.ProductSalePrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ProductSize).HasMaxLength(50);
            entity.Property(e => e.ShopProductId).HasColumnName("ShopProductID");
            entity.Property(e => e.ShopProductInventoryId).HasColumnName("ShopProductInventoryID");
            entity.Property(e => e.StudentCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.ShopProduct).WithMany(p => p.ShopProductCarts)
                .HasForeignKey(d => d.ShopProductId)
                .HasConstraintName("FK__ShopProdu__ShopP__290D0E62");

            entity.HasOne(d => d.ShopProductInventory).WithMany(p => p.ShopProductCarts)
                .HasForeignKey(d => d.ShopProductInventoryId)
                .HasConstraintName("FK__ShopProdu__ShopP__2A01329B");
        });

        modelBuilder.Entity<ShopProductPaymentDetail>(entity =>
        {
            entity.HasKey(e => e.ShopProductPaymentDetailsId).HasName("PK__ShopProd__5D9D5616D78377DF");

            entity.Property(e => e.ShopProductPaymentDetailsId).HasColumnName("ShopProductPaymentDetailsID");
            entity.Property(e => e.CartProductId).HasColumnName("CartProductID");
            entity.Property(e => e.Cccvc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CCCVC");
            entity.Property(e => e.Ccmonth)
                .HasMaxLength(100)
                .HasColumnName("CCMonth");
            entity.Property(e => e.Ccname)
                .HasMaxLength(100)
                .HasColumnName("CCName");
            entity.Property(e => e.Ccnumber)
                .HasMaxLength(100)
                .HasColumnName("CCNumber");
            entity.Property(e => e.Ccyear)
                .HasMaxLength(100)
                .HasColumnName("CCYear");
            entity.Property(e => e.ContactNumber).HasMaxLength(100);
            entity.Property(e => e.DotNetResponce).IsUnicode(false);
            entity.Property(e => e.EmailAddress).HasMaxLength(100);
            entity.Property(e => e.FullStudentName).HasMaxLength(100);
            entity.Property(e => e.HomeRoom).HasMaxLength(50);
            entity.Property(e => e.MTotal).HasColumnName("mTotal");
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus).HasMaxLength(100);
            entity.Property(e => e.PTotal).HasColumnName("pTotal");
            entity.Property(e => e.STotal).HasColumnName("sTotal");
            entity.Property(e => e.SalePrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ShopProductInventoryId).HasColumnName("ShopProductInventoryID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ShopProductInventory).WithMany(p => p.ShopProductPaymentDetails)
                .HasForeignKey(d => d.ShopProductInventoryId)
                .HasConstraintName("FK__ShopProdu__ShopP__2FBA0BF1");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("Students$Students$Students$Students$PrimaryKey");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.Dob)
                .HasPrecision(0)
                .HasColumnName("DOB");
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.ParentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentName2).HasMaxLength(50);
            entity.Property(e => e.ParentNumber2).HasMaxLength(50);
            entity.Property(e => e.ParentPassword).HasMaxLength(255);
            entity.Property(e => e.ParentPassword2).HasMaxLength(255);
            entity.Property(e => e.ParentsEmail).HasMaxLength(255);
            entity.Property(e => e.ParentsEmail2).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.StudentGender).HasMaxLength(10);
            entity.Property(e => e.StudentHomeroomId).HasColumnName("StudentHomeroomID");
            entity.Property(e => e.StudentsEmail).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UploadStudentPhoto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.YearGroup).HasMaxLength(255);

            entity.HasOne(d => d.House).WithMany(p => p.Students)
                .HasForeignKey(d => d.HouseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Students$HousesStudents");

            entity.HasOne(d => d.StudentHomeroom).WithMany(p => p.Students)
                .HasForeignKey(d => d.StudentHomeroomId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Students$HomeroomsStudents");
        });

        modelBuilder.Entity<StudentInfo>(entity =>
        {
            entity.ToTable("StudentInfo");

            entity.Property(e => e.StudentInfoId).HasColumnName("StudentInfoID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.YearGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StudentTotalsAllV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StudentTotalsAllV");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HomeroomCode).HasMaxLength(255);
            entity.Property(e => e.HomeroomId).HasColumnName("HomeroomID");
            entity.Property(e => e.Hwcatt).HasColumnName("HWCAtt");
            entity.Property(e => e.Hwcrem).HasColumnName("HWCRem");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.TotLateHw).HasColumnName("TotLateHW");
            entity.Property(e => e.TotalHwc).HasColumnName("TotalHWC");
            entity.Property(e => e.UploadStudentPhoto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Woapp).HasColumnName("WOApp");
            entity.Property(e => e.YearGroup).HasMaxLength(255);
            entity.Property(e => e.YearLateHw).HasColumnName("YearLateHW");
        });

        modelBuilder.Entity<StudentTotalsAllVhistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StudentTotalsAllVHistory");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HomeroomCode).HasMaxLength(255);
            entity.Property(e => e.HomeroomId).HasColumnName("HomeroomID");
            entity.Property(e => e.Hwcatt).HasColumnName("HWCAtt");
            entity.Property(e => e.Hwcrem).HasColumnName("HWCRem");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.TotLateHw).HasColumnName("TotLateHW");
            entity.Property(e => e.TotalHwc).HasColumnName("TotalHWC");
            entity.Property(e => e.Woapp).HasColumnName("WOApp");
        });

        modelBuilder.Entity<Students08nov24>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("students_08Nov24");

            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.Dob)
                .HasPrecision(0)
                .HasColumnName("DOB");
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.ParentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentName2).HasMaxLength(50);
            entity.Property(e => e.ParentNumber2).HasMaxLength(50);
            entity.Property(e => e.ParentPassword).HasMaxLength(255);
            entity.Property(e => e.ParentPassword2).HasMaxLength(255);
            entity.Property(e => e.ParentsEmail).HasMaxLength(255);
            entity.Property(e => e.ParentsEmail2).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.StudentGender).HasMaxLength(10);
            entity.Property(e => e.StudentHomeroomId).HasColumnName("StudentHomeroomID");
            entity.Property(e => e.StudentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("StudentID");
            entity.Property(e => e.StudentsEmail).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UploadStudentPhoto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.YearGroup).HasMaxLength(255);
        });

        modelBuilder.Entity<StudentsHistory>(entity =>
        {
            entity.HasKey(e => e.StudentsHistoryId).HasName("PK__Students__213F62B41E9EB770");

            entity.ToTable("StudentsHistory");

            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.DeletedOn)
                .HasColumnType("datetime")
                .HasColumnName("deletedOn");
            entity.Property(e => e.Deletedby)
                .HasMaxLength(200)
                .HasColumnName("deletedby");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.ParentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentPassword).HasMaxLength(255);
            entity.Property(e => e.ParentsEmail).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.StudentHomeroomId).HasColumnName("StudentHomeroomID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentsEmail).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearGroup).HasMaxLength(255);
        });

        modelBuilder.Entity<TblActivityTeam>(entity =>
        {
            entity.HasKey(e => e.ActivityTeamId).HasName("PK__TblActiv__1C5B7CACE1F360FC");

            entity.ToTable("TblActivityTeam");

            entity.Property(e => e.ActivityTeamId).HasColumnName("ActivityTeamID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Term)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblActivityTeamHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblActivityTeamHistory");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityTeamId).HasColumnName("ActivityTeamID");
            entity.Property(e => e.SessionYear)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Term)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAttendanceEntry>(entity =>
        {
            entity.HasKey(e => e.EntreyId).HasName("PK__tblAtten__B2E37E437AC79C20");

            entity.ToTable("tblAttendanceEntry");

            entity.Property(e => e.EntreyId).HasColumnName("EntreyID");
            entity.Property(e => e.CheckInOutDate).HasColumnType("datetime");
            entity.Property(e => e.CheckInOutTime).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
        });

        modelBuilder.Entity<TblAttendanceEntryHistory>(entity =>
        {
            entity.HasKey(e => e.AttendanceEntryHistoryId).HasName("PK__tblAtten__490A543EA6D3BC08");

            entity.ToTable("tblAttendanceEntryHistory");

            entity.Property(e => e.CheckInOutDate).HasColumnType("datetime");
            entity.Property(e => e.CheckInOutTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EntreyId).HasColumnName("EntreyID");
            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
        });

        modelBuilder.Entity<TblBookLunchText>(entity =>
        {
            entity.HasKey(e => e.BookLunchTextId).HasName("PK__tblBookL__B56B3B3E5B7744AA");

            entity.ToTable("tblBookLunchText");

            entity.Property(e => e.BookLunchTextId).HasColumnName("BookLunchTextID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PageFor).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblCheckFileLayoutLunch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblCheckFileLayout_Lunch");

            entity.Property(e => e.CheckFileLayoutId).ValueGeneratedOnAdd();
            entity.Property(e => e.FileType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstColumn)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastColumn)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblClassRoom>(entity =>
        {
            entity.HasKey(e => e.ClassRoomId).HasName("PK__TblClass__742E129115AF9237");

            entity.ToTable("TblClassRoom");

            entity.Property(e => e.ClassRoomNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__TblCompa__2D971CAC86247AE3");

            entity.ToTable("TblCompany");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDeletedPizzaLunchOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDeletedPizzaLunchOrders");

            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedPizzaOrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DeletedPizzaOrderID");
            entity.Property(e => e.PizzaMealsTypeId).HasColumnName("PizzaMealsTypeID");
            entity.Property(e => e.PizzaOrderId).HasColumnName("PizzaOrderID");
            entity.Property(e => e.PricingType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentIdcard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StudentIDCard");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblDepartment>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__TblDepar__B2079BED9F2F8535");

            entity.ToTable("TblDepartment");

            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDocuments");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.DocumentId).ValueGeneratedOnAdd();
            entity.Property(e => e.DocumentName).IsUnicode(false);
            entity.Property(e => e.DocumentType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OriginalDocumentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblDocumentType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDocumentType");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DocumentType).IsUnicode(false);
            entity.Property(e => e.DocumentTypeId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblEmailContent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblEmailContents");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailType).HasMaxLength(200);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Purpose).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblEntryAttendanceInOutLog>(entity =>
        {
            entity.HasKey(e => e.InOutLogId).HasName("PK__tblEntry__85FCBD9EE4B9F0DE");

            entity.ToTable("tblEntryAttendanceInOutLog");

            entity.Property(e => e.InOutLogId).HasColumnName("InOutLogID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GuestEmail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GuestName).HasMaxLength(255);
            entity.Property(e => e.GuestPhoneNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InOutDateTime).HasColumnType("datetime");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.LogType).HasMaxLength(255);
            entity.Property(e => e.ReasonId).HasColumnName("ReasonID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Reason).WithMany(p => p.TblEntryAttendanceInOutLogs)
                .HasForeignKey(d => d.ReasonId)
                .HasConstraintName("FK_tblEntryAttendanceInOutLog_ReasonId");
        });

        modelBuilder.Entity<TblEntryAttendanceStillInV>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblEntry__3214EC271B645FEF");

            entity.ToTable("tblEntryAttendanceStillInV");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GuestEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GuestName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblEntryAttendanceStillOutV>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblEntry__3214EC275DCE4913");

            entity.ToTable("tblEntryAttendanceStillOutV");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.LogOutDay).HasColumnType("datetime");
            entity.Property(e => e.OtherText).IsUnicode(false);
            entity.Property(e => e.ReasonId).HasColumnName("ReasonID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TblEquipment>(entity =>
        {
            entity.HasKey(e => e.EquipmentId).HasName("PK__TblEquip__C0F077E5D5098470");

            entity.ToTable("TblEquipment");

            entity.Property(e => e.EquipmentId).HasColumnName("Equipment_Id");
            entity.Property(e => e.EquipmentDescription)
                .IsUnicode(false)
                .HasColumnName("Equipment_Description");
            entity.Property(e => e.EquipmentName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Equipment_Name");
            entity.Property(e => e.EquipmentNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Equipment_Number");
        });

        modelBuilder.Entity<TblEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__tblEvent__7944C870E21A620C");

            entity.ToTable("tblEvent");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);

            entity.HasOne(d => d.EventType).WithMany(p => p.TblEvents)
                .HasForeignKey(d => d.EventTypeId)
                .HasConstraintName("FK_tblEventTypeId");

            entity.HasOne(d => d.Group).WithMany(p => p.TblEvents)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_tblGroupId");

            entity.HasOne(d => d.Meet).WithMany(p => p.TblEvents)
                .HasForeignKey(d => d.MeetId)
                .HasConstraintName("FK_tblIDMeet");
        });

        modelBuilder.Entity<TblEvent24feb25>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblEvent_24feb25");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.EventId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EventID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);
        });

        modelBuilder.Entity<TblEventHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblEventHistory");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.SessionYear)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);
        });

        modelBuilder.Entity<TblEventType>(entity =>
        {
            entity.HasKey(e => e.EventTypeId).HasName("PK__tblEvent__A9216B3F0AB9C48B");

            entity.ToTable("tblEventType");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.EventName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MeetTypeId).HasColumnName("MeetTypeID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);
        });

        modelBuilder.Entity<TblEventTypeHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblEventTypeHistory");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.EventName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MeetTypeId).HasColumnName("MeetTypeID");
            entity.Property(e => e.SessionYear)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);
        });

        modelBuilder.Entity<TblGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__tblGroup__149AF36AD687F48D");

            entity.ToTable("tblGroup");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.Gender)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MaxBirthYear).HasColumnType("datetime");
            entity.Property(e => e.MinBirthYear).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);
        });

        modelBuilder.Entity<TblGroupHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblGroupHistory");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.Gender)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MaxBirthYear).HasColumnType("datetime");
            entity.Property(e => e.MinBirthYear).HasColumnType("datetime");
            entity.Property(e => e.SessionYear)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);
        });

        modelBuilder.Entity<TblInOutLog>(entity =>
        {
            entity.HasKey(e => e.InOutLogId).HasName("PK__tblInOut__85FCBD9EC833394C");

            entity.ToTable("tblInOutLog");

            entity.Property(e => e.InOutLogId).HasColumnName("InOutLogID");
            entity.Property(e => e.Clientip)
                .HasMaxLength(255)
                .HasColumnName("clientip");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GuestEmail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GuestName).HasMaxLength(255);
            entity.Property(e => e.GuestPhoneNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HappinessLevel).HasMaxLength(255);
            entity.Property(e => e.InOutDateTime).HasColumnType("datetime");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.LogType).HasMaxLength(255);
            entity.Property(e => e.ReasonId).HasColumnName("ReasonID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserNumber).HasMaxLength(50);
            entity.Property(e => e.VisitorLocation).HasMaxLength(255);
        });

        modelBuilder.Entity<TblInOutLogHistory>(entity =>
        {
            entity.HasKey(e => e.InOutLogHistoryId).HasName("PK__tblInOut__8B51AA3A9892F4D0");

            entity.ToTable("tblInOutLogHistory");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GuestEmail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GuestName).HasMaxLength(255);
            entity.Property(e => e.GuestPhoneNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HistoryCreatedBy).HasMaxLength(100);
            entity.Property(e => e.HistoryCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.InOutDateTime).HasColumnType("datetime");
            entity.Property(e => e.InOutLogId).HasColumnName("InOutLogID");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.LogType).HasMaxLength(255);
            entity.Property(e => e.ReasonId).HasColumnName("ReasonID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TblLeaveRequest>(entity =>
        {
            entity.HasKey(e => e.LeaveId).HasName("PK__TblLeave__796DB9793C4104CB");

            entity.Property(e => e.LeaveId).HasColumnName("LeaveID");
            entity.Property(e => e.ApprovalStatus)
                .HasMaxLength(20)
                .HasDefaultValue("Approved");
            entity.Property(e => e.LeaveType).HasMaxLength(50);
            entity.Property(e => e.Reason).HasMaxLength(255);
            entity.Property(e => e.TeacherCode).HasMaxLength(50);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
        });

        modelBuilder.Entity<TblLocation>(entity =>
        {
            entity.HasKey(e => e.Locid).HasName("PK__tblLocat__6A45DAE135CCFAFB");

            entity.ToTable("tblLocation");

            entity.Property(e => e.CheckInCheckOutLocation).HasDefaultValue(false);
            entity.Property(e => e.IsArchived).HasMaxLength(50);
            entity.Property(e => e.LocationName).HasMaxLength(255);
            entity.Property(e => e.VisitingLocation).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblLogEmail>(entity =>
        {
            entity.HasKey(e => e.EmailLogId).HasName("PK__tblLogEm__E8CB41CC6A7641C9");

            entity.ToTable("tblLogEmail");

            entity.Property(e => e.EmailBody).IsUnicode(false);
            entity.Property(e => e.EmailCc)
                .IsUnicode(false)
                .HasColumnName("EmailCC");
            entity.Property(e => e.EmailDate).HasColumnType("datetime");
            entity.Property(e => e.EmailStatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmailSubject).IsUnicode(false);
            entity.Property(e => e.EmailTo).IsUnicode(false);
            entity.Property(e => e.EmailType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UniqueId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblLunchOrderHistory>(entity =>
        {
            entity.HasKey(e => e.LunchOrderHistoryId).HasName("PK__TblLunch__2B3A3815867BA100");

            entity.ToTable("TblLunchOrderHistory");

            entity.Property(e => e.LunchOrderHistoryId).HasColumnName("LunchOrderHistoryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsOffline).HasDefaultValue(false);
            entity.Property(e => e.IsUpdatedOffline).HasDefaultValue(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PricingType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentIdcard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StudentIDCard");
            entity.Property(e => e.TblWebHooksPaymentDetailId).HasColumnName("TblWebHooksPaymentDetail_Id");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblLunchSemesterDate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblLunch__3213E83F5BF78C08");

            entity.ToTable("TblLunch_Semester_Date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsArchive).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblMealHistory>(entity =>
        {
            entity.HasKey(e => e.MealHistoryId).HasName("PK__TblMealH__833414924F93E5F9");

            entity.ToTable("TblMealHistory");

            entity.Property(e => e.MealHistoryId).HasColumnName("MealHistoryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsArchive).HasDefaultValue(false);
            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MealDesc).HasColumnType("text");
            entity.Property(e => e.MealShortDesc).HasMaxLength(200);
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Week).HasMaxLength(255);
            entity.Property(e => e.WeekDay)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblMeet>(entity =>
        {
            entity.HasKey(e => e.MeetId).HasName("PK__tblMeets__4030A3F6E9EEFFAB");

            entity.ToTable("tblMeets");

            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.MeetName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MeetTypeId).HasColumnName("MeetTypeID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);

            entity.HasOne(d => d.MeetType).WithMany(p => p.TblMeets)
                .HasForeignKey(d => d.MeetTypeId)
                .HasConstraintName("FK_tblMeetTypes");
        });

        modelBuilder.Entity<TblMeetType>(entity =>
        {
            entity.HasKey(e => e.MeetTypeId).HasName("PK__tblMeetT__F612EFDC7EE05B98");

            entity.ToTable("tblMeetTypes");

            entity.Property(e => e.MeetTypeId).HasColumnName("MeetTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.MeetTypeName).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(200);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMeetsHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblMeetsHistory");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.MeetName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MeetTypeId).HasColumnName("MeetTypeID");
            entity.Property(e => e.SessionYear)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);
        });

        modelBuilder.Entity<TblMenuAccess>(entity =>
        {
            entity.HasKey(e => e.MenuAccessId).HasName("PK__tblMenuA__47F7114BC3FA2C67");

            entity.ToTable("tblMenuAccess");

            entity.HasIndex(e => e.Code, "uc_empcode").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.MenuName).IsUnicode(false);
            entity.Property(e => e.SubMenuAccess).IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMenuMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblMenuM__3213E83FCD2ECA4C");

            entity.ToTable("tblMenuMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Menu).HasMaxLength(1500);
        });

        modelBuilder.Entity<TblMenuMaster20dec2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblMenuMaster_20Dec2024");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Menu).HasMaxLength(1500);
        });

        modelBuilder.Entity<TblOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__TblOrder__C3905BCFCAE9FB23");

            entity.ToTable("TblOrder");

            entity.Property(e => e.ApprovedByAccountsDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedByHeadDate).HasColumnType("datetime");
            entity.Property(e => e.ArrivalNotificationDate).HasColumnType("datetime");
            entity.Property(e => e.Attachment1).IsUnicode(false);
            entity.Property(e => e.Attachment2).IsUnicode(false);
            entity.Property(e => e.Attachment3).IsUnicode(false);
            entity.Property(e => e.Attachment4).IsUnicode(false);
            entity.Property(e => e.Attachment5).IsUnicode(false);
            entity.Property(e => e.BudgetToBeCharged).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ClassroomNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyOrderedFrom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Createdby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.CreditCardorChargeaccount)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DateqQoteApproved).HasColumnType("datetime");
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemOrdered)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModelNumber)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.OrderRequestDate).HasColumnType("datetime");
            entity.Property(e => e.Orderstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("orderstatus");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.QuoteNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Shippedby)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.ToBeFilledBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Updatedby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updatedon)
                .HasColumnType("datetime")
                .HasColumnName("updatedon");
        });

        modelBuilder.Entity<TblOrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId).HasName("PK__TblOrder__D3B9D36CECF0848A");

            entity.Property(e => e.ArrivalNotificationDate).HasColumnType("datetime");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comment)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.CompanyOrderedFrom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Createdby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.ItemOrdered)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LinkToItemOrder)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ModelNumber)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Orderstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("orderstatus");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shippedby)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updatedon)
                .HasColumnType("datetime")
                .HasColumnName("updatedon");

            entity.HasOne(d => d.Order).WithMany(p => p.TblOrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__TblOrderD__Order__7814D14C");
        });

        modelBuilder.Entity<TblOrderPaymentDetailHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblOrderPaymentDetailHistory");

            entity.Property(e => e.Cccvc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CCCVC");
            entity.Property(e => e.Ccmonth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCMonth");
            entity.Property(e => e.Ccname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCName");
            entity.Property(e => e.Ccnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCNumber");
            entity.Property(e => e.Ccyear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCYear");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullStudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HomeRoom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.OrderPaymentHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OrderPaymentHistoryID");
            entity.Property(e => e.PTotal).HasColumnName("pTotal");
            entity.Property(e => e.PayCash).HasDefaultValue(false);
            entity.Property(e => e.STotal).HasColumnName("sTotal");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPizzaLunchOrderHistory>(entity =>
        {
            entity.HasKey(e => e.PizzaLunchOrderHistoryId).HasName("PK__TblPizza__478D73E1A5922DCE");

            entity.ToTable("TblPizzaLunchOrderHistory");

            entity.Property(e => e.PizzaLunchOrderHistoryId).HasColumnName("PizzaLunchOrderHistoryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsOffline).HasDefaultValue(false);
            entity.Property(e => e.IsUpdatedOffline).HasDefaultValue(false);
            entity.Property(e => e.PizzaMealsTypeId).HasColumnName("PizzaMealsTypeID");
            entity.Property(e => e.PizzaOrderId).HasColumnName("PizzaOrderID");
            entity.Property(e => e.StudentIdcard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StudentIDCard");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPizzaMealHistory>(entity =>
        {
            entity.HasKey(e => e.PizzaMealHistoryId).HasName("PK__TblPizza__A6029A53D2951A9C");

            entity.ToTable("TblPizzaMealHistory");

            entity.Property(e => e.PizzaMealHistoryId).HasColumnName("PizzaMealHistoryID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsArchive).HasDefaultValue(false);
            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MealDesc).HasColumnType("text");
            entity.Property(e => e.MealShortDesc).HasMaxLength(200);
            entity.Property(e => e.PizzaMealsTypeId).HasColumnName("PizzaMealsTypeID");
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Week).HasMaxLength(255);
            entity.Property(e => e.WeekDay)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblPizzaOrder>(entity =>
        {
            entity.HasKey(e => e.PizzaOrderId).HasName("PK__TblPizza__EA09DF7DA4349564");

            entity.ToTable("TblPizzaOrder");

            entity.Property(e => e.ApprovedByAccountsDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedByHeadDate).HasColumnType("datetime");
            entity.Property(e => e.ArrivalNotificationDate).HasColumnType("datetime");
            entity.Property(e => e.Attachment1).IsUnicode(false);
            entity.Property(e => e.Attachment2).IsUnicode(false);
            entity.Property(e => e.Attachment3).IsUnicode(false);
            entity.Property(e => e.Attachment4).IsUnicode(false);
            entity.Property(e => e.Attachment5).IsUnicode(false);
            entity.Property(e => e.BudgetToBeCharged).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ClassroomNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyOrderedFrom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CreditCardorChargeaccount)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DateqQoteApproved).HasColumnType("datetime");
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemOrdered)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModelNumber)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.OrderRequestDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.QuoteNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Shippedby)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.ToBeFilledBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPizzaOrderPaymentDetailHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblPizzaOrderPaymentDetailHistory");

            entity.Property(e => e.Cccvc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CCCVC");
            entity.Property(e => e.Ccmonth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCMonth");
            entity.Property(e => e.Ccname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCName");
            entity.Property(e => e.Ccnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCNumber");
            entity.Property(e => e.Ccyear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCYear");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullStudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HomeRoom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.PTotal).HasColumnName("pTotal");
            entity.Property(e => e.PayCash).HasDefaultValue(false);
            entity.Property(e => e.PizzaOrderPaymentDetailHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PizzaOrderPaymentDetailHistoryID");
            entity.Property(e => e.PizzaOrderPaymentDetailsId).HasColumnName("PizzaOrderPaymentDetailsID");
            entity.Property(e => e.STotal).HasColumnName("sTotal");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPizzaSemesterDate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblPizza__3213E83F5616CA79");

            entity.ToTable("TblPizza_Semester_Date");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsArchive).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblProduct");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Productid)
                .ValueGeneratedOnAdd()
                .HasColumnName("productid");
        });

        modelBuilder.Entity<TblQualification>(entity =>
        {
            entity.HasKey(e => e.QualificationId).HasName("PK__TblQuali__C95C12AAB5527FCA");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.QualificationName).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblReason>(entity =>
        {
            entity.HasKey(e => e.ReasonId).HasName("PK__tblReaso__A4F8C0C7C62E8043");

            entity.ToTable("tblReasons");

            entity.Property(e => e.ReasonId).HasColumnName("ReasonID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ReasonDesc).HasMaxLength(255);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblRequirement>(entity =>
        {
            entity.HasKey(e => e.RequirementId).HasName("PK__TblRequi__7DF11E5DF8BE43C4");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.RequirementDescription).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblResult>(entity =>
        {
            entity.HasKey(e => e.ResultId).HasName("PK__tblResul__976902282F663A28");

            entity.ToTable("tblResult");

            entity.Property(e => e.ResultId).HasColumnName("ResultID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);

            entity.HasOne(d => d.Event).WithMany(p => p.TblResults)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK_tblResultEventID");

            entity.HasOne(d => d.Student).WithMany(p => p.TblResults)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblStudentID");
        });

        modelBuilder.Entity<TblSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblSetti__3214EC27D4F507A6");

            entity.ToTable("tblSettings");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblShopProduct>(entity =>
        {
            entity.HasKey(e => e.ShopProductId).HasName("PK__TblShopP__A9FBB7357C7111AF");

            entity.ToTable("TblShopProduct");

            entity.Property(e => e.ShopProductId).HasColumnName("ShopProductID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description1).HasMaxLength(50);
            entity.Property(e => e.Description2).HasMaxLength(50);
            entity.Property(e => e.ImagePath).HasMaxLength(100);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblShopProductInventory>(entity =>
        {
            entity.HasKey(e => e.ShopProductInventoryId).HasName("PK__TblShopP__B20FC586CAEFDF88");

            entity.ToTable("TblShopProductInventory");

            entity.Property(e => e.ShopProductInventoryId).HasColumnName("ShopProductInventoryID");
            entity.Property(e => e.CostPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Quantity).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.SalePrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ShopProductId).HasColumnName("ShopProductID");
            entity.Property(e => e.Size).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.ShopProduct).WithMany(p => p.TblShopProductInventories)
                .HasForeignKey(d => d.ShopProductId)
                .HasConstraintName("FK__TblShopPr__ShopP__2630A1B7");
        });

        modelBuilder.Entity<TblShopProductSchoolOrder>(entity =>
        {
            entity.HasKey(e => e.SchoolOrderId).HasName("PK__TblShopP__9B4617EC70586101");

            entity.ToTable("TblShopProductSchoolOrder");

            entity.Property(e => e.SchoolOrderId).HasColumnName("SchoolOrderID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.OrderBySchool).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ShopProductInventoryid).HasColumnName("shopProductInventoryid");

            entity.HasOne(d => d.ShopProductInventory).WithMany(p => p.TblShopProductSchoolOrders)
                .HasForeignKey(d => d.ShopProductInventoryid)
                .HasConstraintName("FK__TblShopPr__shopP__2CDD9F46");
        });

        modelBuilder.Entity<TblSportAttendance>(entity =>
        {
            entity.HasKey(e => e.SportAttendanceId).HasName("PK__tblSport__EEC162C6BEF560BC");

            entity.ToTable("tblSportAttendance");

            entity.Property(e => e.SportAttendanceId).HasColumnName("SportAttendanceID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.AttendanceDate).HasColumnType("datetime");
            entity.Property(e => e.Attened)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Term)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSportAttendanceHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSportAttendanceHistory");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.AttendanceDate).HasColumnType("datetime");
            entity.Property(e => e.Attened)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.SessionYear)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.SportAttendanceId).HasColumnName("SportAttendanceID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Term)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblStillInV>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblStill__3214EC27E5BF2812");

            entity.ToTable("tblStillInV");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GuestEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GuestName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblStillOutV>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblStill__3214EC27786A67FB");

            entity.ToTable("tblStillOutV");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.LogOutDay).HasColumnType("datetime");
            entity.Property(e => e.OtherText).IsUnicode(false);
            entity.Property(e => e.ReasonId).HasColumnName("ReasonID");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserNumber).HasMaxLength(25);
        });

        modelBuilder.Entity<TblStudentAccessDatum>(entity =>
        {
            entity.HasKey(e => e.Studid).HasName("PK__TblStude__F5FFAC279652EFCD");

            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.StudentGender).HasMaxLength(100);
            entity.Property(e => e.StudentName).HasMaxLength(255);
            entity.Property(e => e.Studentid).HasMaxLength(255);
        });

        modelBuilder.Entity<TblStudentAssignedSubject>(entity =>
        {
            entity.HasKey(e => e.StudentAssignedtId).HasName("PK__TblStude__EEAA351D7462CF42");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStudentAssignedSubjects)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("fk_TblStudentAssignedSubjects_studentid");

            entity.HasOne(d => d.Subject).WithMany(p => p.TblStudentAssignedSubjects)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("fk_TblStudentAssignedSubjects_SubjectId");
        });

        modelBuilder.Entity<TblStudentRequirement>(entity =>
        {
            entity.HasKey(e => e.StudentRequirementId).HasName("PK__TblStude__3ECCC913D0F3991A");

            entity.HasIndex(e => new { e.StudentId, e.RequirementId }, "UQ_StudentRequirement_Student").IsUnique();

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Requirement).WithMany(p => p.TblStudentRequirements)
                .HasForeignKey(d => d.RequirementId)
                .HasConstraintName("fk_TblStudentRequirements_RequirementId");

            entity.HasOne(d => d.Student).WithMany(p => p.TblStudentRequirements)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("fk_TblStudentRequirements_studentid");
        });

        modelBuilder.Entity<TblSubMenuMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblSubMe__3213E83FFDD925DA");

            entity.ToTable("tblSubMenuMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SubMenu).HasMaxLength(1500);

            entity.HasOne(d => d.Menu).WithMany(p => p.TblSubMenuMasters)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("FK__tblSubMen__MenuI__7073AF84");
        });

        modelBuilder.Entity<TblSubMenuMaster27Sep2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSubMenuMaster_27_sep_2024");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.SubMenu).HasMaxLength(1500);
        });

        modelBuilder.Entity<TblSubject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__TblSubje__AC1BA3A8457E2986");

            entity.ToTable(tb => tb.HasTrigger("trg_PreventDuplicateSubject"));

            entity.Property(e => e.ActualStartTime).HasColumnType("datetime");
            entity.Property(e => e.Component).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExamDate).HasColumnType("datetime");
            entity.Property(e => e.ExamDuration).HasColumnType("datetime");
            entity.Property(e => e.Ilp)
                .HasMaxLength(50)
                .HasColumnName("ILP");
            entity.Property(e => e.SessionStartTime).HasColumnType("datetime");
            entity.Property(e => e.SubjectCode).HasMaxLength(100);
            entity.Property(e => e.SubjectName).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearGroup).HasMaxLength(50);

            entity.HasOne(d => d.Qualification).WithMany(p => p.TblSubjects)
                .HasForeignKey(d => d.QualificationId)
                .HasConstraintName("fk_tblsubjects_qualificationid");
        });

        modelBuilder.Entity<TblTempActivityTeam>(entity =>
        {
            entity.HasKey(e => e.TempActivityId).HasName("PK__TblTempA__150D72F85490314F");

            entity.ToTable("TblTempActivityTeam");

            entity.Property(e => e.TempActivityId).HasColumnName("TempActivityID");
            entity.Property(e => e.ActivityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentCode).HasMaxLength(100);
            entity.Property(e => e.StudentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TeacherCode).HasMaxLength(100);
            entity.Property(e => e.TeacherName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Term)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblTempMeal>(entity =>
        {
            entity.HasKey(e => e.TempMealId).HasName("PK__TblTempM__D046617A3C60B90C");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MealDate).HasMaxLength(255);
            entity.Property(e => e.MealDesc).IsUnicode(false);
            entity.Property(e => e.MealShortDesc).HasMaxLength(200);
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Week).HasMaxLength(255);
        });

        modelBuilder.Entity<TblTempPizzaMeal>(entity =>
        {
            entity.HasKey(e => e.TempPizzaMealsId).HasName("PK__TblTempP__A511AB565C339554");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MealDate).HasMaxLength(255);
            entity.Property(e => e.MealDesc).IsUnicode(false);
            entity.Property(e => e.MealShortDesc).HasMaxLength(200);
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Week).HasMaxLength(255);
        });

        modelBuilder.Entity<TblTempResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTempResult");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.ResultId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ResultID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Updatedby).HasMaxLength(255);
        });

        modelBuilder.Entity<TblTempSubject>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ActualStartTime).HasMaxLength(100);
            entity.Property(e => e.Component).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExamDate).HasMaxLength(100);
            entity.Property(e => e.ExamDuration).HasMaxLength(100);
            entity.Property(e => e.Ilp)
                .HasMaxLength(50)
                .HasColumnName("ILP");
            entity.Property(e => e.QualificationId).HasMaxLength(100);
            entity.Property(e => e.Regular).HasMaxLength(100);
            entity.Property(e => e.SessionStartTime).HasMaxLength(100);
            entity.Property(e => e.SubjectCode).HasMaxLength(100);
            entity.Property(e => e.SubjectName).HasMaxLength(100);
            entity.Property(e => e.TotalStudents).HasMaxLength(100);
            entity.Property(e => e.YearGroup).HasMaxLength(50);
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__tblUsers__1788CCACD6FB23B1");

            entity.ToTable("tblUsers");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.House).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Reg).HasMaxLength(255);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserNumber).HasMaxLength(255);
            entity.Property(e => e.Year).HasMaxLength(100);
        });

        modelBuilder.Entity<TblWebHooksPaymentDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblWebHo__3214EC074FF1A00C");

            entity.ToTable("TblWebHooksPaymentDetail");

            entity.Property(e => e.CreateDatetime).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OrderPaymentId).HasColumnName("OrderPaymentID");
            entity.Property(e => e.PTotal).HasColumnName("pTotal");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Pending")
                .IsFixedLength();
            entity.Property(e => e.ResponseDateTime).HasColumnType("datetime");
            entity.Property(e => e.STotal).HasColumnName("sTotal");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.UpnGoConfirmationNo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("UPnGO_ConfirmationNo");
        });

        modelBuilder.Entity<TblWebHooksPaymentDetailTemp>(entity =>
        {
            entity.HasKey(e => e.ResponseTempId).HasName("PK__TblWebHo__55A09F097AB1F0BB");

            entity.ToTable("TblWebHooksPaymentDetailTemp");

            entity.Property(e => e.ResponseTempId).HasColumnName("ResponseTempID");
            entity.Property(e => e.ResponcString)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("responcString");
        });

        modelBuilder.Entity<TblWeek>(entity =>
        {
            entity.HasKey(e => e.WeeksId).HasName("PK__TblWeeks__C2A52CF6D5F418EE");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.RawWeeks)
                .HasMaxLength(100)
                .HasColumnName("Raw_Weeks");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Weeks).HasMaxLength(100);
        });

        modelBuilder.Entity<TblWeightRoomGuestLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblWeigh__3214EC2748E1D19B");

            entity.ToTable("tblWeightRoomGuestLogin");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GuestEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GuestName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LoginDay).HasColumnType("datetime");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblWeightRoomInOutLog>(entity =>
        {
            entity.HasKey(e => e.InOutLogId).HasName("PK__tblWeigh__85FCBD9E44373A09");

            entity.ToTable("tblWeightRoomInOutLog", tb => tb.HasTrigger("TRG_UPDATE_CheckOutDateTime"));

            entity.Property(e => e.InOutLogId).HasColumnName("InOutLogID");
            entity.Property(e => e.CheckOutDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GuestEmail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GuestName).HasMaxLength(255);
            entity.Property(e => e.GuestPhoneNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InOutDateTime).HasColumnType("datetime");
            entity.Property(e => e.LogType).HasMaxLength(255);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblWeightRoomInOutLogHistory>(entity =>
        {
            entity.HasKey(e => e.InOutLogHistoryId).HasName("PK__tblWeigh__8B51AA3AE03949F8");

            entity.ToTable("tblWeightRoomInOutLogHistory");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GuestEmail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GuestName).HasMaxLength(255);
            entity.Property(e => e.GuestPhoneNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HistoryCreatedBy).HasMaxLength(100);
            entity.Property(e => e.HistoryCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.InOutDateTime).HasColumnType("datetime");
            entity.Property(e => e.InOutLogId).HasColumnName("InOutLogID");
            entity.Property(e => e.LogType).HasMaxLength(255);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TblWeightRoomStudentStaffLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblWeigh__3214EC27925E3530");

            entity.ToTable("tblWeightRoomStudentStaffLogin");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LoginDay).HasColumnType("datetime");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("Teachers$Teachers$Teachers$Teachers$PrimaryKey");

            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Ib).HasColumnName("IB");
            entity.Property(e => e.IsArchived).HasColumnName("isArchived");
            entity.Property(e => e.Ks2).HasColumnName("KS2");
            entity.Property(e => e.Ks3)
                .HasDefaultValue(false)
                .HasColumnName("KS3");
            entity.Property(e => e.Ks4)
                .HasDefaultValue(false)
                .HasColumnName("KS4");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Role)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Smt)
                .HasDefaultValue(false)
                .HasColumnName("SMT");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TeacherCode).HasMaxLength(255);
            entity.Property(e => e.TeacherEmail).HasMaxLength(255);
            entity.Property(e => e.TeacherHomeroomId).HasColumnName("TeacherHomeroomID");
            entity.Property(e => e.TeacherPass)
                .HasMaxLength(255)
                .HasDefaultValue("$2y$10$aI9G70cPvJMoupdOm/03YurwghxmQuQO3erW/GZEEdITH1pC516oe");
            entity.Property(e => e.UploadTeacherPhoto)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.TeacherHomeroom).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.TeacherHomeroomId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Teachers$HomeroomsTeachers");
        });

        modelBuilder.Entity<TeacherCountV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TeacherCountV");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LateHwsGiven).HasColumnName("LateHWsGiven");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.WodemeritsGiven).HasColumnName("WODemeritsGiven");
        });

        modelBuilder.Entity<TempPayDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempPayDetails");

            entity.Property(e => e.Pcost).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Scost).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.StudentIdcard)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("studentIDcard");
        });

        modelBuilder.Entity<TempStudent>(entity =>
        {
            entity.HasKey(e => e.TempStudentid).HasName("PK__TempStud__4D0E463DCD60DCC3");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasMaxLength(100)
                .HasColumnName("DOB");
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.HomeroomCode).HasMaxLength(100);
            entity.Property(e => e.Homeroomid).HasMaxLength(100);
            entity.Property(e => e.HouseName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Houseid).HasMaxLength(100);
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.ParentEmailId)
                .HasMaxLength(255)
                .HasColumnName("ParentEmailID");
            entity.Property(e => e.ParentFirstName).HasMaxLength(200);
            entity.Property(e => e.ParentFirstName2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentLastName).HasMaxLength(200);
            entity.Property(e => e.ParentLastName2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentNumber2).HasMaxLength(50);
            entity.Property(e => e.ParentsEmail2).HasMaxLength(255);
            entity.Property(e => e.StudentCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentEmailId)
                .HasMaxLength(255)
                .HasColumnName("StudentEmailID");
            entity.Property(e => e.StudentFirstName).HasMaxLength(200);
            entity.Property(e => e.StudentLastName).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearGroup)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TotalDemeritsTeacherV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalDemeritsTeacherV");

            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
        });

        modelBuilder.Entity<TotalDemeritsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalDemeritsV");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<TotalHwcattendanceV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalHWCAttendanceV");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<TotalHwcattendanceV1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalHWCAttendanceV1");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<TotalLateHwsTeacherV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalLateHWsTeacherV");

            entity.Property(e => e.LateHwsGiven).HasColumnName("LateHWsGiven");
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
        });

        modelBuilder.Entity<TotalLateHwsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalLateHWsV");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<TotalLateHwsV1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalLateHWsV1");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<TotalMeritsTeacherV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalMeritsTeacherV");

            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
        });

        modelBuilder.Entity<TotalMeritsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalMeritsV");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<TotalSatAttDetV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalSatAttDetV");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
        });

        modelBuilder.Entity<TotalWodemeritsTeacherV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalWODemeritsTeacherV");

            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.WodemeritsGiven).HasColumnName("WODemeritsGiven");
        });

        modelBuilder.Entity<TotalWodemeritsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotalWODemeritsV");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Woapplied).HasColumnName("WOApplied");
        });

        modelBuilder.Entity<TransactionResponse>(entity =>
        {
            entity.HasKey(e => e.ResponseId).HasName("PK__Transact__1AAA646C73369013");

            entity.ToTable("TransactionResponse");

            entity.Property(e => e.RefTransId).HasColumnName("RefTransID");
            entity.Property(e => e.ResponseTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwActivityTeacherName>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ActivityTeacherName");

            entity.Property(e => e.ActivityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ActivityID");
            entity.Property(e => e.ActivityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SteacherId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("STeacherID");
            entity.Property(e => e.TeacherId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TeacherID");
            entity.Property(e => e.Term).HasMaxLength(25);
        });

        modelBuilder.Entity<VwAllDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAllData");

            entity.Property(e => e.Component).HasMaxLength(50);
            entity.Property(e => e.ExamDate).HasColumnType("datetime");
            entity.Property(e => e.ExamDuration).HasColumnType("datetime");
            entity.Property(e => e.Ilp)
                .HasMaxLength(50)
                .HasColumnName("ILP");
            entity.Property(e => e.LastName).HasMaxLength(512);
            entity.Property(e => e.Name)
                .HasMaxLength(511)
                .HasColumnName("name");
            entity.Property(e => e.QualificationCreatedBy).HasMaxLength(50);
            entity.Property(e => e.QualificationCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.QualificationName).HasMaxLength(100);
            entity.Property(e => e.QualificationUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.QualificationUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.RequirementCreatedBy).HasMaxLength(50);
            entity.Property(e => e.RequirementCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.RequirementDescription).HasMaxLength(100);
            entity.Property(e => e.RequirementUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.RequirementUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.SessionStartTime).HasColumnType("datetime");
            entity.Property(e => e.StudentAssignedCreatedBy).HasMaxLength(50);
            entity.Property(e => e.StudentAssignedCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentAssignedNotes).HasMaxLength(255);
            entity.Property(e => e.StudentAssignedUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.StudentAssignedUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentRequirementCreatedBy).HasMaxLength(50);
            entity.Property(e => e.StudentRequirementCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentRequirementNotes).HasMaxLength(255);
            entity.Property(e => e.StudentRequirementUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.StudentRequirementUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentYearGroup).HasMaxLength(255);
            entity.Property(e => e.SubjectCode).HasMaxLength(100);
            entity.Property(e => e.SubjectCreatedBy).HasMaxLength(50);
            entity.Property(e => e.SubjectCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SubjectName).HasMaxLength(100);
            entity.Property(e => e.SubjectUpdatedBy).HasMaxLength(50);
            entity.Property(e => e.SubjectUpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearGroup).HasMaxLength(50);
        });

        modelBuilder.Entity<VwChampionQ>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ChampionQ");

            entity.Property(e => e.ChampLabel)
                .HasMaxLength(211)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.Meetname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StudentGender).HasMaxLength(10);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
        });

        modelBuilder.Entity<VwChampionQPre>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ChampionQ_pre");

            entity.Property(e => e.GroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.MeetName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StudentGender).HasMaxLength(10);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
        });

        modelBuilder.Entity<VwColumnsPdf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ColumnsPDF");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasPrecision(0)
                .HasColumnName("DOB");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.ParentsEmail).HasMaxLength(255);
            entity.Property(e => e.Rownum).HasColumnName("ROWNUM");
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.TeacherName).HasMaxLength(511);
            entity.Property(e => e.Term)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UploadStudentPhoto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.YearGroup).HasMaxLength(255);
        });

        modelBuilder.Entity<VwDetailedExamSchedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_DetailedExamSchedule");

            entity.Property(e => e.Component).HasMaxLength(50);
            entity.Property(e => e.ExamDate).HasColumnType("datetime");
            entity.Property(e => e.ExamDateFormatted).HasMaxLength(4000);
            entity.Property(e => e.ExamDuration).HasColumnType("datetime");
            entity.Property(e => e.ExamDuration12Hour).HasMaxLength(4000);
            entity.Property(e => e.ExamDuration24Hour)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ExamDuration25PercentExtra)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ExamDuration25PercentExtra12Hour).HasMaxLength(4000);
            entity.Property(e => e.ExamDuration50PercentExtra)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ExamDuration50PercentExtra12Hour).HasMaxLength(4000);
            entity.Property(e => e.ExamDurationMinutes)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Extra25ExamDurationMinutes)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Extra50ExamDurationMinutes)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SessionEnd25PercentExtraTime12Hour).HasMaxLength(4000);
            entity.Property(e => e.SessionEnd25PercentExtraTime24Hour)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SessionEnd50PercentExtraTime12Hour).HasMaxLength(4000);
            entity.Property(e => e.SessionEnd50PercentExtraTime24Hour)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SessionEndTime12Hour).HasMaxLength(4000);
            entity.Property(e => e.SessionEndTime24Hour)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SessionStartTime).HasColumnType("datetime");
            entity.Property(e => e.SessionStartTime12Hour).HasMaxLength(4000);
            entity.Property(e => e.SessionStartTime24Hour)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SubjectCode).HasMaxLength(100);
            entity.Property(e => e.SubjectId).ValueGeneratedOnAdd();
            entity.Property(e => e.SubjectName).HasMaxLength(100);
            entity.Property(e => e.YearGroup).HasMaxLength(50);
        });

        modelBuilder.Entity<VwEventPointCupQ>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_EventPointCupQ");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EventName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.MeetName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResultId).HasColumnName("ResultID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
        });

        modelBuilder.Entity<VwEventPointsQ>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_EventPointsQ");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EventName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.MeetName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(510);
        });

        modelBuilder.Entity<VwGroupQ>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_GroupQ");

            entity.Property(e => e.Gender)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GroupId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GroupID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwListofActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ListofActivity");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.ActivityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.TeacherName).HasMaxLength(511);
        });

        modelBuilder.Entity<VwMealsOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_MealsOrder");

            entity.Property(e => e.LunchItem).HasMaxLength(255);
        });

        modelBuilder.Entity<VwMealsOrderd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_MealsOrderd");

            entity.Property(e => e.LunchItem).HasMaxLength(255);
        });

        modelBuilder.Entity<VwNumberOfParticipant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_NumberOfParticipants");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EventName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Group)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Meet)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<VwNumberOfStudentsInHouse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_NumberOfStudentsInHouse");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.HouseName).HasMaxLength(255);
        });

        modelBuilder.Entity<VwOrderPlacementReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_OrderPlacementReport");

            entity.Property(e => e.Description1).HasMaxLength(101);
            entity.Property(e => e.DotNetResponce).IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullStudentName).HasMaxLength(100);
            entity.Property(e => e.HomeRoom).HasMaxLength(50);
            entity.Property(e => e.OrderQuantity).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.OrderStatus).HasMaxLength(100);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.ProductSalePrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.SalePrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Size).HasMaxLength(100);
            entity.Property(e => e.StudentCode).HasMaxLength(50);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwPizzaOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_PizzaOrder");

            entity.Property(e => e.LunchItem).HasMaxLength(255);
        });

        modelBuilder.Entity<VwPrintPizzaStickerForTeacherInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_PrintPizzaStickerForTeacherInfo");

            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(29, 2)");
            entity.Property(e => e.MealDesc).IsUnicode(false);
            entity.Property(e => e.PizzaMealsTypeId).HasColumnName("PizzaMealsTypeID");
            entity.Property(e => e.PricingType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PricingTypeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TeacherCode).HasMaxLength(255);
            entity.Property(e => e.TeacherName).HasMaxLength(511);
        });

        modelBuilder.Entity<VwPrintPizzaStickerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_PrintPizzaStickerInfo");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(29, 2)");
            entity.Property(e => e.MealDesc).IsUnicode(false);
            entity.Property(e => e.PizzaMealsTypeId).HasColumnName("PizzaMealsTypeID");
            entity.Property(e => e.PricingType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PricingTypeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.Yeargroup)
                .HasMaxLength(255)
                .HasColumnName("yeargroup");
        });

        modelBuilder.Entity<VwPrintPizzaStickerInfoOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_PrintPizzaStickerInfo_old");

            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(29, 2)");
            entity.Property(e => e.MealDesc).IsUnicode(false);
            entity.Property(e => e.PizzaMealsTypeId).HasColumnName("PizzaMealsTypeID");
            entity.Property(e => e.PricingType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PricingTypeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.Yeargroup)
                .HasMaxLength(255)
                .HasColumnName("yeargroup");
        });

        modelBuilder.Entity<VwPrintStickerForTeacherInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_PrintStickerForTeacherInfo");

            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MealDesc).IsUnicode(false);
            entity.Property(e => e.MeatTypeId).HasColumnName("MeatTypeID");
            entity.Property(e => e.PricingType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PricingTypeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TeacherCode).HasMaxLength(255);
            entity.Property(e => e.TeacherName).HasMaxLength(511);
        });

        modelBuilder.Entity<VwPrintStickerInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_PrintStickerInfo");

            entity.Property(e => e.MealCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MealCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MealDesc).IsUnicode(false);
            entity.Property(e => e.MeatTypeId).HasColumnName("MeatTypeID");
            entity.Property(e => e.PricingType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PricingTypeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimarySecondary)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.Yeargroup)
                .HasMaxLength(255)
                .HasColumnName("yeargroup");
        });

        modelBuilder.Entity<VwPrintStickerTeacherInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_PrintStickerTeacherInfo");

            entity.Property(e => e.MealDesc).IsUnicode(false);
            entity.Property(e => e.MeatTypeId).HasColumnName("MeatTypeID");
            entity.Property(e => e.PricingType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PricingTypeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TeacherCode).HasMaxLength(255);
            entity.Property(e => e.TeacherName).HasMaxLength(511);
        });

        modelBuilder.Entity<VwShopProductCart>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_ShopProductCart");

            entity.Property(e => e.CartProductId).HasColumnName("CartProductID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.ImagePath).HasMaxLength(100);
            entity.Property(e => e.InventoryQuantity).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.OrderQuantity).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.OrderStatus).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.ProductSalePrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ProductSize).HasMaxLength(50);
            entity.Property(e => e.SalePrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ShopProductInventoryId).HasColumnName("ShopProductInventoryID");
            entity.Property(e => e.StudentCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VwSportMeritStudent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_SportMeritStudent");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.UploadStudentPhoto)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwStudentAttendanceSupportLounge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_StudentAttendanceSupportLounge");

            entity.Property(e => e.FirstCheckInTime).HasColumnType("datetime");
            entity.Property(e => e.LastCheckOutTime).HasColumnType("datetime");
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.TotalTime).HasPrecision(0);
            entity.Property(e => e.YearGroup).HasMaxLength(255);
        });

        modelBuilder.Entity<VwStudentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_StudentDetails");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HomeroomCode).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.RequirementBalance).HasMaxLength(4000);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.UploadStudentPhoto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.YearGroup).HasMaxLength(255);
        });

        modelBuilder.Entity<VwStudentLunchCandidate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_StudentLunchCandidate");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Homeroomcode)
                .HasMaxLength(255)
                .HasColumnName("homeroomcode");
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.YearGroup)
                .HasMaxLength(255)
                .HasColumnName("yearGroup");
        });

        modelBuilder.Entity<VwStudentPizzaCandidate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_StudentPizzaCandidates");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Homeroomcode)
                .HasMaxLength(255)
                .HasColumnName("homeroomcode");
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.YearGroup)
                .HasMaxLength(255)
                .HasColumnName("yearGroup");
        });

        modelBuilder.Entity<VwTblResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_TblResult");

            entity.Property(e => e.Dob)
                .HasPrecision(0)
                .HasColumnName("DOB");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EventName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HouseName).HasMaxLength(255);
            entity.Property(e => e.MeetId).HasColumnName("MeetID");
            entity.Property(e => e.MeetName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MeetTypeId).HasColumnName("MeetTypeID");
            entity.Property(e => e.MeetTypeName).HasMaxLength(255);
            entity.Property(e => e.ResultId).HasColumnName("ResultID");
            entity.Property(e => e.StudentCode).HasMaxLength(255);
            entity.Property(e => e.StudentGender).HasMaxLength(10);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
        });

        modelBuilder.Entity<VwTblShopProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_TblShopProduct");

            entity.Property(e => e.Description1).HasMaxLength(50);
            entity.Property(e => e.Description2).HasMaxLength(50);
            entity.Property(e => e.ImagePath).HasMaxLength(100);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.SalePrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ShopProductId).HasColumnName("ShopProductID");
            entity.Property(e => e.Size).HasColumnName("size");
        });

        modelBuilder.Entity<VwTblShopProductInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_TblShopProductInventory");

            entity.Property(e => e.CostPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Description1).HasMaxLength(50);
            entity.Property(e => e.Description2).HasMaxLength(50);
            entity.Property(e => e.ImagePath).HasMaxLength(100);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.SalePrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ShopProductInventoryId).HasColumnName("ShopProductInventoryID");
            entity.Property(e => e.Size).HasMaxLength(100);
        });

        modelBuilder.Entity<VwTblWeightRoomInOutLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_tblWeightRoomInOutLog");

            entity.Property(e => e.CheckOutDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.GuestEmail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GuestName).HasMaxLength(255);
            entity.Property(e => e.GuestPhoneNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InOutDateTime).HasColumnType("datetime");
            entity.Property(e => e.InOutLogId)
                .ValueGeneratedOnAdd()
                .HasColumnName("InOutLogID");
            entity.Property(e => e.LogType).HasMaxLength(255);
            entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTblorder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_tblorder");

            entity.Property(e => e.ApprovedByAccountsDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedByHeadDate).HasColumnType("datetime");
            entity.Property(e => e.ItemOrdered)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderRequestDate).HasColumnType("datetime");
            entity.Property(e => e.Orderstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("orderstatus");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.Staffname)
                .HasMaxLength(511)
                .HasColumnName("staffname");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VwTeacherLunchCandidate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_TeacherLunchCandidate");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.TeacherCode).HasMaxLength(255);
            entity.Property(e => e.TeacherHomeroomId).HasColumnName("TeacherHomeroomID");
        });

        modelBuilder.Entity<VwTeacherPizzaCandidate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_TeacherPizzaCandidates");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HomeroomCode).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.TeacherCode).HasMaxLength(255);
            entity.Property(e => e.TeacherHomeroomId).HasColumnName("TeacherHomeroomID");
        });

        modelBuilder.Entity<WorkOffDeMeritsV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WorkOffDeMeritsV");

            entity.Property(e => e.DateEntered).HasPrecision(0);
            entity.Property(e => e.DemeritWorkOffEventId).HasColumnName("DemeritWorkOffEventID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.StudentName).HasMaxLength(511);
            entity.Property(e => e.Teacher).HasMaxLength(511);
            entity.Property(e => e.TeacherId).HasColumnName("TeacherID");
            entity.Property(e => e.Type)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
