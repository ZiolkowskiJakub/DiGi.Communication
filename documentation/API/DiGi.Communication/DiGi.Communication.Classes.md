#### [DiGi\.Communication](DiGi.Communication.Overview.md 'DiGi\.Communication\.Overview')

## DiGi\.Communication\.Classes Namespace
### Classes

<a name='DiGi.Communication.Classes.AngularPowerDistribution'></a>

## AngularPowerDistribution Class

Represents the angular power distribution, encapsulating the time delay and the associated spatial vectors\.

```csharp
public class AngularPowerDistribution : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.IAngularPowerDistribution, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → AngularPowerDistribution

Implements [IAngularPowerDistribution](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.AngularPowerDistribution.AngularPowerDistribution(DiGi.Communication.Classes.AngularPowerDistribution)'></a>

## AngularPowerDistribution\(AngularPowerDistribution\) Constructor

Initializes a new instance of the [AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution') class by copying values from an existing instance\.

```csharp
public AngularPowerDistribution(DiGi.Communication.Classes.AngularPowerDistribution? angularPowerDistribution);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistribution.AngularPowerDistribution(DiGi.Communication.Classes.AngularPowerDistribution).angularPowerDistribution'></a>

`angularPowerDistribution` [AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution')

The source [AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution') instance to copy data from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Communication.Classes.AngularPowerDistribution.AngularPowerDistribution(double,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Vector3D_)'></a>

## AngularPowerDistribution\(double, IEnumerable\<Vector3D\>\) Constructor

Initializes a new instance of the [AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution') class\.

```csharp
public AngularPowerDistribution(double delay, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Vector3D>? vectors);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistribution.AngularPowerDistribution(double,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Vector3D_).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The delay value for the power distribution\.

<a name='DiGi.Communication.Classes.AngularPowerDistribution.AngularPowerDistribution(double,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Vector3D_).vectors'></a>

`vectors` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of three\-dimensional vectors defining the angular power distribution\.

<a name='DiGi.Communication.Classes.AngularPowerDistribution.AngularPowerDistribution(System.Text.Json.Nodes.JsonObject)'></a>

## AngularPowerDistribution\(JsonObject\) Constructor

Initializes a new instance of the [AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution') class using the specified JSON object\.

```csharp
public AngularPowerDistribution(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistribution.AngularPowerDistribution(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the current instance\.
### Properties

<a name='DiGi.Communication.Classes.AngularPowerDistribution.Delay'></a>

## AngularPowerDistribution\.Delay Property

Gets the delay associated with the angular power distribution\.

```csharp
public double Delay { get; }
```

Implements [Delay](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistribution.Delay 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution\.Delay')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.AngularPowerDistribution.Vectors'></a>

## AngularPowerDistribution\.Vectors Property

Gets the collection of three\-dimensional vectors associated with the angular power distribution, filtered to remove null entries\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Vector3D>? Vectors { get; }
```

Implements [Vectors](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistribution.Vectors 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution\.Vectors')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Communication.Classes.AngularPowerDistribution.GetPower()'></a>

## AngularPowerDistribution\.GetPower\(\) Method

Calculates the total power by summing the lengths of all stored vectors\.

```csharp
public double GetPower();
```

Implements [GetPower\(\)](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistribution.GetPower() 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution\.GetPower\(\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The sum of the vector lengths, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the vectors collection is null\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile'></a>

## AngularPowerDistributionProfile Class

Represents a profile that defines the angular power distribution associated with a specific 3D location\.

```csharp
public class AngularPowerDistributionProfile : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.IAngularPowerDistributionProfile, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → AngularPowerDistributionProfile

Implements [IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile'), [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(DiGi.Communication.Classes.AngularPowerDistributionProfile)'></a>

## AngularPowerDistributionProfile\(AngularPowerDistributionProfile\) Constructor

Initializes a new instance of the [AngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfile') class, optionally copying values from an existing profile\.

```csharp
public AngularPowerDistributionProfile(DiGi.Communication.Classes.AngularPowerDistributionProfile? angularPowerDistributionProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(DiGi.Communication.Classes.AngularPowerDistributionProfile).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [AngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfile')

The source [AngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfile') to copy data from, or `null` to create a new instance\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.AngularPowerDistribution_)'></a>

## AngularPowerDistributionProfile\(Point3D, IEnumerable\<AngularPowerDistribution\>\) Constructor

Initializes a new instance of the [AngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfile') class\.

```csharp
public AngularPowerDistributionProfile(DiGi.Geometry.Spatial.Classes.Point3D? location, System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.AngularPowerDistribution>? angularPowerDistributions);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.AngularPowerDistribution_).location'></a>

`location` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The location of the angular power distribution profile in three\-dimensional space\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.AngularPowerDistribution_).angularPowerDistributions'></a>

`angularPowerDistributions` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of angular power distributions associated with this profile\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.AngularPowerDistribution_)'></a>

## AngularPowerDistributionProfile\(Guid, Point3D, IEnumerable\<AngularPowerDistribution\>\) Constructor

Initializes a new instance of the [AngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfile') class\.

```csharp
public AngularPowerDistributionProfile(System.Guid guid, DiGi.Geometry.Spatial.Classes.Point3D? location, System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.AngularPowerDistribution>? angularPowerDistributions);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.AngularPowerDistribution_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the profile\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.AngularPowerDistribution_).location'></a>

`location` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The location in three\-dimensional space\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.AngularPowerDistribution_).angularPowerDistributions'></a>

`angularPowerDistributions` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of angular power distributions\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(System.Text.Json.Nodes.JsonObject)'></a>

## AngularPowerDistributionProfile\(JsonObject\) Constructor

Initializes a new instance of the [AngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfile') class using the specified JSON object\.

```csharp
public AngularPowerDistributionProfile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributionProfile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the profile\.
### Properties

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.AngularPowerDistributions'></a>

## AngularPowerDistributionProfile\.AngularPowerDistributions Property

Gets or sets the collection of angular power distributions associated with this profile\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.AngularPowerDistribution>? AngularPowerDistributions { get; private set; }
```

Implements [AngularPowerDistributions](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile.AngularPowerDistributions 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile\.AngularPowerDistributions')

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.Location'></a>

## AngularPowerDistributionProfile\.Location Property

Gets the location of the angular power distribution profile in three\-dimensional space\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Location { get; }
```

Implements [Location](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile.Location 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile\.Location')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')
### Methods

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.GetRays(double)'></a>

## AngularPowerDistributionProfile\.GetRays\(double\) Method

Retrieves a list of rays associated with the specified delay\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Classes.Ray>? GetRays(double delay);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.GetRays(double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The time delay used to look up the angular power distribution\.

Implements [GetRays\(double\)](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile.GetRays(double) 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile\.GetRays\(double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray') objects if the distribution is found for the given delay; otherwise, `null`\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation'></a>

## AngularPowerDistributionProfileAntennaRelation Class

Represents a one\-to\-one directional relationship between an angular power distribution profile and an antenna\.

```csharp
public class AngularPowerDistributionProfileAntennaRelation : DiGi.Core.Relation.Classes.OneToOneDirectionalRelation<DiGi.Communication.Interfaces.IAngularPowerDistributionProfile, DiGi.Communication.Interfaces.IAntenna>, DiGi.Communication.Interfaces.ICommunicationRelation, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2') → AngularPowerDistributionProfileAntennaRelation

Implements [ICommunicationRelation](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationRelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation.AngularPowerDistributionProfileAntennaRelation(DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation)'></a>

## AngularPowerDistributionProfileAntennaRelation\(AngularPowerDistributionProfileAntennaRelation\) Constructor

Initializes a new instance of the [AngularPowerDistributionProfileAntennaRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfileAntennaRelation') class based on an existing instance\.

```csharp
public AngularPowerDistributionProfileAntennaRelation(DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation angularPowerDistributionProfileAntennaRelation);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation.AngularPowerDistributionProfileAntennaRelation(DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation).angularPowerDistributionProfileAntennaRelation'></a>

`angularPowerDistributionProfileAntennaRelation` [AngularPowerDistributionProfileAntennaRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfileAntennaRelation')

The existing [AngularPowerDistributionProfileAntennaRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfileAntennaRelation') instance to copy from\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation.AngularPowerDistributionProfileAntennaRelation(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna)'></a>

## AngularPowerDistributionProfileAntennaRelation\(IAngularPowerDistributionProfile, IAntenna\) Constructor

Initializes a new instance of the [AngularPowerDistributionProfileAntennaRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfileAntennaRelation') class\.

```csharp
public AngularPowerDistributionProfileAntennaRelation(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile angularPowerDistributionProfile, DiGi.Communication.Interfaces.IAntenna antenna);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation.AngularPowerDistributionProfileAntennaRelation(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile to be associated\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation.AngularPowerDistributionProfileAntennaRelation(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The antenna to be associated\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation.AngularPowerDistributionProfileAntennaRelation(System.Text.Json.Nodes.JsonObject)'></a>

## AngularPowerDistributionProfileAntennaRelation\(JsonObject\) Constructor

Initializes a new instance of the [AngularPowerDistributionProfileAntennaRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfileAntennaRelation') class using the specified JSON object\.

```csharp
public AngularPowerDistributionProfileAntennaRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation.AngularPowerDistributionProfileAntennaRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the relation\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionSolver'></a>

## AngularPowerDistributionSolver Class

Provides functionality to solve the distribution of angular power based on a set of defined angular power distribution profiles and solver options\.

```csharp
public class AngularPowerDistributionSolver : DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → AngularPowerDistributionSolver

Implements [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISolver](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver 'DiGi\.Core\.Interfaces\.ISolver'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Properties

<a name='DiGi.Communication.Classes.AngularPowerDistributionSolver.AngularPowerDistributionProfiles'></a>

## AngularPowerDistributionSolver\.AngularPowerDistributionProfiles Property

Gets the list of angular power distribution profiles, filtered to remove null entries and cloned to ensure data integrity\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Interfaces.IAngularPowerDistributionProfile>? AngularPowerDistributionProfiles { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.AngularPowerDistributionSolver.AngularPowerDistributionSolverOptions'></a>

## AngularPowerDistributionSolver\.AngularPowerDistributionSolverOptions Property

Gets or sets the configuration options for the angular power distribution solver\.

```csharp
public DiGi.Communication.Classes.AngularPowerDistributionSolverOptions? AngularPowerDistributionSolverOptions { get; set; }
```

#### Property Value
[AngularPowerDistributionSolverOptions](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionSolverOptions 'DiGi\.Communication\.Classes\.AngularPowerDistributionSolverOptions')

<a name='DiGi.Communication.Classes.AngularPowerDistributionSolver.GeometricalPropagationModel'></a>

## AngularPowerDistributionSolver\.GeometricalPropagationModel Property

Gets or sets the geometrical propagation model used by the solver to calculate the angular power distribution\.

```csharp
public DiGi.Communication.Classes.GeometricalPropagationModel? GeometricalPropagationModel { get; set; }
```

#### Property Value
[GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')
### Methods

<a name='DiGi.Communication.Classes.AngularPowerDistributionSolver.Solve()'></a>

## AngularPowerDistributionSolver\.Solve\(\) Method

Executes the solving operation for the angular power distribution\.

```csharp
public bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the solver successfully executed; otherwise, `false`\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionSolverOptions'></a>

## AngularPowerDistributionSolverOptions Class

Provides configuration options for the angular power distribution solver, including tolerance and ray count settings\.

```csharp
public class AngularPowerDistributionSolverOptions : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → AngularPowerDistributionSolverOptions

Implements [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ioptions 'DiGi\.Core\.Interfaces\.IOptions')
### Properties

<a name='DiGi.Communication.Classes.AngularPowerDistributionSolverOptions.RayCount'></a>

## AngularPowerDistributionSolverOptions\.RayCount Property

Gets or sets the number of rays used by the angular power distribution solver\.

```csharp
public int RayCount { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Communication.Classes.AngularPowerDistributionSolverOptions.Tolerance'></a>

## AngularPowerDistributionSolverOptions\.Tolerance Property

Gets or sets the tolerance value used for comparisons and geometric operations within the angular power distribution solver\.

```csharp
public double Tolerance { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.Antenna'></a>

## Antenna Class

Represents an antenna within the communication system, specifying its spatial location and the set of functions it supports\.

```csharp
public class Antenna : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.IAntenna, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → Antenna

Implements [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna'), [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Communication.Classes.Antenna.Antenna(DiGi.Communication.Classes.Antenna)'></a>

## Antenna\(Antenna\) Constructor

Initializes a new instance of the [Antenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Antenna 'DiGi\.Communication\.Classes\.Antenna') class by copying another antenna instance\.

```csharp
public Antenna(DiGi.Communication.Classes.Antenna? antenna);
```
#### Parameters

<a name='DiGi.Communication.Classes.Antenna.Antenna(DiGi.Communication.Classes.Antenna).antenna'></a>

`antenna` [Antenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Antenna 'DiGi\.Communication\.Classes\.Antenna')

The source antenna instance to copy from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Communication.Classes.Antenna.Antenna(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Communication.Enums.Function[])'></a>

## Antenna\(Point3D, Function\[\]\) Constructor

Initializes a new instance of the [Antenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Antenna 'DiGi\.Communication\.Classes\.Antenna') class with the specified location and functions\.

```csharp
public Antenna(DiGi.Geometry.Spatial.Classes.Point3D? location, params DiGi.Communication.Enums.Function[]? functions);
```
#### Parameters

<a name='DiGi.Communication.Classes.Antenna.Antenna(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Communication.Enums.Function[]).location'></a>

`location` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The three\-dimensional coordinates where the antenna is located\.

<a name='DiGi.Communication.Classes.Antenna.Antenna(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Communication.Enums.Function[]).functions'></a>

`functions` [Function](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Function 'DiGi\.Communication\.Enums\.Function')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

A variable number of functions associated with the antenna\.

<a name='DiGi.Communication.Classes.Antenna.Antenna(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Communication.Enums.Function[])'></a>

## Antenna\(Guid, Point3D, Function\[\]\) Constructor

Initializes a new instance of the [Antenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Antenna 'DiGi\.Communication\.Classes\.Antenna') class with the specified unique identifier, location, and functions\.

```csharp
public Antenna(System.Guid guid, DiGi.Geometry.Spatial.Classes.Point3D? location, params DiGi.Communication.Enums.Function[]? functions);
```
#### Parameters

<a name='DiGi.Communication.Classes.Antenna.Antenna(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Communication.Enums.Function[]).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the antenna\.

<a name='DiGi.Communication.Classes.Antenna.Antenna(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Communication.Enums.Function[]).location'></a>

`location` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The three\-dimensional point representing the location of the antenna\.

<a name='DiGi.Communication.Classes.Antenna.Antenna(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Communication.Enums.Function[]).functions'></a>

`functions` [Function](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Function 'DiGi\.Communication\.Enums\.Function')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An optional collection of functions associated with the antenna\.

<a name='DiGi.Communication.Classes.Antenna.Antenna(System.Text.Json.Nodes.JsonObject)'></a>

## Antenna\(JsonObject\) Constructor

Initializes a new instance of the [Antenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Antenna 'DiGi\.Communication\.Classes\.Antenna') class using the specified JSON object\.

```csharp
public Antenna(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.Antenna.Antenna(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the antenna instance, or null\.
### Properties

<a name='DiGi.Communication.Classes.Antenna.Functions'></a>

## Antenna\.Functions Property

Gets the set of functions associated with the antenna\.

```csharp
public System.Collections.Generic.HashSet<DiGi.Communication.Enums.Function>? Functions { get; }
```

Implements [Functions](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna.Functions 'DiGi\.Communication\.Interfaces\.IAntenna\.Functions')

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[Function](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Function 'DiGi\.Communication\.Enums\.Function')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing the antenna's functions, or `null` if none are defined\.

<a name='DiGi.Communication.Classes.Antenna.Location'></a>

## Antenna\.Location Property

Gets the three\-dimensional location of the antenna\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Location { get; }
```

Implements [Location](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna.Location 'DiGi\.Communication\.Interfaces\.IAntenna\.Location')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Classes.CommunicationRelationCluster'></a>

## CommunicationRelationCluster Class

Represents a cluster of communication relations, providing functionality to manage unique relationships between communication GUID objects and communication relations while supporting serialization\.

```csharp
public class CommunicationRelationCluster : DiGi.Core.Relation.Classes.UniqueObjectRelationCluster<DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationRelation>, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3') → [DiGi\.Core\.Classes\.ValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3') → [DiGi\.Core\.Classes\.SerializableObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3') → [DiGi\.Core\.Classes\.UniqueObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1')[ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1') → [DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2')[ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2')[ICommunicationRelation](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationRelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2') → CommunicationRelationCluster

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.CommunicationRelationCluster()'></a>

## CommunicationRelationCluster\(\) Constructor

Initializes a new instance of the [CommunicationRelationCluster](DiGi.Communication.Classes.md#DiGi.Communication.Classes.CommunicationRelationCluster 'DiGi\.Communication\.Classes\.CommunicationRelationCluster') class\.

```csharp
public CommunicationRelationCluster();
```

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.CommunicationRelationCluster(DiGi.Communication.Classes.CommunicationRelationCluster)'></a>

## CommunicationRelationCluster\(CommunicationRelationCluster\) Constructor

Initializes a new instance of the [CommunicationRelationCluster](DiGi.Communication.Classes.md#DiGi.Communication.Classes.CommunicationRelationCluster 'DiGi\.Communication\.Classes\.CommunicationRelationCluster') class, optionally copying data from an existing cluster\.

```csharp
public CommunicationRelationCluster(DiGi.Communication.Classes.CommunicationRelationCluster? communicationRelationCluster);
```
#### Parameters

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.CommunicationRelationCluster(DiGi.Communication.Classes.CommunicationRelationCluster).communicationRelationCluster'></a>

`communicationRelationCluster` [CommunicationRelationCluster](DiGi.Communication.Classes.md#DiGi.Communication.Classes.CommunicationRelationCluster 'DiGi\.Communication\.Classes\.CommunicationRelationCluster')

The source communication relation cluster to initialize from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') to create a new empty instance\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.CommunicationRelationCluster(System.Text.Json.Nodes.JsonObject)'></a>

## CommunicationRelationCluster\(JsonObject\) Constructor

Initializes a new instance of the [CommunicationRelationCluster](DiGi.Communication.Classes.md#DiGi.Communication.Classes.CommunicationRelationCluster 'DiGi\.Communication\.Classes\.CommunicationRelationCluster') class using the specified JSON object\.

```csharp
public CommunicationRelationCluster(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.CommunicationRelationCluster(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the cluster, which may be null\.
### Methods

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna)'></a>

## CommunicationRelationCluster\.AddRelation\(IAngularPowerDistributionProfile, IAntenna\) Method

Adds a relation between the specified angular power distribution profile and antenna\.

```csharp
public DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation? AddRelation(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile? angularPowerDistributionProfile, DiGi.Communication.Interfaces.IAntenna? antenna);
```
#### Parameters

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile to associate\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The antenna to associate\.

#### Returns
[AngularPowerDistributionProfileAntennaRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfileAntennaRelation')  
A new [AngularPowerDistributionProfileAntennaRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation 'DiGi\.Communication\.Classes\.AngularPowerDistributionProfileAntennaRelation') if both parameters are non\-null; otherwise, null\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna)'></a>

## CommunicationRelationCluster\.AddRelation\(IMultipathPowerDelayProfile, IAntenna, IAntenna\) Method

Adds a relation between a multipath power delay profile and two antennas\.

```csharp
public DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation? AddRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile? multipathPowerDelayProfile, DiGi.Communication.Interfaces.IAntenna? antenna_1, DiGi.Communication.Interfaces.IAntenna? antenna_2);
```
#### Parameters

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile to be associated\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna involved in the relation\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The second antenna involved in the relation\.

#### Returns
[MultipathPowerDelayProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation 'DiGi\.Communication\.Classes\.MultipathPowerDelayProfileAntennasRelation')  
The created [MultipathPowerDelayProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation 'DiGi\.Communication\.Classes\.MultipathPowerDelayProfileAntennasRelation') if successful; otherwise, `null`\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringGroup,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_)'></a>

## CommunicationRelationCluster\.AddRelation\(IScatteringGroup, IEnumerable\<IScatteringObject\>\) Method

Adds a relation between the specified scattering group and its scattering objects, replacing any existing relation for that group\.

```csharp
public DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation? AddRelation(DiGi.Communication.Interfaces.IScatteringGroup? scatteringGroup, System.Collections.Generic.IEnumerable<DiGi.Communication.Interfaces.IScatteringObject>? scatteringObjects);
```
#### Parameters

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringGroup,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_).scatteringGroup'></a>

`scatteringGroup` [IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')

The scattering group to associate\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringGroup,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_).scatteringObjects'></a>

`scatteringObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The scattering objects to associate with the scattering group\.

#### Returns
[ScatteringGroupScatteringObjectsRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation 'DiGi\.Communication\.Classes\.ScatteringGroupScatteringObjectsRelation')  
The created [ScatteringGroupScatteringObjectsRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation 'DiGi\.Communication\.Classes\.ScatteringGroupScatteringObjectsRelation') if successful; otherwise, `null`\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna)'></a>

## CommunicationRelationCluster\.AddRelation\(IScatteringProfile, IAntenna, IAntenna\) Method

Adds a relation between a scattering profile and two antennas\.

```csharp
public DiGi.Communication.Classes.ScatteringProfileAntennasRelation? AddRelation(DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile, DiGi.Communication.Interfaces.IAntenna? antenna_1, DiGi.Communication.Interfaces.IAntenna? antenna_2);
```
#### Parameters

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).scatteringProfile'></a>

`scatteringProfile` [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to associate with the antennas\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna involved in the relation\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The second antenna involved in the relation\.

#### Returns
[ScatteringProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileAntennasRelation 'DiGi\.Communication\.Classes\.ScatteringProfileAntennasRelation')  
A [ScatteringProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileAntennasRelation 'DiGi\.Communication\.Classes\.ScatteringProfileAntennasRelation') if the relation was successfully created; otherwise, `null`\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile)'></a>

## CommunicationRelationCluster\.AddRelation\(IScatteringProfile, IMultipathPowerDelayProfile\) Method

Adds a relation between the specified scattering profile and multipath power delay profile\.

```csharp
public DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation? AddRelation(DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile, DiGi.Communication.Interfaces.IMultipathPowerDelayProfile? multipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).scatteringProfile'></a>

`scatteringProfile` [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to associate\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile to associate\.

#### Returns
[ScatteringProfileMultipathPowerDelayProfileRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation 'DiGi\.Communication\.Classes\.ScatteringProfileMultipathPowerDelayProfileRelation')  
A [ScatteringProfileMultipathPowerDelayProfileRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation 'DiGi\.Communication\.Classes\.ScatteringProfileMultipathPowerDelayProfileRelation') if the relation was successfully added; otherwise, `null` if either parameter is null\.

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile'></a>

## ComplexMultipathPowerDelayProfile Class

Represents a complex multipath power delay profile that manages both visible and hidden
simple multipath power delay profiles for communication signal analysis\.

```csharp
public class ComplexMultipathPowerDelayProfile : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile, DiGi.Communication.Interfaces.IMultipathPowerDelayProfile, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → ComplexMultipathPowerDelayProfile

Implements [IComplexMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile'), [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile'), [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile)'></a>

## ComplexMultipathPowerDelayProfile\(ComplexMultipathPowerDelayProfile\) Constructor

Initializes a new instance of the [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile') class by copying another instance\.

```csharp
public ComplexMultipathPowerDelayProfile(DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile? complexMultipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile).complexMultipathPowerDelayProfile'></a>

`complexMultipathPowerDelayProfile` [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile')

The source [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile') object to copy from, or null to create an empty instance\.

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile)'></a>

## ComplexMultipathPowerDelayProfile\(ISimpleMultipathPowerDelayProfile, ISimpleMultipathPowerDelayProfile\) Constructor

Initializes a new instance of the [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile') class using the specified visible and hidden simple multipath power delay profiles\.

```csharp
public ComplexMultipathPowerDelayProfile(DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile_Visible, DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile_Hidden);
```
#### Parameters

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile).simpleMultipathPowerDelayProfile_Visible'></a>

`simpleMultipathPowerDelayProfile_Visible` [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

The visible simple multipath power delay profile to be cloned and assigned\.

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile).simpleMultipathPowerDelayProfile_Hidden'></a>

`simpleMultipathPowerDelayProfile_Hidden` [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

The hidden simple multipath power delay profile to be cloned and assigned\.

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(System.Guid,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile)'></a>

## ComplexMultipathPowerDelayProfile\(Guid, ISimpleMultipathPowerDelayProfile, ISimpleMultipathPowerDelayProfile\) Constructor

Initializes a new instance of the [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile') class\.

```csharp
public ComplexMultipathPowerDelayProfile(System.Guid guid, DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile_Visible, DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile_Hidden);
```
#### Parameters

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(System.Guid,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the object\.

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(System.Guid,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile).simpleMultipathPowerDelayProfile_Visible'></a>

`simpleMultipathPowerDelayProfile_Visible` [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

The visible simple multipath power delay profile\.

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(System.Guid,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile).simpleMultipathPowerDelayProfile_Hidden'></a>

`simpleMultipathPowerDelayProfile_Hidden` [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

The hidden simple multipath power delay profile\.

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(System.Text.Json.Nodes.JsonObject)'></a>

## ComplexMultipathPowerDelayProfile\(JsonObject\) Constructor

Initializes a new instance of the [ComplexMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.ComplexMultipathPowerDelayProfile') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public ComplexMultipathPowerDelayProfile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the current instance\.
### Methods

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.GetSimpleMultipathPowerDelay(bool)'></a>

## ComplexMultipathPowerDelayProfile\.GetSimpleMultipathPowerDelay\(bool\) Method

Retrieves a clone of the simple multipath power delay profile based on the specified visibility\.

```csharp
public DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile? GetSimpleMultipathPowerDelay(bool visible);
```
#### Parameters

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.GetSimpleMultipathPowerDelay(bool).visible'></a>

`visible` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to retrieve the visible \(`true`\) or hidden \(`false`\) profile\.

Implements [GetSimpleMultipathPowerDelay\(bool\)](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IComplexMultipathPowerDelayProfile.GetSimpleMultipathPowerDelay(bool) 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile\.GetSimpleMultipathPowerDelay\(bool\)')

#### Returns
[ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')  
The cloned [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile') corresponding to the requested visibility, or `null` if it does not exist\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel'></a>

## GeometricalPropagationModel Class

Represents a geometrical propagation model used to define and manage communication relation clusters within the system\.

```csharp
public class GeometricalPropagationModel : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidModel, DiGi.Core.Interfaces.ISerializableModel, DiGi.Core.Interfaces.IModel
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → GeometricalPropagationModel

Implements [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidmodel 'DiGi\.Core\.Interfaces\.IGuidModel'), [DiGi\.Core\.Interfaces\.ISerializableModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializablemodel 'DiGi\.Core\.Interfaces\.ISerializableModel'), [DiGi\.Core\.Interfaces\.IModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.imodel 'DiGi\.Core\.Interfaces\.IModel')
### Constructors

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GeometricalPropagationModel()'></a>

## GeometricalPropagationModel\(\) Constructor

Initializes a new instance of the [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel') class\.

```csharp
public GeometricalPropagationModel();
```

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GeometricalPropagationModel(DiGi.Communication.Classes.GeometricalPropagationModel)'></a>

## GeometricalPropagationModel\(GeometricalPropagationModel\) Constructor

Initializes a new instance of the [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel') class by copying an existing instance\.

```csharp
public GeometricalPropagationModel(DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GeometricalPropagationModel(DiGi.Communication.Classes.GeometricalPropagationModel).geometricalPropagationModel'></a>

`geometricalPropagationModel` [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

The source [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel') instance to copy from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GeometricalPropagationModel(System.Text.Json.Nodes.JsonObject)'></a>

## GeometricalPropagationModel\(JsonObject\) Constructor

Initializes a new instance of the [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel') class using the specified JSON object\.

```csharp
public GeometricalPropagationModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GeometricalPropagationModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') from which to initialize the model\.
### Methods

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna)'></a>

## GeometricalPropagationModel\.Assign\(IAngularPowerDistributionProfile, IAntenna\) Method

Assigns an angular power distribution profile and an antenna to the geometrical propagation model\.

```csharp
public bool Assign(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile? angularPowerDistributionProfile, DiGi.Communication.Interfaces.IAntenna? antenna);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile to be assigned\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The antenna to be assigned\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the assignment was successful; otherwise, false\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna)'></a>

## GeometricalPropagationModel\.Assign\(IMultipathPowerDelayProfile, IAntenna, IAntenna\) Method

Assigns a multipath power delay profile and two antennas to the geometrical propagation model\.

```csharp
public bool Assign(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile? multipathPowerDelayProfile, DiGi.Communication.Interfaces.IAntenna? antenna_1, DiGi.Communication.Interfaces.IAntenna? antenna_2);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile to be assigned\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna to be associated with the propagation model\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The second antenna to be associated with the propagation model\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the assignment was successful; otherwise, `false`\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna)'></a>

## GeometricalPropagationModel\.Assign\(IScatteringProfile, IAntenna, IAntenna\) Method

Assigns a scattering profile and two antennas to the geometrical propagation model\.

```csharp
public bool Assign(DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile, DiGi.Communication.Interfaces.IAntenna? antenna_1, DiGi.Communication.Interfaces.IAntenna? antenna_2);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).scatteringProfile'></a>

`scatteringProfile` [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to be assigned\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna involved in the propagation\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The second antenna involved in the propagation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the assignment was successful; otherwise, `false`\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile)'></a>

## GeometricalPropagationModel\.Assign\(IScatteringProfile, IMultipathPowerDelayProfile\) Method

Assigns the specified scattering profile and multipath power delay profile to the propagation model\.

```csharp
public bool Assign(DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile, DiGi.Communication.Interfaces.IMultipathPowerDelayProfile? multipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).scatteringProfile'></a>

`scatteringProfile` [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to be assigned\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile to be assigned\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the assignment was successful; otherwise, false\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAngularPowerDistributionProfiles_TAngularPowerDistributionProfile_()'></a>

## GeometricalPropagationModel\.GetAngularPowerDistributionProfiles\<TAngularPowerDistributionProfile\>\(\) Method

Retrieves the list of angular power distribution profiles associated with the geometrical propagation model\.

```csharp
public System.Collections.Generic.List<TAngularPowerDistributionProfile>? GetAngularPowerDistributionProfiles<TAngularPowerDistributionProfile>()
    where TAngularPowerDistributionProfile : DiGi.Communication.Interfaces.IAngularPowerDistributionProfile;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAngularPowerDistributionProfiles_TAngularPowerDistributionProfile_().TAngularPowerDistributionProfile'></a>

`TAngularPowerDistributionProfile`

The type of the angular power distribution profile, which must implement [IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TAngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetAngularPowerDistributionProfiles_TAngularPowerDistributionProfile_().TAngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetAngularPowerDistributionProfiles\<TAngularPowerDistributionProfile\>\(\)\.TAngularPowerDistributionProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of angular power distribution profiles of type [TAngularPowerDistributionProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetAngularPowerDistributionProfiles_TAngularPowerDistributionProfile_().TAngularPowerDistributionProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetAngularPowerDistributionProfiles\<TAngularPowerDistributionProfile\>\(\)\.TAngularPowerDistributionProfile'), or null if no such profiles are found\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_()'></a>

## GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(\) Method

Retrieves a list of antennas of the specified type associated with this geometrical propagation model\.

```csharp
public System.Collections.Generic.List<TAntenna>? GetAntennas<TAntenna>()
    where TAntenna : DiGi.Communication.Interfaces.IAntenna;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_().TAntenna'></a>

`TAntenna`

The type of antenna to retrieve, which must implement [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TAntenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_().TAntenna 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(\)\.TAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of antennas of type [TAntenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_().TAntenna 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(\)\.TAntenna') if any are found; otherwise, null\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile)'></a>

## GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(IMultipathPowerDelayProfile\) Method

Retrieves a list of antennas associated with the specified multipath power delay profile\.

```csharp
public System.Collections.Generic.List<TAntenna>? GetAntennas<TAntenna>(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile? multipathPowerDelayProfile)
    where TAntenna : DiGi.Communication.Interfaces.IAntenna;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).TAntenna'></a>

`TAntenna`

The type of antenna, which must implement the [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna') interface\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile used to identify the associated antennas\. Can be null\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TAntenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).TAntenna 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile\)\.TAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of antennas of type [TAntenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).TAntenna 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile\)\.TAntenna') if a valid profile is provided and relations are found; otherwise, null\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna)'></a>

## GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(IMultipathPowerDelayProfile, IAntenna\) Method

Retrieves a list of antennas based on the specified multipath power delay profile and antenna reference\.

```csharp
public System.Collections.Generic.List<TAntenna>? GetAntennas<TAntenna>(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile? multipathPowerDelayProfile, DiGi.Communication.Interfaces.IAntenna? antenna)
    where TAntenna : DiGi.Communication.Interfaces.IAntenna;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna).TAntenna'></a>

`TAntenna`

The type of antenna to be returned, which must implement [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile used for the retrieval process\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The reference antenna used to identify the antennas to retrieve\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TAntenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna).TAntenna 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile, DiGi\.Communication\.Interfaces\.IAntenna\)\.TAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of antennas of type \<typeparam ref="TAntenna" /\> if the parameters are valid; otherwise, null\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IScatteringProfile)'></a>

## GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(IScatteringProfile\) Method

Retrieves the list of antennas associated with the specified scattering profile\.

```csharp
public System.Collections.Generic.List<TAntenna>? GetAntennas<TAntenna>(DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile)
    where TAntenna : DiGi.Communication.Interfaces.IAntenna;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IScatteringProfile).TAntenna'></a>

`TAntenna`

The type of antenna, which must implement the [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna') interface\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile used to identify the related antennas\. If null, no antennas are retrieved\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TAntenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IScatteringProfile).TAntenna 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(DiGi\.Communication\.Interfaces\.IScatteringProfile\)\.TAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of antennas of type [TAntenna](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IScatteringProfile).TAntenna 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetAntennas\<TAntenna\>\(DiGi\.Communication\.Interfaces\.IScatteringProfile\)\.TAntenna') associated with the provided scattering profile, or null if the profile is null or no relations are found\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfile_TMultipathPowerDelayProfile_(DiGi.Communication.Interfaces.IScatteringProfile)'></a>

## GeometricalPropagationModel\.GetMultipathPowerDelayProfile\<TMultipathPowerDelayProfile\>\(IScatteringProfile\) Method

Retrieves the multipath power delay profile associated with the specified scattering profile\.

```csharp
public TMultipathPowerDelayProfile? GetMultipathPowerDelayProfile<TMultipathPowerDelayProfile>(DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile)
    where TMultipathPowerDelayProfile : DiGi.Communication.Interfaces.IMultipathPowerDelayProfile;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfile_TMultipathPowerDelayProfile_(DiGi.Communication.Interfaces.IScatteringProfile).TMultipathPowerDelayProfile'></a>

`TMultipathPowerDelayProfile`

The type of the multipath power delay profile to retrieve, which must implement [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfile_TMultipathPowerDelayProfile_(DiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile for which the multipath power delay profile is retrieved\.

#### Returns
[TMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfile_TMultipathPowerDelayProfile_(DiGi.Communication.Interfaces.IScatteringProfile).TMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetMultipathPowerDelayProfile\<TMultipathPowerDelayProfile\>\(DiGi\.Communication\.Interfaces\.IScatteringProfile\)\.TMultipathPowerDelayProfile')  
The multipath power delay profile of type [TMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfile_TMultipathPowerDelayProfile_(DiGi.Communication.Interfaces.IScatteringProfile).TMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetMultipathPowerDelayProfile\<TMultipathPowerDelayProfile\>\(DiGi\.Communication\.Interfaces\.IScatteringProfile\)\.TMultipathPowerDelayProfile') if a relation exists; otherwise, null\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfiles_TMultipathPowerDelayProfile_()'></a>

## GeometricalPropagationModel\.GetMultipathPowerDelayProfiles\<TMultipathPowerDelayProfile\>\(\) Method

Retrieves a list of multipath power delay profiles of the specified type from the communication relation cluster\.

```csharp
public System.Collections.Generic.List<TMultipathPowerDelayProfile>? GetMultipathPowerDelayProfiles<TMultipathPowerDelayProfile>()
    where TMultipathPowerDelayProfile : DiGi.Communication.Interfaces.IMultipathPowerDelayProfile;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfiles_TMultipathPowerDelayProfile_().TMultipathPowerDelayProfile'></a>

`TMultipathPowerDelayProfile`

The type of multipath power delay profile to retrieve, which must implement [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfiles_TMultipathPowerDelayProfile_().TMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetMultipathPowerDelayProfiles\<TMultipathPowerDelayProfile\>\(\)\.TMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [TMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfiles_TMultipathPowerDelayProfile_().TMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetMultipathPowerDelayProfiles\<TMultipathPowerDelayProfile\>\(\)\.TMultipathPowerDelayProfile') objects if available; otherwise, `null`\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringGroups_TScatteringGroup_()'></a>

## GeometricalPropagationModel\.GetScatteringGroups\<TScatteringGroup\>\(\) Method

Gets all scattering groups of the specified type from the model\.

```csharp
public System.Collections.Generic.List<TScatteringGroup>? GetScatteringGroups<TScatteringGroup>()
    where TScatteringGroup : DiGi.Communication.Interfaces.IScatteringGroup;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringGroups_TScatteringGroup_().TScatteringGroup'></a>

`TScatteringGroup`

The type of scattering group to retrieve, which must implement [IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringGroups_TScatteringGroup_().TScatteringGroup 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringGroups\<TScatteringGroup\>\(\)\.TScatteringGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of scattering groups of type [TScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringGroups_TScatteringGroup_().TScatteringGroup 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringGroups\<TScatteringGroup\>\(\)\.TScatteringGroup') if any are found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_()'></a>

## GeometricalPropagationModel\.GetScatteringObjects\<TScatteringObject\>\(\) Method

Retrieves a list of scattering objects of the specified type from the communication relation cluster\.

```csharp
public System.Collections.Generic.List<TScatteringObject>? GetScatteringObjects<TScatteringObject>()
    where TScatteringObject : DiGi.Communication.Interfaces.IScatteringObject;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_().TScatteringObject'></a>

`TScatteringObject`

The type of scattering object to retrieve, which must implement [IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_().TScatteringObject 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringObjects\<TScatteringObject\>\(\)\.TScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of scattering objects of type [TScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_().TScatteringObject 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringObjects\<TScatteringObject\>\(\)\.TScatteringObject'), or `null` if the collection is empty or unavailable\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_(DiGi.Communication.Interfaces.IScatteringGroup)'></a>

## GeometricalPropagationModel\.GetScatteringObjects\<TScatteringObject\>\(IScatteringGroup\) Method

Gets all scattering objects of the specified type associated with the given scattering group\.

```csharp
public System.Collections.Generic.List<TScatteringObject>? GetScatteringObjects<TScatteringObject>(DiGi.Communication.Interfaces.IScatteringGroup? scatteringGroup)
    where TScatteringObject : DiGi.Communication.Interfaces.IScatteringObject;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_(DiGi.Communication.Interfaces.IScatteringGroup).TScatteringObject'></a>

`TScatteringObject`

The type of scattering object to retrieve, which must implement [IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_(DiGi.Communication.Interfaces.IScatteringGroup).scatteringGroup'></a>

`scatteringGroup` [IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')

The scattering group whose scattering objects to retrieve\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_(DiGi.Communication.Interfaces.IScatteringGroup).TScatteringObject 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringObjects\<TScatteringObject\>\(DiGi\.Communication\.Interfaces\.IScatteringGroup\)\.TScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of scattering objects of type [TScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_(DiGi.Communication.Interfaces.IScatteringGroup).TScatteringObject 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringObjects\<TScatteringObject\>\(DiGi\.Communication\.Interfaces\.IScatteringGroup\)\.TScatteringObject') if any are found; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_()'></a>

## GeometricalPropagationModel\.GetScatteringProfiles\<TScatteringProfile\>\(\) Method

Retrieves a list of scattering profiles of the specified type associated with the propagation model\.

```csharp
public System.Collections.Generic.List<TScatteringProfile>? GetScatteringProfiles<TScatteringProfile>()
    where TScatteringProfile : DiGi.Communication.Interfaces.IScatteringProfile;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_().TScatteringProfile'></a>

`TScatteringProfile`

The type of scattering profile to retrieve, which must implement [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_().TScatteringProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringProfiles\<TScatteringProfile\>\(\)\.TScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of scattering profiles of type [TScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_().TScatteringProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringProfiles\<TScatteringProfile\>\(\)\.TScatteringProfile') if any are found; otherwise, null\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna)'></a>

## GeometricalPropagationModel\.GetScatteringProfiles\<TScatteringProfile\>\(IAntenna, IAntenna\) Method

Retrieves the scattering profiles between two specified antennas\.

```csharp
public System.Collections.Generic.List<TScatteringProfile>? GetScatteringProfiles<TScatteringProfile>(DiGi.Communication.Interfaces.IAntenna? antenna_1, DiGi.Communication.Interfaces.IAntenna? antenna_2)
    where TScatteringProfile : DiGi.Communication.Interfaces.IScatteringProfile;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).TScatteringProfile'></a>

`TScatteringProfile`

The type of scattering profile to retrieve, which must implement [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna involved in the propagation path\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The second antenna involved in the propagation path\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).TScatteringProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringProfiles\<TScatteringProfile\>\(DiGi\.Communication\.Interfaces\.IAntenna, DiGi\.Communication\.Interfaces\.IAntenna\)\.TScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of scattering profiles if both antennas are provided; otherwise, null\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Group_TScatteringObject_(string,System.Collections.Generic.IEnumerable_TScatteringObject_)'></a>

## GeometricalPropagationModel\.Group\<TScatteringObject\>\(string, IEnumerable\<TScatteringObject\>\) Method

Creates a scattering group from the specified collection of scattering objects and adds it to the model\.

The bounding box of the resulting group encloses all provided scattering objects.

```csharp
public DiGi.Communication.Classes.ScatteringGroup? Group<TScatteringObject>(string? reference, System.Collections.Generic.IEnumerable<TScatteringObject>? scatteringObjects)
    where TScatteringObject : DiGi.Communication.Interfaces.IScatteringObject;
```
#### Type parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Group_TScatteringObject_(string,System.Collections.Generic.IEnumerable_TScatteringObject_).TScatteringObject'></a>

`TScatteringObject`

The type of the scattering objects, which must implement [IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Group_TScatteringObject_(string,System.Collections.Generic.IEnumerable_TScatteringObject_).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the new scattering group\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Group_TScatteringObject_(string,System.Collections.Generic.IEnumerable_TScatteringObject_).scatteringObjects'></a>

`scatteringObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.Group_TScatteringObject_(string,System.Collections.Generic.IEnumerable_TScatteringObject_).TScatteringObject 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.Group\<TScatteringObject\>\(string, System\.Collections\.Generic\.IEnumerable\<TScatteringObject\>\)\.TScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of scattering objects to group together\.

#### Returns
[ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup')  
The newly created [ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup') if successful; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile)'></a>

## GeometricalPropagationModel\.Update\(IAngularPowerDistributionProfile\) Method

Performs an update operation by adding a cloned angular power distribution profile to the communication relation cluster\.

```csharp
public bool Update(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile? angularPowerDistributionProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [IAngularPowerDistributionProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAngularPowerDistributionProfile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile to be used for the update\. Can be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful and changes were made; otherwise, false\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IAntenna)'></a>

## GeometricalPropagationModel\.Update\(IAntenna\) Method

Performs an update operation and returns whether any changes were made\.

```csharp
public bool Update(DiGi.Communication.Interfaces.IAntenna? antenna);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The antenna to be updated in the propagation model\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the antenna was successfully added; otherwise, `false`\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile)'></a>

## GeometricalPropagationModel\.Update\(IMultipathPowerDelayProfile\) Method

Updates the propagation model using the specified multipath power delay profile\.

```csharp
public bool Update(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile? multipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile to be used for the update; can be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update was successful and changes were made; otherwise, `false`\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IScatteringObject)'></a>

## GeometricalPropagationModel\.Update\(IScatteringObject\) Method

Updates the propagation model by adding the specified scattering object to the communication relation cluster\.

```csharp
public bool Update(DiGi.Communication.Interfaces.IScatteringObject? scatteringObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IScatteringObject).scatteringObject'></a>

`scatteringObject` [IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')

The scattering object to be added\. If null, no update is performed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the scattering object was successfully added; otherwise, `false`\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IScatteringProfile)'></a>

## GeometricalPropagationModel\.Update\(IScatteringProfile\) Method

Performs an update operation and returns whether any changes were made\.

```csharp
public bool Update(DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to be used for the update\. Can be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update was successful; otherwise, `false`\.

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation'></a>

## MultipathPowerDelayProfileAntennasRelation Class

Represents a bidirectional one\-to\-many relationship between a multipath power delay profile and its associated antennas\.

```csharp
public class MultipathPowerDelayProfileAntennasRelation : DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<DiGi.Communication.Interfaces.IMultipathPowerDelayProfile, DiGi.Communication.Interfaces.IAntenna>, DiGi.Communication.Interfaces.ICommunicationRelation, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → MultipathPowerDelayProfileAntennasRelation

Implements [ICommunicationRelation](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationRelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation.MultipathPowerDelayProfileAntennasRelation(DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation)'></a>

## MultipathPowerDelayProfileAntennasRelation\(MultipathPowerDelayProfileAntennasRelation\) Constructor

Initializes a new instance of the [MultipathPowerDelayProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation 'DiGi\.Communication\.Classes\.MultipathPowerDelayProfileAntennasRelation') class using an existing instance\.

```csharp
public MultipathPowerDelayProfileAntennasRelation(DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation multipathPowerDelayProfileAntennasRelation);
```
#### Parameters

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation.MultipathPowerDelayProfileAntennasRelation(DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation).multipathPowerDelayProfileAntennasRelation'></a>

`multipathPowerDelayProfileAntennasRelation` [MultipathPowerDelayProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation 'DiGi\.Communication\.Classes\.MultipathPowerDelayProfileAntennasRelation')

The source relation instance to copy from\.

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation.MultipathPowerDelayProfileAntennasRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna)'></a>

## MultipathPowerDelayProfileAntennasRelation\(IMultipathPowerDelayProfile, IAntenna, IAntenna\) Constructor

Initializes a new instance of the [MultipathPowerDelayProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation 'DiGi\.Communication\.Classes\.MultipathPowerDelayProfileAntennasRelation') class\.

```csharp
public MultipathPowerDelayProfileAntennasRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile multipathPowerDelayProfile, DiGi.Communication.Interfaces.IAntenna antenna_1, DiGi.Communication.Interfaces.IAntenna antenna_2);
```
#### Parameters

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation.MultipathPowerDelayProfileAntennasRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile associated with this relation\.

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation.MultipathPowerDelayProfileAntennasRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna associated with this relation\.

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation.MultipathPowerDelayProfileAntennasRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The second antenna associated with this relation\.

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation.MultipathPowerDelayProfileAntennasRelation(System.Text.Json.Nodes.JsonObject)'></a>

## MultipathPowerDelayProfileAntennasRelation\(JsonObject\) Constructor

Initializes a new instance of the [MultipathPowerDelayProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation 'DiGi\.Communication\.Classes\.MultipathPowerDelayProfileAntennasRelation') class using the specified JSON object\.

```csharp
public MultipathPowerDelayProfileAntennasRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation.MultipathPowerDelayProfileAntennasRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to initialize the relation\.

<a name='DiGi.Communication.Classes.Ray'></a>

## Ray Class

Represents a geometric ray defined by an origin point and a direction vector, supporting serialization for communication purposes\.

```csharp
public class Ray : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Ray

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.Ray.Ray(DiGi.Communication.Classes.Ray)'></a>

## Ray\(Ray\) Constructor

Initializes a new instance of the [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray') class by copying an existing [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray') instance\.

```csharp
public Ray(DiGi.Communication.Classes.Ray? ray);
```
#### Parameters

<a name='DiGi.Communication.Classes.Ray.Ray(DiGi.Communication.Classes.Ray).ray'></a>

`ray` [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray')

The source [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray') instance to copy from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Communication.Classes.Ray.Ray(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Ray\(Point3D, Vector3D\) Constructor

Initializes a new instance of the [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray') class with the specified starting point and direction vector\.

```csharp
public Ray(DiGi.Geometry.Spatial.Classes.Point3D? point, DiGi.Geometry.Spatial.Classes.Vector3D? vector);
```
#### Parameters

<a name='DiGi.Communication.Classes.Ray.Ray(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).point'></a>

`point` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The starting point of the ray\.

<a name='DiGi.Communication.Classes.Ray.Ray(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D).vector'></a>

`vector` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The direction vector of the ray\.

<a name='DiGi.Communication.Classes.Ray.Ray(System.Text.Json.Nodes.JsonObject)'></a>

## Ray\(JsonObject\) Constructor

Initializes a new instance of the [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray') class using the specified JSON object\.

```csharp
public Ray(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.Ray.Ray(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the current [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray') instance\.
### Properties

<a name='DiGi.Communication.Classes.Ray.Point'></a>

## Ray\.Point Property

Gets the point in three\-dimensional space associated with this ray\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Point { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Classes.Ray.Vector'></a>

## Ray\.Vector Property

Gets the vector defining the segment\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Vector { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

<a name='DiGi.Communication.Classes.Scattering'></a>

## Scattering Class

Represents the scattering properties within a communication system,
containing information about signal delay and associated scattering point groups\.

```csharp
public class Scattering : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.IScattering, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Scattering

Implements [IScattering](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScattering 'DiGi\.Communication\.Interfaces\.IScattering'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.Scattering.Scattering(DiGi.Communication.Classes.Scattering)'></a>

## Scattering\(Scattering\) Constructor

Initializes a new instance of the [Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering') class by copying values from an existing [Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering') instance\.

```csharp
public Scattering(DiGi.Communication.Classes.Scattering? scattering);
```
#### Parameters

<a name='DiGi.Communication.Classes.Scattering.Scattering(DiGi.Communication.Classes.Scattering).scattering'></a>

`scattering` [Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering')

The source [Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering') object to copy data from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') to initialize a default instance\.

<a name='DiGi.Communication.Classes.Scattering.Scattering(double)'></a>

## Scattering\(double\) Constructor

Initializes a new instance of the [Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering') class with the specified delay\.

```csharp
public Scattering(double delay);
```
#### Parameters

<a name='DiGi.Communication.Classes.Scattering.Scattering(double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The delay value to be assigned to this scattering instance\.

<a name='DiGi.Communication.Classes.Scattering.Scattering(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.ScatteringPointGroup_)'></a>

## Scattering\(double, IEnumerable\<ScatteringPointGroup\>\) Constructor

Initializes a new instance of the [Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering') class\.

```csharp
public Scattering(double delay, System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.ScatteringPointGroup>? scatteringPointGroups);
```
#### Parameters

<a name='DiGi.Communication.Classes.Scattering.Scattering(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.ScatteringPointGroup_).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The delay value for the scattering\.

<a name='DiGi.Communication.Classes.Scattering.Scattering(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.ScatteringPointGroup_).scatteringPointGroups'></a>

`scatteringPointGroups` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of scattering point groups to be associated with this scattering instance\.

<a name='DiGi.Communication.Classes.Scattering.Scattering(System.Text.Json.Nodes.JsonObject)'></a>

## Scattering\(JsonObject\) Constructor

Initializes a new instance of the [Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering') class using the specified [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public Scattering(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.Scattering.Scattering(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the current instance\.
### Properties

<a name='DiGi.Communication.Classes.Scattering.Delay'></a>

## Scattering\.Delay Property

Gets the delay associated with the scattering process\.

```csharp
public double Delay { get; }
```

Implements [Delay](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScattering.Delay 'DiGi\.Communication\.Interfaces\.IScattering\.Delay')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.Scattering.ScatteringPointGroups'></a>

## Scattering\.ScatteringPointGroups Property

Gets the collection of scattering point groups, filtered to remove null entries and cloned for safety\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Classes.ScatteringPointGroup>? ScatteringPointGroups { get; }
```

Implements [ScatteringPointGroups](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScattering.ScatteringPointGroups 'DiGi\.Communication\.Interfaces\.IScattering\.ScatteringPointGroups')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.ScatteringGroup'></a>

## ScatteringGroup Class

Represents a group of scattering objects identified by a bounding box and a reference string\.

```csharp
public class ScatteringGroup : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.IScatteringGroup, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → ScatteringGroup

Implements [IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup'), [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(DiGi.Communication.Classes.ScatteringGroup)'></a>

## ScatteringGroup\(ScatteringGroup\) Constructor

Initializes a new instance of the [ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup') class by copying an existing scattering group\.

```csharp
public ScatteringGroup(DiGi.Communication.Classes.ScatteringGroup? scatteringGroup);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(DiGi.Communication.Classes.ScatteringGroup).scatteringGroup'></a>

`scatteringGroup` [ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup')

The source scattering group to copy from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') to create a default instance\.

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(string,DiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## ScatteringGroup\(string, BoundingBox3D\) Constructor

Initializes a new instance of the [ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup') class with the specified reference and bounding box, generating a new unique identifier\.

```csharp
public ScatteringGroup(string? reference, DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(string,DiGi.Geometry.Spatial.Classes.BoundingBox3D).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string for the scattering group\. If null or whitespace, the generated GUID string is used\.

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(string,DiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The 3D bounding box that encloses the scattering group\.

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(System.Guid,string,DiGi.Geometry.Spatial.Classes.BoundingBox3D)'></a>

## ScatteringGroup\(Guid, string, BoundingBox3D\) Constructor

Initializes a new instance of the [ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup') class with the specified unique identifier, reference, and bounding box\.

```csharp
public ScatteringGroup(System.Guid guid, string? reference, DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(System.Guid,string,DiGi.Geometry.Spatial.Classes.BoundingBox3D).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the scattering group\.

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(System.Guid,string,DiGi.Geometry.Spatial.Classes.BoundingBox3D).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string for the scattering group\. If null or whitespace, the GUID string is used\.

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(System.Guid,string,DiGi.Geometry.Spatial.Classes.BoundingBox3D).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The 3D bounding box that encloses the scattering group\.

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(System.Text.Json.Nodes.JsonObject)'></a>

## ScatteringGroup\(JsonObject\) Constructor

Initializes a new instance of the [ScatteringGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroup 'DiGi\.Communication\.Classes\.ScatteringGroup') class from a JSON object\.

```csharp
public ScatteringGroup(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringGroup.ScatteringGroup(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data for the scattering group\.
### Properties

<a name='DiGi.Communication.Classes.ScatteringGroup.BoundingBox3D'></a>

## ScatteringGroup\.BoundingBox3D Property

Gets the 3D bounding box that encloses the scattering group\.

```csharp
public DiGi.Geometry.Spatial.Classes.BoundingBox3D? BoundingBox3D { get; }
```

Implements [BoundingBox3D](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup.BoundingBox3D 'DiGi\.Communication\.Interfaces\.IScatteringGroup\.BoundingBox3D')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

<a name='DiGi.Communication.Classes.ScatteringGroup.Reference'></a>

## ScatteringGroup\.Reference Property

Gets the reference identifier of the scattering group\.

```csharp
public string? Reference { get; }
```

Implements [Reference](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup.Reference 'DiGi\.Communication\.Interfaces\.IScatteringGroup\.Reference')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation'></a>

## ScatteringGroupScatteringObjectsRelation Class

Represents a directional one\-to\-many relationship between a scattering group and its associated scattering objects\.

```csharp
public class ScatteringGroupScatteringObjectsRelation : DiGi.Core.Relation.Classes.OneToManyDirectionalRelation<DiGi.Communication.Interfaces.IScatteringGroup, DiGi.Communication.Interfaces.IScatteringObject>, DiGi.Communication.Interfaces.ICommunicationRelation, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2')[IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2')[IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2') → ScatteringGroupScatteringObjectsRelation

Implements [ICommunicationRelation](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationRelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation.ScatteringGroupScatteringObjectsRelation(DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation)'></a>

## ScatteringGroupScatteringObjectsRelation\(ScatteringGroupScatteringObjectsRelation\) Constructor

Initializes a new instance of the [ScatteringGroupScatteringObjectsRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation 'DiGi\.Communication\.Classes\.ScatteringGroupScatteringObjectsRelation') class by copying an existing relation\.

```csharp
public ScatteringGroupScatteringObjectsRelation(DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation? scatteringGroupScatteringObjectsRelation);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation.ScatteringGroupScatteringObjectsRelation(DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation).scatteringGroupScatteringObjectsRelation'></a>

`scatteringGroupScatteringObjectsRelation` [ScatteringGroupScatteringObjectsRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation 'DiGi\.Communication\.Classes\.ScatteringGroupScatteringObjectsRelation')

The source relation to copy from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') to create a default instance\.

<a name='DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation.ScatteringGroupScatteringObjectsRelation(DiGi.Communication.Interfaces.IScatteringGroup,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_)'></a>

## ScatteringGroupScatteringObjectsRelation\(IScatteringGroup, IEnumerable\<IScatteringObject\>\) Constructor

Initializes a new instance of the [ScatteringGroupScatteringObjectsRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation 'DiGi\.Communication\.Classes\.ScatteringGroupScatteringObjectsRelation') class\.

```csharp
public ScatteringGroupScatteringObjectsRelation(DiGi.Communication.Interfaces.IScatteringGroup? scatteringGroup, System.Collections.Generic.IEnumerable<DiGi.Communication.Interfaces.IScatteringObject> scatteringObjects);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation.ScatteringGroupScatteringObjectsRelation(DiGi.Communication.Interfaces.IScatteringGroup,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_).scatteringGroup'></a>

`scatteringGroup` [IScatteringGroup](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringGroup 'DiGi\.Communication\.Interfaces\.IScatteringGroup')

The scattering group to be associated in the relation\.

<a name='DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation.ScatteringGroupScatteringObjectsRelation(DiGi.Communication.Interfaces.IScatteringGroup,System.Collections.Generic.IEnumerable_DiGi.Communication.Interfaces.IScatteringObject_).scatteringObjects'></a>

`scatteringObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of scattering objects to be associated with the group\.

<a name='DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation.ScatteringGroupScatteringObjectsRelation(System.Text.Json.Nodes.JsonObject)'></a>

## ScatteringGroupScatteringObjectsRelation\(JsonObject\) Constructor

Initializes a new instance of the [ScatteringGroupScatteringObjectsRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation 'DiGi\.Communication\.Classes\.ScatteringGroupScatteringObjectsRelation') class from a JSON object\.

```csharp
public ScatteringGroupScatteringObjectsRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringGroupScatteringObjectsRelation.ScatteringGroupScatteringObjectsRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data for the relation\.

<a name='DiGi.Communication.Classes.ScatteringObject'></a>

## ScatteringObject Class

Represents an object that can be scattered within a scene, containing data such as the associated 3D mesh, a reference identifier, relative permittivity, and electrical conductivity\.

```csharp
public class ScatteringObject : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.IScatteringObject, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → ScatteringObject

Implements [IScatteringObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject 'DiGi\.Communication\.Interfaces\.IScatteringObject'), [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(DiGi.Communication.Classes.ScatteringObject)'></a>

## ScatteringObject\(ScatteringObject\) Constructor

Initializes a new instance of the [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject') class by copying the properties of another [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject')\.

```csharp
public ScatteringObject(DiGi.Communication.Classes.ScatteringObject? scatteringObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(DiGi.Communication.Classes.ScatteringObject).scatteringObject'></a>

`scatteringObject` [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject')

The source scattering object to copy from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') to initialize a new instance without existing data\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double)'></a>

## ScatteringObject\(string, Mesh3D, double, double\) Constructor

Initializes a new instance of the [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject') class\.

```csharp
public ScatteringObject(string? reference, DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, double relativePermittivity=1.0, double electricalConductivity=0.0);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the scattering object\. If null or whitespace, the unique identifier \(Guid\) is used instead\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The three\-dimensional mesh associated with the scattering object\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double).relativePermittivity'></a>

`relativePermittivity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The relative permittivity of the object\. Defaults to 1\.0\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double).electricalConductivity'></a>

`electricalConductivity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The electrical conductivity of the object\. Defaults to 0\.0\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double)'></a>

## ScatteringObject\(Guid, string, Mesh3D, double, double\) Constructor

Initializes a new instance of the [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject') class\.

```csharp
public ScatteringObject(System.Guid guid, string? reference, DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, double relativePermittivity=1.0, double electricalConductivity=0.0);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the scattering object\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional reference string; if null or whitespace, the GUID is used as the reference\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The three\-dimensional mesh associated with this scattering object\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double).relativePermittivity'></a>

`relativePermittivity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The relative permittivity of the object\. Defaults to 1\.0\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double,double).electricalConductivity'></a>

`electricalConductivity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The electrical conductivity of the object\. Defaults to 0\.0\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Text.Json.Nodes.JsonObject)'></a>

## ScatteringObject\(JsonObject\) Constructor

Initializes a new instance of the [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject') class using the specified JSON object\.

```csharp
public ScatteringObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') used to initialize the current instance\.
### Properties

<a name='DiGi.Communication.Classes.ScatteringObject.ElectricalConductivity'></a>

## ScatteringObject\.ElectricalConductivity Property

Gets the electrical conductivity of the object\. \[S/m\]

```csharp
public double ElectricalConductivity { get; }
```

Implements [ElectricalConductivity](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject.ElectricalConductivity 'DiGi\.Communication\.Interfaces\.IScatteringObject\.ElectricalConductivity')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.ScatteringObject.Mesh3D'></a>

## ScatteringObject\.Mesh3D Property

Gets a clone of the three\-dimensional mesh associated with this scattering object\.

```csharp
public DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D { get; }
```

Implements [Mesh3D](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject.Mesh3D 'DiGi\.Communication\.Interfaces\.IScatteringObject\.Mesh3D')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

<a name='DiGi.Communication.Classes.ScatteringObject.Reference'></a>

## ScatteringObject\.Reference Property

Gets the serializable reference object\.

```csharp
public string? Reference { get; }
```

Implements [Reference](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject.Reference 'DiGi\.Communication\.Interfaces\.IScatteringObject\.Reference')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.Classes.ScatteringObject.RelativePermittivity'></a>

## ScatteringObject\.RelativePermittivity Property

Gets the relative permittivity of the object\. \[\-\]

```csharp
public double RelativePermittivity { get; }
```

Implements [RelativePermittivity](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringObject.RelativePermittivity 'DiGi\.Communication\.Interfaces\.IScatteringObject\.RelativePermittivity')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.ScatteringPointGroup'></a>

## ScatteringPointGroup Class

Represents a group of scattering points, associating a unique reference identifier with a collection of 3D point coordinates for serialization and communication purposes\.

```csharp
public class ScatteringPointGroup : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ScatteringPointGroup

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.ScatteringPointGroup.ScatteringPointGroup(DiGi.Communication.Classes.ScatteringPointGroup)'></a>

## ScatteringPointGroup\(ScatteringPointGroup\) Constructor

Initializes a new instance of the [ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup') class by copying another instance\.

```csharp
public ScatteringPointGroup(DiGi.Communication.Classes.ScatteringPointGroup? scatteringPointGroup);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringPointGroup.ScatteringPointGroup(DiGi.Communication.Classes.ScatteringPointGroup).scatteringPointGroup'></a>

`scatteringPointGroup` [ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')

The source [ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup') object to copy from, or null to create an empty group\.

<a name='DiGi.Communication.Classes.ScatteringPointGroup.ScatteringPointGroup(string,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_)'></a>

## ScatteringPointGroup\(string, IEnumerable\<Point3D\>\) Constructor

Initializes a new instance of the [ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup') class\.

```csharp
public ScatteringPointGroup(string? reference, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Point3D>? points);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringPointGroup.ScatteringPointGroup(string,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the scattering point group\.

<a name='DiGi.Communication.Classes.ScatteringPointGroup.ScatteringPointGroup(string,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Point3D_).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of 3D points to be included in the group\.

<a name='DiGi.Communication.Classes.ScatteringPointGroup.ScatteringPointGroup(System.Text.Json.Nodes.JsonObject)'></a>

## ScatteringPointGroup\(JsonObject\) Constructor

Initializes a new instance of the [ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup') class using the specified JSON object\.

```csharp
public ScatteringPointGroup(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringPointGroup.ScatteringPointGroup(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the current instance\.
### Properties

<a name='DiGi.Communication.Classes.ScatteringPointGroup.Points'></a>

## ScatteringPointGroup\.Points Property

Gets the collection of points in three\-dimensional space associated with this scattering point group, filtered to remove null entries\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Point3D>? Points { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.ScatteringPointGroup.Reference'></a>

## ScatteringPointGroup\.Reference Property

Gets the serializable reference object\.

```csharp
public string? Reference { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.Classes.ScatteringProfile'></a>

## ScatteringProfile Class

Represents a scattering profile that defines the spatial characteristics and location data associated with a scattering process\.

```csharp
public class ScatteringProfile : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.IScatteringProfile, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → ScatteringProfile

Implements [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile'), [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(bool,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_)'></a>

## ScatteringProfile\(bool, Point3D, Point3D, IEnumerable\<Scattering\>\) Constructor

Initializes a new instance of the [ScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfile 'DiGi\.Communication\.Classes\.ScatteringProfile') class\.

```csharp
public ScatteringProfile(bool visible, DiGi.Geometry.Spatial.Classes.Point3D? location_1, DiGi.Geometry.Spatial.Classes.Point3D? location_2, System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.Scattering>? scatterings);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(bool,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_).visible'></a>

`visible` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the scattering profile is visible\.

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(bool,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_).location_1'></a>

`location_1` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first point in three\-dimensional space defining the location\.

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(bool,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_).location_2'></a>

`location_2` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second point in three\-dimensional space defining the location\.

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(bool,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_).scatterings'></a>

`scatterings` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of scattering elements associated with this profile\.

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(DiGi.Communication.Classes.ScatteringProfile)'></a>

## ScatteringProfile\(ScatteringProfile\) Constructor

Initializes a new instance of the [ScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfile 'DiGi\.Communication\.Classes\.ScatteringProfile') class by copying another [ScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfile 'DiGi\.Communication\.Classes\.ScatteringProfile') instance\.

```csharp
public ScatteringProfile(DiGi.Communication.Classes.ScatteringProfile? scatteringProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(DiGi.Communication.Classes.ScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [ScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfile 'DiGi\.Communication\.Classes\.ScatteringProfile')

The source scattering profile to copy from, or `null` to initialize a new empty profile\.

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_)'></a>

## ScatteringProfile\(Guid, Point3D, Point3D, bool, IEnumerable\<Scattering\>\) Constructor

Initializes a new instance of the [ScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfile 'DiGi\.Communication\.Classes\.ScatteringProfile') class\.

```csharp
public ScatteringProfile(System.Guid guid, DiGi.Geometry.Spatial.Classes.Point3D? location_1, DiGi.Geometry.Spatial.Classes.Point3D? location_2, bool visible, System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.Scattering>? scatterings);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the scattering profile\.

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_).location_1'></a>

`location_1` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The first point in three\-dimensional space defining the location\.

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_).location_2'></a>

`location_2` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The second point in three\-dimensional space defining the location\.

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_).visible'></a>

`visible` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the scattering profile is visible\.

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(System.Guid,DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Point3D,bool,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.Scattering_).scatterings'></a>

`scatterings` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of scatterings associated with this profile\.

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(System.Text.Json.Nodes.JsonObject)'></a>

## ScatteringProfile\(JsonObject\) Constructor

Initializes a new instance of the [ScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfile 'DiGi\.Communication\.Classes\.ScatteringProfile') class using the specified JSON object\.

```csharp
public ScatteringProfile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringProfile.ScatteringProfile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the profile\.
### Properties

<a name='DiGi.Communication.Classes.ScatteringProfile.Location_1'></a>

## ScatteringProfile\.Location\_1 Property

Gets the first location point in three\-dimensional space associated with the scattering profile\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Location_1 { get; }
```

Implements [Location\_1](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile.Location_1 'DiGi\.Communication\.Interfaces\.IScatteringProfile\.Location\_1')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Classes.ScatteringProfile.Location_2'></a>

## ScatteringProfile\.Location\_2 Property

Gets the second location associated with the scattering profile\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Location_2 { get; }
```

Implements [Location\_2](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile.Location_2 'DiGi\.Communication\.Interfaces\.IScatteringProfile\.Location\_2')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Classes.ScatteringProfile.Scatterings'></a>

## ScatteringProfile\.Scatterings Property

Gets the collection of scattering entries associated with this profile\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.Scattering>? Scatterings { get; private set; }
```

Implements [Scatterings](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile.Scatterings 'DiGi\.Communication\.Interfaces\.IScatteringProfile\.Scatterings')

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Communication.Classes.ScatteringProfile.Visible'></a>

## ScatteringProfile\.Visible Property

Gets a value indicating whether the scattering profile is visible\.

```csharp
public bool Visible { get; }
```

Implements [Visible](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile.Visible 'DiGi\.Communication\.Interfaces\.IScatteringProfile\.Visible')

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation'></a>

## ScatteringProfileAntennasRelation Class

Represents a directional one\-to\-many relationship between a scattering profile and its associated antennas\.

```csharp
public class ScatteringProfileAntennasRelation : DiGi.Core.Relation.Classes.OneToManyDirectionalRelation<DiGi.Communication.Interfaces.IScatteringProfile, DiGi.Communication.Interfaces.IAntenna>, DiGi.Communication.Interfaces.ICommunicationRelation, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2')[IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2')[IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2') → ScatteringProfileAntennasRelation

Implements [ICommunicationRelation](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationRelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation.ScatteringProfileAntennasRelation(DiGi.Communication.Classes.ScatteringProfileAntennasRelation)'></a>

## ScatteringProfileAntennasRelation\(ScatteringProfileAntennasRelation\) Constructor

Initializes a new instance of the [ScatteringProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileAntennasRelation 'DiGi\.Communication\.Classes\.ScatteringProfileAntennasRelation') class\.

```csharp
public ScatteringProfileAntennasRelation(DiGi.Communication.Classes.ScatteringProfileAntennasRelation? scatteringProfileAntennasRelation);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation.ScatteringProfileAntennasRelation(DiGi.Communication.Classes.ScatteringProfileAntennasRelation).scatteringProfileAntennasRelation'></a>

`scatteringProfileAntennasRelation` [ScatteringProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileAntennasRelation 'DiGi\.Communication\.Classes\.ScatteringProfileAntennasRelation')

The existing relation to copy from, or null to create a new one\.

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation.ScatteringProfileAntennasRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna)'></a>

## ScatteringProfileAntennasRelation\(IScatteringProfile, IAntenna, IAntenna\) Constructor

Initializes a new instance of the [ScatteringProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileAntennasRelation 'DiGi\.Communication\.Classes\.ScatteringProfileAntennasRelation') class\.

```csharp
public ScatteringProfileAntennasRelation(DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile, DiGi.Communication.Interfaces.IAntenna? antenna_1, DiGi.Communication.Interfaces.IAntenna? antenna_2);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation.ScatteringProfileAntennasRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).scatteringProfile'></a>

`scatteringProfile` [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile associated with this relation\.

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation.ScatteringProfileAntennasRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna to be associated with the scattering profile\.

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation.ScatteringProfileAntennasRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [IAntenna](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IAntenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The second antenna to be associated with the scattering profile\.

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation.ScatteringProfileAntennasRelation(System.Text.Json.Nodes.JsonObject)'></a>

## ScatteringProfileAntennasRelation\(JsonObject\) Constructor

Initializes a new instance of the [ScatteringProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileAntennasRelation 'DiGi\.Communication\.Classes\.ScatteringProfileAntennasRelation') class using the specified JSON object\.

```csharp
public ScatteringProfileAntennasRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation.ScatteringProfileAntennasRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the relation, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation'></a>

## ScatteringProfileMultipathPowerDelayProfileRelation Class

Represents a one\-to\-one bidirectional relationship between a scattering profile and a multipath power delay profile\.

```csharp
public class ScatteringProfileMultipathPowerDelayProfileRelation : DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation<DiGi.Communication.Interfaces.IScatteringProfile, DiGi.Communication.Interfaces.IMultipathPowerDelayProfile>, DiGi.Communication.Interfaces.ICommunicationRelation, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2') → ScatteringProfileMultipathPowerDelayProfileRelation

Implements [ICommunicationRelation](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationRelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation.ScatteringProfileMultipathPowerDelayProfileRelation(DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation)'></a>

## ScatteringProfileMultipathPowerDelayProfileRelation\(ScatteringProfileMultipathPowerDelayProfileRelation\) Constructor

Initializes a new instance of the [ScatteringProfileMultipathPowerDelayProfileRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation 'DiGi\.Communication\.Classes\.ScatteringProfileMultipathPowerDelayProfileRelation') class using an existing relation instance\.

```csharp
public ScatteringProfileMultipathPowerDelayProfileRelation(DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation scatteringProfileMultipathPowerDelayProfileRelation);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation.ScatteringProfileMultipathPowerDelayProfileRelation(DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation).scatteringProfileMultipathPowerDelayProfileRelation'></a>

`scatteringProfileMultipathPowerDelayProfileRelation` [ScatteringProfileMultipathPowerDelayProfileRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation 'DiGi\.Communication\.Classes\.ScatteringProfileMultipathPowerDelayProfileRelation')

The existing [ScatteringProfileMultipathPowerDelayProfileRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation 'DiGi\.Communication\.Classes\.ScatteringProfileMultipathPowerDelayProfileRelation') instance to copy from\.

<a name='DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation.ScatteringProfileMultipathPowerDelayProfileRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile)'></a>

## ScatteringProfileMultipathPowerDelayProfileRelation\(IScatteringProfile, IMultipathPowerDelayProfile\) Constructor

Initializes a new instance of the [ScatteringProfileMultipathPowerDelayProfileRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation 'DiGi\.Communication\.Classes\.ScatteringProfileMultipathPowerDelayProfileRelation') class\.

```csharp
public ScatteringProfileMultipathPowerDelayProfileRelation(DiGi.Communication.Interfaces.IScatteringProfile scatteringProfile, DiGi.Communication.Interfaces.IMultipathPowerDelayProfile multipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation.ScatteringProfileMultipathPowerDelayProfileRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).scatteringProfile'></a>

`scatteringProfile` [IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to be associated in the relation\.

<a name='DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation.ScatteringProfileMultipathPowerDelayProfileRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile to be associated in the relation\.

<a name='DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation.ScatteringProfileMultipathPowerDelayProfileRelation(System.Text.Json.Nodes.JsonObject)'></a>

## ScatteringProfileMultipathPowerDelayProfileRelation\(JsonObject\) Constructor

Initializes a new instance of the [ScatteringProfileMultipathPowerDelayProfileRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation 'DiGi\.Communication\.Classes\.ScatteringProfileMultipathPowerDelayProfileRelation') class using the specified JSON object\.

```csharp
public ScatteringProfileMultipathPowerDelayProfileRelation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation.ScatteringProfileMultipathPowerDelayProfileRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the relation\.

<a name='DiGi.Communication.Classes.ScatteringSolver'></a>

## ScatteringSolver Class

Provides functionality to solve scattering calculations within a communication system,
integrating geometrical propagation models and various scattering profiles on the CPU\.

```csharp
public class ScatteringSolver : DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ScatteringSolver

Implements [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISolver](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver 'DiGi\.Core\.Interfaces\.ISolver'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Properties

<a name='DiGi.Communication.Classes.ScatteringSolver.GeometricalPropagationModel'></a>

## ScatteringSolver\.GeometricalPropagationModel Property

Gets or sets the geometrical propagation model used by the scattering solver\.

```csharp
public DiGi.Communication.Classes.GeometricalPropagationModel? GeometricalPropagationModel { get; set; }
```

#### Property Value
[GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

<a name='DiGi.Communication.Classes.ScatteringSolver.ScatteringProfiles'></a>

## ScatteringSolver\.ScatteringProfiles Property

Gets a cloned list of scattering profiles, filtering out any null entries\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Interfaces.IScatteringProfile>? ScatteringProfiles { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IScatteringProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IScatteringProfile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.ScatteringSolver.ScatteringSolverOptions'></a>

## ScatteringSolver\.ScatteringSolverOptions Property

Gets or sets the configuration options for the scattering solver\.

```csharp
public DiGi.Communication.Classes.ScatteringSolverOptions? ScatteringSolverOptions { get; set; }
```

#### Property Value
[ScatteringSolverOptions](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringSolverOptions 'DiGi\.Communication\.Classes\.ScatteringSolverOptions')
### Methods

<a name='DiGi.Communication.Classes.ScatteringSolver.Solve()'></a>

## ScatteringSolver\.Solve\(\) Method

Executes the solving operation on the CPU\.

```csharp
public bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the solver successfully executed; otherwise, `false`\.

<a name='DiGi.Communication.Classes.ScatteringSolverOptions'></a>

## ScatteringSolverOptions Class

Provides configuration options and parameters for the scattering solver,
including factors for angle calculation and point density\.

```csharp
public class ScatteringSolverOptions : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ScatteringSolverOptions

Implements [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ioptions 'DiGi\.Core\.Interfaces\.IOptions')
### Constructors

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.ScatteringSolverOptions()'></a>

## ScatteringSolverOptions\(\) Constructor

Initializes a new instance of the [ScatteringSolverOptions](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringSolverOptions 'DiGi\.Communication\.Classes\.ScatteringSolverOptions') class\.

```csharp
public ScatteringSolverOptions();
```

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.ScatteringSolverOptions(DiGi.Communication.Classes.ScatteringSolverOptions)'></a>

## ScatteringSolverOptions\(ScatteringSolverOptions\) Constructor

Initializes a new instance of the [ScatteringSolverOptions](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringSolverOptions 'DiGi\.Communication\.Classes\.ScatteringSolverOptions') class by copying from another instance\.

```csharp
public ScatteringSolverOptions(DiGi.Communication.Classes.ScatteringSolverOptions? other);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.ScatteringSolverOptions(DiGi.Communication.Classes.ScatteringSolverOptions).other'></a>

`other` [ScatteringSolverOptions](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringSolverOptions 'DiGi\.Communication\.Classes\.ScatteringSolverOptions')

The source options to copy from\.

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.ScatteringSolverOptions(double,double,double)'></a>

## ScatteringSolverOptions\(double, double, double\) Constructor

Initializes a new instance of the [ScatteringSolverOptions](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringSolverOptions 'DiGi\.Communication\.Classes\.ScatteringSolverOptions') class\.

```csharp
public ScatteringSolverOptions(double angleFactor, double pointDensityFactor, double tolerance);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.ScatteringSolverOptions(double,double,double).angleFactor'></a>

`angleFactor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The angle factor used by the scattering solver for angular calculations\.

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.ScatteringSolverOptions(double,double,double).pointDensityFactor'></a>

`pointDensityFactor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The factor used to determine the point density for the scattering solver\.

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.ScatteringSolverOptions(double,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for distance and geometric comparisons\.

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.ScatteringSolverOptions(System.Text.Json.Nodes.JsonObject)'></a>

## ScatteringSolverOptions\(JsonObject\) Constructor

Initializes a new instance of the [ScatteringSolverOptions](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringSolverOptions 'DiGi\.Communication\.Classes\.ScatteringSolverOptions') class from JSON\.

```csharp
public ScatteringSolverOptions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.ScatteringSolverOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data to deserialize\.
### Properties

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.AngleFactor'></a>

## ScatteringSolverOptions\.AngleFactor Property

Gets the angle factor used by the scattering solver for angular calculations\.

```csharp
public double AngleFactor { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.PointDensityFactor'></a>

## ScatteringSolverOptions\.PointDensityFactor Property

Gets the factor used to determine the point density for the scattering solver\.

```csharp
public double PointDensityFactor { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.ScatteringSolverOptions.Tolerance'></a>

## ScatteringSolverOptions\.Tolerance Property

Gets the tolerance value used for distance and geometric comparisons within the scattering solver\.

```csharp
public double Tolerance { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile'></a>

## SimpleMultipathPowerDelayProfile Class

Represents a simple multipath power delay profile that maps specific time delays to their corresponding power levels\.

```csharp
public class SimpleMultipathPowerDelayProfile : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile, DiGi.Communication.Interfaces.IMultipathPowerDelayProfile, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → SimpleMultipathPowerDelayProfile

Implements [ISimpleMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile'), [IMultipathPowerDelayProfile](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.IMultipathPowerDelayProfile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile'), [ICommunicationGuidObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationGuidObject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [ICommunicationSerializableObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationSerializableObject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [ICommunicationObject](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ICommunicationObject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
### Constructors

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.SimpleMultipathPowerDelayProfile(DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile)'></a>

## SimpleMultipathPowerDelayProfile\(SimpleMultipathPowerDelayProfile\) Constructor

Initializes a new instance of the [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile') class using an existing [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile') object\.

```csharp
public SimpleMultipathPowerDelayProfile(DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile? simpleMultipathPowerDelayProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.SimpleMultipathPowerDelayProfile(DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile).simpleMultipathPowerDelayProfile'></a>

`simpleMultipathPowerDelayProfile` [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile')

The source [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile') object to copy data from\.

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.SimpleMultipathPowerDelayProfile(System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_double,double__)'></a>

## SimpleMultipathPowerDelayProfile\(IEnumerable\<KeyValuePair\<double,double\>\>\) Constructor

Initializes a new instance of the [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile') class\.

```csharp
public SimpleMultipathPowerDelayProfile(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<double,double>>? values);
```
#### Parameters

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.SimpleMultipathPowerDelayProfile(System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_double,double__).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Collections\.Generic\.KeyValuePair&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The data matrix for interpolation, in \[y, x\] format\.

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.SimpleMultipathPowerDelayProfile(System.Guid,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_double,double__)'></a>

## SimpleMultipathPowerDelayProfile\(Guid, IEnumerable\<KeyValuePair\<double,double\>\>\) Constructor

Initializes a new instance of the [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile') class\.

```csharp
public SimpleMultipathPowerDelayProfile(System.Guid guid, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<double,double>>? values);
```
#### Parameters

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.SimpleMultipathPowerDelayProfile(System.Guid,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_double,double__).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier\.

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.SimpleMultipathPowerDelayProfile(System.Guid,System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_double,double__).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Collections\.Generic\.KeyValuePair&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The data matrix for interpolation, in \[y, x\] format\.

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.SimpleMultipathPowerDelayProfile(System.Text.Json.Nodes.JsonObject)'></a>

## SimpleMultipathPowerDelayProfile\(JsonObject\) Constructor

Initializes a new instance of the [SimpleMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.SimpleMultipathPowerDelayProfile') class using the specified JSON object\.

```csharp
public SimpleMultipathPowerDelayProfile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.SimpleMultipathPowerDelayProfile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the current instance\.
### Properties

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.Delays'></a>

## SimpleMultipathPowerDelayProfile\.Delays Property

Delays \[s\]

```csharp
public System.Collections.Generic.HashSet<double>? Delays { get; }
```

Implements [Delays](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile.Delays 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile\.Delays')

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')
### Methods

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.GetPower(double)'></a>

## SimpleMultipathPowerDelayProfile\.GetPower\(double\) Method

Gets the power value associated with the specified delay\.

```csharp
public double GetPower(double delay);
```
#### Parameters

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile.GetPower(double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The delay for which to retrieve the power\.

Implements [GetPower\(double\)](DiGi.Communication.Interfaces.md#DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile.GetPower(double) 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile\.GetPower\(double\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The power value corresponding to the given delay, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the values are not initialized or the delay is not found\.