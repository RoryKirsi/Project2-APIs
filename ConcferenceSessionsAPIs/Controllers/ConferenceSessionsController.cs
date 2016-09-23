using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ConcferenceSessionsAPIs.Controllers
{
	public class ConferenceSessionsController : ApiController
	{
		/*
		List<Session> sessions =
		   new List<Session>(
			   new Session[]
		{
			new Session { SessionTitle = "Microsoft", SessionDescription = "Azure!" },
			new Session { SessionTitle = "Google", SessionDescription = "Android!" },
			new Session { SessionTitle = "Facebook", SessionDescription = "Waht's App!" },
			new Session { SessionTitle = "IBM", SessionDescription = "Watson!" }
		});
			
		public List<Session> GetAll()
		{
			return sessions;
		}

		public Session GetSession(string id)
		{
			var session = sessions.FirstOrDefault((p) => p.SessionTitle == id);
			return session;
		}

*/

				static List<Session> sessions =
	new List<Session>(
					new Session[]
						{
			new Session { SessionTitle = "Fathom Dwellers", 
				SessionDescription = "Deep within the hungering chasms of the Great Sea, swarms of Fathom Dwellers sway like a great floating carpet, sightlessly in the dark.", 
				SessionType = "Fathom Dwellers", 
				SessionStrategy = "To obtain it you have to unlock a World Quest, which is complicated and involves clicking orbs at various places around the Broken Isles. See the comments section for Kosumoth the Hungering on Wowhead for the details. Killing Kosumoth the Hungering without unlocking the quest will not award you the mount.",
				SessionPicture = "Pic_0.jpg",
				SessionLocation = "LocPic_0.png"},
			new Session { SessionTitle = "Llothien Prowler", 
				SessionDescription = "These sleek foxes can prowl amongst newly-fallen leaves without making a sound, even at this size.", 
				SessionType = "Foxes", 
				SessionStrategy = "This sleek fox is a reward for the quest Volpin the Elusive in Suramar.", 
				SessionPicture = "Pic_1.jpg", 
				SessionLocation = "LocPic_1.png"},
			new Session { SessionTitle = "Ashes of Al'ar", 
				SessionDescription = "Al'ar was the beloved pet of Kael'thas Sunstrider, who often boasted that death would never claim it. Perhaps he was right.", 
				SessionType = "Phoenixes", 
				SessionStrategy = "Kael'thas Sunstrider in The Eye, Tempest Keep.", 
				SessionPicture = "Pic_2.jpg", 
				SessionLocation = "LocPic_2.png"},
			new Session { SessionTitle = "Steelbound Devourer",
				SessionDescription = "Only the sturdiest-forged chains can restrain this beast.",
				SessionType = "Core Hounds",
				SessionStrategy = "This fel-green version of the Core Hound is our first ever blacksmith-crafted mount - obviously the blacksmith just makes the restraining harness, not the core hound!",
				SessionPicture ="Pic_3.jpg",
				SessionLocation = "LocPic_3.png"}
						}

				 );

		public ConferenceSessionsController()
		{


		}
		public List<Session> GetAll()
		{
			return sessions;
		}

		public Session GetSession(string id)
		{
			var session = sessions.FirstOrDefault((p) => p.SessionTitle == id);
			return session;
		}


		public IHttpActionResult GetSessionByDescription(string SessionDescription)
		{
			var session = sessions.FirstOrDefault((p) => p.SessionDescription == SessionDescription);
			if (session == null)
			{
				return NotFound();
			}
			return Ok(session);
		}

		public Session PostSession(Session session)
		{
			sessions.Add(session);
			return session;
		}


	}
}
