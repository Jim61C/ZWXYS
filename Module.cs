using System;
using System.Collections.Generic;
using System.Text;
using PAT.Common.Classes.Expressions.ExpressionClass;

//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
    /// <summary>
    /// The math library that can be used in your model.
    /// all methods should be declared as public static.
    /// 
    /// The parameters must be of type "int", or "int array"
    /// The number of parameters can be 0 or many
    /// 
    /// The return type can be bool, int or int[] only.
    /// 
    /// The method name will be used directly in your model.
    /// e.g. call(max, 10, 2), call(dominate, 3, 2), call(amax, [1,3,5]),
    /// 
    /// Note: method names are case sensetive
    /// </summary>
    public class Module: ExpressionValue
    {
        private int classSize;
        private int ta;
        private bool gradClass;
        private int tutLen; // length of tutorial eg. 3 if tutorial takes up 3 timeslots
        private int assignedSlot;
        private int tutRMLoc;

        public Module()
        {
        
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

        public int getTutRMLoc()
        {
            return tutRMLoc;
        }

        //setters
        public void setAssignedSlot(int startSlot)
        {
            assignedSlot = startSlot;
        }

        public void setTutRoomLoc(int loc)
        {
            tutRMLoc = loc;
        }


    

        /// <summary>
        /// Please implement this method to provide the string representation of the datatype
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "";
        }


        /// <summary>
        /// Please implement this method to return a deep clone of the current object
        /// </summary>
        /// <returns></returns>
        public override ExpressionValue GetClone()
        {
            return this;
        }


        /// <summary>
        /// Please implement this method to provide the compact string representation of the datatype
        /// </summary>
        /// <returns></returns>
        public override string ExpressionID
        {
            get {return ""; }
        }

    }
}
