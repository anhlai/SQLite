using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00LayChkNamesArgs : IContractArgs
    {
        private String _bunho;
        private String _reserDate;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String ReserDate
        {
            get { return this._reserDate; }
            set { this._reserDate = value; }
        }

        public CPL2010U00LayChkNamesArgs() { }

        public CPL2010U00LayChkNamesArgs(String bunho, String reserDate)
        {
            this._bunho = bunho;
            this._reserDate = reserDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00LayChkNamesRequest();
        }
    }
}