

namespace mapgen {
    public class ElevationModelGTOPO30 {

        private static string _tilePath = "C:/Users/sdme/git/mapgen/res/GTOPO30/all10/";
        private static string _tileSuffix = "10g";
        private static string[,] _tileChars = new string[4, 4] {
            { "A", "B", "C", "D" },
            { "E", "F", "G", "H" },
            { "I", "J", "K", "L" },
            { "M", "N", "O", "P" }
        };


        public static string GetTileName(double latitude, double longitude) {
            int[] tileIndex = GetTileIndex(latitude, longitude);
            string tileName = _tileChars[tileIndex[0], tileIndex[1]].ToLower() + _tileSuffix;
            return tileName;
        }

        public static int[] GetTileIndex(double latitude, double longitude) {

            if (longitude < -180 || longitude > 180)
                throw new ArgumentException($"Input latitude must be between -180 and 180. Received {latitude}");
            if (latitude < -90 || latitude > 90)
                throw new ArgumentException($"Input longitude must be between -90 and 90. Received {longitude}");

            int[] tileIndex = new int[2] { -1, -1 };

            switch (latitude) {
                case < -50:
                    tileIndex[1] = 3; break;
                case < 0:
                    tileIndex[1] = 2; break;
                case < 50:
                    tileIndex[1] = 1; break;
                default:
                    tileIndex[1] = 0; break;
            }
            switch (longitude) {
                case < -90:
                    tileIndex[0] = 0; break;
                case < 0:
                    tileIndex[0] = 1; break;
                case < 90:
                    tileIndex[0] = 2; break;
                default:
                    tileIndex[0] = 3; break;
            }
            

            return tileIndex;
        }



    }
}
