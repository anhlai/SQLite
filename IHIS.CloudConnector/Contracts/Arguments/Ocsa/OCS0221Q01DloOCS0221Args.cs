using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0221Q01DloOCS0221Args : IContractArgs
	{
		private String _categoryGubun;
		private String _memb;

		public String CategoryGubun
		{
			get { return this._categoryGubun; }
			set { this._categoryGubun = value; }
		}

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public OCS0221Q01DloOCS0221Args() { }

		public OCS0221Q01DloOCS0221Args(String categoryGubun, String memb)
		{
			this._categoryGubun = categoryGubun;
			this._memb = memb;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0221Q01DloOCS0221Request();
		}
	}
}