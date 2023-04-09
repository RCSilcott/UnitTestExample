using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.Test
{
	[TestFixture]
	public class ProgramServiceTests
	{
        private ProgramService _programService;

        [SetUp]
		public void SetUp()
		{
			_programService = new ProgramService();
		}

        [TestCase]
        public void SquaredReturnsCorrectResult()
        {
            // Arrange
            int num = 5;

            // Act

            int testResult = _programService.Square(num);

            //Assert
            Assert.AreEqual(num * num, testResult);
        }
    }
}
