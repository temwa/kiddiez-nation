using System.Collections.Generic;
using System.Data.Entity;

namespace Nation1.Models
{
    public class NannyDatabaseInitializer : DropCreateDatabaseIfModelChanges<NannyContext>
    {
        protected override void Seed(NannyContext context)
        {
            
        }

        private static List<Nanny> GetNannies()
        {
            var nannies = new List<Nanny>
            {
                new Nanny
                {
                    NannyID = 1,
                    NannyName = "Tendani Netshitenzhe",
                    Age = 21,
                    ExperienceYears = 2,
                    PartorFull = "Part-Time",
                    Areas = "Gauteng. Johannesburg: Fourways, Bryanston, Sandton",
                    Phone = "+27823934162",
                    Email = "tn124377@gmail.com",
                    Extra = "Female. Student. Can also provide tutoring for Maths"
                },
                new Nanny
                {
                    NannyID = 2,
                    NannyName = "Sibulele Hlongwane",
                    Age = 22,
                    ExperienceYears = 1,
                    PartorFull = "Part-Time",
                    Areas = "Eastern Cape. Port Elizabeth: Port Elizabeth Central, Millard Grange",
                    Phone = "+27413743172",
                    Extra = "Female. Student. Can also provide tutoring for Maths, Sciences and Accounting"
                },
                new Nanny
                {
                    NannyID = 3,
                    NannyName = "Amy Brodie",
                    Age = 27,
                    ExperienceYears = 5,
                    PartorFull = "Full-Time",
                    Areas = "Western Cape. Cape Town: Rondebosch, Kenilworth, Claremont, Newlands",
                    Phone = "+27728651370",
                    Extra = "Female. Can also provide freshly cooked meals"
                },
                new Nanny
                {
                    NannyID = 4,
                    NannyName = "Sewagodimo Matlapeng",
                    Age = 21,
                    ExperienceYears = 0,
                    PartorFull = "Part-Time",
                    Areas = "Gauteng. Johannesburg: Douglasdale, Jukskei Park, Northgate, Northriding, Olivedale",
                    Phone = "+27829000083",
                    Extra = "Female."
                }
            };
            return nannies;
        }
    }
}