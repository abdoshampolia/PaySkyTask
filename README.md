# Purchase API

This is a simple .NET 8 Web API that processes payments through different banks based on the provided nationality ID using the Factory Pattern.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Running the API

1. **Clone the repository**
    ```sh
    git clone https://github.com/abdoshampolia/PaySkyTask.git
    cd PurchaseAPI
    ```

2. **Restore the dependencies**
    ```sh
    dotnet restore
    ```

3. **Run the API**
    ```sh
    dotnet run
    ```

### API Usage
    ```sh Sample NationalId To Test PurchaseApi

        UAE: 784-1995-1234567-8
        EGY: 29802060123456
        SU : 1023456789 
-     ```

- **POST /purchase**

  Request Body:
  ```json
  {
      "nationalityId": 1
  }
