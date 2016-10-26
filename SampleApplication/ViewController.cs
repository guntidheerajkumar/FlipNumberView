using System;
using FlipNumberView;
using CoreGraphics;
using Foundation;
using UIKit;

namespace SampleApplication
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var flipView = new JTNumberScrollAnimatedView();
			flipView.TextColor = UIColor.Red;
			flipView.Duration = 1.0f;
			flipView.MinLength = 4;
			flipView.Font = UIFont.SystemFontOfSize(20);
			flipView.Value = NSNumber.FromDouble(259);
			flipView.Frame = new CGRect(10, 60, this.View.Frame.Width - 20, 100);
			flipView.StartAnimation();
			this.View.AddSubview(flipView);
		}
	}
}
