using List;
using NUnit.Framework;
using System.Collections.Generic;

namespace ListTest
{
    public class Tests
    {
        [Test]
        public void SearchElemet_WhenFound_ShouldReturnTrue()
        {
            LinkedList linkedList = new LinkedList();
            int value = linkedList.Search(30);
            Assert.AreEqual(0,value);
        }
    }
}