using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class IpwonReserStatusResult : AbstractContractResult
	{
		private String _retValue;

		public String RetValue
		{
			get { return this._retValue; }
			set { this._retValue = value; }
		}

		public IpwonReserStatusResult() { }

	}
}