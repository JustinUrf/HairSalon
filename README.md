# _Employee and Client Tracker_

#### By Justin lee

#### _.net Fullstack application that uses SQL databases to register a imaginary Hair Salon with its own Stylists and Clientale._
## Technologies Used

* C#
* .Net
* HTML
* Bootstrap

## Description

This website is a application that allows an imaginary owner of a Hair Salon to keep track of their Clients and their own employees and what clients are under each employee. This uses SQL databases to keep track what clients belong to which stylists. Stylists can have multiple Clients while clients may only have one stylists. 


## Setup/Installation Requirements

1. Clone this repo.
2. In the root directory of the file named ``HairSalon.Soltuion`` create a file called ``appsettings.json`` and include these lines of code ``{"ConnectionStrings": {"DefaultConnection":"Server=localhost;Port=3306;database=[YOUR_DATA_BASE_HERE];uid=[YOUR_USER_ID_HERE];pwd=[YOUR_PASSWORD_HERE];"}}``
3. Download the SQL. Database given with the repository and import it to your own SQL database.
4. Remove the brackets and input the following fields with your personal matching fields above. i.e "database=hair_salon"
5. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "HairSalon".
6. In the command line, run the command ``dotnet run`` to compile and execute the console application.
7. If any dependancies show up, go to specific folders and use ``dotnet restore`` to restore its depedancies.
8. After running ``dotnet run``, open local host 5001 in your web browser.


## Known Bugs

* N/A

## License

MIT

Copyright (c) 2023 _Justin Lee _
