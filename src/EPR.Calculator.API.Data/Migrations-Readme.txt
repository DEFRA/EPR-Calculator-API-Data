In order to run the EF migrations we need to in always in sync

*** Command to install the dotnet tool for Entity framework core ***

dotnet tool install -g dotnet-ef

**** Command to Run the created the Migrations ****

dotnet ef migrations add AddInitialMigration --project ./src/EPR.Calculator.API.Data

**** Command to add a migration *****

dotnet ef migrations add AddBlogCreatedTimestamp

**** Command to remove latest Migration *****

dotnet ef migrations remove --verbose --project "./src/EPR.Calculator.API.Data" 

**** Listing Migrations *****

dotnet ef migrations list

**** Checking for Model changes *****

dotnet ef migrations has-pending-model-changes

**** Creating Migrations for Sql ******

dotnet ef migrations script -o  ./EPR.Calculator.API.Data/Scripts/migrations.sql -i --project "./src/EPR.Calculator.API.Data" 

***** Command to Update the migrations on the database *****

dotnet ef database update --verbose --project "./src/EPR.Calculator.API.Data"