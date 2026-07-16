#### [DiGi\.Communication](DiGi.Communication.Overview.md 'DiGi\.Communication\.Overview')

## DiGi\.Communication Namespace
### Classes

<a name='DiGi.Communication.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna,double,double)'></a>

## Create\.Ellipsoid\(IAntenna, IAntenna, double, double\) Method

Propagation ellipsoid for two antennas and given delay

```csharp
public static DiGi.Geometry.Spatial.Classes.Ellipsoid? Ellipsoid(DiGi.Communication.Interfaces.IAntenna? antenna_1, DiGi.Communication.Interfaces.IAntenna? antenna_2, double delay, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna,double,double).antenna_1'></a>

`antenna_1` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

First antenna

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna,double,double).antenna_2'></a>

`antenna_2` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

Second antenna

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna,double,double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Delay \[m\]

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance \[m\]

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double)'></a>

## Create\.Ellipsoid\(Point3D, Point3D, double, double\) Method

Propagation ellipsoid for two antennas and given delay

```csharp
public static DiGi.Geometry.Spatial.Classes.Ellipsoid? Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D? location_1, DiGi.Geometry.Spatial.Classes.Point3D? location_2, double delay, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double).location_1'></a>

`location_1` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

First location

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double).location_2'></a>

`location_2` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

Second location

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Delay \[m\]

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance \[m\]

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid')

<a name='DiGi.Communication.Create.EllipsoidComponents(thisDiGi.Communication.Obselete.Classes.PropagationModel)'></a>

## Create\.EllipsoidComponents\(this PropagationModel\) Method

Stage I of the multi\-ellipsoidal model: determines the power components P\_n from the individual propagation ellipsoids\. Each mesh cell is assigned to the ellipsoid with the nearest delay, the complex reflection coefficients are weighted by the omnidirectional antenna characteristics and summed per ellipsoid\.

```csharp
public static System.Collections.Generic.List<DiGi.Communication.Obselete.Classes.EllipsoidComponent>? EllipsoidComponents(this DiGi.Communication.Obselete.Classes.PropagationModel? propagationModel);
```
#### Parameters

<a name='DiGi.Communication.Create.EllipsoidComponents(thisDiGi.Communication.Obselete.Classes.PropagationModel).propagationModel'></a>

`propagationModel` [PropagationModel](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationModel 'DiGi\.Communication\.Obselete\.Classes\.PropagationModel')

Input data of the multi\-ellipsoidal propagation model\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[EllipsoidComponent](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.EllipsoidComponent 'DiGi\.Communication\.Obselete\.Classes\.EllipsoidComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
Ellipsoid components ordered by delay or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for invalid input\.

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_)'></a>

## Create\.PropagationResult\(this GeometricalPropagationModel, double, Polarization, MaterialProperties, AntennaCharacteristic, AntennaCharacteristic, AntennaCharacteristic, Dictionary\<string,MaterialProperties\>\) Method

Executes the full comparative analysis cascade of the multi\-ellipsoidal propagation model directly from a geometrical propagation model\. The geometrical input is first converted into the input data of the multi\-ellipsoidal propagation model \(see [ToPropagation\_PropagationModel\(this GeometricalPropagationModel, double, Polarization, MaterialProperties, AntennaCharacteristic, AntennaCharacteristic, AntennaCharacteristic, AntennaCharacteristic, Dictionary&lt;string,MaterialProperties&gt;\)](DiGi.Communication.Obselete.Convert.md#DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_) 'DiGi\.Communication\.Obselete\.Convert\.Convert\.ToPropagation\_PropagationModel\(this DiGi\.Communication\.Classes\.GeometricalPropagationModel, double, DiGi\.Communication\.Enums\.Polarization, DiGi\.Communication\.Obselete\.Classes\.MaterialProperties, DiGi\.Communication\.AntennaCharacteristic, DiGi\.Communication\.AntennaCharacteristic, DiGi\.Communication\.AntennaCharacteristic, DiGi\.Communication\.AntennaCharacteristic, System\.Collections\.Generic\.Dictionary\<string,DiGi\.Communication\.Obselete\.Classes\.MaterialProperties\>\)')\) and afterwards the standard three stage cascade is executed\.

```csharp
public static DiGi.Communication.Obselete.Classes.PropagationResult? PropagationResult(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel, double frequency, DiGi.Communication.Enums.Polarization polarization, DiGi.Communication.Obselete.Classes.MaterialProperties? materialProperties, DiGi.Communication.AntennaCharacteristic? receivingDirectionalCharacteristic, DiGi.Communication.AntennaCharacteristic? receivingOmnidirectionalCharacteristic, DiGi.Communication.AntennaCharacteristic? transmittingOmnidirectionalCharacteristic, System.Collections.Generic.Dictionary<string,DiGi.Communication.Obselete.Classes.MaterialProperties>? materialPropertiesDictionary=null);
```
#### Parameters

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).geometricalPropagationModel'></a>

`geometricalPropagationModel` [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

Geometrical propagation model holding the antennas, the scattering objects and the multipath power delay profile\.

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).frequency'></a>

`frequency` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Frequency f of the propagating electromagnetic wave \[MHz\]\.

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).polarization'></a>

