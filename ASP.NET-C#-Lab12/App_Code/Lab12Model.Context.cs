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

public partial class Lab12Entities : DbContext
{
    public Lab12Entities()
        : base("name=Lab12Entities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<Calendar> Calendars { get; set; }
    public DbSet<ClassMeeting> ClassMeetings { get; set; }
    public DbSet<Registration> Registrations { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Student> Students { get; set; }
}
