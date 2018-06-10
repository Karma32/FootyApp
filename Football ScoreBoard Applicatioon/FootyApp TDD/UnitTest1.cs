using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Project;

namespace FootyApp_TDD
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Test_min_score()
        {
            TeamDisplay Team = new TeamDisplay("Taliban");

         //   Team.GetTeamName();

            Assert.AreEqual("Taliban", Team.GetTeamName());
        }
    }
}
