# SDN .NET Aspire & Dapr Demo

## Overview

This repository contains a demo application for an article in **SDN Magazine**. The demo showcases how to use **.NET Aspire** with **Dapr** to enable seamless communication between two services using a **Dapr Pub/Sub component**.

## Features

- Demonstrates the integration of **.NET Aspire** with **Dapr**.
- Implements **Pub/Sub messaging** using Dapr.
- Uses **.NET Aspire service orchestration** to manage application components.
- Provides a minimal yet effective example of event-driven communication in a **multi-service environment**.

## Architecture

The application consists of two services:

1. **Sender Service**: Publishes messages to a Dapr Pub/Sub topic.
2. **Receiver Service**: Subscribes to the topic and processes incoming messages.

Dapr handles the communication between these services using a message broker (such as Redis or Azure Service Bus).

## Prerequisites

Ensure you have the following installed:

- [Docker](https://docs.docker.com/get-started/)
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Dapr CLI](https://docs.dapr.io/getting-started/install-dapr-cli/)

## Getting Started

### 1. Clone the Repository

```sh
git clone https://github.com/nikneem/sdn-mag-aspire-dapr-demo.git
```

Open the solution in the source folder and start the solution.

## Contributing

Contributions are welcome! Feel free to submit a PR or open an issue.

## License

This project is licensed under the [MIT License](LICENSE).

## Author

This demo is created as part of an **SDN Magazine** article to illustrate the power of **.NET Aspire** and **Dapr** for event-driven architectures.
