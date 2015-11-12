using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3020U02ResultMapGrdRsltArgs : IContractArgs
    {
        private String _jangbiCode;
        private String _resultDate;
        private String _sampleId;

        public String JangbiCode
        {
            get { return this._jangbiCode; }
            set { this._jangbiCode = value; }
        }

        public String ResultDate
        {
            get { return this._resultDate; }
            set { this._resultDate = value; }
        }

        public String SampleId
        {
            get { return this._sampleId; }
            set { this._sampleId = value; }
        }

        public CPL3020U02ResultMapGrdRsltArgs() { }

        public CPL3020U02ResultMapGrdRsltArgs(String jangbiCode, String resultDate, String sampleId)
        {
            this._jangbiCode = jangbiCode;
            this._resultDate = resultDate;
            this._sampleId = sampleId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3020U02ResultMapGrdRsltRequest();
        }
    }
}