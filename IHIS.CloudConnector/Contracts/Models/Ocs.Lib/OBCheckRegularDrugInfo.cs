using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class OBCheckRegularDrugInfo
	{
		private String _suryang;
		private String _danui;
		private String _dv;
		private String _dvTime;
		private String _jusa;
		private String _bogyongCode;

		public String Suryang
		{
			get { return this._suryang; }
			set { this._suryang = value; }
		}

		public String Danui
		{
			get { return this._danui; }
			set { this._danui = value; }
		}

		public String Dv
		{
			get { return this._dv; }
			set { this._dv = value; }
		}

		public String DvTime
		{
			get { return this._dvTime; }
			set { this._dvTime = value; }
		}

		public String Jusa
		{
			get { return this._jusa; }
			set { this._jusa = value; }
		}

		public String BogyongCode
		{
			get { return this._bogyongCode; }
			set { this._bogyongCode = value; }
		}

		public OBCheckRegularDrugInfo() { }

		public OBCheckRegularDrugInfo(String suryang, String danui, String dv, String dvTime, String jusa, String bogyongCode)
		{
			this._suryang = suryang;
			this._danui = danui;
			this._dv = dv;
			this._dvTime = dvTime;
			this._jusa = jusa;
			this._bogyongCode = bogyongCode;
		}

	}
}