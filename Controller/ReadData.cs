using System;
using System.IO;
using System.Globalization;
namespace Projects.Controller
{
   public class ReadData
   {
    public ReadData(){}

                                 public void ReadCard(string[] lines,string logFile){
                 
                                        AdjustDate adjustDate =new AdjustDate();
                                        decimal sum =0.00m;

                                        for(int i=0; i<lines.Length;i++){
                                                       if(lines[i].Contains("$LTNG"))
                                            {
                                                  DateOnly resultingDate = adjustDate.DateForm(lines[i].Substring(5, 8));
                                                  string newDate= resultingDate.ToString("dd MMMM yyyy");
                                                  var d =adjustDate.TimeForm(lines[i].Substring(13, 6));
                                                  string card = lines[i].Substring(33, 18);
                                                  //string manufact = lines[i].Substring(51, 8);
                                                  string farechrge=lines[i].Substring(68,9);
                                                  string amount=lines[i].Substring(77,11);
                                                  string bal=lines[i].Substring(88,11);

                                                  decimal fare =Convert.ToDecimal(farechrge);
                                                  decimal amt =Convert.ToDecimal(amount);
                                                  decimal balance =Convert.ToDecimal(bal);
                                                  sum+=fare;

                                                  Console.WriteLine("Date: "+newDate);
                                                  Console.WriteLine("Time: "+d);
                                                  Console.WriteLine("Card#: "+card);
                                                //   Console.WriteLine("manufacture: "+manufact);
                                                  Console.WriteLine("Fare Charge: RM"+fare);
                                                //   Console.WriteLine("amount charges: RM"+amt);
                                                  Console.WriteLine("Balance : RM"+balance);
                                                  Console.WriteLine("");
                                                  //first is for insert and replace
                                                // File.WriteAllText(logFile,"------,"+resultingDate+","+d+","+card+","+farechrge+","+amount+","+bal);
                                                  //second is for add without replacing the content of log file
                                                using(StreamWriter sw= File.AppendText(logFile)){
                                                  sw.WriteLine("------,"+resultingDate+","+d+","+card+","+farechrge+","+amount+","+bal);
                                                }
                                                int milliseconds = 100;
                                                Thread.Sleep(milliseconds);
                                                
                                                

                                             }
                                             
                                         }
                                         Console.WriteLine("Total fare charges are: RM"+sum);
                     
        }





            }
               


           

}