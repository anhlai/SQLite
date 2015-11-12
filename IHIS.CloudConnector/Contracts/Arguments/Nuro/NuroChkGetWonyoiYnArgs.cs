using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroChkGetWonyoiYnArgs : IContractArgs
	{
		private String _gubun;
		private String _gongbiCode1;
		private String _gongbiCode2;
		private String _gongbiCode3;
		private String _gongbiCode4;

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String GongbiCode1
		{
			get { return this._gongbiCode1; }
			set { this._gongbiCode1 = value; }
		}

		public String GongbiCode2
		{
			get { return this._gongbiCode2; }
			set { this._gongbiCode2 = value; }
		}

		public String GongbiCode3
		{
			get { return this._gongbiCode3; }
			set { this._gongbiCode3 = value; }
		}

		public String GongbiCode4
		{
			get { return this._gongbiCode4; }
			set { this._gongbiCode4 = value; }
		}

		public NuroChkGetWonyoiYnArgs() { }

		public NuroChkGetWonyoiYnArgs(String gubun, String gongbiCode1, String gongbiCode2, String gongbiCode3, String gongbiCode4)
		{
			this._gubun = gubun;
			this._gongbiCode1 = gongbiCode1;
			this._gongbiCode2 = gongbiCode2;
			this._gongbiCode3 = gongbiCode3;
			this._gongbiCode4 = gongbiCode4;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroChkGetWonyoiYnRequest();
		}
	}
}