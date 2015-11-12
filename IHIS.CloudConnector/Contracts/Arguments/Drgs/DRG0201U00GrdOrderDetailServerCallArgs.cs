using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0201U00GrdOrderDetailServerCallArgs : IContractArgs
	{
		private String _jubsuDate;
		private String _bunho;
		private String _drgBunho;

		public String JubsuDate
		{
			get { return this._jubsuDate; }
			set { this._jubsuDate = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String DrgBunho
		{
			get { return this._drgBunho; }
			set { this._drgBunho = value; }
		}

		public DRG0201U00GrdOrderDetailServerCallArgs() { }

		public DRG0201U00GrdOrderDetailServerCallArgs(String jubsuDate, String bunho, String drgBunho)
		{
			this._jubsuDate = jubsuDate;
			this._bunho = bunho;
			this._drgBunho = drgBunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0201U00GrdOrderDetailServerCallRequest();
		}
	}
}