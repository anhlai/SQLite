using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class HILoadCodeNameInfo
	{
		private String _orderGubunName;
		private String _specimenName;
		private String _jusaName;
		private String _payName;
		private String _bogyongName;
		private String _jundalPartOutName;
		private String _jundalPartInpName;
		private String _ordDanuiName;
		private String _mayakYn;

		public String OrderGubunName
		{
			get { return this._orderGubunName; }
			set { this._orderGubunName = value; }
		}

		public String SpecimenName
		{
			get { return this._specimenName; }
			set { this._specimenName = value; }
		}

		public String JusaName
		{
			get { return this._jusaName; }
			set { this._jusaName = value; }
		}

		public String PayName
		{
			get { return this._payName; }
			set { this._payName = value; }
		}

		public String BogyongName
		{
			get { return this._bogyongName; }
			set { this._bogyongName = value; }
		}

		public String JundalPartOutName
		{
			get { return this._jundalPartOutName; }
			set { this._jundalPartOutName = value; }
		}

		public String JundalPartInpName
		{
			get { return this._jundalPartInpName; }
			set { this._jundalPartInpName = value; }
		}

		public String OrdDanuiName
		{
			get { return this._ordDanuiName; }
			set { this._ordDanuiName = value; }
		}

		public String MayakYn
		{
			get { return this._mayakYn; }
			set { this._mayakYn = value; }
		}

		public HILoadCodeNameInfo() { }

		public HILoadCodeNameInfo(String orderGubunName, String specimenName, String jusaName, String payName, String bogyongName, String jundalPartOutName, String jundalPartInpName, String ordDanuiName, String mayakYn)
		{
			this._orderGubunName = orderGubunName;
			this._specimenName = specimenName;
			this._jusaName = jusaName;
			this._payName = payName;
			this._bogyongName = bogyongName;
			this._jundalPartOutName = jundalPartOutName;
			this._jundalPartInpName = jundalPartInpName;
			this._ordDanuiName = ordDanuiName;
			this._mayakYn = mayakYn;
		}

	}
}