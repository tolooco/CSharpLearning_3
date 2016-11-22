﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter35
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    [System.Serializable]
    public class Person
    {
        public int Age;
        public string FullName;

        public Person(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList oPersonCollection1 = new System.Collections.ArrayList();

            oPersonCollection1.Add(new Person("Ali Reza Alavi", 20));
            oPersonCollection1.Add(new Person("Sara Ahmadi", 30));
            oPersonCollection1.Add(new Person("Sanaz Samimi", 40));

            System.IO.FileStream oFileStream1 = new System.IO.FileStream(@"C:\TEST.BIN", System.IO.FileMode.Create, System.IO.FileAccess.Write);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter oBinaryFormatter1 = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            oBinaryFormatter1.Serialize(oFileStream1, oPersonCollection1);
            oFileStream1.Close();
            oPersonCollection1.Clear();

            System.Collections.ArrayList oPersonCollection2 = null;

            System.IO.FileStream oFileStream2 = new System.IO.FileStream(@"C:\TEST.BIN", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter oBinaryFormatter2 = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            oPersonCollection2 = (System.Collections.ArrayList)oBinaryFormatter2.Deserialize(oFileStream2);
            oFileStream2.Close();

            System.Console.WriteLine("\n----------");
            foreach (Person oPerson in oPersonCollection2)
                oPerson.ShowInfo();
            System.Console.WriteLine("----------");

            oPersonCollection2.Clear();

            System.Console.ReadLine();
        }
    }
}
