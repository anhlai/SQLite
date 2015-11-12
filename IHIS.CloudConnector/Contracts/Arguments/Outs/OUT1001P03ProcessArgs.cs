using System;
using IHIS.CloudConnector.Contracts.Models.Outs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Outs
{
    public class OUT1001P03ProcessArgs : IContractArgs
    {
        private String _fromBunho;
        private String _toBunho;
        private String _userId;
        private List<OUT1001P03ProcessInfo> _pkKeyInfo = new List<OUT1001P03ProcessInfo>();

        public String FromBunho
        {
            get { return this._fromBunho; }
            set { this._fromBunho = value; }
        }

        public String ToBunho
        {
            get { return this._toBunho; }
            set { this._toBunho = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<OUT1001P03ProcessInfo> PkKeyInfo
        {
            get { return this._pkKeyInfo; }
            set { this._pkKeyInfo = value; }
        }

        public OUT1001P03ProcessArgs() { }

        public OUT1001P03ProcessArgs(String fromBunho, String toBunho, String userId, List<OUT1001P03ProcessInfo> pkKeyInfo)
        {
            this._fromBunho = fromBunho;
            this._toBunho = toBunho;
            this._userId = userId;
            this._pkKeyInfo = pkKeyInfo;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OUT1001P03ProcessRequest();
        }
    }
}