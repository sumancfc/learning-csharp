# Files

## File Handling Basics

- `File:` Provides static methods for performing operations on files (reading, writing, copying, deleting, etc.).
- `FileInfo:` Represents a file and provides instance methods for working with it. Useful when we need to perform multiple operations on the same file.
- `Directory:` Provides static methods for working with directories (creating, deleting, enumerating, etc.).
- `DirectoryInfo:` Represents a directory and provides instance methods.
- `Stream:` Provides a base class for streams, which are used for reading and writing data to and from various sources (including files).
- `StreamReader:` Used for reading text from a stream (typically a file).
- `StreamWriter:` Used for writing text to a stream (typically a file).

## File Methods in C#

| Method            | Description                                                                                               |
|-------------------|-----------------------------------------------------------------------------------------------------------|
| `AppendText()`    | Appends text at the end of an existing file.                                                              |
| `Copy()`          | Copies a file.                                                                                            |
| `Create()`        | Creates or overwrites a file.                                                                             |
| `Delete()`        | Deletes a file.                                                                                           |
| `Exists()`        | Tests whether the file exists.                                                                            |
| `ReadAllText()`   | Reads the contents of a file.                                                                             |
| `Replace()`       | Replaces the contents of a file with the contents of another file.                                        |
| `WriteAllText()`  | Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.     |

### Reading from a File

- Using `File.ReadAllText()` (For small files):

```csharp
using System.IO; // include the System.IO namespace

try 
{
    string fileContents = File.ReadAllText("my_file.txt");
    Console.WriteLine(fileContents);
}
catch (FileNotFoundException)
{
    Console.WriteLine("File not found.");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
```

- Using `StreamReader` (For larger files or line by line reading):

```csharp
using System.IO; // include the System.IO namespace

try
{
    using (StreamReader reader = new StreamReader("my_file.txt")) 
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line); // Process each line
        }
    }
}
catch (FileNotFoundException) { /* ... */ }
catch (IOException ex) { /* ... */ }
```

### Writing to a File

- Using `File.WriteAllText()` (For small files):

```csharp
using System.IO; // include the System.IO namespace

try
{
    File.WriteAllText("output.txt", "This is some text to write to the file.");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occured: {ex.Message}");
}
```

- Using `StreamWriter` (For larger files or formatted output):

```csharp
using System.IO; // include the System.IO namespace

try
{
    using (StreamWriter writer = new StreamWriter("output.txt", true)) // 'true' for append, 'false' for overwrite (default)
    {
        writer.WriteLine("This is a new line.");
        writer.WriteLine($"The current date is: {DateTime.Now}");
        writer.Write("Some more text without a newline."); // Write without a newline
    }
}
catch (IOException ex) { /* ... */ }
```

### Working with File Paths

- The `Path` class provides useful methods for manipulating file paths:

```csharp
string filePath = "my_folder/my_file.txt";
string fileName = Path.GetFileName(filePath);        // "my_file.txt"
string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath); // "my_file"
string directoryName = Path.GetDirectoryName(filePath);   // "my_folder"
string fullPath = Path.GetFullPath(filePath);          // The absolute path
string combinedPath = Path.Combine("my_folder", "another_file.txt"); // Combines paths correctly
```

### File Information and Operations

- The `FileInfo` class allows us to get information about a file and perform operations on it:

```csharp
FileInfo fileInfo = new FileInfo("my_file.txt");

if (fileInfo.Exists)
{
    Console.WriteLine($"File size: {fileInfo.Length} bytes");
    Console.WriteLine($"Creation time: {fileInfo.CreationTime}");

    //fileInfo.CopyTo("my_file_copy.txt", true); // Copy the file (overwrite if true)
    //fileInfo.MoveTo("new_location/my_file.txt"); // Move the file
    //fileInfo.Delete(); // Delete the file
}
```

### Directory Operations

- The `Directory` and `DirectoryInfo` classes are used for working with directories:

```csharp
// Create a directory
Directory.CreateDirectory("new_directory");

// Get all files in a directory
string[] files = Directory.GetFiles("my_folder");

// Get all subdirectories
string[] subdirectories = Directory.GetDirectories("my_folder");

// Get directory information
DirectoryInfo dirInfo = new DirectoryInfo("my_folder");
if (dirInfo.Exists)
{
    // ...
}

// Delete a directory (recursive to delete contents)
//Directory.Delete("my_folder", true); // true for recursive delete
```

### Exception Handling

Always use `try-catch blocks to handle potential exceptions when working with files.  Common exceptions include:

- `FileNotFoundException`: The file is not found.
- `IOException`: An I/O error occurs (e.g., file access denied).
- `DirectoryNotFoundException`: The directory is not found.

### `using` Statement

Use the `using` statement with `StreamReader`, `StreamWriter`, and other disposable objects to ensure that resources are closed and released properly, even if exceptions occur.  This prevents file locks and other issues.
