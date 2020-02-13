using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace program.Pages  
{  
    public class Top10StationsByRidership : PageModel  
    {  
				public List<Models.Top10> Top10Riders { get; set; }
				public string Input { get; set; }
				public Exception EX { get; set; }
               
  
        public void OnGet(string input)  
        {  
				    Top10Riders = new List<Models.Top10>();
							string sql;

							sql = string.Format(@"
	SELECT TOP 10 Stations.Name, Stations.StationID AS ID, SUM(DailyTotal) AS TotalRiders
    FROM Stations
    LEFT JOIN Riderships ON Stations.StationID = Riderships.StationID
    GROUP BY Stations.Name, Stations.StationID
    ORDER BY TotalRiders DESC;
    ", input);



//FULL OUTER JOIN Stops ON Stations.StationID = Stops.StationID
							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);   
							foreach (DataRow row in ds.Tables[0].Rows)
							{
								Models.Top10 s = new Models.Top10();

								s.StationName   = Convert.ToString(row["Name"]);
                                s.StationID = Convert.ToInt32(row["ID"]);
                                s.Ridership = Convert.ToInt32(row["TotalRiders"]);
                                
 
								Top10Riders.Add(s);
							}
						}//else
					}


}//namespace