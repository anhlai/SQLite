using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using IsResultToConsultRequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.IsResultToConsultRequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class IsResultToConsultArgs : IContractArgs
	{
		private IsResultToConsultRequestInfo _inputInfo;

		public IsResultToConsultRequestInfo InputInfo
		{
			get { return this._inputInfo; }
			set { this._inputInfo = value; }
		}

		public IsResultToConsultArgs() { }

		public IsResultToConsultArgs(IsResultToConsultRequestInfo inputInfo)
		{
			this._inputInfo = inputInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new IsResultToConsultRequest();
		}
	}
}