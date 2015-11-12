using System;

namespace IHIS.CloudConnector.Contracts.Models.Clis
{
    public class CLIS2015U04GetProtocolItemInfo
    {
        private String _clisProtocolId;
        private String _protocolCode;
        private String _protocolName;
        private String _startDate;
        private String _endDate;

        public String ClisProtocolId
        {
            get { return this._clisProtocolId; }
            set { this._clisProtocolId = value; }
        }

        public String ProtocolCode
        {
            get { return this._protocolCode; }
            set { this._protocolCode = value; }
        }

        public String ProtocolName
        {
            get { return this._protocolName; }
            set { this._protocolName = value; }
        }

        public String StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        public String EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        public CLIS2015U04GetProtocolItemInfo() { }

        public CLIS2015U04GetProtocolItemInfo(String clisProtocolId, String protocolCode, String protocolName, String startDate, String endDate)
        {
            this._clisProtocolId = clisProtocolId;
            this._protocolCode = protocolCode;
            this._protocolName = protocolName;
            this._startDate = startDate;
            this._endDate = endDate;
        }

    }
}