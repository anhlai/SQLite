using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0113Q00GrdCHT0113Args : IContractArgs
	{
		private String _disabilityName;
		private String _date;

		public String DisabilityName
		{
			get { return this._disabilityName; }
			set { this._disabilityName = value; }
		}

		public String Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public CHT0113Q00GrdCHT0113Args() { }

		public CHT0113Q00GrdCHT0113Args(String disabilityName, String date)
		{
			this._disabilityName = disabilityName;
			this._date = date;
		}

		public IExtensible GetRequestInstance()
		{
			return new CHT0113Q00GrdCHT0113Request();
		}
	}
}