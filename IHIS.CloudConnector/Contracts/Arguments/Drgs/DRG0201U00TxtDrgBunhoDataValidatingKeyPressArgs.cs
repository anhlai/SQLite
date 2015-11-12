using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0201U00TxtDrgBunhoDataValidatingKeyPressArgs : IContractArgs
	{
		private String _jubsuDate;
		private String _bunho;

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

		public DRG0201U00TxtDrgBunhoDataValidatingKeyPressArgs() { }

		public DRG0201U00TxtDrgBunhoDataValidatingKeyPressArgs(String jubsuDate, String bunho)
		{
			this._jubsuDate = jubsuDate;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0201U00TxtDrgBunhoDataValidatingKeyPressRequest();
		}
	}
}