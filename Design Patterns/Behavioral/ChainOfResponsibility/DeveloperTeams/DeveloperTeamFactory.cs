namespace ChainOfResponsibility.DeveloperTeams
{
    internal class DeveloperTeamFactory : IDeveloperTeamFactory
    {
        public DeveloperTeam CreateAndAttachDeveloperTeams()
        {
            var juniorDeveloperTeam = new JuniorDeveloperTeam();
            var regularDeveloperTeam = new RegularDeveloperTeam();
            var seniorDeveloperTeam = new SeniorDeveloperTeam();

            juniorDeveloperTeam.SetSuccessor(regularDeveloperTeam);
            regularDeveloperTeam.SetSuccessor(seniorDeveloperTeam);

            return juniorDeveloperTeam;
        } 
    }
}
