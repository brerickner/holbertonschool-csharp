using NUnit.Framework;
using System;
using System.Collections.Generic;
using InventoryLibrary;

/// <summary>
/// Namespace InventoryLibrary.Tests
/// </summary>
namespace InventoryLibrary.Tests
{
    /// <summary>
    /// Public class Tests
    /// </summary>
    [TestFixture]
    public class Tests
    {
        
        /// <summary>
        /// Public method {Setup}.
        /// Set up objects for testing.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            BaseClass meow = new BaseClass();
            BaseClass meow1 = new BaseClass();
   
        }

        /// <summary>
        /// Method Test_BaseClass_Properties.
        /// Tests BaseClass string id, DateTime date_created, and
        /// DateTime date_updated as well as correctness of property types
        /// </summary>
        [Test]
        public void Test_BaseClass_Properties()
        {
            BaseClass meow = new BaseClass();
            BaseClass meow1 = new BaseClass();
            Assert.AreNotEqual(meow.id, meow1.id);
            Assert.AreEqual(meow.date_created, meow1.date_created);
            Assert.AreEqual(meow.date_updated, meow1.date_updated);
            Assert.AreEqual(meow.id.GetType(), typeof(string));
            Assert.AreEqual(meow.date_created.GetType(), typeof(DateTime));
            Assert.AreEqual(meow.date_updated.GetType(), typeof(DateTime));
        }
    }
}
