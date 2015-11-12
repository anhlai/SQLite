using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0204Q00GrdOCS0205Args : IContractArgs
	{
		private String _memb;
		private String _sangGubun;
		private String _sangNameInx;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String SangGubun
		{
			get { return this._sangGubun; }
			set { this._sangGubun = value; }
		}

		public String SangNameInx
		{
			get { return this._sangNameInx; }
			set { this._sangNameInx = value; }
		}

		public OCS0204Q00GrdOCS0205Args() { }

		public OCS0204Q00GrdOCS0205Args(String memb, String sangGubun, String sangNameInx)
		{
			this._memb = memb;
			this._sangGubun = sangGubun;
			this._sangNameInx = sangNameInx;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0204Q00GrdOCS0205Request();
		}
	}
}