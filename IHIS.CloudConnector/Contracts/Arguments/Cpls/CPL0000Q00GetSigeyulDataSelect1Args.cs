using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00GetSigeyulDataSelect1Args : IContractArgs
	{
		private String _bunho;
		private String _userId;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public CPL0000Q00GetSigeyulDataSelect1Args() { }

		public CPL0000Q00GetSigeyulDataSelect1Args(String bunho, String userId)
		{
			this._bunho = bunho;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00GetSigeyulDataSelect1Request();
		}
	}
}