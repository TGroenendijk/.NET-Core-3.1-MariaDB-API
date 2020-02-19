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
![Create MariaDB server](https://user-images.githubusercontent.com/4686866/74847337-3de35400-5332-11ea-8462-8562ff4ad4a5.png | width=320)
