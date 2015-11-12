using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
	public class PHY8002U00PrintArgs : IContractArgs
	{
		private String _gwa;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public PHY8002U00PrintArgs() { }

		public PHY8002U00PrintArgs(String gwa)
		{
			this._gwa = gwa;
		}

		public IExtensible GetRequestInstance()
		{
			return new PHY8002U00PrintRequest();
		}
	}
}