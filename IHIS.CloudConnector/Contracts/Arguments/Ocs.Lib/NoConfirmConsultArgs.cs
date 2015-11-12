using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using NoConfirmConsultInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.NoConfirmConsultInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class NoConfirmConsultArgs : IContractArgs
	{
		private NoConfirmConsultInfo _consultInfo;

		public NoConfirmConsultInfo ConsultInfo
		{
			get { return this._consultInfo; }
			set { this._consultInfo = value; }
		}

		public NoConfirmConsultArgs() { }

		public NoConfirmConsultArgs(NoConfirmConsultInfo consultInfo)
		{
			this._consultInfo = consultInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new NoConfirmConsultRequest();
		}
	}
}