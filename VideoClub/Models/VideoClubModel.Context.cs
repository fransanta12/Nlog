﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoClub.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VIDEO_CLUB_DB_Entities : DbContext
    {
        public VIDEO_CLUB_DB_Entities()
            : base("name=VIDEO_CLUB_DB_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Pelicula> Pelicula { get; set; }
    
        public virtual ObjectResult<PeliculasPorAño_Result> PeliculasPorAño(Nullable<int> año)
        {
            var añoParameter = año.HasValue ?
                new ObjectParameter("Año", año) :
                new ObjectParameter("Año", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PeliculasPorAño_Result>("PeliculasPorAño", añoParameter);
        }
    }
}