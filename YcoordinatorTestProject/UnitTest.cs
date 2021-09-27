using NUnit.Framework;

namespace YcoordinatorTestProject
{
    public class UnitTest : Base.BaseClass
    {
        [Test]
        public void FetechDataFromNews()
        {
            News.RetriveNewsHeadings.NewsHeadings(driver);
            News.RetriveNewsHeadings.Points(driver);
            News.RetriveNewsHeadings.DisplayRecords();
            News.RetriveNewsHeadings.HighestPoints();

        }
    }
}
