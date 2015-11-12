using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503U00GetFindWorkerArgs : IContractArgs
	{
		private String _findMode;
		private String _refCode;
		private String _naewonDate;
		private String _mInOutGubun;

		public String FindMode
		{
			get { return this._findMode; }
			set { this._findMode = value; }
		}

		public String RefCode
		{
			get { return this._refCode; }
			set { this._refCode = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String MInOutGubun
		{
			get { return this._mInOutGubun; }
			set { this._mInOutGubun = value; }
		}

		public OCS0503U00GetFindWorkerArgs() { }

		public OCS0503U00GetFindWorkerArgs(String findMode, String refCode, String naewonDate, String mInOutGubun)
		{
			this._findMode = findMode;
			this._refCode = refCode;
			this._naewonDate = naewonDate;
			this._mInOutGubun = mInOutGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503U00GetFindWorkerRequest();
		}
	}
}