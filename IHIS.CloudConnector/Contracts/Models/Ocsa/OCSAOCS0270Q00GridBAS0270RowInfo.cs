using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocsa
{
	public class OCSAOCS0270Q00GridBAS0270RowInfo
	{
		private String _doctor;
		private String _doctorName;
		private String _contKey;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String DoctorName
		{
			get { return this._doctorName; }
			set { this._doctorName = value; }
		}

		public String ContKey
		{
			get { return this._contKey; }
			set { this._contKey = value; }
		}

		public OCSAOCS0270Q00GridBAS0270RowInfo() { }

		public OCSAOCS0270Q00GridBAS0270RowInfo(String doctor, String doctorName, String contKey)
		{
			this._doctor = doctor;
			this._doctorName = doctorName;
			this._contKey = contKey;
		}

	}
}