using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poi.Moe.Migrations
{
    public partial class Created_Blog_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogArticlePraise",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ArticleId = table.Column<string>(nullable: true),
                    IsPositive = table.Column<bool>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogArticlePraise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogClassification",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogClassification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogTag",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogArticle",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Summary = table.Column<string>(maxLength: 500, nullable: true),
                    PraiseCount = table.Column<int>(nullable: false, defaultValue: 0),
                    CommentCount = table.Column<int>(nullable: false, defaultValue: 0),
                    ReadCount = table.Column<int>(nullable: false, defaultValue: 0),
                    ClassId = table.Column<Guid>(nullable: false),
                    IsEssence = table.Column<bool>(nullable: false, defaultValue: false),
                    IsTop = table.Column<bool>(nullable: false, defaultValue: false),
                    ClassificationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogArticle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogArticle_BlogClassification_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "BlogClassification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogArticleDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ArticleId = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogArticleDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogArticleDetail_BlogArticle_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "BlogArticle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogArticleTag",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ArticleId = table.Column<Guid>(nullable: true),
                    TagId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogArticleTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogArticleTag_BlogArticle_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "BlogArticle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogArticleTag_BlogTag_TagId",
                        column: x => x.TagId,
                        principalTable: "BlogTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogArticle_ClassificationId",
                table: "BlogArticle",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogArticleDetail_ArticleId",
                table: "BlogArticleDetail",
                column: "ArticleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogArticleTag_ArticleId",
                table: "BlogArticleTag",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogArticleTag_TagId",
                table: "BlogArticleTag",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogArticleDetail");

            migrationBuilder.DropTable(
                name: "BlogArticlePraise");

            migrationBuilder.DropTable(
                name: "BlogArticleTag");

            migrationBuilder.DropTable(
                name: "BlogArticle");

            migrationBuilder.DropTable(
                name: "BlogTag");

            migrationBuilder.DropTable(
                name: "BlogClassification");
        }
    }
}
