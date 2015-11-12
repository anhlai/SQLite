using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using DupCheckInputOutOrderInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.DupCheckInputOutOrderInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class DupCheckInputOutOrderArgs : IContractArgs
	{
		private DupCheckInputOutOrderInfo _outOrderInfo;

		public DupCheckInputOutOrderInfo OutOrderInfo
		{
			get { return this._outOrderInfo; }
			set { this._outOrderInfo = value; }
		}

		public DupCheckInputOutOrderArgs() { }

		public DupCheckInputOutOrderArgs(DupCheckInputOutOrderInfo outOrderInfo)
		{
			this._outOrderInfo = outOrderInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new DupCheckInputOutOrderRequest();
		}
	}
}