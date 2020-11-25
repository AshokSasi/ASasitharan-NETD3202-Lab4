using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASasitharan_NETD3202_Lab4.Models
{
    public class book
    {
        //data members
        public string title { get; set; }

        public Int64 isbn { get; set; }

        public double version { get; set; }
        public double purchasePrice { get; set; }

        public string condition { get; set; }

        //default constructor
        public book()
        {

        }

        //parameterized constructor
        public book(string title, Int64 isbn, double version, double purchasePrice, string condition)
        {
            this.title = title;
            this.isbn = isbn;
            this.version = version;
            this.purchasePrice = purchasePrice;
            this.condition = condition;
        }

        //method that calculates the value of the textbook based on the condition
        public double calculateValue (double origPrice ,string condition)
        {
            if(condition.Equals("likeNew"))
            {
                return Math.Round((origPrice / 2),2);
            }
            else if(condition.Equals("good"))
            {
                return Math.Round((origPrice / 3),2);
            }
            else
            {
                return Math.Round((origPrice / 4),2);
            }
            
        }

        

        //overrided ToString that displays the price of the book
        public override string ToString()
        {
            return "Your textbook: " + this.title + ", Version: " + this.version + " was appraised at: $" + calculateValue(this.purchasePrice,this.condition);
        }
    }

  
}
