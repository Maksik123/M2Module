namespace M2Module.Models
{
    public abstract class FootballTeam
    {
        public abstract string FootballTeamName { get; }

        public abstract FootballPlayer[] TeamLineUp { get; set; }

    }
}
