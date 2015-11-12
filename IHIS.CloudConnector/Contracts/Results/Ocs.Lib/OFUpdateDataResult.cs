using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OFUpdateDataResult : AbstractContractResult
	{
		private Boolean _updateResult1;
		private Boolean _updateResult2;
		private Boolean _updateResult3;

		public Boolean UpdateResult1
		{
			get { return this._updateResult1; }
			set { this._updateResult1 = value; }
		}

		public Boolean UpdateResult2
		{
			get { return this._updateResult2; }
			set { this._updateResult2 = value; }
		}

		public Boolean UpdateResult3
		{
			get { return this._updateResult3; }
			set { this._updateResult3 = value; }
		}

		public OFUpdateDataResult() { }

	}
}