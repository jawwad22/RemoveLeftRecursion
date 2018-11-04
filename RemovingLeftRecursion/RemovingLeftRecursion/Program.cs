using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingLeftRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example implement from 
       // https://www.youtube.com/watch?v=7VOJ6Cj1OVQ&t=199s
            Dictionary<string, string> production = new Dictionary<string, string>();
            production.Add("E", "E+T|T");

            foreach (KeyValuePair<string, string> entry in production) { 
                bool flag=false;
                string key = "";
                string beta = "";
                string alpha = "";
                string[] splitArray;
                if (char.Parse(entry.Key) == entry.Value[0]) {
                    flag = true;
                    key = entry.Key;
                    splitArray = entry.Value.Split('|');
                    beta = splitArray[1]; //bad code practice detected
                    string temp = splitArray[0];
                   temp= temp.Remove(0, 1);
                    splitArray[0] = temp;
                    alpha = splitArray[0];
                                    
                }
                if (flag) { 
                if(production.ContainsKey(key)){
                    production[key] = beta + key + "'";
                    production.Add(key+"'",alpha+"|e"); ///here e taken as null
                }
                }
            }
        }
    }
}
