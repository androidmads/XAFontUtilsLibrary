using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Menu = Android.Views.IMenu;
using MenuItem = Android.Views.IMenuItem;
using SubMenu = Android.Views.ISubMenu;
using MaterialToolbar = Android.Support.V7.Widget.Toolbar;
using Toolbar = Android.Widget.Toolbar;
using Android.Text;
using Android.Support.Design.Widget;

namespace XAFontUtilsLibrary
{
    public class FontUtils
    {
        private Context context;

        public FontUtils(Context _context)
        {
            context = _context;
        }

        public void ApplyFontToToolbar(Toolbar toolbar, Typeface typeface)
        {
            for (int i = 0; i < toolbar.ChildCount; i++)
            {
                View view = toolbar.GetChildAt(i);
                if (view is TextView)
                {
                    TextView tv = (TextView)view;
                    tv.SetTypeface(typeface, TypefaceStyle.Normal);
                    break;
                }
            }
        }

        public void ApplyFontToToolbar(MaterialToolbar toolbar, Typeface typeface)
        {
            for (int i = 0; i < toolbar.ChildCount; i++)
            {
                View view = toolbar.GetChildAt(i);
                if (view is TextView)
                {
                    TextView tv = (TextView)view;
                    tv.SetTypeface(typeface, TypefaceStyle.Normal);
                    break;
                }
            }
        }

        public void ApplyFontToMenu(Menu menu, Typeface typeface)
        {
            for (int i = 0; i < menu.Size(); i++)
            {
                MenuItem menuItem = menu.GetItem(i);
                SubMenu subMenu = menuItem.SubMenu;
                if (subMenu != null && subMenu.Size() > 0)
                {
                    for (int j = 0; j < subMenu.Size(); j++)
                    {
                        MenuItem subMenuItem = subMenu.GetItem(j);
                        ApplyFontToMenuItem(subMenuItem, typeface);
                    }
                }
                ApplyFontToMenuItem(menuItem, typeface);
            }
        }

        public void ApplyFontToSubMenu(SubMenu menu, Typeface typeface)
        {
            for (int i = 0; i < menu.Size(); i++)
            {
                MenuItem menuItem = menu.GetItem(i);
                SubMenu subMenu = menuItem.SubMenu;
                if (subMenu != null && subMenu.Size() > 0)
                {
                    for (int j = 0; j < subMenu.Size(); j++)
                    {
                        MenuItem subMenuItem = subMenu.GetItem(j);
                        ApplyFontToMenuItem(subMenuItem, typeface);
                    }
                }
                ApplyFontToMenuItem(menuItem, typeface);
            }
        }

        private void ApplyFontToMenuItem(MenuItem mi, Typeface typeface)
        {
            SpannableString mNewTitle = new SpannableString(mi.TitleFormatted);
            mNewTitle.SetSpan(new MenuItemTypefaceSpan(typeface),
                    0, mNewTitle.Length(),
                    SpanTypes.InclusiveExclusive);
            mi.SetTitle(mNewTitle);
        }

        public void ApplyFontToNavigationView(NavigationView navigationView, Typeface typeface)
        {
            ApplyFontToMenu(navigationView.Menu, typeface);
        }

        public void ApplyFontToView(View view, Typeface typeface)
        {
            if (view is TextView)
            {
                TextView tv = (TextView)view;
                tv.Typeface = typeface;
            }
        }

    }
}