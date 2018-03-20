using Android.Text.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Java.Interop;
using Java.Lang;
using Android.Graphics;

namespace XAFontUtilsLibrary
{
    public class MenuItemTypefaceSpan : TypefaceSpan
    {
        private readonly Typeface _typeface;

        public MenuItemTypefaceSpan(Typeface typeface) : base(string.Empty)
        {
            _typeface = typeface;
        }

        public MenuItemTypefaceSpan(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public MenuItemTypefaceSpan(Parcel src) : base(src)
        {
        }

        public MenuItemTypefaceSpan(string family) : base(family)
        {
        }

        public override void UpdateDrawState(TextPaint ds)
        {
            ApplyTypeface(ds, _typeface);
        }

        public override void UpdateMeasureState(TextPaint paint)
        {
            ApplyTypeface(paint, _typeface);
        }

        private static void ApplyTypeface(Paint paint, Typeface tf)
        {
            TypefaceStyle oldStyle;
            Typeface old = paint.Typeface;
            if (old == null)
            {
                oldStyle = 0;
            }
            else
            {
                oldStyle = old.Style;
            }

            TypefaceStyle fake = (oldStyle & ~tf.Style);
            if ((fake & TypefaceStyle.Bold) != TypefaceStyle.Normal)
            {
                paint.FakeBoldText = true;
            }

            if ((fake & TypefaceStyle.Italic) != 0)
            {
                paint.TextSkewX = -0.25f;
            }
            paint.SetTypeface(tf);
        }

    }
}