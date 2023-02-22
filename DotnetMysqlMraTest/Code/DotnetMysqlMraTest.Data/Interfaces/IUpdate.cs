namespace DotnetMysqlMraTest.Data.Interfaces
{
    public interface IUpdate<T> where T : class
    {
        T Update( T entity);
    }
}