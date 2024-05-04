namespace ConsoleApp1
{
    internal partial class program
    {
        public struct DigitalSize
        {
            private long bit;

            private const long bitsInBit = 1;
            private const long bitsInByte = 8;
            private const long bitsInKB = 1024;
            private const long bitsInMB = 1024;
            private const long bitsInGB = 1024;
            private const long bitsInTB = 1024;


            public string Bit => $"{(bit / bitsInBit):N0} Bit ";
            public string Byte => $"{(bit / bitsInByte):N0} Byte ";
            public string KB => $"{(bit / bitsInKB):N0} KB ";
            public string MB => $"{(bit / bitsInMB):N0} MB ";
            public string GB => $"{(bit / bitsInGB):N0} GB ";
            public string TB => $"{(bit / bitsInTB):N0} TB ";


            public DigitalSize(long initialValue)
            {
                this.bit = initialValue;
            }



            public DigitalSize AddBit(long bit)
            {
                return Add(bit, bitsInBit);
            }

            public DigitalSize AddByte(long bit)
            {
                return Add(bit, bitsInByte);
            }


            public DigitalSize AddKB(long bit)
            {
                return Add(bit, bitsInKB);
            }


            public DigitalSize AddMB(long bit)
            {
                return Add(bit, bitsInMB);
            }


            public DigitalSize AddGB(long bit)
            {
                return Add(bit, bitsInGB);
            }

            public DigitalSize AddTB(long bit)
            {
                return Add(bit, bitsInTB);
            }

            private DigitalSize Add(long value, long scale)
            {
                return new DigitalSize(value * scale);

            }


        }
    }
}
