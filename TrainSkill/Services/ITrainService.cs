using System.Threading.Tasks;
using TrainSkill.Domain;

namespace TrainSkill.Services
{
    public interface ITrainService
    {
        Task<ITrain> GetTrain(string trainNumber);
    }
}
