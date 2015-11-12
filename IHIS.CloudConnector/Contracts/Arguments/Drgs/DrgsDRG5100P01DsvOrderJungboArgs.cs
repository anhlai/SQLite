using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01DsvOrderJungboArgs : IContractArgs
	{
		private String _jubsuDate;
		private String _drgBunho;

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

		public DrgsDRG5100P01DsvOrderJungboArgs() { }

		public DrgsDRG5100P01DsvOrderJungboArgs(String jubsuDate, String drgBunho)
		{
			this._jubsuDate = jubsuDate;
			this._drgBunho = drgBunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01DsvOrderJungboRequest();
		}
	}
}