using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingApplication;

namespace OderProcessingUnitTest
{
    [TestClass]
    public class OderProcessingUnitTest
    {
        [TestMethod]
        public void ShouldReturnVideoSlipOnly()
        {
            var result = OrderProcessor.ConvertInputToType(new string[] { "video", "Random" });
            Assert.AreEqual("Random", result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Operations[0]);
            Assert.AreEqual(1, result.Operations.Count);

        }
    }
}
