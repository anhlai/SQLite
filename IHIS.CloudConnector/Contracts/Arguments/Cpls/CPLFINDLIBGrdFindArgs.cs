using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPLFINDLIBGrdFindArgs : IContractArgs
	{
		private String _isExist;
		private String _resultForm;
		private String _find;
		private String _codeType;

		public String IsExist
		{
			get { return this._isExist; }
			set { this._isExist = value; }
		}

		public String ResultForm
		{
			get { return this._resultForm; }
			set { this._resultForm = value; }
		}

		public String Find
		{
			get { return this._find; }
			set { this._find = value; }
		}

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public CPLFINDLIBGrdFindArgs() { }

		public CPLFINDLIBGrdFindArgs(String isExist, String resultForm, String find, String codeType)
		{
			this._isExist = isExist;
			this._resultForm = resultForm;
			this._find = find;
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPLFINDLIBGrdFindRequest();
		}
	}
}