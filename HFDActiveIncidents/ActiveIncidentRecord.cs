using System;
namespace HFDActiveIncidents
{
    [Serializable]
    public class ActiveIncidentRecord
    {
        [NonSerialized]
        private string _CombinedResponse;

        public string Agency { get; set; }
        public string Address { get; set; }
        public string CrossStreet { get; set; }
        public string KeyMap { get; set; }
        public string XCoord { get; set; }
        public string YCoord { get; set; }
        public double Latitude
        {
            get { return ParseCoordinate(YCoord); }
        }
        public double Longitude
        {
            get { return ParseCoordinate(XCoord); }
        }
        public string CombinedResponse {
            get
            {
                return String.IsNullOrWhiteSpace(_CombinedResponse) ? "N" : _CombinedResponse;
            }
            set
            {
                _CombinedResponse = value;
            }
        }
        public DateTime CallTimeOpened { get; set; }
        public string IncidentType { get; set; }
        public int AlarmLevel { get; set; }
        public int NumberOfUnits { get; set; }
        public string Units { get; set; }

        private double ParseCoordinate(string strCoordinate)
        {
            try
            {
                int insertAt;

                if (strCoordinate[0] == '-')
                {
                    insertAt = 3;
                }
                else
                {
                    insertAt = 2;
                }

                strCoordinate = strCoordinate.Insert(insertAt, ".");

                return Double.Parse(strCoordinate);
            }
            catch
            {
                return 0.0D;
            }
        }
    }
}
