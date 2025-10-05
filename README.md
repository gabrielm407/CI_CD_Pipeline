# CI/CD Pipeline Demo (C#)

This project demonstrates a simple CI/CD pipeline using GitHub Actions for a basic C# (.NET) application.  
It also follows common practices of GitHub repository security practices. 

## Project Structure

```
ci-cd-pipeline-demo
├── src
│   └── Program.cs
├── ci-cd-pipeline-demo.csproj
├── .github
│   └── workflows
│       └── deployment.yml
│       └── codeql.yml
└── README.md
```

## Getting Started

1. **Clone the repository**:
   ```
   git clone <repository-url>
   cd ci-cd-pipeline-demo
   ```

2. **Restore dependencies**:
   ```
   dotnet restore
   ```

3. **Run the application**:
   ```
   dotnet run --project src
   ```

## CI/CD Pipeline

The pipeline is defined in `.github/workflows/deployment.yml` and runs build and test jobs on push and pull request events.  
There is another pipeline called `.github/workflows/codeql.yml` and this a pipeline that checks the code at a certain time each week and checks if there are vulnerabilities.

## License

MIT
