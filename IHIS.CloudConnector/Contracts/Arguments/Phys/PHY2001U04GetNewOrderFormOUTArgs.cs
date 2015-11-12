using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04GetNewOrderFormOUTArgs : IContractArgs
    {
        private String _orderDate;
        private String _timeHour;
        private String _timeMin;
        private String _timeSec;

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String TimeHour
        {
            get { return this._timeHour; }
            set { this._timeHour = value; }
        }

        public String TimeMin
        {
            get { return this._timeMin; }
            set { this._timeMin = value; }
        }

        public String TimeSec
        {
            get { return this._timeSec; }
            set { this._timeSec = value; }
        }

        public PHY2001U04GetNewOrderFormOUTArgs() { }

        public PHY2001U04GetNewOrderFormOUTArgs(String orderDate, String timeHour, String timeMin, String timeSec)
        {
            this._orderDate = orderDate;
            this._timeHour = timeHour;
            this._timeMin = timeMin;
            this._timeSec = timeSec;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04GetNewOrderFormOUTRequest();
        }
    }
}