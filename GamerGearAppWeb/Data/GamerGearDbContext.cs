﻿using GamerGearAppWeb.models;
using GamerGearAppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace GamerGearAppWeb.Data;

public class GamerGearDbContext : DbContext
{
    public DbSet<Periferico> Periferico { get; set; }
    public DbSet<Marca> Marca { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        string conn = config.GetConnectionString("Conn");
        
        optionsBuilder.UseSqlServer(conn);
    }
}
