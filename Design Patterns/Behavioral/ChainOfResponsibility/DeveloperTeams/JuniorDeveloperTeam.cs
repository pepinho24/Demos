namespace ChainOfResponsibility.DeveloperTeams
{
    internal class JuniorDeveloperTeam : DeveloperTeam
    {
        private const ushort MaximumDifficultyToHandle = 1;

        protected override bool CanHandle(SoftwareRequest request)
        {
            return request.Difficulty <= MaximumDifficultyToHandle;
        }

        protected override string DevelopSoftware(SoftwareRequest request)
        {
            return "Software Created by the Junior Developer Team!";
        }
    }
}
