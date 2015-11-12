using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503U00CreateTimeComboArgs : IContractArgs
	{
		private String _doctor;
		private String _date;
		private String _intweek;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public String Intweek
		{
			get { return this._intweek; }
			set { this._intweek = value; }
		}

		public OCS0503U00CreateTimeComboArgs() { }

		public OCS0503U00CreateTimeComboArgs(String doctor, String date, String intweek)
		{
			this._doctor = doctor;
			this._date = date;
			this._intweek = intweek;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503U00CreateTimeComboRequest();
		}
	}
}