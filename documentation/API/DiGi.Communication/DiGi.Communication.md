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