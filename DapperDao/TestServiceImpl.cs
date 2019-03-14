using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperDao
{
    public class TestServiceImpl : RepositoryServiceImpl<TestDto>, ITestService
    {
        public string GetTestValue()
        {
            return "this is a testImpl.";
        }
    }
}
