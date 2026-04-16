# hello-as-net-developer

## Summary

An ASP.NET Core REST API application to illustrate the use of Minimal APIs.

## Features

The API supports both GET and POST requests to generate personalized greetings based on a developer's first and last names.

- **GET /greetings**: Retrieve a greeting with optional `firstName` and `lastName` query parameters.
- **POST /greetings**: Create a greeting by sending a JSON payload with `firstName` and `lastName`.

## User Stories
The user stories for this project can be found in the [docs/user-stories.md](docs/user-stories.md) document.

## Class Diagram
The class diagram for this project can be found in the [docs/class-diagram.puml](docs/class-diagram.puml) document.

The following diagram shows the class hierarchy and relationships for the application:
![class-diagram](https://plantuml.com/plantuml/proxy?src=https://raw.githubusercontent.com/upc-pre-202610-1asi0730-12206/hello-asp-net-developer/refs/heads/master/docs/class-diagram.puml)