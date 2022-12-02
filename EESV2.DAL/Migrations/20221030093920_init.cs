using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EESV2.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommitteeStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommitteeStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level3ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level3ProcessCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level4ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level4ProcessCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ImpartStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImpartStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedDateTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsShow = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParrentOfficeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Offices_Offices_ParrentOfficeID",
                        column: x => x.ParrentOfficeID,
                        principalTable: "Offices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PortalMembershipTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalMembershipTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProposalStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposalStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReferralStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserPosts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPosts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VisitorStatistics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorStatistics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressHome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeID = table.Column<int>(type: "int", nullable: false),
                    EmploymentTypeID = table.Column<int>(type: "int", nullable: false),
                    PortalMembershipTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_EmploymentTypes_EmploymentTypeID",
                        column: x => x.EmploymentTypeID,
                        principalTable: "EmploymentTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Offices_OfficeID",
                        column: x => x.OfficeID,
                        principalTable: "Offices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_PortalMembershipTypes_PortalMembershipTypeID",
                        column: x => x.PortalMembershipTypeID,
                        principalTable: "PortalMembershipTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_UserPosts_PostID",
                        column: x => x.PostID,
                        principalTable: "UserPosts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_UserStatuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "UserStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Committees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    SecretaryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Committees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Committees_CommitteeStatuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "CommitteeStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Committees_Users_SecretaryID",
                        column: x => x.SecretaryID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "proposals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectPr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentDescPr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewDesPr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeBazr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesDabir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ch01 = table.Column<bool>(type: "bit", nullable: false),
                    Ch02 = table.Column<bool>(type: "bit", nullable: false),
                    Ch03 = table.Column<bool>(type: "bit", nullable: false),
                    Ch04 = table.Column<bool>(type: "bit", nullable: false),
                    Ch05 = table.Column<bool>(type: "bit", nullable: false),
                    Ch06 = table.Column<bool>(type: "bit", nullable: false),
                    Ch07 = table.Column<bool>(type: "bit", nullable: false),
                    Ch08 = table.Column<bool>(type: "bit", nullable: false),
                    Ch09 = table.Column<bool>(type: "bit", nullable: false),
                    Ch10 = table.Column<bool>(type: "bit", nullable: false),
                    Ch11 = table.Column<bool>(type: "bit", nullable: false),
                    Ch12 = table.Column<bool>(type: "bit", nullable: false),
                    Ch13 = table.Column<bool>(type: "bit", nullable: false),
                    Ch14 = table.Column<bool>(type: "bit", nullable: false),
                    Ch15 = table.Column<bool>(type: "bit", nullable: false),
                    Ch16 = table.Column<bool>(type: "bit", nullable: false),
                    Ch17 = table.Column<bool>(type: "bit", nullable: false),
                    Ch18 = table.Column<bool>(type: "bit", nullable: false),
                    Ch19 = table.Column<bool>(type: "bit", nullable: false),
                    Ch20 = table.Column<bool>(type: "bit", nullable: false),
                    Ch21 = table.Column<bool>(type: "bit", nullable: false),
                    Ch22 = table.Column<bool>(type: "bit", nullable: false),
                    Ch23 = table.Column<bool>(type: "bit", nullable: false),
                    Ch24 = table.Column<bool>(type: "bit", nullable: false),
                    Ch25 = table.Column<bool>(type: "bit", nullable: false),
                    Ch26 = table.Column<bool>(type: "bit", nullable: false),
                    Ch27 = table.Column<bool>(type: "bit", nullable: false),
                    Ch28 = table.Column<bool>(type: "bit", nullable: false),
                    Ch29 = table.Column<bool>(type: "bit", nullable: false),
                    Ch30 = table.Column<bool>(type: "bit", nullable: false),
                    Ch31 = table.Column<bool>(type: "bit", nullable: false),
                    Ch32 = table.Column<bool>(type: "bit", nullable: false),
                    Ch33 = table.Column<bool>(type: "bit", nullable: false),
                    Ch34 = table.Column<bool>(type: "bit", nullable: false),
                    Ch35 = table.Column<bool>(type: "bit", nullable: false),
                    Ch36 = table.Column<bool>(type: "bit", nullable: false),
                    Ch37 = table.Column<bool>(type: "bit", nullable: false),
                    EjraDaily = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EjraMonthly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EjraYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ejra5Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetDaily = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetMonthly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GetYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Get5Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SarfeDaily = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SarfeMonthly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SarfeYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sarfe5Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrarID = table.Column<int>(type: "int", nullable: false),
                    RegistrarParticipatePercent = table.Column<int>(type: "int", nullable: false),
                    StatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proposals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_proposals_ProposalStatuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "ProposalStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_proposals_Users_RegistrarID",
                        column: x => x.RegistrarID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Q1 = table.Column<int>(type: "int", nullable: false),
                    Q2 = table.Column<int>(type: "int", nullable: false),
                    Q3 = table.Column<int>(type: "int", nullable: false),
                    Q4 = table.Column<int>(type: "int", nullable: false),
                    Q5 = table.Column<int>(type: "int", nullable: false),
                    Q6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q8 = table.Column<int>(type: "int", nullable: false),
                    Q9 = table.Column<int>(type: "int", nullable: false),
                    Q10 = table.Column<int>(type: "int", nullable: false),
                    Q11 = table.Column<int>(type: "int", nullable: false),
                    Q12 = table.Column<int>(type: "int", nullable: false),
                    Q13 = table.Column<int>(type: "int", nullable: false),
                    Q14 = table.Column<int>(type: "int", nullable: false),
                    Q15 = table.Column<int>(type: "int", nullable: false),
                    Q16 = table.Column<int>(type: "int", nullable: false),
                    Q17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSeenByAdmin = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Surveys_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserCommittees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommitteeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCommittees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCommittees_Committees_CommitteeID",
                        column: x => x.CommitteeID,
                        principalTable: "Committees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserCommittees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imparts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cost = table.Column<long>(type: "bigint", nullable: true),
                    ExecutorRegistrationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExecutorRegistrationTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExecutorIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionExecute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeToExecute = table.Column<int>(type: "int", nullable: true),
                    StartDateExecute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDateExecute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalID = table.Column<int>(type: "int", nullable: false),
                    ExecutorID = table.Column<int>(type: "int", nullable: false),
                    ImpartStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imparts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Imparts_ImpartStatuses_ImpartStatusID",
                        column: x => x.ImpartStatusID,
                        principalTable: "ImpartStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imparts_proposals_ProposalID",
                        column: x => x.ProposalID,
                        principalTable: "proposals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imparts_Users_ExecutorID",
                        column: x => x.ExecutorID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Objections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reasons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ProposalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objections", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Objections_proposals_ProposalID",
                        column: x => x.ProposalID,
                        principalTable: "proposals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Objections_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ProposalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Participants_proposals_ProposalID",
                        column: x => x.ProposalID,
                        principalTable: "proposals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participants_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Referrals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderID = table.Column<int>(type: "int", nullable: false),
                    ReciverID = table.Column<int>(type: "int", nullable: false),
                    ProposalID = table.Column<int>(type: "int", nullable: false),
                    EvaluationTypeID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referrals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Referrals_EvaluationTypes_EvaluationTypeID",
                        column: x => x.EvaluationTypeID,
                        principalTable: "EvaluationTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Referrals_proposals_ProposalID",
                        column: x => x.ProposalID,
                        principalTable: "proposals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Referrals_ReferralStatuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "ReferralStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Referrals_Users_ReciverID",
                        column: x => x.ReciverID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Referrals_Users_SenderID",
                        column: x => x.SenderID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgressReports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Percentage = table.Column<int>(type: "int", nullable: false),
                    Defects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImpartID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressReports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProgressReports_Imparts_ImpartID",
                        column: x => x.ImpartID,
                        principalTable: "Imparts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserImparts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ImpartID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImparts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserImparts_Imparts_ImpartID",
                        column: x => x.ImpartID,
                        principalTable: "Imparts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserImparts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NewQualityEvaluations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PishOk = table.Column<bool>(type: "bit", nullable: true),
                    Quality = table.Column<byte>(type: "tinyint", nullable: true),
                    HrWork = table.Column<double>(type: "float", nullable: true),
                    Q1 = table.Column<int>(type: "int", nullable: false),
                    Q2 = table.Column<int>(type: "int", nullable: false),
                    Q3 = table.Column<int>(type: "int", nullable: false),
                    Q4 = table.Column<int>(type: "int", nullable: false),
                    Q5 = table.Column<int>(type: "int", nullable: false),
                    Q6 = table.Column<int>(type: "int", nullable: false),
                    Q7 = table.Column<int>(type: "int", nullable: false),
                    Q8 = table.Column<int>(type: "int", nullable: false),
                    Q9 = table.Column<int>(type: "int", nullable: false),
                    Q10 = table.Column<int>(type: "int", nullable: false),
                    Q11 = table.Column<int>(type: "int", nullable: false),
                    Q12 = table.Column<int>(type: "int", nullable: false),
                    Q13 = table.Column<int>(type: "int", nullable: false),
                    Q14 = table.Column<int>(type: "int", nullable: false),
                    Q15 = table.Column<int>(type: "int", nullable: false),
                    Q16 = table.Column<int>(type: "int", nullable: false),
                    Q17 = table.Column<int>(type: "int", nullable: false),
                    Q18 = table.Column<int>(type: "int", nullable: false),
                    RejectReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferralID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewQualityEvaluations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NewQualityEvaluations_Referrals_ReferralID",
                        column: x => x.ReferralID,
                        principalTable: "Referrals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QualityEvaluations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PishOk = table.Column<bool>(type: "bit", nullable: true),
                    Quality = table.Column<byte>(type: "tinyint", nullable: true),
                    HrWork = table.Column<double>(type: "float", nullable: true),
                    K1 = table.Column<int>(type: "int", nullable: true),
                    K2 = table.Column<int>(type: "int", nullable: true),
                    K3 = table.Column<int>(type: "int", nullable: true),
                    K4 = table.Column<int>(type: "int", nullable: true),
                    K5 = table.Column<int>(type: "int", nullable: true),
                    K6 = table.Column<int>(type: "int", nullable: true),
                    K7 = table.Column<int>(type: "int", nullable: true),
                    K8 = table.Column<int>(type: "int", nullable: true),
                    RejectReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferralID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityEvaluations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QualityEvaluations_Referrals_ReferralID",
                        column: x => x.ReferralID,
                        principalTable: "Referrals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuantitativEvaluations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PishOk = table.Column<bool>(type: "bit", nullable: true),
                    Quality = table.Column<byte>(type: "tinyint", nullable: true),
                    HrWork = table.Column<double>(type: "float", nullable: true),
                    Q1 = table.Column<byte>(type: "tinyint", nullable: true),
                    Q2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErjraDaily = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EjraMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EjraYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ejra5Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SamarDaily = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SamarMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SamarYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sama5Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SarfeDaily = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SarfeMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SarfeYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sarfe5Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MablaghNahaiNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MablaghNahaiAlphabet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateArz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferralID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuantitativEvaluations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QuantitativEvaluations_Referrals_ReferralID",
                        column: x => x.ReferralID,
                        principalTable: "Referrals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CommitteeStatuses",
                columns: new[] { "ID", "Title" },
                values: new object[,]
                {
                    { 1, "فعال" },
                    { 2, "غیر فعال" }
                });

            migrationBuilder.InsertData(
                table: "EmploymentTypes",
                columns: new[] { "ID", "Title" },
                values: new object[,]
                {
                    { 1, "رسمی" },
                    { 2, "قرار دادی" },
                    { 3, "پیمانکاری" }
                });

            migrationBuilder.InsertData(
                table: "EvaluationTypes",
                columns: new[] { "ID", "Title" },
                values: new object[,]
                {
                    { 1, "فرم کمی" },
                    { 2, "فرم کیفی" },
                    { 3, "نامشخص" }
                });

            migrationBuilder.InsertData(
                table: "ImpartStatuses",
                columns: new[] { "ID", "Title" },
                values: new object[,]
                {
                    { 1, "نامشخص" },
                    { 2, "تایید و ابلاغ اجرایه توسط دبیرخانه نظام مشارکت و اقدام جهت اجرا" },
                    { 3, "انجام برآورد مجری - منتظر تایید دبیرخانه نظام مشارکت" },
                    { 4, "لطفا برآورد هزینه، برنامه، همکاران اجرایی پیشنهاد بررسی مجدد گردد" },
                    { 5, "ارسال به ستاد انتقال" },
                    { 6, "ارسال به ستاد ملی گاز" }
                });

            migrationBuilder.InsertData(
                table: "PortalMembershipTypes",
                columns: new[] { "ID", "Title" },
                values: new object[,]
                {
                    { 5, "ارزیاب تخصصی" },
                    { 3, "عضو شورای مشارکت" },
                    { 4, "عضو کمیته تخصصی فرعی" },
                    { 1, "عادی" },
                    { 2, "رئیس واحد" }
                });

            migrationBuilder.InsertData(
                table: "ProposalStatuses",
                columns: new[] { "ID", "Title" },
                values: new object[,]
                {
                    { 8, "تایید ارزیابی و اماده طرح در شورای مرکزی" },
                    { 1, "ارجاع به ارزیابی" },
                    { 2, "تصویب شده" },
                    { 3, "رد شده" },
                    { 4, "در دست برسی" },
                    { 5, "اجرا شده" },
                    { 6, "عودت از ارزیابی به دبیرخانه" },
                    { 7, "سایر" },
                    { 9, "ابلاغ به واحد مجری" }
                });

            migrationBuilder.InsertData(
                table: "ReferralStatuses",
                columns: new[] { "ID", "Title" },
                values: new object[,]
                {
                    { 1, "مشاهده شده" },
                    { 2, "مشاهده نشده" },
                    { 3, "ارزیابی شده" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "Title" },
                values: new object[] { 1, "Secretary" });

            migrationBuilder.InsertData(
                table: "UserPosts",
                columns: new[] { "ID", "Title" },
                values: new object[] { 1, "تست" });

            migrationBuilder.InsertData(
                table: "UserStatuses",
                columns: new[] { "ID", "Title" },
                values: new object[,]
                {
                    { 2, "غیر فعال" },
                    { 1, "فعال" },
                    { 3, "بازنشسته" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Committees_SecretaryID",
                table: "Committees",
                column: "SecretaryID");

            migrationBuilder.CreateIndex(
                name: "IX_Committees_StatusID",
                table: "Committees",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Imparts_ExecutorID",
                table: "Imparts",
                column: "ExecutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Imparts_ImpartStatusID",
                table: "Imparts",
                column: "ImpartStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Imparts_ProposalID",
                table: "Imparts",
                column: "ProposalID");

            migrationBuilder.CreateIndex(
                name: "IX_NewQualityEvaluations_ReferralID",
                table: "NewQualityEvaluations",
                column: "ReferralID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Objections_ProposalID",
                table: "Objections",
                column: "ProposalID");

            migrationBuilder.CreateIndex(
                name: "IX_Objections_UserID",
                table: "Objections",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_ParrentOfficeID",
                table: "Offices",
                column: "ParrentOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_ProposalID",
                table: "Participants",
                column: "ProposalID");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_UserID",
                table: "Participants",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressReports_ImpartID",
                table: "ProgressReports",
                column: "ImpartID");

            migrationBuilder.CreateIndex(
                name: "IX_proposals_RegistrarID",
                table: "proposals",
                column: "RegistrarID");

            migrationBuilder.CreateIndex(
                name: "IX_proposals_StatusID",
                table: "proposals",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_QualityEvaluations_ReferralID",
                table: "QualityEvaluations",
                column: "ReferralID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuantitativEvaluations_ReferralID",
                table: "QuantitativEvaluations",
                column: "ReferralID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_EvaluationTypeID",
                table: "Referrals",
                column: "EvaluationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_ProposalID",
                table: "Referrals",
                column: "ProposalID");

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_ReciverID",
                table: "Referrals",
                column: "ReciverID");

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_SenderID",
                table: "Referrals",
                column: "SenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_StatusID",
                table: "Referrals",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_UserID",
                table: "Surveys",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserCommittees_CommitteeID",
                table: "UserCommittees",
                column: "CommitteeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserCommittees_UserId",
                table: "UserCommittees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserImparts_ImpartID",
                table: "UserImparts",
                column: "ImpartID");

            migrationBuilder.CreateIndex(
                name: "IX_UserImparts_UserID",
                table: "UserImparts",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRoles",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmploymentTypeID",
                table: "Users",
                column: "EmploymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OfficeID",
                table: "Users",
                column: "OfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PortalMembershipTypeID",
                table: "Users",
                column: "PortalMembershipTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PostID",
                table: "Users",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StatusID",
                table: "Users",
                column: "StatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "NewQualityEvaluations");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Objections");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "ProgressReports");

            migrationBuilder.DropTable(
                name: "QualityEvaluations");

            migrationBuilder.DropTable(
                name: "QuantitativEvaluations");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.DropTable(
                name: "UserCommittees");

            migrationBuilder.DropTable(
                name: "UserImparts");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "VisitorStatistics");

            migrationBuilder.DropTable(
                name: "Referrals");

            migrationBuilder.DropTable(
                name: "Committees");

            migrationBuilder.DropTable(
                name: "Imparts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "EvaluationTypes");

            migrationBuilder.DropTable(
                name: "ReferralStatuses");

            migrationBuilder.DropTable(
                name: "CommitteeStatuses");

            migrationBuilder.DropTable(
                name: "ImpartStatuses");

            migrationBuilder.DropTable(
                name: "proposals");

            migrationBuilder.DropTable(
                name: "ProposalStatuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "EmploymentTypes");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "PortalMembershipTypes");

            migrationBuilder.DropTable(
                name: "UserPosts");

            migrationBuilder.DropTable(
                name: "UserStatuses");
        }
    }
}
