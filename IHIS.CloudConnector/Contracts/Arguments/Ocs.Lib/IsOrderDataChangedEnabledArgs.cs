using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using IsOrderDataChangedEnabledRequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.IsOrderDataChangedEnabledRequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class IsOrderDataChangedEnabledArgs : IContractArgs
	{
		private IsOrderDataChangedEnabledRequestInfo _inputInfo;

		public IsOrderDataChangedEnabledRequestInfo InputInfo
		{
			get { return this._inputInfo; }
			set { this._inputInfo = value; }
		}

		public IsOrderDataChangedEnabledArgs() { }

		public IsOrderDataChangedEnabledArgs(IsOrderDataChangedEnabledRequestInfo inputInfo)
		{
			this._inputInfo = inputInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new IsOrderDataChangedEnabledRequest();
		}
	}
}