using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class RES1001U00FrmModifyReserGrdRES1001Args : IContractArgs
	{
		private String _doctor;
		private String _dayOfWeek;
		private String _date;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String DayOfWeek
		{
			get { return this._dayOfWeek; }
			set { this._dayOfWeek = value; }
		}

		public String Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public RES1001U00FrmModifyReserGrdRES1001Args() { }

		public RES1001U00FrmModifyReserGrdRES1001Args(String doctor, String dayOfWeek, String date)
		{
			this._doctor = doctor;
			this._dayOfWeek = dayOfWeek;
			this._date = date;
		}

		public IExtensible GetRequestInstance()
		{
			return new RES1001U00FrmModifyReserGrdRES1001Request();
		}
	}
}