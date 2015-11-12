using System;

namespace IHIS.CloudConnector.Contracts.Results.Nuro
{
	public class NuroGetLastGubunResult : AbstractContractResult
	{
		private String _retValue;

		public String RetValue
		{
			get { return this._retValue; }
			set { this._retValue = value; }
		}

		public NuroGetLastGubunResult() { }

	}
}