using System.Collections.Generic;

namespace TrainSkill.Services
{
    public class TrainResponses
    {
        public int TrainCount { get; set; }
        public Dictionary<int, TrainResponse> Trains { get; set; }
    }
}
