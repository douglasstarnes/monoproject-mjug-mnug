using System;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using System.IO;
using System.Net;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace twitter
{
	public class TwitterDataSource : UITableViewDataSource
	{

		public TwitterDataSource ()
		{

		}

		public override int RowsInSection (UITableView tableView, int section)
		{
			return TwitterData.GetObject().Tweets.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = new UITableViewCell(UITableViewCellStyle.Default, "TweetCell");
			cell.TextLabel.LineBreakMode = UILineBreakMode.WordWrap;
			cell.TextLabel.Lines = 0;
			cell.TextLabel.Font = UIFont.FromName("Arial", 16.0f);
			cell.TextLabel.Text = TwitterData.GetObject().Tweets[indexPath.Row];
			return cell;
		}
	}
}

