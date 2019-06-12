using System;

namespace MaxScaleProxyProblem
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				var context = new MaxScaleProxyDbContext();
				int intTest = 1337;
				long longTest = 1337;
				DateTime dateTimeTest = DateTime.Now;
				string stringTest = "test";

				var report = new ClickPerformanceReportModel
				{
					AccountDescriptiveName = stringTest,
					AdFormat = stringTest,
					AdGroupId = 123123123,
					AdGroupName = stringTest,
					AdGroupStatus = stringTest,
					AdNetworkType1 = stringTest,
					AdNetworkType2 = stringTest,
					AdVariationControlTrialArmId = longTest,
					AdVariationTreatmentTrialArmId = longTest,
					AdVariationTrialId = longTest,
					AoiCityCriteriaId = stringTest,
					AoiCountryCriteriaId = stringTest,
					AoiMetroCriteriaId = stringTest,
					AoiMostSpecificTargetId = stringTest,
					AoiRegionCriteriaId = stringTest,
					CampaignId = longTest,
					CampaignLocationTargetId = longTest,
					CampaignName = stringTest,
					CampaignStatus = stringTest,
					Clicks = intTest,
					ClickType = stringTest,
					CreativeId = longTest,
					CriteriaId = longTest,
					CriteriaParameters = stringTest,
					Date = dateTimeTest,
					Device = stringTest,
					ExternalCustomerId = longTest,
					GclId = stringTest,
					Id = intTest,
					KeywordMatchType = stringTest,
					LopCityCriteriaId = longTest,
					LopCountryCriteriaId = longTest,
					LopMetroCriteriaId = longTest,
					LopMostSpecificTargetId = longTest,
					LopRegionCriteriaId = longTest,
					MonthOfYear = stringTest,
					Page = intTest,
					Slot = stringTest,
					Timestamp = dateTimeTest,
					UserListId = longTest
				};
				context.ClickPerformanceReports.Add(report);
				context.SaveChanges();
				Console.WriteLine("Test completed without errors");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Test failed with an exception");
				Console.WriteLine(ex.ToString());
			}
        }
    }
}
