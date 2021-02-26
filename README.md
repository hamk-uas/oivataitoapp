# OivaTaito Web Application

## Project Contributors


| [<img src="https://www.rakennerahastot.fi/documents/10179/54973/EU_ESR_FI_vertical_20mm_rgb.png/" alt="ESF EU flag logo in Finnish" width="200" />](https://www.rakennerahastot.fi) | [<img src="https://www.rakennerahastot.fi/documents/10179/55439/VipuvoimaaEU_2014_2020_rgb.png/2a05d239-e940-4301-928f-82078c2959bf?t=1404911191222" alt="Vipuvoimaa EU:lta logo" width="200"/>](https://www.rakennerahastot.fi)
| -------- | -------- |
| [<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/HAMK_yhdistelma_vari_wikipedia.svg/1280px-HAMK_yhdistelma_vari_wikipedia.svg.png" alt="Häme University of Applied Sciences logo" width="200"/>](https://hamk.fi?lang=en) | [<img src="https://pbs.twimg.com/profile_images/1328612182775508998/3kkLdMJk_400x400.jpg" alt ="HAMK Smart Research Unit logo" width="200" />](https://www.hamk.fi/research/hamk-smart/?lang=en) |

## About

OivaTaito is a web application meant to help users identify and visualize their generic skills. The user's skills are measured with questionnaires and visualized with various charts.

OivaTaito was built as a part of the Oiva project. It was build with Blazor, a framework for web development using .NET and C#.


| :information_source: | For more information about the Oiva project, please visit https://www.oivaosaaminen.fi
| --- | --- |

### Used Tools :hammer_and_wrench: 

* ASP.NET Core Blazor
    * Blazor Server
    * ASP.NET Core 3.1
* Entity Framework Core
* [Blazored LocalStorage](https://github.com/Blazored/LocalStorage)
* [ChartJS Blazor](https://github.com/mariusmuntean/ChartJs.Blazor)
* Google Authentication
* Visual Studio 2019 w/ ASP.NET workload

### Usage

1. Clone the repository
2. Generate OAuth credentials in Google Cloud Platform 
3. Set up an SQL server and a database
4. Open the project in VS
5. In [appsettings.Development.json](./OivaTaitoApp/appsettings.Development.json), replace values of
    * **ClientID** and **ClientSecret** under Google with your credentials
    * **DefaultConnection** under ConnectionStrings with connection string to your server
6. In i.e the Package Manager Console, run the following commands to initialize the database
    ```
    enable-migrations
    add-migration InitialCreate
    update-database
    ```
7. Clean, build and run

| :information_source: | View the README on [Hackmd.io](https://hackmd.io/a3fFQ8BISOekicD9lm0rrg) |
| --- | --- |