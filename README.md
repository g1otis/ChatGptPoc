# Customer API Project

Welcome to the Customer API project repository. This .NET 8 Web API is POC project designed using the chatGPT prompt to demonstrate how a developer could get benefit of using chatGPT, creating a project and making changes/improvements.

## POC Branches
- part1-scaffolding: related article link

## Features

- **CRUD Operations**: Create, read, update, and delete customer records.
- **Repository Pattern**: Ensures business logic is decoupled from data access layers.
- **DTOs (Data Transfer Objects)**: Facilitate the transmission of data across processes.
- **Auto Migration**: Automates database migrations to ensure schema consistency.
- **Docker Integration**: Containerizes the application for easy deployment and isolation.

## Technologies

- **.NET 8**: Latest Microsoft framework for building high-performance applications.
- **Entity Framework Core**: Data access technology.
- **AutoMapper**: Object-to-object mapping tool to convert entities to DTOs.
- **SQL Server**: Reliable, scalable, corporate database management system.
- **Docker**: Platform to develop, ship, and run applications.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET 8 SDK
- Docker Desktop

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/customerapi.git

2. Navigate to the project directory:
    ```bash
    cd CustomerApi

3. Build the Docker containers:
    ```bash
    docker-compose up --build