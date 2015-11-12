using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroOUT0101U02GetTypeArgs : IContractArgs
	{
		private String _johapGubun;
		private String _find1;

		public String JohapGubun
		{
			get { return this._johapGubun; }
			set { this._johapGubun = value; }
		}

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public NuroOUT0101U02GetTypeArgs() { }

		public NuroOUT0101U02GetTypeArgs(String johapGubun, String find1)
		{
			this._johapGubun = johapGubun;
			this._find1 = find1;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroOUT0101U02GetTypeRequest();
		}
	}
}