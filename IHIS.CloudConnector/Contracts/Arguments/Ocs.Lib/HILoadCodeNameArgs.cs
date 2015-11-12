using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class HILoadCodeNameArgs : IContractArgs
	{
		private String _orderGubun;
		private String _specimenCode;
		private String _jusa;
		private String _pay;
		private String _orderGubunBas;
		private String _bogyongCode;
		private String _jusaSpdGubun;
		private String _jundalPartOut;
		private String _jundalPartInp;
		private String _ordDanui;
		private String _hangmogCode;

		public String OrderGubun
		{
			get { return this._orderGubun; }
			set { this._orderGubun = value; }
		}

		public String SpecimenCode
		{
			get { return this._specimenCode; }
			set { this._specimenCode = value; }
		}

		public String Jusa
		{
			get { return this._jusa; }
			set { this._jusa = value; }
		}

		public String Pay
		{
			get { return this._pay; }
			set { this._pay = value; }
		}

		public String OrderGubunBas
		{
			get { return this._orderGubunBas; }
			set { this._orderGubunBas = value; }
		}

		public String BogyongCode
		{
			get { return this._bogyongCode; }
			set { this._bogyongCode = value; }
		}

		public String JusaSpdGubun
		{
			get { return this._jusaSpdGubun; }
			set { this._jusaSpdGubun = value; }
		}

		public String JundalPartOut
		{
			get { return this._jundalPartOut; }
			set { this._jundalPartOut = value; }
		}

		public String JundalPartInp
		{
			get { return this._jundalPartInp; }
			set { this._jundalPartInp = value; }
		}

		public String OrdDanui
		{
			get { return this._ordDanui; }
			set { this._ordDanui = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public HILoadCodeNameArgs() { }

		public HILoadCodeNameArgs(String orderGubun, String specimenCode, String jusa, String pay, String orderGubunBas, String bogyongCode, String jusaSpdGubun, String jundalPartOut, String jundalPartInp, String ordDanui, String hangmogCode)
		{
			this._orderGubun = orderGubun;
			this._specimenCode = specimenCode;
			this._jusa = jusa;
			this._pay = pay;
			this._orderGubunBas = orderGubunBas;
			this._bogyongCode = bogyongCode;
			this._jusaSpdGubun = jusaSpdGubun;
			this._jundalPartOut = jundalPartOut;
			this._jundalPartInp = jundalPartInp;
			this._ordDanui = ordDanui;
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new HILoadCodeNameRequest();
		}
	}
}