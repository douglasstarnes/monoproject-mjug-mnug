using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace twitter
{
	public class TwitterData
	{
		public List<string> Tweets;

		private static TwitterData theObject = null;

		private TwitterData ()
		{
			Tweets = new List<string>();
			Tweets.Add("Demo");
		}

		public static TwitterData GetObject() 
		{
			if (theObject == null)
				theObject = new TwitterData();
			return theObject;
		}

		public void RefreshTweets(string search_term)
		{
			Tweets.Clear ();

			WebRequest request = WebRequest.Create(string.Format("http://search.twitter.com/search.json?q=%40{0}", search_term));
			request.Method = "GET";
			WebResponse response = request.GetResponse();
			Stream data = response.GetResponseStream();
			StreamReader reader = new StreamReader(data);
			string dataFromServer = reader.ReadToEnd();

			JObject myObject = (JObject)JsonConvert.DeserializeObject(dataFromServer);
			foreach (var result in myObject["results"])
			{
				Tweets.Add (result["text"].ToString ());
			}

			reader.Close();
			data.Close();
			response.Close();
		}
	}
}

