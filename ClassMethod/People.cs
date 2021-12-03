using System;

namespace ClassMethod
{
    public class People
    {
        // property
        public int Age { get; set; }
        public string Name { get; set; }
        public string SkinColor { get; set; }
        
        //constructor default
        public People()
        {
            
        }

        public People(int age, string name, string skinColor)
        {
            this.Age = age;
            this.Name = name;
            this.SkinColor = skinColor;
        }
        
        //method
        public void Speak()
        {
            Console.WriteLine("Helloworld" + Age);
        }
        
        public void Run()
        {
            Console.WriteLine("Running");
        }
        
        public void Swimming()
        {
            Console.WriteLine("Swimming");
        }

        ~People()
        {
            
        }
    }
}