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
            // BaseClass meow = new BaseClass();
            // BaseClass meow1 = new BaseClass();
   
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

        /// <summary>
        /// Method Test_Item_Properties.
        /// Test Item properties name, description, price, and tags along with correctness of property types.
        /// </summary>
        [Test]
        public void Test_Item_Properties()
        {
            Item meow = new Item("Cat");
            Item meow1 = new Item("Cat_1");
            Item meow2 = new Item("Cat_2", description: "A cat");
            Item meow3 = new Item("Cat_3", price: 9.99f, tags: new List<string>() { "cat", "kitten" });
            Assert.AreNotEqual(meow.name, meow1.name);
            Assert.AreEqual("A cat", meow2.description);
            Assert.AreEqual(0.0f, meow1.price);
            Assert.AreEqual(null, meow1.tags);
            Assert.AreEqual(9.99f, meow3.price);
            Assert.AreEqual(meow.name.GetType(), typeof(string));
            Assert.AreEqual(meow2.description.GetType(), typeof(string));
            Assert.AreEqual(meow3.price.GetType(), typeof(float));
            Assert.AreEqual(meow3.tags.GetType(), typeof(List<string>));
        }

        /// <summary>
        /// Method {Test_User_Properties} tests User property name and correctness of type
        /// </summary>
        [Test]
        public void Test_User_Properties()
        {
            User meow = new User("Cat");
            User meow1 = new User("Cat_1");
            Assert.AreNotEqual(meow.name, meow1.name);
            Assert.AreEqual(meow.name, "Cat");
            Assert.AreEqual(meow1.name, "Cat_1");
            Assert.AreEqual(meow.name.GetType(), typeof(string));
           

        }
    }
}
