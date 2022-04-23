
# Branden Clauson Animal Shelter API

### ***By Branden Clauson***
### An API project which manages cats and dogs within an animal shelter

<p>&nbsp<p>

## **Technologies used**

* C#
* .NET 5.0
* dotnet
* MySql
* MySql workbench

<p>&nbsp<p>

## **Description**

#### An API that contains dogs and cats within a database for an animal shelter 


<p>&nbsp<p>

## **Setup/Installation Requirements**
* Clone to folder
* Navagate to directory within your terminal
* Create appsettings.json file within the LocalAnimalShelter directory with the code:
 <code> 
 {
  
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=Branden_Clauson;uid=root;pwd=epicodus;"
  }
}
}
</code>

* make sure to install <code> $ dotnet tool install --global dotnet-ef --version 5.0.1 </code>
* run <code> $ dotnet ef database update </code>
* Return to the directory in the terminal and input <code> dotnet run </code>
* The API should now show on the localhost in browser or Postman
* API also implements Swagger documentation, to localhost:5000/swagger


<p>&nbsp<p>

## **Known Bugs**

#### No current known bugs

## **License**

[MIT](LICENSE.txt)

Copyright (c) 2022 Branden Clauson

<p>&nbsp<p>