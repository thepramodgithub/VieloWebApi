namespace Vielo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'47223a5a-d06a-4303-8361-a02e68c3788c', N'guest@vielo.com', 0, N'AEIhxgKtg2taPzuMqw0V1wM5hf/HXcuKF4lcpnrbVYh/dzS3rQ0j+cnF7k9YHp0jGw==', N'64b56651-7177-4be4-9878-8c1d11d2bcb8', NULL, 0, 0, NULL, 1, 0, N'guest@vielo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c8a5ab58-0ded-4506-95e4-5e8b109e4498', N'admin@vielo.com', 0, N'AJTDpG9bb6liBU3NFuBL8fEeOmj7w9Y6Lzf/kiaVHFX88N94LCGBsJw+9cDz3dILMg==', N'7ec70d14-4467-4816-b538-50d2ac206cf5', NULL, 0, 0, NULL, 1, 0, N'admin@vielo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'db5aa0d1-1f10-4300-a1b4-6d04a1b7c41d', N'admin1@vielo.com', 0, N'AE+Ts/tb0eTUByJLfQmnvznuLffFdQqWJ6WJvqlYPXkJG03FLbMMEZm3L8obT2UM7Q==', N'8c729af9-9380-4c29-9328-427e9b9b77e8', NULL, 0, 0, NULL, 1, 0, N'admin1@vielo.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1a19ae7c-c180-4f94-8d8b-cf5abe516003', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'db5aa0d1-1f10-4300-a1b4-6d04a1b7c41d', N'1a19ae7c-c180-4f94-8d8b-cf5abe516003')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