`polarization` [Polarization](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Polarization 'DiGi\.Communication\.Enums\.Polarization')

Polarization type of the propagating electromagnetic wave\.

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).materialProperties'></a>

`materialProperties` [MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')

Default electrical material properties applied to the mesh cells of the scattering objects\.

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).receivingDirectionalCharacteristic'></a>

`receivingDirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized reception characteristic g\(theta, phi\) of the directional receiving antenna\.

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).receivingOmnidirectionalCharacteristic'></a>

`receivingOmnidirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized reception characteristic g\_0\(theta, phi\) of the omnidirectional receiving antenna\.

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).transmittingOmnidirectionalCharacteristic'></a>

`transmittingOmnidirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized radiation characteristic g\_T0\(theta, phi\) of the omnidirectional transmitting antenna\.

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).materialPropertiesDictionary'></a>

`materialPropertiesDictionary` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

Optional electrical material properties per scattering object keyed by the scattering object reference\. Scattering objects without an entry use the default material properties\.

#### Returns
[PropagationResult](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationResult 'DiGi\.Communication\.Obselete\.Classes\.PropagationResult')  
Result of the comparative analysis or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for invalid input\.

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Obselete.Classes.PropagationModel)'></a>

## Create\.PropagationResult\(this PropagationModel\) Method

Executes the full comparative analysis cascade of the multi\-ellipsoidal propagation model\.

Stage I: determines the power components P_n from the individual propagation ellipsoids.

Stage II: assigns the corrected power p_nkl = w_0n * w_Pn * g_T0kl * g_0kl * |Gamma_kl|^2 / P to each incoming ray, correcting the object mapping errors with the measured Power Delay Profile.

Stage III: applies the directional reception characteristic gain G_kl = g / g_0 to the angular power distribution and sums the total power P_0 received by the directional antenna.

```csharp
public static DiGi.Communication.Obselete.Classes.PropagationResult? PropagationResult(this DiGi.Communication.Obselete.Classes.PropagationModel? propagationModel);
```
#### Parameters

<a name='DiGi.Communication.Create.PropagationResult(thisDiGi.Communication.Obselete.Classes.PropagationModel).propagationModel'></a>

`propagationModel` [PropagationModel](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationModel 'DiGi\.Communication\.Obselete\.Classes\.PropagationModel')

Input data of the multi\-ellipsoidal propagation model\.

#### Returns
[PropagationResult](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationResult 'DiGi\.Communication\.Obselete\.Classes\.PropagationResult')  
Result of the comparative analysis or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for invalid input\.

<a name='DiGi.Communication.Create.Report(thisDiGi.Communication.Classes.GeometricalPropagationModel)'></a>

## Create\.Report\(this GeometricalPropagationModel\) Method

Creates a new report based on the specified geometrical propagation model\.

```csharp
public static DiGi.Core.IO.Classes.Report Report(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel);
```
#### Parameters

<a name='DiGi.Communication.Create.Report(thisDiGi.Communication.Classes.GeometricalPropagationModel).geometricalPropagationModel'></a>

`geometricalPropagationModel` [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The geometrical propagation model to use for the report\.

#### Returns
[DiGi\.Core\.IO\.Classes\.Report](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.classes.report 'DiGi\.Core\.IO\.Classes\.Report')  
A new [Report\(this GeometricalPropagationModel\)](DiGi.Communication.md#DiGi.Communication.Create.Report(thisDiGi.Communication.Classes.GeometricalPropagationModel) 'DiGi\.Communication\.Create\.Report\(this DiGi\.Communication\.Classes\.GeometricalPropagationModel\)') instance used for collecting and exporting data\.

<a name='DiGi.Communication.Create.ScatteringGroups(thisDiGi.Communication.Classes.GeometricalPropagationModel,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_,double)'></a>

## Create\.ScatteringGroups\(this GeometricalPropagationModel, IEnumerable\<IScatteringObject\>, double\) Method

Creates scattering groups by clustering scattering objects into connected components based on intersection of their bounding boxes expanded by the given tolerance\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.Communication.Interfaces.IScatteringGroup>? ScatteringGroups(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel, System.Collections.Generic.IEnumerable<DiGi.Communication.Interfaces.IScatteringObject>? scatteringObjects=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Communication.Create.ScatteringGroups(thisDiGi.Communication.Classes.GeometricalPropagationModel,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_,double).geometricalPropagationModel'></a>

`geometricalPropagationModel` [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The geometrical propagation model providing the scattering objects when [scatteringObjects](DiGi.Communication.md#DiGi.Communication.Create.ScatteringGroups(thisDiGi.Communication.Classes.GeometricalPropagationModel,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_,double).scatteringObjects 'DiGi\.Communication\.Create\.ScatteringGroups\(this DiGi\.Communication\.Classes\.GeometricalPropagationModel, System\.Collections\.Generic\.IEnumerable\<DiGi\.Communication\.Interfaces\.IScatteringObject\>, double\)\.scatteringObjects') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Communication.Create.ScatteringGroups(thisDiGi.Communication.Classes.GeometricalPropagationModel,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_,double).scatteringObjects'></a>

`scatteringObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The scattering objects to group\. If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null'), ungrouped scattering objects of the [geometricalPropagationModel](DiGi.Communication.md#DiGi.Communication.Create.ScatteringGroups(thisDiGi.Communication.Classes.GeometricalPropagationModel,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_,double).geometricalPropagationModel 'DiGi\.Communication\.Create\.ScatteringGroups\(this DiGi\.Communication\.Classes\.GeometricalPropagationModel, System\.Collections\.Generic\.IEnumerable\<DiGi\.Communication\.Interfaces\.IScatteringObject\>, double\)\.geometricalPropagationModel') are used\.

