using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Newtonsoft.Json;
using TrainSkill.Services;
using TrainSkill.UseCase.ApplicationStart;
using TrainSkill.UseCase.WherIsMyTrain;

namespace TrainSkill.Functions
{
    public class TrainFunction : ITrainFunction
    {
        IApplicationStart applicationStart;
        IWhereIsMyTrain whereIsMyTrain;

        public TrainFunction(IApplicationStart applicationStart, IWhereIsMyTrain whereIsMyTrain)
        {
            this.applicationStart = applicationStart;
            this.whereIsMyTrain = whereIsMyTrain;
        }

        public async Task<SkillResponse> InvokeAsync(HttpRequest req)
        {
            string json = await req.ReadAsStringAsync();
            var skillRequest = JsonConvert.DeserializeObject<SkillRequest>(json);

            var requestType = skillRequest.GetRequestType();

            SkillResponse response = null;

            if (requestType == typeof(LaunchRequest))
            {
                response = ResponseBuilder.Tell(applicationStart.GetResponse());
                response.Response.ShouldEndSession = false;
            }
            else if (requestType == typeof(IntentRequest))
            {
                var intentRequest = skillRequest.Request as IntentRequest;
                if (intentRequest.Intent.Name == "WhatTrain")
                {
                    var trainNumber = intentRequest.Intent.Slots.First().Value;
                    var trainResponse = await whereIsMyTrain.GetResponse(trainNumber.Value);
                    response = ResponseBuilder.Tell(trainResponse);
                    response.Response.ShouldEndSession = true;
                }
            }
            
            return response;
        }
    }
}
