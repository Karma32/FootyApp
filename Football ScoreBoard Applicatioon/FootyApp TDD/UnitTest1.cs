using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Project;

namespace FootyApp_TDD
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_GetName()
        {
            TeamDisplay Team = new TeamDisplay("Chocolate");

            //   Team.GetTeamName();

            Assert.AreEqual("Chocolate", Team.GetTeamName());
        }

        [TestMethod]
        public void Test_GetScore()
        {
            TeamDisplay Team = new TeamDisplay("Chocolate");
            Team.Increment();
            Team.Increment();
            Assert.AreEqual(2, Team.GetScore());
        }


        [TestMethod]
        public void Test_Array()
        {
        int[] dog = new int[4];
        TeamDisplay Team = new TeamDisplay("Chocolate");
            dog[0] = 32;
            Assert.AreEqual(dog[0],32 );

         }
    
        

    }
}
