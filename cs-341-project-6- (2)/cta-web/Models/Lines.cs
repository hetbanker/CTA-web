//
// One CTA Station
//

namespace program.Models
{

  public class Lines
	{
	
		// data members with auto-generated getters and setters:
	    public int StationID { get; set; }
		public string StationName { get; set; }
		public int Stops {get;set;}
	
		// default constructor:
		public Lines()
		{ }
		
		// constructor:
		public Lines(int id, string name, int stop)
		{
			StationID = id;
			StationName = name;
			Stops = stop;
		}
		
	}//class

}//namespacee