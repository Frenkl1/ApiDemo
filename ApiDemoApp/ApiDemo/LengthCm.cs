namespace ApiDemo
{
    public class Length
    {
        public DateTime Date { get; set; }

        public int LengthCm { get; set; }

        public int LengthM => (int)(LengthCm / 100);

        public int LengthInch => (int)(LengthCm * 0.393701);

    }
}



