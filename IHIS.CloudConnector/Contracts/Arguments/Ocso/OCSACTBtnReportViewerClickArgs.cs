using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTBtnReportViewerClickArgs : IContractArgs
    {
        private String _jundalPart;

        public String JundalPart
        {
            get { return this._jundalPart; }
            set { this._jundalPart = value; }
        }

        public OCSACTBtnReportViewerClickArgs() { }

        public OCSACTBtnReportViewerClickArgs(String jundalPart)
        {
            this._jundalPart = jundalPart;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTBtnReportViewerClickRequest();
        }
    }
}