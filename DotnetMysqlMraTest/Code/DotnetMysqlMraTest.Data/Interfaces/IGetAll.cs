using System.Collections.Generic;

namespace DotnetMysqlMraTest.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
