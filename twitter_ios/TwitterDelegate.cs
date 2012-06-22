using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;


namespace twitter
{
	public class TwitterDelegate : UITableViewDelegate
	{
		public TwitterDelegate ()
		{
		}

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 100.0f;
		}
	}
}

