#### [DiGi\.Communication](DiGi.Communication.Overview.md 'DiGi\.Communication\.Overview')

## DiGi\.Communication\.Obselete\.Delegates Namespace
### Delegates

<a name='DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double)'></a>

## AntennaCharacteristic\(double, double\) Delegate

Normalized antenna radiation characteristic g\(theta, phi\)\. The normalization condition is the integral of \|g\(theta, phi\)\|^2 over the full solid angle equal to 1\.

```csharp
public delegate double AntennaCharacteristic(double theta, double phi);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double).theta'></a>

`theta` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Polar angle theta \[rad\] measured from the OZ axis\.

<a name='DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double).phi'></a>

`phi` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Azimuth angle phi \[rad\] measured in the XOY plane from the OX axis\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Value of the normalized radiation characteristic for the given direction\.