using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class OUT1001R01GrdListArgs : IContractArgs
    {
        private String _bunho;
        private String _naewonDate;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String NaewonDate
        {
            get { return this._naewonDate; }
            set { this._naewonDate = value; }
        }

        public OUT1001R01GrdListArgs() { }

        public OUT1001R01GrdListArgs(String bunho, String naewonDate)
        {
            this._bunho = bunho;
            this._naewonDate = naewonDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OUT1001R01GrdListRequest();
        }
    }
}