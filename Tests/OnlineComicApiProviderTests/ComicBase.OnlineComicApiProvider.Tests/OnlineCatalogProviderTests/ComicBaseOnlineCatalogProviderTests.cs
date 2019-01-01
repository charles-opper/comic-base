using ComicBase.OnlineComicApiProvider.Factory;
using ComicBase.OnlineComicApiProvider.Interfaces;
using ComicBase.OnlineComicApiProvider.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.OnlineComicApiProvider.Tests.OnlineCatalogProviderTests
{
    [TestClass]
    public class ComicBaseOnlineCatalogProviderTests
    {
        public ComicBaseOnlineCatalogProviderTests()
        {
            var factory = new OnlineCatalogProviderFactory();
            _provider = factory.GetProvider(ProviderType.ComicVine, MockConfiguration.ComicVineApiKey);
        }

        [TestMethod]
        public void TestGetCatalogItems()
        {
            var catalogItems = new List<OnlineCatalogItem>();

            catalogItems.AddRange(_provider.GetCatalogItemsByTitle("Cable"));

            Assert.IsTrue(catalogItems.Count > 0);
        }

        private IOnlineCatalogProvider _provider;
    }
}
