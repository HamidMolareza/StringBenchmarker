## Getting Started

### Prerequisites
Before you begin, ensure you have one of following items installed:
- **Docker:** Ensure Docker is installed and running on your system.
- **.NET SDK 8.0**

### Using Docker

To get started with `StringBenchmarker` using Docker, follow these steps:

1. **Build the Docker image:**
   ```bash
   docker build -t stringbenchmarker .
   ```

2. **Run docker:**
    ```bash
    docker run --rm -v $(pwd)/StringBenchmarker:/app stringbenchmarker
    ```

3. **Clear:**
    ```bash
    docker rmi -f stringbenchmarker
    ```

### Using .NET 8

To get started with StringBenchmarker using .NET 8, follow these steps:

1. **Restore dependencies and build the project:**
   ```bash
   dotnet restore
   dotnet build --configuration Release --no-restore
   ```

2. **Run:**
    ```bash
    dotnet run --project StringBenchmarker.csproj --configuration Release --no-build
    ```