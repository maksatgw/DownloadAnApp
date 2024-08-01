## Welcome to Donwload an App ASP .NET CORE MVC

It is not a complicated task but wanted to keep it in archive. It does simple task, returns a file.
## Usage, and Codes

When you put your files to your wwwrooot directory, you can use the codes followed by in your controller.

```csharp

//Download method
public IActionResult GetMyApp()
{
   //Get the file path of application
   var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "app-release.apk");

   //Read the bytes
   var fileBytes = System.IO.File.ReadAllBytes(filePath);
   //find the bytes
   var fileName = "app-release.apk";

   //Return files
   return File(fileBytes, "application/octet-stream", fileName);
}

```


