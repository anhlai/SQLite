using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    [Serializable]
    public class NuroNUR2001U04DepartmentListArgs : IContractArgs
    {
        private string _comingDate;

        public string ComingDate
        {
            get { return _comingDate; }
            set { _comingDate = value; }
        }

        public NuroNUR2001U04DepartmentListArgs(string comingDate)
        {
            _comingDate = comingDate;
        }

        public NuroNUR2001U04DepartmentListArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroNUR2001U04DepartmentListRequest();
        }
    }
}
