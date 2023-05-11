# HMO

## Table of Contents
1. [Introduction](#introduction)
2. [Features](#features)
3. [Server-Side](#server-side)
4. [Data Storage](#data-storage)
5. [Project Structure](#project-structure)
6. [Dependencies](#dependencies)
7. [Installation](#installation)
8. [Usage](#usage)
9. [API Documentation](#api-documentation)
10. [Contributing](#contributing)
11. [License](#license)

## Introduction
The HMO System is a software application designed to manage the records and details of members, patients, and revenue in a health fund.
It also keeps track of key information related to the corona epidemic for the members of the health fund. 
The system allows for input and retrieval of records, access to a database, and generates summary views regarding the corona virus. 
The system is built with an entity framework 
using a SQL server database 
and follows a four-layer architecture: service, repository, DTO, and controller.

## Features
1. Display members' details at the checkout.
2. Store and retrieve personal details of health fund members, including:
   - First name and last name
   - Identity card
   - Address (city of residence, street, and number)
   - Date of birth
   - Telephone number
   - Mobile phone number
3. Track corona virus information for each member, including:
   - Dates of receiving each corona vaccine
   - Manufacturer of the vaccine
   - Date of receiving a positive result
   - Date of recovery from the disease
4. Generate summary views on the corona virus, including:
   - Number of active patients each day in the last month
   - Number of unvaccinated Copa members

## Server-Side
The server-side of the System is responsible for handling the logic and data processing. 
It provides APIs for inputting and retrieving records, as well as accessing the underlying database.
The server-side ensures the correctness of the inputs.

## Data Storage
The system uses a SQL server database to store and manage the data. 
The database schema is designed to accommodate the required member and corona virus information.
The entity framework handles the communication with the database and provides an abstraction layer for data operations.

## Project Structure
The Health Fund Management System follows a four-layer architecture, consisting of the following layers:

1. Service: Contains business logic and operations related to managing the health fund and corona virus data.
2. Repository: Handles data access and storage operations, including interactions with the SQL server database.
3. DTO (Data Transfer Object): Defines the data structures used for transferring data between layers and APIs.
4. Controller: Implements the APIs and serves as the interface for external clients to interact with the system.

## Dependencies
The Health Fund Management System has the following dependencies:

1. Entity Framework (version 6.0): ORM (Object-Relational Mapping) framework used for data access and management.
2. SQL Server (version 18.12.1): Database server used to store and manage the system's data.
3. Dependency Injection framework.

## Installation
To install and run the Health Fund Management System, follow these steps:

1. Clone the project repository from [GitHub URL](https://github.com/your/project/repository).
2. Install the required dependencies mentioned in the project.
3. Set up the SQL server database and configure the connection details in the project's configuration files.
4. Build
