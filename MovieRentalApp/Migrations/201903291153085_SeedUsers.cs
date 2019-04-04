namespace MovieRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3a423585-1db9-4d89-a112-2e6e52f5208b', N'guest@rental.com', 0, N'ABHeUYs2KMckw23b8HNxpdisIGVuDyhC8s5U2vQnEAlDKc8iiDsjomroKa+XLGDNBw==', N'e0bb0507-a625-455c-9083-546ca4110437', NULL, 0, 0, NULL, 1, 0, N'guest@rental.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'efb7c4c3-aa0e-49bc-974c-bdb36e646fae', N'admin@rental.com', 0, N'ALH+Ra8uizrDvBH9mTK1Dtjct31UngmBcpQwZkgwkmroep+enpdCwyVSDUKuqaucjA==', N'fbb6b713-ac74-49d1-8494-27ea6d1dfc31', NULL, 0, 0, NULL, 1, 0, N'admin@rental.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c1940f25-ce99-4562-a425-5bc25c3cc7a2', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'efb7c4c3-aa0e-49bc-974c-bdb36e646fae', N'c1940f25-ce99-4562-a425-5bc25c3cc7a2')
");
        }
        
        public override void Down()
        {
        }
    }
}
