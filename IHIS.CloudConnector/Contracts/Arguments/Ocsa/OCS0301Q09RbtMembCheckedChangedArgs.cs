using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0301Q09RbtMembCheckedChangedArgs : IContractArgs
	{
		private String _code;
		private String _id;
		private String _m0300;
		private String _m0301;
		private String _directPath;
		private String _rbtName;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public String Id
		{
			get { return this._id; }
			set { this._id = value; }
		}

		public String M0300
		{
			get { return this._m0300; }
			set { this._m0300 = value; }
		}

		public String M0301
		{
			get { return this._m0301; }
			set { this._m0301 = value; }
		}

		public String DirectPath
		{
			get { return this._directPath; }
			set { this._directPath = value; }
		}

		public String RbtName
		{
			get { return this._rbtName; }
			set { this._rbtName = value; }
		}

		public OCS0301Q09RbtMembCheckedChangedArgs() { }

		public OCS0301Q09RbtMembCheckedChangedArgs(String code, String id, String m0300, String m0301, String directPath, String rbtName)
		{
			this._code = code;
			this._id = id;
			this._m0300 = m0300;
			this._m0301 = m0301;
			this._directPath = directPath;
			this._rbtName = rbtName;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0301Q09RbtMembCheckedChangedRequest();
		}
	}
}