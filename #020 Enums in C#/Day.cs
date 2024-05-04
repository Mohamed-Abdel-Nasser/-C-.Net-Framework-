namespace ConsoleApp1
{
    internal partial class program
    {
        [Flags]
        enum Day
        {
            MONDAY = 0b_0000_0000,
            TUESDAY = 0b_0000_0010,
            WEDNESDAY = 0b_0000_0100,
            THURSDAY = 0b_0000_1000,
            FRIDAY = 0b_0001_0000,
            SATURDAY = 0b_0010_0000,
            SUNDAY = 0b_0100_0000,
            BUSDAY = MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY,
            WEEKEND = SATURDAY | SUNDAY

        }
    }
}
