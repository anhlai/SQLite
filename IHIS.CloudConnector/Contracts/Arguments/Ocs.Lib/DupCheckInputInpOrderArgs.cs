using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using DupCheckInputInpOrderRequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.DupCheckInputInpOrderRequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class DupCheckInputInpOrderArgs : IContractArgs
	{
		private DupCheckInputInpOrderRequestInfo _inputInfo;

		public DupCheckInputInpOrderRequestInfo InputInfo
		{
			get { return this._inputInfo; }
			set { this._inputInfo = value; }
		}

		public DupCheckInputInpOrderArgs() { }

		public DupCheckInputInpOrderArgs(DupCheckInputInpOrderRequestInfo inputInfo)
		{
			this._inputInfo = inputInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new DupCheckInputInpOrderRequest();
		}
	}
}