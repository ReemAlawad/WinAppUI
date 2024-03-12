using ClassLibraryCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectDemo
{
    [TestFixture]
    internal class ListProcessorTests
    {
       private ListProcessor _listProcessor;
        private List<String> _list;
       // private  string[3];
            string[] _arr ;
        [SetUp]
        public void SetUp()
        {
            _listProcessor = new ListProcessor();
            _list = new List<string> {"a","b","c","a" };
            _arr = new[] { "appel", "banaan", "citroen", "aardbei" };
        }
        [Test]
        public void SortList_ShouldReturnSortedList()
        {
            //Arange
           
            var result = _listProcessor.SortList(_list);
            _list = new List<string> { "a", "a","b","c"};
            Assert.That(result, Is.EqualTo(_list));

        }

        [TestCase("b", new[] { "aardbei", "appel", "banaan", "citroen" })]
       
        public void FindStringWithSubstring_Test( string substring, string[] expected)
        {
            var result = _listProcessor.FindStringWithSubstring(_arr.ToList(),substring);
           // _list = new List<string> { "appel"};
            Assert.That(result, Is.EqualTo(substring));
        }

    }
}
