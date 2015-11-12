using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class GetBogyongInfo3Result : AbstractContractResult
	{
		private String _bogyongName;
		private String _nvl;

		public String BogyongName
		{
			get { return this._bogyongName; }
			set { this._bogyongName = value; }
		}

		public String Nvl
		{
			get { return this._nvl; }
			set { this._nvl = value; }
		}

		public GetBogyongInfo3Result() { }

	}
}