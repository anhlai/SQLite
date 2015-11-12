using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroInspectionOrderGetTelArgs : IContractArgs
    {
        private String _reserDate;

        public String ReserDate
        {
            get { return this._reserDate; }
            set { this._reserDate = value; }
        }

        public NuroInspectionOrderGetTelArgs() { }

        public NuroInspectionOrderGetTelArgs(String reserDate)
        {
            this._reserDate = reserDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroInspectionOrderGetTelRequest();
        }
    }
}