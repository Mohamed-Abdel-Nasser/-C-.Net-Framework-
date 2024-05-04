namespace ConsoleApp1
{
    public class IP
    {
        private int[] segments = new int[4];

        public int this[int index]
        {
            get
            {
                return segments[index];
            }
            set
            {
                segments[index] = value;
            }
        }


        public IP(int segments1, int segments2, int segments3, int segments4)
        {
            this.segments[0] = segments1;
            this.segments[1] = segments2;
            this.segments[2] = segments3;
            this.segments[3] = segments4;


        }


        public string Address => string.Join(",", segments);

        public IP(string IPAddress) // 123.123.123.123
        {
            var segs = IPAddress.Split(".");
            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32(segs[i]);
            }

        }

    }

}
