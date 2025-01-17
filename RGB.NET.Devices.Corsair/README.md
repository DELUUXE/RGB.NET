﻿[RGB.NET](https://github.com/DarthAffe/RGB.NET) Device-Provider-Package for Corsair-Devices.

## Usage
This provider follows the default pattern and does not require additional setup.

```csharp
surface.Load(CorsairDeviceProvider.Instance);
```

# Required SDK
This providers requires native SDK-dlls.   
You can get them directly from Corsair at [https://github.com/CorsairOfficial/cue-sdk/releases](https://github.com/CorsairOfficial/cue-sdk/releases)

Since the SDK-dlls are native it's important to use the correct architecture you're building your application for. (If in doubt you can always include both.)

### x64
`redist\x64\CUESDK.x64_2019.dll` from the SDK-zip needs to be distributed as `<application-directory>\x64\CUESDK.x64_2019.dll` (or simply named `CUESDK.dll`)

You can use other, custom paths by adding them to `CorsairDeviceProvider.PossibleX64NativePaths`.

### x86
`redist\i386\CUESDK_2019.dll` from the SDK-zip needs to be distributed as `<application-directory>\x86\CUESDK_2019.dll` (or simply named `CUESDK.dll`)

You can use other, custom paths by adding them to `CorsairDeviceProvider.PossibleX86NativePaths`.
