[![NuGet Version](https://img.shields.io/nuget/v/Drastic.LeakCanary.svg)](https://www.nuget.org/packages/Drastic.LeakCanary/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# Drastic.LeakCanary

Drastic.Flipper is a .NET binding of [LeakCanary](https://github.com/square/leakcanary), A memory leak detection library for Android.

## Setup

- Install the `Drastic.LeakCanary` nuget
- Add the following to your Application to start the LeakCanary process:

```csharp
    public override void OnCreate()
    {
        base.OnCreate();
        Leakcanary.AppWatcher.Instance.ManualInstall(this);
    }
```

You should see

```
[LeakCanary] LeakCanary is running and ready to detect memory leaks.
```

In your logs.