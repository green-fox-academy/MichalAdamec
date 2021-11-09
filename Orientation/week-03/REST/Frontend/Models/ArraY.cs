using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//That receives a relatively complex json object:
//    "what": "sum",
//  "numbers": [1, 2, 5, 10]
//what can be 3 things: sum, multiply, double
//and responds with sum or multiplication of all elements in the numbers or with another array with the doubled elements:
//eg. / arrays with { "what": "sum", "numbers": [1,2,5,10]} will respond {"result": 18}
//eg. / arrays with { "what": "multiply", "numbers": [1,2,5,10]} will respond {"result": 100}
//eg. / arrays with { "what": "double", "numbers": [1,2,5,10]} will respond {"result": [2,4,10,20]}
//if no what(or numbers) is provided:
//    "error": "Please provide what to do with the numbers!"
namespace Frontend.Models
{
    public class ArraY
    {
        public string What { get; set; }
        public int[] Numbers { get; set; }

        public int Sum()
        {
            int numb = 0;
            foreach (var num in Numbers)
                numb += num;
            return numb;
        }
        public int Multiply()
        {
            int numb = 1;
            foreach(int num in Numbers)
                numb *= num;
            return numb;
        }
        public int[] Double()
        {
            int[] newArray = new int[Numbers.Length];
            for (int a = 0; a < Numbers.Length; a++)
                newArray[a] = Numbers[a] * 2;
            return newArray;
        }

    }
}
