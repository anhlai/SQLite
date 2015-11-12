using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00InsertCPLTEMPArgs : IContractArgs
	{
		private String _userId;
		private String _i;
		private String _hangmogCode;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String I
		{
			get { return this._i; }
			set { this._i = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public CPL0000Q00InsertCPLTEMPArgs() { }

		public CPL0000Q00InsertCPLTEMPArgs(String userId, String i, String hangmogCode)
		{
			this._userId = userId;
			this._i = i;
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00InsertCPLTEMPRequest();
		}
	}
}