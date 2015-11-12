using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroNUR2001U04ComingStatusUpdateArgs : IContractArgs
    {
        private string _comingStatus;
        private string _pkout1001;

        public string ComingStatus
        {
            get { return _comingStatus; }
            set { _comingStatus = value; }
        }

        public string Pkout1001
        {
            get { return _pkout1001; }
            set { _pkout1001 = value; }
        }

        public NuroNUR2001U04ComingStatusUpdateArgs(string comingStatus, string pkout1001)
        {
            _comingStatus = comingStatus;
            _pkout1001 = pkout1001;
        }

        public NuroNUR2001U04ComingStatusUpdateArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroNUR2001U04ComingStatusUpdateRequest();
        }
    }
}
