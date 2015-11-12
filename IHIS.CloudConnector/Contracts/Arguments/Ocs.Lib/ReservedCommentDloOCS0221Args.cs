using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
    public class ReservedCommentDloOCS0221Args : IContractArgs
    {
        private String _memb;
        private String _categoryGubun;

        public String Memb
        {
            get { return this._memb; }
            set { this._memb = value; }
        }

        public String CategoryGubun
        {
            get { return this._categoryGubun; }
            set { this._categoryGubun = value; }
        }

        public ReservedCommentDloOCS0221Args() { }

        public ReservedCommentDloOCS0221Args(String memb, String categoryGubun)
        {
            this._memb = memb;
            this._categoryGubun = categoryGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ReservedCommentDloOCS0221Request();
        }
    }
}