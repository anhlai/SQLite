using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANSGrdOutSangArgs : IContractArgs
    {
        private String _hospCode;
        private String _bunho;
        private String _ioGubun;
        private String _gijunDate;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public String GijunDate
        {
            get { return this._gijunDate; }
            set { this._gijunDate = value; }
        }

        public ORDERTRANSGrdOutSangArgs() { }

        public ORDERTRANSGrdOutSangArgs(String hospCode, String bunho, String ioGubun, String gijunDate)
        {
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._ioGubun = ioGubun;
            this._gijunDate = gijunDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANSGrdOutSangRequest();
        }
    }
}