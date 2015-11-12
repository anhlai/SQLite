using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class GetFindWorkerResponseInfo
	{
		private String _code;
		private String _name;
		private String _value1;
		private String _value2;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public String Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		public String Value1
		{
			get { return this._value1; }
			set { this._value1 = value; }
		}

		public String Value2
		{
			get { return this._value2; }
			set { this._value2 = value; }
		}

		public GetFindWorkerResponseInfo() { }

		public GetFindWorkerResponseInfo(String code, String name, String value1, String value2)
		{
			this._code = code;
			this._name = name;
			this._value1 = value1;
			this._value2 = value2;
		}

	}
}