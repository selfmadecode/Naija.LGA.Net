# Naija.LGA.Net

This package provides a simple way to retrieve data about Nigerian states and their Local Government Areas (LGAs).
Designed for developers working with location-based services in Nigeria.


## Features

- Retrieve all states in Nigeria.
- Get a specific state by its ID or name.
- Get states without their LGAs
- Access comprehensive lists of Local Government Areas (LGAs) for each state.
- Lightweight and easy-to-integrate.


## Installation

Add the package to your project via your package manager. Example for **NuGet Package Manager**:

```bash
Install-Package Naija.LGA.Net
```

Or via the .NET CLI:

```bash
dotnet add package Naija.LGA.Net
```

---

## Usage

Below is an example of how to use the package to access state and LGA data.

```csharp
using System;
using System.Linq;
using Niaja;

class Program
{
    static void Main(string[] args)
    {
        // Retrieve all states
        var states = Nigeria.GetStatesWithLgas();
        Console.WriteLine($"Total states: {states.Count()}");

        // Retrieve a state by ID
        var state = Nigeria.GetStateWithLgas(36); // Example: Get state with ID 36
        Console.WriteLine($"State Name: {state.Name}");

        // Retrieve a state by name
        var imo = Nigeria.GetStateWithLgas("Imo");
        Console.WriteLine($"Imo LGAs: {string.Join(", ", imo.LGAs.Select(l => l.Name))}");

        // Retrieve all states with priority state at the top
        var states = Nigeria.GetStatesWithLgasWithAndPrioritizeState(25);
        Console.WriteLine(statesWithPriority.First().Name);
    }
}
```

### Explanation of Methods

1. **GetStates**
   - Returns a list of all Nigerian states.
   - Example:
     ```csharp
     var states = Nigeria.GetStatesWithLgas();
     Console.WriteLine(states.Count());
     ```

2. **GetState(int id)**
   - Retrieves a specific state by its ID.
   - Example:
     ```csharp
     var state = Nigeria.GetStateWithLgas(36);
     Console.WriteLine(state.Name);
     ```

3. **GetState(string name)**
   - Retrieves a state by its name (case-insensitive).
   - Example:
     ```csharp
     var imo = Nigeria.GetStateWithLgas("Imo");
     ```

4. **GetStatesWithLgasWithAndPrioritizeState(int priorityStateId)**
    - Returns a list of all Nigerian states with a priority state at the top of the list
    ```csharp
    var states = Nigeria.GetStatesWithLgasWithAndPrioritizeState(29);
    Console.WriteLine(statesWithPriority.First().Name);
    ```
---

## Data Structure

### State Object

- **Id** (int): Unique identifier for the state.
- **priorityStateId** (int): Unique identifier for the state.
- **Name** (string): Name of the state.
- **Capital** (string): Capital for the state.
- **Lgas** (List<Lga>): List of Local Government Areas within the state.

### LGA Object

- **Id** (int): Unique identifier for the LGA.
- **Name** (string): Name of the LGA.

---

## Contributing

Contributions are welcome! If you have suggestions or improvements, please submit a pull request or open an issue in the [repository](https://github.com/selfmadecode/Naija.LGA.Net)

---

