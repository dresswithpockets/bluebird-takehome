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

- Kubernetes
  - [Docker](https://www.docker.com/get-started)
  - [kubectl](https://kubernetes.io/docs/tasks/tools/)
  - [minikube](https://minikube.sigs.k8s.io/docs/start/)
- C#
  - [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
  - A suitable IDE of your choice; we recommend:
    - [Jetbrains Rider](https://www.jetbrains.com/rider/) - Free Evaluation or via EAP
    - [Visual Studio Code](https://code.visualstudio.com/) - Free
      - [Guide for C# via VS Code](https://code.visualstudio.com/docs/languages/csharp)

# Assignment

Please write an API which fulfills the following user requirements

- User can get a list of trade securities
- User can get information about each security, such as the current share price
- User can get a list of all of their own market orders
- User can create a market order to sell or buy a number of shares of a security
- User can cancel an existing market order if it hasnt already executed
- User can get a list of all shares of each security they own, as well as the price they bought each share at.

Please write a background service which fulfills the following requirements:

- Market orders should execute ASAP @ the current share price of the specified security
- Market orders should automatically cancel if there is more than 10% variance between the current share price of the security & the share price of the security when the market order was created

You do not need to use real or live trading data. Feel free to use or create any data that would fulfil the requirements of the assignment, even if the source data itself is nonsensical. Also, feel free to assume that users have infinite buying power, for the sake of simplicity.

Please write unit tests for each important and testable unit of your code. We have provided an xUnit project, `src/Bluebird.Tests`, where you can write your tests. If you are not familiar with writing tests for xUnit, see [the xUnit documentation](https://xunit.net/#documentation).

Within `src/Bluebird.Tests`, we've provided a class `SqliteConnectionProvider` which can provide an ephemeral sqlite db instance for use within unit tests. You can use it to a get a direct `DbConnection`, or to get a `DbContextOptions<T>` necessary for instantiating a `DbContext` instance.

## Evaluation Criteria

- Learning & implementing new frameworks/languages
- Speed / resourcefulness
- Working with a broad specification / autonomous decision making
- Quality given the amount of time taken
