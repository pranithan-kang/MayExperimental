using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Mockers
{
    public class MeowList
    {
        public List<Meow> GetMockup()
        {
            var MyArray = new List<Meow>();
            var meow1 = new Meow() { Name = "แมวพิมพ์", Age = 60, Sex = "Female" };
            var meow2 = new Meow() { Name = "กังพิมพ์", Age = 30, Sex = "Male" };
            var meow3 = new Meow() { Name = "Sakamoto", Age = 20, Sex = "Male" };

            MyArray.Add(meow1);
            MyArray.Add(meow2);
            MyArray.Add(meow3);

            return MyArray;
        }

        public void DoSomething()
        {

        }
    }
}