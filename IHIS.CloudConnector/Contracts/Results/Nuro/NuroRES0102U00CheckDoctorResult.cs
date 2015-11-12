using System;

namespace IHIS.CloudConnector.Contracts.Results.Nuro
{
	public class NuroRES0102U00CheckDoctorResult : AbstractContractResult
	{
		private String _check;

		public String Check
		{
			get { return this._check; }
			set { this._check = value; }
		}

		public NuroRES0102U00CheckDoctorResult() { }

	}
}