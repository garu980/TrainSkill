using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TrainSkill.Services;

namespace TrainSkillTests
{
    [TestClass]
    public class TrainServiceTests
    {
        [TestMethod]
        public async Task ShouldReturnCorrectTrain()
        {
            var trainService = new TrainService();
            var train = await trainService.GetTrain("273");
        }
    }
}
