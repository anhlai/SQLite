using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using GetJundaPartAndTableRequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetJundaPartAndTableRequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetJundaPartAndTableArgs : IContractArgs
	{
		private GetJundaPartAndTableRequestInfo _inputInfo;

		public GetJundaPartAndTableRequestInfo InputInfo
		{
			get { return this._inputInfo; }
			set { this._inputInfo = value; }
		}

		public GetJundaPartAndTableArgs() { }

		public GetJundaPartAndTableArgs(GetJundaPartAndTableRequestInfo inputInfo)
		{
			this._inputInfo = inputInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetJundaPartAndTableRequest();
		}
	}
}