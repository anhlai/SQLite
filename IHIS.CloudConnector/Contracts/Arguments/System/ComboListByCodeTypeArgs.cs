using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class ComboListByCodeTypeArgs : IContractArgs
    {
        private string _codeType;
        private bool _isAll;

        public string CodeType
        {
            get { return _codeType; }
            set { _codeType = value; }
        }

        public bool IsAll
        {
            get { return _isAll; }
            set { _isAll = value; }
        }

        public ComboListByCodeTypeArgs(string codeType, bool isAll)
        {
            _codeType = codeType;
            _isAll = isAll;
        }

        public ComboListByCodeTypeArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new ComboListByCodeTypeRequest();
        }
    }
}
