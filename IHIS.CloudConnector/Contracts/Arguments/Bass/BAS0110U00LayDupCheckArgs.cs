using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0110U00LayDupCheckArgs : IContractArgs
    {
        private String _gubun;
        private String _startDate;
        private String _johap;

        public String Gubun
        {
            get { return this._gubun; }
            set { this._gubun = value; }
        }

        public String StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        public String Johap
        {
            get { return this._johap; }
            set { this._johap = value; }
        }

        public BAS0110U00LayDupCheckArgs() { }

        public BAS0110U00LayDupCheckArgs(String gubun, String startDate, String johap)
        {
            this._gubun = gubun;
            this._startDate = startDate;
            this._johap = johap;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0110U00LayDupCheckRequest();
        }
    }
}