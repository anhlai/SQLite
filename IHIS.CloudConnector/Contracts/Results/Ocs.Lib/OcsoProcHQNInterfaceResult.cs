using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OcsoProcHQNInterfaceResult : AbstractContractResult
	{
		private String _pkphy7401;
		private String _rtnIfsCnt;

		public String Pkphy7401
		{
			get { return this._pkphy7401; }
			set { this._pkphy7401 = value; }
		}

		public String RtnIfsCnt
		{
			get { return this._rtnIfsCnt; }
			set { this._rtnIfsCnt = value; }
		}

		public OcsoProcHQNInterfaceResult() { }

	}
}