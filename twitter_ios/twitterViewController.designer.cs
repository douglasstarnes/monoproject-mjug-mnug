// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace twitter
{
	[Register ("twitterViewController")]
	partial class twitterViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField search_term { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView results { get; set; }

		[Action ("search:")]
		partial void search (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (search_term != null) {
				search_term.Dispose ();
				search_term = null;
			}

			if (results != null) {
				results.Dispose ();
				results = null;
			}
		}
	}
}
