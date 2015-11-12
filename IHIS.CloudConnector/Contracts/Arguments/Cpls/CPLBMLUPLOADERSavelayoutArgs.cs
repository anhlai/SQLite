using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPLBMLUPLOADERSavelayoutArgs : IContractArgs
    {
        private List<CPLBMLUPLOADERSavelayoutInfo> _uploaderSavelayoutInfo = new List<CPLBMLUPLOADERSavelayoutInfo>();

        public List<CPLBMLUPLOADERSavelayoutInfo> UploaderSavelayoutInfo
        {
            get { return this._uploaderSavelayoutInfo; }
            set { this._uploaderSavelayoutInfo = value; }
        }

        public CPLBMLUPLOADERSavelayoutArgs() { }

        public CPLBMLUPLOADERSavelayoutArgs(List<CPLBMLUPLOADERSavelayoutInfo> uploaderSavelayoutInfo)
        {
            this._uploaderSavelayoutInfo = uploaderSavelayoutInfo;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPLBMLUPLOADERSavelayoutRequest();
        }
    }
}