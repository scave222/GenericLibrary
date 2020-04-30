using System;
using System.Collections.Generic;

namespace IntergenicLibrary
{
    public class Library : IDefaulterList
    {

         public Student StudentDetails{get; set;}
         public Book BookDetails{get; set;}
         public string DateIssuedDetails{get; set;}
         public string DateReturnedDetails{get; set;}
         public int issuedDate;
         public int returnedDate;
         public double DaysR;
         public Library(Student studentdetails, Book bookdetails, string dateIssuedDetails, string dateReturnedDetails)
        {
            StudentDetails = studentdetails;
            BookDetails = bookdetails;
            DateIssuedDetails = dateIssuedDetails;
            DateReturnedDetails = dateReturnedDetails; 


        }

        public string GetName()
        {
            return $"Student Name:{StudentDetails.Name}";
        }
        public string GetYear()
        {
            return $"Student year:{StudentDetails.YrOfStudy}";
        }
        public string GetBook()
        {
            return $"Book name: {BookDetails.BookName} Book ID: {BookDetails.BookID}";
        }
       
        public string GetDateReturn()
        {
       
    
                
                    
                    System.DateTime issuedDate = Convert.ToDateTime(DateIssuedDetails);
                    System.DateTime returnedDate = issuedDate.AddDays(+14);
                    TimeSpan DateDifferent = returnedDate - issuedDate;
                    double Days = DateDifferent.TotalDays;
                    System.DateTime drDate = Convert.ToDateTime(DateReturnedDetails);
                    TimeSpan DateReturnedDifferent = drDate - issuedDate;
                      DaysR = DateReturnedDifferent.TotalDays;
                    //Console.WriteLine($"The return date difference is {Days} and the day returned difference is {DaysR}");
                    return  $"The expected return date is: {returnedDate}";
               
        
        }
        public string GetDefaulter()
        {
            GetDateReturn();
            if(DaysR > 14){
                return $"{GetName()} is a defaulter,hasn't returned {GetBook()} Collected on {DateIssuedDetails} ";
            }
            return $"{GetName()} Is not a defaulter";
           
        }

        public override string ToString()
        {
            return $"{GetDefaulter()}";
        }

    }
}