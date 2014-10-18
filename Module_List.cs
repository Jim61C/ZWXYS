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
        public int index;
        public int[] modules;
        public int[] timeSlot = new int[10];
        
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

        public TA()
        {
            this.index =0;
        }
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

    public class Module : ExpressionValue 
    {

        public int ta;
        public bool gradClass;
        public int tutLen; // length of tutorial eg. 3 if tutorial takes up 3 timeslots
        public int assignedSlot;
        public int classSize = 0;
                
        public override string ToString()
        {
            return "[" + ExpressionID +"]";
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
            get
            {
                String returnString = "";
                returnString += "Module_assignedSlot =" + assignedSlot;
                return returnString;
            }
        }

        public Module ()
        {
            this.classSize=0;
            this.ta =0;
            this.gradClass=false;
            this.tutLen=0;
            this.assignedSlot=0;
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

   public class ModuleList : ExpressionValue 
    {
        public List <Module> list;

        public int Field = 0;
        
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

        public int Property
        {
            get { return Field; }
            set { Field = value; }
        }

        //default constructor
        public ModuleList()
        {
            list = new List<Module>();
        }

        public ModuleList( Module [] array)
        {
            list = new List<Module>();
            foreach (Module element in array)
            {
                list.Add(element);
            }
            
        }

        public ModuleList(List<Module> list)
        {
            this.list = list;
        }

        ////override
        //public override string GetID()
        //{
        //    String returnString = "";
        //    foreach (int element in list)
        //    {
        //        returnString += element.ToString() + ",";
        //    }

        //    if (returnString.Length > 0)
        //    {
        //        returnString = returnString.Substring(0, returnString.Length - 1);
        //    }

        //    return returnString;
        //}


        /*//override
        public override string ToString()
        {
            return "[" + ExpressionID + "]";

        }*/

        /*//override
        public override ExpressionValue GetClone()
        {
            return new List(new System.Collections.Generic.List<int>(list));
        }*/


        public int Count()
        {
            return list.Count;
        }

	    public void Add(Module element)
        {
           this.list.Add(element);
        }

        public Module Get(int index)
        {
            return this.list[index];
        }
        
        public bool Contains(Module element)
        {
            return this.list.Contains(element);
        }

        /*public List Concat(List list1, List list2)
        {
            if (list1 == null && list2 == null)
            {
                return new List();
            }
            else if (list1 == null)
            {
                return (List)list2.GetClone();
            
            }
            else if (list2 == null)
            {
                return (List)list1.GetClone();
            }
            else
            {
                List newList = new List();
                newList.list.AddRange(new System.Collections.Generic.List<int>(list1.list));
                newList.list.AddRange(new System.Collections.Generic.List<int>(list2.list));
                return newList;
            
            }
          
        }*/

        public void Remove(Module element)
        {
            this.list.Remove(element);
        }
        
        public void RemoveAt(int index)
        {
            if (index >= 0 && index <= list.Count)
            {
                this.list.RemoveAt(index);
            }
            else
            {
                //throw PAT Runtime exception
                throw new RuntimeException("index is less than 0.o -index is equal to or greater than length of the list.");
            }

          
        }

  
    }
}