using System.Web;
using System.Web.Optimization;

namespace signalrwebrtc
{
	public class BundleConfig
	{
		// Paketleme hakkında daha fazla bilgi için lütfen https://go.microsoft.com/fwlink/?LinkId=301862 adresini ziyaret edin
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			// Geliştirme yapmak ve öğrenme kaynağı olarak yararlanmak için Modernizr uygulamasının geliştirme sürümünü kullanın. Ardından
			// üretim için hazır. https://modernizr.com adresinde derleme aracını kullanarak yalnızca ihtiyacınız olan testleri seçin.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));
			bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
					 "~/Content/themes/base/jquery.ui.core.css",
					 "~/Content/themes/base/jquery.ui.resizable.css",
					 "~/Content/themes/base/jquery.ui.selectable.css",
					 "~/Content/themes/base/jquery.ui.accordion.css",
					 "~/Content/themes/base/jquery.ui.autocomplete.css",
					 "~/Content/themes/base/jquery.ui.button.css",
					 "~/Content/themes/base/jquery.ui.dialog.css",
					 "~/Content/themes/base/jquery.ui.slider.css",
					 "~/Content/themes/base/jquery.ui.tabs.css",
					 "~/Content/themes/base/jquery.ui.datepicker.css",
					 "~/Content/themes/base/jquery.ui.progressbar.css",
					 "~/Content/themes/base/jquery.ui.theme.css"));
		}
	}
}
