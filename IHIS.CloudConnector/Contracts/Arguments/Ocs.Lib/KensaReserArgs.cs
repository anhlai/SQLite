using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using KensaReserInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.KensaReserInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class KensaReserArgs : IContractArgs
	{
		private KensaReserInfo _reserInfo;

		public KensaReserInfo ReserInfo
		{
			get { return this._reserInfo; }
			set { this._reserInfo = value; }
		}

		public KensaReserArgs() { }

		public KensaReserArgs(KensaReserInfo reserInfo)
		{
			this._reserInfo = reserInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new KensaReserRequest();
		}
	}
}