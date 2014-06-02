using System;
namespace HFDActiveIncidents
{
    [Serializable]
    public class ActiveIncidentRecord
    {
        [NonSerialized]
        private readonly DateTime _dtRetrieved;
        [NonSerialized]
        private string _strCombinedResponse;
        [NonSerialized]
        private string _strCallTimeOpened;
        [NonSerialized]
        private DateTime _dtCallTimeOpened;
        [NonSerialized]
        private string _strAlarmLevel;
        [NonSerialized]
        private int _nAlarmLevel;
        [NonSerialized]
        private string _strNumberOfUnits;
        [NonSerialized]
        private int _nNumberOfUnits;

        public ActiveIncidentRecord()
        {
            _dtRetrieved = DateTime.Now;
        }

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
                return String.IsNullOrWhiteSpace(_strCombinedResponse) ? "N" : _strCombinedResponse;
            }
            set
            {
                _strCombinedResponse = value;
            }
        }
        public string CallTimeOpened
        {
            get
            {
                return _strCallTimeOpened;
            }
            set
            {
                DateTime dtNewValue;
                _strCallTimeOpened = value;
                if (DateTime.TryParse(value, out dtNewValue))
                {
                    _dtCallTimeOpened = dtNewValue;
                }
                else
                {
                    _dtCallTimeOpened = DateTime.MinValue;
                }
            }
        }
        public DateTime CallTimeOpenedDT
        {
            get
            {
                return _dtCallTimeOpened;
            }
        }
        public string IncidentType { get; set; }
        public string AlarmLevel 
        {
            get 
            {
                return _strAlarmLevel;
            }
            set 
            {
                int nNewValue;
                _strAlarmLevel = value;
                if (int.TryParse(value, out nNewValue))
                {
                    _nAlarmLevel = nNewValue;
                }
                else
                {
                    _nAlarmLevel = 0;
                }
            }
        }
        public int AlarmLevelInt
        {
            get
            {
                return _nAlarmLevel;
            }
        }
        public string NumberOfUnits
        {
            get
            {
                return _strNumberOfUnits;
            }
            set
            {
                int nNewValue;
                _strNumberOfUnits = value;
                if (int.TryParse(value, out nNewValue))
                {
                    _nNumberOfUnits = nNewValue;
                }
                else
                {
                    _nNumberOfUnits = 1;
                }
            }
        }
        public int NumberOfUnitsInt
        {
            get
            {
                return _nNumberOfUnits;
            }
        }

        public DateTime DateRetrieved { get { return _dtRetrieved; } }

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
