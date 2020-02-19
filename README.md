# ASP.NET Core 3.1 Web API that gets customers from MariaDB
This sample creates the following API:
GET /api/customers/city/{city}	Get the customers by city


## Prerequisites
Visual Studio 2019 16.4 or later with the ASP.NET and web development workload
.NET Core 3.1 SDK or later


## Create an Azure Database for MariaDB server
You first have to create an Azure Database for MariaDB server with a defined set of compute and storage resources. You create the server within an Azure resource group.
To create an Azure Database for MariaDB server:
1.	Select the Create a resource button (+) in the upper left corner of the portal.
2.	Select Databases > Azure Database for MariaDB. 

Enter or select the following server details:
![Create MariaDB server in Azure](https://user-images.githubusercontent.com/4686866/74857226-b0106480-5343-11ea-8f88-ab2b9f19183c.png)


## Connect to Azure Database for MariaDB
You can use a variety of applications to connect to your Azure Database for MariaDB server.
Use an application like MySQL Workbench or SQLyog to create a database and a customer table
![SQLyog Customer table in MariaDB](https://user-images.githubusercontent.com/4686866/74857953-c8cd4a00-5344-11ea-94d6-48e9957823db.png)


## Add a model class
A model is a set of classes that represent the data that the app manages. The model for this app is a Customer class.


## Add a database Facade
The database Facade is the class that gets the customer data from MariaDB. This class uses the MySqlConnector NuGet package. A provider, supporting MySQL Server, MariaDB, Percona Server, Amazon Aurora, Azure Database for MySQL and more.

## Test the MariaDb API with Postman
Create a new request.
Set the HTTP method to GET.
![Postman - Get Customers from MariaDB by City](https://user-images.githubusercontent.com/4686866/74858984-7e4ccd00-5346-11ea-8cbf-ac6aa82fa812.png)



