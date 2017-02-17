using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

using Foundation;
using UIKit;

namespace FormsInternationlization.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			var language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
			//language = "de"; change to see diff labels for de language
			var file = @"Assets/Language_" + language + ".txt";
			var path = Path.Combine(Directory.GetCurrentDirectory(), file);
			var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
			Multilanguage.LoadDictionary(stream);

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
