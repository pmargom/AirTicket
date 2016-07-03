namespace AirticketApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8986573e-afd0-432a-80cf-7c2b2de93874', N'guest@airtiket.com', 0, N'AFqx++rL2APAT6illu0kX5k8G0EYK9eE9FdId4LJQz2HmNRkI+ZIqu0uven13f/nEQ==', N'd321af5d-378b-4285-9670-4511265d1ed0', NULL, 0, 0, NULL, 1, 0, N'guest@airtiket.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8dad064c-bd5d-41f5-b950-e1c860469739', N'admin@airticket.com', 0, N'AMOrdwu2UOMXUJpvx8IaPqIeuj63xFfgdNQXA59dC2/ixxRm6zrnD0jm1ekjHSFT1w==', N'93b65005-47a0-47f4-be1a-16c4e2797184', NULL, 0, 0, NULL, 1, 0, N'admin@airticket.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fdd61e3b-58a8-4084-9230-17d03c129279', N'CanManageAirports')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8dad064c-bd5d-41f5-b950-e1c860469739', N'fdd61e3b-58a8-4084-9230-17d03c129279')

");
        }
        
        public override void Down()
        {
        }
    }
}
