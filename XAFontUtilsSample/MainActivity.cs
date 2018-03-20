using Android.App;
using Android.Widget;
using Android.OS;
using XAFontUtilsLibrary;
using Android.Graphics;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Views;

namespace XAFontUtilsSample
{
    [Activity(Label = "XAFontUtilsSample",
        Theme = "@style/MyTheme",
        MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public static string lato_light = "fonts/Lato-Light.ttf";
        public static string lato_regular = "fonts/Lato-Regular.ttf";
        public static string lato_bold = "fonts/Lato-Bold.ttf";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Toolbar toolbar = (Toolbar)FindViewById(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            toolbar.Title = "Font Utils - Xamarin";

            TextView textview = (TextView)FindViewById(Resource.Id.textView);
            EditText editText = (EditText)FindViewById(Resource.Id.editText);
            RadioButton radioButton = (RadioButton)FindViewById(Resource.Id.radio);
            CheckBox checkBox = (CheckBox)FindViewById(Resource.Id.chkBox);

            Typeface typefaceBold = Typeface.CreateFromAsset(Assets, lato_bold);
            Typeface typefaceLight = Typeface.CreateFromAsset(Assets, lato_light);
            Typeface typefaceRegular = Typeface.CreateFromAsset(Assets, lato_regular);

            FontUtils fontUtils = new FontUtils(ApplicationContext);
            fontUtils.ApplyFontToToolbar(toolbar, typefaceBold);
            fontUtils.ApplyFontToView(textview, typefaceRegular);
            fontUtils.ApplyFontToView(editText, typefaceRegular);
            fontUtils.ApplyFontToView(radioButton, typefaceBold);
            fontUtils.ApplyFontToView(checkBox, typefaceLight);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            Typeface typefaceLight = Typeface.CreateFromAsset(Assets, lato_light);
            MenuInflater.Inflate(Resource.Menu.menu, menu);
            FontUtils fontUtils = new FontUtils(ApplicationContext);
            fontUtils.ApplyFontToMenu(menu, typefaceLight);
            return true;
        }
    }
}

