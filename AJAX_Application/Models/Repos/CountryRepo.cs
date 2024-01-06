using AJAX_Application.Models.Data;
using System.Diagnostics.Metrics;

namespace AJAX_Application.Models.Repos
{
      public class CountryRepo : IRepoProj<Country>
      {
            private readonly AppDbConext conext;

            public CountryRepo(AppDbConext conext)
            {
                  this.conext = conext;
            }

            public void Add(Country add)
            {
                  throw new NotImplementedException();
            }

            public Country Find(int Id)
            {
                  var c = conext.Countries.Find(Id);
                  return c;
            }

            public List<Country> List()
            {
                  var x = conext.Countries.ToList();
                  return x;
            }

            public List<Country> ListByFilter(Func<Country, bool> lamda)
            {
                  var x = conext.Countries.Where(lamda).ToList();
                  return x;
            }
      }
}
