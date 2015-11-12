using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0117grdCHT0117CheckArgs : IContractArgs
	{
		private String _buwi;

		public String Buwi
		{
			get { return this._buwi; }
			set { this._buwi = value; }
		}

		public CHT0117grdCHT0117CheckArgs() { }

		public CHT0117grdCHT0117CheckArgs(String buwi)
		{
			this._buwi = buwi;
		}

		public IExtensible GetRequestInstance()
		{
			return new CHT0117grdCHT0117CheckRequest();
		}
	}
}