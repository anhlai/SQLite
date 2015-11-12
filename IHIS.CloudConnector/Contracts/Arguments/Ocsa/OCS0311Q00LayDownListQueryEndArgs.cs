using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311Q00LayDownListQueryEndArgs : IContractArgs
    {
        private List<OCS0311Q00LayDownListQueryEndReqInfo> _layDownReqItem = new List<OCS0311Q00LayDownListQueryEndReqInfo>();

        public List<OCS0311Q00LayDownListQueryEndReqInfo> LayDownReqItem
        {
            get { return this._layDownReqItem; }
            set { this._layDownReqItem = value; }
        }

        public OCS0311Q00LayDownListQueryEndArgs() { }

        public OCS0311Q00LayDownListQueryEndArgs(List<OCS0311Q00LayDownListQueryEndReqInfo> layDownReqItem)
        {
            this._layDownReqItem = layDownReqItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311Q00LayDownListQueryEndRequest();
        }
    }
}