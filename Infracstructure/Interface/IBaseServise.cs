namespace Infracstructure.Interface;

public interface IBaseServise<T>
{
      List<T> Get();
        string  Add(T t);
      string Update(T t);
      void Delete(int i);
      T GetById(int t);
}
