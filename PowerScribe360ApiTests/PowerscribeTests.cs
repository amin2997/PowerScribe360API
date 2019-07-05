using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerScribe360Api;
using PowerScribe360Api.XmlObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerScribe360Api.Tests
{
	[TestClass()]
	public class PowerscribeTests
	{
		private static Powerscribe ps360;


		[ClassInitialize]
		public static void InitializeComponent(TestContext context)
		{
			ps360 = new Powerscribe("http://tps360/RadPortal");
			ps360.SignIn("Valid_PowerScribe360_UserName", "Valid_PowerScribe360_Password");
			
		}
		[ClassCleanup]
		public static void ClassCleanup()
		{
			ps360?.SignOut();
		}

		[TestMethod()]
		[Priority(0)]
		public void SignIn_with_invalid_account()
		{
			Assert.IsFalse(ps360.SignIn("Valid_PowerScribe360_UserName", "Invalid_Password"));
		}

		[TestMethod()]
		[Priority(1)]
		public void SignIn_with_valid_account()
		{			
			Assert.IsTrue(ps360.SignIn("Valid_PowerScribe360_UserName", "Valid_PowerScribe360_Password") && ps360.SetCustomField("32908176", "AI_Report", ""));		
		}
		[DataTestMethod()]
		[DataRow("8656512")]
		[DataRow("8677891")]
		[DataRow("8502455")]
		[DataRow("8954810")]
		[DataRow("8974902")]
		[DataRow("8979657")]
		public void TryGetOrder_order_exists(string accession)
		{
			bool ok = ps360.TryGetOrder(accession, out OrderData order) && order.Accession == accession;
			Assert.IsTrue(ok);
		}
		[DataTestMethod()]
		[DataRow("8656512x")]
		[DataRow("8677891x")]
		[DataRow("8502455x")]
		[DataRow("8954810x")]
		[DataRow("8974902x")]
		[DataRow("8979657x")]
		public void TryGetOrder_order_does_not_exists(string accession)
		{
			Assert.IsFalse(ps360.TryGetOrder(accession, out OrderData order));
		}

		[DataTestMethod()]
		[DataRow("33173265", "AI_Report", "Intriguing")]
		[DataRow("8677891", "AI_Report", "502")]
		[DataRow("8502455", "AI_Report", "503")]
		[DataRow("8954810", "AI_Report", "504")]
		[DataRow("8974902", "AI_Report", "505")]
		[DataRow("8979657", "AI_Report", "506")]
		public void SetCustomField_Valid_Accession(string accession, string fieldName, string fieldValue)
		{
			Assert.IsTrue(ps360.SetCustomField(accession, fieldName, fieldValue));
		}
		public int RandomNumber(int min, int max)
		{
			Random random = new Random();
			return random.Next(min, max);
		}
		[DataTestMethod()]
		[DataRow("8656512x", "CTRAD", "501")]
		[DataRow("8677891x", "CTRAD", "502")]
		[DataRow("8502455x", "CTRAD", "503")]
		[DataRow("8954810x", "CTRAD", "504")]
		[DataRow("8974902x", "CTRAD", "505")]
		[DataRow("8979657x", "CTRAD", "506")]
		public void SetCustomField_Invalid_Accession(string accession, string fieldName, string fieldValue)
		{
			Assert.IsFalse(ps360.SetCustomField(accession, fieldName, fieldValue));
		}

		[DataTestMethod()]
		[DataRow("8656512", "CTRADx", "501")]
		[DataRow("8677891", "CTRADx", "502")]
		[DataRow("8502455", "CTRADx", "503")]
		[DataRow("8954810", "CTRADx", "504")]
		[DataRow("8974902", "CTRADx", "505")]
		[DataRow("8979657", "CTRADx", "506")]
		public void SetCustomField_Invalid_FieldName(string accession, string fieldName, string fieldValue)
		{
			Assert.IsFalse(ps360.SetCustomField(accession, fieldName, fieldValue));
		}


		[DataTestMethod()]
		[DataRow("8656512")]
		public void TryGetReportTest(string accession)
		{
			Assert.IsTrue(ps360.TryGetReport(accession, out Report report));
		}

		[DataTestMethod()]
		[DataRow("8656512")]
		public void TryGetReport_FeildsTest(string accession)
		{

			var ok = ps360.TryGetReport(accession, out Report report);

			Assert.IsNotNull(report.GetCustomFeilds());
		}
	}
}