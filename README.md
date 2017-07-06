# System.IO.Abstractions

For .Net core.

This is a fork of https://github.com/tathamoddie/System.IO.Abstractions
until the official repo supports .Net core.

As such, it is not on nuget.

# Installing

    npm install --save shadowmint/System.IO.Abstractions

Now add the `NuGet.Config` to the project folder:

    <?xml version="1.0" encoding="utf-8"?>
    <configuration>
     <packageSources>
        <add key="local" value="./packages" />
     </packageSources>
    </configuration>

Now you can install the package:

    dotnet add package System.IO.Abstractions -v 3.0.0

You may also want to use `dotnet nuget locals all --clear` to clear cached objects.

# Building a new package version

    npm run build

# Testing

    npm test
