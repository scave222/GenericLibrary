using System;

namespace IntergenicLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Date dateissued = new Date("11/6/2017");
            Student student = new Student("Caleb", 2000, "23DE");
            Student student1 = new Student("Ifeanyi", 2000, "23DE");
            Student student2= new Student("Banky", 2000, "23DE");
            Student student3 = new Student("Tolu", 2000, "23DE");
            Student student4 = new Student("Grace", 2000, "23DE");

            Book book = new Book("Eze goes to school", "456");
            Book book1 = new Book("Mike goes to school", "756");
            Book book2 = new Book("Soji goes to school", "086");
            Book book3 = new Book("Abayomi goes to school", "326");
            Book book4 = new Book("Yahgozie goes to school", "766");

            Library library = new Library(student,book,"2/25/2017", "3/1/2017");
            Library library1 = new Library(student1,book1,"12/25/2017", "3/1/2018");
            Library library2 = new Library(student2,book2,"8/2/2017", "8/20/2017");
            Library library3 = new Library(student3,book3,"11/5/2017", "11/15/2017");
            Library library4= new Library(student4,book4,"2/7/2017", "11/7/2017");

            // Console.WriteLine(library.GetName());
            // Console.WriteLine(library.GetYear());
            // Console.WriteLine(library.GetBook());
            // Console.WriteLine(library.GetDateReturn()); 
            //  Console.WriteLine(library.GetDefaulter());   

             GenericDefaulterList<Library> lib = new GenericDefaulterList<Library>(); 


             lib.Add(library);                     
             lib.Add(library1);                     
             lib.Add(library2);                     
             lib.Add(library3);                     
             lib.Add(library4);  
             

             foreach(var l in lib.GetAllDefaulters()){
              
              Console.WriteLine(l);        
             }

        }
    }
}
