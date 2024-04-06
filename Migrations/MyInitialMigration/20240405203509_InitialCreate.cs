using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment4.Migrations.MyInitialMigration
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "AccountId", "AccountType", "CurrentBalance", "DateCreated", "UserId" },
                values: new object[,]
                {
                    { 1, "Checking", 1000.0, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3484), 1 },
                    { 2, "Savings", 2000.0, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3520), 2 },
                    { 3, "Checking", 3000.0, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3541), 3 },
                    { 4, "Savings", 4000.0, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3583), 4 },
                    { 5, "Checking", 5000.0, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3604), 5 },
                    { 6, "Savings", 6000.0, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3624), 6 },
                    { 7, "Checking", 7000.0, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3644), 7 },
                    { 8, "Savings", 8000.0, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3687), 8 },
                    { 9, "Checking", 9000.0, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3707), 9 },
                    { 10, "Savings", 10000.0, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3739), 10 }
                });

            migrationBuilder.InsertData(
                table: "TransactionHistory",
                columns: new[] { "TransactionId", "AccountId", "Amount", "Description", "TransactionDate" },
                values: new object[,]
                {
                    { 11, 1, 100m, "Transaction 1 for Account 1", new DateTime(2024, 4, 4, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3490) },
                    { 12, 1, 200m, "Transaction 2 for Account 1", new DateTime(2024, 4, 3, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3501) },
                    { 13, 1, 300m, "Transaction 3 for Account 1", new DateTime(2024, 4, 2, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3503) },
                    { 14, 1, 400m, "Transaction 4 for Account 1", new DateTime(2024, 4, 1, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3505) },
                    { 15, 1, 500m, "Transaction 5 for Account 1", new DateTime(2024, 3, 31, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3507) },
                    { 16, 1, 600m, "Transaction 6 for Account 1", new DateTime(2024, 3, 30, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3510) },
                    { 17, 1, 700m, "Transaction 7 for Account 1", new DateTime(2024, 3, 29, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3512) },
                    { 18, 1, 800m, "Transaction 8 for Account 1", new DateTime(2024, 3, 28, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3514) },
                    { 19, 1, 900m, "Transaction 9 for Account 1", new DateTime(2024, 3, 27, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3515) },
                    { 20, 1, 1000m, "Transaction 10 for Account 1", new DateTime(2024, 3, 26, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3518) },
                    { 21, 2, 100m, "Transaction 1 for Account 2", new DateTime(2024, 4, 4, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3522) },
                    { 22, 2, 200m, "Transaction 2 for Account 2", new DateTime(2024, 4, 3, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3524) },
                    { 23, 2, 300m, "Transaction 3 for Account 2", new DateTime(2024, 4, 2, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3526) },
                    { 24, 2, 400m, "Transaction 4 for Account 2", new DateTime(2024, 4, 1, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3527) },
                    { 25, 2, 500m, "Transaction 5 for Account 2", new DateTime(2024, 3, 31, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3530) },
                    { 26, 2, 600m, "Transaction 6 for Account 2", new DateTime(2024, 3, 30, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3531) },
                    { 27, 2, 700m, "Transaction 7 for Account 2", new DateTime(2024, 3, 29, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3533) },
                    { 28, 2, 800m, "Transaction 8 for Account 2", new DateTime(2024, 3, 28, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3536) },
                    { 29, 2, 900m, "Transaction 9 for Account 2", new DateTime(2024, 3, 27, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3538) },
                    { 30, 2, 1000m, "Transaction 10 for Account 2", new DateTime(2024, 3, 26, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3539) },
                    { 31, 3, 100m, "Transaction 1 for Account 3", new DateTime(2024, 4, 4, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3542) },
                    { 32, 3, 200m, "Transaction 2 for Account 3", new DateTime(2024, 4, 3, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3544) },
                    { 33, 3, 300m, "Transaction 3 for Account 3", new DateTime(2024, 4, 2, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3546) },
                    { 34, 3, 400m, "Transaction 4 for Account 3", new DateTime(2024, 4, 1, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3548) },
                    { 35, 3, 500m, "Transaction 5 for Account 3", new DateTime(2024, 3, 31, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3550) },
                    { 36, 3, 600m, "Transaction 6 for Account 3", new DateTime(2024, 3, 30, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3552) },
                    { 37, 3, 700m, "Transaction 7 for Account 3", new DateTime(2024, 3, 29, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3554) },
                    { 38, 3, 800m, "Transaction 8 for Account 3", new DateTime(2024, 3, 28, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3556) },
                    { 39, 3, 900m, "Transaction 9 for Account 3", new DateTime(2024, 3, 27, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3579) },
                    { 40, 3, 1000m, "Transaction 10 for Account 3", new DateTime(2024, 3, 26, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3581) },
                    { 41, 4, 100m, "Transaction 1 for Account 4", new DateTime(2024, 4, 4, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3584) },
                    { 42, 4, 200m, "Transaction 2 for Account 4", new DateTime(2024, 4, 3, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3586) },
                    { 43, 4, 300m, "Transaction 3 for Account 4", new DateTime(2024, 4, 2, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3588) },
                    { 44, 4, 400m, "Transaction 4 for Account 4", new DateTime(2024, 4, 1, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3591) },
                    { 45, 4, 500m, "Transaction 5 for Account 4", new DateTime(2024, 3, 31, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3592) },
                    { 46, 4, 600m, "Transaction 6 for Account 4", new DateTime(2024, 3, 30, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3594) },
                    { 47, 4, 700m, "Transaction 7 for Account 4", new DateTime(2024, 3, 29, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3596) },
                    { 48, 4, 800m, "Transaction 8 for Account 4", new DateTime(2024, 3, 28, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3598) },
                    { 49, 4, 900m, "Transaction 9 for Account 4", new DateTime(2024, 3, 27, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3600) },
                    { 50, 4, 1000m, "Transaction 10 for Account 4", new DateTime(2024, 3, 26, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3601) },
                    { 51, 5, 100m, "Transaction 1 for Account 5", new DateTime(2024, 4, 4, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3605) },
                    { 52, 5, 200m, "Transaction 2 for Account 5", new DateTime(2024, 4, 3, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3607) },
                    { 53, 5, 300m, "Transaction 3 for Account 5", new DateTime(2024, 4, 2, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3609) },
                    { 54, 5, 400m, "Transaction 4 for Account 5", new DateTime(2024, 4, 1, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3611) },
                    { 55, 5, 500m, "Transaction 5 for Account 5", new DateTime(2024, 3, 31, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3613) },
                    { 56, 5, 600m, "Transaction 6 for Account 5", new DateTime(2024, 3, 30, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3615) },
                    { 57, 5, 700m, "Transaction 7 for Account 5", new DateTime(2024, 3, 29, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3616) },
                    { 58, 5, 800m, "Transaction 8 for Account 5", new DateTime(2024, 3, 28, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3618) },
                    { 59, 5, 900m, "Transaction 9 for Account 5", new DateTime(2024, 3, 27, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3620) },
                    { 60, 5, 1000m, "Transaction 10 for Account 5", new DateTime(2024, 3, 26, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3622) },
                    { 61, 6, 100m, "Transaction 1 for Account 6", new DateTime(2024, 4, 4, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3625) },
                    { 62, 6, 200m, "Transaction 2 for Account 6", new DateTime(2024, 4, 3, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3627) },
                    { 63, 6, 300m, "Transaction 3 for Account 6", new DateTime(2024, 4, 2, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3629) },
                    { 64, 6, 400m, "Transaction 4 for Account 6", new DateTime(2024, 4, 1, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3631) },
                    { 65, 6, 500m, "Transaction 5 for Account 6", new DateTime(2024, 3, 31, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3632) },
                    { 66, 6, 600m, "Transaction 6 for Account 6", new DateTime(2024, 3, 30, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3634) },
                    { 67, 6, 700m, "Transaction 7 for Account 6", new DateTime(2024, 3, 29, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3636) },
                    { 68, 6, 800m, "Transaction 8 for Account 6", new DateTime(2024, 3, 28, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3638) },
                    { 69, 6, 900m, "Transaction 9 for Account 6", new DateTime(2024, 3, 27, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3640) },
                    { 70, 6, 1000m, "Transaction 10 for Account 6", new DateTime(2024, 3, 26, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3642) },
                    { 71, 7, 100m, "Transaction 1 for Account 7", new DateTime(2024, 4, 4, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3645) },
                    { 72, 7, 200m, "Transaction 2 for Account 7", new DateTime(2024, 4, 3, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3647) },
                    { 73, 7, 300m, "Transaction 3 for Account 7", new DateTime(2024, 4, 2, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3648) },
                    { 74, 7, 400m, "Transaction 4 for Account 7", new DateTime(2024, 4, 1, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3650) },
                    { 75, 7, 500m, "Transaction 5 for Account 7", new DateTime(2024, 3, 31, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3652) },
                    { 76, 7, 600m, "Transaction 6 for Account 7", new DateTime(2024, 3, 30, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3654) },
                    { 77, 7, 700m, "Transaction 7 for Account 7", new DateTime(2024, 3, 29, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3656) },
                    { 78, 7, 800m, "Transaction 8 for Account 7", new DateTime(2024, 3, 28, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3658) },
                    { 79, 7, 900m, "Transaction 9 for Account 7", new DateTime(2024, 3, 27, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3660) },
                    { 80, 7, 1000m, "Transaction 10 for Account 7", new DateTime(2024, 3, 26, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3685) },
                    { 81, 8, 100m, "Transaction 1 for Account 8", new DateTime(2024, 4, 4, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3688) },
                    { 82, 8, 200m, "Transaction 2 for Account 8", new DateTime(2024, 4, 3, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3690) },
                    { 83, 8, 300m, "Transaction 3 for Account 8", new DateTime(2024, 4, 2, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3692) },
                    { 84, 8, 400m, "Transaction 4 for Account 8", new DateTime(2024, 4, 1, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3694) },
                    { 85, 8, 500m, "Transaction 5 for Account 8", new DateTime(2024, 3, 31, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3696) },
                    { 86, 8, 600m, "Transaction 6 for Account 8", new DateTime(2024, 3, 30, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3698) },
                    { 87, 8, 700m, "Transaction 7 for Account 8", new DateTime(2024, 3, 29, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3699) },
                    { 88, 8, 800m, "Transaction 8 for Account 8", new DateTime(2024, 3, 28, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3701) },
                    { 89, 8, 900m, "Transaction 9 for Account 8", new DateTime(2024, 3, 27, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3703) },
                    { 90, 8, 1000m, "Transaction 10 for Account 8", new DateTime(2024, 3, 26, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3705) },
                    { 91, 9, 100m, "Transaction 1 for Account 9", new DateTime(2024, 4, 4, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3709) },
                    { 92, 9, 200m, "Transaction 2 for Account 9", new DateTime(2024, 4, 3, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3711) },
                    { 93, 9, 300m, "Transaction 3 for Account 9", new DateTime(2024, 4, 2, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3712) },
                    { 94, 9, 400m, "Transaction 4 for Account 9", new DateTime(2024, 4, 1, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3714) },
                    { 95, 9, 500m, "Transaction 5 for Account 9", new DateTime(2024, 3, 31, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3717) },
                    { 96, 9, 600m, "Transaction 6 for Account 9", new DateTime(2024, 3, 30, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3719) },
                    { 97, 9, 700m, "Transaction 7 for Account 9", new DateTime(2024, 3, 29, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3731) },
                    { 98, 9, 800m, "Transaction 8 for Account 9", new DateTime(2024, 3, 28, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3733) },
                    { 99, 9, 900m, "Transaction 9 for Account 9", new DateTime(2024, 3, 27, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3735) },
                    { 100, 9, 1000m, "Transaction 10 for Account 9", new DateTime(2024, 3, 26, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3737) },
                    { 101, 10, 100m, "Transaction 1 for Account 10", new DateTime(2024, 4, 4, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3740) },
                    { 102, 10, 200m, "Transaction 2 for Account 10", new DateTime(2024, 4, 3, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3742) },
                    { 103, 10, 300m, "Transaction 3 for Account 10", new DateTime(2024, 4, 2, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3744) },
                    { 104, 10, 400m, "Transaction 4 for Account 10", new DateTime(2024, 4, 1, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3746) },
                    { 105, 10, 500m, "Transaction 5 for Account 10", new DateTime(2024, 3, 31, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3748) },
                    { 106, 10, 600m, "Transaction 6 for Account 10", new DateTime(2024, 3, 30, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3750) },
                    { 107, 10, 700m, "Transaction 7 for Account 10", new DateTime(2024, 3, 29, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3752) },
                    { 108, 10, 800m, "Transaction 8 for Account 10", new DateTime(2024, 3, 28, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3753) },
                    { 109, 10, 900m, "Transaction 9 for Account 10", new DateTime(2024, 3, 27, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3755) },
                    { 110, 10, 1000m, "Transaction 10 for Account 10", new DateTime(2024, 3, 26, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3757) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DateCreated", "Email", "Firstname", "Lastname", "Password" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3318), "user1@example.com", "Firstname1", "Lastname1", "hashed-password-1" },
                    { 2, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3385), "user2@example.com", "Firstname2", "Lastname2", "hashed-password-2" },
                    { 3, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3388), "user3@example.com", "Firstname3", "Lastname3", "hashed-password-3" },
                    { 4, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3391), "user4@example.com", "Firstname4", "Lastname4", "hashed-password-4" },
                    { 5, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3394), "user5@example.com", "Firstname5", "Lastname5", "hashed-password-5" },
                    { 6, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3399), "user6@example.com", "Firstname6", "Lastname6", "hashed-password-6" },
                    { 7, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3402), "user7@example.com", "Firstname7", "Lastname7", "hashed-password-7" },
                    { 8, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3405), "user8@example.com", "Firstname8", "Lastname8", "hashed-password-8" },
                    { 9, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3408), "user9@example.com", "Firstname9", "Lastname9", "hashed-password-9" },
                    { 10, new DateTime(2024, 4, 5, 16, 35, 9, 267, DateTimeKind.Local).AddTicks(3413), "user10@example.com", "Firstname10", "Lastname10", "hashed-password-10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "TransactionHistory");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
