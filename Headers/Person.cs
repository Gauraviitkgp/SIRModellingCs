using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRModellingCs.Headers
{
    public struct WorkPlaceID
    {
        public int Sector;
        public int SectorClass;
        public int Id;
    }
    public interface Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int AgeClass { get; set; }
        public int FamilyId { get; set; }
        public bool IsAlien { get; set; }
        public int GroceryPlace { get; set; }
        public Dictionary<String,int> History { get; set; }
        public Dictionary<String,List<Person>> SpreadsTo { get; set; }
        public bool UseTN { get; set; }
        public WorkPlaceID Work { get; set; }
        public int ReproNumber { get; set; }
        public WorkPlaceID GetWorkPlaceID();
        public void probablistically_assign(int[] probablities);

    }
}
