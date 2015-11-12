using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroMakeDeptComboArgs : IContractArgs
    {

        public NuroMakeDeptComboArgs()
        {
            
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroMakeDeptComboRequest();
        }
    }
}
