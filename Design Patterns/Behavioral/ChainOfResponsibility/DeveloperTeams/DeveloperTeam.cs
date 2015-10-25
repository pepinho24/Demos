namespace ChainOfResponsibility.DeveloperTeams
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>    
    internal abstract class DeveloperTeam
    {
        protected DeveloperTeam Successor { get; set; }

        public void SetSuccessor(DeveloperTeam successor)
        {
            this.Successor = successor;
        }

        public string HandleRequest(SoftwareRequest request)
        {
            if (this.CanHandle(request))
            {
              return this.DevelopSoftware(request);
            }

            if (this.Successor != null)
            {
               return this.Successor.HandleRequest(request);
            }

            return "This software cannot be developed by our team";     
        }

        protected abstract bool CanHandle(SoftwareRequest request);

        protected abstract string DevelopSoftware(SoftwareRequest request);
    }
}
