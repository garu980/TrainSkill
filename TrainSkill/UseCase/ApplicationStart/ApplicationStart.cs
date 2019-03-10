namespace TrainSkill.UseCase.ApplicationStart
{
    internal class ApplicationStart : IApplicationStart
    {
        public string GetResponse()
        {
            return "Welcome to Check my train! You can ask me information about the location of a train by using the train number. " +
                "For example you can ask: Where is train 934?";
        }
    }
}
