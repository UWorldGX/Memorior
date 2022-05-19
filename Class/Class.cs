namespace MasaWebApp1.Class
{

    public class DataSources
    {
        public string Name { get; set; }
        public Birthday ?Birthday { get; set; }
    }

    public class Birthday
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Date { get; set; }
    }

}