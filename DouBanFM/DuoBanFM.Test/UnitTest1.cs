using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DouBanFM.Services;
using System.Threading.Tasks;

namespace DuoBanFM.Test
{
    [TestClass]
    public class UnitTest1
    {
        private DouBanChannalService douBanChannalService = new DouBanChannalService();

        [TestMethod]
        public async Task TestMethod1()
        {
            var result = await douBanChannalService.GetAllChannels();
            Assert.IsTrue(result == null);
        }
    }
}
