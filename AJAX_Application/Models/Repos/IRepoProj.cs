namespace AJAX_Application.Models.Repos
{
      public interface IRepoProj<T>
      {
            void Add(T add);
            T Find(int Id);
            List<T> List();
            List<T> ListByFilter(Func<T, bool> lamda);
      }
}