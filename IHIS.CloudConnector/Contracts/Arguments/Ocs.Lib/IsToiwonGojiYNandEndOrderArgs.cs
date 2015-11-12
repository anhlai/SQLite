using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using IsToiwonGojiYNandEndOrderRequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.IsToiwonGojiYNandEndOrderRequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class IsToiwonGojiYNandEndOrderArgs : IContractArgs
	{
		private IsToiwonGojiYNandEndOrderRequestInfo _inputInfo;

		public IsToiwonGojiYNandEndOrderRequestInfo InputInfo
		{
			get { return this._inputInfo; }
			set { this._inputInfo = value; }
		}

		public IsToiwonGojiYNandEndOrderArgs() { }

		public IsToiwonGojiYNandEndOrderArgs(IsToiwonGojiYNandEndOrderRequestInfo inputInfo)
		{
			this._inputInfo = inputInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new IsToiwonGojiYNandEndOrderRequest();
		}
	}
}