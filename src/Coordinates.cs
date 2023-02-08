namespace mapgen {
    internal class Coordinates {

        //lat 55.777344, lon 12.264762
        //lat 55.558575, lon 12.823898

        private float _latitude;
        private float _longitude;

        public Coordinates(float latitude, float longitude) {
            _latitude = latitude;
            _longitude = longitude;
        }

        public float Latitude {
            get { return _latitude; }
            set { _latitude = value; }
        }
        public float Longitude {
            get { return _longitude; }
            set { _longitude = value; }
        }






    }
}
