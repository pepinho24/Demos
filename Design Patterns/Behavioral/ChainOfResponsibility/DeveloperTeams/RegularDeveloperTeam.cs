namespace ChainOfResponsibility.DeveloperTeams
{
    internal class RegularDeveloperTeam : DeveloperTeam
    {
        private const ushort MaximumDifficultyToHandle = 4;

        protected override bool CanHandle(SoftwareRequest request)
        {
            return request.Difficulty <= MaximumDifficultyToHandle;
        }

        protected override string DevelopSoftware(SoftwareRequest request)
        {
            return "Software Created by the Regular Developer Team!";
        }
    }
}
