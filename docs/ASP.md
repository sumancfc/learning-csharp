# ASP.NET Web Pages

### Web Pages Examples
- [ASP.NET Web Pages](https://www.w3schools.com/asp/webpages_intro.asp)

```html
<html lang="en">
<body>
     <h1>Hello Web Pages</h1>
     <p>The time is @DateTime.Now</p>
</body>
</html>
```

## Razor Markup
- [Razor Markup](https://www.w3schools.com/asp/webpages_razor.asp)
- C# code blocks are enclosed in @{ ... }
- Inline expressions (variables or functions) start with @
- Code statements end with semicolon
- Variables are declared with the var keyword, or the datatype (int, string, etc.)
- Strings are enclosed with quotation marks
- C# code is case-sensitive
- C# files have the extension .cshtml

```html
<!DOCTYPE html>
<html>
    <head>
        <title>ASP.NET Razor</title>
        <meta charset="utf-8" />
    </head>
<body>
    <h1>ASP.NET Razor</h1>
    <p>Welcome to ASP.NET Razor</p>
    <p>Current time: @DateTime.Now</p>
</body>
</html>
```