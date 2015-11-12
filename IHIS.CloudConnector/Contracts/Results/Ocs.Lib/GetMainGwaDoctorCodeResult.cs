using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class GetMainGwaDoctorCodeResult : AbstractContractResult
	{
		private String _doctor;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public GetMainGwaDoctorCodeResult() { }

	}
}