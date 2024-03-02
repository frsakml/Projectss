using System;
using System.IO;
using System.Globalization;
using Projects.Controller;
namespace Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
              string filePath = @"Data/DataTest.DAT";
              string logFile = "Data/output.log";
              
              string[] lines = File.ReadAllLines(filePath);
            ReadData readdata =new ReadData();
                readdata.ReadCard(lines,logFile);
            //    for(int i=0;i<date.Length;i++){
            //     Console.WriteLine("Date: "+date[i]);
            //     Console.WriteLine("Time: "+time[i]);
            //    }



        }

        // public static string[] ReadDate(string[] lines){

        //          AdjustDate adjustDate =new AdjustDate();
                        
        //                                 List<string> date = new List<string>();
        //                                 for(int i=0; i<lines.Length;i++){
        //                                                if(lines[i].Contains("$LTNG"))
        //                                     {
        //                                           var resultingDate = adjustDate.DateForm(lines[i].Substring(5, 8));
        //                                           date.Add(resultingDate);
        //                                          // Console.WriteLine("Date: "+resultingDate);
        //                                      }
        //                                  }
        //                                   string[] d=date.ToArray();
        //                                  return d;

                     
        // }

        //  public static string[] ReadTime(string[] lines){

        //          AdjustDate adjustDate =new AdjustDate();
                        
        //                                 List<string> time = new List<string>();
        //                                 for(int i=0; i<lines.Length;i++){
        //                                                if(lines[i].Contains("$LTNG"))
        //                                     {
        //                                           var d =adjustDate.TimeForm(lines[i].Substring(13, 6));
        //                                           time.Add(d);
        //                                           //Console.WriteLine("Time: "+d);
        //                                      }
        //                                  }
        //                                  string[] t=time.ToArray();
        //                                  return t;
                     
        // }
        

    }
}