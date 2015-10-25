namespace ChainOfResponsibility.DeveloperTeams
{
    internal interface IDeveloperTeamFactory
    {
        DeveloperTeam CreateAndAttachDeveloperTeams();
    }
}