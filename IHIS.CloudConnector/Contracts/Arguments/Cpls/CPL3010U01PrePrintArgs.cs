using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3010U01PrePrintArgs : IContractArgs
    {
        private String _iraiStr;
        private String _uitakCode;

        public String IraiStr
        {
            get { return this._iraiStr; }
            set { this._iraiStr = value; }
        }

        public String UitakCode
        {
            get { return this._uitakCode; }
            set { this._uitakCode = value; }
        }

        public CPL3010U01PrePrintArgs() { }

        public CPL3010U01PrePrintArgs(String iraiStr, String uitakCode)
        {
            this._iraiStr = iraiStr;
            this._uitakCode = uitakCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3010U01PrePrintRequest();
        }
    }
}