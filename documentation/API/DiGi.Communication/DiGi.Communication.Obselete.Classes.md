#### [DiGi\.Communication](DiGi.Communication.Overview.md 'DiGi\.Communication\.Overview')

## DiGi\.Communication\.Obselete\.Classes Namespace
### Classes

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay'></a>

## ArrivalRay Class

Ray arriving at the receiving antenna: an arrival direction \(theta, phi\) with its assigned corrected power p\_nkl\.

```csharp
public class ArrivalRay : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ArrivalRay

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.ArrivalRay(DiGi.Communication.Obselete.Classes.ArrivalRay)'></a>

## ArrivalRay\(ArrivalRay\) Constructor

Initializes a new instance of the [ArrivalRay](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.ArrivalRay 'DiGi\.Communication\.Obselete\.Classes\.ArrivalRay') class by copying another ray\.

```csharp
public ArrivalRay(DiGi.Communication.Obselete.Classes.ArrivalRay? arrivalRay);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.ArrivalRay(DiGi.Communication.Obselete.Classes.ArrivalRay).arrivalRay'></a>

`arrivalRay` [ArrivalRay](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.ArrivalRay 'DiGi\.Communication\.Obselete\.Classes\.ArrivalRay')

The source ray to copy from\.

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.ArrivalRay(double,double,double)'></a>

## ArrivalRay\(double, double, double\) Constructor

Initializes a new instance of the [ArrivalRay](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.ArrivalRay 'DiGi\.Communication\.Obselete\.Classes\.ArrivalRay') class\.

