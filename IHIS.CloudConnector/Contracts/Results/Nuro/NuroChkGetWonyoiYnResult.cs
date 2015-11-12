using System;

namespace IHIS.CloudConnector.Contracts.Results.Nuro
{
	public class NuroChkGetWonyoiYnResult : AbstractContractResult
	{
		private String _wonyoiYn;

		public String WonyoiYn
		{
			get { return this._wonyoiYn; }
			set { this._wonyoiYn = value; }
		}

		public NuroChkGetWonyoiYnResult() { }

	}
}