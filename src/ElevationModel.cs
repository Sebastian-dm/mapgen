using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapgen {
    internal class ElevationModelGTOPO30
    {

        private string _tilePath = "C:/Users/sdme/git/mapgen/res/GTOPO30/all10/";
        private string _tilePrefix = "a10";
        private char[,] _tileChars = new char[4, 4] {
            { 'A', 'B', 'C', 'D' },
            { 'E', 'F', 'G', 'H' },
            { 'I', 'J', 'K', 'L' },
            { 'M', 'N', 'O', 'P' }
        };


        private string GetTileName(float lat, float lon) {
            int[] tileIndex = GetTileIndex(lat, lon);
            string tileName = _tilePrefix + _tileChars[tileIndex[0], tileIndex[1]];
            return tileName;
        }

        private int[] GetTileIndex(float lat, float lon) {

        if (lon < -180 || lon > 180)
            throw new ArgumentException($"Input latitude must be between -180 and 180. Received {lat}");
        if (lat < -90 || lat > 90)
            throw new ArgumentException($"Input longitude must be between -90 and 90. Received {lon}");

        int[] tileIndex = new int[2] { -1, -1 };

        switch (lon) {
            case < -90:
                tileIndex[0] = 0; break;
            case < 0:
                tileIndex[0] = 1; break;
            case < 90:
                tileIndex[0] = 2; break;
            default:
                tileIndex[0] = 3; break;
        }
        switch (lat) {
            case < -50:
                tileIndex[1] = 0; break;
            case < 0:
                tileIndex[1] = 1; break;
            case < 50:
                tileIndex[1] = 2; break;
            default:
                tileIndex[1] = 3; break;
        }

        return tileIndex;
        }



    }
}
