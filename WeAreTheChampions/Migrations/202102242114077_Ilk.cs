namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorName = c.String(nullable: false),
                        Red = c.Int(nullable: false),
                        Green = c.Int(nullable: false),
                        Blue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchTime = c.DateTime(nullable: false),
                        Team1Id = c.Int(nullable: false),
                        Team2Id = c.Int(nullable: false),
                        Score1 = c.Int(nullable: false),
                        Score2 = c.Int(nullable: false),
                        Result = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team1Id)
                .ForeignKey("dbo.Teams", t => t.Team2Id)
                .Index(t => t.Team1Id)
                .Index(t => t.Team2Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(nullable: false),
                        PlayerName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.TeamColors",
                c => new
                    {
                        TeamId = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamId, t.ColorId })
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.ColorId);
            
            CreateTable(
                "dbo.TeamColor1",
                c => new
                    {
                        Team_Id = c.Int(nullable: false),
                        Color_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_Id, t.Color_Id })
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .ForeignKey("dbo.Colors", t => t.Color_Id, cascadeDelete: true)
                .Index(t => t.Team_Id)
                .Index(t => t.Color_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamColors", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamColor1", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.TeamColor1", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team2Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team1Id", "dbo.Teams");
            DropIndex("dbo.TeamColor1", new[] { "Color_Id" });
            DropIndex("dbo.TeamColor1", new[] { "Team_Id" });
            DropIndex("dbo.TeamColors", new[] { "ColorId" });
            DropIndex("dbo.TeamColors", new[] { "TeamId" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Matches", new[] { "Team2Id" });
            DropIndex("dbo.Matches", new[] { "Team1Id" });
            DropTable("dbo.TeamColor1");
            DropTable("dbo.TeamColors");
            DropTable("dbo.Players");
            DropTable("dbo.Matches");
            DropTable("dbo.Teams");
            DropTable("dbo.Colors");
        }
    }
}
