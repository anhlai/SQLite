using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0310U00layGroupGubunCheckArgs : IContractArgs
	{
		private String _sgCode;

		public String SgCode
		{
			get { return this._sgCode; }
			set { this._sgCode = value; }
		}

		public BAS0310U00layGroupGubunCheckArgs() { }

		public BAS0310U00layGroupGubunCheckArgs(String sgCode)
		{
			this._sgCode = sgCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0310U00layGroupGubunCheckRequest();
		}
	}
}