using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace FlipNumberView
{
	// @interface JTNumberScrollAnimatedView : UIView
	[BaseType(typeof(UIView))]
	interface JTNumberScrollAnimatedView
	{
		// @property (nonatomic, strong) NSNumber * value;
		[Export("value", ArgumentSemantic.Strong)]
		NSNumber Value { get; set; }

		// @property (nonatomic, strong) UIColor * textColor;
		[Export("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic, strong) UIFont * font;
		[Export("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (assign, nonatomic) CFTimeInterval duration;
		[Export("duration")]
		double Duration { get; set; }

		// @property (assign, nonatomic) CFTimeInterval durationOffset;
		[Export("durationOffset")]
		double DurationOffset { get; set; }

		// @property (assign, nonatomic) NSUInteger density;
		[Export("density")]
		nuint Density { get; set; }

		// @property (assign, nonatomic) NSUInteger minLength;
		[Export("minLength")]
		nuint MinLength { get; set; }

		// @property (assign, nonatomic) BOOL isAscending;
		[Export("isAscending")]
		bool IsAscending { get; set; }

		// -(void)startAnimation;
		[Export("startAnimation")]
		void StartAnimation();

		// -(void)stopAnimation;
		[Export("stopAnimation")]
		void StopAnimation();
	}
}
