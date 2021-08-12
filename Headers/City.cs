using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Variables and Classes have to be named with Capital start.
 * Each new "word" in the variable and classes should precede with captialization
 * Each method should be in the form a_b() where a is function and b is on what the function is applied to
 * b follows the Variable convention in naming
*/
namespace SIRModellingCs.Headers
{
    public interface PopulationDistribution
    {
        public int PopulationGroup { get; set; }
        public int AgeGroupDistribution { get; set; }
        public int Population { get; set; }
        public int[] AgeGroupList { get; set; }
        public int[] AgeGroups { get; set; }
        public int[] Ages { get; set; }

        public void update_Params();
        public void sample_Age();
        public int get_Age(int id);
        public int get_AgeClass(int id);
    }

    public interface City
    {
        public Dictionary<int, int> SectorHolder { get; set; }
        public List<Person> Citizens { get; set; }
        public List<List<Person>> Families { get; set; }
        public int EmployedPopulation {get;set;}
        public PopulationDistribution CityPopulationDistribution { get; set; }
        public float VirusC { get; set; }
        public int Today { get; set; }
        public int CityTestingCap { get; set; }
        public float ComplianceRate { get; set; }
        public Dictionary<string,int> Tramissionmodes { get; set; }
        public HashSet<Person> TodayShoppers { get; set; }
    }
}
