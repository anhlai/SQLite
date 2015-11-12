using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class UpdateJubsuDataArgs : IContractArgs
    {
        private List<UpdateJubsuDataInfo> _dataInfo = new List<UpdateJubsuDataInfo>();
        private Boolean _isOrca;
        private String _orcaGigwanCode;

        public List<UpdateJubsuDataInfo> DataInfo
        {
            get { return this._dataInfo; }
            set { this._dataInfo = value; }
        }

        public Boolean IsOrca
        {
            get { return this._isOrca; }
            set { this._isOrca = value; }
        }

        public String OrcaGigwanCode
        {
            get { return this._orcaGigwanCode; }
            set { this._orcaGigwanCode = value; }
        }

        public UpdateJubsuDataArgs() { }

        public UpdateJubsuDataArgs(List<UpdateJubsuDataInfo> dataInfo, Boolean isOrca, String orcaGigwanCode)
        {
            this._dataInfo = dataInfo;
            this._isOrca = isOrca;
            this._orcaGigwanCode = orcaGigwanCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.UpdateJubsuDataRequest();
        }
    }
}