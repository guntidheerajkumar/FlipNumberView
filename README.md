# Flip Number View

> FlipNumberView generates random number and displays in flip view fashion

```
var flipView = new JTNumberScrollAnimatedView();
flipView.TextColor = UIColor.Red;
flipView.Duration = 1.0f;
flipView.MinLength = 4;
flipView.Font = UIFont.SystemFontOfSize(20);
flipView.Value = NSNumber.FromDouble(259);
flipView.Frame = new CGRect(10, 60, this.View.Frame.Width - 20, 100);
flipView.StartAnimation();
this.View.AddSubview(flipView);
```


###Output

![](https://github.com/guntidheerajkumar/FlipNumberView/blob/master/FlipViewOutput.gif)
