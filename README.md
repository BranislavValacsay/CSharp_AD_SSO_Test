# Custom SSO Demo for Windows Domain

C# demonstration of a custom Single Sign-On (SSO) implementation for Windows domain environments.

## Description

This project showcases a custom-built Single Sign-On (SSO) solution for Windows domain environments. It leverages Active Directory for authentication and provides a seamless login experience for domain users.

## Features

- Custom SSO implementation for Windows domain
- Integration with local Active Directory (Not Azure version)
- Can be integrated with Automatic user authentication using current Windows credentials
- Can be integrated with Role-based access control
- Can be integrated with Secure token generation and validation
- Can be integrated with Session management

## Technologies Used

- C# (.NET Framework)
- Active Directory Domain Services
- Windows Authentication
- System.DirectoryServices.AccountManagement namespace

## Project Structure

- `Program.cs`: Entry point of the application
- `ActiveDirectoryService.cs`: Core SSO logic implementation,Handles Active Directory authentication
- `AuthController.cs` : API controller that verifies requet. This controller is able to read user ID and attempt to verify user in AD independently

## Setup and Usage

1. Clone this repository
2. Open the solution in Visual Studio
3. Ensure your development machine is part of a Windows domain
4. Update the `ActiveDirectoryService.cs` file with your domain settings
5. Build and run the application

Note: This demo requires a Windows domain environment to function properly.

## License

This project is open source and available under the [MIT License](https://opensource.org/licenses/MIT).

---

Created by [Branislav Valacsay]
