using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Gos.Migrations
{
    /// <inheritdoc />
    public partial class SyncWithDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Overeyingofpets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    adress = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("peremoga_pk", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "shelter",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    adress = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("shelter_pk", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    firstname = table.Column<string>(type: "character varying", maxLength: 40, nullable: false),
                    secondname = table.Column<string>(type: "character varying", maxLength: 40, nullable: false),
                    therdname = table.Column<string>(type: "character varying", maxLength: 40, nullable: false),
                    phone = table.Column<string>(type: "character varying", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("user_pk", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vetclinic",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    adress = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("vetclinic_pk", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "animalsinheltetrs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Name = table.Column<string>(type: "character varying", nullable: false),
                    idshelters = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("animalsheltetr_pk", x => x.id);
                    table.ForeignKey(
                        name: "animalsinheltetrs_shelter_fk",
                        column: x => x.idshelters,
                        principalTable: "shelter",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "animal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    age = table.Column<int>(type: "integer", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    nameanimal = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("animal_pk", x => x.id);
                    table.ForeignKey(
                        name: "animal_user_fk",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "missinganimal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    userid = table.Column<int>(type: "integer", nullable: false),
                    animalid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("missinganimal_pk", x => x.id);
                    table.ForeignKey(
                        name: "missinganimal_user_fk",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "reweis",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    comm = table.Column<string>(type: "character varying", nullable: false),
                    id_user = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("reweis_pk", x => x.id);
                    table.ForeignKey(
                        name: "reweis_user_fk",
                        column: x => x.id_user,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "takeanimal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    shelerid = table.Column<int>(type: "integer", nullable: false),
                    aniimalsinsheltrsid = table.Column<int>(type: "integer", nullable: false),
                    iduser = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("takeanimal_pk", x => x.id);
                    table.ForeignKey(
                        name: "takeanimal_animalsinheltetrs_fk",
                        column: x => x.aniimalsinsheltrsid,
                        principalTable: "animalsinheltetrs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "takeanimal_shelter_fk",
                        column: x => x.shelerid,
                        principalTable: "shelter",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "takeanimal_user_fk",
                        column: x => x.iduser,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "passport",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    serea = table.Column<int>(type: "integer", nullable: false),
                    number = table.Column<int>(type: "integer", nullable: false),
                    animalid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("passport_pk", x => x.id);
                    table.ForeignKey(
                        name: "passport_animal_fk",
                        column: x => x.id,
                        principalTable: "animal",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "recod",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    vetclinid = table.Column<int>(type: "integer", nullable: false),
                    userid = table.Column<int>(type: "integer", nullable: false),
                    animalid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("recod_pk", x => x.id);
                    table.ForeignKey(
                        name: "recod_animal_fk",
                        column: x => x.animalid,
                        principalTable: "animal",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "recod_user_fk",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "recod_vetclinic_fk",
                        column: x => x.vetclinid,
                        principalTable: "vetclinic",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "takeOvereyingofpets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    animalid = table.Column<int>(type: "integer", nullable: false),
                    peremoga = table.Column<int>(type: "integer", nullable: false),
                    userid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("newtable_pk", x => x.id);
                    table.ForeignKey(
                        name: "takeperemoga_animal_fk",
                        column: x => x.animalid,
                        principalTable: "animal",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "takeperemoga_peremoga_fk",
                        column: x => x.peremoga,
                        principalTable: "Overeyingofpets",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "takeperemoga_user_fk",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "comm_overeyeing",
                columns: table => new
                {
                    reweis_over = table.Column<int>(type: "integer", nullable: false),
                    overeyeing = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "comm_overeyeing_overeyingofpets_fk",
                        column: x => x.overeyeing,
                        principalTable: "Overeyingofpets",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "comm_overeyeing_reweis_fk",
                        column: x => x.reweis_over,
                        principalTable: "reweis",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "commvet",
                columns: table => new
                {
                    idcomm = table.Column<int>(type: "integer", nullable: false),
                    idvet = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("commvet_pk", x => new { x.idcomm, x.idvet });
                    table.ForeignKey(
                        name: "commvet_reweis_fk",
                        column: x => x.idcomm,
                        principalTable: "reweis",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "commvet_vetclinic_fk",
                        column: x => x.idvet,
                        principalTable: "vetclinic",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "vaccine",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    pssoprtid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("vacin_pk", x => x.id);
                    table.ForeignKey(
                        name: "vacin_passport_fk",
                        column: x => x.pssoprtid,
                        principalTable: "passport",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_animal_user_id",
                table: "animal",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_animalsinheltetrs_idshelters",
                table: "animalsinheltetrs",
                column: "idshelters");

            migrationBuilder.CreateIndex(
                name: "comm_overeyeing_unique",
                table: "comm_overeyeing",
                columns: new[] { "overeyeing", "reweis_over" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_comm_overeyeing_reweis_over",
                table: "comm_overeyeing",
                column: "reweis_over");

            migrationBuilder.CreateIndex(
                name: "IX_commvet_idvet",
                table: "commvet",
                column: "idvet");

            migrationBuilder.CreateIndex(
                name: "IX_missinganimal_userid",
                table: "missinganimal",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_recod_animalid",
                table: "recod",
                column: "animalid");

            migrationBuilder.CreateIndex(
                name: "IX_recod_userid",
                table: "recod",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_recod_vetclinid",
                table: "recod",
                column: "vetclinid");

            migrationBuilder.CreateIndex(
                name: "IX_reweis_id_user",
                table: "reweis",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "IX_takeanimal_aniimalsinsheltrsid",
                table: "takeanimal",
                column: "aniimalsinsheltrsid");

            migrationBuilder.CreateIndex(
                name: "IX_takeanimal_iduser",
                table: "takeanimal",
                column: "iduser");

            migrationBuilder.CreateIndex(
                name: "IX_takeanimal_shelerid",
                table: "takeanimal",
                column: "shelerid");

            migrationBuilder.CreateIndex(
                name: "IX_takeOvereyingofpets_animalid",
                table: "takeOvereyingofpets",
                column: "animalid");

            migrationBuilder.CreateIndex(
                name: "IX_takeOvereyingofpets_peremoga",
                table: "takeOvereyingofpets",
                column: "peremoga");

            migrationBuilder.CreateIndex(
                name: "IX_takeOvereyingofpets_userid",
                table: "takeOvereyingofpets",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_vaccine_pssoprtid",
                table: "vaccine",
                column: "pssoprtid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comm_overeyeing");

            migrationBuilder.DropTable(
                name: "commvet");

            migrationBuilder.DropTable(
                name: "missinganimal");

            migrationBuilder.DropTable(
                name: "recod");

            migrationBuilder.DropTable(
                name: "takeanimal");

            migrationBuilder.DropTable(
                name: "takeOvereyingofpets");

            migrationBuilder.DropTable(
                name: "vaccine");

            migrationBuilder.DropTable(
                name: "reweis");

            migrationBuilder.DropTable(
                name: "vetclinic");

            migrationBuilder.DropTable(
                name: "animalsinheltetrs");

            migrationBuilder.DropTable(
                name: "Overeyingofpets");

            migrationBuilder.DropTable(
                name: "passport");

            migrationBuilder.DropTable(
                name: "shelter");

            migrationBuilder.DropTable(
                name: "animal");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
