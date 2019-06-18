namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'495ce4eb-6f15-4389-bd71-0b04bf85837c', N'guest@vidly.com', 0, N'APGhI7r5g8DOIy7PPIVBY2b5HRAowQ4sE3t5RGWM54foPiexx2X2eRjHVhbSn1w0ig==', N'5751284a-b75c-4b7b-b4c0-d59053f7f0c4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'9c74e0f1-78f2-430d-a77d-6b8965569ebb', N'admin@vidly.com', 0, N'AHVq73vNP53MOppstpTPS043xdXcqsbVATDFHJdq/q00hZSCFYvwTEJ4O8MRah8BUg==', N'0537dae0-5184-40eb-a496-3725c99e0ddd', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b80f35ae-f73e-4a61-9640-fda3e5af5051', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c74e0f1-78f2-430d-a77d-6b8965569ebb', N'b80f35ae-f73e-4a61-9640-fda3e5af5051')

");

        }
        
        public override void Down()
        {
        }
    }
}
