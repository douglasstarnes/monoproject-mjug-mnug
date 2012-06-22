using System;
using System.IO;
using System.Net;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace twitter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var search_term = args[0];
	
			WebRequest request = WebRequest.Create(String.Format("http://search.twitter.com/search.json?q=%40{0}", search_term));
			request.Method = "GET";
			WebResponse response = request.GetResponse();
			Stream data = response.GetResponseStream();
			StreamReader reader = new StreamReader(data);
			string dataFromServer = reader.ReadToEnd();
			
			JObject myObj = (JObject)JsonConvert.DeserializeObject(dataFromServer);
			foreach (var result in myObj["results"])
			{
				Console.WriteLine(result["text"]);	
				Console.WriteLine();
			}
			reader.Close();
			data.Close();
			response.Close();
		}
	}
}

