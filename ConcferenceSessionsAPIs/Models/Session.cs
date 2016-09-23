using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ConcferenceSessionsAPIs
{
	public class Session
	{
		/*ObservableCollection<Session> _SessionsList;
		public event PropertyChangedEventHandler PropertyChanged;
		public ObservableCollection<Session> SessionsList
		{
			get { return _SessionsList; }
			set
			{
				_SessionsList = value;
				if (PropertyChanged != null)
				{
					PropertyChanged(this,
									new PropertyChangedEventArgs("SessionsList"));
				}
			}
		}
		public string SessionTitle { get; set; }

		string _SessionDescription;
		public string SessionDescription
		{
			get
			{
				return _SessionDescription;
			}
			set
			{
				_SessionDescription = value;
			}
		}

		public Session()
		{
			SessionTitle = "default session";
			SessionDescription = "default session description";
		}

		public override string ToString()
		{
			return string.Format("[Session: SessionTitle={0}, SessionDescription={1}]", SessionTitle, SessionDescription);
		}*/

		public string SessionTitle { get; set; }
		public string SessionDescription { get; set; }
		public string SessionType { get; set; }
		public string SessionPicture { get; set; }
		public string SessionStrategy { get; set; }
		public string SessionLocation { get; set; }

		public Session()
		{
		}


	}
}
