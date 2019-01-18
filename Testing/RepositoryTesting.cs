using DAL;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Testing
{
    public class Tests
    {
        private AppDbContext context;
        private DataRepository repository;

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

        [Test]
        public void Test1()
        {
            var meeting = repository.GetMeeting(1);
            Assert.That(meeting, Is.Not.Null);
        }
    }
}