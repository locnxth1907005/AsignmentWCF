using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyDBContext
/// </summary>
public class MyDBContext : DbContext
{
    public MyDBContext() : base("MyConnectionString")
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DbSet<Student> Students { get; set; }
}