```csharp
public ArrivalRay(double theta, double phi, double power);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.ArrivalRay(double,double,double).theta'></a>

`theta` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Polar angle theta\_kl \[rad\] of the arrival direction, measured from the OZ axis at the receiver\.

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.ArrivalRay(double,double,double).phi'></a>

`phi` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Azimuth angle phi\_kl \[rad\] of the arrival direction, measured in the XOY plane from the OX axis at the receiver\.

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.ArrivalRay(double,double,double).power'></a>

`power` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Corrected normalized power p\_nkl assigned to the ray \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.ArrivalRay(System.Text.Json.Nodes.JsonObject)'></a>

## ArrivalRay\(JsonObject\) Constructor

Initializes a new instance of the [ArrivalRay](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.ArrivalRay 'DiGi\.Communication\.Obselete\.Classes\.ArrivalRay') class from a JsonObject\.

```csharp
public ArrivalRay(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.ArrivalRay(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.phi'></a>

## ArrivalRay\.phi Field

Azimuth angle phi\_kl \[rad\] of the arrival direction, measured in the XOY plane from the OX axis at the receiver\.

```csharp
private readonly double phi;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.power'></a>

## ArrivalRay\.power Field

Corrected normalized power p\_nkl assigned to the ray \[\-\]\.

```csharp
private readonly double power;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.theta'></a>

## ArrivalRay\.theta Field

Polar angle theta\_kl \[rad\] of the arrival direction, measured from the OZ axis at the receiver\.

```csharp
private readonly double theta;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Properties

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.Phi'></a>

## ArrivalRay\.Phi Property

Azimuth angle phi\_kl \[rad\] of the arrival direction, measured in the XOY plane from the OX axis at the receiver\.

```csharp
public double Phi { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.Power'></a>

## ArrivalRay\.Power Property

Corrected normalized power p\_nkl assigned to the ray \[\-\]\.

```csharp
public double Power { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.ArrivalRay.Theta'></a>

## ArrivalRay\.Theta Property

Polar angle theta\_kl \[rad\] of the arrival direction, measured from the OZ axis at the receiver\.

```csharp
public double Theta { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent'></a>

## EllipsoidComponent Class

Power component P\_n of a single propagation ellipsoid related to the delay tau\_n of the Power Delay Profile\.

```csharp
public class EllipsoidComponent : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → EllipsoidComponent

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(DiGi.Communication.Obselete.Classes.EllipsoidComponent)'></a>

## EllipsoidComponent\(EllipsoidComponent\) Constructor

Initializes a new instance of the [EllipsoidComponent](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.EllipsoidComponent 'DiGi\.Communication\.Obselete\.Classes\.EllipsoidComponent') class by copying another ellipsoid component\.

```csharp
public EllipsoidComponent(DiGi.Communication.Obselete.Classes.EllipsoidComponent? ellipsoidComponent);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(DiGi.Communication.Obselete.Classes.EllipsoidComponent).ellipsoidComponent'></a>

`ellipsoidComponent` [EllipsoidComponent](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.EllipsoidComponent 'DiGi\.Communication\.Obselete\.Classes\.EllipsoidComponent')

The source ellipsoid component to copy from\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double)'></a>

## EllipsoidComponent\(double, double, double, double, double, double, IEnumerable\<RayContribution\>, double, Complex, double, double\) Constructor

Initializes a new instance of the [EllipsoidComponent](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.EllipsoidComponent 'DiGi\.Communication\.Obselete\.Classes\.EllipsoidComponent') class\.

```csharp
public EllipsoidComponent(double delay, double fractionalPower, double mappingErrorCorrectionCoefficient, double measuredFractionalPower, double power, double powerEquivalenceCoefficient, System.Collections.Generic.IEnumerable<DiGi.Communication.Obselete.Classes.RayContribution>? rayContributions, double referencePower, System.Numerics.Complex reflectionCoefficientSum, double semiMajorAxis, double semiMinorAxis);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Delay tau\_n \[s\] related to the ellipsoid\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).fractionalPower'></a>

`fractionalPower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Normalized power p\_n = P\_n / P resulting from the model \[\-\]\. Calculated in Stage II\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).mappingErrorCorrectionCoefficient'></a>

`mappingErrorCorrectionCoefficient` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Correction coefficient w\_0n = p'\_n / p\_n for ray scattering object mapping errors \[\-\]\. Calculated in Stage II\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).measuredFractionalPower'></a>

`measuredFractionalPower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Normalized \(fractional\) power p'\_n retrieved directly from the measured Power Delay Profile \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).power'></a>

`power` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Component power P\_n = \|Gamma\_n\|^2 \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).powerEquivalenceCoefficient'></a>

`powerEquivalenceCoefficient` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Power equivalence coefficient w\_Pn = P\_n / P'\_n \[\-\]\. Calculated in Stage II\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).rayContributions'></a>

`rayContributions` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[RayContribution](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.RayContribution 'DiGi\.Communication\.Obselete\.Classes\.RayContribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Contributions of the mesh cells assigned to the ellipsoid\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).referencePower'></a>

`referencePower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Reference power P'\_n: sum of squared moduli of the weighted reflection coefficients \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).reflectionCoefficientSum'></a>

`reflectionCoefficientSum` [System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

Sum Gamma\_n of the weighted complex reflection coefficients of the whole ellipsoid \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).semiMajorAxis'></a>

`semiMajorAxis` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Semi\-major axis a\_n of the ellipsoid \[m\]\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.RayContribution_,double,System.Numerics.Complex,double,double).semiMinorAxis'></a>

`semiMinorAxis` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Semi\-minor axes b\_n = c\_n of the ellipsoid \[m\]\.

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(System.Text.Json.Nodes.JsonObject)'></a>

## EllipsoidComponent\(JsonObject\) Constructor

Initializes a new instance of the [EllipsoidComponent](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.EllipsoidComponent 'DiGi\.Communication\.Obselete\.Classes\.EllipsoidComponent') class from a JsonObject\.

```csharp
public EllipsoidComponent(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.EllipsoidComponent(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.delay'></a>

## EllipsoidComponent\.delay Field

Delay tau\_n \[s\] related to the ellipsoid\.

```csharp
private readonly double delay;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.fractionalPower'></a>

## EllipsoidComponent\.fractionalPower Field

Normalized power p\_n = P\_n / P resulting from the model \[\-\]\. Calculated in Stage II\.

```csharp
private readonly double fractionalPower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.mappingErrorCorrectionCoefficient'></a>

## EllipsoidComponent\.mappingErrorCorrectionCoefficient Field

Correction coefficient w\_0n = p'\_n / p\_n for ray scattering object mapping errors \[\-\]\. Calculated in Stage II\.

```csharp
private readonly double mappingErrorCorrectionCoefficient;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.measuredFractionalPower'></a>

## EllipsoidComponent\.measuredFractionalPower Field

Normalized \(fractional\) power p'\_n retrieved directly from the measured Power Delay Profile \[\-\]\.

```csharp
private readonly double measuredFractionalPower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.power'></a>

## EllipsoidComponent\.power Field

Component power P\_n = \|Gamma\_n\|^2 \[\-\]\.

```csharp
private readonly double power;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.powerEquivalenceCoefficient'></a>

## EllipsoidComponent\.powerEquivalenceCoefficient Field

Power equivalence coefficient w\_Pn = P\_n / P'\_n \[\-\]\. Calculated in Stage II\.

```csharp
private readonly double powerEquivalenceCoefficient;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.rayContributions'></a>

## EllipsoidComponent\.rayContributions Field

Contributions of the mesh cells assigned to the ellipsoid\.

```csharp
private readonly List<RayContribution>? rayContributions;
```

#### Field Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[RayContribution](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.RayContribution 'DiGi\.Communication\.Obselete\.Classes\.RayContribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.referencePower'></a>

## EllipsoidComponent\.referencePower Field

Reference power P'\_n: sum of squared moduli of the weighted reflection coefficients \[\-\]\.

```csharp
private readonly double referencePower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.reflectionCoefficientSum'></a>

## EllipsoidComponent\.reflectionCoefficientSum Field

Sum Gamma\_n of the weighted complex reflection coefficients of the whole ellipsoid \[\-\]\.

```csharp
private readonly Complex reflectionCoefficientSum;
```

#### Field Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.semiMajorAxis'></a>

## EllipsoidComponent\.semiMajorAxis Field

Semi\-major axis a\_n of the ellipsoid \[m\]\.

```csharp
private readonly double semiMajorAxis;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.semiMinorAxis'></a>

## EllipsoidComponent\.semiMinorAxis Field

Semi\-minor axes b\_n = c\_n of the ellipsoid \[m\]\.

```csharp
private readonly double semiMinorAxis;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Properties

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.Delay'></a>

## EllipsoidComponent\.Delay Property

Delay tau\_n \[s\] related to the ellipsoid\.

```csharp
public double Delay { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.FractionalPower'></a>

## EllipsoidComponent\.FractionalPower Property

Normalized power p\_n = P\_n / P resulting from the model \[\-\]\. Calculated in Stage II\.

```csharp
public double FractionalPower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.MappingErrorCorrectionCoefficient'></a>

## EllipsoidComponent\.MappingErrorCorrectionCoefficient Property

Correction coefficient w\_0n = p'\_n / p\_n for ray scattering object mapping errors \[\-\]\. Calculated in Stage II\.

```csharp
public double MappingErrorCorrectionCoefficient { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.MeasuredFractionalPower'></a>

## EllipsoidComponent\.MeasuredFractionalPower Property

Normalized \(fractional\) power p'\_n retrieved directly from the measured Power Delay Profile \[\-\]\.

```csharp
public double MeasuredFractionalPower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.Power'></a>

## EllipsoidComponent\.Power Property

Component power P\_n = \|Gamma\_n\|^2 \[\-\]\.

```csharp
public double Power { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.PowerEquivalenceCoefficient'></a>

## EllipsoidComponent\.PowerEquivalenceCoefficient Property

Power equivalence coefficient w\_Pn = P\_n / P'\_n \[\-\]\. Calculated in Stage II\.

```csharp
public double PowerEquivalenceCoefficient { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.RayContributions'></a>

## EllipsoidComponent\.RayContributions Property

Contributions of the mesh cells assigned to the ellipsoid\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Obselete.Classes.RayContribution>? RayContributions { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[RayContribution](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.RayContribution 'DiGi\.Communication\.Obselete\.Classes\.RayContribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.ReferencePower'></a>

## EllipsoidComponent\.ReferencePower Property

Reference power P'\_n: sum of squared moduli of the weighted reflection coefficients \[\-\]\.

```csharp
public double ReferencePower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.ReflectionCoefficientSum'></a>

## EllipsoidComponent\.ReflectionCoefficientSum Property

Sum Gamma\_n of the weighted complex reflection coefficients of the whole ellipsoid \[\-\]\.

```csharp
public System.Numerics.Complex ReflectionCoefficientSum { get; }
```

#### Property Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.SemiMajorAxis'></a>

## EllipsoidComponent\.SemiMajorAxis Property

Semi\-major axis a\_n of the ellipsoid \[m\]\.

```csharp
public double SemiMajorAxis { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.EllipsoidComponent.SemiMinorAxis'></a>

## EllipsoidComponent\.SemiMinorAxis Property

Semi\-minor axes b\_n = c\_n of the ellipsoid \[m\]\.

```csharp
public double SemiMinorAxis { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties'></a>

## MaterialProperties Class

Electrical material properties of a scattering object\.

```csharp
public class MaterialProperties : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → MaterialProperties

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.MaterialProperties(DiGi.Communication.Obselete.Classes.MaterialProperties)'></a>

## MaterialProperties\(MaterialProperties\) Constructor

Initializes a new instance of the [MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties') class by copying another material properties instance\.

```csharp
public MaterialProperties(DiGi.Communication.Obselete.Classes.MaterialProperties? materialProperties);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.MaterialProperties(DiGi.Communication.Obselete.Classes.MaterialProperties).materialProperties'></a>

`materialProperties` [MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')

The source material properties to copy from\.

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.MaterialProperties(double,double)'></a>

## MaterialProperties\(double, double\) Constructor

Initializes a new instance of the [MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties') class\.

```csharp
public MaterialProperties(double relativePermittivity, double conductivity);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.MaterialProperties(double,double).relativePermittivity'></a>

`relativePermittivity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Relative electrical permittivity of the object \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.MaterialProperties(double,double).conductivity'></a>

`conductivity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Electrical conductivity of the object \[S/m\]\.

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.MaterialProperties(System.Text.Json.Nodes.JsonObject)'></a>

## MaterialProperties\(JsonObject\) Constructor

Initializes a new instance of the [MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties') class from a JsonObject\.

```csharp
public MaterialProperties(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.MaterialProperties(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.conductivity'></a>

## MaterialProperties\.conductivity Field

Electrical conductivity sigma\_k of the object \[S/m\]\.

```csharp
private readonly double conductivity;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.relativePermittivity'></a>

## MaterialProperties\.relativePermittivity Field

Relative electrical permittivity epsilon\_wk of the object \[\-\]\.

```csharp
private readonly double relativePermittivity;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Properties

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.Conductivity'></a>

## MaterialProperties\.Conductivity Property

Electrical conductivity sigma\_k of the object \[S/m\]\.

```csharp
public double Conductivity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.MaterialProperties.RelativePermittivity'></a>

## MaterialProperties\.RelativePermittivity Property

Relative electrical permittivity epsilon\_wk of the object \[\-\]\.

```csharp
public double RelativePermittivity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.MeshCell'></a>

## MeshCell Class

Triangular spatial cell of the scattering object mesh\. Coordinates are expressed in the model coordinate system: the transmitter is placed at the origin, the transmitter\-receiver direction determines the OX axis and the earth surface forms the XOY plane\.

```csharp
public class MeshCell : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → MeshCell

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Obselete.Classes.MeshCell.MeshCell(DiGi.Communication.Obselete.Classes.MeshCell)'></a>

## MeshCell\(MeshCell\) Constructor

Initializes a new instance of the [MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell') class by copying another mesh cell\.

```csharp
public MeshCell(DiGi.Communication.Obselete.Classes.MeshCell? meshCell);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.MeshCell.MeshCell(DiGi.Communication.Obselete.Classes.MeshCell).meshCell'></a>

`meshCell` [MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell')

The source mesh cell to copy from\.

<a name='DiGi.Communication.Obselete.Classes.MeshCell.MeshCell(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Communication.Obselete.Classes.MaterialProperties)'></a>

## MeshCell\(Point3D, Vector3D, MaterialProperties\) Constructor

Initializes a new instance of the [MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell') class\.

```csharp
public MeshCell(DiGi.Geometry.Spatial.Classes.Point3D? center, DiGi.Geometry.Spatial.Classes.Vector3D? normal, DiGi.Communication.Obselete.Classes.MaterialProperties? materialProperties);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.MeshCell.MeshCell(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Communication.Obselete.Classes.MaterialProperties).center'></a>

`center` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

Center of gravity of the triangular cell \[m\]\.

<a name='DiGi.Communication.Obselete.Classes.MeshCell.MeshCell(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Communication.Obselete.Classes.MaterialProperties).normal'></a>

`normal` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

Normal vector of the cell plane\.

<a name='DiGi.Communication.Obselete.Classes.MeshCell.MeshCell(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Communication.Obselete.Classes.MaterialProperties).materialProperties'></a>

`materialProperties` [MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')

Electrical material properties of the cell\.

<a name='DiGi.Communication.Obselete.Classes.MeshCell.MeshCell(System.Text.Json.Nodes.JsonObject)'></a>

## MeshCell\(JsonObject\) Constructor

Initializes a new instance of the [MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell') class from a JsonObject\.

```csharp
public MeshCell(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.MeshCell.MeshCell(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Obselete.Classes.MeshCell.center'></a>

## MeshCell\.center Field

Center of gravity of the triangular cell \[m\]\.

```csharp
private readonly Point3D? center;
```

#### Field Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Obselete.Classes.MeshCell.materialProperties'></a>

## MeshCell\.materialProperties Field

Electrical material properties of the cell\.

```csharp
private readonly MaterialProperties? materialProperties;
```

#### Field Value
[MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')

<a name='DiGi.Communication.Obselete.Classes.MeshCell.normal'></a>

## MeshCell\.normal Field

Normal vector of the cell plane\.

```csharp
private readonly Vector3D? normal;
```

#### Field Value
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')
### Properties

<a name='DiGi.Communication.Obselete.Classes.MeshCell.Center'></a>

## MeshCell\.Center Property

Center of gravity of the triangular cell \[m\]\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Center { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Obselete.Classes.MeshCell.MaterialProperties'></a>

## MeshCell\.MaterialProperties Property

Electrical material properties of the cell\.

```csharp
public DiGi.Communication.Obselete.Classes.MaterialProperties? MaterialProperties { get; }
```

#### Property Value
[MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')

<a name='DiGi.Communication.Obselete.Classes.MeshCell.Normal'></a>

## MeshCell\.Normal Property

Normal vector of the cell plane\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Normal { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel'></a>

## PropagationModel Class

Input data of the multi\-ellipsoidal propagation model\. The model coordinate system places the transmitter \(Tx\) at the origin, the receiver \(Rx\) at \(Distance, 0, 0\) — the Tx\-Rx direction determines the OX axis — and the earth surface forms the XOY plane\.

```csharp
public class PropagationModel : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → PropagationModel

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(DiGi.Communication.Obselete.Classes.PropagationModel)'></a>

## PropagationModel\(PropagationModel\) Constructor

Initializes a new instance of the [PropagationModel](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationModel 'DiGi\.Communication\.Obselete\.Classes\.PropagationModel') class by copying another propagation model\.

```csharp
public PropagationModel(DiGi.Communication.Obselete.Classes.PropagationModel? propagationModel);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(DiGi.Communication.Obselete.Classes.PropagationModel).propagationModel'></a>

`propagationModel` [PropagationModel](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationModel 'DiGi\.Communication\.Obselete\.Classes\.PropagationModel')

The source propagation model to copy from\.

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.MeshCell_,DiGi.Communication.Obselete.Enums.Polarization,DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic)'></a>

## PropagationModel\(double, double, IEnumerable\<MeshCell\>, Polarization, SimpleMultipathPowerDelayProfile, AntennaCharacteristic, AntennaCharacteristic, AntennaCharacteristic, AntennaCharacteristic\) Constructor

Initializes a new instance of the [PropagationModel](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationModel 'DiGi\.Communication\.Obselete\.Classes\.PropagationModel') class\.

```csharp
public PropagationModel(double distance, double frequency, System.Collections.Generic.IEnumerable<DiGi.Communication.Obselete.Classes.MeshCell>? meshCells, DiGi.Communication.Obselete.Enums.Polarization polarization, DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile, DiGi.Communication.Obselete.Delegates.AntennaCharacteristic? receivingDirectionalCharacteristic, DiGi.Communication.Obselete.Delegates.AntennaCharacteristic? receivingOmnidirectionalCharacteristic, DiGi.Communication.Obselete.Delegates.AntennaCharacteristic? transmittingDirectionalCharacteristic, DiGi.Communication.Obselete.Delegates.AntennaCharacteristic? transmittingOmnidirectionalCharacteristic);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.MeshCell_,DiGi.Communication.Obselete.Enums.Polarization,DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Distance d between the transmitter and receiver \[m\]\.

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.MeshCell_,DiGi.Communication.Obselete.Enums.Polarization,DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic).frequency'></a>

`frequency` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Frequency f of the propagating electromagnetic wave \[MHz\]\.

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.MeshCell_,DiGi.Communication.Obselete.Enums.Polarization,DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic).meshCells'></a>

`meshCells` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Triangular spatial cells representing the scattering objects\.

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.MeshCell_,DiGi.Communication.Obselete.Enums.Polarization,DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic).polarization'></a>

`polarization` [Polarization](DiGi.Communication.Obselete.Enums.md#DiGi.Communication.Obselete.Enums.Polarization 'DiGi\.Communication\.Obselete\.Enums\.Polarization')

Polarization type of the propagating electromagnetic wave\.

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.MeshCell_,DiGi.Communication.Obselete.Enums.Polarization,DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic).simpleMultipathPowerDelayProfile'></a>

`simpleMultipathPowerDelayProfile` [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile')

Normalized Power Delay Profile \(PDP\): delays tau\_n mapped to the normalized \(fractional\) powers p'\_n\.

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.MeshCell_,DiGi.Communication.Obselete.Enums.Polarization,DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic).receivingDirectionalCharacteristic'></a>

`receivingDirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

Normalized reception characteristic g\(theta, phi\) of the directional receiving antenna\.

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.MeshCell_,DiGi.Communication.Obselete.Enums.Polarization,DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic).receivingOmnidirectionalCharacteristic'></a>

`receivingOmnidirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

Normalized reception characteristic g\_0\(theta, phi\) of the omnidirectional receiving antenna\.

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.MeshCell_,DiGi.Communication.Obselete.Enums.Polarization,DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic).transmittingDirectionalCharacteristic'></a>

`transmittingDirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

Normalized radiation characteristic g\_T\(theta, phi\) of the directional transmitting antenna\.

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.MeshCell_,DiGi.Communication.Obselete.Enums.Polarization,DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic,DiGi.Communication.Obselete.Delegates.AntennaCharacteristic).transmittingOmnidirectionalCharacteristic'></a>

`transmittingOmnidirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

Normalized radiation characteristic g\_T0\(theta, phi\) of the omnidirectional transmitting antenna\.

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(System.Text.Json.Nodes.JsonObject)'></a>

## PropagationModel\(JsonObject\) Constructor

Initializes a new instance of the [PropagationModel](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationModel 'DiGi\.Communication\.Obselete\.Classes\.PropagationModel') class from a JsonObject\.

```csharp
public PropagationModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.PropagationModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.distance'></a>

## PropagationModel\.distance Field

Distance d between the transmitter and receiver \[m\]\.

```csharp
private readonly double distance;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.frequency'></a>

## PropagationModel\.frequency Field

Frequency f of the propagating electromagnetic wave \[MHz\]\.

```csharp
private readonly double frequency;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.meshCells'></a>

## PropagationModel\.meshCells Field

Triangular spatial cells representing the scattering objects\.

```csharp
private readonly List<MeshCell>? meshCells;
```

#### Field Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.polarization'></a>

## PropagationModel\.polarization Field

Polarization type of the propagating electromagnetic wave\.

```csharp
private readonly Polarization polarization;
```

#### Field Value
[Polarization](DiGi.Communication.Obselete.Enums.md#DiGi.Communication.Obselete.Enums.Polarization 'DiGi\.Communication\.Obselete\.Enums\.Polarization')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.receivingDirectionalCharacteristic'></a>

## PropagationModel\.receivingDirectionalCharacteristic Field

Normalized reception characteristic g\(theta, phi\) of the directional receiving antenna\. Not serializable: excluded from JSON persistence and cloning restores a [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') reference\.

```csharp
private readonly AntennaCharacteristic? receivingDirectionalCharacteristic;
```

#### Field Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.receivingOmnidirectionalCharacteristic'></a>

## PropagationModel\.receivingOmnidirectionalCharacteristic Field

Normalized reception characteristic g\_0\(theta, phi\) of the omnidirectional receiving antenna\. Not serializable: excluded from JSON persistence and cloning restores a [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') reference\.

```csharp
private readonly AntennaCharacteristic? receivingOmnidirectionalCharacteristic;
```

#### Field Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.simpleMultipathPowerDelayProfile'></a>

## PropagationModel\.simpleMultipathPowerDelayProfile Field

Normalized Power Delay Profile \(PDP\): delays tau\_n mapped to the normalized \(fractional\) powers p'\_n\. The fractional powers are expected to sum to 1\.

```csharp
private readonly SimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile;
```

#### Field Value
[SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.transmittingDirectionalCharacteristic'></a>

## PropagationModel\.transmittingDirectionalCharacteristic Field

Normalized radiation characteristic g\_T\(theta, phi\) of the directional transmitting antenna\. Reserved for the transmitting\-side comparison; not used by the receiving\-side comparative analysis\. Not serializable: excluded from JSON persistence and cloning restores a [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') reference\.

```csharp
private readonly AntennaCharacteristic? transmittingDirectionalCharacteristic;
```

#### Field Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.transmittingOmnidirectionalCharacteristic'></a>

## PropagationModel\.transmittingOmnidirectionalCharacteristic Field

Normalized radiation characteristic g\_T0\(theta, phi\) of the omnidirectional transmitting antenna\. Not serializable: excluded from JSON persistence and cloning restores a [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') reference\.

```csharp
private readonly AntennaCharacteristic? transmittingOmnidirectionalCharacteristic;
```

#### Field Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')
### Properties

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.Distance'></a>

## PropagationModel\.Distance Property

Distance d between the transmitter and receiver \[m\]\.

```csharp
public double Distance { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.Frequency'></a>

## PropagationModel\.Frequency Property

Frequency f of the propagating electromagnetic wave \[MHz\]\.

```csharp
public double Frequency { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.MeshCells'></a>

## PropagationModel\.MeshCells Property

Triangular spatial cells representing the scattering objects\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Obselete.Classes.MeshCell>? MeshCells { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.Polarization'></a>

## PropagationModel\.Polarization Property

Polarization type of the propagating electromagnetic wave\.

```csharp
public DiGi.Communication.Obselete.Enums.Polarization Polarization { get; }
```

#### Property Value
[Polarization](DiGi.Communication.Obselete.Enums.md#DiGi.Communication.Obselete.Enums.Polarization 'DiGi\.Communication\.Obselete\.Enums\.Polarization')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.ReceivingDirectionalCharacteristic'></a>

## PropagationModel\.ReceivingDirectionalCharacteristic Property

Normalized reception characteristic g\(theta, phi\) of the directional receiving antenna\.

```csharp
public DiGi.Communication.Obselete.Delegates.AntennaCharacteristic? ReceivingDirectionalCharacteristic { get; }
```

#### Property Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.ReceivingOmnidirectionalCharacteristic'></a>

## PropagationModel\.ReceivingOmnidirectionalCharacteristic Property

Normalized reception characteristic g\_0\(theta, phi\) of the omnidirectional receiving antenna\.

```csharp
public DiGi.Communication.Obselete.Delegates.AntennaCharacteristic? ReceivingOmnidirectionalCharacteristic { get; }
```

#### Property Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.SimpleMultipathPowerDelayProfile'></a>

## PropagationModel\.SimpleMultipathPowerDelayProfile Property

Normalized Power Delay Profile \(PDP\): delays tau\_n mapped to the normalized \(fractional\) powers p'\_n\. The fractional powers are expected to sum to 1\.

```csharp
public DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile? SimpleMultipathPowerDelayProfile { get; }
```

#### Property Value
[SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.TransmittingDirectionalCharacteristic'></a>

## PropagationModel\.TransmittingDirectionalCharacteristic Property

Normalized radiation characteristic g\_T\(theta, phi\) of the directional transmitting antenna\. Reserved for the transmitting\-side comparison; not used by the receiving\-side comparative analysis\.

```csharp
public DiGi.Communication.Obselete.Delegates.AntennaCharacteristic? TransmittingDirectionalCharacteristic { get; }
```

#### Property Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Obselete.Classes.PropagationModel.TransmittingOmnidirectionalCharacteristic'></a>

## PropagationModel\.TransmittingOmnidirectionalCharacteristic Property

Normalized radiation characteristic g\_T0\(theta, phi\) of the omnidirectional transmitting antenna\.

```csharp
public DiGi.Communication.Obselete.Delegates.AntennaCharacteristic? TransmittingOmnidirectionalCharacteristic { get; }
```

#### Property Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.Obselete.Delegates.md#DiGi.Communication.Obselete.Delegates.AntennaCharacteristic(double,double) 'DiGi\.Communication\.Obselete\.Delegates\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Obselete.Classes.PropagationResult'></a>

## PropagationResult Class

Result of the comparative multi\-ellipsoidal propagation analysis\.

```csharp
public class PropagationResult : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → PropagationResult

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.PropagationResult(DiGi.Communication.Obselete.Classes.PropagationResult)'></a>

## PropagationResult\(PropagationResult\) Constructor

Initializes a new instance of the [PropagationResult](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationResult 'DiGi\.Communication\.Obselete\.Classes\.PropagationResult') class by copying another propagation result\.

```csharp
public PropagationResult(DiGi.Communication.Obselete.Classes.PropagationResult? propagationResult);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.PropagationResult(DiGi.Communication.Obselete.Classes.PropagationResult).propagationResult'></a>

`propagationResult` [PropagationResult](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationResult 'DiGi\.Communication\.Obselete\.Classes\.PropagationResult')

The source propagation result to copy from\.

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.PropagationResult(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.EllipsoidComponent_,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.ArrivalRay_,double)'></a>

## PropagationResult\(double, IEnumerable\<EllipsoidComponent\>, IEnumerable\<ArrivalRay\>, double\) Constructor

Initializes a new instance of the [PropagationResult](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationResult 'DiGi\.Communication\.Obselete\.Classes\.PropagationResult') class\.

```csharp
public PropagationResult(double directionalPower, System.Collections.Generic.IEnumerable<DiGi.Communication.Obselete.Classes.EllipsoidComponent>? ellipsoidComponents, System.Collections.Generic.IEnumerable<DiGi.Communication.Obselete.Classes.ArrivalRay>? rays, double totalPower);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.PropagationResult(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.EllipsoidComponent_,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.ArrivalRay_,double).directionalPower'></a>

`directionalPower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Total normalized power P\_0 reaching the receiving antenna after applying the directional reception characteristic \[\-\]\. The final result of the comparative analysis\.

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.PropagationResult(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.EllipsoidComponent_,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.ArrivalRay_,double).ellipsoidComponents'></a>

`ellipsoidComponents` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[EllipsoidComponent](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.EllipsoidComponent 'DiGi\.Communication\.Obselete\.Classes\.EllipsoidComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Ellipsoid components P\_n determined for the individual delays of the Power Delay Profile\.

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.PropagationResult(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.EllipsoidComponent_,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.ArrivalRay_,double).rays'></a>

`rays` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ArrivalRay](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.ArrivalRay 'DiGi\.Communication\.Obselete\.Classes\.ArrivalRay')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Rays arriving at the receiving antenna: arrival directions \(theta\_kl, phi\_kl\) with their assigned corrected powers p\_nkl\.

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.PropagationResult(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.EllipsoidComponent_,System.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.ArrivalRay_,double).totalPower'></a>

`totalPower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Total received power P before applying the directional antenna characteristics \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.PropagationResult(System.Text.Json.Nodes.JsonObject)'></a>

## PropagationResult\(JsonObject\) Constructor

Initializes a new instance of the [PropagationResult](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationResult 'DiGi\.Communication\.Obselete\.Classes\.PropagationResult') class from a JsonObject\.

```csharp
public PropagationResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.PropagationResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.directionalPower'></a>

## PropagationResult\.directionalPower Field

Total normalized power P\_0 reaching the receiving antenna after applying the directional reception characteristic \[\-\]\. The final result of the comparative analysis\.

```csharp
private readonly double directionalPower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.ellipsoidComponents'></a>

## PropagationResult\.ellipsoidComponents Field

Ellipsoid components P\_n determined for the individual delays of the Power Delay Profile\.

```csharp
private readonly List<EllipsoidComponent>? ellipsoidComponents;
```

#### Field Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[EllipsoidComponent](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.EllipsoidComponent 'DiGi\.Communication\.Obselete\.Classes\.EllipsoidComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.rays'></a>

## PropagationResult\.rays Field

Rays arriving at the receiving antenna: arrival directions \(theta\_kl, phi\_kl\) with their assigned corrected powers p\_nkl\. The powers sum to 1 for a normalized Power Delay Profile\.

```csharp
private readonly List<ArrivalRay>? rays;
```

#### Field Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ArrivalRay](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.ArrivalRay 'DiGi\.Communication\.Obselete\.Classes\.ArrivalRay')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.totalPower'></a>

## PropagationResult\.totalPower Field

Total received power P before applying the directional antenna characteristics \[\-\]\.

```csharp
private readonly double totalPower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Properties

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.DirectionalPower'></a>

## PropagationResult\.DirectionalPower Property

Total normalized power P\_0 reaching the receiving antenna after applying the directional reception characteristic \[\-\]\. The final result of the comparative analysis\.

```csharp
public double DirectionalPower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.EllipsoidComponents'></a>

## PropagationResult\.EllipsoidComponents Property

Ellipsoid components P\_n determined for the individual delays of the Power Delay Profile\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Obselete.Classes.EllipsoidComponent>? EllipsoidComponents { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[EllipsoidComponent](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.EllipsoidComponent 'DiGi\.Communication\.Obselete\.Classes\.EllipsoidComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.Rays'></a>

## PropagationResult\.Rays Property

Rays arriving at the receiving antenna: arrival directions \(theta\_kl, phi\_kl\) with their assigned corrected powers p\_nkl\. The powers sum to 1 for a normalized Power Delay Profile\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Obselete.Classes.ArrivalRay>? Rays { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ArrivalRay](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.ArrivalRay 'DiGi\.Communication\.Obselete\.Classes\.ArrivalRay')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Obselete.Classes.PropagationResult.TotalPower'></a>

## PropagationResult\.TotalPower Property

Total received power P before applying the directional antenna characteristics \[\-\]\.

```csharp
public double TotalPower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution'></a>

## RayContribution Class

Contribution of a single mesh cell \(cell l of subset k\) to an ellipsoid component: ray directions, antenna gains and reflection coefficients\.

```csharp
public class RayContribution : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → RayContribution

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(DiGi.Communication.Obselete.Classes.RayContribution)'></a>

## RayContribution\(RayContribution\) Constructor

Initializes a new instance of the [RayContribution](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.RayContribution 'DiGi\.Communication\.Obselete\.Classes\.RayContribution') class by copying another ray contribution\.

```csharp
public RayContribution(DiGi.Communication.Obselete.Classes.RayContribution? rayContribution);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(DiGi.Communication.Obselete.Classes.RayContribution).rayContribution'></a>

`rayContribution` [RayContribution](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.RayContribution 'DiGi\.Communication\.Obselete\.Classes\.RayContribution')

The source ray contribution to copy from\.

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex)'></a>

## RayContribution\(double, double, double, double, Complex, double, double, double, Complex\) Constructor

Initializes a new instance of the [RayContribution](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.RayContribution 'DiGi\.Communication\.Obselete\.Classes\.RayContribution') class\.

```csharp
public RayContribution(double incidenceAngle, double phiReceiver, double phiTransmitter, double receivingGain, System.Numerics.Complex reflectionCoefficient, double thetaReceiver, double thetaTransmitter, double transmittingGain, System.Numerics.Complex weightedReflectionCoefficient);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).incidenceAngle'></a>

`incidenceAngle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Angle of incidence gamma\_kl \[rad\] of the ray on the cell plane, measured from the plane \(grazing angle\)\.

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).phiReceiver'></a>

`phiReceiver` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Azimuth angle phi\_kl \[rad\] of the received ray, with origin at the receiver\.

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).phiTransmitter'></a>

`phiTransmitter` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Azimuth angle phi\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).receivingGain'></a>

`receivingGain` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Normalized reception characteristic value g\_0kl of the omnidirectional receiving antenna for the received ray direction \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).reflectionCoefficient'></a>

`reflectionCoefficient` [System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

Complex reflection coefficient Gamma\_kl of the cell \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).thetaReceiver'></a>

`thetaReceiver` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Polar angle theta\_kl \[rad\] of the received ray, with origin at the receiver\.

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).thetaTransmitter'></a>

`thetaTransmitter` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Polar angle theta\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).transmittingGain'></a>

`transmittingGain` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Normalized radiation characteristic value g\_T0kl of the omnidirectional transmitting antenna for the emitted ray direction \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).weightedReflectionCoefficient'></a>

`weightedReflectionCoefficient` [System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

Weighted complex reflection coefficient Gamma'\_kl = g\_T0kl \* g\_0kl \* Gamma\_kl \[\-\]\.

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(System.Text.Json.Nodes.JsonObject)'></a>

## RayContribution\(JsonObject\) Constructor

Initializes a new instance of the [RayContribution](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.RayContribution 'DiGi\.Communication\.Obselete\.Classes\.RayContribution') class from a JsonObject\.

```csharp
public RayContribution(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Classes.RayContribution.RayContribution(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Obselete.Classes.RayContribution.incidenceAngle'></a>

## RayContribution\.incidenceAngle Field

Angle of incidence gamma\_kl \[rad\] of the ray on the cell plane, measured from the plane \(grazing angle\)\.

```csharp
private readonly double incidenceAngle;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.phiReceiver'></a>

## RayContribution\.phiReceiver Field

Azimuth angle phi\_kl \[rad\] of the received ray, with origin at the receiver\.

```csharp
private readonly double phiReceiver;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.phiTransmitter'></a>

## RayContribution\.phiTransmitter Field

Azimuth angle phi\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

```csharp
private readonly double phiTransmitter;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.receivingGain'></a>

## RayContribution\.receivingGain Field

Normalized reception characteristic value g\_0kl of the omnidirectional receiving antenna for the received ray direction \[\-\]\.

```csharp
private readonly double receivingGain;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.reflectionCoefficient'></a>

## RayContribution\.reflectionCoefficient Field

Complex reflection coefficient Gamma\_kl of the cell \[\-\]\.

```csharp
private readonly Complex reflectionCoefficient;
```

#### Field Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.thetaReceiver'></a>

## RayContribution\.thetaReceiver Field

Polar angle theta\_kl \[rad\] of the received ray, with origin at the receiver\.

```csharp
private readonly double thetaReceiver;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.thetaTransmitter'></a>

## RayContribution\.thetaTransmitter Field

Polar angle theta\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

```csharp
private readonly double thetaTransmitter;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.transmittingGain'></a>

## RayContribution\.transmittingGain Field

Normalized radiation characteristic value g\_T0kl of the omnidirectional transmitting antenna for the emitted ray direction \[\-\]\.

```csharp
private readonly double transmittingGain;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.weightedReflectionCoefficient'></a>

## RayContribution\.weightedReflectionCoefficient Field

Weighted complex reflection coefficient Gamma'\_kl = g\_T0kl \* g\_0kl \* Gamma\_kl \[\-\]\.

```csharp
private readonly Complex weightedReflectionCoefficient;
```

#### Field Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')
### Properties

<a name='DiGi.Communication.Obselete.Classes.RayContribution.IncidenceAngle'></a>

## RayContribution\.IncidenceAngle Property

Angle of incidence gamma\_kl \[rad\] of the ray on the cell plane, measured from the plane \(grazing angle\)\.

```csharp
public double IncidenceAngle { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.PhiReceiver'></a>

## RayContribution\.PhiReceiver Property

Azimuth angle phi\_kl \[rad\] of the received ray, with origin at the receiver\.

```csharp
public double PhiReceiver { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.PhiTransmitter'></a>

## RayContribution\.PhiTransmitter Property

Azimuth angle phi\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

```csharp
public double PhiTransmitter { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.ReceivingGain'></a>

## RayContribution\.ReceivingGain Property

Normalized reception characteristic value g\_0kl of the omnidirectional receiving antenna for the received ray direction \[\-\]\.

```csharp
public double ReceivingGain { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.ReflectionCoefficient'></a>

## RayContribution\.ReflectionCoefficient Property

Complex reflection coefficient Gamma\_kl of the cell \[\-\]\.

```csharp
public System.Numerics.Complex ReflectionCoefficient { get; }
```

#### Property Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.ThetaReceiver'></a>

## RayContribution\.ThetaReceiver Property

Polar angle theta\_kl \[rad\] of the received ray, with origin at the receiver\.

```csharp
public double ThetaReceiver { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.ThetaTransmitter'></a>

## RayContribution\.ThetaTransmitter Property

Polar angle theta\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

```csharp
public double ThetaTransmitter { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.TransmittingGain'></a>

## RayContribution\.TransmittingGain Property

Normalized radiation characteristic value g\_T0kl of the omnidirectional transmitting antenna for the emitted ray direction \[\-\]\.

```csharp
public double TransmittingGain { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Obselete.Classes.RayContribution.WeightedReflectionCoefficient'></a>

## RayContribution\.WeightedReflectionCoefficient Property

Weighted complex reflection coefficient Gamma'\_kl = g\_T0kl \* g\_0kl \* Gamma\_kl \[\-\]\.

```csharp
public System.Numerics.Complex WeightedReflectionCoefficient { get; }
```

#### Property Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')