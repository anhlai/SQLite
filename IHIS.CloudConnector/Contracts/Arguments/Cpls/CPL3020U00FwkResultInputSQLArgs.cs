using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U00FwkResultInputSQLArgs : IContractArgs
	{
		private String _dummy;
		private String _find1;
		private String _resultForm;
		private String _codeType;

		public String Dummy
		{
			get { return this._dummy; }
			set { this._dummy = value; }
		}

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public String ResultForm
		{
			get { return this._resultForm; }
			set { this._resultForm = value; }
		}

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public CPL3020U00FwkResultInputSQLArgs() { }

		public CPL3020U00FwkResultInputSQLArgs(String dummy, String find1, String resultForm, String codeType)
		{
			this._dummy = dummy;
			this._find1 = find1;
			this._resultForm = resultForm;
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U00FwkResultInputSQLRequest();
		}
	}
}