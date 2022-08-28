# CSharpKeyAuth - Template
## Setup Instructions
### - Edit Login.cs to match your KeyAuth information. 

```
name: "PLACE APP NAME HERE",
ownerid: "PLACE OWNERID HERE",
secret: "PLACE SECRET HERE",
version: "PLACE VERSION HERE"
```

## - How to change colors
- In the future I will make a config file to pull from but for now this is how you will change the colors.
- Locate DarkTheme() & LightTheme() in the forms wanted to change and change the Argb values to what you want. 

``` 
        ​// Color settings for dark theme​
        private void DarkTheme()
        {
            backgroundcolor = Color.FromArgb(43, 45, 50);
            textboxcolor = Color.FromArgb(60, 63, 69);
            topbarcolor = Color.FromArgb(32, 34, 37);
            textcolor = Color.FromArgb(255, 255, 255);
            logo = CSharpKeyAuth.Properties.Resources.logo_1_dark;
        }
```
```
        ​// Color settings for light theme​
        private void LightTheme()   
        {
            backgroundcolor = Color.FromArgb(238, 238, 238);
            textboxcolor = Color.FromArgb(192, 192, 192);
            topbarcolor = Color.FromArgb(255, 255, 255);
            textcolor = Color.FromArgb(0, 0, 0);
            logo = CSharpKeyAuth.Properties.Resources.logo_1_white;
        }
 ```
       
