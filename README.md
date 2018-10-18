# XAFontUtilsLibrary
A Tiny Font Utility Library for Xamarin.Android to apply custom Fonts to 
* Toolbar
* NavigationView
* Menu
* Submenu
* RadioGroup
* TabLayout
* Other Views like EditText, TextView, etc.

## Supported Android Languages
- [x] Java
- [x] Kotlin
- [x] Xamarin

Readme for Java and Kotlin can be found here https://github.com/androidmads/FontUtils.

## How to download
You can download the plugin from Nuget Package Manager using 

```csharp
Install-Package XAFontUtils -Version 1.0.2
```

If the nuget is not compatible to your project, then you can download and include the directly from [here](https://github.com/androidmads/XAFontUtilsLibrary/blob/master/XAFontUtilsLibrary.dll)

## How to use
### C#
```java
// To import the Library
using XAFontUtilsLibrary;
...
// Applying Custom Font
Typeface typeface = Typeface.CreateFromAsset(Assets, "custom_font.ttf");
// Init Library
FontUtils fontUtils = new FontUtils();
// Apply font to Toolbar
fontUtils.ApplyFontToToolbar(toolbar, typeface);
// Apply font to NavigationView
fontUtils.ApplyFontToNavigationView(navigationView, typeface);
// Apply font to Menu
fontUtils.ApplyFontToMenu(menu, typeface);
// Apply font to Other Views like TextView...
fontUtils.ApplyFontToView(textview, typeface);
fontUtils.ApplyFontToView(editText, typeface);
fontUtils.ApplyFontToView(radioButton, typeface);
fontUtils.ApplyFontToView(checkBox, typeface);

fontUtils.ApplyFontToRadioGroup(radioGroup, typeface);
fontUtils.ApplyFontToTabLayout(tabLayout, typeface);
```
## License
```
MIT License

Copyright (c) 2018 AndroidMad / Mushtaq M A

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
