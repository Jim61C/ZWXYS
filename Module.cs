using System;
using System.Collections.Generic;
using System.Text;
//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
    /// The return type can be bool, int or int[] only.

    public class Module
    {
        private int classSize;
        private int ta;
        private bool gradClass;
        private int tutLen; // length of tutorial eg. 3 if tutorial takes up 3 timeslots
        private int assignedSlot;

        public Module()
        {
            this.classSize = 0;
            this.ta = 0;
            this.gradClass = false;
            this.tutLen = 0;
            this.assignedSlot = 0;
        }

        public Module(int classSize, int ta, bool gradClass, int tutLen)
        {
            this.classSize = classSize;
            this.ta = ta;
            this.gradClass = gradClass;
            this.tutLen = tutLen;
            this.assignedSlot = 0;
        }

        // getters
        public int getClassSize()
        {
            return classSize;
        }

        public bool isGradClass()
        {
            return gradClass;
        }

        public int getTutLen()
        {
            return tutLen;
        }

        public int getAssignedSlot()
        {
            return assignedSlot;
        }

        public int getTa()
        {
            return ta;
        }

        //setters
        public void setAssignedSlot(int startSlot)
        {
            assignedSlot = startSlot;
        }


    }
}