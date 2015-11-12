using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0110U00GrdJohapArgs : IContractArgs
    {
        private String _johapGubun;
        private String _johap;
        private String _startDate;

        public String JohapGubun
        {
            get { return this._johapGubun; }
            set { this._johapGubun = value; }
        }

        public String Johap
        {
            get { return this._johap; }
            set { this._johap = value; }
        }

        public String StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        public BAS0110U00GrdJohapArgs() { }

        public BAS0110U00GrdJohapArgs(String johapGubun, String johap, String startDate)
        {
            this._johapGubun = johapGubun;
            this._johap = johap;
            this._startDate = startDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0110U00GrdJohapRequest();
        }
    }
}