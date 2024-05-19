namespace Lab3Real.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LittleChangeInDoctorModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HospitalDoctors", "Hospital_Id", "dbo.Hospitals");
            DropForeignKey("dbo.HospitalDoctors", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.HospitalDoctors", new[] { "Hospital_Id" });
            DropIndex("dbo.HospitalDoctors", new[] { "Doctor_Id" });
            AddColumn("dbo.Doctors", "Hospital_Id", c => c.Int());
            CreateIndex("dbo.Doctors", "Hospital_Id");
            AddForeignKey("dbo.Doctors", "Hospital_Id", "dbo.Hospitals", "Id");
            DropTable("dbo.HospitalDoctors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.HospitalDoctors",
                c => new
                    {
                        Hospital_Id = c.Int(nullable: false),
                        Doctor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Hospital_Id, t.Doctor_Id });
            
            DropForeignKey("dbo.Doctors", "Hospital_Id", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "Hospital_Id" });
            DropColumn("dbo.Doctors", "Hospital_Id");
            CreateIndex("dbo.HospitalDoctors", "Doctor_Id");
            CreateIndex("dbo.HospitalDoctors", "Hospital_Id");
            AddForeignKey("dbo.HospitalDoctors", "Doctor_Id", "dbo.Doctors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HospitalDoctors", "Hospital_Id", "dbo.Hospitals", "Id", cascadeDelete: true);
        }
    }
}
