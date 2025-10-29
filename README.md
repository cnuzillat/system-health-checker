# system-health-checker

## Overview

**System Health Checker** is a lightweight C# console application designed to verify the online status of a website or URL. It allows users to quickly check if a web service is up and running, making it a handy tool for system administrators, developers, and anyone who needs to monitor website availability.

## Features

- **URL Status Check:** Enter any website or URL to determine if it is online.
- **Clear Output:** The application provides clear, concise feedback about the status of the URL.
- **Lightweight:** Minimal dependencies and quick to run.
- **Easy to Use:** Simple command-line interface.
- **Extensible:** Built with C# for easy customization or integration into larger systems.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (Core or Framework, compatible with your OS)

### Building the Application

1. Clone the repository:
   ```bash
   git clone https://github.com/cnuzillat/system-health-checker.git
   cd system-health-checker
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

### Running the Application

To check a website's status, run:

```bash
dotnet run -- <URL>
```

**Example:**
```bash
dotnet run -- https://www.example.com
```

The application will report whether the specified URL is online or offline.

## Usage

- Input a URL when prompted or pass it as a command-line argument.
- The application will attempt to reach the URL and report its status.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for improvements, new features, or bug fixes.

## Author

- [cnuzillat](https://github.com/cnuzillat)
