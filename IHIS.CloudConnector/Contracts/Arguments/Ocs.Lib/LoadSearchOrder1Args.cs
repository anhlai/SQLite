using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
    public class LoadSearchOrder1Args : IContractArgs
    {
        private LoadSearchOrder1RequestInfo _inputInfo;
        private String _bunho;

        public LoadSearchOrder1RequestInfo InputInfo
        {
            get { return this._inputInfo; }
            set { this._inputInfo = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public LoadSearchOrder1Args() { }

        public LoadSearchOrder1Args(LoadSearchOrder1RequestInfo inputInfo, String bunho)
        {
            this._inputInfo = inputInfo;
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.LoadSearchOrder1Request();
        }
    }
}