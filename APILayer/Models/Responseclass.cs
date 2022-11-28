using NPOI.SS.Formula.Functions;
using System.Collections.Generic;

namespace APILayer.Models
{
    public class Responseclass<T>
    {
        public bool IsError { get; set; }
        public IEnumerable<T> ErrorList { get; set; }
        public int NoError { get; set; }
        public T result { get; set; }
        public string Messages { get; set; }
        

        public Responseclass()
        {

        }
       
    }
    public class Responseclassmethod<T> where T : class
    {

    
    

     
    }
}
