using System;


namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Telephone telephone1 = new DigitalPhone();
            Telephone telephone2 = new TalkingPhone();

            telephone1.Ring();
            telephone2.Ring();
        } 
    }
}
