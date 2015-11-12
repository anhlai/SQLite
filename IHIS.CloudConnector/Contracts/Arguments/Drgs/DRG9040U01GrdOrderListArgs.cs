using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG9040U01GrdOrderListArgs : IContractArgs
	{
		private String _jubsuDate;
		private String _drgBunho;
		private String _magamBunryu;

		public String JubsuDate
		{
			get { return this._jubsuDate; }
			set { this._jubsuDate = value; }
		}

		public String DrgBunho
		{
			get { return this._drgBunho; }
			set { this._drgBunho = value; }
		}

		public String MagamBunryu
		{
			get { return this._magamBunryu; }
			set { this._magamBunryu = value; }
		}

		public DRG9040U01GrdOrderListArgs() { }

		public DRG9040U01GrdOrderListArgs(String jubsuDate, String drgBunho, String magamBunryu)
		{
			this._jubsuDate = jubsuDate;
			this._drgBunho = drgBunho;
			this._magamBunryu = magamBunryu;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG9040U01GrdOrderListRequest();
		}
	}
}