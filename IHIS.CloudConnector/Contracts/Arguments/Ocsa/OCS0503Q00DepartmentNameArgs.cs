using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503Q00DepartmentNameArgs : IContractArgs
	{
		private String _gwaCode;

		public String GwaCode
		{
			get { return this._gwaCode; }
			set { this._gwaCode = value; }
		}

		public OCS0503Q00DepartmentNameArgs() { }

		public OCS0503Q00DepartmentNameArgs(String gwaCode)
		{
			this._gwaCode = gwaCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503Q00DepartmentNameRequest();
		}
	}
}