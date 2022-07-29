using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToDoManager;

namespace ToDoManagerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateTest()
        {
            ToDoList obj = new ToDoList("Read two chapters of the book",
                new DateTime(2022, 7, 30), "Free Time");
            Assert.IsNotNull(obj.Create());
        }

        [TestMethod]
        public void TasksListTest()
        {
            ToDoList obj = new ToDoList("Read two chapters of the book",
                new DateTime(2022, 7, 30), "Free Time");
            Assert.AreEqual("Read two chapters of the book", obj.Create()[0]);
            
        }

        [TestMethod]
        public void PostponeTest()
        {
            ToDoList obj = new ToDoList("Read two chapters of the book",
                new DateTime(2022, 7, 30), "Free Time");
            Assert.IsNotNull(obj.Postpone());
        }

        [TestMethod]
        public void PostponedListTest()
        {
            ToDoList obj = new ToDoList("Read two chapters of the book",
                new DateTime(2022, 7, 30), "Free Time");
            Assert.AreEqual("Read two chapters of the book", obj.Postpone()[0]);
        }

        
    }
}
