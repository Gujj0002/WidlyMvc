namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'54a4f9de-23be-4929-85e0-32e91c66303a', N'alpeshgujjar18@gmail.com', 0, N'AJ8WSmdAv77AWSt2VLPUE2BdRgjp4WcPuNKFF+6UIlAiGIkbJHKQfz8HnCO1Wa9uyw==', N'894c3830-90b2-472b-87e7-2d8323de360a', NULL, 0, 0, NULL, 1, 0, N'alpeshgujjar18@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd85821f1-a7d0-4869-bc49-bdf533a81695', N'gujj0002@algonquinlive.com', 0, N'AOyliXG3cx7aLsAlJdsToO262FwpvNNdSKiFh+mI97Uw+3oua9R/1KB4iUZs9nXdeA==', N'697f6fed-e737-4188-85ad-e52e5005689e', NULL, 0, 0, NULL, 1, 0, N'gujj0002@algonquinlive.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3e1dcca5-6859-4fd8-ab76-fe2a359837ca', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd85821f1-a7d0-4869-bc49-bdf533a81695', N'3e1dcca5-6859-4fd8-ab76-fe2a359837ca')


                ");
        }
        
        public override void Down()
        {
        }
    }
}
