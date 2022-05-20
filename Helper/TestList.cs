using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCICD_webAPI.Helper
{
    //靜態方法
    public static class TestList
    {
        public static  List<int> GenerateList()
        {
            return new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}
