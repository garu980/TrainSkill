using System.Threading.Tasks;

namespace TrainSkill.UseCase.WherIsMyTrain
{
    public interface IWhereIsMyTrain
    {
        Task<string> GetResponse(string trainNumber);
    }
}
