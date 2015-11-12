using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using DupCheckCPLOrder2RequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.DupCheckCPLOrder2RequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class DupCheckCPLOrder2Args : IContractArgs
	{
		private DupCheckCPLOrder2RequestInfo _inputInfo;

		public DupCheckCPLOrder2RequestInfo InputInfo
		{
			get { return this._inputInfo; }
			set { this._inputInfo = value; }
		}

		public DupCheckCPLOrder2Args() { }

		public DupCheckCPLOrder2Args(DupCheckCPLOrder2RequestInfo inputInfo)
		{
			this._inputInfo = inputInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new DupCheckCPLOrder2Request();
		}
	}
}