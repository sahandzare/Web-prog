namespace elvis
{
     public class song
    {

        public int id { get; set; }
        public int artist { get; set; }

        public string title { get; set; }
        public string spotify { get; set; }

        // method use for the deserialization and serialization 

        public override string ToString()
        {
            return $"{id}-{title}-{artist}-{spotify}";
        }

    }
}