<a name='DiGi.Communication.Create.ScatteringGroups(thisDiGi.Communication.Classes.GeometricalPropagationModel,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance \[m\] by which bounding boxes are expanded while testing for intersection\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
The created scattering groups if any; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Communication.Create.SimpleMultipathPowerDelayProfile(DiGi.Communication.Enums.DefaultSimpleMultipathPowerDelayProfile)'></a>

## Create\.SimpleMultipathPowerDelayProfile\(DefaultSimpleMultipathPowerDelayProfile\) Method

Creates a [SimpleMultipathPowerDelayProfile\(DefaultSimpleMultipathPowerDelayProfile\)](DiGi.Communication.md#DiGi.Communication.Create.SimpleMultipathPowerDelayProfile(DiGi.Communication.Enums.DefaultSimpleMultipathPowerDelayProfile) 'DiGi\.Communication\.Create\.SimpleMultipathPowerDelayProfile\(DiGi\.Communication\.Enums\.DefaultSimpleMultipathPowerDelayProfile\)') based on the specified default profile configuration\.

```csharp
public static DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile? SimpleMultipathPowerDelayProfile(DiGi.Communication.Enums.DefaultSimpleMultipathPowerDelayProfile defaultSimpleMultipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Create.SimpleMultipathPowerDelayProfile(DiGi.Communication.Enums.DefaultSimpleMultipathPowerDelayProfile).defaultSimpleMultipathPowerDelayProfile'></a>

`defaultSimpleMultipathPowerDelayProfile` [DefaultSimpleMultipathPowerDelayProfile](DiGi.Communication.Enums.md#DiGi.Communication.Enums.DefaultSimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Enums\.DefaultSimpleMultipathPowerDelayProfile')

The default power delay profile preset to use\.

#### Returns
[SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile')  
A new instance of [SimpleMultipathPowerDelayProfile\(DefaultSimpleMultipathPowerDelayProfile\)](DiGi.Communication.md#DiGi.Communication.Create.SimpleMultipathPowerDelayProfile(DiGi.Communication.Enums.DefaultSimpleMultipathPowerDelayProfile) 'DiGi\.Communication\.Create\.SimpleMultipathPowerDelayProfile\(DiGi\.Communication\.Enums\.DefaultSimpleMultipathPowerDelayProfile\)') corresponding to the specified preset, or `null` if no matching profile is found\.

<a name='DiGi.Communication.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Communication.Query.ComplexRelativePermittivity(thisDiGi.Communication.Obselete.Classes.MaterialProperties,double)'></a>

## Query\.ComplexRelativePermittivity\(this MaterialProperties, double\) Method

Complex relative electrical permittivity epsilon'\_k = epsilon\_wk \- j \* 60 \* lambda \* sigma\_k of the scattering object\.

```csharp
public static System.Numerics.Complex ComplexRelativePermittivity(this DiGi.Communication.Obselete.Classes.MaterialProperties materialProperties, double wavelength);
```
#### Parameters

<a name='DiGi.Communication.Query.ComplexRelativePermittivity(thisDiGi.Communication.Obselete.Classes.MaterialProperties,double).materialProperties'></a>

`materialProperties` [MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')

Electrical material properties of the object\.

<a name='DiGi.Communication.Query.ComplexRelativePermittivity(thisDiGi.Communication.Obselete.Classes.MaterialProperties,double).wavelength'></a>

`wavelength` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Wavelength lambda of the propagating electromagnetic wave \[m\]\.

#### Returns
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')  
Complex relative electrical permittivity \[\-\]\.

<a name='DiGi.Communication.Query.Delay(thisDiGi.Communication.Obselete.Classes.MeshCell,double)'></a>

## Query\.Delay\(this MeshCell, double\) Method

Excess propagation delay tau \[s\] of the mesh cell relative to the direct transmitter\-receiver path: tau = \(r\_1 \+ r\_2 \- d\) / c, with r\_1 and r\_2 the distances from the transmitter \(origin\) and receiver to the cell center\.

```csharp
public static double Delay(this DiGi.Communication.Obselete.Classes.MeshCell meshCell, double distance);
```
#### Parameters

<a name='DiGi.Communication.Query.Delay(thisDiGi.Communication.Obselete.Classes.MeshCell,double).meshCell'></a>

`meshCell` [MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell')

Mesh cell of the scattering object\.

<a name='DiGi.Communication.Query.Delay(thisDiGi.Communication.Obselete.Classes.MeshCell,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Distance d between the transmitter and receiver \[m\]\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Excess propagation delay \[s\] or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') for invalid input\.

<a name='DiGi.Communication.Query.IncidenceAngle(thisDiGi.Communication.Obselete.Classes.MeshCell)'></a>

## Query\.IncidenceAngle\(this MeshCell\) Method

Angle of incidence gamma\_kl \[rad\] of the ray emitted from the transmitter \(placed at the origin\) on the mesh cell plane, measured from the plane \(grazing angle\)\.

```csharp
public static double IncidenceAngle(this DiGi.Communication.Obselete.Classes.MeshCell meshCell);
```
#### Parameters

<a name='DiGi.Communication.Query.IncidenceAngle(thisDiGi.Communication.Obselete.Classes.MeshCell).meshCell'></a>

`meshCell` [MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell')

Mesh cell of the scattering object\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Angle of incidence \[rad\] in range \[0, pi/2\] or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') for a degenerate cell\.

<a name='DiGi.Communication.Query.Phi(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.Phi\(this Vector3D\) Method

Azimuth angle phi \[rad\] of the vector in spherical coordinates, measured in the XOY plane from the OX axis\.

```csharp
public static double Phi(this DiGi.Geometry.Spatial.Classes.Vector3D vector3D);
```
#### Parameters

<a name='DiGi.Communication.Query.Phi(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

Direction vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Azimuth angle \[rad\] in range \(\-pi, pi\]\.

<a name='DiGi.Communication.Query.Polyline3Ds(thisDiGi.Communication.Interfaces.IScatteringProfile,double,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.Polyline3Ds\(this IScatteringProfile, double, IEnumerable\<string\>\) Method

Retrieves a list of three\-dimensional polylines from the specified scattering profile based on the provided delay and optional references\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Polyline3D>? Polyline3Ds(this DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile, double delay, System.Collections.Generic.IEnumerable<string>? references=null);
```
#### Parameters

<a name='DiGi.Communication.Query.Polyline3Ds(thisDiGi.Communication.Interfaces.IScatteringProfile,double,System.Collections.Generic.IEnumerable_string_).scatteringProfile'></a>

`scatteringProfile` [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to query for polyline data\.

<a name='DiGi.Communication.Query.Polyline3Ds(thisDiGi.Communication.Interfaces.IScatteringProfile,double,System.Collections.Generic.IEnumerable_string_).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The delay value used to filter or identify the polylines\.

<a name='DiGi.Communication.Query.Polyline3Ds(thisDiGi.Communication.Interfaces.IScatteringProfile,double,System.Collections.Generic.IEnumerable_string_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An optional collection of reference strings to further filter the results\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Geometry\.Spatial\.Classes\.Polyline3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyline3d 'DiGi\.Geometry\.Spatial\.Classes\.Polyline3D') objects if successful; otherwise, `null` if the scattering profile is null\.

<a name='DiGi.Communication.Query.ReflectionCoefficient(System.Numerics.Complex,double,DiGi.Communication.Enums.Polarization)'></a>

## Query\.ReflectionCoefficient\(Complex, double, Polarization\) Method

Complex reflection coefficient Gamma\_kl for the given complex relative permittivity, angle of incidence and polarization\.

Vertical: Gamma = (epsilon' * sin(gamma) - sqrt(epsilon' - cos^2(gamma))) / (epsilon' * sin(gamma) + sqrt(epsilon' - cos^2(gamma))).

