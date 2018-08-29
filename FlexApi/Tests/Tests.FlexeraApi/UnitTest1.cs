using FlexApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Tests.FlexeraApi
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()	
		{
			var controller = new ValuesController();
			var returnData = controller.Get();

			Assert.AreEqual(1, returnData.Count());
		}
	}
}
