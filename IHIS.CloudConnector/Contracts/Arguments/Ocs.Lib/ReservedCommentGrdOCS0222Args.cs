using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
    public class ReservedCommentGrdOCS0222Args : IContractArgs
    {
        private String _memb;
        private String _seq;

        public String Memb
        {
            get { return this._memb; }
            set { this._memb = value; }
        }

        public String Seq
        {
            get { return this._seq; }
            set { this._seq = value; }
        }

        public ReservedCommentGrdOCS0222Args() { }

        public ReservedCommentGrdOCS0222Args(String memb, String seq)
        {
            this._memb = memb;
            this._seq = seq;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ReservedCommentGrdOCS0222Request();
        }
    }
}