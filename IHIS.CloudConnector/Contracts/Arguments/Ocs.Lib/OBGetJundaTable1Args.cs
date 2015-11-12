using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OBGetJundaTable1Args : IContractArgs
	{
		private String _hangmogCode;
		private String _ioGubun;
		private String _jundalPart;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String JundalPart
		{
			get { return this._jundalPart; }
			set { this._jundalPart = value; }
		}

		public OBGetJundaTable1Args() { }

		public OBGetJundaTable1Args(String hangmogCode, String ioGubun, String jundalPart)
		{
			this._hangmogCode = hangmogCode;
			this._ioGubun = ioGubun;
			this._jundalPart = jundalPart;
		}

		public IExtensible GetRequestInstance()
		{
			return new OBGetJundaTable1Request();
		}
	}
}