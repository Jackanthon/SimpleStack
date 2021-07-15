using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day3Mod4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array here called grdsArray
            float[] grdsArray = new float[5];
            //Call the addGrades method, passing it the grdsArray 
            addGrades(grdsArray);
            //display grades using a foreach construct to iterate over the array
            displayGrades(grdsArray);
            Stack myStack = new Stack();
            //Call the pushStack() method passing in the gardes array for values pushStack
            pushStack(grdsArray, myStack);
            //Call the popStack() method twice to remove the top two items from stack
            //The popStack method will display each popped item to the console window
            popStack(myStack);
            popStack(myStack);
            //Create a new SortedList object called myCourses
            SortedList myCouses = new SortedList();

            populateList(myCouses);
            //display a course in the list by passing a key
            displayList(myCouses, "CS101");
            //remove an item from the myCoures list using the key
            removeList(myCouses, "CS201");
            //call the populateList() method
            
           





            Console.ReadLine();
        }
        static void addGrades(float[] grdArray)
        {
            grdArray[0] = 98;
            grdArray[1] = 99;
            grdArray[2] = 89;
            grdArray[3] = 95;
            grdArray[4] = 96;
        }
        static void displayGrades(float [] grdsArray)
        {
            foreach (double item in grdsArray)
            {
                Console.WriteLine(item);
            }    
        }
        static void pushStack(float[] grdArray, Stack stack)
        {
            foreach (float item in grdArray)
            {
                stack.Push(item);
            }
        }
        //pop top items from the stack objected passed in and write the value out to the console
        static void popStack(Stack stack)
        {
            Console.WriteLine("Item removed from the stack: ");
            float item = (float)stack.Pop();
            Console.WriteLine(item);
        }
        static void populateList(SortedList list)
        {
            list.Add("CS101", "Introduction to Computer Science");
            list.Add("CS102", "Data Structures and Algorithm Analysis");
            list.Add("CS201", "Introduction to Databases");
            list.Add("CS301", "Introduction to Object-Oriented Programming");
        }
        static void displayList(SortedList list, string key)
        {
            int index;
            string course;
            index = list.IndexOfKey(key);
            course = (string)list.GetByIndex(index);
            Console.WriteLine(course);
        }
        static void removeList(SortedList list, string key)
        {
            int index;
            string course;
            index = list.IndexOfKey(key);
            course = (string)list.GetByIndex(index);
            list.Remove(key);
            Console.WriteLine(course + " was removed from the list");
        }
    }
}
