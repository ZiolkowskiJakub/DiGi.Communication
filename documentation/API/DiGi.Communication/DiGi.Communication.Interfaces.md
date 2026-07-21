#### [DiGi\.Communication](DiGi.Communication.Overview.md 'DiGi\.Communication\.Overview')

## DiGi\.Communication\.Interfaces Namespace
### Interfaces

<a name='DiGi.Communication.Interfaces.IAngularPowerDistribution'></a>

## IAngularPowerDistribution Interface

Interface for an angular power distribution at a given delay, describing power arrival directions as a set of vectors\.

```csharp
public interface IAngularPowerDistribution : DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Derived  
↳ [AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution')

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Properties

<a name='DiGi.Communication.Interfaces.IAngularPowerDistribution.Delay'></a>

## IAngularPowerDistribution\.Delay Property

Gets the propagation delay associated with this power distribution \[s\]\.

```csharp
double Delay { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Interfaces.IAngularPowerDistribution.Vectors'></a>

## IAngularPowerDistribution\.Vectors Property

Gets the list of direction vectors representing the angular distribution of power\.

```csharp
System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Vector3D>? Vectors { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Communication.Interfaces.IAngularPowerDistribution.GetPower()'></a>

## IAngularPowerDistribution\.GetPower\(\) Method

Computes the total power of this angular distribution\.

```csharp
double GetPower();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The total power value\.

<a name='DiGi.Communication.Interfaces.IAngularPowerDistributionProfile'></a>

## IAngularPowerDistributionProfile Interface

Interface for a profile that aggregates angular power distributions at a specific location\.

```csharp
public interface IAngularPowerDistributionProfile : DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [AngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfile')

Implements [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Properties

<a name='DiGi.Communication.Interfaces.IAngularPowerDistributionProfile.AngularPowerDistributions'></a>

## IAngularPowerDistributionProfile\.AngularPowerDistributions Property

Gets the collection of angular power distributions contained in this profile\.

```csharp
System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.AngularPowerDistribution>? AngularPowerDistributions { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Communication.Interfaces.IAngularPowerDistributionProfile.Location'></a>

## IAngularPowerDistributionProfile\.Location Property

Gets the spatial location of the angular power distribution profile\.

```csharp
DiGi.Geometry.Spatial.Classes.Point3D? Location { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')
### Methods

<a name='DiGi.Communication.Interfaces.IAngularPowerDistributionProfile.GetRays(double)'></a>

## IAngularPowerDistributionProfile\.GetRays\(double\) Method

Retrieves the rays associated with the specified delay\.

```csharp
System.Collections.Generic.List<DiGi.Communication.Classes.Ray>? GetRays(double delay);
```
#### Parameters

<a name='DiGi.Communication.Interfaces.IAngularPowerDistributionProfile.GetRays(double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The propagation delay \[s\] for which to retrieve rays\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of rays corresponding to the given delay, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no rays are found\.

<a name='DiGi.Communication.Interfaces.IAntenna'></a>

## IAntenna Interface

Interface for an antenna with a location and a set of communication functions\.

```csharp
public interface IAntenna : DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [Antenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Antenna 'DiGi\.Communication\.Classes\.Antenna')

Implements [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Properties

<a name='DiGi.Communication.Interfaces.IAntenna.Functions'></a>

## IAntenna\.Functions Property

Gets the set of communication functions \(e\.g\. transmitter, receiver\) supported by the antenna\.

```csharp
System.Collections.Generic.HashSet<DiGi.Communication.Enums.Function>? Functions { get; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[Function](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Function 'DiGi\.Communication\.Enums\.Function')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

<a name='DiGi.Communication.Interfaces.IAntenna.Location'></a>

## IAntenna\.Location Property

Gets the spatial location of the antenna\.

```csharp
DiGi.Geometry.Spatial.Classes.Point3D? Location { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Interfaces.ICommunicationGuidObject'></a>

## ICommunicationGuidObject Interface

Interface for communication objects that combine serialization support with a globally unique identifier\.

```csharp
public interface ICommunicationGuidObject : DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [AngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfile')  
↳ [Antenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Antenna 'DiGi\.Communication\.Classes\.Antenna')  
↳ [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile')  
↳ [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')  
↳ [ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup')  
↳ [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject')  
↳ [ScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfile 'DiGi\.Communication\.Classes\.ScatteringProfile')  
↳ [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile')  
↳ [IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')  
↳ [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')  
↳ [IComplexMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile')  
↳ [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')  
↳ [IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')  
↳ [IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')  
↳ [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')  
↳ [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.Communication.Interfaces.ICommunicationObject'></a>

## ICommunicationObject Interface

Base interface for all communication\-related objects in the DiGi framework\.

```csharp
public interface ICommunicationObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution')  
↳ [AngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfile')  
↳ [AngularPowerDistributionProfileAntennaRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfileAntennaRelation')  
↳ [AngularPowerDistributionSolver](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionSolver 'DiGi\.Communication\.Classes\.AngularPowerDistributionSolver')  
↳ [AngularPowerDistributionSolverOptions](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionSolverOptions 'DiGi\.Communication\.Classes\.AngularPowerDistributionSolverOptions')  
↳ [Antenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Antenna 'DiGi\.Communication\.Classes\.Antenna')  
↳ [CommunicationRelationCluster](DiGi.Communication.Classes.md#DiGi.Communication.Classes.CommunicationRelationCluster 'DiGi\.Communication\.Classes\.CommunicationRelationCluster')  
↳ [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile')  
↳ [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')  
↳ [MultipathPowerDelayProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation 'DiGi\.Communication\.Classes\.MultipathPowerDelayProfileAntennasRelation')  
↳ [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray')  
↳ [Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering')  
↳ [ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup')  
↳ [ScatteringGroupScatteringObjectsRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation 'DiGi\.Communication\.Classes\.ScatteringGroupScatteringObjectsRelation')  
↳ [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject')  
↳ [ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')  
↳ [ScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfile 'DiGi\.Communication\.Classes\.ScatteringProfile')  
↳ [ScatteringProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileAntennasRelation 'DiGi\.Communication\.Classes\.ScatteringProfileAntennasRelation')  
↳ [ScatteringProfileMultipathPowerDelayProfileRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation 'DiGi\.Communication\.Classes\.ScatteringProfileMultipathPowerDelayProfileRelation')  
↳ [ScatteringSolver](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringSolver 'DiGi\.Communication\.Classes\.ScatteringSolver')  
↳ [ScatteringSolverOptions](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringSolverOptions 'DiGi\.Communication\.Classes\.ScatteringSolverOptions')  
↳ [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile')  
↳ [IAngularPowerDistribution](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution')  
↳ [IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')  
↳ [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')  
↳ [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')  
↳ [ICommunicationRelation](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationRelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation')  
↳ [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject')  
↳ [IComplexMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile')  
↳ [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')  
↳ [IScattering](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScattering 'DiGi\.Communication\.Interfaces\.IScattering')  
↳ [IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')  
↳ [IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')  
↳ [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')  
↳ [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')  
↳ [ArrivalRay](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.ArrivalRay 'DiGi\.Communication\.Obselete\.Classes\.ArrivalRay')  
↳ [EllipsoidComponent](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.EllipsoidComponent 'DiGi\.Communication\.Obselete\.Classes\.EllipsoidComponent')  
↳ [MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')  
↳ [MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell')  
↳ [PropagationModel](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationModel 'DiGi\.Communication\.Obselete\.Classes\.PropagationModel')  
↳ [PropagationResult](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationResult 'DiGi\.Communication\.Obselete\.Classes\.PropagationResult')  
↳ [RayContribution](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.RayContribution 'DiGi\.Communication\.Obselete\.Classes\.RayContribution')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Communication.Interfaces.ICommunicationRelation'></a>

## ICommunicationRelation Interface

Interface for relations that belong to the communication domain\.

```csharp
public interface ICommunicationRelation : DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [AngularPowerDistributionProfileAntennaRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfileAntennaRelation')  
↳ [MultipathPowerDelayProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation 'DiGi\.Communication\.Classes\.MultipathPowerDelayProfileAntennasRelation')  
↳ [ScatteringGroupScatteringObjectsRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation 'DiGi\.Communication\.Classes\.ScatteringGroupScatteringObjectsRelation')  
↳ [ScatteringProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileAntennasRelation 'DiGi\.Communication\.Classes\.ScatteringProfileAntennasRelation')  
↳ [ScatteringProfileMultipathPowerDelayProfileRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation 'DiGi\.Communication\.Classes\.ScatteringProfileMultipathPowerDelayProfileRelation')

Implements [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Communication.Interfaces.ICommunicationSerializableObject'></a>

## ICommunicationSerializableObject Interface

Interface for communication objects that support serialization\.

```csharp
public interface ICommunicationSerializableObject : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Derived  
↳ [AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution')  
↳ [AngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfile')  
↳ [Antenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Antenna 'DiGi\.Communication\.Classes\.Antenna')  
↳ [CommunicationRelationCluster](DiGi.Communication.Classes.md#DiGi.Communication.Classes.CommunicationRelationCluster 'DiGi\.Communication\.Classes\.CommunicationRelationCluster')  
↳ [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile')  
↳ [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')  
↳ [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray')  
↳ [Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering')  
↳ [ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup')  
↳ [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject')  
↳ [ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')  
↳ [ScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfile 'DiGi\.Communication\.Classes\.ScatteringProfile')  
↳ [ScatteringSolverOptions](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringSolverOptions 'DiGi\.Communication\.Classes\.ScatteringSolverOptions')  
↳ [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile')  
↳ [IAngularPowerDistribution](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution')  
↳ [IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')  
↳ [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')  
↳ [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')  
↳ [IComplexMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile')  
↳ [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')  
↳ [IScattering](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScattering 'DiGi\.Communication\.Interfaces\.IScattering')  
↳ [IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')  
↳ [IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')  
↳ [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')  
↳ [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')  
↳ [ArrivalRay](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.ArrivalRay 'DiGi\.Communication\.Obselete\.Classes\.ArrivalRay')  
↳ [EllipsoidComponent](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.EllipsoidComponent 'DiGi\.Communication\.Obselete\.Classes\.EllipsoidComponent')  
↳ [MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')  
↳ [MeshCell](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MeshCell 'DiGi\.Communication\.Obselete\.Classes\.MeshCell')  
↳ [PropagationModel](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationModel 'DiGi\.Communication\.Obselete\.Classes\.PropagationModel')  
↳ [PropagationResult](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationResult 'DiGi\.Communication\.Obselete\.Classes\.PropagationResult')  
↳ [RayContribution](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.RayContribution 'DiGi\.Communication\.Obselete\.Classes\.RayContribution')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')

<a name='DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile'></a>

## IComplexMultipathPowerDelayProfile Interface

Interface for a complex multipath power delay profile that can decompose into separate visible and hidden simple profiles\.

```csharp
public interface IComplexMultipathPowerDelayProfile : DiGi.Communication.Interfaces.IMultipathPowerDelayProfile, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile')

Implements [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile'), [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Methods

<a name='DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile.GetSimpleMultipathPowerDelay(bool)'></a>

## IComplexMultipathPowerDelayProfile\.GetSimpleMultipathPowerDelay\(bool\) Method

Gets the simple multipath power delay profile filtered by visibility\.

```csharp
DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile? GetSimpleMultipathPowerDelay(bool visible);
```
#### Parameters

<a name='DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile.GetSimpleMultipathPowerDelay(bool).visible'></a>

`visible` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool'), returns the visible component; otherwise, returns the hidden component\.

#### Returns
[ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')  
The filtered [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if not available\.

<a name='DiGi.Communication.Interfaces.IMultipathPowerDelayProfile'></a>

## IMultipathPowerDelayProfile Interface

Base interface for multipath power delay profiles that describe the received power as a function of propagation delay\.

```csharp
public interface IMultipathPowerDelayProfile : DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile')  
↳ [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile')  
↳ [IComplexMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile')  
↳ [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

Implements [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.Communication.Interfaces.IScattering'></a>

## IScattering Interface

Interface for a scattering event that groups scattering points by a common propagation delay\.

```csharp
public interface IScattering : DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Derived  
↳ [Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering')

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Properties

<a name='DiGi.Communication.Interfaces.IScattering.Delay'></a>

## IScattering\.Delay Property

Gets the propagation delay \[s\] associated with this scattering event\.

```csharp
double Delay { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Interfaces.IScattering.ScatteringPointGroups'></a>

## IScattering\.ScatteringPointGroups Property

Gets the list of scattering point groups associated with this scattering event\.

```csharp
System.Collections.Generic.List<DiGi.Communication.Classes.ScatteringPointGroup>? ScatteringPointGroups { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Interfaces.IScatteringGroup'></a>

## IScatteringGroup Interface

Interface for a group of scattering objects, defined by a bounding box and a reference identifier\.

```csharp
public interface IScatteringGroup : DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup')

Implements [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Properties

<a name='DiGi.Communication.Interfaces.IScatteringGroup.BoundingBox3D'></a>

## IScatteringGroup\.BoundingBox3D Property

Gets the 3D bounding box that encloses the scattering group\.

```csharp
DiGi.Geometry.Spatial.Classes.BoundingBox3D? BoundingBox3D { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

<a name='DiGi.Communication.Interfaces.IScatteringGroup.Reference'></a>

## IScatteringGroup\.Reference Property

Gets the reference identifier of the scattering group\.

```csharp
string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.Interfaces.IScatteringObject'></a>

## IScatteringObject Interface

Interface for a physical object that causes scattering of electromagnetic waves, defined by its mesh geometry, reference identifier, relative permittivity, and electrical conductivity\.

```csharp
public interface IScatteringObject : DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject')

Implements [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Properties

<a name='DiGi.Communication.Interfaces.IScatteringObject.ElectricalConductivity'></a>

## IScatteringObject\.ElectricalConductivity Property

Gets the electrical conductivity of the object \[S/m\]\.

```csharp
double ElectricalConductivity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Interfaces.IScatteringObject.Mesh3D'></a>

## IScatteringObject\.Mesh3D Property

Gets the 3D mesh representing the geometry of the scattering object\.

```csharp
DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

<a name='DiGi.Communication.Interfaces.IScatteringObject.Reference'></a>

## IScatteringObject\.Reference Property

Gets the reference identifier of the scattering object\.

```csharp
string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.Interfaces.IScatteringObject.RelativePermittivity'></a>

## IScatteringObject\.RelativePermittivity Property

Gets the relative permittivity of the object \[\-\]\.

```csharp
double RelativePermittivity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Interfaces.IScatteringProfile'></a>

## IScatteringProfile Interface

Interface for a scattering profile that describes the scattering characteristics between two locations\.

```csharp
public interface IScatteringProfile : DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [ScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfile 'DiGi\.Communication\.Classes\.ScatteringProfile')

Implements [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Properties

<a name='DiGi.Communication.Interfaces.IScatteringProfile.Location_1'></a>

## IScatteringProfile\.Location\_1 Property

Gets the first \(transmitter\-side\) spatial location of the scattering profile\.

```csharp
DiGi.Geometry.Spatial.Classes.Point3D? Location_1 { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Interfaces.IScatteringProfile.Location_2'></a>

## IScatteringProfile\.Location\_2 Property

Gets the second \(receiver\-side\) spatial location of the scattering profile\.

```csharp
DiGi.Geometry.Spatial.Classes.Point3D? Location_2 { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Interfaces.IScatteringProfile.Scatterings'></a>

## IScatteringProfile\.Scatterings Property

Gets the collection of scattering events contained in this profile\.

```csharp
System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.Scattering>? Scatterings { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Communication.Interfaces.IScatteringProfile.Visible'></a>

## IScatteringProfile\.Visible Property

Gets whether the scattering profile is visible \(line\-of\-sight component\)\.

```csharp
bool Visible { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile'></a>

## ISimpleMultipathPowerDelayProfile Interface

Interface for a simple multipath power delay profile that maps discrete propagation delays to their corresponding power values\.

```csharp
public interface ISimpleMultipathPowerDelayProfile : DiGi.Communication.Interfaces.IMultipathPowerDelayProfile, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile')

Implements [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile'), [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Properties

<a name='DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile.Delays'></a>

## ISimpleMultipathPowerDelayProfile\.Delays Property

Gets the set of discrete propagation delays \[s\] present in the profile\.

```csharp
System.Collections.Generic.HashSet<double>? Delays { get; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')
### Methods

<a name='DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile.GetPower(double)'></a>

## ISimpleMultipathPowerDelayProfile\.GetPower\(double\) Method

Gets the power value associated with the specified propagation delay\.

```csharp
double GetPower(double delay);
```
#### Parameters

<a name='DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile.GetPower(double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The propagation delay \[s\] for which to retrieve the power\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The power value at the given delay\.