Horizontal: Gamma = (sin(gamma) - sqrt(epsilon' - cos^2(gamma))) / (sin(gamma) + sqrt(epsilon' - cos^2(gamma))).

```csharp
public static System.Numerics.Complex ReflectionCoefficient(System.Numerics.Complex complexRelativePermittivity, double incidenceAngle, DiGi.Communication.Enums.Polarization polarization);
```
#### Parameters

<a name='DiGi.Communication.Query.ReflectionCoefficient(System.Numerics.Complex,double,DiGi.Communication.Enums.Polarization).complexRelativePermittivity'></a>

`complexRelativePermittivity` [System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

Complex relative electrical permittivity epsilon'\_k of the object \[\-\]\.

<a name='DiGi.Communication.Query.ReflectionCoefficient(System.Numerics.Complex,double,DiGi.Communication.Enums.Polarization).incidenceAngle'></a>

`incidenceAngle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Angle of incidence gamma\_kl \[rad\] measured from the cell plane \(grazing angle\)\.

<a name='DiGi.Communication.Query.ReflectionCoefficient(System.Numerics.Complex,double,DiGi.Communication.Enums.Polarization).polarization'></a>

`polarization` [Polarization](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Polarization 'DiGi\.Communication\.Enums\.Polarization')

Polarization type of the propagating electromagnetic wave\.

#### Returns
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')  
Complex reflection coefficient \[\-\]\.

<a name='DiGi.Communication.Query.Scale(thisDiGi.Communication.Classes.Ray,double)'></a>

## Query\.Scale\(this Ray, double\) Method

Scales the specified ray by the given factor\.

```csharp
public static DiGi.Communication.Classes.Ray? Scale(this DiGi.Communication.Classes.Ray? ray, double factor);
```
#### Parameters

<a name='DiGi.Communication.Query.Scale(thisDiGi.Communication.Classes.Ray,double).ray'></a>

`ray` [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray')

The ray to scale\.

<a name='DiGi.Communication.Query.Scale(thisDiGi.Communication.Classes.Ray,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scaling factor\.

#### Returns
[Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray')  
A new scaled [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input ray is null or the factor is NaN\.

<a name='DiGi.Communication.Query.Scale(thisSystem.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Ray_,double)'></a>

## Query\.Scale\(this IEnumerable\<Ray\>, double\) Method

Scales a collection of rays by the specified factor\.

```csharp
public static System.Collections.Generic.List<DiGi.Communication.Classes.Ray>? Scale(this System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.Ray>? rays, double factor);
```
#### Parameters

<a name='DiGi.Communication.Query.Scale(thisSystem.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Ray_,double).rays'></a>

`rays` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of rays to scale\.

<a name='DiGi.Communication.Query.Scale(thisSystem.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Ray_,double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scaling factor to apply to each ray\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A new list containing the scaled rays, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input collection is null\.

<a name='DiGi.Communication.Query.SemiMajorAxis(double,double)'></a>

## Query\.SemiMajorAxis\(double, double\) Method

Semi\-major axis a\_n \[m\] of the propagation ellipsoid: a\_n = \(c \* tau\_n \+ d\) / 2\.

```csharp
public static double SemiMajorAxis(double delay, double distance);
```
#### Parameters

<a name='DiGi.Communication.Query.SemiMajorAxis(double,double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Delay tau\_n \[s\]\.

<a name='DiGi.Communication.Query.SemiMajorAxis(double,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Distance d between the transmitter and receiver \[m\]\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Semi\-major axis \[m\] or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') for invalid input\.

<a name='DiGi.Communication.Query.SemiMinorAxis(double,double)'></a>

## Query\.SemiMinorAxis\(double, double\) Method

Semi\-minor axes b\_n = c\_n \[m\] of the propagation ellipsoid: b\_n = sqrt\(c \* tau\_n \* \(c \* tau\_n \+ 2 \* d\)\) / 2\.

```csharp
public static double SemiMinorAxis(double delay, double distance);
```
#### Parameters

<a name='DiGi.Communication.Query.SemiMinorAxis(double,double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Delay tau\_n \[s\]\.

<a name='DiGi.Communication.Query.SemiMinorAxis(double,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Distance d between the transmitter and receiver \[m\]\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Semi\-minor axis \[m\] or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') for invalid input\.

<a name='DiGi.Communication.Query.Theta(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Query\.Theta\(this Vector3D\) Method

Polar angle theta \[rad\] of the vector in spherical coordinates, measured from the OZ axis\.

```csharp
public static double Theta(this DiGi.Geometry.Spatial.Classes.Vector3D vector3D);
```
#### Parameters

<a name='DiGi.Communication.Query.Theta(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

Direction vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Polar angle \[rad\] in range \[0, pi\] or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') for a zero\-length vector\.

<a name='DiGi.Communication.Query.TotalPower(thisSystem.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.ArrivalRay_)'></a>

## Query\.TotalPower\(this IEnumerable\<ArrivalRay\>\) Method

Sum of the powers assigned to the rays\. For rays created from a normalized Power Delay Profile the sum equals 1\.

```csharp
public static double TotalPower(this System.Collections.Generic.IEnumerable<DiGi.Communication.Obselete.Classes.ArrivalRay>? arrivalRays);
```
#### Parameters

<a name='DiGi.Communication.Query.TotalPower(thisSystem.Collections.Generic.IEnumerable_DiGi.Communication.Obselete.Classes.ArrivalRay_).arrivalRays'></a>

`arrivalRays` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ArrivalRay](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.ArrivalRay 'DiGi\.Communication\.Obselete\.Classes\.ArrivalRay')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Rays with assigned corrected powers p\_nkl\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Sum of the ray powers \[\-\] or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') when rays are not provided\.

<a name='DiGi.Communication.Query.Wavelength(double)'></a>

## Query\.Wavelength\(double\) Method

Wavelength lambda \[m\] of the propagating electromagnetic wave: lambda = c / f, with the frequency expressed in MHz\.

```csharp
public static double Wavelength(double frequency);
```
#### Parameters

<a name='DiGi.Communication.Query.Wavelength(double).frequency'></a>

`frequency` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Frequency f of the propagating electromagnetic wave \[MHz\]\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Wavelength \[m\] or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') for a non\-positive frequency\.
### Delegates

<a name='DiGi.Communication.AntennaCharacteristic(double,double)'></a>

## AntennaCharacteristic\(double, double\) Delegate

Normalized antenna radiation characteristic g\(theta, phi\)\. The normalization condition is the integral of \|g\(theta, phi\)\|^2 over the full solid angle equal to 1\.

```csharp
public delegate double AntennaCharacteristic(double theta, double phi);
```
#### Parameters

<a name='DiGi.Communication.AntennaCharacteristic(double,double).theta'></a>

`theta` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Polar angle theta \[rad\] measured from the OZ axis\.

<a name='DiGi.Communication.AntennaCharacteristic(double,double).phi'></a>

`phi` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Azimuth angle phi \[rad\] measured in the XOY plane from the OX axis\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
Value of the normalized radiation characteristic for the given direction\.