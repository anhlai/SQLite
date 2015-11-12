using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00LayBarcodeTemp2Args : IContractArgs
    {
        private String _specimentSer;

        public String SpecimentSer
        {
            get { return this._specimentSer; }
            set { this._specimentSer = value; }
        }

        public CPL2010U00LayBarcodeTemp2Args() { }

        public CPL2010U00LayBarcodeTemp2Args(String specimentSer)
        {
            this._specimentSer = specimentSer;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00LayBarcodeTemp2Request();
        }
    }
}