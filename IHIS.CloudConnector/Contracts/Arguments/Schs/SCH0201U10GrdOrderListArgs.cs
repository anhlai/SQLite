using System;
using IHIS.CloudConnector.Contracts.Models.Schs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
    public class SCH0201U10GrdOrderListArgs : IContractArgs
    {
        private String _bunho;
        private String _reserDate;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String ReserDate
        {
            get { return this._reserDate; }
            set { this._reserDate = value; }
        }

        public SCH0201U10GrdOrderListArgs() { }

        public SCH0201U10GrdOrderListArgs(String bunho, String reserDate)
        {
            this._bunho = bunho;
            this._reserDate = reserDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.SCH0201U10GrdOrderListRequest();
        }
    }
}