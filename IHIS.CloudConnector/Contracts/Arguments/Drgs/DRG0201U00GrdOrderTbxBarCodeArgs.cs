using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0201U00GrdOrderTbxBarCodeArgs : IContractArgs
	{
		private String _orerDate;
		private String _drgBunho;

		public String OrerDate
		{
			get { return this._orerDate; }
			set { this._orerDate = value; }
		}

		public String DrgBunho
		{
			get { return this._drgBunho; }
			set { this._drgBunho = value; }
		}

		public DRG0201U00GrdOrderTbxBarCodeArgs() { }

		public DRG0201U00GrdOrderTbxBarCodeArgs(String orerDate, String drgBunho)
		{
			this._orerDate = orerDate;
			this._drgBunho = drgBunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0201U00GrdOrderTbxBarCodeRequest();
		}
	}
}