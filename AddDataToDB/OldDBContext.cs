using EESV2.AddDataToDB.Models;
using Microsoft.EntityFrameworkCore;

namespace EESV2.AddDataToDB
{
    public partial class OldDBContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=IMS;Data Source=.");
        }



        public virtual DbSet<ActiveSessionsAndRequest> ActiveSessionsAndRequests { get; set; }
        public virtual DbSet<ComputersInternal> ComputersInternals { get; set; }
        public virtual DbSet<ConsistentBatchManifestsInternal> ConsistentBatchManifestsInternals { get; set; }
        public virtual DbSet<CpuUtilization> CpuUtilizations { get; set; }
        public virtual DbSet<CpuUtilizationInternal> CpuUtilizationInternals { get; set; }
        public virtual DbSet<DacsInternal> DacsInternals { get; set; }
        public virtual DbSet<DatabasesInternal> DatabasesInternals { get; set; }
        public virtual DbSet<DatafilesInternal> DatafilesInternals { get; set; }
        public virtual DbSet<DiskUsage> DiskUsages { get; set; }
        public virtual DbSet<DistinctQuery> DistinctQueries { get; set; }
        public virtual DbSet<DistinctQueryStat> DistinctQueryStats { get; set; }
        public virtual DbSet<DistinctQueryToHandle> DistinctQueryToHandles { get; set; }
        public virtual DbSet<FilegroupsInternal> FilegroupsInternals { get; set; }
        public virtual DbSet<IoVirtualFileStat> IoVirtualFileStats { get; set; }
        public virtual DbSet<LatestComputer> LatestComputers { get; set; }
        public virtual DbSet<LatestComputerCpuMemoryConfiguration> LatestComputerCpuMemoryConfigurations { get; set; }
        public virtual DbSet<LatestDac> LatestDacs { get; set; }
        public virtual DbSet<LatestDacCpuUtilization> LatestDacCpuUtilizations { get; set; }
        public virtual DbSet<LatestDatabase> LatestDatabases { get; set; }
        public virtual DbSet<LatestDatafile> LatestDatafiles { get; set; }
        public virtual DbSet<LatestFilegroup> LatestFilegroups { get; set; }
        public virtual DbSet<LatestInstanceCpuUtilization> LatestInstanceCpuUtilizations { get; set; }
        public virtual DbSet<LatestLogfile> LatestLogfiles { get; set; }
        public virtual DbSet<LatestSmoProperty> LatestSmoProperties { get; set; }
        public virtual DbSet<LatestSmoServer> LatestSmoServers { get; set; }
        public virtual DbSet<LatestVolume> LatestVolumes { get; set; }
        public virtual DbSet<LatestVolume1> LatestVolumes1 { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<LogUsage> LogUsages { get; set; }
        public virtual DbSet<LogfilesInternal> LogfilesInternals { get; set; }
        public virtual DbSet<NotableQueryPlan> NotableQueryPlans { get; set; }
        public virtual DbSet<NotableQueryText> NotableQueryTexts { get; set; }
        public virtual DbSet<Oldpersonel> Oldpersonels { get; set; }
        public virtual DbSet<Oldpishnahadat> Oldpishnahadats { get; set; }
        public virtual DbSet<Oldpishnahaddahandegan> Oldpishnahaddahandegans { get; set; }
        public virtual DbSet<Oldtx> Oldtxes { get; set; }
        public virtual DbSet<OldwordPlace> OldwordPlaces { get; set; }
        public virtual DbSet<OsLatchStat> OsLatchStats { get; set; }
        public virtual DbSet<OsMemoryClerk> OsMemoryClerks { get; set; }
        public virtual DbSet<OsMemoryNode> OsMemoryNodes { get; set; }
        public virtual DbSet<OsProcessMemory> OsProcessMemories { get; set; }
        public virtual DbSet<OsScheduler> OsSchedulers { get; set; }
        public virtual DbSet<OsWaitStat> OsWaitStats { get; set; }
        public virtual DbSet<PerformanceCounter> PerformanceCounters { get; set; }
        public virtual DbSet<PerformanceCounterInstance> PerformanceCounterInstances { get; set; }
        public virtual DbSet<PerformanceCounterReportGroupItem> PerformanceCounterReportGroupItems { get; set; }
        public virtual DbSet<PerformanceCounterValue> PerformanceCounterValues { get; set; }
        public virtual DbSet<PurgeInfoInternal> PurgeInfoInternals { get; set; }
        public virtual DbSet<QueryStat> QueryStats { get; set; }
        public virtual DbSet<SmoServersInternal> SmoServersInternals { get; set; }
        public virtual DbSet<Snapshot> Snapshots { get; set; }
        public virtual DbSet<SnapshotTimetableInternal> SnapshotTimetableInternals { get; set; }
        public virtual DbSet<SnapshotsInternal> SnapshotsInternals { get; set; }
        public virtual DbSet<SourceInfoInternal> SourceInfoInternals { get; set; }
        public virtual DbSet<SpaceUtilization> SpaceUtilizations { get; set; }
        public virtual DbSet<SpaceUtilizationInternal> SpaceUtilizationInternals { get; set; }
        public virtual DbSet<SqlProcessAndSystemMemory> SqlProcessAndSystemMemories { get; set; }
        public virtual DbSet<SupportedCollectorType> SupportedCollectorTypes { get; set; }
        public virtual DbSet<SupportedCollectorTypesInternal> SupportedCollectorTypesInternals { get; set; }
        public virtual DbSet<SysutilityUcpBatchManifestsInternal> SysutilityUcpBatchManifestsInternals { get; set; }
        public virtual DbSet<SysutilityUcpCpuMemoryConfigurationsInternal> SysutilityUcpCpuMemoryConfigurationsInternals { get; set; }
        public virtual DbSet<SysutilityUcpDacCollectedExecutionStatisticsInternal> SysutilityUcpDacCollectedExecutionStatisticsInternals { get; set; }
        public virtual DbSet<SysutilityUcpSmoPropertiesInternal> SysutilityUcpSmoPropertiesInternals { get; set; }
        public virtual DbSet<SysutilityUcpVolumesInternal> SysutilityUcpVolumesInternals { get; set; }
        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<Tbl3Level> Tbl3Levels { get; set; }
        public virtual DbSet<Tbl4Level> Tbl4Levels { get; set; }
        public virtual DbSet<TblArGroup> TblArGroups { get; set; }
        public virtual DbSet<TblArPersonel> TblArPersonels { get; set; }
        public virtual DbSet<TblArzyab> TblArzyabs { get; set; }
        public virtual DbSet<TblArzyabi> TblArzyabis { get; set; }
        public virtual DbSet<TblBazr> TblBazrs { get; set; }
        public virtual DbSet<TblCmt> TblCmts { get; set; }
        public virtual DbSet<TblDoc> TblDocs { get; set; }
        public virtual DbSet<TblDocType> TblDocTypes { get; set; }
        public virtual DbSet<TblEblagh> TblEblaghs { get; set; }
        public virtual DbSet<TblEblaghHamkar> TblEblaghHamkars { get; set; }
        public virtual DbSet<TblEblaghRep> TblEblaghReps { get; set; }
        public virtual DbSet<TblEblaghStatus> TblEblaghStatuses { get; set; }
        public virtual DbSet<TblEduPost> TblEduPosts { get; set; }
        public virtual DbSet<TblErja> TblErjas { get; set; }
        public virtual DbSet<TblErjaProb> TblErjaProbs { get; set; }
        public virtual DbSet<TblFestival> TblFestivals { get; set; }
        public virtual DbSet<TblForm> TblForms { get; set; }
        public virtual DbSet<TblIsoForm> TblIsoForms { get; set; }
        public virtual DbSet<TblLogDownload> TblLogDownloads { get; set; }
        public virtual DbSet<TblLogPrint> TblLogPrints { get; set; }
        public virtual DbSet<TblManagment> TblManagments { get; set; }
        public virtual DbSet<TblMasolePayesh> TblMasolePayeshes { get; set; }
        public virtual DbSet<TblMrc> TblMrcs { get; set; }
        public virtual DbSet<TblNatijeProp> TblNatijeProps { get; set; }
        public virtual DbSet<TblOffer> TblOffers { get; set; }
        public virtual DbSet<TblPageRole> TblPageRoles { get; set; }
        public virtual DbSet<TblPart> TblParts { get; set; }
        public virtual DbSet<TblPayesh> TblPayeshes { get; set; }
        public virtual DbSet<TblPish> TblPishes { get; set; }
        public virtual DbSet<TblProbLog> TblProbLogs { get; set; }
        public virtual DbSet<TblProp> TblProps { get; set; }
        public virtual DbSet<TblPropUnder500> TblPropUnder500s { get; set; }
        public virtual DbSet<TblProtest> TblProtests { get; set; }
        public virtual DbSet<TblReq> TblReqs { get; set; }
        public virtual DbSet<TblSemat> TblSemats { get; set; }
        public virtual DbSet<TblStateu> TblStateus { get; set; }
        public virtual DbSet<TblStatus> TblStatuses { get; set; }
        public virtual DbSet<TblStum> TblSta { get; set; }
        public virtual DbSet<TblTypeName> TblTypeNames { get; set; }
        public virtual DbSet<TblTypeReq> TblTypeReqs { get; set; }
        public virtual DbSet<TblUsPa> TblUsPas { get; set; }
        public virtual DbSet<TblUsr> TblUsrs { get; set; }
        public virtual DbSet<TblUsrMsg> TblUsrMsgs { get; set; }
        public virtual DbSet<TblWorkGroup> TblWorkGroups { get; set; }
        public virtual DbSet<TblWorkGroupPerson> TblWorkGroupPeople { get; set; }
        public virtual DbSet<TraceDatum> TraceData { get; set; }
        public virtual DbSet<TraceInfo> TraceInfos { get; set; }
        public virtual DbSet<UtilityObjectsInternal> UtilityObjectsInternals { get; set; }
        public virtual DbSet<View3level> View3levels { get; set; }
        public virtual DbSet<View4level> View4levels { get; set; }
        public virtual DbSet<ViewAllProp> ViewAllProps { get; set; }
        public virtual DbSet<ViewArGp> ViewArGps { get; set; }
        public virtual DbSet<ViewArzyab> ViewArzyabs { get; set; }
        public virtual DbSet<ViewArzyaban> ViewArzyabans { get; set; }
        public virtual DbSet<ViewArzyabi> ViewArzyabis { get; set; }
        public virtual DbSet<ViewArzyabi4arzyabBartar> ViewArzyabi4arzyabBartars { get; set; }
        public virtual DbSet<ViewArzyabiWithEmNo> ViewArzyabiWithEmNos { get; set; }
        public virtual DbSet<ViewBazr> ViewBazrs { get; set; }
        public virtual DbSet<ViewDoc> ViewDocs { get; set; }
        public virtual DbSet<ViewEblagh> ViewEblaghs { get; set; }
        public virtual DbSet<ViewEblagh4safariReport> ViewEblagh4safariReports { get; set; }
        public virtual DbSet<ViewEblaghHamkar> ViewEblaghHamkars { get; set; }
        public virtual DbSet<ViewEblaghRep> ViewEblaghReps { get; set; }
        public virtual DbSet<ViewEblaghTotalDarsadPishraft> ViewEblaghTotalDarsadPishrafts { get; set; }
        public virtual DbSet<ViewErjaAryabanLastComplete> ViewErjaAryabanLastCompletes { get; set; }
        public virtual DbSet<ViewErjaArzyab> ViewErjaArzyabs { get; set; }
        public virtual DbSet<ViewErjaArzyaban> ViewErjaArzyabans { get; set; }
        public virtual DbSet<ViewErjaArzyabanBedonePasokh> ViewErjaArzyabanBedonePasokhs { get; set; }
        public virtual DbSet<ViewErjaArzyabanLastErja> ViewErjaArzyabanLastErjas { get; set; }
        public virtual DbSet<ViewErjaArzyabanManage> ViewErjaArzyabanManages { get; set; }
        public virtual DbSet<ViewErjaKarGoroh> ViewErjaKarGorohs { get; set; }
        public virtual DbSet<ViewForm> ViewForms { get; set; }
        public virtual DbSet<ViewIso> ViewIsos { get; set; }
        public virtual DbSet<ViewLastArzyabi> ViewLastArzyabis { get; set; }
        public virtual DbSet<ViewLastErjaInbox> ViewLastErjaInboxes { get; set; }
        public virtual DbSet<ViewLogDl> ViewLogDls { get; set; }
        public virtual DbSet<ViewOffer> ViewOffers { get; set; }
        public virtual DbSet<ViewOffers2> ViewOffers2s { get; set; }
        public virtual DbSet<ViewOldPishnahadat> ViewOldPishnahadats { get; set; }
        public virtual DbSet<ViewOldpishnahad> ViewOldpishnahads { get; set; }
        public virtual DbSet<ViewPayesh4level> ViewPayesh4levels { get; set; }
        public virtual DbSet<ViewPost> ViewPosts { get; set; }
        public virtual DbSet<ViewProp> ViewProps { get; set; }
        public virtual DbSet<ViewProp4report> ViewProp4reports { get; set; }
        public virtual DbSet<ViewProp4report1> ViewProp4reports1 { get; set; }
        public virtual DbSet<ViewPropReFromAll> ViewPropReFromAlls { get; set; }
        public virtual DbSet<ViewPropWithOffer> ViewPropWithOffers { get; set; }
        public virtual DbSet<ViewPropWithOffers2> ViewPropWithOffers2s { get; set; }
        public virtual DbSet<ViewProtest> ViewProtests { get; set; }
        public virtual DbSet<ViewRepEjra> ViewRepEjras { get; set; }
        public virtual DbSet<ViewReport> ViewReports { get; set; }
        public virtual DbSet<ViewReq> ViewReqs { get; set; }
        public virtual DbSet<ViewTmp> ViewTmps { get; set; }
        public virtual DbSet<ViewTotalProb> ViewTotalProbs { get; set; }
        public virtual DbSet<ViewUnder500> ViewUnder500s { get; set; }
        public virtual DbSet<ViewUnitWithFatherUnit> ViewUnitWithFatherUnits { get; set; }
        public virtual DbSet<ViewUsr> ViewUsrs { get; set; }
        public virtual DbSet<ViewWgp> ViewWgps { get; set; }
        public virtual DbSet<VolumesInternal> VolumesInternals { get; set; }
        public virtual DbSet<WaitCategory> WaitCategories { get; set; }
        public virtual DbSet<WaitType> WaitTypes { get; set; }
        public virtual DbSet<WaitTypesCategorized> WaitTypesCategorizeds { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActiveSessionsAndRequest>(entity =>
            {
                entity.HasKey(e => new { e.SnapshotId, e.CollectionTime, e.RowId });

                entity.ToTable("active_sessions_and_requests", "snapshots");

                entity.HasIndex(e => e.BlockingSessionId, "IDX_blocking_session_id");

                entity.HasIndex(e => e.CollectionTime, "IDX_collection_time");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.RowId).HasColumnName("row_id");

                entity.Property(e => e.BlockingExecContextId).HasColumnName("blocking_exec_context_id");

                entity.Property(e => e.BlockingSessionId).HasColumnName("blocking_session_id");

                entity.Property(e => e.Command)
                    .HasMaxLength(32)
                    .HasColumnName("command");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.ExecContextId).HasColumnName("exec_context_id");

                entity.Property(e => e.ExecutingManagedCode).HasColumnName("executing_managed_code");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("host_name");

                entity.Property(e => e.IsBlocking).HasColumnName("is_blocking");

                entity.Property(e => e.IsUserProcess).HasColumnName("is_user_process");

                entity.Property(e => e.LastWaitType)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("last_wait_type");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("login_name");

                entity.Property(e => e.LoginTime).HasColumnName("login_time");

                entity.Property(e => e.MemoryUsage).HasColumnName("memory_usage");

                entity.Property(e => e.OpenResultsets).HasColumnName("open_resultsets");

                entity.Property(e => e.OpenTransactionCount).HasColumnName("open_transaction_count");

                entity.Property(e => e.PendingIoCount).HasColumnName("pending_io_count");

                entity.Property(e => e.PlanHandle)
                    .HasMaxLength(64)
                    .HasColumnName("plan_handle");

                entity.Property(e => e.PrevError).HasColumnName("prev_error");

                entity.Property(e => e.ProgramName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("program_name");

                entity.Property(e => e.RequestCpuTime).HasColumnName("request_cpu_time");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.RequestLogicalReads).HasColumnName("request_logical_reads");

                entity.Property(e => e.RequestReads).HasColumnName("request_reads");

                entity.Property(e => e.RequestStartTime).HasColumnName("request_start_time");

                entity.Property(e => e.RequestStatus)
                    .HasMaxLength(15)
                    .HasColumnName("request_status");

                entity.Property(e => e.RequestTotalElapsedTime).HasColumnName("request_total_elapsed_time");

                entity.Property(e => e.RequestWrites).HasColumnName("request_writes");

                entity.Property(e => e.ResourceDescription)
                    .IsRequired()
                    .HasMaxLength(140)
                    .HasColumnName("resource_description");

                entity.Property(e => e.SchedulerId).HasColumnName("scheduler_id");

                entity.Property(e => e.SessionCpuTime).HasColumnName("session_cpu_time");

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.SessionLastRequestEndTime).HasColumnName("session_last_request_end_time");

                entity.Property(e => e.SessionLastRequestStartTime).HasColumnName("session_last_request_start_time");

                entity.Property(e => e.SessionLogicalReads).HasColumnName("session_logical_reads");

                entity.Property(e => e.SessionReads).HasColumnName("session_reads");

                entity.Property(e => e.SessionRowCount).HasColumnName("session_row_count");

                entity.Property(e => e.SessionStatus)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("session_status");

                entity.Property(e => e.SessionTotalElapsedTime).HasColumnName("session_total_elapsed_time");

                entity.Property(e => e.SessionTotalScheduledTime).HasColumnName("session_total_scheduled_time");

                entity.Property(e => e.SessionWrites).HasColumnName("session_writes");

                entity.Property(e => e.SqlHandle)
                    .HasMaxLength(64)
                    .HasColumnName("sql_handle");

                entity.Property(e => e.StatementEndOffset).HasColumnName("statement_end_offset");

                entity.Property(e => e.StatementStartOffset).HasColumnName("statement_start_offset");

                entity.Property(e => e.TaskState)
                    .HasMaxLength(10)
                    .HasColumnName("task_state");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.TransactionIsolationLevel).HasColumnName("transaction_isolation_level");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WaitDurationMs).HasColumnName("wait_duration_ms");

                entity.Property(e => e.WaitResource)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("wait_resource");

                entity.Property(e => e.WaitType)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("wait_type");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.ActiveSessionsAndRequests)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_active_sessions_and_requests_snapshots_internal");
            });

            modelBuilder.Entity<ComputersInternal>(entity =>
            {
                entity.HasKey(e => new { e.ProcessingTime, e.PhysicalServerName });

                entity.ToTable("computers_internal", "sysutility_ucp_core");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.PhysicalServerName)
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.CpuArchitecture)
                    .HasMaxLength(64)
                    .HasColumnName("cpu_architecture");

                entity.Property(e => e.CpuCaption)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_caption");

                entity.Property(e => e.CpuClockSpeed)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cpu_clock_speed");

                entity.Property(e => e.CpuFamily)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_family");

                entity.Property(e => e.CpuMaxClockSpeed)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cpu_max_clock_speed");

                entity.Property(e => e.CpuName)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsClusteredServer).HasColumnName("is_clustered_server");

                entity.Property(e => e.L2CacheSize)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("l2_cache_size");

                entity.Property(e => e.L3CacheSize)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("l3_cache_size");

                entity.Property(e => e.NumProcessors).HasColumnName("num_processors");

                entity.Property(e => e.PercentTotalCpuUtilization).HasColumnName("percent_total_cpu_utilization");

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(4000)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.Urn)
                    .HasMaxLength(4000)
                    .HasColumnName("urn");

                entity.Property(e => e.VirtualServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("virtual_server_name");
            });

            modelBuilder.Entity<ConsistentBatchManifestsInternal>(entity =>
            {
                entity.HasKey(e => new { e.ServerInstanceName, e.BatchTime });

                entity.ToTable("consistent_batch_manifests_internal", "sysutility_ucp_staging");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");
            });

            modelBuilder.Entity<CpuUtilization>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cpu_utilization", "sysutility_ucp_core");

                entity.Property(e => e.AggregationType).HasColumnName("aggregation_type");

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.ObjectType).HasColumnName("object_type");

                entity.Property(e => e.PercentTotalCpuUtilization).HasColumnName("percent_total_cpu_utilization");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");
            });

            modelBuilder.Entity<CpuUtilizationInternal>(entity =>
            {
                entity.HasKey(e => new { e.AggregationType, e.ProcessingTime, e.ObjectType, e.PhysicalServerName, e.ServerInstanceName, e.DatabaseName })
                    .HasName("pk_cpu_utilization_internal");

                entity.ToTable("cpu_utilization_internal", "sysutility_ucp_core");

                entity.Property(e => e.AggregationType).HasColumnName("aggregation_type");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ObjectType).HasColumnName("object_type");

                entity.Property(e => e.PhysicalServerName)
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("database_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PercentTotalCpuUtilization).HasColumnName("percent_total_cpu_utilization");
            });

            modelBuilder.Entity<DacsInternal>(entity =>
            {
                entity.HasKey(e => new { e.ProcessingTime, e.ServerInstanceName, e.DacName });

                entity.ToTable("dacs_internal", "sysutility_ucp_core");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.DacName)
                    .HasMaxLength(128)
                    .HasColumnName("dac_name");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.DacDeployDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dac_deploy_date");

                entity.Property(e => e.DacDescription)
                    .HasMaxLength(4000)
                    .HasColumnName("dac_description");

                entity.Property(e => e.DacId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("dac_id");

                entity.Property(e => e.DacPercentTotalCpuUtilization).HasColumnName("dac_percent_total_cpu_utilization");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(4000)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.Urn)
                    .HasMaxLength(4000)
                    .HasColumnName("urn");
            });

            modelBuilder.Entity<DatabasesInternal>(entity =>
            {
                entity.HasKey(e => new { e.ProcessingTime, e.ServerInstanceName, e.Name });

                entity.ToTable("databases_internal", "sysutility_ucp_core");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.Collation).HasMaxLength(128);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ParentUrn)
                    .HasMaxLength(320)
                    .HasColumnName("parent_urn");

                entity.Property(e => e.PowershellPath).HasColumnName("powershell_path");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Urn)
                    .HasMaxLength(512)
                    .HasColumnName("urn");
            });

            modelBuilder.Entity<DatafilesInternal>(entity =>
            {
                entity.HasKey(e => new { e.ProcessingTime, e.ServerInstanceName, e.DatabaseName, e.FilegroupName, e.Name });

                entity.ToTable("datafiles_internal", "sysutility_ucp_core");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.FilegroupName)
                    .HasMaxLength(128)
                    .HasColumnName("filegroup_name");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.FileName).HasMaxLength(260);

                entity.Property(e => e.ParentUrn)
                    .HasMaxLength(780)
                    .HasColumnName("parent_urn");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath).HasColumnName("powershell_path");

                entity.Property(e => e.Urn)
                    .HasMaxLength(1500)
                    .HasColumnName("urn");

                entity.Property(e => e.VolumeDeviceId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("volume_device_id");

                entity.Property(e => e.VolumeName)
                    .HasMaxLength(260)
                    .HasColumnName("volume_name");
            });

            modelBuilder.Entity<DiskUsage>(entity =>
            {
                entity.HasKey(e => new { e.SnapshotId, e.CollectionTime, e.DatabaseName });

                entity.ToTable("disk_usage", "snapshots");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.Dbsize).HasColumnName("dbsize");

                entity.Property(e => e.Ftsize).HasColumnName("ftsize");

                entity.Property(e => e.Logsize).HasColumnName("logsize");

                entity.Property(e => e.Pages).HasColumnName("pages");

                entity.Property(e => e.Reservedpages).HasColumnName("reservedpages");

                entity.Property(e => e.Usedpages).HasColumnName("usedpages");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.DiskUsages)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_disk_usage_snapshots_internal");
            });

            modelBuilder.Entity<DistinctQuery>(entity =>
            {
                entity.HasKey(e => new { e.SourceId, e.DistinctQueryHash });

                entity.ToTable("distinct_queries", "snapshots");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.DistinctQueryHash).HasColumnName("distinct_query_hash");

                entity.Property(e => e.DistinctSqlText)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasColumnName("distinct_sql_text");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.DistinctQueries)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_distinct_queries_source_info_internal");
            });

            modelBuilder.Entity<DistinctQueryStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("distinct_query_stats", "snapshots");

                entity.Property(e => e.DistinctQueryHash).HasColumnName("distinct_query_hash");

                entity.Property(e => e.ExecutionCount).HasColumnName("execution_count");

                entity.Property(e => e.TotalClrTime).HasColumnName("total_clr_time");

                entity.Property(e => e.TotalElapsedTime).HasColumnName("total_elapsed_time");

                entity.Property(e => e.TotalLogicalReads).HasColumnName("total_logical_reads");

                entity.Property(e => e.TotalLogicalWrites).HasColumnName("total_logical_writes");

                entity.Property(e => e.TotalPhysicalReads).HasColumnName("total_physical_reads");

                entity.Property(e => e.TotalWorkerTime).HasColumnName("total_worker_time");
            });

            modelBuilder.Entity<DistinctQueryToHandle>(entity =>
            {
                entity.HasKey(e => new { e.SourceId, e.DistinctQueryHash, e.SqlHandle });

                entity.ToTable("distinct_query_to_handle", "snapshots");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.DistinctQueryHash).HasColumnName("distinct_query_hash");

                entity.Property(e => e.SqlHandle)
                    .HasMaxLength(64)
                    .HasColumnName("sql_handle");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.DistinctQueryToHandles)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_distinct_query_to_handle_source_info_internal");

                entity.HasOne(d => d.DistinctQuery)
                    .WithMany(p => p.DistinctQueryToHandles)
                    .HasForeignKey(d => new { d.SourceId, d.DistinctQueryHash })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_distinct_query_to_handle_distinct_queries");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.DistinctQueryToHandles)
                    .HasForeignKey(d => new { d.SourceId, d.SqlHandle })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_distinct_query_to_handle_notable_query_text");
            });

            modelBuilder.Entity<FilegroupsInternal>(entity =>
            {
                entity.HasKey(e => new { e.ProcessingTime, e.ServerInstanceName, e.DatabaseName, e.Name });

                entity.ToTable("filegroups_internal", "sysutility_ucp_core");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.ParentUrn)
                    .HasMaxLength(512)
                    .HasColumnName("parent_urn");

                entity.Property(e => e.PowershellPath).HasColumnName("powershell_path");

                entity.Property(e => e.Urn)
                    .HasMaxLength(780)
                    .HasColumnName("urn");
            });

            modelBuilder.Entity<IoVirtualFileStat>(entity =>
            {
                entity.HasKey(e => new { e.SnapshotId, e.CollectionTime, e.LogicalDisk, e.DatabaseName, e.FileId });

                entity.ToTable("io_virtual_file_stats", "snapshots");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.LogicalDisk)
                    .HasMaxLength(255)
                    .HasColumnName("logical_disk");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.DatabaseId).HasColumnName("database_id");

                entity.Property(e => e.IoStallReadMs).HasColumnName("io_stall_read_ms");

                entity.Property(e => e.IoStallWriteMs).HasColumnName("io_stall_write_ms");

                entity.Property(e => e.LogicalFileName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("logical_file_name");

                entity.Property(e => e.NumOfBytesRead).HasColumnName("num_of_bytes_read");

                entity.Property(e => e.NumOfBytesWritten).HasColumnName("num_of_bytes_written");

                entity.Property(e => e.NumOfReads).HasColumnName("num_of_reads");

                entity.Property(e => e.NumOfWrites).HasColumnName("num_of_writes");

                entity.Property(e => e.SizeOnDiskBytes).HasColumnName("size_on_disk_bytes");

                entity.Property(e => e.TypeDesc)
                    .HasMaxLength(60)
                    .HasColumnName("type_desc");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.IoVirtualFileStats)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_io_virtual_file_stats");
            });

            modelBuilder.Entity<LatestComputer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_computers", "sysutility_ucp_core");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.CpuArchitecture)
                    .HasMaxLength(64)
                    .HasColumnName("cpu_architecture");

                entity.Property(e => e.CpuCaption)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_caption");

                entity.Property(e => e.CpuClockSpeed)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cpu_clock_speed");

                entity.Property(e => e.CpuFamily)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_family");

                entity.Property(e => e.CpuMaxClockSpeed)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cpu_max_clock_speed");

                entity.Property(e => e.CpuName)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsClusteredServer).HasColumnName("is_clustered_server");

                entity.Property(e => e.L2CacheSize)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("l2_cache_size");

                entity.Property(e => e.L3CacheSize)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("l3_cache_size");

                entity.Property(e => e.NumProcessors).HasColumnName("num_processors");

                entity.Property(e => e.PercentTotalCpuUtilization).HasColumnName("percent_total_cpu_utilization");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(4000)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.Urn)
                    .HasMaxLength(4000)
                    .HasColumnName("urn");

                entity.Property(e => e.VirtualServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("virtual_server_name");
            });

            modelBuilder.Entity<LatestComputerCpuMemoryConfiguration>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_computer_cpu_memory_configuration", "sysutility_ucp_staging");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.CpuArchitecture)
                    .HasMaxLength(64)
                    .HasColumnName("cpu_architecture");

                entity.Property(e => e.CpuCaption)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_caption");

                entity.Property(e => e.CpuClockSpeed)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cpu_clock_speed");

                entity.Property(e => e.CpuFamily)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_family");

                entity.Property(e => e.CpuMaxClockSpeed)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cpu_max_clock_speed");

                entity.Property(e => e.CpuName)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_name");

                entity.Property(e => e.IsClusteredServer).HasColumnName("is_clustered_server");

                entity.Property(e => e.L2CacheSize)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("l2_cache_size");

                entity.Property(e => e.L3CacheSize)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("l3_cache_size");

                entity.Property(e => e.NumProcessors).HasColumnName("num_processors");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(294)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.ServerProcessorUsage).HasColumnName("server_processor_usage");

                entity.Property(e => e.Urn)
                    .HasMaxLength(292)
                    .HasColumnName("urn");

                entity.Property(e => e.VirtualServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("virtual_server_name");
            });

            modelBuilder.Entity<LatestDac>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_dacs", "sysutility_ucp_core");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.DacDeployDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dac_deploy_date");

                entity.Property(e => e.DacDescription)
                    .HasMaxLength(4000)
                    .HasColumnName("dac_description");

                entity.Property(e => e.DacId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("dac_id");

                entity.Property(e => e.DacName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("dac_name");

                entity.Property(e => e.DacPercentTotalCpuUtilization).HasColumnName("dac_percent_total_cpu_utilization");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(4000)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.Urn)
                    .HasMaxLength(4000)
                    .HasColumnName("urn");
            });

            modelBuilder.Entity<LatestDacCpuUtilization>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_dac_cpu_utilization", "sysutility_ucp_staging");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.DacDb)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("dac_db");

                entity.Property(e => e.DacDeployDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dac_deploy_date");

                entity.Property(e => e.DacDescription)
                    .HasMaxLength(4000)
                    .HasColumnName("dac_description");

                entity.Property(e => e.DacName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("dac_name");

                entity.Property(e => e.LatestCpuPct).HasColumnName("latest_cpu_pct");

                entity.Property(e => e.LatestIntervalCpuTimeMs).HasColumnName("latest_interval_cpu_time_ms");

                entity.Property(e => e.LatestIntervalEndTime).HasColumnName("latest_interval_end_time");

                entity.Property(e => e.LatestIntervalStartTime).HasColumnName("latest_interval_start_time");

                entity.Property(e => e.LifetimeCpuTimeMs).HasColumnName("lifetime_cpu_time_ms");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(297)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.Urn)
                    .HasMaxLength(450)
                    .HasColumnName("urn");
            });

            modelBuilder.Entity<LatestDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_databases", "sysutility_ucp_core");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.Collation).HasMaxLength(128);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ParentUrn)
                    .HasMaxLength(320)
                    .HasColumnName("parent_urn");

                entity.Property(e => e.PowershellPath).HasColumnName("powershell_path");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Urn)
                    .HasMaxLength(512)
                    .HasColumnName("urn");
            });

            modelBuilder.Entity<LatestDatafile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_datafiles", "sysutility_ucp_core");

                entity.Property(e => e.AvailableSpace).HasColumnName("available_space");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.FileName).HasMaxLength(260);

                entity.Property(e => e.FilegroupName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("filegroup_name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ParentUrn)
                    .HasMaxLength(780)
                    .HasColumnName("parent_urn");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath).HasColumnName("powershell_path");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.Urn)
                    .HasMaxLength(1500)
                    .HasColumnName("urn");

                entity.Property(e => e.VolumeDeviceId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("volume_device_id");

                entity.Property(e => e.VolumeName)
                    .HasMaxLength(260)
                    .HasColumnName("volume_name");
            });

            modelBuilder.Entity<LatestFilegroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_filegroups", "sysutility_ucp_core");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ParentUrn)
                    .HasMaxLength(512)
                    .HasColumnName("parent_urn");

                entity.Property(e => e.PowershellPath).HasColumnName("powershell_path");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.Urn)
                    .HasMaxLength(780)
                    .HasColumnName("urn");
            });

            modelBuilder.Entity<LatestInstanceCpuUtilization>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_instance_cpu_utilization", "sysutility_ucp_staging");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.InstanceProcessorUsage).HasColumnName("instance_processor_usage");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");
            });

            modelBuilder.Entity<LatestLogfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_logfiles", "sysutility_ucp_core");

                entity.Property(e => e.AvailableSpace).HasColumnName("available_space");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.FileName).HasMaxLength(260);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ParentUrn)
                    .HasMaxLength(780)
                    .HasColumnName("parent_urn");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath).HasColumnName("powershell_path");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.Urn)
                    .HasMaxLength(1500)
                    .HasColumnName("urn");

                entity.Property(e => e.VolumeDeviceId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("volume_device_id");

                entity.Property(e => e.VolumeName)
                    .HasMaxLength(260)
                    .HasColumnName("volume_name");
            });

            modelBuilder.Entity<LatestSmoProperty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_smo_properties", "sysutility_ucp_staging");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.ObjectType).HasColumnName("object_type");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(128)
                    .HasColumnName("property_name");

                entity.Property(e => e.PropertyValue)
                    .HasColumnType("sql_variant")
                    .HasColumnName("property_value");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.Urn)
                    .HasMaxLength(4000)
                    .HasColumnName("urn");
            });

            modelBuilder.Entity<LatestSmoServer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_smo_servers", "sysutility_ucp_core");

                entity.Property(e => e.BackupDirectory).HasMaxLength(260);

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.BrowserServiceAccount).HasMaxLength(128);

                entity.Property(e => e.BuildClrVersionString).HasMaxLength(20);

                entity.Property(e => e.Collation).HasMaxLength(128);

                entity.Property(e => e.CollationId).HasColumnName("CollationID");

                entity.Property(e => e.ComputerNamePhysicalNetBios)
                    .HasMaxLength(128)
                    .HasColumnName("ComputerNamePhysicalNetBIOS");

                entity.Property(e => e.DefaultFile).HasMaxLength(260);

                entity.Property(e => e.DefaultLog).HasMaxLength(260);

                entity.Property(e => e.Edition).HasMaxLength(64);

                entity.Property(e => e.ErrorLogPath).HasMaxLength(260);

                entity.Property(e => e.FilestreamShareName).HasMaxLength(260);

                entity.Property(e => e.InstallDataDirectory).HasMaxLength(260);

                entity.Property(e => e.InstallSharedDirectory).HasMaxLength(260);

                entity.Property(e => e.InstanceName).HasMaxLength(128);

                entity.Property(e => e.Language).HasMaxLength(64);

                entity.Property(e => e.MailProfile).HasMaxLength(128);

                entity.Property(e => e.MasterDblogPath)
                    .HasMaxLength(260)
                    .HasColumnName("MasterDBLogPath");

                entity.Property(e => e.MasterDbpath)
                    .HasMaxLength(260)
                    .HasColumnName("MasterDBPath");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NetName).HasMaxLength(128);

                entity.Property(e => e.Osversion)
                    .HasMaxLength(32)
                    .HasColumnName("OSVersion");

                entity.Property(e => e.Platform).HasMaxLength(32);

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(4000)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.Product).HasMaxLength(48);

                entity.Property(e => e.ProductLevel).HasMaxLength(32);

                entity.Property(e => e.ResourceVersionString).HasMaxLength(32);

                entity.Property(e => e.RootDirectory).HasMaxLength(260);

                entity.Property(e => e.ServiceAccount).HasMaxLength(128);

                entity.Property(e => e.ServiceInstanceId).HasMaxLength(64);

                entity.Property(e => e.ServiceName).HasMaxLength(64);

                entity.Property(e => e.SqlCharSetName).HasMaxLength(32);

                entity.Property(e => e.SqlDomainGroup).HasMaxLength(260);

                entity.Property(e => e.SqlSortOrderName).HasMaxLength(64);

                entity.Property(e => e.Urn)
                    .HasMaxLength(320)
                    .HasColumnName("urn");

                entity.Property(e => e.VersionString).HasMaxLength(32);
            });

            modelBuilder.Entity<LatestVolume>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_volumes", "sysutility_ucp_core");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PercentTotalSpaceUtilization).HasColumnName("percent_total_space_utilization");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(4000)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.TotalSpaceAvailable).HasColumnName("total_space_available");

                entity.Property(e => e.TotalSpaceUtilized).HasColumnName("total_space_utilized");

                entity.Property(e => e.VirtualServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("virtual_server_name");

                entity.Property(e => e.VolumeDeviceId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("volume_device_id");

                entity.Property(e => e.VolumeName)
                    .HasMaxLength(260)
                    .HasColumnName("volume_name");
            });

            modelBuilder.Entity<LatestVolume1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("latest_volumes", "sysutility_ucp_staging");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.FreeSpace).HasColumnName("free_space");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(431)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.TotalSpaceAvailable).HasColumnName("total_space_available");

                entity.Property(e => e.VirtualServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("virtual_server_name");

                entity.Property(e => e.VolumeDeviceId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("volume_device_id");

                entity.Property(e => e.VolumeName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("volume_name");
            });

            modelBuilder.Entity<Library>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LIBRARY");

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .HasColumnName("CODE")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Des)
                    .HasMaxLength(240)
                    .HasColumnName("DES")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ln)
                    .HasMaxLength(8)
                    .HasColumnName("LN")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MInf)
                    .HasMaxLength(20)
                    .HasColumnName("M_INF")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mesc)
                    .HasMaxLength(40)
                    .HasColumnName("MESC")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mescchng)
                    .HasMaxLength(40)
                    .HasColumnName("MESCCHNG")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SIn)
                    .HasMaxLength(56)
                    .HasColumnName("S_IN")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sc)
                    .HasMaxLength(4)
                    .HasColumnName("SC")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ut)
                    .HasMaxLength(8)
                    .HasColumnName("UT")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<LogUsage>(entity =>
            {
                entity.HasKey(e => new { e.SnapshotId, e.CollectionTime, e.DatabaseName });

                entity.ToTable("log_usage", "snapshots");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.LogSizeMb).HasColumnName("log_size_mb");

                entity.Property(e => e.LogSpaceUsed).HasColumnName("log_space_used");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.LogUsages)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_log_usage_snapshots_internal");
            });

            modelBuilder.Entity<LogfilesInternal>(entity =>
            {
                entity.HasKey(e => new { e.ProcessingTime, e.ServerInstanceName, e.DatabaseName, e.Name });

                entity.ToTable("logfiles_internal", "sysutility_ucp_core");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.FileName).HasMaxLength(260);

                entity.Property(e => e.ParentUrn)
                    .HasMaxLength(780)
                    .HasColumnName("parent_urn");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PowershellPath).HasColumnName("powershell_path");

                entity.Property(e => e.Urn)
                    .HasMaxLength(1500)
                    .HasColumnName("urn");

                entity.Property(e => e.VolumeDeviceId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("volume_device_id");

                entity.Property(e => e.VolumeName)
                    .HasMaxLength(260)
                    .HasColumnName("volume_name");
            });

            modelBuilder.Entity<NotableQueryPlan>(entity =>
            {
                entity.HasKey(e => new { e.SourceId, e.SqlHandle, e.PlanHandle, e.StatementStartOffset, e.StatementEndOffset, e.CreationTime, e.PlanGenerationNum });

                entity.ToTable("notable_query_plan", "snapshots");

                entity.HasIndex(e => new { e.SourceId, e.PlanHandle, e.StatementStartOffset, e.StatementEndOffset, e.CreationTime }, "IDX_notable_query_plan_plan_handle");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.SqlHandle)
                    .HasMaxLength(64)
                    .HasColumnName("sql_handle");

                entity.Property(e => e.PlanHandle)
                    .HasMaxLength(64)
                    .HasColumnName("plan_handle");

                entity.Property(e => e.StatementStartOffset).HasColumnName("statement_start_offset");

                entity.Property(e => e.StatementEndOffset).HasColumnName("statement_end_offset");

                entity.Property(e => e.CreationTime).HasColumnName("creation_time");

                entity.Property(e => e.PlanGenerationNum).HasColumnName("plan_generation_num");

                entity.Property(e => e.DatabaseId).HasColumnName("database_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(128)
                    .HasColumnName("object_name");

                entity.Property(e => e.QueryPlan).HasColumnName("query_plan");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.NotableQueryPlans)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_notable_query_plan_source_info_internal");
            });

            modelBuilder.Entity<NotableQueryText>(entity =>
            {
                entity.HasKey(e => new { e.SourceId, e.SqlHandle });

                entity.ToTable("notable_query_text", "snapshots");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.SqlHandle)
                    .HasMaxLength(64)
                    .HasColumnName("sql_handle");

                entity.Property(e => e.DatabaseId).HasColumnName("database_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(128)
                    .HasColumnName("object_name");

                entity.Property(e => e.SqlText).HasColumnName("sql_text");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.NotableQueryTexts)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_notable_query_text_source_info_internal");
            });

            modelBuilder.Entity<Oldpersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLDPersonel");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fam)
                    .HasMaxLength(100)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PersonCode)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<Oldpishnahadat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLDPishnahadat");

                entity.Property(e => e.DalileAdamEjra)
                    .HasMaxLength(400)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.DigarP)
                    .HasMaxLength(400)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Hadaya)
                    .HasMaxLength(400)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.NamePishnahadDahande)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NazaryehKarshenas)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Onvan)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PadashHamkariEjrai).HasColumnType("money");

                entity.Property(e => e.PadashKarshenasiArzyabi).HasColumnType("money");

                entity.Property(e => e.PadashOk).HasColumnName("PadashOK");

                entity.Property(e => e.PadashPishnahad).HasColumnType("money");

                entity.Property(e => e.Pasokh)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PersonelCode)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeJooeArzi).HasColumnType("money");

                entity.Property(e => e.SoodSarfe).HasColumnType("money");

                entity.Property(e => e.TarikhJalaseShora).HasColumnType("datetime");

                entity.Property(e => e.TarikhPayaneEjra).HasColumnType("datetime");

                entity.Property(e => e.TarikhSabt).HasColumnType("datetime");

                entity.Property(e => e.TarikhTasvib).HasColumnType("datetime");

                entity.Property(e => e.Wpcode).HasColumnName("WPCode");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Oldpishnahaddahandegan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLDPishnahaddahandegan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PersonelCode)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<Oldtx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLDTX");

                entity.Property(e => e.Eghdam)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NamPishnahadDaha)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NamVahed)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NoePish)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Onvan)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ShomarePish)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TarihJalase)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TarikhErsal)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TarikhSabt)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Vaziat)
                    .HasMaxLength(1020)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<OldwordPlace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OLDWordPlace");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(128)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Wcode).HasColumnName("wcode");
            });

            modelBuilder.Entity<OsLatchStat>(entity =>
            {
                entity.HasKey(e => new { e.SnapshotId, e.CollectionTime, e.LatchClass });

                entity.ToTable("os_latch_stats", "snapshots");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.LatchClass)
                    .HasMaxLength(45)
                    .HasColumnName("latch_class");

                entity.Property(e => e.WaitTimeMs).HasColumnName("wait_time_ms");

                entity.Property(e => e.WaitingRequestsCount).HasColumnName("waiting_requests_count");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.OsLatchStats)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_os_latch_stats_snapshots_internal");
            });

            modelBuilder.Entity<OsMemoryClerk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("os_memory_clerks", "snapshots");

                entity.HasIndex(e => new { e.SnapshotId, e.CollectionTime }, "CIDX_os_memory_clerks")
                    .IsClustered();

                entity.Property(e => e.AweAllocatedKb).HasColumnName("awe_allocated_kb");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.MemoryNodeId).HasColumnName("memory_node_id");

                entity.Property(e => e.MultiPagesKb).HasColumnName("multi_pages_kb");

                entity.Property(e => e.SharedMemoryCommittedKb).HasColumnName("shared_memory_committed_kb");

                entity.Property(e => e.SharedMemoryReservedKb).HasColumnName("shared_memory_reserved_kb");

                entity.Property(e => e.SinglePagesKb).HasColumnName("single_pages_kb");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(60)
                    .HasColumnName("type");

                entity.Property(e => e.VirtualMemoryCommittedKb).HasColumnName("virtual_memory_committed_kb");

                entity.Property(e => e.VirtualMemoryReservedKb).HasColumnName("virtual_memory_reserved_kb");

                entity.HasOne(d => d.Snapshot)
                    .WithMany()
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_os_memory_clerks_snapshots_internal");
            });

            modelBuilder.Entity<OsMemoryNode>(entity =>
            {
                entity.HasKey(e => new { e.SnapshotId, e.CollectionTime, e.MemoryNodeId });

                entity.ToTable("os_memory_nodes", "snapshots");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.MemoryNodeId).HasColumnName("memory_node_id");

                entity.Property(e => e.LockedPageAllocationsKb).HasColumnName("locked_page_allocations_kb");

                entity.Property(e => e.MultiPagesKb).HasColumnName("multi_pages_kb");

                entity.Property(e => e.SharedMemoryCommittedKb).HasColumnName("shared_memory_committed_kb");

                entity.Property(e => e.SharedMemoryReservedKb).HasColumnName("shared_memory_reserved_kb");

                entity.Property(e => e.SinglePagesKb).HasColumnName("single_pages_kb");

                entity.Property(e => e.VirtualAddressSpaceCommittedKb).HasColumnName("virtual_address_space_committed_kb");

                entity.Property(e => e.VirtualAddressSpaceReservedKb).HasColumnName("virtual_address_space_reserved_kb");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.OsMemoryNodes)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_os_memory_nodes_snapshots_internal");
            });

            modelBuilder.Entity<OsProcessMemory>(entity =>
            {
                entity.HasKey(e => new { e.SnapshotId, e.CollectionTime });

                entity.ToTable("os_process_memory", "snapshots");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.AvailableCommitLimitKb).HasColumnName("available_commit_limit_kb");

                entity.Property(e => e.LargePageAllocationsKb).HasColumnName("large_page_allocations_kb");

                entity.Property(e => e.LockedPageAllocationsKb).HasColumnName("locked_page_allocations_kb");

                entity.Property(e => e.MemoryUtilizationPercentage).HasColumnName("memory_utilization_percentage");

                entity.Property(e => e.PageFaultCount).HasColumnName("page_fault_count");

                entity.Property(e => e.PhysicalMemoryInUseKb).HasColumnName("physical_memory_in_use_kb");

                entity.Property(e => e.ProcessPhysicalMemoryLow).HasColumnName("process_physical_memory_low");

                entity.Property(e => e.ProcessVirtualMemoryLow).HasColumnName("process_virtual_memory_low");

                entity.Property(e => e.TotalVirtualAddressSpaceKb).HasColumnName("total_virtual_address_space_kb");

                entity.Property(e => e.VirtualAddressSpaceAvailableKb).HasColumnName("virtual_address_space_available_kb");

                entity.Property(e => e.VirtualAddressSpaceCommittedKb).HasColumnName("virtual_address_space_committed_kb");

                entity.Property(e => e.VirtualAddressSpaceReservedKb).HasColumnName("virtual_address_space_reserved_kb");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.OsProcessMemories)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_os_process_memory_snapshots_internal");
            });

            modelBuilder.Entity<OsScheduler>(entity =>
            {
                entity.HasKey(e => new { e.SnapshotId, e.CollectionTime, e.SchedulerId });

                entity.ToTable("os_schedulers", "snapshots");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.SchedulerId).HasColumnName("scheduler_id");

                entity.Property(e => e.ContextSwitchesCount).HasColumnName("context_switches_count");

                entity.Property(e => e.CpuId).HasColumnName("cpu_id");

                entity.Property(e => e.CurrentTasksCount).HasColumnName("current_tasks_count");

                entity.Property(e => e.IsIdle).HasColumnName("is_idle");

                entity.Property(e => e.ParentNodeId).HasColumnName("parent_node_id");

                entity.Property(e => e.PendingDiskIoCount).HasColumnName("pending_disk_io_count");

                entity.Property(e => e.PreemptiveSwitchesCount).HasColumnName("preemptive_switches_count");

                entity.Property(e => e.RunnableTasksCount).HasColumnName("runnable_tasks_count");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("status");

                entity.Property(e => e.WorkQueueCount).HasColumnName("work_queue_count");

                entity.Property(e => e.YieldCount).HasColumnName("yield_count");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.OsSchedulers)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_os_schedulers_snapshots_internal");
            });

            modelBuilder.Entity<OsWaitStat>(entity =>
            {
                entity.HasKey(e => new { e.SnapshotId, e.CollectionTime, e.WaitType });

                entity.ToTable("os_wait_stats", "snapshots");

                entity.HasIndex(e => new { e.CollectionTime, e.SnapshotId }, "IDX_os_wait_stats1");

                entity.HasIndex(e => new { e.SnapshotId, e.CollectionTime }, "IDX_os_wait_stats2");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.WaitType)
                    .HasMaxLength(45)
                    .HasColumnName("wait_type");

                entity.Property(e => e.SignalWaitTimeMs).HasColumnName("signal_wait_time_ms");

                entity.Property(e => e.WaitTimeMs).HasColumnName("wait_time_ms");

                entity.Property(e => e.WaitingTasksCount).HasColumnName("waiting_tasks_count");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.OsWaitStats)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_os_wait_stats_snapshots_internal");
            });

            modelBuilder.Entity<PerformanceCounter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("performance_counters", "snapshots");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.FormattedValue).HasColumnName("formatted_value");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("path");

                entity.Property(e => e.PerformanceCounterId).HasColumnName("performance_counter_id");

                entity.Property(e => e.PerformanceCounterName)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("performance_counter_name");

                entity.Property(e => e.PerformanceInstanceName)
                    .HasMaxLength(2048)
                    .HasColumnName("performance_instance_name");

                entity.Property(e => e.PerformanceObjectName)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("performance_object_name");

                entity.Property(e => e.RawValueFirst).HasColumnName("raw_value_first");

                entity.Property(e => e.RawValueSecond).HasColumnName("raw_value_second");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");
            });

            modelBuilder.Entity<PerformanceCounterInstance>(entity =>
            {
                entity.HasKey(e => e.PerformanceCounterId);

                entity.ToTable("performance_counter_instances", "snapshots");

                entity.HasIndex(e => new { e.ObjectName, e.CounterName }, "IDX_performance_counter_instances1");

                entity.HasIndex(e => e.Path, "UN_performance_counter_path")
                    .IsUnique();

                entity.Property(e => e.PerformanceCounterId).HasColumnName("performance_counter_id");

                entity.Property(e => e.CounterName)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("counter_name");

                entity.Property(e => e.CounterType).HasColumnName("counter_type");

                entity.Property(e => e.InstanceName)
                    .HasMaxLength(2048)
                    .HasColumnName("instance_name");

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("object_name");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<PerformanceCounterReportGroupItem>(entity =>
            {
                entity.HasKey(e => e.CounterGroupItemId)
                    .HasName("PK__performa__FF3FA0801F26B388");

                entity.ToTable("performance_counter_report_group_items", "core");

                entity.Property(e => e.CounterGroupItemId).HasColumnName("counter_group_item_id");

                entity.Property(e => e.CounterGroupId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("counter_group_id");

                entity.Property(e => e.CounterName)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("counter_name");

                entity.Property(e => e.CounterSubgroupId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("counter_subgroup_id");

                entity.Property(e => e.DivideByCpuCount).HasColumnName("divide_by_cpu_count");

                entity.Property(e => e.InstanceName)
                    .HasMaxLength(2048)
                    .HasColumnName("instance_name");

                entity.Property(e => e.MultiplyBy)
                    .HasColumnType("numeric(28, 10)")
                    .HasColumnName("multiply_by");

                entity.Property(e => e.NotInstanceName)
                    .HasMaxLength(2048)
                    .HasColumnName("not_instance_name");

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("object_name");

                entity.Property(e => e.ObjectNameWildcards).HasColumnName("object_name_wildcards");

                entity.Property(e => e.SeriesName)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasColumnName("series_name");
            });

            modelBuilder.Entity<PerformanceCounterValue>(entity =>
            {
                entity.HasKey(e => new { e.PerformanceCounterInstanceId, e.SnapshotId, e.CollectionTime });

                entity.ToTable("performance_counter_values", "snapshots");

                entity.HasIndex(e => new { e.SnapshotId, e.PerformanceCounterInstanceId, e.CollectionTime }, "IDX_performance_counter_values1");

                entity.Property(e => e.PerformanceCounterInstanceId).HasColumnName("performance_counter_instance_id");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.FormattedValue).HasColumnName("formatted_value");

                entity.Property(e => e.RawValueFirst).HasColumnName("raw_value_first");

                entity.Property(e => e.RawValueSecond).HasColumnName("raw_value_second");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.PerformanceCounterValues)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_performance_counter_values_snapshot_id");
            });

            modelBuilder.Entity<PurgeInfoInternal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("purge_info_internal", "core");

                entity.Property(e => e.StopPurge).HasColumnName("stop_purge");
            });

            modelBuilder.Entity<QueryStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("query_stats", "snapshots");

                entity.HasIndex(e => new { e.SnapshotId, e.CollectionTime, e.SqlHandle, e.StatementStartOffset, e.StatementEndOffset, e.PlanHandle }, "CIDX_query_stats")
                    .IsClustered();

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.CreationTime).HasColumnName("creation_time");

                entity.Property(e => e.ExecutionCount).HasColumnName("execution_count");

                entity.Property(e => e.LastExecutionTime).HasColumnName("last_execution_time");

                entity.Property(e => e.MaxClrTime).HasColumnName("max_clr_time");

                entity.Property(e => e.MaxElapsedTime).HasColumnName("max_elapsed_time");

                entity.Property(e => e.MaxLogicalReads).HasColumnName("max_logical_reads");

                entity.Property(e => e.MaxLogicalWrites).HasColumnName("max_logical_writes");

                entity.Property(e => e.MaxPhysicalReads).HasColumnName("max_physical_reads");

                entity.Property(e => e.MaxWorkerTime).HasColumnName("max_worker_time");

                entity.Property(e => e.MinClrTime).HasColumnName("min_clr_time");

                entity.Property(e => e.MinElapsedTime).HasColumnName("min_elapsed_time");

                entity.Property(e => e.MinLogicalReads).HasColumnName("min_logical_reads");

                entity.Property(e => e.MinLogicalWrites).HasColumnName("min_logical_writes");

                entity.Property(e => e.MinPhysicalReads).HasColumnName("min_physical_reads");

                entity.Property(e => e.MinWorkerTime).HasColumnName("min_worker_time");

                entity.Property(e => e.PlanGenerationNum).HasColumnName("plan_generation_num");

                entity.Property(e => e.PlanHandle)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("plan_handle");

                entity.Property(e => e.SnapshotClrTime).HasColumnName("snapshot_clr_time");

                entity.Property(e => e.SnapshotElapsedTime).HasColumnName("snapshot_elapsed_time");

                entity.Property(e => e.SnapshotExecutionCount).HasColumnName("snapshot_execution_count");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.SnapshotLogicalReads).HasColumnName("snapshot_logical_reads");

                entity.Property(e => e.SnapshotLogicalWrites).HasColumnName("snapshot_logical_writes");

                entity.Property(e => e.SnapshotPhysicalReads).HasColumnName("snapshot_physical_reads");

                entity.Property(e => e.SnapshotWorkerTime).HasColumnName("snapshot_worker_time");

                entity.Property(e => e.SqlHandle)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("sql_handle");

                entity.Property(e => e.StatementEndOffset).HasColumnName("statement_end_offset");

                entity.Property(e => e.StatementStartOffset).HasColumnName("statement_start_offset");

                entity.Property(e => e.TotalClrTime).HasColumnName("total_clr_time");

                entity.Property(e => e.TotalElapsedTime).HasColumnName("total_elapsed_time");

                entity.Property(e => e.TotalLogicalReads).HasColumnName("total_logical_reads");

                entity.Property(e => e.TotalLogicalWrites).HasColumnName("total_logical_writes");

                entity.Property(e => e.TotalPhysicalReads).HasColumnName("total_physical_reads");

                entity.Property(e => e.TotalWorkerTime).HasColumnName("total_worker_time");

                entity.HasOne(d => d.Snapshot)
                    .WithMany()
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_query_stats_snapshots_internal");
            });

            modelBuilder.Entity<SmoServersInternal>(entity =>
            {
                entity.HasKey(e => new { e.ProcessingTime, e.Name });

                entity.ToTable("smo_servers_internal", "sysutility_ucp_core");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.BackupDirectory).HasMaxLength(260);

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.BrowserServiceAccount).HasMaxLength(128);

                entity.Property(e => e.BuildClrVersionString).HasMaxLength(20);

                entity.Property(e => e.Collation).HasMaxLength(128);

                entity.Property(e => e.CollationId).HasColumnName("CollationID");

                entity.Property(e => e.ComputerNamePhysicalNetBios)
                    .HasMaxLength(128)
                    .HasColumnName("ComputerNamePhysicalNetBIOS");

                entity.Property(e => e.DefaultFile).HasMaxLength(260);

                entity.Property(e => e.DefaultLog).HasMaxLength(260);

                entity.Property(e => e.Edition).HasMaxLength(64);

                entity.Property(e => e.ErrorLogPath).HasMaxLength(260);

                entity.Property(e => e.FilestreamShareName).HasMaxLength(260);

                entity.Property(e => e.InstallDataDirectory).HasMaxLength(260);

                entity.Property(e => e.InstallSharedDirectory).HasMaxLength(260);

                entity.Property(e => e.InstanceName).HasMaxLength(128);

                entity.Property(e => e.Language).HasMaxLength(64);

                entity.Property(e => e.MailProfile).HasMaxLength(128);

                entity.Property(e => e.MasterDblogPath)
                    .HasMaxLength(260)
                    .HasColumnName("MasterDBLogPath");

                entity.Property(e => e.MasterDbpath)
                    .HasMaxLength(260)
                    .HasColumnName("MasterDBPath");

                entity.Property(e => e.NetName).HasMaxLength(128);

                entity.Property(e => e.Osversion)
                    .HasMaxLength(32)
                    .HasColumnName("OSVersion");

                entity.Property(e => e.Platform).HasMaxLength(32);

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(4000)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.Product).HasMaxLength(48);

                entity.Property(e => e.ProductLevel).HasMaxLength(32);

                entity.Property(e => e.ResourceVersionString).HasMaxLength(32);

                entity.Property(e => e.RootDirectory).HasMaxLength(260);

                entity.Property(e => e.ServiceAccount).HasMaxLength(128);

                entity.Property(e => e.ServiceInstanceId).HasMaxLength(64);

                entity.Property(e => e.ServiceName).HasMaxLength(64);

                entity.Property(e => e.SqlCharSetName).HasMaxLength(32);

                entity.Property(e => e.SqlDomainGroup).HasMaxLength(260);

                entity.Property(e => e.SqlSortOrderName).HasMaxLength(64);

                entity.Property(e => e.Urn)
                    .HasMaxLength(320)
                    .HasColumnName("urn");

                entity.Property(e => e.VersionString).HasMaxLength(32);
            });

            modelBuilder.Entity<Snapshot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("snapshots", "core");

                entity.Property(e => e.CollectionSetUid).HasColumnName("collection_set_uid");

                entity.Property(e => e.InstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("instance_name")
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("operator");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.SnapshotTime).HasColumnName("snapshot_time");

                entity.Property(e => e.SnapshotTimeId).HasColumnName("snapshot_time_id");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.ValidThrough).HasColumnName("valid_through");
            });

            modelBuilder.Entity<SnapshotTimetableInternal>(entity =>
            {
                entity.HasKey(e => e.SnapshotTimeId)
                    .HasName("PK_snapshots_timetable_internal");

                entity.ToTable("snapshot_timetable_internal", "core");

                entity.HasIndex(e => e.SnapshotTime, "IDX_snapshot_time");

                entity.Property(e => e.SnapshotTimeId).HasColumnName("snapshot_time_id");

                entity.Property(e => e.SnapshotTime).HasColumnName("snapshot_time");
            });

            modelBuilder.Entity<SnapshotsInternal>(entity =>
            {
                entity.HasKey(e => e.SnapshotId);

                entity.ToTable("snapshots_internal", "core");

                entity.HasIndex(e => new { e.SnapshotTimeId, e.SourceId }, "IDX_snapshot_time_id");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.SnapshotTimeId).HasColumnName("snapshot_time_id");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.HasOne(d => d.SnapshotTime)
                    .WithMany(p => p.SnapshotsInternals)
                    .HasForeignKey(d => d.SnapshotTimeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_snapshots_snapshots_timetable");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.SnapshotsInternals)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_snapshots_source_info");
            });

            modelBuilder.Entity<SourceInfoInternal>(entity =>
            {
                entity.HasKey(e => e.SourceId);

                entity.ToTable("source_info_internal", "core");

                entity.HasIndex(e => new { e.CollectionSetUid, e.InstanceName, e.Operator }, "UQ_collection_set_uid_instance_name")
                    .IsUnique();

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.CollectionSetUid).HasColumnName("collection_set_uid");

                entity.Property(e => e.DaysUntilExpiration).HasColumnName("days_until_expiration");

                entity.Property(e => e.InstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("instance_name")
                    .UseCollation("Latin1_General_CI_AI");

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("operator");
            });

            modelBuilder.Entity<SpaceUtilization>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("space_utilization", "sysutility_ucp_core");

                entity.Property(e => e.AggregationType).HasColumnName("aggregation_type");

                entity.Property(e => e.AllocatedSpaceBytes).HasColumnName("allocated_space_bytes");

                entity.Property(e => e.AvailableSpaceBytes).HasColumnName("available_space_bytes");

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("database_name");

                entity.Property(e => e.DbfileName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("dbfile_name");

                entity.Property(e => e.FilegroupName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("filegroup_name");

                entity.Property(e => e.ObjectType).HasColumnName("object_type");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.TotalSpaceBytes).HasColumnName("total_space_bytes");

                entity.Property(e => e.UsedSpaceBytes).HasColumnName("used_space_bytes");

                entity.Property(e => e.VirtualServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("virtual_server_name");

                entity.Property(e => e.VolumeDeviceId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("volume_device_id");
            });

            modelBuilder.Entity<SpaceUtilizationInternal>(entity =>
            {
                entity.HasKey(e => new { e.AggregationType, e.ProcessingTime, e.ObjectType, e.VirtualServerName, e.VolumeDeviceId, e.ServerInstanceName, e.DatabaseName, e.FilegroupName, e.DbfileName })
                    .HasName("pk_storage_utilization");

                entity.ToTable("space_utilization_internal", "sysutility_ucp_core");

                entity.Property(e => e.AggregationType).HasColumnName("aggregation_type");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.ObjectType).HasColumnName("object_type");

                entity.Property(e => e.VirtualServerName)
                    .HasMaxLength(128)
                    .HasColumnName("virtual_server_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.VolumeDeviceId)
                    .HasMaxLength(128)
                    .HasColumnName("volume_device_id")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("database_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FilegroupName)
                    .HasMaxLength(128)
                    .HasColumnName("filegroup_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DbfileName)
                    .HasMaxLength(128)
                    .HasColumnName("dbfile_name")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AllocatedSpaceBytes).HasColumnName("allocated_space_bytes");

                entity.Property(e => e.AvailableSpaceBytes).HasColumnName("available_space_bytes");

                entity.Property(e => e.TotalSpaceBytes).HasColumnName("total_space_bytes");

                entity.Property(e => e.UsedSpaceBytes).HasColumnName("used_space_bytes");
            });

            modelBuilder.Entity<SqlProcessAndSystemMemory>(entity =>
            {
                entity.HasKey(e => new { e.SnapshotId, e.CollectionTime });

                entity.ToTable("sql_process_and_system_memory", "snapshots");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.BpoolCommitTarget).HasColumnName("bpool_commit_target");

                entity.Property(e => e.BpoolCommitted).HasColumnName("bpool_committed");

                entity.Property(e => e.BpoolVisible).HasColumnName("bpool_visible");

                entity.Property(e => e.SqlAvailableCommitLimitKb).HasColumnName("sql_available_commit_limit_kb");

                entity.Property(e => e.SqlLargePageAllocationsKb).HasColumnName("sql_large_page_allocations_kb");

                entity.Property(e => e.SqlLockedPageAllocationsKb).HasColumnName("sql_locked_page_allocations_kb");

                entity.Property(e => e.SqlMemoryUtilizationPercentage).HasColumnName("sql_memory_utilization_percentage");

                entity.Property(e => e.SqlPageFaultCount).HasColumnName("sql_page_fault_count");

                entity.Property(e => e.SqlPhysicalMemoryInUseKb).HasColumnName("sql_physical_memory_in_use_kb");

                entity.Property(e => e.SqlProcessPhysicalMemoryLow).HasColumnName("sql_process_physical_memory_low");

                entity.Property(e => e.SqlProcessVirtualMemoryLow).HasColumnName("sql_process_virtual_memory_low");

                entity.Property(e => e.SqlTotalVirtualAddressSpaceKb).HasColumnName("sql_total_virtual_address_space_kb");

                entity.Property(e => e.SqlVirtualAddressSpaceAvailableKb).HasColumnName("sql_virtual_address_space_available_kb");

                entity.Property(e => e.SqlVirtualAddressSpaceCommittedKb).HasColumnName("sql_virtual_address_space_committed_kb");

                entity.Property(e => e.SqlVirtualAddressSpaceReservedKb).HasColumnName("sql_virtual_address_space_reserved_kb");

                entity.Property(e => e.SystemAvailablePageFileKb).HasColumnName("system_available_page_file_kb");

                entity.Property(e => e.SystemAvailablePhysicalMemoryKb).HasColumnName("system_available_physical_memory_kb");

                entity.Property(e => e.SystemCacheKb).HasColumnName("system_cache_kb");

                entity.Property(e => e.SystemHighMemorySignalState).HasColumnName("system_high_memory_signal_state");

                entity.Property(e => e.SystemKernelNonpagedPoolKb).HasColumnName("system_kernel_nonpaged_pool_kb");

                entity.Property(e => e.SystemKernelPagedPoolKb).HasColumnName("system_kernel_paged_pool_kb");

                entity.Property(e => e.SystemLowMemorySignalState).HasColumnName("system_low_memory_signal_state");

                entity.Property(e => e.SystemTotalPageFileKb).HasColumnName("system_total_page_file_kb");

                entity.Property(e => e.SystemTotalPhysicalMemoryKb).HasColumnName("system_total_physical_memory_kb");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.SqlProcessAndSystemMemories)
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_sql_process_and_system_memory_internal");
            });

            modelBuilder.Entity<SupportedCollectorType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("supported_collector_types", "core");

                entity.Property(e => e.CollectorTypeUid).HasColumnName("collector_type_uid");
            });

            modelBuilder.Entity<SupportedCollectorTypesInternal>(entity =>
            {
                entity.HasKey(e => e.CollectorTypeUid);

                entity.ToTable("supported_collector_types_internal", "core");

                entity.Property(e => e.CollectorTypeUid)
                    .ValueGeneratedNever()
                    .HasColumnName("collector_type_uid");
            });

            modelBuilder.Entity<SysutilityUcpBatchManifestsInternal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sysutility_ucp_batch_manifests_internal", "snapshots");

                entity.HasIndex(e => e.SnapshotId, "CI_sysutility_ucp_batch_manifests_internal")
                    .IsClustered();

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("parameter_name");

                entity.Property(e => e.ParameterValue)
                    .HasColumnType("sql_variant")
                    .HasColumnName("parameter_value");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.HasOne(d => d.Snapshot)
                    .WithMany()
                    .HasForeignKey(d => d.SnapshotId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_sysutility_ucp_batch_manifests_internal");
            });

            modelBuilder.Entity<SysutilityUcpCpuMemoryConfigurationsInternal>(entity =>
            {
                entity.HasKey(e => new { e.ServerInstanceName, e.BatchTime, e.PhysicalServerName })
                    .HasName("PK_sysutility_cpu_memory_related_info_internal_clustered");

                entity.ToTable("sysutility_ucp_cpu_memory_configurations_internal", "snapshots");

                entity.HasIndex(e => e.SnapshotId, "NCI_sysutility_ucp_cpu_memory_configurations_internal");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.PhysicalServerName)
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.CpuArchitecture)
                    .HasMaxLength(64)
                    .HasColumnName("cpu_architecture");

                entity.Property(e => e.CpuCaption)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_caption");

                entity.Property(e => e.CpuClockSpeed)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cpu_clock_speed");

                entity.Property(e => e.CpuFamily)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_family");

                entity.Property(e => e.CpuMaxClockSpeed)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("cpu_max_clock_speed");

                entity.Property(e => e.CpuName)
                    .HasMaxLength(128)
                    .HasColumnName("cpu_name");

                entity.Property(e => e.InstanceProcessorUsage).HasColumnName("instance_processor_usage");

                entity.Property(e => e.IsClusteredServer).HasColumnName("is_clustered_server");

                entity.Property(e => e.L2CacheSize)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("l2_cache_size");

                entity.Property(e => e.L3CacheSize)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("l3_cache_size");

                entity.Property(e => e.NumProcessors).HasColumnName("num_processors");

                entity.Property(e => e.ServerProcessorUsage).HasColumnName("server_processor_usage");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.VirtualServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("virtual_server_name");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.SysutilityUcpCpuMemoryConfigurationsInternals)
                    .HasForeignKey(d => d.SnapshotId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_sysutility_cpu_memory_related_info_snapshots_internal_snapshots_internal");
            });

            modelBuilder.Entity<SysutilityUcpDacCollectedExecutionStatisticsInternal>(entity =>
            {
                entity.HasKey(e => new { e.ServerInstanceName, e.BatchTime, e.DacName });

                entity.ToTable("sysutility_ucp_dac_collected_execution_statistics_internal", "snapshots");

                entity.HasIndex(e => e.SnapshotId, "NCI_sysutility_ucp_dac_collected_execution_statistics_internal");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.DacName)
                    .HasMaxLength(128)
                    .HasColumnName("dac_name");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.DacDb)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("dac_db");

                entity.Property(e => e.DacDeployDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dac_deploy_date");

                entity.Property(e => e.DacDescription)
                    .HasMaxLength(4000)
                    .HasColumnName("dac_description");

                entity.Property(e => e.IntervalCpuPct).HasColumnName("interval_cpu_pct");

                entity.Property(e => e.IntervalCpuTimeMs).HasColumnName("interval_cpu_time_ms");

                entity.Property(e => e.IntervalEndTime).HasColumnName("interval_end_time");

                entity.Property(e => e.IntervalStartTime).HasColumnName("interval_start_time");

                entity.Property(e => e.LifetimeCpuTimeMs).HasColumnName("lifetime_cpu_time_ms");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.SysutilityUcpDacCollectedExecutionStatisticsInternals)
                    .HasForeignKey(d => d.SnapshotId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_dac_collected_execution_statistics_internal_snapshots_internal");
            });

            modelBuilder.Entity<SysutilityUcpSmoPropertiesInternal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sysutility_ucp_smo_properties_internal", "snapshots");

                entity.HasIndex(e => new { e.ServerInstanceName, e.BatchTime }, "CI_sysutility_ucp_smo_properties_internal")
                    .IsClustered();

                entity.HasIndex(e => e.SnapshotId, "NCI_sysutility_ucp_smo_properties_internal");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.ObjectType).HasColumnName("object_type");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(128)
                    .HasColumnName("property_name");

                entity.Property(e => e.PropertyValue)
                    .HasColumnType("sql_variant")
                    .HasColumnName("property_value");

                entity.Property(e => e.ServerInstanceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.Urn)
                    .HasMaxLength(4000)
                    .HasColumnName("urn");

                entity.HasOne(d => d.Snapshot)
                    .WithMany()
                    .HasForeignKey(d => d.SnapshotId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_sysutility_ucp_smo_properties_internal_snapshots_internal");
            });

            modelBuilder.Entity<SysutilityUcpVolumesInternal>(entity =>
            {
                entity.HasKey(e => new { e.ServerInstanceName, e.BatchTime, e.VolumeDeviceId })
                    .HasName("PK_sysutility_volumes_info_internal");

                entity.ToTable("sysutility_ucp_volumes_internal", "snapshots");

                entity.HasIndex(e => e.SnapshotId, "NCI_sysutility_ucp_volumes_internal");

                entity.Property(e => e.ServerInstanceName)
                    .HasMaxLength(128)
                    .HasColumnName("server_instance_name");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.VolumeDeviceId)
                    .HasMaxLength(128)
                    .HasColumnName("volume_device_id");

                entity.Property(e => e.CollectionTime).HasColumnName("collection_time");

                entity.Property(e => e.FreeSpace).HasColumnName("free_space");

                entity.Property(e => e.PhysicalServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.TotalSpaceAvailable).HasColumnName("total_space_available");

                entity.Property(e => e.VirtualServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("virtual_server_name");

                entity.Property(e => e.VolumeName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("volume_name");

                entity.HasOne(d => d.Snapshot)
                    .WithMany(p => p.SysutilityUcpVolumesInternals)
                    .HasForeignKey(d => d.SnapshotId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_volumes_info_snapshots_internal");
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Rext)
                    .HasMaxLength(40)
                    .HasColumnName("rext")
                    .IsFixedLength(true)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<Tbl3Level>(entity =>
            {
                entity.HasKey(e => e.ThreeLevelId);

                entity.ToTable("tbl3Level");

                entity.Property(e => e.ThreeLevelId)
                    .HasMaxLength(50)
                    .HasColumnName("threeLevelID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelName)
                    .HasMaxLength(200)
                    .HasColumnName("threeLevelName")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<Tbl4Level>(entity =>
            {
                entity.HasKey(e => e.FourLevelNo);

                entity.ToTable("tbl4Level");

                entity.Property(e => e.FourLevelNo)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FourLevelName)
                    .HasMaxLength(1000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelNo)
                    .HasMaxLength(200)
                    .HasColumnName("threeLevelNo")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblArGroup>(entity =>
            {
                entity.HasKey(e => e.ArgId);

                entity.ToTable("tblArGroup");

                entity.Property(e => e.ArgId)
                    .ValueGeneratedNever()
                    .HasColumnName("argID");

                entity.Property(e => e.ArgName)
                    .HasMaxLength(800)
                    .HasColumnName("argName")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblArPersonel>(entity =>
            {
                entity.HasKey(e => e.ArgpId);

                entity.ToTable("tblArPersonel");

                entity.Property(e => e.ArgpId).HasColumnName("argpID");

                entity.Property(e => e.ArgId).HasColumnName("argID");

                entity.Property(e => e.EmP)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblArzyab>(entity =>
            {
                entity.HasKey(e => e.ArzyabId);

                entity.ToTable("tblArzyab");

                entity.Property(e => e.ArzyabId)
                    .ValueGeneratedNever()
                    .HasColumnName("ArzyabID");

                entity.Property(e => e.Agid).HasColumnName("AGID");

                entity.Property(e => e.EmNo)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Kid).HasColumnName("KID");
            });

            modelBuilder.Entity<TblArzyabi>(entity =>
            {
                entity.HasKey(e => e.ArzyabiId);

                entity.ToTable("tblArzyabi");

                entity.HasIndex(e => e.ErjaId, "QueryStroeRec_002");

                entity.Property(e => e.ArzyabiId).HasColumnName("ArzyabiID");

                entity.Property(e => e.DateArz)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year)
                    .HasMaxLength(200)
                    .HasColumnName("ejra5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraMonth)
                    .HasMaxLength(200)
                    .HasColumnName("ejraMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraYear)
                    .HasMaxLength(200)
                    .HasColumnName("ejraYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ErjaId).HasColumnName("erjaID");

                entity.Property(e => e.ErjraDaily)
                    .HasMaxLength(200)
                    .HasColumnName("erjraDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HrWork).HasColumnName("hrWork");

                entity.Property(e => e.Ip)
                    .HasMaxLength(200)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.K1).HasColumnName("k1");

                entity.Property(e => e.K2).HasColumnName("k2");

                entity.Property(e => e.K3).HasColumnName("k3");

                entity.Property(e => e.K4).HasColumnName("k4");

                entity.Property(e => e.K5).HasColumnName("k5");

                entity.Property(e => e.K6).HasColumnName("k6");

                entity.Property(e => e.K7).HasColumnName("k7");

                entity.Property(e => e.K8).HasColumnName("k8");

                entity.Property(e => e.MablaghNahaiAlphabet)
                    .HasMaxLength(200)
                    .HasColumnName("mablaghNahaiAlphabet")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiNumber)
                    .HasMaxLength(200)
                    .HasColumnName("mablaghNahaiNumber")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q10)
                    .HasMaxLength(4000)
                    .HasColumnName("q10")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q2)
                    .HasMaxLength(4000)
                    .HasColumnName("q2")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q3)
                    .HasMaxLength(4000)
                    .HasColumnName("q3")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q4)
                    .HasMaxLength(4000)
                    .HasColumnName("q4")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q5)
                    .HasMaxLength(4000)
                    .HasColumnName("q5")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q6)
                    .HasMaxLength(4000)
                    .HasColumnName("q6")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q7)
                    .HasMaxLength(4000)
                    .HasColumnName("q7")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q8)
                    .HasMaxLength(4000)
                    .HasColumnName("q8")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q9)
                    .HasMaxLength(4000)
                    .HasColumnName("q9")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.Sama5Year)
                    .HasMaxLength(200)
                    .HasColumnName("sama5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarDaily)
                    .HasMaxLength(200)
                    .HasColumnName("samarDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarMonth)
                    .HasMaxLength(200)
                    .HasColumnName("samarMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarYear)
                    .HasMaxLength(200)
                    .HasColumnName("samarYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year)
                    .HasMaxLength(200)
                    .HasColumnName("sarfe5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeDaily)
                    .HasMaxLength(200)
                    .HasColumnName("sarfeDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeMonth)
                    .HasMaxLength(200)
                    .HasColumnName("sarfeMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeYear)
                    .HasMaxLength(200)
                    .HasColumnName("sarfeYear")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblBazr>(entity =>
            {
                entity.HasKey(e => e.BId);

                entity.ToTable("tblBazr");

                entity.Property(e => e.BId).HasColumnName("bID");

                entity.Property(e => e.BSubject)
                    .HasMaxLength(4000)
                    .HasColumnName("bSubject")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ExpireDt)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Source)
                    .HasMaxLength(200)
                    .HasColumnName("source")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblCmt>(entity =>
            {
                entity.HasKey(e => e.CmtId);

                entity.ToTable("tblCmt");

                entity.Property(e => e.CmtId).HasColumnName("cmtID");

                entity.Property(e => e.CmtEmail)
                    .HasMaxLength(2000)
                    .HasColumnName("cmtEmail")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CmtFname)
                    .HasMaxLength(200)
                    .HasColumnName("cmtFname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CmtPhone)
                    .HasMaxLength(200)
                    .HasColumnName("cmtPhone")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CmtText)
                    .HasMaxLength(4000)
                    .HasColumnName("cmtText")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Date)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ip)
                    .HasMaxLength(200)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Time)
                    .HasMaxLength(40)
                    .HasColumnName("time")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblDoc>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("tblDoc");

                entity.Property(e => e.DocId)
                    .HasMaxLength(50)
                    .HasColumnName("DocID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DocName)
                    .HasMaxLength(600)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.FourLevelNo)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ZipAddress)
                    .HasMaxLength(2000)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblDocType>(entity =>
            {
                entity.HasKey(e => e.DocTypeInt);

                entity.ToTable("tblDocType");

                entity.Property(e => e.DocTypeName)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblEblagh>(entity =>
            {
                entity.HasKey(e => e.EblaghId);

                entity.ToTable("tblEblagh");

                entity.Property(e => e.EblaghId).HasColumnName("EblaghID");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateStart)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Datepadash100)
                    .HasMaxLength(40)
                    .HasColumnName("datepadash100")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Datepadash30)
                    .HasMaxLength(40)
                    .HasColumnName("datepadash30")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Datepadash70)
                    .HasMaxLength(40)
                    .HasColumnName("datepadash70")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmNoEblagh)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.IntOk)
                    .HasColumnName("intOk")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ipba)
                    .HasMaxLength(200)
                    .HasColumnName("IPBa")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.LastRe)
                    .HasMaxLength(4000)
                    .HasColumnName("lastRe")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lastpishraft)
                    .HasMaxLength(200)
                    .HasColumnName("lastpishraft")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Padash100).HasColumnName("padash100");

                entity.Property(e => e.Padash30).HasColumnName("padash30");

                entity.Property(e => e.Padash70).HasColumnName("padash70");

                entity.Property(e => e.Pardakh30tDate)
                    .HasMaxLength(40)
                    .HasColumnName("pardakh30tDate")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pardakht100).HasColumnName("pardakht100");

                entity.Property(e => e.Pardakht100Date)
                    .HasMaxLength(40)
                    .HasColumnName("pardakht100Date")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pardakht30).HasColumnName("pardakht30");

                entity.Property(e => e.Pardakht70).HasColumnName("pardakht70");

                entity.Property(e => e.Pardakht70Date)
                    .HasMaxLength(40)
                    .HasColumnName("pardakht70Date")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Saat)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SaatBa)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SharhEjrai)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TarikhBa)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Totalpishraft)
                    .HasMaxLength(200)
                    .HasColumnName("totalpishraft")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<TblEblaghHamkar>(entity =>
            {
                entity.HasKey(e => e.HamkarId);

                entity.ToTable("tblEblaghHamkar");

                entity.Property(e => e.HamkarId).HasColumnName("HamkarID");

                entity.Property(e => e.EblaghId).HasColumnName("EblaghID");

                entity.Property(e => e.EmNo)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblEblaghRep>(entity =>
            {
                entity.HasKey(e => e.IdeblaghRep);

                entity.ToTable("tblEblaghRep");

                entity.Property(e => e.IdeblaghRep).HasColumnName("IDEblaghRep");

                entity.Property(e => e.AttachFile)
                    .HasMaxLength(200)
                    .HasColumnName("attach_file")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DescNavaghes)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DescRep)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EblaghId).HasColumnName("EblaghID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(200)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblEblaghStatus>(entity =>
            {
                entity.HasKey(e => e.EblaghStatusId);

                entity.ToTable("tblEblaghStatus");

                entity.Property(e => e.EblaghStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("EblaghStatusID");

                entity.Property(e => e.EblaghStatusName)
                    .HasMaxLength(400)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblEduPost>(entity =>
            {
                entity.HasKey(e => e.EduId);

                entity.ToTable("tblEduPost");

                entity.Property(e => e.EduId).HasColumnName("edu_ID");

                entity.Property(e => e.Abstract)
                    .HasMaxLength(2000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.AddDate)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(getdate())")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PartId).HasColumnName("PartID");

                entity.Property(e => e.Pic)
                    .HasMaxLength(80)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblErja>(entity =>
            {
                entity.HasKey(e => e.ErjaId);

                entity.ToTable("tblErja");

                entity.HasIndex(e => e.Flag4Tasvib, "<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.Tarikh, e.Flag4Tasvib }, "ErjaIDX001");

                entity.HasIndex(e => e.ArzyabIdDes, "ErjaIDX002");

                entity.HasIndex(e => e.Idpr, "ErjaIDX003");

                entity.HasIndex(e => e.Flag4Tasvib, "QueryStoreRec_003");

                entity.Property(e => e.ErjaId).HasColumnName("ErjaID");

                entity.Property(e => e.ArzyabIdDes).HasColumnName("ArzyabID_DES");

                entity.Property(e => e.ArzyabIdSrc).HasColumnName("ArzyabID_SRC");

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .HasColumnName("description");

                entity.Property(e => e.Flag4Tasvib).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Ip)
                    .HasMaxLength(200)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.JalaseNo)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SaAt)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblErjaProb>(entity =>
            {
                entity.HasKey(e => e.ErId)
                    .HasName("PK_tblSoratjalase");

                entity.ToTable("tblErjaProb");

                entity.Property(e => e.ErId).HasColumnName("erID");

                entity.Property(e => e.DateArz)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Descr)
                    .HasMaxLength(4000)
                    .HasColumnName("descr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year)
                    .HasMaxLength(200)
                    .HasColumnName("ejra5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraMonth)
                    .HasMaxLength(200)
                    .HasColumnName("ejraMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraYear)
                    .HasMaxLength(200)
                    .HasColumnName("ejraYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmP)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ErjraDaily)
                    .HasMaxLength(200)
                    .HasColumnName("erjraDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HrWork).HasColumnName("hrWork");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.JalaseDate)
                    .HasMaxLength(200)
                    .HasColumnName("jalaseDate")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.JalaseNo)
                    .HasMaxLength(200)
                    .HasColumnName("jalaseNo")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiAlphabet)
                    .HasMaxLength(200)
                    .HasColumnName("mablaghNahaiAlphabet")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiNumber)
                    .HasMaxLength(200)
                    .HasColumnName("mablaghNahaiNumber")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q10)
                    .HasMaxLength(4000)
                    .HasColumnName("q10")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q2)
                    .HasMaxLength(4000)
                    .HasColumnName("q2")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q3)
                    .HasMaxLength(4000)
                    .HasColumnName("q3")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q4)
                    .HasMaxLength(4000)
                    .HasColumnName("q4")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q5)
                    .HasMaxLength(4000)
                    .HasColumnName("q5")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q6)
                    .HasMaxLength(4000)
                    .HasColumnName("q6")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q7)
                    .HasMaxLength(4000)
                    .HasColumnName("q7")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q8)
                    .HasMaxLength(4000)
                    .HasColumnName("q8")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q9)
                    .HasMaxLength(4000)
                    .HasColumnName("q9")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.Sama5Year)
                    .HasMaxLength(200)
                    .HasColumnName("sama5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarDaily)
                    .HasMaxLength(200)
                    .HasColumnName("samarDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarMonth)
                    .HasMaxLength(200)
                    .HasColumnName("samarMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarYear)
                    .HasMaxLength(200)
                    .HasColumnName("samarYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year)
                    .HasMaxLength(200)
                    .HasColumnName("sarfe5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeDaily)
                    .HasMaxLength(200)
                    .HasColumnName("sarfeDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeMonth)
                    .HasMaxLength(200)
                    .HasColumnName("sarfeMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeYear)
                    .HasMaxLength(200)
                    .HasColumnName("sarfeYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WgId).HasColumnName("wgID");
            });

            modelBuilder.Entity<TblFestival>(entity =>
            {
                entity.ToTable("tblFestival");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateStart)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Descr)
                    .HasMaxLength(4000)
                    .HasColumnName("descr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pict)
                    .HasMaxLength(200)
                    .HasColumnName("pict")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Subject)
                    .HasMaxLength(800)
                    .HasColumnName("subject")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblForm>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("tblForm");

                entity.HasIndex(e => e.DopId, "tblFormIDX0012");

                entity.Property(e => e.FormId)
                    .HasMaxLength(50)
                    .HasColumnName("FormID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DopId)
                    .HasMaxLength(200)
                    .HasColumnName("DopID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FormName)
                    .HasMaxLength(1000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ZipAddress)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblIsoForm>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("tblIsoForm");

                entity.Property(e => e.FormId)
                    .HasMaxLength(50)
                    .HasColumnName("FormID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DepId).HasColumnName("DepID");

                entity.Property(e => e.FormName)
                    .HasMaxLength(800)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pdfaddress)
                    .HasMaxLength(4000)
                    .HasColumnName("PDFAddress")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WordAddress)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblLogDownload>(entity =>
            {
                entity.ToTable("tblLogDownload");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileId)
                    .HasMaxLength(200)
                    .HasColumnName("fileID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FileTypeId)
                    .HasMaxLength(200)
                    .HasColumnName("fileTypeID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblLogPrint>(entity =>
            {
                entity.HasKey(e => e.IdlogPrint);

                entity.ToTable("tblLogPrint");

                entity.Property(e => e.IdlogPrint).HasColumnName("IDLogPrint");

                entity.Property(e => e.DatePrint)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Ipprint)
                    .HasMaxLength(200)
                    .HasColumnName("IPPrint")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimePrint)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UsrPrint)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblManagment>(entity =>
            {
                entity.HasKey(e => e.ManId);

                entity.ToTable("tblManagment");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(1000)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblMasolePayesh>(entity =>
            {
                entity.HasKey(e => e.Idmasole);

                entity.ToTable("tblMasolePayesh");

                entity.Property(e => e.Idmasole).HasColumnName("IDMasole");

                entity.Property(e => e.Idpayesh).HasColumnName("IDPayesh");

                entity.Property(e => e.Kpimode).HasColumnName("KPIMode");

                entity.Property(e => e.ProccessId).HasColumnName("ProccessID");

                entity.Property(e => e.Username)
                    .HasMaxLength(480)
                    .IsFixedLength(true)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblMrc>(entity =>
            {
                entity.HasKey(e => e.IdstatusPayesh);

                entity.ToTable("tblMRC");

                entity.Property(e => e.IdstatusPayesh).HasColumnName("IDStatusPayesh");

                entity.Property(e => e.StatusPayeshName)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblNatijeProp>(entity =>
            {
                entity.HasKey(e => e.NId);

                entity.ToTable("tblNatijeProp");

                entity.Property(e => e.NId)
                    .ValueGeneratedNever()
                    .HasColumnName("nID");

                entity.Property(e => e.NText)
                    .HasMaxLength(200)
                    .HasColumnName("nText")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblOffer>(entity =>
            {
                entity.HasKey(e => e.Idof);

                entity.ToTable("tblOffers");

                entity.HasIndex(e => new { e.Idpr, e.Emno }, "i-980118");

                entity.Property(e => e.Idof).HasColumnName("IDOf");

                entity.Property(e => e.Emno)
                    .HasMaxLength(100)
                    .HasColumnName("EMno")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");
            });

            modelBuilder.Entity<TblPageRole>(entity =>
            {
                entity.ToTable("tblPageRoles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Page)
                    .HasMaxLength(200)
                    .HasColumnName("page")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Roles)
                    .HasMaxLength(200)
                    .HasColumnName("roles")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblPart>(entity =>
            {
                entity.HasKey(e => e.PartId);

                entity.ToTable("tblPart");

                entity.Property(e => e.PartId).HasColumnName("partID");

                entity.Property(e => e.PartName)
                    .HasMaxLength(200)
                    .HasColumnName("partName")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblPayesh>(entity =>
            {
                entity.HasKey(e => e.Idpayesh);

                entity.ToTable("tblPayesh");

                entity.Property(e => e.Idpayesh).HasColumnName("IDPayesh");

                entity.Property(e => e.Carno).HasColumnName("CARNo");

                entity.Property(e => e.DalEnBeAm)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateBegin)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateControl)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateTakmil)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DefinePayesh)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DlRaShKe)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DoreyeZamani)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MeyarGhabol)
                    .HasMaxLength(80)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MghdrAndGiSho)
                    .HasMaxLength(80)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MiEnBeAm)
                    .HasMaxLength(80)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mrc).HasColumnName("MRC");

                entity.Property(e => e.SignMghdr).HasColumnName("signMghdr");
            });

            modelBuilder.Entity<TblPish>(entity =>
            {
                entity.HasKey(e => e.CmtId);

                entity.ToTable("tblPish");

                entity.Property(e => e.CmtId).HasColumnName("cmtID");

                entity.Property(e => e.Date)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ip)
                    .HasMaxLength(200)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PiEmNo)
                    .HasMaxLength(800)
                    .HasColumnName("piEmNo")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PiFlname)
                    .HasMaxLength(800)
                    .HasColumnName("piFLName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PiNoeEst)
                    .HasMaxLength(2000)
                    .HasColumnName("piNoeEst")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PiText)
                    .HasMaxLength(4000)
                    .HasColumnName("piText")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PiVahed)
                    .HasMaxLength(800)
                    .HasColumnName("piVahed")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Time)
                    .HasMaxLength(40)
                    .HasColumnName("time")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblProbLog>(entity =>
            {
                entity.ToTable("tblProbLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Ip)
                    .HasMaxLength(200)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NewStatusId).HasColumnName("newStatusID");

                entity.Property(e => e.SaAt)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblProp>(entity =>
            {
                entity.HasKey(e => e.Idpr)
                    .HasName("PK_tblProp_1");

                entity.ToTable("tblProp");

                entity.HasIndex(e => new { e.DateN, e.StatusId }, "<Name of Missing Index, sysname,>");

                entity.HasIndex(e => e.DateN, "QueryStoreRec_004");

                entity.HasIndex(e => new { e.Usrid, e.DateN }, "QueryStoreRec_005");

                entity.HasIndex(e => e.StatusId, "QueryStoreRec_006");

                entity.HasIndex(e => e.StatusId, "QueryStoreRec_007");

                entity.HasIndex(e => new { e.DateN, e.StatusId }, "QueryStoreRecommanded_001");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.AtF)
                    .HasMaxLength(800)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ch01).HasColumnName("ch01");

                entity.Property(e => e.Ch02).HasColumnName("ch02");

                entity.Property(e => e.Ch03).HasColumnName("ch03");

                entity.Property(e => e.Ch04).HasColumnName("ch04");

                entity.Property(e => e.Ch05).HasColumnName("ch05");

                entity.Property(e => e.Ch06).HasColumnName("ch06");

                entity.Property(e => e.Ch07).HasColumnName("ch07");

                entity.Property(e => e.Ch08).HasColumnName("ch08");

                entity.Property(e => e.Ch09).HasColumnName("ch09");

                entity.Property(e => e.Ch10).HasColumnName("ch10");

                entity.Property(e => e.Ch11).HasColumnName("ch11");

                entity.Property(e => e.Ch12).HasColumnName("ch12");

                entity.Property(e => e.Ch13).HasColumnName("ch13");

                entity.Property(e => e.Ch14).HasColumnName("ch14");

                entity.Property(e => e.Ch15).HasColumnName("ch15");

                entity.Property(e => e.Ch16).HasColumnName("ch16");

                entity.Property(e => e.Ch17).HasColumnName("ch17");

                entity.Property(e => e.Ch18).HasColumnName("ch18");

                entity.Property(e => e.Ch19).HasColumnName("ch19");

                entity.Property(e => e.Ch20).HasColumnName("ch20");

                entity.Property(e => e.Ch21).HasColumnName("ch21");

                entity.Property(e => e.Ch22).HasColumnName("ch22");

                entity.Property(e => e.Ch23).HasColumnName("ch23");

                entity.Property(e => e.Ch24).HasColumnName("ch24");

                entity.Property(e => e.Ch25).HasColumnName("ch25");

                entity.Property(e => e.Ch26).HasColumnName("ch26");

                entity.Property(e => e.Ch27).HasColumnName("ch27");

                entity.Property(e => e.Ch28).HasColumnName("ch28");

                entity.Property(e => e.Ch29).HasColumnName("ch29");

                entity.Property(e => e.Ch30).HasColumnName("ch30");

                entity.Property(e => e.Ch31).HasColumnName("ch31");

                entity.Property(e => e.Ch32).HasColumnName("ch32");

                entity.Property(e => e.Ch33).HasColumnName("ch33");

                entity.Property(e => e.Ch34).HasColumnName("ch34");

                entity.Property(e => e.Ch35).HasColumnName("ch35");

                entity.Property(e => e.Ch36).HasColumnName("ch36");

                entity.Property(e => e.Ch37).HasColumnName("ch37");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(200)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CurrentDescPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Dabir).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateN).HasMaxLength(20);

                entity.Property(e => e.DesDabir)
                    .HasMaxLength(4000)
                    .HasColumnName("desDabir")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NahveyeMohasebe)
                    .HasMaxLength(4000)
                    .HasColumnName("nahveyeMohasebe")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NewDesPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(200)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblPropUnder500>(entity =>
            {
                entity.HasKey(e => e.Idpr);

                entity.ToTable("tblPropUnder500");

                entity.Property(e => e.Idpr)
                    .ValueGeneratedNever()
                    .HasColumnName("IDpr");

                entity.Property(e => e.Ch01).HasColumnName("ch01");

                entity.Property(e => e.Ch02).HasColumnName("ch02");

                entity.Property(e => e.Ch03).HasColumnName("ch03");

                entity.Property(e => e.Ch04).HasColumnName("ch04");

                entity.Property(e => e.Ch05).HasColumnName("ch05");

                entity.Property(e => e.Ch06).HasColumnName("ch06");

                entity.Property(e => e.Ch07).HasColumnName("ch07");

                entity.Property(e => e.Ch08).HasColumnName("ch08");

                entity.Property(e => e.Ch09).HasColumnName("ch09");

                entity.Property(e => e.Ch10).HasColumnName("ch10");

                entity.Property(e => e.Ch11).HasColumnName("ch11");

                entity.Property(e => e.Ch12).HasColumnName("ch12");

                entity.Property(e => e.Ch13).HasColumnName("ch13");

                entity.Property(e => e.Ch14).HasColumnName("ch14");

                entity.Property(e => e.Ch15).HasColumnName("ch15");

                entity.Property(e => e.Ch16).HasColumnName("ch16");

                entity.Property(e => e.Ch17).HasColumnName("ch17");

                entity.Property(e => e.Ch18).HasColumnName("ch18");

                entity.Property(e => e.Ch19).HasColumnName("ch19");

                entity.Property(e => e.Ch20).HasColumnName("ch20");

                entity.Property(e => e.Ch21).HasColumnName("ch21");

                entity.Property(e => e.Ch22).HasColumnName("ch22");

                entity.Property(e => e.Ch23).HasColumnName("ch23");

                entity.Property(e => e.Ch24).HasColumnName("ch24");

                entity.Property(e => e.Ch25).HasColumnName("ch25");

                entity.Property(e => e.Ch26).HasColumnName("ch26");

                entity.Property(e => e.Ch27).HasColumnName("ch27");

                entity.Property(e => e.Ch28).HasColumnName("ch28");

                entity.Property(e => e.Ch29).HasColumnName("ch29");

                entity.Property(e => e.Ch30).HasColumnName("ch30");

                entity.Property(e => e.Ch31).HasColumnName("ch31");

                entity.Property(e => e.Ch32).HasColumnName("ch32");

                entity.Property(e => e.Ch33).HasColumnName("ch33");

                entity.Property(e => e.Ch34).HasColumnName("ch34");

                entity.Property(e => e.Ch35).HasColumnName("ch35");

                entity.Property(e => e.Ch36).HasColumnName("ch36");

                entity.Property(e => e.Ch37).HasColumnName("ch37");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(200)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CurrentDescPr)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NewDesPr)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(200)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblProtest>(entity =>
            {
                entity.HasKey(e => e.Idprotest);

                entity.ToTable("tblProtest");

                entity.Property(e => e.Idprotest).HasColumnName("IDProtest");

                entity.Property(e => e.Answ)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Descr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Emno)
                    .HasMaxLength(40)
                    .HasColumnName("EMNo")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Saat)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblReq>(entity =>
            {
                entity.HasKey(e => e.Idreq);

                entity.ToTable("tblReq");

                entity.Property(e => e.Idreq).HasColumnName("IDReq");

                entity.Property(e => e.Date)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(getdate())")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DocId)
                    .HasMaxLength(200)
                    .HasColumnName("DocID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FileNameS)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StateusId)
                    .HasColumnName("stateusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Time)
                    .HasMaxLength(40)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TypeReqId).HasColumnName("TypeReqID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UserText)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblSemat>(entity =>
            {
                entity.HasKey(e => e.Ids);

                entity.ToTable("tblSemat");

                entity.Property(e => e.Ids).HasColumnName("IDS");

                entity.Property(e => e.Idup).HasColumnName("IDUp");

                entity.Property(e => e.Semat)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblStateu>(entity =>
            {
                entity.HasKey(e => e.StateusId);

                entity.ToTable("tblStateus");

                entity.Property(e => e.StateusId).HasColumnName("stateusID");

                entity.Property(e => e.StateusName)
                    .HasMaxLength(1000)
                    .HasColumnName("stateusName")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblStatus>(entity =>
            {
                entity.HasKey(e => e.Idst);

                entity.ToTable("tblStatus");

                entity.Property(e => e.Idst).HasColumnName("IDSt");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblStum>(entity =>
            {
                entity.ToTable("tblSta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CntPep).HasColumnName("cntPep");
            });

            modelBuilder.Entity<TblTypeName>(entity =>
            {
                entity.HasKey(e => e.FileTypeId);

                entity.ToTable("tblTypeName");

                entity.Property(e => e.FileTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("fileTypeID");

                entity.Property(e => e.FileTypeName)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblTypeReq>(entity =>
            {
                entity.HasKey(e => e.TypeReqId);

                entity.ToTable("tblTypeReq");

                entity.Property(e => e.TypeReqId).HasColumnName("TypeReqID");

                entity.Property(e => e.TypeReqName)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblUsPa>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("tblUsPas");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Password)
                    .HasMaxLength(4000)
                    .HasColumnName("password")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblUsr>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("tblUSR");

                entity.HasIndex(e => e.EmP, "QueryUSRStoreRec_001");

                entity.Property(e => e.Username)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ActiveFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(1200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Basij).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmP)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(480)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lname)
                    .HasMaxLength(480)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Password)
                    .HasMaxLength(2000)
                    .HasColumnName("password")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'nopic.jpg')")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Raeis).HasDefaultValueSql("((0))");

                entity.Property(e => e.Roles)
                    .HasMaxLength(800)
                    .HasDefaultValueSql("(N'emOnly')")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(800)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblUsrMsg>(entity =>
            {
                entity.ToTable("tblUSR_MSG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Msg)
                    .HasMaxLength(4000)
                    .HasColumnName("msg")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.OnceVisible)
                    .HasColumnName("onceVisible")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Remove)
                    .HasColumnName("remove")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Username)
                    .HasMaxLength(200)
                    .HasColumnName("username")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<TblWorkGroup>(entity =>
            {
                entity.HasKey(e => e.WgId);

                entity.ToTable("tblWorkGroup");

                entity.Property(e => e.WgId).HasColumnName("wgID");

                entity.Property(e => e.WgName)
                    .HasMaxLength(800)
                    .HasColumnName("wgName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WgStatus)
                    .HasColumnName("wgStatus")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblWorkGroupPerson>(entity =>
            {
                entity.HasKey(e => e.WgpId);

                entity.ToTable("tblWorkGroupPerson");

                entity.Property(e => e.WgpId).HasColumnName("wgpID");

                entity.Property(e => e.EmP)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WgId).HasColumnName("wgID");
            });

            modelBuilder.Entity<TraceDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trace_data", "snapshots");

                entity.HasIndex(e => new { e.SnapshotId, e.EventSequence }, "IDX_trace_data_EventSequence")
                    .IsClustered();

                entity.HasIndex(e => new { e.StartTime, e.EventClass }, "IDX_trace_data_StartTime_EventClass");

                entity.HasIndex(e => e.TraceInfoId, "IDX_trace_data_trace_info_id");

                entity.Property(e => e.ApplicationName).HasMaxLength(256);

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

                entity.Property(e => e.DatabaseName).HasMaxLength(256);

                entity.Property(e => e.DbuserName)
                    .HasMaxLength(256)
                    .HasColumnName("DBUserName");

                entity.Property(e => e.FileName).HasMaxLength(256);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.HostName).HasMaxLength(256);

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.LinkedServerName).HasMaxLength(256);

                entity.Property(e => e.LoginName).HasMaxLength(256);

                entity.Property(e => e.MethodName).HasMaxLength(256);

                entity.Property(e => e.NtdomainName)
                    .HasMaxLength(256)
                    .HasColumnName("NTDomainName");

                entity.Property(e => e.NtuserName)
                    .HasMaxLength(256)
                    .HasColumnName("NTUserName");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ObjectId2).HasColumnName("ObjectID2");

                entity.Property(e => e.ObjectName).HasMaxLength(256);

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.OwnerName).HasMaxLength(256);

                entity.Property(e => e.ParentName).HasMaxLength(256);

                entity.Property(e => e.PlanHandle).HasMaxLength(64);

                entity.Property(e => e.ProviderName).HasMaxLength(256);

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.RoleName).HasMaxLength(256);

                entity.Property(e => e.ServerName).HasMaxLength(256);

                entity.Property(e => e.SessionLoginName).HasMaxLength(256);

                entity.Property(e => e.SnapshotId).HasColumnName("snapshot_id");

                entity.Property(e => e.SourceDatabaseId).HasColumnName("SourceDatabaseID");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.SqlHandle).HasMaxLength(64);

                entity.Property(e => e.TargetLoginName).HasMaxLength(256);

                entity.Property(e => e.TargetUserName).HasMaxLength(256);

                entity.Property(e => e.TraceInfoId).HasColumnName("trace_info_id");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.HasOne(d => d.Snapshot)
                    .WithMany()
                    .HasForeignKey(d => d.SnapshotId)
                    .HasConstraintName("FK_trace_data_snapshot_id");

                entity.HasOne(d => d.TraceInfo)
                    .WithMany()
                    .HasForeignKey(d => d.TraceInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trace_data_trace_info_id");
            });

            modelBuilder.Entity<TraceInfo>(entity =>
            {
                entity.ToTable("trace_info", "snapshots");

                entity.Property(e => e.TraceInfoId).HasColumnName("trace_info_id");

                entity.Property(e => e.CollectionItemId).HasColumnName("collection_item_id");

                entity.Property(e => e.DroppedEventCount).HasColumnName("dropped_event_count");

                entity.Property(e => e.EventCount).HasColumnName("event_count");

                entity.Property(e => e.IsRunning).HasColumnName("is_running");

                entity.Property(e => e.LastEventSequence).HasColumnName("last_event_sequence");

                entity.Property(e => e.LastSnapshotId).HasColumnName("last_snapshot_id");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");

                entity.HasOne(d => d.LastSnapshot)
                    .WithMany(p => p.TraceInfos)
                    .HasForeignKey(d => d.LastSnapshotId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_trace_info_last_snapshot_id");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.TraceInfos)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_trace_info_source_id");
            });

            modelBuilder.Entity<UtilityObjectsInternal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("utility_objects_internal", "sysutility_ucp_misc");

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("object_name");

                entity.Property(e => e.ObjectSchema)
                    .HasMaxLength(128)
                    .HasColumnName("object_schema");

                entity.Property(e => e.SqlObjectType)
                    .HasMaxLength(60)
                    .HasColumnName("sql_object_type")
                    .UseCollation("Latin1_General_CI_AS_KS_WS");

                entity.Property(e => e.UtilityObjectType)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("utility_object_type");
            });

            modelBuilder.Entity<View3level>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_3Level");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(300)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Carno).HasColumnName("CARNo");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DalEnBeAm).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateBegin)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateControl)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateTakmil)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DefinePayesh).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DlRaShKe).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DoreyeZamani)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idmasole).HasColumnName("IDMasole");

                entity.Property(e => e.Idpayesh).HasColumnName("IDPayesh");

                entity.Property(e => e.IdstatusPayesh).HasColumnName("IDStatusPayesh");

                entity.Property(e => e.Kpimode).HasColumnName("KPIMode");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MeyarGhabol)
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MghdrAndGiSho)
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MiEnBeAm)
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SignMghdr).HasColumnName("signMghdr");

                entity.Property(e => e.StatusPayeshName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("threeLevelID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelName)
                    .HasMaxLength(50)
                    .HasColumnName("threeLevelName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<View4level>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_4Level");

                entity.Property(e => e.FourLevelName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FourLevelNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("threeLevelID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelName)
                    .HasMaxLength(50)
                    .HasColumnName("threeLevelName")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewAllProp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AllProp");

                entity.Property(e => e.AtF)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ch01).HasColumnName("ch01");

                entity.Property(e => e.Ch02).HasColumnName("ch02");

                entity.Property(e => e.Ch03).HasColumnName("ch03");

                entity.Property(e => e.Ch04).HasColumnName("ch04");

                entity.Property(e => e.Ch05).HasColumnName("ch05");

                entity.Property(e => e.Ch06).HasColumnName("ch06");

                entity.Property(e => e.Ch07).HasColumnName("ch07");

                entity.Property(e => e.Ch08).HasColumnName("ch08");

                entity.Property(e => e.Ch09).HasColumnName("ch09");

                entity.Property(e => e.Ch10).HasColumnName("ch10");

                entity.Property(e => e.Ch11).HasColumnName("ch11");

                entity.Property(e => e.Ch12).HasColumnName("ch12");

                entity.Property(e => e.Ch13).HasColumnName("ch13");

                entity.Property(e => e.Ch14).HasColumnName("ch14");

                entity.Property(e => e.Ch15).HasColumnName("ch15");

                entity.Property(e => e.Ch16).HasColumnName("ch16");

                entity.Property(e => e.Ch17).HasColumnName("ch17");

                entity.Property(e => e.Ch18).HasColumnName("ch18");

                entity.Property(e => e.Ch19).HasColumnName("ch19");

                entity.Property(e => e.Ch20).HasColumnName("ch20");

                entity.Property(e => e.Ch21).HasColumnName("ch21");

                entity.Property(e => e.Ch22).HasColumnName("ch22");

                entity.Property(e => e.Ch23).HasColumnName("ch23");

                entity.Property(e => e.Ch24).HasColumnName("ch24");

                entity.Property(e => e.Ch25).HasColumnName("ch25");

                entity.Property(e => e.Ch26).HasColumnName("ch26");

                entity.Property(e => e.Ch27).HasColumnName("ch27");

                entity.Property(e => e.Ch28).HasColumnName("ch28");

                entity.Property(e => e.Ch29).HasColumnName("ch29");

                entity.Property(e => e.Ch30).HasColumnName("ch30");

                entity.Property(e => e.Ch31).HasColumnName("ch31");

                entity.Property(e => e.Ch32).HasColumnName("ch32");

                entity.Property(e => e.Ch33).HasColumnName("ch33");

                entity.Property(e => e.Ch34).HasColumnName("ch34");

                entity.Property(e => e.Ch35).HasColumnName("ch35");

                entity.Property(e => e.Ch36).HasColumnName("ch36");

                entity.Property(e => e.Ch37).HasColumnName("ch37");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(50)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CurrentDescPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DesDabir)
                    .HasColumnName("desDabir")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Emno)
                    .HasMaxLength(50)
                    .HasColumnName("EMno")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Expr1).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idof).HasColumnName("IDOf");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NahveyeMohasebe)
                    .HasColumnName("nahveyeMohasebe")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NewDesPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<ViewArGp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ArGP");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(300)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ArgId).HasColumnName("argID");

                entity.Property(e => e.ArgName)
                    .HasMaxLength(200)
                    .HasColumnName("argName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ArgpId).HasColumnName("argpID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewArzyab>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Arzyab");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(300)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ArgId).HasColumnName("argID");

                entity.Property(e => e.ArgName)
                    .HasMaxLength(200)
                    .HasColumnName("argName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ArgpId).HasColumnName("argpID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewArzyaban>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Arzyaban");

                entity.Property(e => e.ArgId).HasColumnName("argID");

                entity.Property(e => e.ArgName)
                    .HasMaxLength(200)
                    .HasColumnName("argName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ArzyabId).HasColumnName("ArzyabID");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WgId).HasColumnName("wgID");

                entity.Property(e => e.WgName)
                    .HasMaxLength(200)
                    .HasColumnName("wgName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewArzyabi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Arzyabi");

                entity.Property(e => e.DateArz)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year)
                    .HasMaxLength(50)
                    .HasColumnName("ejra5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraMonth)
                    .HasMaxLength(50)
                    .HasColumnName("ejraMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraYear)
                    .HasMaxLength(50)
                    .HasColumnName("ejraYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmNo)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Emnop)
                    .HasMaxLength(50)
                    .HasColumnName("emnop")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ErjaId).HasColumnName("ErjaID");

                entity.Property(e => e.ErjraDaily)
                    .HasMaxLength(50)
                    .HasColumnName("erjraDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fnamep)
                    .HasMaxLength(120)
                    .HasColumnName("fnamep")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HrWork).HasColumnName("hrWork");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.K1).HasColumnName("k1");

                entity.Property(e => e.K2).HasColumnName("k2");

                entity.Property(e => e.K3).HasColumnName("k3");

                entity.Property(e => e.K4).HasColumnName("k4");

                entity.Property(e => e.K5).HasColumnName("k5");

                entity.Property(e => e.K6).HasColumnName("k6");

                entity.Property(e => e.K7).HasColumnName("k7");

                entity.Property(e => e.K8).HasColumnName("k8");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lnamep)
                    .HasMaxLength(120)
                    .HasColumnName("lnamep")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiAlphabet)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiAlphabet")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiNumber)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiNumber")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.Sama5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sama5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarDaily)
                    .HasMaxLength(50)
                    .HasColumnName("samarDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarMonth)
                    .HasMaxLength(50)
                    .HasColumnName("samarMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarYear)
                    .HasMaxLength(50)
                    .HasColumnName("samarYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sarfe5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeDaily)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeMonth)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeYear)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(50)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewArzyabi4arzyabBartar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Arzyabi_4ArzyabBartar");

                entity.Property(e => e.ArzyabiId).HasColumnName("ArzyabiID");

                entity.Property(e => e.DateArz)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year)
                    .HasMaxLength(50)
                    .HasColumnName("ejra5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraMonth)
                    .HasMaxLength(50)
                    .HasColumnName("ejraMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraYear)
                    .HasMaxLength(50)
                    .HasColumnName("ejraYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmNo)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ErjaId).HasColumnName("ErjaID");

                entity.Property(e => e.ErjraDaily)
                    .HasMaxLength(50)
                    .HasColumnName("erjraDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HrWork).HasColumnName("hrWork");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.K1).HasColumnName("k1");

                entity.Property(e => e.K2).HasColumnName("k2");

                entity.Property(e => e.K3).HasColumnName("k3");

                entity.Property(e => e.K4).HasColumnName("k4");

                entity.Property(e => e.K5).HasColumnName("k5");

                entity.Property(e => e.K6).HasColumnName("k6");

                entity.Property(e => e.K7).HasColumnName("k7");

                entity.Property(e => e.K8).HasColumnName("k8");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiAlphabet)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiAlphabet")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiNumber)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiNumber")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.Sama5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sama5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarDaily)
                    .HasMaxLength(50)
                    .HasColumnName("samarDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarMonth)
                    .HasMaxLength(50)
                    .HasColumnName("samarMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarYear)
                    .HasMaxLength(50)
                    .HasColumnName("samarYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sarfe5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeDaily)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeMonth)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeYear)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(50)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewArzyabiWithEmNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ArzyabiWithEmNo");

                entity.Property(e => e.ArzyabIdSrc).HasColumnName("ArzyabID_SRC");

                entity.Property(e => e.ArzyabiId).HasColumnName("ArzyabiID");

                entity.Property(e => e.DateArz)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmNo)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ErjaId).HasColumnName("ErjaID");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HrWork).HasColumnName("hrWork");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewBazr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Bazr");

                entity.Property(e => e.BId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.BSubject)
                    .HasColumnName("bSubject")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ExpireDt)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .HasColumnName("source")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Doc");

                entity.Property(e => e.DocId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DocID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DocName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DocTypeName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FourLevelName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FourLevelNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("threeLevelID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelName)
                    .HasMaxLength(50)
                    .HasColumnName("threeLevelName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ZipAddress)
                    .HasMaxLength(500)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewEblagh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Eblagh");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateStart)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Datepadash100)
                    .HasMaxLength(10)
                    .HasColumnName("datepadash100")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Datepadash30)
                    .HasMaxLength(10)
                    .HasColumnName("datepadash30")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Datepadash70)
                    .HasMaxLength(10)
                    .HasColumnName("datepadash70")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EblaghId).HasColumnName("EblaghID");

                entity.Property(e => e.EblaghStatusName)
                    .HasMaxLength(100)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmNoEblagh)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.IntOk).HasColumnName("intOk");

                entity.Property(e => e.Ipba)
                    .HasMaxLength(50)
                    .HasColumnName("IPBa")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.LastRe)
                    .HasColumnName("lastRe")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lastpishraft)
                    .HasMaxLength(50)
                    .HasColumnName("lastpishraft")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Padash100).HasColumnName("padash100");

                entity.Property(e => e.Padash30).HasColumnName("padash30");

                entity.Property(e => e.Padash70).HasColumnName("padash70");

                entity.Property(e => e.Pardakh30tDate)
                    .HasMaxLength(10)
                    .HasColumnName("pardakh30tDate")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pardakht100).HasColumnName("pardakht100");

                entity.Property(e => e.Pardakht100Date)
                    .HasMaxLength(10)
                    .HasColumnName("pardakht100Date")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pardakht30).HasColumnName("pardakht30");

                entity.Property(e => e.Pardakht70).HasColumnName("pardakht70");

                entity.Property(e => e.Pardakht70Date)
                    .HasMaxLength(10)
                    .HasColumnName("pardakht70Date")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PunitId).HasColumnName("PUnitID");

                entity.Property(e => e.Saat)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SaatBa)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SharhEjrai).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TarikhBa)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TotalPishraft).HasColumnName("totalPishraft");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<ViewEblagh4safariReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Eblagh_4SafariReport");

                entity.Property(e => e.ArzyabiId).HasColumnName("ArzyabiID");

                entity.Property(e => e.EblaghId).HasColumnName("EblaghID");

                entity.Property(e => e.EmNo)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TotalPishraft).HasColumnName("totalPishraft");
            });

            modelBuilder.Entity<ViewEblaghHamkar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Eblagh_Hamkar");

                entity.Property(e => e.EblaghId).HasColumnName("EblaghID");

                entity.Property(e => e.EmNo)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HamkarId).HasColumnName("HamkarID");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitName).UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewEblaghRep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_EblaghRep");

                entity.Property(e => e.DescNavaghes).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DescRep).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EblaghId).HasColumnName("EblaghID");

                entity.Property(e => e.EmNoEblagh)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Expr1)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.IdeblaghRep).HasColumnName("IDEblaghRep");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.IntOk).HasColumnName("intOk");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ipba)
                    .HasMaxLength(50)
                    .HasColumnName("IPBa")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Padash30).HasColumnName("padash30");

                entity.Property(e => e.Saat)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SaatBa)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TarikhBa)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<ViewEblaghTotalDarsadPishraft>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_EblaghTotalDarsadPishraft");

                entity.Property(e => e.EblaghId).HasColumnName("EblaghID");

                entity.Property(e => e.TotalPishraft).HasColumnName("totalPishraft");
            });

            modelBuilder.Entity<ViewErjaAryabanLastComplete>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Erja_Aryaban_Last_Complete");

                entity.Property(e => e.ArzyabIdDes).HasColumnName("ArzyabID_DES");

                entity.Property(e => e.Fnamed)
                    .HasMaxLength(120)
                    .HasColumnName("fnamed")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Lnamed)
                    .HasMaxLength(120)
                    .HasColumnName("lnamed")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SaAt)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewErjaArzyab>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Erja_Arzyab");

                entity.Property(e => e.ArgId).HasColumnName("argID");

                entity.Property(e => e.ArgName)
                    .HasMaxLength(200)
                    .HasColumnName("argName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateArz)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Descr)
                    .HasColumnName("descr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year)
                    .HasMaxLength(50)
                    .HasColumnName("ejra5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraMonth)
                    .HasMaxLength(50)
                    .HasColumnName("ejraMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraYear)
                    .HasMaxLength(50)
                    .HasColumnName("ejraYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ErId).HasColumnName("erID");

                entity.Property(e => e.ErjraDaily)
                    .HasMaxLength(50)
                    .HasColumnName("erjraDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HrWork).HasColumnName("hrWork");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.JalaseDate)
                    .HasMaxLength(50)
                    .HasColumnName("jalaseDate")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.JalaseNo)
                    .HasMaxLength(50)
                    .HasColumnName("jalaseNo")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiAlphabet)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiAlphabet")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiNumber)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiNumber")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q10)
                    .HasColumnName("q10")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q2)
                    .HasColumnName("q2")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q3)
                    .HasColumnName("q3")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q4)
                    .HasColumnName("q4")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q5)
                    .HasColumnName("q5")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q6)
                    .HasColumnName("q6")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q7)
                    .HasColumnName("q7")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q8)
                    .HasColumnName("q8")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q9)
                    .HasColumnName("q9")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.Sama5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sama5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarDaily)
                    .HasMaxLength(50)
                    .HasColumnName("samarDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarMonth)
                    .HasMaxLength(50)
                    .HasColumnName("samarMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarYear)
                    .HasMaxLength(50)
                    .HasColumnName("samarYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sarfe5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeDaily)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeMonth)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeYear)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewErjaArzyaban>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Erja_Arzyaban");

                entity.Property(e => e.ArzyabIdDes).HasColumnName("ArzyabID_DES");

                entity.Property(e => e.ArzyabIdSrc).HasColumnName("ArzyabID_SRC");

                entity.Property(e => e.ArzyabiId).HasColumnName("ArzyabiID");

                entity.Property(e => e.DateArz)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year)
                    .HasMaxLength(50)
                    .HasColumnName("ejra5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraMonth)
                    .HasMaxLength(50)
                    .HasColumnName("ejraMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraYear)
                    .HasMaxLength(50)
                    .HasColumnName("ejraYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ErjaId).HasColumnName("ErjaID");

                entity.Property(e => e.ErjraDaily)
                    .HasMaxLength(50)
                    .HasColumnName("erjraDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fnamed)
                    .HasMaxLength(120)
                    .HasColumnName("fnamed")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HrWork).HasColumnName("hrWork");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.JalaseNo)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lnamed)
                    .HasMaxLength(120)
                    .HasColumnName("lnamed")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiAlphabet)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiAlphabet")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiNumber)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiNumber")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q10)
                    .HasColumnName("q10")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q2)
                    .HasColumnName("q2")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q3)
                    .HasColumnName("q3")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q4)
                    .HasColumnName("q4")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q5)
                    .HasColumnName("q5")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q6)
                    .HasColumnName("q6")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q7)
                    .HasColumnName("q7")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q8)
                    .HasColumnName("q8")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q9)
                    .HasColumnName("q9")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.SaAt)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sama5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sama5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarDaily)
                    .HasMaxLength(50)
                    .HasColumnName("samarDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarMonth)
                    .HasMaxLength(50)
                    .HasColumnName("samarMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarYear)
                    .HasMaxLength(50)
                    .HasColumnName("samarYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sarfe5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeDaily)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeMonth)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeYear)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewErjaArzyabanBedonePasokh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ErjaArzyabanBedonePasokh");

                entity.Property(e => e.ArzyabIdDes).HasColumnName("ArzyabID_DES");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fnamed)
                    .HasMaxLength(120)
                    .HasColumnName("fnamed")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Lnamed)
                    .HasMaxLength(120)
                    .HasColumnName("lnamed")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewErjaArzyabanLastErja>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Erja_Arzyaban_LastErja");

                entity.Property(e => e.Cnt).HasColumnName("CNT");

                entity.Property(e => e.ErjaId).HasColumnName("ErjaID");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");
            });

            modelBuilder.Entity<ViewErjaArzyabanManage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Erja_ArzyabanManage");

                entity.Property(e => e.ArzyabIdDes).HasColumnName("ArzyabID_DES");

                entity.Property(e => e.ArzyabIdSrc).HasColumnName("ArzyabID_SRC");

                entity.Property(e => e.ArzyabiId).HasColumnName("ArzyabiID");

                entity.Property(e => e.DateArz)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year)
                    .HasMaxLength(50)
                    .HasColumnName("ejra5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraMonth)
                    .HasMaxLength(50)
                    .HasColumnName("ejraMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraYear)
                    .HasMaxLength(50)
                    .HasColumnName("ejraYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ErjaId).HasColumnName("ErjaID");

                entity.Property(e => e.ErjraDaily)
                    .HasMaxLength(50)
                    .HasColumnName("erjraDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fnamed)
                    .HasMaxLength(120)
                    .HasColumnName("fnamed")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HrWork).HasColumnName("hrWork");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.JalaseNo)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.K1).HasColumnName("k1");

                entity.Property(e => e.K2).HasColumnName("k2");

                entity.Property(e => e.K3).HasColumnName("k3");

                entity.Property(e => e.K4).HasColumnName("k4");

                entity.Property(e => e.K5).HasColumnName("k5");

                entity.Property(e => e.K6).HasColumnName("k6");

                entity.Property(e => e.K7).HasColumnName("k7");

                entity.Property(e => e.K8).HasColumnName("k8");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lnamed)
                    .HasMaxLength(120)
                    .HasColumnName("lnamed")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiAlphabet)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiAlphabet")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiNumber)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiNumber")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q10)
                    .HasColumnName("q10")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q2)
                    .HasColumnName("q2")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q3)
                    .HasColumnName("q3")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q4)
                    .HasColumnName("q4")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q5)
                    .HasColumnName("q5")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q6)
                    .HasColumnName("q6")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q7)
                    .HasColumnName("q7")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q8)
                    .HasColumnName("q8")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q9)
                    .HasColumnName("q9")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.SaAt)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sama5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sama5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarDaily)
                    .HasMaxLength(50)
                    .HasColumnName("samarDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarMonth)
                    .HasMaxLength(50)
                    .HasColumnName("samarMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarYear)
                    .HasMaxLength(50)
                    .HasColumnName("samarYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sarfe5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeDaily)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeMonth)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeYear)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewErjaKarGoroh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Erja_KarGoroh");

                entity.Property(e => e.DateArz)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Descr)
                    .HasColumnName("descr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year)
                    .HasMaxLength(50)
                    .HasColumnName("ejra5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraMonth)
                    .HasMaxLength(50)
                    .HasColumnName("ejraMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EjraYear)
                    .HasMaxLength(50)
                    .HasColumnName("ejraYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ErId).HasColumnName("erID");

                entity.Property(e => e.ErjraDaily)
                    .HasMaxLength(50)
                    .HasColumnName("erjraDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HrWork).HasColumnName("hrWork");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.JalaseDate)
                    .HasMaxLength(50)
                    .HasColumnName("jalaseDate")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.JalaseNo)
                    .HasMaxLength(50)
                    .HasColumnName("jalaseNo")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiAlphabet)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiAlphabet")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MablaghNahaiNumber)
                    .HasMaxLength(50)
                    .HasColumnName("mablaghNahaiNumber")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Q10)
                    .HasColumnName("q10")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q2)
                    .HasColumnName("q2")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q3)
                    .HasColumnName("q3")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q4)
                    .HasColumnName("q4")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q5)
                    .HasColumnName("q5")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q6)
                    .HasColumnName("q6")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q7)
                    .HasColumnName("q7")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q8)
                    .HasColumnName("q8")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q9)
                    .HasColumnName("q9")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.Sama5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sama5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarDaily)
                    .HasMaxLength(50)
                    .HasColumnName("samarDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarMonth)
                    .HasMaxLength(50)
                    .HasColumnName("samarMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SamarYear)
                    .HasMaxLength(50)
                    .HasColumnName("samarYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year)
                    .HasMaxLength(50)
                    .HasColumnName("sarfe5Year")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeDaily)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeDaily")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeMonth)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeMonth")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeYear)
                    .HasMaxLength(50)
                    .HasColumnName("sarfeYear")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WgName)
                    .HasMaxLength(200)
                    .HasColumnName("wgName")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewForm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Form");

                entity.Property(e => e.DocId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DocID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DocName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DocTypeName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FormID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FormName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FourLevelName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FourLevelNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("threeLevelID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelName)
                    .HasMaxLength(50)
                    .HasColumnName("threeLevelName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ZipAddress).UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewIso>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ISO");

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FormID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FormName)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pdfaddress)
                    .HasColumnName("PDFAddress")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WordAddress).UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewLastArzyabi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LastArzyabi");

                entity.Property(e => e.Cnt).HasColumnName("CNT");

                entity.Property(e => e.ErjaId).HasColumnName("ErjaID");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");
            });

            modelBuilder.Entity<ViewLastErjaInbox>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LastErjaInbox");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.JalaseNo)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sender)
                    .HasMaxLength(241)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewLogDl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LogDL");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(300)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FileId)
                    .HasMaxLength(50)
                    .HasColumnName("fileID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FileTypeId)
                    .HasMaxLength(50)
                    .HasColumnName("fileTypeID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .HasColumnName("password")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewOffer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Offers");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(300)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(50)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Emno)
                    .HasMaxLength(50)
                    .HasColumnName("EMno")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idof).HasColumnName("IDOf");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .HasColumnName("password")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewOffers2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Offers2");

                entity.Property(e => e.Ch01).HasColumnName("ch01");

                entity.Property(e => e.Ch02).HasColumnName("ch02");

                entity.Property(e => e.Ch03).HasColumnName("ch03");

                entity.Property(e => e.Ch04).HasColumnName("ch04");

                entity.Property(e => e.Ch05).HasColumnName("ch05");

                entity.Property(e => e.Ch06).HasColumnName("ch06");

                entity.Property(e => e.Ch07).HasColumnName("ch07");

                entity.Property(e => e.Ch08).HasColumnName("ch08");

                entity.Property(e => e.Ch09).HasColumnName("ch09");

                entity.Property(e => e.Ch10).HasColumnName("ch10");

                entity.Property(e => e.Ch11).HasColumnName("ch11");

                entity.Property(e => e.Ch12).HasColumnName("ch12");

                entity.Property(e => e.Ch13).HasColumnName("ch13");

                entity.Property(e => e.Ch14).HasColumnName("ch14");

                entity.Property(e => e.Ch15).HasColumnName("ch15");

                entity.Property(e => e.Ch16).HasColumnName("ch16");

                entity.Property(e => e.Ch17).HasColumnName("ch17");

                entity.Property(e => e.Ch18).HasColumnName("ch18");

                entity.Property(e => e.Ch19).HasColumnName("ch19");

                entity.Property(e => e.Ch20).HasColumnName("ch20");

                entity.Property(e => e.Ch21).HasColumnName("ch21");

                entity.Property(e => e.Ch22).HasColumnName("ch22");

                entity.Property(e => e.Ch23).HasColumnName("ch23");

                entity.Property(e => e.Ch24).HasColumnName("ch24");

                entity.Property(e => e.Ch25).HasColumnName("ch25");

                entity.Property(e => e.Ch26).HasColumnName("ch26");

                entity.Property(e => e.Ch27).HasColumnName("ch27");

                entity.Property(e => e.Ch28).HasColumnName("ch28");

                entity.Property(e => e.Ch29).HasColumnName("ch29");

                entity.Property(e => e.Ch30).HasColumnName("ch30");

                entity.Property(e => e.Ch31).HasColumnName("ch31");

                entity.Property(e => e.Ch32).HasColumnName("ch32");

                entity.Property(e => e.Ch33).HasColumnName("ch33");

                entity.Property(e => e.Ch34).HasColumnName("ch34");

                entity.Property(e => e.Ch35).HasColumnName("ch35");

                entity.Property(e => e.Ch36).HasColumnName("ch36");

                entity.Property(e => e.Ch37).HasColumnName("ch37");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(50)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CurrentDescPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Emno)
                    .HasMaxLength(50)
                    .HasColumnName("EMno")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idof).HasColumnName("IDOf");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.NewDesPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(50)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewOldPishnahadat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OldPishnahadat");

                entity.Property(e => e.DalileAdamEjra)
                    .HasMaxLength(100)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.DigarP)
                    .HasMaxLength(100)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fam)
                    .HasMaxLength(25)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Hadaya)
                    .HasMaxLength(100)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NamePishnahadDahande)
                    .HasMaxLength(30)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NazaryehKarshenas).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Onvan)
                    .HasMaxLength(255)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PadashHamkariEjrai).HasColumnType("money");

                entity.Property(e => e.PadashKarshenasiArzyabi).HasColumnType("money");

                entity.Property(e => e.PadashOk).HasColumnName("PadashOK");

                entity.Property(e => e.PadashPishnahad).HasColumnType("money");

                entity.Property(e => e.Pasokh).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PersonCode)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(32)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SarfeJooeArzi).HasColumnType("money");

                entity.Property(e => e.Semat)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SoodSarfe).HasColumnType("money");

                entity.Property(e => e.TarikhJalaseShora).HasColumnType("datetime");

                entity.Property(e => e.TarikhPayaneEjra).HasColumnType("datetime");

                entity.Property(e => e.TarikhSabt).HasColumnType("datetime");

                entity.Property(e => e.TarikhTasvib).HasColumnType("datetime");

                entity.Property(e => e.Wcode).HasColumnName("wcode");

                entity.Property(e => e.Wpcode).HasColumnName("WPCode");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<ViewOldpishnahad>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OLDPishnahad");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fam)
                    .HasMaxLength(25)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PersonCode)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(32)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewPayesh4level>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Payesh_4Level");

                entity.Property(e => e.Carno).HasColumnName("CARNo");

                entity.Property(e => e.DalEnBeAm).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateBegin)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateControl)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DefinePayesh).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DlRaShKe).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DoreyeZamani)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FourLevelName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FourLevelNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idmasole).HasColumnName("IDMasole");

                entity.Property(e => e.Idpayesh).HasColumnName("IDPayesh");

                entity.Property(e => e.IdstatusPayesh).HasColumnName("IDStatusPayesh");

                entity.Property(e => e.Kpimode).HasColumnName("KPIMode");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MeyarGhabol)
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MghdrAndGiSho)
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MiEnBeAm)
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SignMghdr).HasColumnName("signMghdr");

                entity.Property(e => e.StatusPayeshName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ThreeLevelNo)
                    .HasMaxLength(50)
                    .HasColumnName("threeLevelNo")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewPost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Post");

                entity.Property(e => e.Abstract)
                    .HasMaxLength(500)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.AddDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EduId).HasColumnName("edu_ID");

                entity.Property(e => e.PartId).HasColumnName("partID");

                entity.Property(e => e.PartName)
                    .HasMaxLength(50)
                    .HasColumnName("partName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pic)
                    .IsRequired()
                    .HasMaxLength(20)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewProp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Prop");

                entity.Property(e => e.AtF)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ch01).HasColumnName("ch01");

                entity.Property(e => e.Ch02).HasColumnName("ch02");

                entity.Property(e => e.Ch03).HasColumnName("ch03");

                entity.Property(e => e.Ch04).HasColumnName("ch04");

                entity.Property(e => e.Ch05).HasColumnName("ch05");

                entity.Property(e => e.Ch06).HasColumnName("ch06");

                entity.Property(e => e.Ch07).HasColumnName("ch07");

                entity.Property(e => e.Ch08).HasColumnName("ch08");

                entity.Property(e => e.Ch09).HasColumnName("ch09");

                entity.Property(e => e.Ch10).HasColumnName("ch10");

                entity.Property(e => e.Ch11).HasColumnName("ch11");

                entity.Property(e => e.Ch12).HasColumnName("ch12");

                entity.Property(e => e.Ch13).HasColumnName("ch13");

                entity.Property(e => e.Ch14).HasColumnName("ch14");

                entity.Property(e => e.Ch15).HasColumnName("ch15");

                entity.Property(e => e.Ch16).HasColumnName("ch16");

                entity.Property(e => e.Ch17).HasColumnName("ch17");

                entity.Property(e => e.Ch18).HasColumnName("ch18");

                entity.Property(e => e.Ch19).HasColumnName("ch19");

                entity.Property(e => e.Ch20).HasColumnName("ch20");

                entity.Property(e => e.Ch21).HasColumnName("ch21");

                entity.Property(e => e.Ch22).HasColumnName("ch22");

                entity.Property(e => e.Ch23).HasColumnName("ch23");

                entity.Property(e => e.Ch24).HasColumnName("ch24");

                entity.Property(e => e.Ch25).HasColumnName("ch25");

                entity.Property(e => e.Ch26).HasColumnName("ch26");

                entity.Property(e => e.Ch27).HasColumnName("ch27");

                entity.Property(e => e.Ch28).HasColumnName("ch28");

                entity.Property(e => e.Ch29).HasColumnName("ch29");

                entity.Property(e => e.Ch30).HasColumnName("ch30");

                entity.Property(e => e.Ch31).HasColumnName("ch31");

                entity.Property(e => e.Ch32).HasColumnName("ch32");

                entity.Property(e => e.Ch33).HasColumnName("ch33");

                entity.Property(e => e.Ch34).HasColumnName("ch34");

                entity.Property(e => e.Ch35).HasColumnName("ch35");

                entity.Property(e => e.Ch36).HasColumnName("ch36");

                entity.Property(e => e.Ch37).HasColumnName("ch37");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(50)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CurrentDescPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DesDabir)
                    .HasColumnName("desDabir")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.NahveyeMohasebe)
                    .HasColumnName("nahveyeMohasebe")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NewDesPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(50)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewProp4report>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Prop_4Report");

                entity.Property(e => e.AtF)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ch01).HasColumnName("ch01");

                entity.Property(e => e.Ch02).HasColumnName("ch02");

                entity.Property(e => e.Ch03).HasColumnName("ch03");

                entity.Property(e => e.Ch04).HasColumnName("ch04");

                entity.Property(e => e.Ch05).HasColumnName("ch05");

                entity.Property(e => e.Ch06).HasColumnName("ch06");

                entity.Property(e => e.Ch07).HasColumnName("ch07");

                entity.Property(e => e.Ch08).HasColumnName("ch08");

                entity.Property(e => e.Ch09).HasColumnName("ch09");

                entity.Property(e => e.Ch10).HasColumnName("ch10");

                entity.Property(e => e.Ch11).HasColumnName("ch11");

                entity.Property(e => e.Ch12).HasColumnName("ch12");

                entity.Property(e => e.Ch13).HasColumnName("ch13");

                entity.Property(e => e.Ch14).HasColumnName("ch14");

                entity.Property(e => e.Ch15).HasColumnName("ch15");

                entity.Property(e => e.Ch16).HasColumnName("ch16");

                entity.Property(e => e.Ch17).HasColumnName("ch17");

                entity.Property(e => e.Ch18).HasColumnName("ch18");

                entity.Property(e => e.Ch19).HasColumnName("ch19");

                entity.Property(e => e.Ch20).HasColumnName("ch20");

                entity.Property(e => e.Ch21).HasColumnName("ch21");

                entity.Property(e => e.Ch22).HasColumnName("ch22");

                entity.Property(e => e.Ch23).HasColumnName("ch23");

                entity.Property(e => e.Ch24).HasColumnName("ch24");

                entity.Property(e => e.Ch25).HasColumnName("ch25");

                entity.Property(e => e.Ch26).HasColumnName("ch26");

                entity.Property(e => e.Ch27).HasColumnName("ch27");

                entity.Property(e => e.Ch28).HasColumnName("ch28");

                entity.Property(e => e.Ch29).HasColumnName("ch29");

                entity.Property(e => e.Ch30).HasColumnName("ch30");

                entity.Property(e => e.Ch31).HasColumnName("ch31");

                entity.Property(e => e.Ch32).HasColumnName("ch32");

                entity.Property(e => e.Ch33).HasColumnName("ch33");

                entity.Property(e => e.Ch34).HasColumnName("ch34");

                entity.Property(e => e.Ch35).HasColumnName("ch35");

                entity.Property(e => e.Ch36).HasColumnName("ch36");

                entity.Property(e => e.Ch37).HasColumnName("ch37");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(50)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CurrentDescPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DesDabir)
                    .HasColumnName("desDabir")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Emno)
                    .HasMaxLength(50)
                    .HasColumnName("EMno")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idof).HasColumnName("IDOf");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NahveyeMohasebe)
                    .HasColumnName("nahveyeMohasebe")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NewDesPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<ViewProp4report1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Prop_4Report-");

                entity.Property(e => e.AtF)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ch01).HasColumnName("ch01");

                entity.Property(e => e.Ch02).HasColumnName("ch02");

                entity.Property(e => e.Ch03).HasColumnName("ch03");

                entity.Property(e => e.Ch04).HasColumnName("ch04");

                entity.Property(e => e.Ch05).HasColumnName("ch05");

                entity.Property(e => e.Ch06).HasColumnName("ch06");

                entity.Property(e => e.Ch07).HasColumnName("ch07");

                entity.Property(e => e.Ch08).HasColumnName("ch08");

                entity.Property(e => e.Ch09).HasColumnName("ch09");

                entity.Property(e => e.Ch10).HasColumnName("ch10");

                entity.Property(e => e.Ch11).HasColumnName("ch11");

                entity.Property(e => e.Ch12).HasColumnName("ch12");

                entity.Property(e => e.Ch13).HasColumnName("ch13");

                entity.Property(e => e.Ch14).HasColumnName("ch14");

                entity.Property(e => e.Ch15).HasColumnName("ch15");

                entity.Property(e => e.Ch16).HasColumnName("ch16");

                entity.Property(e => e.Ch17).HasColumnName("ch17");

                entity.Property(e => e.Ch18).HasColumnName("ch18");

                entity.Property(e => e.Ch19).HasColumnName("ch19");

                entity.Property(e => e.Ch20).HasColumnName("ch20");

                entity.Property(e => e.Ch21).HasColumnName("ch21");

                entity.Property(e => e.Ch22).HasColumnName("ch22");

                entity.Property(e => e.Ch23).HasColumnName("ch23");

                entity.Property(e => e.Ch24).HasColumnName("ch24");

                entity.Property(e => e.Ch25).HasColumnName("ch25");

                entity.Property(e => e.Ch26).HasColumnName("ch26");

                entity.Property(e => e.Ch27).HasColumnName("ch27");

                entity.Property(e => e.Ch28).HasColumnName("ch28");

                entity.Property(e => e.Ch29).HasColumnName("ch29");

                entity.Property(e => e.Ch30).HasColumnName("ch30");

                entity.Property(e => e.Ch31).HasColumnName("ch31");

                entity.Property(e => e.Ch32).HasColumnName("ch32");

                entity.Property(e => e.Ch33).HasColumnName("ch33");

                entity.Property(e => e.Ch34).HasColumnName("ch34");

                entity.Property(e => e.Ch35).HasColumnName("ch35");

                entity.Property(e => e.Ch36).HasColumnName("ch36");

                entity.Property(e => e.Ch37).HasColumnName("ch37");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(50)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CurrentDescPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DesDabir)
                    .HasColumnName("desDabir")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Emno)
                    .HasMaxLength(50)
                    .HasColumnName("EMno")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idof).HasColumnName("IDOf");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NahveyeMohasebe)
                    .HasColumnName("nahveyeMohasebe")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NewDesPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<ViewPropReFromAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Prop_ReFromAll");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(300)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.AtF)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ch01).HasColumnName("ch01");

                entity.Property(e => e.Ch02).HasColumnName("ch02");

                entity.Property(e => e.Ch03).HasColumnName("ch03");

                entity.Property(e => e.Ch04).HasColumnName("ch04");

                entity.Property(e => e.Ch05).HasColumnName("ch05");

                entity.Property(e => e.Ch06).HasColumnName("ch06");

                entity.Property(e => e.Ch07).HasColumnName("ch07");

                entity.Property(e => e.Ch08).HasColumnName("ch08");

                entity.Property(e => e.Ch09).HasColumnName("ch09");

                entity.Property(e => e.Ch10).HasColumnName("ch10");

                entity.Property(e => e.Ch11).HasColumnName("ch11");

                entity.Property(e => e.Ch12).HasColumnName("ch12");

                entity.Property(e => e.Ch13).HasColumnName("ch13");

                entity.Property(e => e.Ch14).HasColumnName("ch14");

                entity.Property(e => e.Ch15).HasColumnName("ch15");

                entity.Property(e => e.Ch16).HasColumnName("ch16");

                entity.Property(e => e.Ch17).HasColumnName("ch17");

                entity.Property(e => e.Ch18).HasColumnName("ch18");

                entity.Property(e => e.Ch19).HasColumnName("ch19");

                entity.Property(e => e.Ch20).HasColumnName("ch20");

                entity.Property(e => e.Ch21).HasColumnName("ch21");

                entity.Property(e => e.Ch22).HasColumnName("ch22");

                entity.Property(e => e.Ch23).HasColumnName("ch23");

                entity.Property(e => e.Ch24).HasColumnName("ch24");

                entity.Property(e => e.Ch25).HasColumnName("ch25");

                entity.Property(e => e.Ch26).HasColumnName("ch26");

                entity.Property(e => e.Ch27).HasColumnName("ch27");

                entity.Property(e => e.Ch28).HasColumnName("ch28");

                entity.Property(e => e.Ch29).HasColumnName("ch29");

                entity.Property(e => e.Ch30).HasColumnName("ch30");

                entity.Property(e => e.Ch31).HasColumnName("ch31");

                entity.Property(e => e.Ch32).HasColumnName("ch32");

                entity.Property(e => e.Ch33).HasColumnName("ch33");

                entity.Property(e => e.Ch34).HasColumnName("ch34");

                entity.Property(e => e.Ch35).HasColumnName("ch35");

                entity.Property(e => e.Ch36).HasColumnName("ch36");

                entity.Property(e => e.Ch37).HasColumnName("ch37");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(50)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentDescPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DesDabir)
                    .HasColumnName("desDabir")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.K1).HasColumnName("k1");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NahveyeMohasebe)
                    .HasColumnName("nahveyeMohasebe")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NewDesPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Q1).HasColumnName("q1");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(50)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewPropWithOffer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Prop_With_Offers");

                entity.Property(e => e.AtF)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(50)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CurrentDescPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DesDabir)
                    .HasColumnName("desDabir")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Emno)
                    .HasMaxLength(50)
                    .HasColumnName("EMno")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idof).HasColumnName("IDOf");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NahveyeMohasebe)
                    .HasColumnName("nahveyeMohasebe")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NewDesPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(50)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewPropWithOffers2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Prop_With_Offers_2");

                entity.Property(e => e.AtF)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(50)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CurrentDescPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DesDabir)
                    .HasColumnName("desDabir")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Emno)
                    .HasMaxLength(50)
                    .HasColumnName("EMno")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idof).HasColumnName("IDOf");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NahveyeMohasebe)
                    .HasColumnName("nahveyeMohasebe")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.NewDesPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Unit).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(50)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewProtest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Protest");

                entity.Property(e => e.Answ).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Descr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Emno)
                    .HasMaxLength(10)
                    .HasColumnName("EMNo")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Idprotest).HasColumnName("IDProtest");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Saat)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewRepEjra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Rep_Ejra");

                entity.Property(e => e.EblaghId).HasColumnName("EblaghID");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDPr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Tarikh)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Report");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(50)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewReq>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Req");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(300)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateEnd)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DocId)
                    .HasMaxLength(50)
                    .HasColumnName("DocID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FileNameS)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FormName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idreq).HasColumnName("IDReq");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .HasColumnName("password")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StateusId).HasColumnName("stateusID");

                entity.Property(e => e.StateusName)
                    .HasMaxLength(250)
                    .HasColumnName("stateusName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Time)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TypeReqId).HasColumnName("TypeReqID");

                entity.Property(e => e.TypeReqName)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UserText).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_tmp");

                entity.Property(e => e.Emno)
                    .HasMaxLength(50)
                    .HasColumnName("EMno")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewTotalProb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TotalProb");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(300)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Emno)
                    .HasMaxLength(50)
                    .HasColumnName("EMno")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Idof).HasColumnName("IDOf");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Usrid)
                    .IsRequired()
                    .HasMaxLength(120)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewUnder500>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Under500");

                entity.Property(e => e.Ch01).HasColumnName("ch01");

                entity.Property(e => e.Ch02).HasColumnName("ch02");

                entity.Property(e => e.Ch03).HasColumnName("ch03");

                entity.Property(e => e.Ch04).HasColumnName("ch04");

                entity.Property(e => e.Ch05).HasColumnName("ch05");

                entity.Property(e => e.Ch06).HasColumnName("ch06");

                entity.Property(e => e.Ch07).HasColumnName("ch07");

                entity.Property(e => e.Ch08).HasColumnName("ch08");

                entity.Property(e => e.Ch09).HasColumnName("ch09");

                entity.Property(e => e.Ch10).HasColumnName("ch10");

                entity.Property(e => e.Ch11).HasColumnName("ch11");

                entity.Property(e => e.Ch12).HasColumnName("ch12");

                entity.Property(e => e.Ch13).HasColumnName("ch13");

                entity.Property(e => e.Ch14).HasColumnName("ch14");

                entity.Property(e => e.Ch15).HasColumnName("ch15");

                entity.Property(e => e.Ch16).HasColumnName("ch16");

                entity.Property(e => e.Ch17).HasColumnName("ch17");

                entity.Property(e => e.Ch18).HasColumnName("ch18");

                entity.Property(e => e.Ch19).HasColumnName("ch19");

                entity.Property(e => e.Ch20).HasColumnName("ch20");

                entity.Property(e => e.Ch21).HasColumnName("ch21");

                entity.Property(e => e.Ch22).HasColumnName("ch22");

                entity.Property(e => e.Ch23).HasColumnName("ch23");

                entity.Property(e => e.Ch24).HasColumnName("ch24");

                entity.Property(e => e.Ch25).HasColumnName("ch25");

                entity.Property(e => e.Ch26).HasColumnName("ch26");

                entity.Property(e => e.Ch27).HasColumnName("ch27");

                entity.Property(e => e.Ch28).HasColumnName("ch28");

                entity.Property(e => e.Ch29).HasColumnName("ch29");

                entity.Property(e => e.Ch30).HasColumnName("ch30");

                entity.Property(e => e.Ch31).HasColumnName("ch31");

                entity.Property(e => e.Ch32).HasColumnName("ch32");

                entity.Property(e => e.Ch33).HasColumnName("ch33");

                entity.Property(e => e.Ch34).HasColumnName("ch34");

                entity.Property(e => e.Ch35).HasColumnName("ch35");

                entity.Property(e => e.Ch36).HasColumnName("ch36");

                entity.Property(e => e.Ch37).HasColumnName("ch37");

                entity.Property(e => e.CodeBazr)
                    .HasMaxLength(50)
                    .HasColumnName("codeBazr")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CurrentDescPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.DateN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ejra5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EjraYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Get5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GetYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idpr).HasColumnName("IDpr");

                entity.Property(e => e.Idst).HasColumnName("IDSt");

                entity.Property(e => e.NewDesPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Sarfe5Year).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeDaily).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeMonthly).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SarfeYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.SubjectPr).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.TimeN)
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Usrid)
                    .HasMaxLength(50)
                    .HasColumnName("USRID")
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewUnitWithFatherUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_UnitWithFatherUnit");

                entity.Property(e => e.FatherUnit).UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Ids).HasColumnName("IDS");

                entity.Property(e => e.Unit).UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewUsr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_USR");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(1200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmP)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FatherUnit)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(480)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lname)
                    .HasMaxLength(480)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(1000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Password)
                    .HasMaxLength(2000)
                    .HasColumnName("password")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Pic)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(800)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Unit)
                    .HasMaxLength(4000)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<ViewWgp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_WGP");

                entity.Property(e => e.AddressHome)
                    .HasMaxLength(300)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmP)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Fname)
                    .HasMaxLength(120)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Lname)
                    .HasMaxLength(120)
                    .HasColumnName("lname")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.ManId).HasColumnName("ManID");

                entity.Property(e => e.ManName)
                    .HasMaxLength(250)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Semat)
                    .HasMaxLength(200)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WgId).HasColumnName("wgID");

                entity.Property(e => e.WgName)
                    .HasMaxLength(200)
                    .HasColumnName("wgName")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.WgStatus).HasColumnName("wgStatus");

                entity.Property(e => e.WgpId).HasColumnName("wgpID");

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");
            });

            modelBuilder.Entity<VolumesInternal>(entity =>
            {
                entity.HasKey(e => new { e.ProcessingTime, e.PhysicalServerName, e.VolumeDeviceId })
                    .HasName("pk_volumes_internal");

                entity.ToTable("volumes_internal", "sysutility_ucp_core");

                entity.Property(e => e.ProcessingTime).HasColumnName("processing_time");

                entity.Property(e => e.PhysicalServerName)
                    .HasMaxLength(128)
                    .HasColumnName("physical_server_name");

                entity.Property(e => e.VolumeDeviceId)
                    .HasMaxLength(128)
                    .HasColumnName("volume_device_id");

                entity.Property(e => e.BatchTime).HasColumnName("batch_time");

                entity.Property(e => e.FreeSpace).HasColumnName("free_space");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PowershellPath)
                    .HasMaxLength(4000)
                    .HasColumnName("powershell_path");

                entity.Property(e => e.TotalSpaceAvailable).HasColumnName("total_space_available");

                entity.Property(e => e.VirtualServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("virtual_server_name");

                entity.Property(e => e.VolumeName)
                    .HasMaxLength(260)
                    .HasColumnName("volume_name");
            });

            modelBuilder.Entity<WaitCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_categories");

                entity.ToTable("wait_categories", "core");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("category_name");

                entity.Property(e => e.Ignore).HasColumnName("ignore");
            });

            modelBuilder.Entity<WaitType>(entity =>
            {
                entity.HasKey(e => e.WaitType1)
                    .HasName("PK_events");

                entity.ToTable("wait_types", "core");

                entity.Property(e => e.WaitType1)
                    .HasMaxLength(45)
                    .HasColumnName("wait_type");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.WaitTypes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_events_categories");
            });

            modelBuilder.Entity<WaitTypesCategorized>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("wait_types_categorized", "core");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("category_name");

                entity.Property(e => e.Ignore).HasColumnName("ignore");

                entity.Property(e => e.WaitType)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("wait_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
