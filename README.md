# Abstract Factory Course Setup

`Abstract_Factory` is a console application that demonstrates an **Abstract Factory**–based workflow for composing lectures, practicals, coursework, and submission defense mechanisms based on a JSON configuration file.  
It wires together lecture and practice sessions, teachers, and coursework rules without requiring consumers to know concrete implementations.

---

## Features

- Reads course metadata (course name, group, teachers, sessions) from a JSON configuration file
- Constructs sessions using `Lecture`, `Practice`, and factory classes to keep responsibilities separated
- Selects coursework submission strategies dynamically:
  - `GitHubRepoDefense`
  - `OnlineUploadDefense`
  - `OfflineDefense`
- Outputs a structured enrollment summary including:
  - Course information
  - Assigned teachers
  - Timetable slots
  - Coursework defense strategy

---

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Command-line environment (PowerShell, Terminal, Bash)

---

## Usage

### Run the Application

1. Prepare a course configuration JSON file (see example below)
2. Run the application from the solution directory:

```bash
dotnet run --project Abstract_Factory -- course.json
```

3. Review the console output for course, teacher, session, and coursework details

---

## Configuration Example

```json
{
  "course": "Programming",
  "group": "KP-42",
  "lecturer": {
    "name": "Dr. Ivanova"
  },
  "assistant": {
    "name": "Mr. Petrenko"
  },
  "supervisor": {
    "name": "Prof. Shcherba"
  },
  "lecture": {
    "day": "Monday",
    "start": "08:30",
    "end": "10:00",
    "room": "129"
  },
  "practical": {
    "day": "Thursday",
    "start": "12:10",
    "end": "13:45",
    "room": "4"
  },
  "courseworkName": "Programming Project"
}
```

The configuration parser is tolerant to missing values.  
If some fields are omitted, default values will be applied automatically.

---

## Testing

Unit tests are located in the `Abstract_Factory.Tests` project.

To run tests:

```bash
cd Abstract_Factory.Tests
dotnet test
```
