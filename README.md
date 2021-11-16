# ORM EntityFramework Demo

1.  Make sure you have Docker installed. [Docker Desktop for Mac and Windows](https://www.docker.com/products/docker-desktop)  
    You can use the cli if you prefer.
    
2.  Login to or sign up with [Docker Hub](https://hub.docker.com/).
    
3.  Install the SQL Server Extension in VSCODE.
    
4.  Download and run the MSSQL Container:  

		$ docker run -e "ACCEPT_EULA=1" -e "MSSQL_SA_PASSWORD=MyPass@word" -e "MSSQL_PID=Developer" -e "MSSQL_USER=SA" -p 1433:1433 -d --name=sql mcr.microsoft.com/azure-sql-edge
    
5.  Configure The SQL Server Extension to access your database:

    a.  Click on the SQL Server tab in the left toolbar

    b.  Press + Add Connection and enter localhost in the command palette where it asks for server name, press ENTER.

    c.  Press Enter to accept the default database.  
 
    d.  Choose SQL Login for authentication.

    e.  Enter `sa` for the username.

    f.  Enter `MyPass@word` for the password.

    g.  Choose yes to save password.

    h.  For profile name enter ORM Demo.
        
6.  If you don’t have .NET Core SDK installed yet, you can find it [here](https://dotnet.microsoft.com/download).
    
7.  Install the Entity Framework cli tool `$ dotnet tool install --global dotnet-ef`.

8. Clone this repository `$ git clone https://github.com/danmestas/ORMDemo.git`

9. Open the root of this repository in VSCode.

10. Create your initial migration: `$ dotnet ef migrations add InitialCreate`


> Written with [StackEdit](https://stackedit.io/).
