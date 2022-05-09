using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMS.API.Migrations
{
    public partial class sdc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_ReviewerId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_TraineeId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_traineeFeedbacks_Users_TraineeId",
                table: "traineeFeedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_traineeFeedbacks_Users_TrainerId",
                table: "traineeFeedbacks");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_ReviewerId",
                table: "Reviews",
                column: "ReviewerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_TraineeId",
                table: "Reviews",
                column: "TraineeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_traineeFeedbacks_Users_TraineeId",
                table: "traineeFeedbacks",
                column: "TraineeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_traineeFeedbacks_Users_TrainerId",
                table: "traineeFeedbacks",
                column: "TrainerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_ReviewerId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_TraineeId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_traineeFeedbacks_Users_TraineeId",
                table: "traineeFeedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_traineeFeedbacks_Users_TrainerId",
                table: "traineeFeedbacks");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_ReviewerId",
                table: "Reviews",
                column: "ReviewerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_TraineeId",
                table: "Reviews",
                column: "TraineeId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_traineeFeedbacks_Users_TraineeId",
                table: "traineeFeedbacks",
                column: "TraineeId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_traineeFeedbacks_Users_TrainerId",
                table: "traineeFeedbacks",
                column: "TrainerId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
