using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311U00SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<OCS0311U00grdHangmogCodeListInfo> _grdHangMogList = new List<OCS0311U00grdHangmogCodeListInfo>();
        private List<OCS0311U00grdSetCodeListInfo> _grdSetCodeList = new List<OCS0311U00grdSetCodeListInfo>();
        private List<OCS0311U00grdSetHangmogListInfo> _grdSetHangMogList = new List<OCS0311U00grdSetHangmogListInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<OCS0311U00grdHangmogCodeListInfo> GrdHangMogList
        {
            get { return this._grdHangMogList; }
            set { this._grdHangMogList = value; }
        }

        public List<OCS0311U00grdSetCodeListInfo> GrdSetCodeList
        {
            get { return this._grdSetCodeList; }
            set { this._grdSetCodeList = value; }
        }

        public List<OCS0311U00grdSetHangmogListInfo> GrdSetHangMogList
        {
            get { return this._grdSetHangMogList; }
            set { this._grdSetHangMogList = value; }
        }

        public OCS0311U00SaveLayoutArgs() { }

        public OCS0311U00SaveLayoutArgs(String userId, List<OCS0311U00grdHangmogCodeListInfo> grdHangMogList, List<OCS0311U00grdSetCodeListInfo> grdSetCodeList, List<OCS0311U00grdSetHangmogListInfo> grdSetHangMogList)
        {
            this._userId = userId;
            this._grdHangMogList = grdHangMogList;
            this._grdSetCodeList = grdSetCodeList;
            this._grdSetHangMogList = grdSetHangMogList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311U00SaveLayoutRequest();
        }
    }
}