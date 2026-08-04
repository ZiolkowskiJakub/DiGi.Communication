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
The calculated propagation [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid'), or `null` if invalid parameters are provided\.

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
The calculated propagation [DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.ellipsoid 'DiGi\.Geometry\.Spatial\.Classes\.Ellipsoid'), or `null` if invalid parameters are provided\.

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

<a name='DiGi.Communication.Query.Conductivity(thisDiGi.Communication.Classes.ElectricalProperties,double)'></a>

## Query\.Conductivity\(this ElectricalProperties, double\) Method

Calculates the electrical conductivity sigma\_k of the electrical properties \[S/m\]\.

```csharp
public static double Conductivity(this DiGi.Communication.Classes.ElectricalProperties? electricalProperties, double frequency);
```
#### Parameters

<a name='DiGi.Communication.Query.Conductivity(thisDiGi.Communication.Classes.ElectricalProperties,double).electricalProperties'></a>

`electricalProperties` [ElectricalProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ElectricalProperties 'DiGi\.Communication\.Classes\.ElectricalProperties')

The electrical properties instance\.

<a name='DiGi.Communication.Query.Conductivity(thisDiGi.Communication.Classes.ElectricalProperties,double).frequency'></a>

`frequency` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Frequency in \[Hz\]\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The electrical conductivity \[S/m\], or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if calculation inputs are invalid or [electricalProperties](DiGi.Communication.md#DiGi.Communication.Query.Conductivity(thisDiGi.Communication.Classes.ElectricalProperties,double).electricalProperties 'DiGi\.Communication\.Query\.Conductivity\(this DiGi\.Communication\.Classes\.ElectricalProperties, double\)\.electricalProperties') is null\.

<a name='DiGi.Communication.Query.ElectricalPropertiesByReference(thisDiGi.Communication.Classes.GeometricalPropagationModel)'></a>

## Query\.ElectricalPropertiesByReference\(this GeometricalPropagationModel\) Method

Builds a lookup of the electrical properties of every scattering object of the model, keyed by the scattering object reference\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.Communication.Classes.ElectricalProperties>? ElectricalPropertiesByReference(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel);
```
#### Parameters

<a name='DiGi.Communication.Query.ElectricalPropertiesByReference(thisDiGi.Communication.Classes.GeometricalPropagationModel).geometricalPropagationModel'></a>

`geometricalPropagationModel` [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The geometrical propagation model holding the scattering objects\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[ElectricalProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ElectricalProperties 'DiGi\.Communication\.Classes\.ElectricalProperties')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping the scattering object reference to its electrical properties, or `null` if [geometricalPropagationModel](DiGi.Communication.md#DiGi.Communication.Query.ElectricalPropertiesByReference(thisDiGi.Communication.Classes.GeometricalPropagationModel).geometricalPropagationModel 'DiGi\.Communication\.Query\.ElectricalPropertiesByReference\(this DiGi\.Communication\.Classes\.GeometricalPropagationModel\)\.geometricalPropagationModel') is null or holds no scattering objects\.

### Remarks
The scattering objects are retrieved in a single bulk call\. Resolving each [Reference](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringHit.Reference 'DiGi\.Communication\.Interfaces\.IScatteringHit\.Reference') through
[GetScatteringObjects&lt;TScatteringObject&gt;\(string\)](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_(string) 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringObjects\<TScatteringObject\>\(string\)') instead would clone the mesh of every
candidate on each call\. References are not enforced unique, so the last scattering object of a duplicated reference wins\.

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

<a name='DiGi.Communication.Query.RelativePermittivity(thisDiGi.Communication.Classes.ElectricalProperties,double)'></a>

## Query\.RelativePermittivity\(this ElectricalProperties, double\) Method

Calculates the relative electrical permittivity epsilon\_wk of the electrical properties \[\-\]\.

```csharp
public static double RelativePermittivity(this DiGi.Communication.Classes.ElectricalProperties? electricalProperties, double frequency);
```
#### Parameters

<a name='DiGi.Communication.Query.RelativePermittivity(thisDiGi.Communication.Classes.ElectricalProperties,double).electricalProperties'></a>

`electricalProperties` [ElectricalProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ElectricalProperties 'DiGi\.Communication\.Classes\.ElectricalProperties')

The electrical properties instance\.

<a name='DiGi.Communication.Query.RelativePermittivity(thisDiGi.Communication.Classes.ElectricalProperties,double).frequency'></a>

`frequency` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Frequency in \[Hz\]\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The relative electrical permittivity \[\-\], or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if calculation inputs are invalid or [electricalProperties](DiGi.Communication.md#DiGi.Communication.Query.RelativePermittivity(thisDiGi.Communication.Classes.ElectricalProperties,double).electricalProperties 'DiGi\.Communication\.Query\.RelativePermittivity\(this DiGi\.Communication\.Classes\.ElectricalProperties, double\)\.electricalProperties') is null\.

<a name='DiGi.Communication.Query.ScatteringHitsByElectricalProperties_TScatteringHit_(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Communication.Classes.AngularPowerDistribution,double,double)'></a>

## Query\.ScatteringHitsByElectricalProperties\<TScatteringHit\>\(this GeometricalPropagationModel, AngularPowerDistribution, double, double\) Method

Groups scattering hits extracted from an angular power distribution at specified azimuth and elevation angles by the electrical properties of their corresponding scattering objects in the model\.

```csharp
public static System.Collections.Generic.Dictionary<DiGi.Communication.Classes.ElectricalProperties,System.Collections.Generic.List<TScatteringHit>>? ScatteringHitsByElectricalProperties<TScatteringHit>(this DiGi.Communication.Classes.GeometricalPropagationModel geometricalPropagationModel, DiGi.Communication.Classes.AngularPowerDistribution? angularPowerDistribution, double azimuth, double elevation)
    where TScatteringHit : DiGi.Communication.Interfaces.IScatteringHit;
```
#### Type parameters

<a name='DiGi.Communication.Query.ScatteringHitsByElectricalProperties_TScatteringHit_(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Communication.Classes.AngularPowerDistribution,double,double).TScatteringHit'></a>

`TScatteringHit`

The type of scattering hit to extract, which must implement [IScatteringHit](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringHit 'DiGi\.Communication\.Interfaces\.IScatteringHit')\.
#### Parameters

<a name='DiGi.Communication.Query.ScatteringHitsByElectricalProperties_TScatteringHit_(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Communication.Classes.AngularPowerDistribution,double,double).geometricalPropagationModel'></a>

`geometricalPropagationModel` [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The geometrical propagation model containing the scattering objects\.

<a name='DiGi.Communication.Query.ScatteringHitsByElectricalProperties_TScatteringHit_(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Communication.Classes.AngularPowerDistribution,double,double).angularPowerDistribution'></a>

`angularPowerDistribution` [AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution')

The angular power distribution from which scattering hits are extracted\.

<a name='DiGi.Communication.Query.ScatteringHitsByElectricalProperties_TScatteringHit_(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Communication.Classes.AngularPowerDistribution,double,double).azimuth'></a>

`azimuth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The azimuth angle in radians\.

<a name='DiGi.Communication.Query.ScatteringHitsByElectricalProperties_TScatteringHit_(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Communication.Classes.AngularPowerDistribution,double,double).elevation'></a>

`elevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation angle in radians\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[ElectricalProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ElectricalProperties 'DiGi\.Communication\.Classes\.ElectricalProperties')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TScatteringHit](DiGi.Communication.md#DiGi.Communication.Query.ScatteringHitsByElectricalProperties_TScatteringHit_(thisDiGi.Communication.Classes.GeometricalPropagationModel,DiGi.Communication.Classes.AngularPowerDistribution,double,double).TScatteringHit 'DiGi\.Communication\.Query\.ScatteringHitsByElectricalProperties\<TScatteringHit\>\(this DiGi\.Communication\.Classes\.GeometricalPropagationModel, DiGi\.Communication\.Classes\.AngularPowerDistribution, double, double\)\.TScatteringHit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping each unique [ElectricalProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ElectricalProperties 'DiGi\.Communication\.Classes\.ElectricalProperties') to a list of matching scattering hits, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if inputs are null or angles are invalid\.

<a name='DiGi.Communication.Query.SphericalDistributionScatteringHitCollection(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Enums.Function)'></a>

## Query\.SphericalDistributionScatteringHitCollection\(this IAngularPowerDistributionProfile, Function\) Method

Combines and retrieves a spherical distribution scattering hit collection across all delays in the specified angular power distribution profile\.

```csharp
public static DiGi.Communication.Classes.SphericalDistributionScatteringHitCollection? SphericalDistributionScatteringHitCollection(this DiGi.Communication.Interfaces.IAngularPowerDistributionProfile? angularPowerDistributionProfile, DiGi.Communication.Enums.Function function=DiGi.Communication.Enums.Function.Receiver);
```
#### Parameters

<a name='DiGi.Communication.Query.SphericalDistributionScatteringHitCollection(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Enums.Function).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile to query\.

<a name='DiGi.Communication.Query.SphericalDistributionScatteringHitCollection(thisDiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Enums.Function).function'></a>

`function` [Function](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Function 'DiGi\.Communication\.Enums\.Function')

The node function \(Transmitter or Receiver\) used for spatial hit positioning\.

#### Returns
[SphericalDistributionScatteringHitCollection](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SphericalDistributionScatteringHitCollection 'DiGi\.Communication\.Classes\.SphericalDistributionScatteringHitCollection')  
A [SphericalDistributionScatteringHitCollection](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SphericalDistributionScatteringHitCollection 'DiGi\.Communication\.Classes\.SphericalDistributionScatteringHitCollection') instance aggregating all scattering hits, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the profile or its distributions are null or contain no hits\.