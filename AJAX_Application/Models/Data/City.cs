using System.Diagnostics.Metrics;

namespace AJAX_Application.Models.Data
{
      public class City
      {
            public int Id { get; set; }
            public string Name { get; set; }

            public int CountryId { get; set; }
            public Country Country { get; set; }
      }
}
