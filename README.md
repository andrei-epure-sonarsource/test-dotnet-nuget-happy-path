# NuGet happy-path fixture

This .NET 10 console application is a valid SonarQube Cloud automatic-analysis fixture. It uses `Newtonsoft.Json` to serialize a small order summary and has no intentionally broken dependencies.

```sh
dotnet restore
dotnet build --no-restore
dotnet run --no-build
```

Automatic analysis should resolve `Newtonsoft.Json`, compile the application, and complete without NuGet resolution warnings or errors.
