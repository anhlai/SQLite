using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using DupCheckCPLOrder1RequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.DupCheckCPLOrder1RequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class DupCheckCPLOrder1Args : IContractArgs
	{
		private DupCheckCPLOrder1RequestInfo _inputInfo;

		public DupCheckCPLOrder1RequestInfo InputInfo
		{
			get { return this._inputInfo; }
			set { this._inputInfo = value; }
		}

		public DupCheckCPLOrder1Args() { }

		public DupCheckCPLOrder1Args(DupCheckCPLOrder1RequestInfo inputInfo)
		{
			this._inputInfo = inputInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new DupCheckCPLOrder1Request();
		}
	}
}