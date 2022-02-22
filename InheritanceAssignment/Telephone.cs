using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    public abstract class Telephone
    {
        protected string phonetype;

        public abstract void Ring();
        
    }

    public class DigitalPhone : Telephone
    {
        public DigitalPhone()
        {
            this.phonetype = "Digital";
        }
        public override void Ring()
        {
            Console.WriteLine("{0} phone ringing..... Baaaa Boooooo", phonetype);
        }
    }
    public class TalkingPhone : Telephone
    {
        public TalkingPhone()
        {
            this.phonetype = "Talking";
        }
        public override void Ring()
        {
            Console.WriteLine("{0} phone ringing... zuuu zuuuu", phonetype);
            
        }
    }
        

    

    
}
    













