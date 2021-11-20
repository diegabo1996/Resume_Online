using LCode.NETCore.Base._5._0.BaseDatos;
using LCode.Resume.Online.Models.v1_0;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCode.Resume.Online.DataBase.Contextos.v1_0
{
    public class Contexto : ConexionContextoBD
    {
        string NombreConexionContexto = "LCode.Resume.Online";
        public Contexto()
        {
            Iniciar(NombreConexionContexto);
        }
        public DbSet<General_Information> General_Information { get; set; }
        public DbSet<Culture_Resume> Culture_Resume { get; set; }
        public DbSet<WhatIDo> WhatIDo { get; set; }
        public DbSet<Social_Networks> Social_Networks { get; set; }
        public DbSet<Resume_Section> Resume_Section { get; set; }
        public DbSet<Resume_Extra_Skills> Resume_Extra_Skills { get; set; }
        public DbSet<Resume_Knowledge_General> Resume_Knowledge_General { get; set; }
        public DbSet<Category_Portfolio> Category_Portfolio { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Personal_Titles> Personal_Titles { get; set; }
        public DbSet<About_Info> About_Info { get; set; }
        public DbSet<Contact> Contact_Registry { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("resume");
            modelBuilder.Entity<General_Information>().Property(m => m.Guid_Resume).HasDefaultValueSql("NEWID()"); 
            modelBuilder.Entity<General_Information>().Property(m => m.DateTimeCreated).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<General_Information>().Property(m => m.DateTimeModified).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<General_Information>().Property(m => m.Photo).IsRequired(false);
            modelBuilder.Entity<WhatIDo>().Property(m => m.Guid_WhatIDo).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<WhatIDo>().Property(m => m.DateTimeCreated).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<WhatIDo>().Property(m => m.DateTimeModified).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Social_Networks>().Property(m => m.Guid_SocialNetwork).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Social_Networks>().Property(m => m.DateTimeCreated).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Social_Networks>().Property(m => m.DateTimeModified).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Resume_Extra_Skills>().Property(m => m.Guid_Resume_Extra_Skill).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Resume_Extra_Skills>().Property(m => m.DateTimeCreated).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Resume_Extra_Skills>().Property(m => m.DateTimeModified).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Resume_Knowledge_General>().Property(m => m.Guid_Resume_Knowledge_General).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Resume_Knowledge_General>().Property(m => m.DateTimeCreated).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Resume_Knowledge_General>().Property(m => m.DateTimeModified).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Portfolio>().Property(m => m.Guid_Portfolio).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Portfolio>().Property(m => m.DateTimeCreated).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Portfolio>().Property(m => m.DateTimeModified).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Category_Portfolio>().Property(m => m.Guid_Category_Portolio).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Resume_Section>().Property(m => m.Guid_Resume_Section).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Resume_Section>().Property(m => m.DateTimeCreated).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Resume_Section>().Property(m => m.DateTimeModified).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<About_Info>().Property(m => m.Guid_About_Info).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<About_Info>().Property(m => m.DateTimeCreated).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<About_Info>().Property(m => m.DateTimeModified).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Culture_Resume>().Property(m => m.Guid_Culture_Resume).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Culture_Resume>().Property(m => m.DateTimeCreated).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Personal_Titles>().Property(m => m.Guid_Personal_Title).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Personal_Titles>().Property(m => m.DateTimeCreated).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Personal_Titles>().Property(m => m.DateTimeModified).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Contact>().Property(m => m.DateTimeRegistred).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Contact>().Property(m => m.Notified).HasDefaultValueSql("0");
        }
    }
}
