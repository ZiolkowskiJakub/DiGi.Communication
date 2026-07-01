#### [DiGi\.Communication](index.md 'index')

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

`antenna_1` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

First antenna

<a name='DiGi.Communication.Create.Ellipsoid(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna,double,double).antenna_2'></a>

`antenna_2` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

<a name='DiGi.Communication.Query.Polyline3Ds(thisDiGi.Communication.Interfaces.IScatteringProfile,double,System.Collections.Generic.IEnumerable_string_)'></a>

## Query\.Polyline3Ds\(this IScatteringProfile, double, IEnumerable\<string\>\) Method

Retrieves a list of three\-dimensional polylines from the specified scattering profile based on the provided delay and optional references\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Polyline3D>? Polyline3Ds(this DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile, double delay, System.Collections.Generic.IEnumerable<string>? references=null);
```
#### Parameters

<a name='DiGi.Communication.Query.Polyline3Ds(thisDiGi.Communication.Interfaces.IScatteringProfile,double,System.Collections.Generic.IEnumerable_string_).scatteringProfile'></a>

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

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