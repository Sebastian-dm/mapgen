using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapgen {
    internal class ElevationModel {



        private string GetNameOfTile(float lat, float lon) {

            string tile = "";
            switch (lat) {
                case > 90:
                    throw new ArgumentException("input latitude cannot be above 90");
                case > 50:
                    switch (lon) {
                        case > 180:
                            throw new ArgumentException("input longitude cannot be above 180");
                        case > 90:
                            tile = "D";
                            break;
                        case > 0:
                            tile = "C";
                            break;
                        case > -90:
                            tile = "B";
                            break;
                        case >= -180:
                            tile = "A";
                            break;
                        default:
                            throw new ArgumentException("input longitude cannot be below -180");
                    }
                    break;
                case > 0:
                    switch (lon) {
                        case > 180:
                            throw new ArgumentException("input longitude cannot be above 180");
                        case > 90:
                            tile = "";
                            break;
                        case > 0:
                            tile = "G";
                            break;
                        case > -90:
                            tile = "F";
                            break;
                        case >= -180:
                            tile = "E";
                            break;
                        default:
                            throw new ArgumentException("input longitude cannot be below -180");
                    }
                    break;
                case > -50:
                    switch (lon) {
                        case > 180:
                            throw new ArgumentException("input longitude cannot be above 180");
                        case > 90:
                            tile = "";
                            break;
                        case > 0:
                            tile = "";
                            break;
                        case > -90:
                            tile = "";
                            break;
                        case >= -180:
                            tile = "";
                            break;
                        default:
                            throw new ArgumentException("input longitude cannot be below -180");
                    }
                    break;
                case >= -90:
                    switch (lon) {
                        case > 180:
                            throw new ArgumentException("input longitude cannot be above 180");
                        case > 90:
                            tile = "";
                            break;
                        case > 0:
                            tile = "";
                            break;
                        case > -90:
                            tile = "";
                            break;
                        case >= -180:
                            tile = "";
                            break;
                        default:
                            throw new ArgumentException("input longitude cannot be below -180");
                    }
                    break;
                default:
                    throw new ArgumentException("input latitude cannot be below -90");
            }
        }
            {
                "Tiles": {
                    "A": {
                        "LatMin": 50,
            "LatMax": 90,
            "LonMin": -180,
            "LonMax": -90,
                    },
        "B": {
                        "LatMin": 50,
            "LatMax": 90,
            "LonMin": 90,
            "LonMax": 0,
        },
        "C": {
                        "LatMin": 50,
            "LatMax": 90,
            "LonMin": 0,
            "LonMax": 90,
        },
        "D": {
                        "LatMin": 50,
            "LatMax": 90,
            "LonMin": 90,
            "LonMax": 180,
        },
        "E": {
                        "LatMin": 0,
            "LatMax": 50,
            "LonMin": -180,
            "LonMax": -90,
        },
        "F": {
                        "LatMin": 0,
            "LatMax": 50,
            "LonMin": -90,
            "LonMax": 0,
        },
        "G": {
                        "LatMin": 0,
            "LatMax": 50,
            "LonMin": 0,
            "LonMax": 90,
        },
        "H": {
                        "LatMin": 0,
            "LatMax": 50,
            "LonMin": 90,
            "LonMax": 180,
        },
        "I": {
                        "LatMin": -50,
            "LatMax": 0,
            "LonMin": -180,
            "LonMax": -90,
        },
        "J": {
                        "LatMin": -50,
            "LatMax": 0,
            "LonMin": -90,
            "LonMax": 0,
        },
        "K": {
                        "LatMin": -50,
            "LatMax": 0,
            "LonMin": 0,
            "LonMax": 90,
        },
        "L": {
                        "LatMin": -50,
            "LatMax": 0,
            "LonMin": 90,
            "LonMax": 180,
        },
        "L": {
                        "LatMin": -50,
            "LatMax": 0,
            "LonMin": 90,
            "LonMax": 180,
        },
        "M": {
                        "LatMin": -90,
            "LatMax": -50,
            "LonMin": -180,
            "LonMax": -90,
        },
        "N": {
                        "LatMin": -90,
            "LatMax": -50,
            "LonMin": -90,
            "LonMax": 0,
        },
        "O": {
                        "LatMin": -90,
            "LatMax": -50,
            "LonMin": 0,
            "LonMax": 90,
        },
        "P": {
                        "LatMin": -90,
            "LatMax": -50,
            "LonMin": 90,
            "LonMax": 180,
        }
                }
            }
        }



    }
}
