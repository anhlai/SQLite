using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
	public class PHY0001U00GrdOCS0132Args : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public PHY0001U00GrdOCS0132Args() { }

		public PHY0001U00GrdOCS0132Args(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new PHY0001U00GrdOCS0132Request();
		}
	}
}