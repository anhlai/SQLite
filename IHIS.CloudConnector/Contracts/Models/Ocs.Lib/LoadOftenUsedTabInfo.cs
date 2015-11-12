using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class LoadOftenUsedTabInfo
	{
		private String _memb;
		private String _inputTab;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public LoadOftenUsedTabInfo() { }

		public LoadOftenUsedTabInfo(String memb, String inputTab)
		{
			this._memb = memb;
			this._inputTab = inputTab;
		}

	}
}