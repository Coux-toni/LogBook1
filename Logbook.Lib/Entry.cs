namespace Logbook.Lib
{
    public class Entry
    {
        public string Description { get; set; } = string.Empty;

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int StartKM { get; set; }

        public int  EndKM { get; set; }

        public string NumberPlate { get; set; }

        public string From { get; set; }
        
        public string To { get; set; }

        public string ID { get; set; }


        public Entry(string ID, DateTime start, DateTime end, int startkm, int endkm, string numberplate, string from, string to)
        {
            this.ID = ID;
            this.Start = start;
            this.End = end;
            this.StartKM = startkm;
            this.EndKM = endkm;
            this.NumberPlate = numberplate;
            this.From = from;
            this.To = to;
        }

    }
}
