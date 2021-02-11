using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Mine.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class HomeMenuItemTests
    {
        [Test]
        public void HomeMenuItem_Constructor_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new HomeMenuItemTests();
            // Reset
            
            // Assert 
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeMenuItem_Get_Set_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new HomeMenuItem();
            MenuItemType Id = new MenuItemType();
            result.Id = Id;
            result.Title = "Title";
            // Reset

            // Assert 
            Assert.AreEqual(Id, result.Id);
            Assert.AreEqual("Title", result.Title);
        }
    }
}
