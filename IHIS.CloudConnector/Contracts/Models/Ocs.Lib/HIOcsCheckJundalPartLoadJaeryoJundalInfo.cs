using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class HIOcsCheckJundalPartLoadJaeryoJundalInfo
	{
		private String _checkJundal;
		private String _loadJaeryoJundal;

		public String CheckJundal
		{
			get { return this._checkJundal; }
			set { this._checkJundal = value; }
		}

		public String LoadJaeryoJundal
		{
			get { return this._loadJaeryoJundal; }
			set { this._loadJaeryoJundal = value; }
		}

		public HIOcsCheckJundalPartLoadJaeryoJundalInfo() { }

		public HIOcsCheckJundalPartLoadJaeryoJundalInfo(String checkJundal, String loadJaeryoJundal)
		{
			this._checkJundal = checkJundal;
			this._loadJaeryoJundal = loadJaeryoJundal;
		}

	}
}