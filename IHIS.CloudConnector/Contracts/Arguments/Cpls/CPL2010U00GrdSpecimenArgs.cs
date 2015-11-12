using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00GrdSpecimenArgs : IContractArgs
    {
        private String _mJubsuYn;
        private String _orderDate;
        private String _bunho;
        private String _gwa;
        private String _orderTime;
        private String _doctor;
        private String _reserDate;
        private String _jubsuDate;
        private String _jubsuTime;
        private String _jubsuja;
        private String _groupSer;
        private String _reserYn;
        private String _emergencyYn;

        public String MJubsuYn
        {
            get { return this._mJubsuYn; }
            set { this._mJubsuYn = value; }
        }

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String OrderTime
        {
            get { return this._orderTime; }
            set { this._orderTime = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String ReserDate
        {
            get { return this._reserDate; }
            set { this._reserDate = value; }
        }

        public String JubsuDate
        {
            get { return this._jubsuDate; }
            set { this._jubsuDate = value; }
        }

        public String JubsuTime
        {
            get { return this._jubsuTime; }
            set { this._jubsuTime = value; }
        }

        public String Jubsuja
        {
            get { return this._jubsuja; }
            set { this._jubsuja = value; }
        }

        public String GroupSer
        {
            get { return this._groupSer; }
            set { this._groupSer = value; }
        }

        public String ReserYn
        {
            get { return this._reserYn; }
            set { this._reserYn = value; }
        }

        public String EmergencyYn
        {
            get { return this._emergencyYn; }
            set { this._emergencyYn = value; }
        }

        public CPL2010U00GrdSpecimenArgs() { }

        public CPL2010U00GrdSpecimenArgs(String mJubsuYn, String orderDate, String bunho, String gwa, String orderTime, String doctor, String reserDate, String jubsuDate, String jubsuTime, String jubsuja, String groupSer, String reserYn, String emergencyYn)
        {
            this._mJubsuYn = mJubsuYn;
            this._orderDate = orderDate;
            this._bunho = bunho;
            this._gwa = gwa;
            this._orderTime = orderTime;
            this._doctor = doctor;
            this._reserDate = reserDate;
            this._jubsuDate = jubsuDate;
            this._jubsuTime = jubsuTime;
            this._jubsuja = jubsuja;
            this._groupSer = groupSer;
            this._reserYn = reserYn;
            this._emergencyYn = emergencyYn;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00GrdSpecimenRequest();
        }
    }
}