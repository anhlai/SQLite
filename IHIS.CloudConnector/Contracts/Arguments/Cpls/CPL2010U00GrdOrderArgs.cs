using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00GrdOrderArgs : IContractArgs
    {
        private String _bunho;
        private String _mijubsu;
        private String _reserYn;
        private String _fromDate;
        private String _toDate;
        private String _doctor;
        private String _emergencyYn;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String Mijubsu
        {
            get { return this._mijubsu; }
            set { this._mijubsu = value; }
        }

        public String ReserYn
        {
            get { return this._reserYn; }
            set { this._reserYn = value; }
        }

        public String FromDate
        {
            get { return this._fromDate; }
            set { this._fromDate = value; }
        }

        public String ToDate
        {
            get { return this._toDate; }
            set { this._toDate = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String EmergencyYn
        {
            get { return this._emergencyYn; }
            set { this._emergencyYn = value; }
        }

        public CPL2010U00GrdOrderArgs() { }

        public CPL2010U00GrdOrderArgs(String bunho, String mijubsu, String reserYn, String fromDate, String toDate, String doctor, String emergencyYn)
        {
            this._bunho = bunho;
            this._mijubsu = mijubsu;
            this._reserYn = reserYn;
            this._fromDate = fromDate;
            this._toDate = toDate;
            this._doctor = doctor;
            this._emergencyYn = emergencyYn;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00GrdOrderRequest();
        }
    }
}