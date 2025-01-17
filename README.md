# SQLite-Local-DB
Work Project: Investigating setup requirements to migrate a SQL Server Compact Edition database into SQLite using .Net 4.8 in Visual Studio 2022


SQLite Migration Information
Database conversion
Converting a SQL Server CE file (.sdf file extension) into a SQLite (.db file extension).
1.	Open the SQLite/SQL Server Compact Toolbox (installation instructions below)
2.	Locate the database file to convert and right click:
3.	Script Database > Script Schema and Data for SQLite
4.	Save .sql file
5.	Open DB Browser (SQLite) (installation instructions below)
6.	Create new database in DB Browser
7.	Select ‘Execute SQL’
8.	Open the .sql file and run
9.	‘Write changes’ to the database
10.	A new ‘.db’ file should have been created


Visual Studio Toolbox Extension
To use these commands, open the Package Manager Console in Visual Studio by navigating to Extensions > Manage Extensions > SQLite/SQL Server Compact Toolbox 
DB Browser (SQLite)
1.	Downloads - DB Browser for SQLite

   
Nuget Packages
1.	Microsoft.EntityFrameworkCore
2.	Microsoft.EntityFrameworkCore.Sqlite
3.	Microsoft.EntityFrameworkCore.Tools

*v3.1.32

1.	SQLitePCLRaw.bundle_e_sqlite3
2.	SQLitePCLRaw.bundle_green
3.	SQLitePCLRaw.core
4.	SQLitePCLRaw.lib.e_sqlite3
5.	SQLitePCLRaw.provider.dynamic_cdecl
6.	SQLitePCLRaw.provider.e_sqlite3

*v2.1.10

--> requires manually moving e_sqlite3.dll to bin > debug > runtimes folder


Useful Package Manager Console (PMC) Commands
There are several Package Manager Console commands that can help manage the database with Entity Framework Core. Here are some key commands which might be useful:
1.	Add-Migration: Creates a new migration based on the changes you have made to your model.
Add-Migration InitialCreate
2.	Update-Database: Applies any pending migrations to the database.
Update-Database
3.	Remove-Migration: Removes the last migration that has not been applied to the database.
Remove-Migration
4.	Get-Help: Provides information about the available Entity Framework Core commands.
Get-Help EntityFrameworkCore
5.	Scaffold-DbContext: Generates a model from an existing database.
Scaffold-DbContext "YourConnectionString" Microsoft.EntityFrameworkCore.Sqlite
To use these commands, open the Package Manager Console in Visual Studio by navigating to Tools > NuGet Package Manager > Package Manager Console. Make sure Microsoft.EntityFrameworkCore.Tools package is installed in the project. This can be installed using the following command:
Install-Package Microsoft.EntityFrameworkCore.Tools
These commands should help manage the database schema and migrations effectively. 

