namespace AJAX_Application.Models.Data
{
      public class Country
      {
            public int Id { get; set; }
            public string Name { get; set; }
            public ICollection<City> Cities { get; set; }
      }
}
