using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TrainSkill.Domain;

namespace TrainSkill.Services
{
    public class TrainService : ITrainService
    {
        public async Task<ITrain> GetTrain(string trainNumber)
        {
            using (var httpClient = new HttpClient { BaseAddress = new System.Uri("https://junatkartalla-cal-prod.herokuapp.com") })
            {
                var response = await httpClient.GetAsync("/trains/1");
                if(!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var trains = await response.Content.ReadAsAsync<TrainResponses>();

                if(trains.Trains.Any(t => t.Key == int.Parse(trainNumber)))
                {
                    var train = trains.Trains.Single(t => t.Key == int.Parse(trainNumber));
                    return new Train(train.Value.Status, train.Value.Delta);
                }

                return null;
            }
        }
    }
}
