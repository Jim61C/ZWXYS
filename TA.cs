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
    public class TA : ExpressionValue
    {
    
    
        int index;
        int[] modules;
        int[] timeSlot = new int[10];

         public TA()
        {
        }

        public TA(int i, int[] mods)
        {
            index = i;
            modules = mods;
        }

        public void setIndex(int i){
            index = i;
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

        public void setModules(int[] m){
            modules = m;
        }

        public int[] getModules()
        {
            return modules;
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
