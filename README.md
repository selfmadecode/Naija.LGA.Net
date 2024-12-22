# Naija.Grid.Net

# The **NaijaGrid** package provides a simple and efficient way to retrieve data about Nigerian states and their Local Government Areas (LGAs).
# Designed for developers working with location-based services or administrative data in Nigeria, this package simplifies access to structured state and LGA data.


## Features

- Retrieve all states in Nigeria.
- Get a specific state by its ID or name.
- Access comprehensive lists of Local Government Areas (LGAs) for each state.
- Lightweight and easy-to-integrate.


## Installation

Add the package to your project via your package manager. Example for **NuGet Package Manager**:

```bash
Install-Package Naija.Grid.Net
```

Or via the .NET CLI:

```bash
dotnet add package Naija.Grid.Net
```

---

## Usage

Below is an example of how to use the **NaijaGridService** to access state and LGA data.

```csharp
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Retrieve all states
        var states = NaijaGridService.GetStates();
        Console.WriteLine($"Total states: {states.Count()}");

        // Retrieve a state by ID
        var state = NaijaGridService.GetState(36); // Example: Get state with ID 36
        Console.WriteLine($"State Name: {state.Name}");

        // Retrieve a state by name
        var imo = NaijaGridService.GetState("Imo");
        Console.WriteLine($"Imo LGAs: {string.Join(", ", imo.LGAs.Select(l => l.Name))}");
    }
}
```

### Explanation of Methods

1. **GetStates**
   - Returns a list of all Nigerian states.
   - Example:
     ```csharp
     var states = NaijaGridService.GetStates();
     Console.WriteLine(states.Count());
     ```

2. **GetState(int id)**
   - Retrieves a specific state by its ID.
   - Example:
     ```csharp
     var state = NaijaGridService.GetState(36);
     Console.WriteLine(state.Name);
     ```

3. **GetState(string name)**
   - Retrieves a state by its name (case-insensitive).
   - Example:
     ```csharp
     var imo = NaijaGridService.GetState("Imo");
     ```

---

## Data Structure

### State Object

- **Id** (int): Unique identifier for the state.
- **Name** (string): Name of the state.
- **Capital** (string): Capital for the state.
- **LGAs** (List<LGA>): List of Local Government Areas within the state.

### LGA Object

- **Id** (int): Unique identifier for the LGA.
- **Name** (string): Name of the LGA.

---

## Contributing

Contributions are welcome! If you have suggestions or improvements, please submit a pull request or open an issue in the repository.

---

## License

This package is licensed under the MIT License. See `LICENSE` for details.

