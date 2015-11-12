using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04InsertVitalArgs : IContractArgs
    {
        private String _userId;
        private String _bunho;
        private String _measureDate;
        private String _measureTime;
        private String _bpTo;
        private String _bpFrom;
        private String _pulse;
        private String _bt;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String MeasureDate
        {
            get { return this._measureDate; }
            set { this._measureDate = value; }
        }

        public String MeasureTime
        {
            get { return this._measureTime; }
            set { this._measureTime = value; }
        }

        public String BpTo
        {
            get { return this._bpTo; }
            set { this._bpTo = value; }
        }

        public String BpFrom
        {
            get { return this._bpFrom; }
            set { this._bpFrom = value; }
        }

        public String Pulse
        {
            get { return this._pulse; }
            set { this._pulse = value; }
        }

        public String Bt
        {
            get { return this._bt; }
            set { this._bt = value; }
        }

        public PHY2001U04InsertVitalArgs() { }

        public PHY2001U04InsertVitalArgs(String userId, String bunho, String measureDate, String measureTime, String bpTo, String bpFrom, String pulse, String bt)
        {
            this._userId = userId;
            this._bunho = bunho;
            this._measureDate = measureDate;
            this._measureTime = measureTime;
            this._bpTo = bpTo;
            this._bpFrom = bpFrom;
            this._pulse = pulse;
            this._bt = bt;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04InsertVitalRequest();
        }
    }
}