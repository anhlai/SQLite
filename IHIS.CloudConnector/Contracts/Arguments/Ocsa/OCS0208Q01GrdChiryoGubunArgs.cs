using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0208Q01GrdChiryoGubunArgs : IContractArgs
	{
		private String _bogyongGubun;
		private String _jaeryoCode;
		private String _useYn;

		public String BogyongGubun
		{
			get { return this._bogyongGubun; }
			set { this._bogyongGubun = value; }
		}

		public String JaeryoCode
		{
			get { return this._jaeryoCode; }
			set { this._jaeryoCode = value; }
		}

		public String UseYn
		{
			get { return this._useYn; }
			set { this._useYn = value; }
		}

		public OCS0208Q01GrdChiryoGubunArgs() { }

		public OCS0208Q01GrdChiryoGubunArgs(String bogyongGubun, String jaeryoCode, String useYn)
		{
			this._bogyongGubun = bogyongGubun;
			this._jaeryoCode = jaeryoCode;
			this._useYn = useYn;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0208Q01GrdChiryoGubunRequest();
		}
	}
}