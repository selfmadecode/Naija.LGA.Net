﻿using System;
using System.Collections.Generic;
using System.Linq;
using Naija.Model;
using Naija.Utilities;

namespace Naija
{
    /// <summary>
    /// Represents the country Nigeria including it's states and LGAs.
    /// </summary>
    public static class Nigeria
    {
        private static readonly List<State> States = Util.InitializeStates();

        /// <summary>
        /// Retrieves all <see cref="State"/> objects, including their LGAs.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{State}"/> containing all states with their LGAs.</returns>
        public static IEnumerable<State> GetStatesWithLgas()
        {
            return States.ToList();
        }

        /// <summary>
        /// Retrieves a <see cref="State"/> object by its unique identifier (ID), including its LGAs.
        /// </summary>
        /// <param name="id">The ID of the state to retrieve. It must be greater than zero.</param>
        /// <returns>A <see cref="State"/> object representing the state with the specified ID.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the provided <paramref name="id"/> is less than or equal to zero.</exception>
        /// <exception cref="KeyNotFoundException">Thrown if no state with the specified ID is found.</exception>

        public static State GetStateWithLgas(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "State ID must be greater than zero.");

            var state = States.FirstOrDefault(x => x.Id == id);

            return state ?? throw new KeyNotFoundException($"State with ID {id} was not found.");
        }

        /// <summary>
        /// Retrieves a <see cref="State"/> object by its name, including its LGAs.
        /// </summary>
        /// <param name="name">The name of the state to retrieve. It cannot be null or empty.</param>
        /// <returns>A <see cref="State"/> object representing the state with the specified name.</returns>
        /// <exception cref="ArgumentException">Thrown when the provided <paramref name="name"/> is null, empty, or consists only of white-space characters.</exception>
        /// <exception cref="KeyNotFoundException">Thrown if no state with the specified name is found.</exception>

        public static State GetStateWithLgas(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("State name cannot be null or empty.", nameof(name));

            var state = States.FirstOrDefault(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));

            return state ?? throw new KeyNotFoundException($"State with name '{name}' was not found.");
        }

        // <summary>
        /// Retrieves all <see cref="State"/> states without their LGAs.
        /// </summary>
        /// <returns>A list of <see cref="IEnumerable{State}"/> objects without LGAs.</returns>
        public static IEnumerable<State> GetStatesWithoutLgas()
        {
            return States
                .Select(state => new State
                {
                    Id = state.Id,
                    Name = state.Name,
                    Capital = state.Capital,
                    Lgas = null // exclude LGAs
                })
                .ToList();
        }

        /// <summary>
        /// Retrieves a <see cref="State"/> object by its name, without its LGAs.
        /// </summary>
        /// <param name="name">The name of the state to retrieve. It cannot be null or empty.</param>
        /// <returns>A <see cref="State"/> object representing the state with the specified name.</returns>
        /// <exception cref="ArgumentException">Thrown when the provided <paramref name="name"/> is null, empty, or consists only of white-space characters.</exception>
        /// <exception cref="KeyNotFoundException">Thrown if no state with the specified name is found.</exception>

        public static State GetStateWithoutLgas(string name)
        {
            var state = GetStateWithLgas(name);
            state.Lgas = null;

            return state;
        }

        /// <summary>
        /// Retrieves a list of states, prioritizing the specified state by placing it at the beginning.
        /// If the specified state is not found or the ID is invalid, all states are returned without prioritization.
        /// </summary>
        /// <param name="priorityStateId">The id of the state to prioritize. Must be greater than 0 and within the range of existing states</param>
        /// <returns>An <see cref="IEnumerable{State}"/> containing all states with their LGAs with a priority state moved to the top of the list.</returns>
        /// <exception cref="InvalidOperationException"> Thrown if no state with the specified <paramref name="priorityStateId"/> exists
        /// </exception>
        public static IEnumerable<State> GetStatesWithLgas(int priorityStateId)
        {            
            if (priorityStateId > 0 && priorityStateId <= States.Count)
            {
                var stateToPrioritize = States.Single(s => s.Id == priorityStateId);

                // return the prioritized state first followed by the remaining states, excluding the prioritized one.
                return new List<State> { stateToPrioritize }
                    .Concat(States.Where(x => x.Id != priorityStateId));
            }

            return GetStatesWithLgas();
        }
    }
}
