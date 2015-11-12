using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OUT0101Q01GrdPatientListArgs : IContractArgs
	{
		private String _hospCode;
		private String _suname2;
		private String _sex;
		private String _birth;
		private String _tel;

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public String Suname2
		{
			get { return this._suname2; }
			set { this._suname2 = value; }
		}

		public String Sex
		{
			get { return this._sex; }
			set { this._sex = value; }
		}

		public String Birth
		{
			get { return this._birth; }
			set { this._birth = value; }
		}

		public String Tel
		{
			get { return this._tel; }
			set { this._tel = value; }
		}

		public OUT0101Q01GrdPatientListArgs() { }

		public OUT0101Q01GrdPatientListArgs(String hospCode, String suname2, String sex, String birth, String tel)
		{
			this._hospCode = hospCode;
			this._suname2 = suname2;
			this._sex = sex;
			this._birth = birth;
			this._tel = tel;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUT0101Q01GrdPatientListRequest();
		}
	}
}