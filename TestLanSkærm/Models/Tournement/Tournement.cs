namespace TestLanSkærm.Models.Tournement
{

    public class TournamentData
    {
        public Data Data { get; set; }
    }

    public class Data
    {
        public Tournement Tournament { get; set; }
    }

    public class Tournement
    {
        public string Description { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
    }
}
