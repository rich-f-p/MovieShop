using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_Collections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CastMovieCast",
                columns: table => new
                {
                    CastsId = table.Column<int>(type: "int", nullable: false),
                    MovieCastsCastId = table.Column<int>(type: "int", nullable: false),
                    MovieCastsCharacter = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MovieCastsMovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastMovieCast", x => new { x.CastsId, x.MovieCastsCastId, x.MovieCastsCharacter, x.MovieCastsMovieId });
                    table.ForeignKey(
                        name: "FK_CastMovieCast_Casts_CastsId",
                        column: x => x.CastsId,
                        principalTable: "Casts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastMovieCast_MovieCasts_MovieCastsCastId_MovieCastsCharacter_MovieCastsMovieId",
                        columns: x => new { x.MovieCastsCastId, x.MovieCastsCharacter, x.MovieCastsMovieId },
                        principalTable: "MovieCasts",
                        principalColumns: new[] { "CastId", "Character", "MovieId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieMovieCast",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false),
                    movieCastsCastId = table.Column<int>(type: "int", nullable: false),
                    movieCastsCharacter = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    movieCastsMovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieMovieCast", x => new { x.MoviesId, x.movieCastsCastId, x.movieCastsCharacter, x.movieCastsMovieId });
                    table.ForeignKey(
                        name: "FK_MovieMovieCast_MovieCasts_movieCastsCastId_movieCastsCharacter_movieCastsMovieId",
                        columns: x => new { x.movieCastsCastId, x.movieCastsCharacter, x.movieCastsMovieId },
                        principalTable: "MovieCasts",
                        principalColumns: new[] { "CastId", "Character", "MovieId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieMovieCast_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailers_MovieId",
                table: "Trailers",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_UserId",
                table: "Purchases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieId",
                table: "MovieGenres",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CastMovieCast_MovieCastsCastId_MovieCastsCharacter_MovieCastsMovieId",
                table: "CastMovieCast",
                columns: new[] { "MovieCastsCastId", "MovieCastsCharacter", "MovieCastsMovieId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieMovieCast_movieCastsCastId_movieCastsCharacter_movieCastsMovieId",
                table: "MovieMovieCast",
                columns: new[] { "movieCastsCastId", "movieCastsCharacter", "movieCastsMovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Movies_MovieId",
                table: "Favorites",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Users_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Movies_MovieId",
                table: "Purchases",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Users_UserId",
                table: "Purchases",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Reviews",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trailers_Movies_MovieId",
                table: "Trailers",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Movies_MovieId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Users_UserId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Movies_MovieId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Users_UserId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Trailers_Movies_MovieId",
                table: "Trailers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropTable(
                name: "CastMovieCast");

            migrationBuilder.DropTable(
                name: "MovieMovieCast");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Trailers_MovieId",
                table: "Trailers");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_UserId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_MovieId",
                table: "MovieGenres");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
