# SqlDataToolsTest
How to publish a database project when running unit test

You need:
Clean install Windows 10
Install Visual Studio 2017 Professional
Install SQL Data tools for VS 2017 => https://docs.microsoft.com/en-us/sql/ssdt/download-sql-server-data-tools-ssdt

The exception occurs when running the unit test TestMethod1 in DatabaseTestLoader class on the following line:

Project mySqlProject = projects.LoadProject(@"..\..\..\Database1\Database1.sqlproj");

