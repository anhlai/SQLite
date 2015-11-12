using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class GetDefaultOrdDanuiInfo
	{
		private String _ordDanui;
		private String _codeName;

		public String OrdDanui
		{
			get { return this._ordDanui; }
			set { this._ordDanui = value; }
		}

		public String CodeName
		{
			get { return this._codeName; }
			set { this._codeName = value; }
		}

		public GetDefaultOrdDanuiInfo() { }

		public GetDefaultOrdDanuiInfo(String ordDanui, String codeName)
		{
			this._ordDanui = ordDanui;
			this._codeName = codeName;
		}

	}
}