using DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class BaseFixture
    {
        protected AppDbContext context;
        protected DataRepository repository;

        [SetUp]
        public void Setup()
        {
            context = AppContextFactory.CreateContext();
            repository = new DataRepository(context);
        }

        [TearDown]
        public void TearDown()
        {
            context.Dispose();
            context = null;
            repository = null;
        }
    }
}
