using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAT.Lib
{
    public class TA 
    {
        int index;
        int[] modules;
        int[] timeSlot = new int[10];
        public TA(int i, int[] mods)
        {
            index = i;
            modules = mods;
        }

        public int getIndex()
        {
            return index;
        }

        public void setTimeSlot(int i, int modIndex)
        {
            timeSlot[i] = modIndex;
        }

        public int[] getTimeSlot()
        {
            return timeSlot;
        }

        public int[] getModules()
        {
            return modules;
        }
    }
}
