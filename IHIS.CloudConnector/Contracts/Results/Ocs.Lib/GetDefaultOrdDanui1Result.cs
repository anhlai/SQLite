using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class GetDefaultOrdDanui1Result : AbstractContractResult
	{
		private String _ordDanui;

		public String OrdDanui
		{
			get { return this._ordDanui; }
			set { this._ordDanui = value; }
		}

		public GetDefaultOrdDanui1Result() { }

	}
}