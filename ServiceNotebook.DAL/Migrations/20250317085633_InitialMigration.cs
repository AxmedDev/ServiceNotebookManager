using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceNotebook.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeNotebooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Citizenship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMarried = table.Column<bool>(type: "bit", nullable: false),
                    MainPhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OtherPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeNotebooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeNotebookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_EmployeeNotebooks_EmployeeNotebookId",
                        column: x => x.EmployeeNotebookId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CombatParticipations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Injuries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeteranStatus = table.Column<int>(type: "int", nullable: false),
                    EmployeeNotebookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombatParticipations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CombatParticipations_EmployeeNotebooks_EmployeeNotebookId",
                        column: x => x.EmployeeNotebookId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiplomaNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DiplomaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeNotebookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_EmployeeNotebooks_EmployeeNotebookId",
                        column: x => x.EmployeeNotebookId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeNotebookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyMembers_EmployeeNotebooks_EmployeeNotebookId",
                        column: x => x.EmployeeNotebookId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForeignLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProficiencyLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeNotebookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForeignLanguages_EmployeeNotebooks_EmployeeNotebookId",
                        column: x => x.EmployeeNotebookId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalInstitution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExaminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceSuitability = table.Column<int>(type: "int", nullable: false),
                    EmployeeNotebookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthStatuses_EmployeeNotebooks_EmployeeNotebookId",
                        column: x => x.EmployeeNotebookId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentificationDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssuingAuthority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodType = table.Column<int>(type: "int", nullable: false),
                    EmployeeNotebookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentificationDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentificationDocuments_EmployeeNotebooks_EmployeeNotebookId",
                        column: x => x.EmployeeNotebookId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Workplace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeNotebookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExperiences_EmployeeNotebooks_EmployeeNotebookId",
                        column: x => x.EmployeeNotebookId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeNotebookOrder",
                columns: table => new
                {
                    EmployeeNotebooksId = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeNotebookOrder", x => new { x.EmployeeNotebooksId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_EmployeeNotebookOrder_EmployeeNotebooks_EmployeeNotebooksId",
                        column: x => x.EmployeeNotebooksId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeNotebookOrder_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MilitaryRank = table.Column<int>(type: "int", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    EmployeeNotebookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MilitaryServices_EmployeeNotebooks_EmployeeNotebookId",
                        column: x => x.EmployeeNotebookId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MilitaryServices_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillDegrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<int>(type: "int", nullable: false),
                    AssignmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    EmployeeNotebookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillDegrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillDegrees_EmployeeNotebooks_EmployeeNotebookId",
                        column: x => x.EmployeeNotebookId,
                        principalTable: "EmployeeNotebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillDegrees_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_EmployeeNotebookId",
                table: "Addresses",
                column: "EmployeeNotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_CombatParticipations_EmployeeNotebookId",
                table: "CombatParticipations",
                column: "EmployeeNotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_DiplomaNumber",
                table: "Educations",
                column: "DiplomaNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_EmployeeNotebookId",
                table: "Educations",
                column: "EmployeeNotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeNotebookOrder_OrdersId",
                table: "EmployeeNotebookOrder",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeNotebooks_MainPhoneNumber",
                table: "EmployeeNotebooks",
                column: "MainPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FamilyMembers_EmployeeNotebookId",
                table: "FamilyMembers",
                column: "EmployeeNotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignLanguages_EmployeeNotebookId",
                table: "ForeignLanguages",
                column: "EmployeeNotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthStatuses_EmployeeNotebookId",
                table: "HealthStatuses",
                column: "EmployeeNotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentificationDocuments_DocumentNumber",
                table: "IdentificationDocuments",
                column: "DocumentNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IdentificationDocuments_EmployeeNotebookId",
                table: "IdentificationDocuments",
                column: "EmployeeNotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_MilitaryServices_EmployeeNotebookId",
                table: "MilitaryServices",
                column: "EmployeeNotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_MilitaryServices_OrderId",
                table: "MilitaryServices",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderNumber",
                table: "Orders",
                column: "OrderNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SkillDegrees_EmployeeNotebookId",
                table: "SkillDegrees",
                column: "EmployeeNotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillDegrees_OrderId",
                table: "SkillDegrees",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_EmployeeNotebookId",
                table: "WorkExperiences",
                column: "EmployeeNotebookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CombatParticipations");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "EmployeeNotebookOrder");

            migrationBuilder.DropTable(
                name: "FamilyMembers");

            migrationBuilder.DropTable(
                name: "ForeignLanguages");

            migrationBuilder.DropTable(
                name: "HealthStatuses");

            migrationBuilder.DropTable(
                name: "IdentificationDocuments");

            migrationBuilder.DropTable(
                name: "MilitaryServices");

            migrationBuilder.DropTable(
                name: "SkillDegrees");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "EmployeeNotebooks");
        }
    }
}
