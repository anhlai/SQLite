using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01UpdateDrgPackYNInDRG2010Args : IContractArgs
	{
		private String _drgPackYn;
		private String _fkocs1003;

		public String DrgPackYn
		{
			get { return this._drgPackYn; }
			set { this._drgPackYn = value; }
		}

		public String Fkocs1003
		{
			get { return this._fkocs1003; }
			set { this._fkocs1003 = value; }
		}

		public DrgsDRG5100P01UpdateDrgPackYNInDRG2010Args() { }

		public DrgsDRG5100P01UpdateDrgPackYNInDRG2010Args(String drgPackYn, String fkocs1003)
		{
			this._drgPackYn = drgPackYn;
			this._fkocs1003 = fkocs1003;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01UpdateDrgPackYNInDRG2010Request();
		}
	}
}