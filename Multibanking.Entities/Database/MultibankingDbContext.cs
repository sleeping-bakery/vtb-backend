﻿using Microsoft.EntityFrameworkCore;
using Multibanking.Entities.Users;

namespace Multibanking.Entities.Database;

public class MultibankingDbContext(DbContextOptions<MultibankingDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}