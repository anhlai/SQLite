using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01DsvOrderPrintArgs : IContractArgs
	{
		private String _ioGobun;
		private String _jubsuDate;
		private String _drgBunho;

		public String IoGobun
		{
			get { return this._ioGobun; }
			set { this._ioGobun = value; }
		}

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

		public DrgsDRG5100P01DsvOrderPrintArgs() { }

		public DrgsDRG5100P01DsvOrderPrintArgs(String ioGobun, String jubsuDate, String drgBunho)
		{
			this._ioGobun = ioGobun;
			this._jubsuDate = jubsuDate;
			this._drgBunho = drgBunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01DsvOrderPrintRequest();
		}
	}
}