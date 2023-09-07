namespace Domain
{
    public class Cursors
    {
        public string before { get; set; }
        public string after { get; set; }
    }

    public class Datum
    {
        public string media_url { get; set; }
        public string permalink { get; set; }
        public string media_type { get; set; }
        public string id { get; set; }
    }

    public class Paging
    {
        public Cursors cursors { get; set; }
        public string next { get; set; }
    }

    public class Graph
    {
        public List<Datum> data { get; set; }
        public Paging paging { get; set; }
    }
}