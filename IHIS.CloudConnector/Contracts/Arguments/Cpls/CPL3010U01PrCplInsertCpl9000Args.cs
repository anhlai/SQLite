using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3010U01PrCplInsertCpl9000Args : IContractArgs
    {
        private String _userId;
        private List<CPL3010U01PrCplInsertCpl9000Info> _prCplLst = new List<CPL3010U01PrCplInsertCpl9000Info>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<CPL3010U01PrCplInsertCpl9000Info> PrCplLst
        {
            get { return this._prCplLst; }
            set { this._prCplLst = value; }
        }

        public CPL3010U01PrCplInsertCpl9000Args() { }

        public CPL3010U01PrCplInsertCpl9000Args(String userId, List<CPL3010U01PrCplInsertCpl9000Info> prCplLst)
        {
            this._userId = userId;
            this._prCplLst = prCplLst;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3010U01PrCplInsertCpl9000Request();
        }
    }
}