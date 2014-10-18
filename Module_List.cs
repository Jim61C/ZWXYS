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

        public int name;
        public int[] modules;
        public int modules_size;
        public int[] timeSlot;
        public int timeSlot_size;
        
        public override string ToString()
        {
            return "[" + ExpressionID+ "]";
        }

        public override ExpressionValue GetClone()
        {
            return this;
        }

        public override string ExpressionID
        {
            get
            {
                String returnString = "";
                returnString += "Name: " + this.name +", Modules: [";
                for (int i=0;i< modules_size;i++)// print list of modules of the TA
                {
                    if(i == 0 )
                    returnString += modules[i];
                    else
                    returnString += "," + modules[i];
                } 
                returnString +="]";
                returnString += ", timeSlot: [";
                for (int i=0;i< timeSlot_size;i++)// print list of timeslots of the TA
                {
                    if(i == 0 )
                    returnString += timeSlot[i];
                    else
                    returnString += "," + timeSlot[i];
                } 
                returnString +="] ";

                return returnString; 
            }
        }


        public TA()
        {
            name = 0;
            modules_size =0;
            timeSlot_size =0;
        }

        public TA(int i, int[] mods)
        {
            name = i;
            modules = mods;
        }

        public void setIndex(int i){
            name = i;
        }

        public int getIndex()
        {
            return name;
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
    }

    public class Module : ExpressionValue 
    {
        public int classSize;
        public TA [] ta;
        public bool gradClass;
        public int tutLen; // length of tutorial eg. 3 if tutorial takes up 3 timeslots
        public int assignedSlot;
        public int assignedRoom;// represented by enum
        public TA prof; 
        public int TA_size = 0;

        public Module(int classSize, TA [] ta, bool gradClass, int tutLen)
        {
            this.classSize = classSize;
            this.ta = ta;
            this.gradClass = gradClass;
            this.tutLen = tutLen;
            this.assignedSlot = 0;
        }
        public Module()
        {
            TA_size = 0;
            gradClass=false;
            tutLen = 0;
            assignedSlot =0;
            assignedRoom =0;
            prof = new TA();
            classSize =0;
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

        public TA [] getTa()
        {
            return ta;
        }

        //setters
        public void setAssignedSlot(int startSlot)
        {
            assignedSlot = startSlot;
        }

        public override string ToString()
        {
            return "[" + ExpressionID +"]";
        }


        public override ExpressionValue GetClone()
        {
            return this;
        }

        public override string ExpressionID
        {
            get
            {
                String returnString = "";
                returnString += "classSize: "+ classSize +",";
                returnString += "isGradClass: "+ gradClass +",";
                returnString += "assignedSlot: "+ assignedSlot+ ",";
                returnString += "assignedRoom: "+ assignedRoom+ ",";
                returnString += "LengthOfTut: "+ tutLen+ ",";
                returnString += "Professor: " + prof.ToString() +", ";
                returnString += "TAs: "+"\n"+ "[ ";
                for (int i=0;i< TA_size;i++)
                {
                    returnString += ta[i].ToString() +"\n";
                }

                returnString +="]" +"\n";
                return returnString;
            }
        }

    }

   public class ModuleList : ExpressionValue 
    {
        public List <Module> list;
        public int size = 0;
        
        public override string ToString()
        {
            return "[" + ExpressionID +"]";
        }

        public override ExpressionValue GetClone()
        {
            return this;
        }

        public override string ExpressionID
        {
            get
            {
                String  returnString = "ListOfModules: "+"\n"+ "[ ";
                for(int i=0; i< size; i++)
                {
                    returnString+= list[i].ToString() +"\n";
                }
                returnString+="] "+"\n";
                return returnString;
            }
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