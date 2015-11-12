using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
    public class OcsoLoadCht0110Args : IContractArgs
    {
        private String _sangCode;
        private String _gijunDate;

        public String SangCode
        {
            get { return this._sangCode; }
            set { this._sangCode = value; }
        }

        public String GijunDate
        {
            get { return this._gijunDate; }
            set { this._gijunDate = value; }
        }

        public OcsoLoadCht0110Args() { }

        public OcsoLoadCht0110Args(String sangCode, String gijunDate)
        {
            this._sangCode = sangCode;
            this._gijunDate = gijunDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OcsoLoadCht0110Request();
        }
    }
}