using BackIonic.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BackIonic
{
    public class ContextoDB: DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<ActividadAlumno> ActividadAlumnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                string connectionString = "Data Source=LAPTOP-TU4DNU1R;Initial Catalog=DbIonic;Integrated Security=true";
                connectionString = "Data Source=LAPTOP-MO1HC59V;Initial Catalog=DbIonic;Integrated Security=true";
                connectionString = "workstation id=DbTester.mssql.somee.com;packet size=4096;user id=daniel_123_SQLLogin_1;pwd=lx8u4atmdy;data source=DbTester.mssql.somee.com;persist security info=False;initial catalog=DbTester";
                options.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder pModelBuilder)
        {
            base.OnModelCreating(pModelBuilder);
            //aquí se personalizan las tablas

        }
    }
}
