namespace ChainOfResponsibility
{
    using System;

    /// <summary>
    /// Class holding request details.
    /// </summary>
    internal class SoftwareRequest
    {
        private const string DifficultyExceptionStringFormatMessage = "Difficulty must be a number between {0} and {1}!";
        private const ushort MinimumDifficultyConstant = 1;
        private const ushort MaximumDifficultyConstant = 6;
        private ushort difficulty;

        public SoftwareRequest(ushort difficulty, string content)
        {
            this.Difficulty = difficulty;
            this.Content = content;
        }

        public ushort Difficulty
        {
            get
            {
                return this.difficulty;
            }

            set
            {
                if (value < MinimumDifficultyConstant || value > MaximumDifficultyConstant)
                {
                    throw new ArgumentException(string.Format(DifficultyExceptionStringFormatMessage, MinimumDifficultyConstant, MaximumDifficultyConstant));
                }

                this.difficulty = value;
            }
        }

        public string Content { get; set; }
    }
}
