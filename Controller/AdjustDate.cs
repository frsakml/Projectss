using System;
using System.IO;
using System.Globalization;
namespace Projects.Controller
{
   public class AdjustDate
   {
    public AdjustDate(){}

                            public DateOnly DateForm(string datee)
                            {
                              var enUS = new System.Globalization.CultureInfo("en-US");
                              DateOnly resultingDate = DateOnly.ParseExact(datee,"yyyyMMdd",enUS);
                                                                        
                                    
                                    return resultingDate;
                            }
                
                             public string TimeForm(string timee)
                                 {
                                     var d = TimeOnly.ParseExact(timee, "HHmmss", CultureInfo.InvariantCulture);
                                        String s = d.ToString("HH:mm:ss");
                                    return s;
                                 }





            }
               


           

}
                           