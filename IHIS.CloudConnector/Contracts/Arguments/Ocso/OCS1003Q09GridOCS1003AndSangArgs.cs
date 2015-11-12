using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003Q09GridOCS1003AndSangArgs : IContractArgs
	{
		private String _grdsangBunho;
		private String _grdsangNaewonDate;
		private String _grdsangGwa;
		private String _grdsangDoctor;
		private String _grdsangNaewonType;
		private String _grdsangJubsuNo;
		private String _grdsangIoGubun;
		private String _grdocs1003Bunho;
		private String _grdocs1003NaewonDate;
		private String _grdocs1003Gwa;
		private String _grdocs1003Doctor;
		private String _grdocs1003NaewonType;
		private String _grdocs1003InputGubun;
		private String _grdocs1003TelYn;
		private String _grdocs1003InputTab;
		private String _grdocs1003JubsuNo;
		private String _grdocs1003PkOrder;
		private String _grdocs1003GenericYn;
		private String _grdocs1003Kijun;
		private String _grdocs1003IoGubun;

		public String GrdsangBunho
		{
			get { return this._grdsangBunho; }
			set { this._grdsangBunho = value; }
		}

		public String GrdsangNaewonDate
		{
			get { return this._grdsangNaewonDate; }
			set { this._grdsangNaewonDate = value; }
		}

		public String GrdsangGwa
		{
			get { return this._grdsangGwa; }
			set { this._grdsangGwa = value; }
		}

		public String GrdsangDoctor
		{
			get { return this._grdsangDoctor; }
			set { this._grdsangDoctor = value; }
		}

		public String GrdsangNaewonType
		{
			get { return this._grdsangNaewonType; }
			set { this._grdsangNaewonType = value; }
		}

		public String GrdsangJubsuNo
		{
			get { return this._grdsangJubsuNo; }
			set { this._grdsangJubsuNo = value; }
		}

		public String GrdsangIoGubun
		{
			get { return this._grdsangIoGubun; }
			set { this._grdsangIoGubun = value; }
		}

		public String Grdocs1003Bunho
		{
			get { return this._grdocs1003Bunho; }
			set { this._grdocs1003Bunho = value; }
		}

		public String Grdocs1003NaewonDate
		{
			get { return this._grdocs1003NaewonDate; }
			set { this._grdocs1003NaewonDate = value; }
		}

		public String Grdocs1003Gwa
		{
			get { return this._grdocs1003Gwa; }
			set { this._grdocs1003Gwa = value; }
		}

		public String Grdocs1003Doctor
		{
			get { return this._grdocs1003Doctor; }
			set { this._grdocs1003Doctor = value; }
		}

		public String Grdocs1003NaewonType
		{
			get { return this._grdocs1003NaewonType; }
			set { this._grdocs1003NaewonType = value; }
		}

		public String Grdocs1003InputGubun
		{
			get { return this._grdocs1003InputGubun; }
			set { this._grdocs1003InputGubun = value; }
		}

		public String Grdocs1003TelYn
		{
			get { return this._grdocs1003TelYn; }
			set { this._grdocs1003TelYn = value; }
		}

		public String Grdocs1003InputTab
		{
			get { return this._grdocs1003InputTab; }
			set { this._grdocs1003InputTab = value; }
		}

		public String Grdocs1003JubsuNo
		{
			get { return this._grdocs1003JubsuNo; }
			set { this._grdocs1003JubsuNo = value; }
		}

		public String Grdocs1003PkOrder
		{
			get { return this._grdocs1003PkOrder; }
			set { this._grdocs1003PkOrder = value; }
		}

		public String Grdocs1003GenericYn
		{
			get { return this._grdocs1003GenericYn; }
			set { this._grdocs1003GenericYn = value; }
		}

		public String Grdocs1003Kijun
		{
			get { return this._grdocs1003Kijun; }
			set { this._grdocs1003Kijun = value; }
		}

		public String Grdocs1003IoGubun
		{
			get { return this._grdocs1003IoGubun; }
			set { this._grdocs1003IoGubun = value; }
		}

		public OCS1003Q09GridOCS1003AndSangArgs() { }

		public OCS1003Q09GridOCS1003AndSangArgs(String grdsangBunho, String grdsangNaewonDate, String grdsangGwa, String grdsangDoctor, String grdsangNaewonType, String grdsangJubsuNo, String grdsangIoGubun, String grdocs1003Bunho, String grdocs1003NaewonDate, String grdocs1003Gwa, String grdocs1003Doctor, String grdocs1003NaewonType, String grdocs1003InputGubun, String grdocs1003TelYn, String grdocs1003InputTab, String grdocs1003JubsuNo, String grdocs1003PkOrder, String grdocs1003GenericYn, String grdocs1003Kijun, String grdocs1003IoGubun)
		{
			this._grdsangBunho = grdsangBunho;
			this._grdsangNaewonDate = grdsangNaewonDate;
			this._grdsangGwa = grdsangGwa;
			this._grdsangDoctor = grdsangDoctor;
			this._grdsangNaewonType = grdsangNaewonType;
			this._grdsangJubsuNo = grdsangJubsuNo;
			this._grdsangIoGubun = grdsangIoGubun;
			this._grdocs1003Bunho = grdocs1003Bunho;
			this._grdocs1003NaewonDate = grdocs1003NaewonDate;
			this._grdocs1003Gwa = grdocs1003Gwa;
			this._grdocs1003Doctor = grdocs1003Doctor;
			this._grdocs1003NaewonType = grdocs1003NaewonType;
			this._grdocs1003InputGubun = grdocs1003InputGubun;
			this._grdocs1003TelYn = grdocs1003TelYn;
			this._grdocs1003InputTab = grdocs1003InputTab;
			this._grdocs1003JubsuNo = grdocs1003JubsuNo;
			this._grdocs1003PkOrder = grdocs1003PkOrder;
			this._grdocs1003GenericYn = grdocs1003GenericYn;
			this._grdocs1003Kijun = grdocs1003Kijun;
			this._grdocs1003IoGubun = grdocs1003IoGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003Q09GridOCS1003AndSangRequest();
		}
	}
}