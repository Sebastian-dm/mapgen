
namespace mapGenTest {

    [TestClass]
    public class ElevationModelTest {



        public ElevationModelTest() {


        }


        [TestMethod]
        public void TileNameTest() {
            Assert.AreEqual("a10g", ElevationModelGTOPO30.GetTileName(67.0, -126.0));
            Assert.AreEqual("p10g", ElevationModelGTOPO30.GetTileName(-67.0, 126.0));
        }
    }
}