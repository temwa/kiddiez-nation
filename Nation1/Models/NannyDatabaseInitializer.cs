using System.Collections.Generic;
using System.Data.Entity;

namespace Nation1.Models
{
    public class NannyDatabaseInitializer : DropCreateDatabaseIfModelChanges<NannyContext>
    {
        protected override void Seed(NannyContext context)
        {
            GetNannies().ForEach(c => context.Nannies.Add(c));
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
                    Extra = "Female. Student. Can also provide tutoring for Maths",
                    ImagePath = "nanny1.jpg"
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
                    Email = "hlongwane.sibu@gmail.com",
                    Extra = "Female. Student. Can also provide tutoring for Maths, Sciences and Accounting",
                    ImagePath = "nanny2.jpg"
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
                    Email = "brodieamy04@yahoo.com",
                    Extra = "Female. Can also provide freshly cooked meals",
                    ImagePath = "nanny4.jpg"
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
                    Email = "matlapeng.ednecia@hotmail.com",
                    Extra = "Female.",
                    ImagePath = "nanny3.jpg"
                },
                new Nanny
                {
                    NannyID = 5,
                    NannyName = "Brian Msimango",
                    Age = 22,
                    ExperienceYears = 1,
                    PartorFull = "Full-Time",
                    Areas = "Western Cape. Cape Town: Salt River, Walmer Estate, Woodstock, Zonnebloem, Observatory",
                    Phone = "+27825096462",
                    Email = "msimango.brian@yahoo.com",
                    Extra = "Male. Can also provide sports training for Soccer, Hockey and Netball",
                    ImagePath = "nanny5.jpg"
                },
                new Nanny
                {
                    NannyID = 6,
                    NannyName = "Etuna Hango",
                    Age = 32,
                    ExperienceYears = 10,
                    PartorFull = "Full-Time",
                    Areas = "Western Cape. Cape Town: Rondebosch, Kenilworth, Claremont, Newlands",
                    Phone = "+27832685785",
                    Email = "hango.etuna@gmail.com",
                    Extra = "Male. Can also provide tutoring for Maths, Science & Accounting",
                    ImagePath = "nanny6.jpg"
                }
            };
            return nannies;
        }
    }
}