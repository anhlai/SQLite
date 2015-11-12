using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01GetTimerArgs : IContractArgs
	{
		private String _currentDate;

		public String CurrentDate
		{
			get { return this._currentDate; }
			set { this._currentDate = value; }
		}

		public DrgsDRG5100P01GetTimerArgs() { }

		public DrgsDRG5100P01GetTimerArgs(String currentDate)
		{
			this._currentDate = currentDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01GetTimerRequest();
		}
	}
}