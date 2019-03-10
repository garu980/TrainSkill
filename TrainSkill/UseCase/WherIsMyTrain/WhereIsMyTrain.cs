using System.Threading.Tasks;
using TrainSkill.Services;

namespace TrainSkill.UseCase.WherIsMyTrain
{
    internal class WhereIsMyTrain : IWhereIsMyTrain
    {
        ITrainService trainService;

        public WhereIsMyTrain(ITrainService trainService)
        {
            this.trainService = trainService;
        }

        public async Task<string> GetResponse(string trainNumber)
        {
            var train = await trainService.GetTrain(trainNumber);
            if(train == null)
            {
                return $"Sorry train {trainNumber} was not found";
            }

            if(train.IsDelayed)
            {
                return $"Train {trainNumber} is {train.DelayInMinutes} minutes delayed";
            }

            return $"Train {trainNumber} is on time";
        }
    }
}
