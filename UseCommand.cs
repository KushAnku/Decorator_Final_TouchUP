using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Escape
{
    public class UseCommand : Command
    {
        public UseCommand() : base()
        {
            this.name = "use";
        }
        public override bool Execute(Nurse nurse)
        {
            if (this.hasSecondWord() && hasThirdWord())
            {
                if (SecondWord == "defibrillator")
                {
                    nurse.save(int.Parse(ThirdWord));
                }
                else if (SecondWord == "bpmachine" || SecondWord =="heartmachine" || SecondWord == "stethescope")
                {
                    nurse.checkup(int.Parse(ThirdWord));
                }


            }
            return false;
        }
    }
}
