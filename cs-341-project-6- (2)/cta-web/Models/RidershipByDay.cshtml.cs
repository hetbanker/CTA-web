using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
  
namespace program.Pages  
{  
    public class RidershipByDayModel : PageModel  
    {  
        public List<string> Days { get; set; }
        public List<int> NumRiders { get; set; }
        public Exception EX { get; set; }
  
        public void OnGet()  
        {
          Days = new List<string>();
          NumRiders = new List<int>();
          
          EX = null;
          
          Days.Add("Sun");
          Days.Add("Mon");
          Days.Add("Tue");
          Days.Add("Wed");
          Days.Add("Thur");
          Days.Add("Fri");
          Days.Add("Sat");
           
          try
          {
            string sql = string.Format(@"
SELECT DATENAME(WEEKDAY,TheDate) AS TheDay, Sum(DailyTotal) AS NumRiders
FROM Riderships
GROUP BY DATENAME(WEEKDAY,TheDate)
ORDER BY
    CASE DATENAME(WEEKDAY, TheDate)
    WHEN 'Sunday'    THEN 1
    WHEN 'Monday'    THEN 2
    WHEN 'Tuesday'   THEN 3
    WHEN 'Wednesday' THEN 4
    WHEN 'Thursday'  THEN 5
    WHEN 'Friday'    THEN 6
    WHEN 'Saturday'  THEN 7
    END ASC
");
          
            DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
              int numriders = Convert.ToInt32(row["NumRiders"]);

              NumRiders.Add(numriders);
            }
		  }
		      catch(Exception ex)
		      {
                EX = ex;
		      }
		      finally
		      { 
                // nothing at the moment
              } 
        }  
        
    }//class
}//namespace