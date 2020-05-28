using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OderProcessingUnitTest
{
    [TestClass]
    public class OderProcessingUnitTest
    {
        [TestMethod]
        public void ShouldReturnVideoSlipOnly()
        {
            var result = Program.ConvertInputToType(new string[] { "video", "Random" });
            Assert.AreEqual("Random", result.ItemName);

        }
    }
}
