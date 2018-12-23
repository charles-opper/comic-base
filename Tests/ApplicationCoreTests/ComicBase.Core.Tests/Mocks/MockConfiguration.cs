using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.Core.Tests.Mocks
{
    public static class MockConfiguration
    {
        public static readonly string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ComicBase;Integrated Security=True;Connect Timeout=10;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
