# Example .NET Project: Using a Class Library in a Web API

## Overview

This repository demonstrates how to build a .NET Class Library (ClassLib) and use it in a .NET Web API application. The goal is to illustrate how to structure projects, share reusable code, and integrate a class library into a web application.

## Project Structure

```bash
├── DotnetLibExample.App # The .NET Web API project
│   ├── Controllers
│   ├── Properties
├── DotnetLibExample.Lib # The reusable .NET Class Library project
│   ├── Api
│   ├── Models
│   ├── Services
└── DotnetLibExample.Test # Unit tests
```

## Prerequisites

- .NET SDK (8.0+ recommended)
- Visual Studio, JetBrains Rider, or VS Code with C# extension

## Getting Started

1️⃣ Clone the Repository

```bash
git clone https://github.com/gusterwoei/dotnet-classlib-example.git
cd dotnet-classlib-example
```

2️⃣ Build the Solution

```bash
dotnet build
```

This will compile all 3 projects.

3️⃣ Run the Web API

```bash
dotnet run --project DotnetLibExample.App
```

4️⃣ Pack the class library

```bash
cd DotnetLibExample.Lib
dotnet pack
```

This will generate a `.nupkg` bundle.