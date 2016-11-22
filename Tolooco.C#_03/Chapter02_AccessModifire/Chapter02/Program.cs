﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public class Person // Class Accessbilities: [public] - [internal]
    {
        // Member Accessbilities: [public] - [private] - [protected] - [internal] - [protected internal]
        // [protected internal] means [protected] OR [internal]

        //بالیک :دسترسی کامل در کل برنامه
        public int Age;
        public string FullName;

        //پرایویت:دسترسی در همان کلاس
        private string SomePrivateMember;
        //پروتکتد :دسترسی در همان کلاس و کلاس های مشتق شده
        protected string SomeProtectedMember;

        //اینترنال:دسترسی در کل سولوشن
        //پروتکتد اینترنال یعنی یا پروتکتد یا اینترنال
        protected internal string SomeProtectedInternalMember;

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }

    public class Employee : Person
    {
        public int Salary;

        public void DoSomethings()
        {
            Age = 10;

            // Wrong Usage!
            // SomePrivateMember = "Hello!";

            SomeProtectedMember = "Hello!";
            SomeProtectedInternalMember = "How Are You?";
        }
    }

    /// <summary>
    /// پیاده سازی اکسز مادی فایر در کلاس ها
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson = new Person();

            // Wrong Usage!
            // oPerson.SomePrivateMember = "Hello!";
            // oPerson.SomeProtectedMember = "Hello!";

            oPerson.SomeProtectedInternalMember = "Hello!";

            System.Console.ReadLine();
        }
    }
}
