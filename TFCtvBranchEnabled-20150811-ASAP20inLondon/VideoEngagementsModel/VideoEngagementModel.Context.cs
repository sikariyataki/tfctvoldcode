﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace VideoEngagementsModel
{
    public partial class VideoEngagementsEntities : DbContext
    {
        public VideoEngagementsEntities()
            : base("name=VideoEngagementsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ChannelPlay> ChannelPlays { get; set; }
        public DbSet<EpisodePlay> EpisodePlays { get; set; }
        public DbSet<YouTubePlay> YouTubePlays { get; set; }
    }
}
