using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00ReservationOut0123UpdateArgs : IContractArgs
	{
		private String _userId;
		private String _reserComment;
		private String _reserType;
		private String _patientCode;
		private String _pkout1001;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String ReserComment
		{
			get { return this._reserComment; }
			set { this._reserComment = value; }
		}

		public String ReserType
		{
			get { return this._reserType; }
			set { this._reserType = value; }
		}

		public String PatientCode
		{
			get { return this._patientCode; }
			set { this._patientCode = value; }
		}

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public NuroRES1001U00ReservationOut0123UpdateArgs() { }

		public NuroRES1001U00ReservationOut0123UpdateArgs(String userId, String reserComment, String reserType, String patientCode, String pkout1001)
		{
			this._userId = userId;
			this._reserComment = reserComment;
			this._reserType = reserType;
			this._patientCode = patientCode;
			this._pkout1001 = pkout1001;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00ReservationOut0123UpdateRequest();
		}
	}
}