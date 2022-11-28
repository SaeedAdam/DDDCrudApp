using NPOI.SS.Formula.Functions;
using System.Collections;

namespace APILayer.Models
{
    public class Response<T>
    {
        public bool Issuccess { get; set; }
        public string Message { get; set; }
        public int ErrorList { get; set; }
        public T Data { get; set; }
        public void AddResponse(bool IsSuccess,int totalRecords, T result, string message)

        {
            this.Issuccess = IsSuccess;
            this.ErrorList = totalRecords;
            this.Message = message;
            this.Data = result;
        }

    }
}
