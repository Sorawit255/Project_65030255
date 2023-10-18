using Project_65030255;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Enum.GetNames(typeof(Project.Members)).Length == 4);
        }
        [TestMethod]
        public void TestProjectMemberIds()
        {
            Assert.IsTrue((int)Project.Members.Tiew == 1);
            Assert.IsTrue((int)Project.Members.Ping == 2);
            Assert.IsTrue((int)Project.Members.Arm == 3);
            Assert.IsTrue((int)Project.Members.Fulk == 4);
        }
    }

    
}