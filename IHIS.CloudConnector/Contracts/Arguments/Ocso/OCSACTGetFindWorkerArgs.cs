using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTGetFindWorkerArgs : IContractArgs
    {
        private String _colName;
        private String _arg1;

        public String ColName
        {
            get { return this._colName; }
            set { this._colName = value; }
        }

        public String Arg1
        {
            get { return this._arg1; }
            set { this._arg1 = value; }
        }

        public OCSACTGetFindWorkerArgs() { }

        public OCSACTGetFindWorkerArgs(String colName, String arg1)
        {
            this._colName = colName;
            this._arg1 = arg1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTGetFindWorkerRequest();
        }
    }
}