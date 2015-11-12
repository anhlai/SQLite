using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using IpwonReserStatusInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.IpwonReserStatusInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class IpwonReserStatusArgs : IContractArgs
	{
		private IpwonReserStatusInfo _reserStatusInfo;

		public IpwonReserStatusInfo ReserStatusInfo
		{
			get { return this._reserStatusInfo; }
			set { this._reserStatusInfo = value; }
		}

		public IpwonReserStatusArgs() { }

		public IpwonReserStatusArgs(IpwonReserStatusInfo reserStatusInfo)
		{
			this._reserStatusInfo = reserStatusInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new IpwonReserStatusRequest();
		}
	}
}