using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class FwPaCommentGrdCmmtFwkArgs : IContractArgs
    {
        private String _bunho;
        private String _cmmtGubun;
        private String _jundalTable;
        private String _jundalPart;
        private String _fkocs;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String CmmtGubun
        {
            get { return this._cmmtGubun; }
            set { this._cmmtGubun = value; }
        }

        public String JundalTable
        {
            get { return this._jundalTable; }
            set { this._jundalTable = value; }
        }

        public String JundalPart
        {
            get { return this._jundalPart; }
            set { this._jundalPart = value; }
        }

        public String Fkocs
        {
            get { return this._fkocs; }
            set { this._fkocs = value; }
        }

        public FwPaCommentGrdCmmtFwkArgs() { }

        public FwPaCommentGrdCmmtFwkArgs(String bunho, String cmmtGubun, String jundalTable, String jundalPart, String fkocs)
        {
            this._bunho = bunho;
            this._cmmtGubun = cmmtGubun;
            this._jundalTable = jundalTable;
            this._jundalPart = jundalPart;
            this._fkocs = fkocs;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.FwPaCommentGrdCmmtFwkRequest();
        }
    }
}