# DocxTemplateParser
This repository is created in coordination with VibeOps, in support of Reportly, a tool to organize technical reports through your browser.

## Using Git
To complete this project, you will need to follow the below outline using Git. For those who have not used Git before, ***emphasized*** terms are the technical terms you will need to research.
- Install [Git](https://git-scm.com/) on your computer, if you haven't already.
  
  This is primarily a command-line tool. It should ask to make changes to your PATH variable. You should permit it to do so.

- ***Fork*** this repository on my Github account (ksherbert-hcc), to the account of you or your partner.
- ***Clone*** your fork, to create a project directory on your local computer. Both partners can do this.
- Complete the tasks for each week in the project directory on your local computer.

  Additional notes:
  - *You should never modify files through Github.*
  - *It is absolutely essential that you keep your project directory organized, neat, and professional.*
  - The easiest strategy is to do all work together with your partner on one workstation, then ***pull*** changes from your fork on Github later, to synchronize your workspaces.
  - It is also possible for both partners to work separately on different components, using Git's ***merge*** feature to ensure changes made to the same file are consistent. When you have changed the same *lines* of code, this becomes somewhat tedious - but it is a good skill to practice. Try it at least once!

- When you complete a lab, ***stage*** changes, ***commit*** changes to your local Git history, and then ***push*** this commit record to your fork on Github.

  Additional notes:
  - *Files generated automatically from a build process are system specific and should not be staged or committed.*

    *Proprietary files (e.g. technical reports provided by a business) should not be staged or committed.*
  
    Instead, you can add these to your ***.gitignore*** file so that Git will not continue to list them as unstaged.
  - It is also a good idea to stage and commit changes as you complete different milestones *within* a lab.
  
    You need not push these changes until you are ready to turn them in (unless you need to merge your work with your partner).

## Using C#
Within this Git project is a C# project - and I anticipate we will create one or two more C# projects as time goes on. The easiest way to work with C# is to use VS Code.

*VS Code is not the same as Visual Studio, a much more monolithic, venerable and...shall I say,* scenile *piece of software.*

Steps you should only have to complete once:
1. Install VS Code, if you haven't already.
2. Install the "C# Dev Kit" extension.
3. Install .NET 10.0. This is the analog to OpenJDK when you installed Java.

   *Installing the C# Dev Kit extension should prompt you to do this step. You may be prompted to "log in" to Microsoft. That is totally unnecessary. Just skip that step.*

Steps to complete when making a new project:
1. Open your project directory in VS Code on your local device. We'll call this the "root" project directory from now on, to distinguish it from the C# project we are about to create.
2. Open the "command palette" (Ctrl+Shift+P, usually) and find the command ".NET: New Project..."
3. Follow the steps to name and create your C# project. Be sure it is created inside your root project directory. You should also see a `.sln` file appear in the root project directory.

   *I have no idea what the .sln file is but it's probably important.*

4. Open the `Project.cs` file. VS Code should automatically *build* the project directory, including `bin` and `obj` folders.

   *Beware I'm not yet sure this actually works. I haven't been able to follow precisely this workflow on school computers. If perchance you see a bin folder appear in the root project directory, as opposed to inside the C# project directory, something has gone wrong. Please alert me ASAP.*

5. Open the "command palette" (Ctrl+Shift+P, usually) and find the command "NuGet: Add NuGet Package...".
   Add the latest version of `DocumentFormat.OpenXML`.

   This will update the `.csproj` file in your C# project directory to include the package as a dependency. VS Code *should* automatically rebuild your `obj` folder to include the requisite files which enable the requisite import statements in your C# code.

Steps to complete when running a project:
1. Have the file open which you want to run. Hit the play button. Um. That *seems* to be it?

   I am never quite sure, because there are two things that need to happen when the play button is pressed. First, the code is *compiled*, which (should) rewrite all the `.exe` and `.dll` business in the `bin` folder. Second, the `.exe` file is *executed*.

   There's a pretty good chance this works a bit differently on every machine. Let me know if you suspect it isn't working correctly.

2. Any file paths should be either absolute paths, or relative to ... the ... current working directory. Which ought to be the root project directory. But it seems that, using the play button, it is the location of the `.exe` file. I don't understand why, and this is precisely why I don't like using the play button! But, it's probably easiest for now to just prefix your file paths in the code with the requisite number of "../"s.

3. There is probably a proper way of organizing a C# project to contain multiple files and perhaps even multiple executable scripts. I am presently waiting for our collaborators to give me further guidance on what that is. :)

## Lab 1
We did Lab 1 together as a class. Here is a reminder of the steps we took.

### Unzipping a Word Document
1. Copy the word document and rename it so it uses the .zip extension instead of .docx.
2. Extract all files from the .zip.
3. The resulting directory is a dense packaging of XML files describing all content and metadata contained within the Word document.
4. We found the main content in `word/document.xml`.

### Understanding an XML Document
1. Similar to HTML, XML files consist of ***elements***. The type of element is identified by the ***tag***. Elements may have a number of ***attributes*** which are assigned a string value. Elements may or may not contain ***content***, which may consist of ***inner text***, nested ***child*** elements, or both.
   
   Syntax for elements without content:
   ```
   <tag attribute="value" />
   ```

   Syntax for elements with content:
   ```
   <tag attribute="value">content</tag>
   ```

2. The attributes, values, and content valid for any element are defined by a ***schema***. For a Word document, this schema is given by the [OpenXML interface](https://learn.microsoft.com/en-us/dotnet/api/documentformat.openxml.wordprocessing?view=openxml-3.0.1).

### Coding up a Word Parser
1. We created a new C# project called `WordParser`.
2. We copied the specifications from our Curriculum Outline as comments in our script.
3. We wrote additional comments outlining the series of steps we expected to have to accomplish.
4. We drew from examples included in the tutorial documentation for the referenced package `DocumentFormat.OpenXML` to start off our code.
5. We inspected the reference documentation for each OpenXML object to understand the attributes and children containing the required information, as well as the syntax to access it.
6. Afterward I polished the code up with additional comments and more robust null handling.