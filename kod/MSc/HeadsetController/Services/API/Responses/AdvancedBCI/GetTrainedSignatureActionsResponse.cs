using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.AdvancedBCI
{
    public class GetTrainedSignatureActionsResponse : IResult
    {
        public IEnumerable<object> trainedActions { get; }
        public int totalTimesTraining { get; }

        [JsonConstructor]
        private GetTrainedSignatureActionsResponse(IEnumerable<object> trainedActions, int totalTimesTraining)
        {
            this.trainedActions = trainedActions;
            this.totalTimesTraining = totalTimesTraining;
        }
    }

    public class MentalCommandGetSkillRatingResponse : IResult
    {
        //TODO

        [JsonConstructor]
        private MentalCommandGetSkillRatingResponse()
        {

        }
    }

    public class MentalCommandTrainingThresholdResponse : IResult
    {
        public int currentThreshold { get; }
        public int lastTrainingScore { get; }

        [JsonConstructor]
        private MentalCommandTrainingThresholdResponse(int currentThreshold, int lastTrainingScore)
        {
            this.currentThreshold = currentThreshold;
            this.lastTrainingScore = lastTrainingScore;
        }
    }

    public class MentalCommandActionLevelResponse : IResult
    {
        //TODO

        [JsonConstructor]
        private MentalCommandActionLevelResponse()
        {

        }
    }

    public class MentalCommandActionSensitivityResponse : IResult
    {
        //TODO

        [JsonConstructor]
        private MentalCommandActionSensitivityResponse()
        {

        }
    }
}
