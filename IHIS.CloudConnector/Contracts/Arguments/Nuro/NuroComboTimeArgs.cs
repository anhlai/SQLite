using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroComboTimeArgs : IContractArgs
    {
        private string _codeType;
        public NuroComboTimeArgs()
        {
            
        }
        public NuroComboTimeArgs(string codeType)
        {
            CodeType = codeType;
        }

        public string CodeType
        {
            get { return _codeType; }
            set { _codeType = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroComboTimeRequest();
        }
    }
}
