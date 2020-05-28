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

        [TestMethod]
        public void ShouldReturnVideoLearningToSkiSlipOnly()
        {
            var result = OrderProcessor.ConvertInputToType(new string[] { "video", "Learning To Ski" });
            Assert.AreEqual("Learning To Ski", result.ItemName);
            Assert.AreEqual("Generated a packing slip.", result.Operations[0]);
            Assert.AreEqual("'First Aid' video added to the packing slip", result.Operations[1]);
            Assert.AreEqual(2, result.Operations.Count);
        }
    }
}
