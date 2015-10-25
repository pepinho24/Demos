namespace ChainOfResponsibility.DeveloperTeams
{
    internal class SeniorDeveloperTeam : DeveloperTeam
    {
        private const ushort MaximumDifficultyToHandle = 5;

        protected override bool CanHandle(SoftwareRequest request)
        {
            return request.Difficulty <= MaximumDifficultyToHandle;
        }

        protected override string DevelopSoftware(SoftwareRequest request)
        {
            return "Software Created by the Senior Developer Team!";
        }
    }
}
