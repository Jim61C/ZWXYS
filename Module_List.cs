using System;
using System.Collections.Generic;
using System.Text;
using PAT.Common.Classes.Expressions.ExpressionClass;


//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
   public class ModuleList
    {
        public List<Module> list;

        public int Field = 0;

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

        public int Get(int index)
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
