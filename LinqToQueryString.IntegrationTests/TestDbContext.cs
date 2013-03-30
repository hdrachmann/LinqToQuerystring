﻿namespace LinqToQueryString.IntegrationTests
{
    using System.Data.Entity;

    using LinqToQueryString.Tests;

    public class TestDbContext : DbContext
    {
        public DbSet<ConcreteClass> ConcreteCollection { get; set; }

        public DbSet<ComplexClass> ComplexCollection { get; set; }
    }
}