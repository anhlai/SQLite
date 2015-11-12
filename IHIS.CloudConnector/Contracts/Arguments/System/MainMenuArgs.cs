using System;
using IHIS.CloudConnector.Contracts.Models;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class MainMenuArgs : IContractArgs
    {
        private string _msgUserYn;
        private string _adminUserYn;

        public string MsgUserYn
        {
            get { return _msgUserYn; }
            set { _msgUserYn = value; }
        }

        public string AdminUserYn
        {
            get { return _adminUserYn; }
            set { _adminUserYn = value; }
        }

        public MainMenuArgs(String msgUserYn, String adminUserYn)
        {
            MsgUserYn = msgUserYn;
            AdminUserYn = adminUserYn;
        }

        public MainMenuArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new MainMenuRequest();
        }
    }
}