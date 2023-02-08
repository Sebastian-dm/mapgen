using mapgen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mapGenTest {

    [TestClass]
    public class ElevationModelTest {



        public ElevationModelTest() {


        }


        [TestMethod]
        public void TileNameTest() {
            Assert.AreEqual("A", ElevationModelGTOPO30.GetTileName(67.0, -126.0));
            Assert.AreEqual("P", ElevationModelGTOPO30.GetTileName(-67.0, 126.0));
        }
    }
}