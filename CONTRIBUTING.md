## Contributing

I intend on making this beginner-friendly. If you see something, say something! (Aka, make a change and PR it). I'd prefer that you have tests; if you don't, I'd be willing to pair with you over some form of communication and help you out.

## Before you start
You'll need to fork and/or clone this repo down to your local machine if you want to just play with the API. If you want to play with the website, as well, you'll need to for and/or clone [DDRScoreTracker](https://github.com/duraz0rz/DDRScoreTracker).

## Requirements
- [.NET Core SDK 2.1 or higher](https://dotnet.microsoft.com/download)
  - `scoop install dotnet-sdk` on Windows
  - `brew cask install dotnet-sdk` on Mac
  - Whatever the equivalent is on Linux
- NodeJS 11.x
  - `scoop install nodejs`
  - `brew install nodejs`
- [Angular CLI](https://cli.angular.io/)

## How to run
- `dotnet run --project .\DDRScoreTracker.API\DDRScoreTracker.API.csproj` in API folder to run a local instance of the API.
- `npm start` in web code folder to start the web app.
