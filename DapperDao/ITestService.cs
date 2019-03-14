using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperDao
{
    public interface ITestService:IRepositoryService<TestDto>
    {
        string GetTestValue();
    }
}
