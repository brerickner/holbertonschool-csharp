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
    public class Tests
    {
        [SetUp]
        /// <summary>
        /// Public method {Setup}.
        /// Set up objects for testing.
        /// </summary>
        public void Setup()
        {
            BaseClass meow = new BaseClass();
            BaseClass meow1 = new BaseClass();
        }

        [Test]
        public void Test_BaseClass_Properties ()
        {
            meow.id = "007";
            meow1.id = 3;
            meow.date_updated = DateTime.Now;

            Assert.Error(meow1.id);
            Assert.IsNotNull(meow.id);
            Assert.IsNotNull(meow.date_created);
            Assert.IsNotNull(meow.date_updated);
            Assert.AreEqual(meow.id, "007");
            Assert.AreNotEqual(meow.date_created, meow.date_updated);
            Assert.TypeOf(meow.date_created, typeof(DateTime));
            Assert.TypeOf(meow.date_updated, typeof(DateTime));
            Assert.TypeOf(meow.id, typeof(String));
        }
    }
}
