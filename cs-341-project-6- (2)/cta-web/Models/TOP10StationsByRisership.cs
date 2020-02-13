//
// One CTA Station
//

namespace program.Models
{

  public class Top10
	{
	
		// data members with auto-generated getters and setters:
	   
		public string StationName { get; set; }
		public int Ridership { get; set; }
        public int StationID { get; set; }
	
		// default constructor:
		public Top10()
		{ }
		
		// constructor:
		public Top10(string name, int total, int id)
		{
			StationName = name;
			Ridership = total;
            StationID = id;
		}
		
	}//class

}//namespacee