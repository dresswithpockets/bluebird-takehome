# Introduction

This is a kubernetes cluster with a webapi service and a background service. You must complete the requirements for the implementation of the service as described below.

In order to succeed with this assignment, make sure to follow the [80/20 rule](https://en.wikipedia.org/wiki/Pareto_principle). Regardless of if you're familiar with every technology listed below, you only need to learn or know enough about each tool to get this assignment working. We are not looking for perfect usage of any tool.

In addition to the code written for this assignment, please provide a writeup about your solution:

  - Details about any nuances in the project, the why behind any choices you made that you think are important, etc.
  - Basic documentation for interfacing with the public surface of the API.
  - A list the technologies that were totally new to you or you have very little experience with.
  - Approximately how long it took to complete the assignment.

We're not looking for a formal essay or anything - maybe 500 words or less. There is no benchmark for the writeup.

## Prerequisites

- [Docker CLI & Engine](https://www.docker.com/get-started)
- [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A suitable C# IDE of your choice; we recommend:
- [Jetbrains Rider](https://www.jetbrains.com/rider/) - Free Evaluation or via EAP
- [Visual Studio Code](https://code.visualstudio.com/) - Free
    - [Guide for C# via VS Code](https://code.visualstudio.com/docs/languages/csharp)

# Assignment

**Please write an API in `src/Bluebird.Api` which fulfills the following user requirements:**

- User can get a list of their market order history & the status of each market order
- User can create a market order to sell or buy a number of shares of a security

N.B. `WeatherForecastController` is just an example controller, feel free to delete it.

**Please write a background service in `src/Bluebird.Background` which fulfills the following requirements:**

- Market orders should execute ASAP @ the current share price of the specified security

You do not need to use real or live trading data. Feel free to use or create any data that would fulfil the requirements of the assignment, even if the source data itself is nonsensical. Also, feel free to assume that users have infinite buying power, for the sake of simplicity.

**We have provided an xUnit project, `src/Bluebird.Tests`, where you may write unit tests. This is optional.**

## Evaluation Criteria

- Learning & implementing new frameworks/languages
- Speed / resourcefulness
- Working with a broad specification / autonomous decision making
- Quality given the amount of time taken

## Running/Testing locally

With the docker daemon/engine running on your system, run `docker compose up --detach` to run and `docker compose down` to takedown the DB, API, and background service.

While running, you will be able to access the API at `localhost:5000`.

If you are running your application through your IDE for debugging purposes, you may desire to run the DB by itself; you may do so by executing `docker compose up db --detach`.
