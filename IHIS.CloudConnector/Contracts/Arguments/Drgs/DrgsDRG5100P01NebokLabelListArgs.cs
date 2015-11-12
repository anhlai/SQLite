using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01NebokLabelListArgs : IContractArgs
	{
		private String _jubsuDate;
		private String _drgBunho;
		private String _bunho;

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

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public DrgsDRG5100P01NebokLabelListArgs() { }

		public DrgsDRG5100P01NebokLabelListArgs(String jubsuDate, String drgBunho, String bunho)
		{
			this._jubsuDate = jubsuDate;
			this._drgBunho = drgBunho;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01NebokLabelListRequest();
		}
	}
}