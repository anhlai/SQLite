using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01CheckUsedSangArgs : IContractArgs
	{
		private String _fkOutSang;
		private String _dataKubun;

		public String FkOutSang
		{
			get { return this._fkOutSang; }
			set { this._fkOutSang = value; }
		}

		public String DataKubun
		{
			get { return this._dataKubun; }
			set { this._dataKubun = value; }
		}

		public OcsoOCS1003P01CheckUsedSangArgs() { }

		public OcsoOCS1003P01CheckUsedSangArgs(String fkOutSang, String dataKubun)
		{
			this._fkOutSang = fkOutSang;
			this._dataKubun = dataKubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01CheckUsedSangRequest();
		}
	}
}