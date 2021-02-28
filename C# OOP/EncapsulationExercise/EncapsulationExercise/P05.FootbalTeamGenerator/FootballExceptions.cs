namespace P05.FootballTeamGenerator
{
    public static class FootballExceptions
    {
        public static string NameException => "A name should not be empty.";

        public static string StatException => "{0} should be between 0 and 100.";

        public static string InvalidRemovePlayerException => "Player {0} is not in {1} team.";

        public static string InvalidTeam => "Team {0} does not exist.";
    }
}
