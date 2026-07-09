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

Implements [DiGi\.Communication\.Interfaces\.IAngularPowerDistribution](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution'), [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
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

Implements [Delay](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution.delay 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution\.Delay')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.AngularPowerDistribution.Vectors'></a>

## AngularPowerDistribution\.Vectors Property

Gets the collection of three\-dimensional vectors associated with the angular power distribution, filtered to remove null entries\.

```csharp
public System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.Vector3D>? Vectors { get; }
```

Implements [Vectors](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution.vectors 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution\.Vectors')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Communication.Classes.AngularPowerDistribution.GetPower()'></a>

## AngularPowerDistribution\.GetPower\(\) Method

Calculates the total power by summing the lengths of all stored vectors\.

```csharp
public double GetPower();
```

Implements [GetPower\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistribution.getpower 'DiGi\.Communication\.Interfaces\.IAngularPowerDistribution\.GetPower')

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

Implements [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile'), [DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
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

Implements [AngularPowerDistributions](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile.angularpowerdistributions 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile\.AngularPowerDistributions')

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[AngularPowerDistribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.AngularPowerDistribution 'DiGi\.Communication\.Classes\.AngularPowerDistribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfile.Location'></a>

## AngularPowerDistributionProfile\.Location Property

Gets the location of the angular power distribution profile in three\-dimensional space\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Location { get; }
```

Implements [Location](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile.location 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile\.Location')

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

Implements [GetRays\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile.getrays#digi-communication-interfaces-iangularpowerdistributionprofile-getrays(system-double) 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile\.GetRays\(System\.Double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Ray](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Ray 'DiGi\.Communication\.Classes\.Ray') objects if the distribution is found for the given delay; otherwise, `null`\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation'></a>

## AngularPowerDistributionProfileAntennaRelation Class

Represents a one\-to\-one directional relationship between an angular power distribution profile and an antenna\.

```csharp
public class AngularPowerDistributionProfileAntennaRelation : DiGi.Core.Relation.Classes.OneToOneDirectionalRelation<DiGi.Communication.Interfaces.IAngularPowerDistributionProfile, DiGi.Communication.Interfaces.IAntenna>, DiGi.Communication.Interfaces.ICommunicationRelation, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonedirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\`2') → AngularPowerDistributionProfileAntennaRelation

Implements [DiGi\.Communication\.Interfaces\.ICommunicationRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationrelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
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

`angularPowerDistributionProfile` [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile to be associated\.

<a name='DiGi.Communication.Classes.AngularPowerDistributionProfileAntennaRelation.AngularPowerDistributionProfileAntennaRelation(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

Implements [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISolver](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver 'DiGi\.Core\.Interfaces\.ISolver'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Properties

<a name='DiGi.Communication.Classes.AngularPowerDistributionSolver.AngularPowerDistributionProfiles'></a>

## AngularPowerDistributionSolver\.AngularPowerDistributionProfiles Property

Gets the list of angular power distribution profiles, filtered to remove null entries and cloned to ensure data integrity\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Interfaces.IAngularPowerDistributionProfile>? AngularPowerDistributionProfiles { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

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

Implements [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ioptions 'DiGi\.Core\.Interfaces\.IOptions')
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

Implements [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna'), [DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
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

Implements [Functions](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna.functions 'DiGi\.Communication\.Interfaces\.IAntenna\.Functions')

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[Function](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Function 'DiGi\.Communication\.Enums\.Function')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing the antenna's functions, or `null` if none are defined\.

<a name='DiGi.Communication.Classes.Antenna.Location'></a>

## Antenna\.Location Property

Gets the three\-dimensional location of the antenna\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Location { get; }
```

Implements [Location](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna.location 'DiGi\.Communication\.Interfaces\.IAntenna\.Location')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Classes.ArrivalRay'></a>

## ArrivalRay Class

Ray arriving at the receiving antenna: an arrival direction \(theta, phi\) with its assigned corrected power p\_nkl\.

```csharp
public class ArrivalRay : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ArrivalRay

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.ArrivalRay.ArrivalRay(DiGi.Communication.Classes.ArrivalRay)'></a>

## ArrivalRay\(ArrivalRay\) Constructor

Initializes a new instance of the [ArrivalRay](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ArrivalRay 'DiGi\.Communication\.Classes\.ArrivalRay') class by copying another ray\.

```csharp
public ArrivalRay(DiGi.Communication.Classes.ArrivalRay? arrivalRay);
```
#### Parameters

<a name='DiGi.Communication.Classes.ArrivalRay.ArrivalRay(DiGi.Communication.Classes.ArrivalRay).arrivalRay'></a>

`arrivalRay` [ArrivalRay](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ArrivalRay 'DiGi\.Communication\.Classes\.ArrivalRay')

The source ray to copy from\.

<a name='DiGi.Communication.Classes.ArrivalRay.ArrivalRay(double,double,double)'></a>

## ArrivalRay\(double, double, double\) Constructor

Initializes a new instance of the [ArrivalRay](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ArrivalRay 'DiGi\.Communication\.Classes\.ArrivalRay') class\.

```csharp
public ArrivalRay(double theta, double phi, double power);
```
#### Parameters

<a name='DiGi.Communication.Classes.ArrivalRay.ArrivalRay(double,double,double).theta'></a>

`theta` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Polar angle theta\_kl \[rad\] of the arrival direction, measured from the OZ axis at the receiver\.

<a name='DiGi.Communication.Classes.ArrivalRay.ArrivalRay(double,double,double).phi'></a>

`phi` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Azimuth angle phi\_kl \[rad\] of the arrival direction, measured in the XOY plane from the OX axis at the receiver\.

<a name='DiGi.Communication.Classes.ArrivalRay.ArrivalRay(double,double,double).power'></a>

`power` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Corrected normalized power p\_nkl assigned to the ray \[\-\]\.

<a name='DiGi.Communication.Classes.ArrivalRay.ArrivalRay(System.Text.Json.Nodes.JsonObject)'></a>

## ArrivalRay\(JsonObject\) Constructor

Initializes a new instance of the [ArrivalRay](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ArrivalRay 'DiGi\.Communication\.Classes\.ArrivalRay') class from a JsonObject\.

```csharp
public ArrivalRay(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.ArrivalRay.ArrivalRay(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Classes.ArrivalRay.phi'></a>

## ArrivalRay\.phi Field

Azimuth angle phi\_kl \[rad\] of the arrival direction, measured in the XOY plane from the OX axis at the receiver\.

```csharp
private readonly double phi;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.ArrivalRay.power'></a>

## ArrivalRay\.power Field

Corrected normalized power p\_nkl assigned to the ray \[\-\]\.

```csharp
private readonly double power;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.ArrivalRay.theta'></a>

## ArrivalRay\.theta Field

Polar angle theta\_kl \[rad\] of the arrival direction, measured from the OZ axis at the receiver\.

```csharp
private readonly double theta;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Properties

<a name='DiGi.Communication.Classes.ArrivalRay.Phi'></a>

## ArrivalRay\.Phi Property

Azimuth angle phi\_kl \[rad\] of the arrival direction, measured in the XOY plane from the OX axis at the receiver\.

```csharp
public double Phi { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.ArrivalRay.Power'></a>

## ArrivalRay\.Power Property

Corrected normalized power p\_nkl assigned to the ray \[\-\]\.

```csharp
public double Power { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.ArrivalRay.Theta'></a>

## ArrivalRay\.Theta Property

Polar angle theta\_kl \[rad\] of the arrival direction, measured from the OZ axis at the receiver\.

```csharp
public double Theta { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.CommunicationRelationCluster'></a>

## CommunicationRelationCluster Class

Represents a cluster of communication relations, providing functionality to manage unique relationships between communication GUID objects and communication relations while supporting serialization\.

```csharp
public class CommunicationRelationCluster : DiGi.Core.Relation.Classes.UniqueObjectRelationCluster<DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationRelation>, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3') → [DiGi\.Core\.Classes\.ValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3') → [DiGi\.Core\.Classes\.SerializableObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3') → [DiGi\.Core\.Classes\.UniqueObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1')[DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1') → [DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2')[DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2')[DiGi\.Communication\.Interfaces\.ICommunicationRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationrelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.uniqueobjectrelationcluster-2 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\`2') → CommunicationRelationCluster

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
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

`angularPowerDistributionProfile` [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile to associate\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

`multipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile to be associated\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna involved in the relation\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The second antenna involved in the relation\.

#### Returns
[MultipathPowerDelayProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation 'DiGi\.Communication\.Classes\.MultipathPowerDelayProfileAntennasRelation')  
The created [MultipathPowerDelayProfileAntennasRelation](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation 'DiGi\.Communication\.Classes\.MultipathPowerDelayProfileAntennasRelation') if successful; otherwise, `null`\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna)'></a>

## CommunicationRelationCluster\.AddRelation\(IScatteringProfile, IAntenna, IAntenna\) Method

Adds a relation between a scattering profile and two antennas\.

```csharp
public DiGi.Communication.Classes.ScatteringProfileAntennasRelation? AddRelation(DiGi.Communication.Interfaces.IScatteringProfile? scatteringProfile, DiGi.Communication.Interfaces.IAntenna? antenna_1, DiGi.Communication.Interfaces.IAntenna? antenna_2);
```
#### Parameters

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).scatteringProfile'></a>

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to associate with the antennas\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna involved in the relation\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to associate\.

<a name='DiGi.Communication.Classes.CommunicationRelationCluster.AddRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

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

Implements [DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icomplexmultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile'), [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile'), [DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
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

`simpleMultipathPowerDelayProfile_Visible` [DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

The visible simple multipath power delay profile to be cloned and assigned\.

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile).simpleMultipathPowerDelayProfile_Hidden'></a>

`simpleMultipathPowerDelayProfile_Hidden` [DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

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

`simpleMultipathPowerDelayProfile_Visible` [DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

The visible simple multipath power delay profile\.

<a name='DiGi.Communication.Classes.ComplexMultipathPowerDelayProfile.ComplexMultipathPowerDelayProfile(System.Guid,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile,DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile).simpleMultipathPowerDelayProfile_Hidden'></a>

`simpleMultipathPowerDelayProfile_Hidden` [DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')

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

Implements [GetSimpleMultipathPowerDelay\(bool\)](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icomplexmultipathpowerdelayprofile.getsimplemultipathpowerdelay#digi-communication-interfaces-icomplexmultipathpowerdelayprofile-getsimplemultipathpowerdelay(system-boolean) 'DiGi\.Communication\.Interfaces\.IComplexMultipathPowerDelayProfile\.GetSimpleMultipathPowerDelay\(System\.Boolean\)')

#### Returns
[DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile')  
The cloned [DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile') corresponding to the requested visibility, or `null` if it does not exist\.

<a name='DiGi.Communication.Classes.EllipsoidComponent'></a>

## EllipsoidComponent Class

Power component P\_n of a single propagation ellipsoid related to the delay tau\_n of the Power Delay Profile\.

```csharp
public class EllipsoidComponent : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → EllipsoidComponent

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(DiGi.Communication.Classes.EllipsoidComponent)'></a>

## EllipsoidComponent\(EllipsoidComponent\) Constructor

Initializes a new instance of the [EllipsoidComponent](DiGi.Communication.Classes.md#DiGi.Communication.Classes.EllipsoidComponent 'DiGi\.Communication\.Classes\.EllipsoidComponent') class by copying another ellipsoid component\.

```csharp
public EllipsoidComponent(DiGi.Communication.Classes.EllipsoidComponent? ellipsoidComponent);
```
#### Parameters

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(DiGi.Communication.Classes.EllipsoidComponent).ellipsoidComponent'></a>

`ellipsoidComponent` [EllipsoidComponent](DiGi.Communication.Classes.md#DiGi.Communication.Classes.EllipsoidComponent 'DiGi\.Communication\.Classes\.EllipsoidComponent')

The source ellipsoid component to copy from\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double)'></a>

## EllipsoidComponent\(double, double, double, double, double, double, IEnumerable\<RayContribution\>, double, Complex, double, double\) Constructor

Initializes a new instance of the [EllipsoidComponent](DiGi.Communication.Classes.md#DiGi.Communication.Classes.EllipsoidComponent 'DiGi\.Communication\.Classes\.EllipsoidComponent') class\.

```csharp
public EllipsoidComponent(double delay, double fractionalPower, double mappingErrorCorrectionCoefficient, double measuredFractionalPower, double power, double powerEquivalenceCoefficient, System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.RayContribution>? rayContributions, double referencePower, System.Numerics.Complex reflectionCoefficientSum, double semiMajorAxis, double semiMinorAxis);
```
#### Parameters

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Delay tau\_n \[s\] related to the ellipsoid\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).fractionalPower'></a>

`fractionalPower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Normalized power p\_n = P\_n / P resulting from the model \[\-\]\. Calculated in Stage II\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).mappingErrorCorrectionCoefficient'></a>

`mappingErrorCorrectionCoefficient` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Correction coefficient w\_0n = p'\_n / p\_n for ray scattering object mapping errors \[\-\]\. Calculated in Stage II\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).measuredFractionalPower'></a>

`measuredFractionalPower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Normalized \(fractional\) power p'\_n retrieved directly from the measured Power Delay Profile \[\-\]\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).power'></a>

`power` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Component power P\_n = \|Gamma\_n\|^2 \[\-\]\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).powerEquivalenceCoefficient'></a>

`powerEquivalenceCoefficient` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Power equivalence coefficient w\_Pn = P\_n / P'\_n \[\-\]\. Calculated in Stage II\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).rayContributions'></a>

`rayContributions` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[RayContribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.RayContribution 'DiGi\.Communication\.Classes\.RayContribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Contributions of the mesh cells assigned to the ellipsoid\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).referencePower'></a>

`referencePower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Reference power P'\_n: sum of squared moduli of the weighted reflection coefficients \[\-\]\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).reflectionCoefficientSum'></a>

`reflectionCoefficientSum` [System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

Sum Gamma\_n of the weighted complex reflection coefficients of the whole ellipsoid \[\-\]\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).semiMajorAxis'></a>

`semiMajorAxis` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Semi\-major axis a\_n of the ellipsoid \[m\]\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(double,double,double,double,double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.RayContribution_,double,System.Numerics.Complex,double,double).semiMinorAxis'></a>

`semiMinorAxis` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Semi\-minor axes b\_n = c\_n of the ellipsoid \[m\]\.

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(System.Text.Json.Nodes.JsonObject)'></a>

## EllipsoidComponent\(JsonObject\) Constructor

Initializes a new instance of the [EllipsoidComponent](DiGi.Communication.Classes.md#DiGi.Communication.Classes.EllipsoidComponent 'DiGi\.Communication\.Classes\.EllipsoidComponent') class from a JsonObject\.

```csharp
public EllipsoidComponent(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.EllipsoidComponent.EllipsoidComponent(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Classes.EllipsoidComponent.delay'></a>

## EllipsoidComponent\.delay Field

Delay tau\_n \[s\] related to the ellipsoid\.

```csharp
private readonly double delay;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.fractionalPower'></a>

## EllipsoidComponent\.fractionalPower Field

Normalized power p\_n = P\_n / P resulting from the model \[\-\]\. Calculated in Stage II\.

```csharp
private readonly double fractionalPower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.mappingErrorCorrectionCoefficient'></a>

## EllipsoidComponent\.mappingErrorCorrectionCoefficient Field

Correction coefficient w\_0n = p'\_n / p\_n for ray scattering object mapping errors \[\-\]\. Calculated in Stage II\.

```csharp
private readonly double mappingErrorCorrectionCoefficient;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.measuredFractionalPower'></a>

## EllipsoidComponent\.measuredFractionalPower Field

Normalized \(fractional\) power p'\_n retrieved directly from the measured Power Delay Profile \[\-\]\.

```csharp
private readonly double measuredFractionalPower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.power'></a>

## EllipsoidComponent\.power Field

Component power P\_n = \|Gamma\_n\|^2 \[\-\]\.

```csharp
private readonly double power;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.powerEquivalenceCoefficient'></a>

## EllipsoidComponent\.powerEquivalenceCoefficient Field

Power equivalence coefficient w\_Pn = P\_n / P'\_n \[\-\]\. Calculated in Stage II\.

```csharp
private readonly double powerEquivalenceCoefficient;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.rayContributions'></a>

## EllipsoidComponent\.rayContributions Field

Contributions of the mesh cells assigned to the ellipsoid\.

```csharp
private readonly List<RayContribution>? rayContributions;
```

#### Field Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[RayContribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.RayContribution 'DiGi\.Communication\.Classes\.RayContribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.EllipsoidComponent.referencePower'></a>

## EllipsoidComponent\.referencePower Field

Reference power P'\_n: sum of squared moduli of the weighted reflection coefficients \[\-\]\.

```csharp
private readonly double referencePower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.reflectionCoefficientSum'></a>

## EllipsoidComponent\.reflectionCoefficientSum Field

Sum Gamma\_n of the weighted complex reflection coefficients of the whole ellipsoid \[\-\]\.

```csharp
private readonly Complex reflectionCoefficientSum;
```

#### Field Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

<a name='DiGi.Communication.Classes.EllipsoidComponent.semiMajorAxis'></a>

## EllipsoidComponent\.semiMajorAxis Field

Semi\-major axis a\_n of the ellipsoid \[m\]\.

```csharp
private readonly double semiMajorAxis;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.semiMinorAxis'></a>

## EllipsoidComponent\.semiMinorAxis Field

Semi\-minor axes b\_n = c\_n of the ellipsoid \[m\]\.

```csharp
private readonly double semiMinorAxis;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Properties

<a name='DiGi.Communication.Classes.EllipsoidComponent.Delay'></a>

## EllipsoidComponent\.Delay Property

Delay tau\_n \[s\] related to the ellipsoid\.

```csharp
public double Delay { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.FractionalPower'></a>

## EllipsoidComponent\.FractionalPower Property

Normalized power p\_n = P\_n / P resulting from the model \[\-\]\. Calculated in Stage II\.

```csharp
public double FractionalPower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.MappingErrorCorrectionCoefficient'></a>

## EllipsoidComponent\.MappingErrorCorrectionCoefficient Property

Correction coefficient w\_0n = p'\_n / p\_n for ray scattering object mapping errors \[\-\]\. Calculated in Stage II\.

```csharp
public double MappingErrorCorrectionCoefficient { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.MeasuredFractionalPower'></a>

## EllipsoidComponent\.MeasuredFractionalPower Property

Normalized \(fractional\) power p'\_n retrieved directly from the measured Power Delay Profile \[\-\]\.

```csharp
public double MeasuredFractionalPower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.Power'></a>

## EllipsoidComponent\.Power Property

Component power P\_n = \|Gamma\_n\|^2 \[\-\]\.

```csharp
public double Power { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.PowerEquivalenceCoefficient'></a>

## EllipsoidComponent\.PowerEquivalenceCoefficient Property

Power equivalence coefficient w\_Pn = P\_n / P'\_n \[\-\]\. Calculated in Stage II\.

```csharp
public double PowerEquivalenceCoefficient { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.RayContributions'></a>

## EllipsoidComponent\.RayContributions Property

Contributions of the mesh cells assigned to the ellipsoid\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Classes.RayContribution>? RayContributions { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[RayContribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.RayContribution 'DiGi\.Communication\.Classes\.RayContribution')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.EllipsoidComponent.ReferencePower'></a>

## EllipsoidComponent\.ReferencePower Property

Reference power P'\_n: sum of squared moduli of the weighted reflection coefficients \[\-\]\.

```csharp
public double ReferencePower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.ReflectionCoefficientSum'></a>

## EllipsoidComponent\.ReflectionCoefficientSum Property

Sum Gamma\_n of the weighted complex reflection coefficients of the whole ellipsoid \[\-\]\.

```csharp
public System.Numerics.Complex ReflectionCoefficientSum { get; }
```

#### Property Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

<a name='DiGi.Communication.Classes.EllipsoidComponent.SemiMajorAxis'></a>

## EllipsoidComponent\.SemiMajorAxis Property

Semi\-major axis a\_n of the ellipsoid \[m\]\.

```csharp
public double SemiMajorAxis { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.EllipsoidComponent.SemiMinorAxis'></a>

## EllipsoidComponent\.SemiMinorAxis Property

Semi\-minor axes b\_n = c\_n of the ellipsoid \[m\]\.

```csharp
public double SemiMinorAxis { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.GeometricalPropagationModel'></a>

## GeometricalPropagationModel Class

Represents a geometrical propagation model used to define and manage communication relation clusters within the system\.

```csharp
public class GeometricalPropagationModel : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidModel, DiGi.Core.Interfaces.ISerializableModel, DiGi.Core.Interfaces.IModel
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → GeometricalPropagationModel

Implements [DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidmodel 'DiGi\.Core\.Interfaces\.IGuidModel'), [DiGi\.Core\.Interfaces\.ISerializableModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializablemodel 'DiGi\.Core\.Interfaces\.ISerializableModel'), [DiGi\.Core\.Interfaces\.IModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.imodel 'DiGi\.Core\.Interfaces\.IModel')
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

`angularPowerDistributionProfile` [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

The angular power distribution profile to be assigned\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile,DiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

`multipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile to be assigned\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna to be associated with the propagation model\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to be assigned\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna involved in the propagation\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to be assigned\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Assign(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

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

The type of the angular power distribution profile, which must implement [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')\.

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

The type of antenna to retrieve, which must implement [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')\.

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

The type of antenna, which must implement the [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna') interface\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

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

The type of antenna to be returned, which must implement [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile used for the retrieval process\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna).antenna'></a>

`antenna` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

The type of antenna, which must implement the [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna') interface\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetAntennas_TAntenna_(DiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

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

The type of the multipath power delay profile to retrieve, which must implement [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfile_TMultipathPowerDelayProfile_(DiGi.Communication.Interfaces.IScatteringProfile).scatteringProfile'></a>

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

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

The type of multipath power delay profile to retrieve, which must implement [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfiles_TMultipathPowerDelayProfile_().TMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetMultipathPowerDelayProfiles\<TMultipathPowerDelayProfile\>\(\)\.TMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [TMultipathPowerDelayProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetMultipathPowerDelayProfiles_TMultipathPowerDelayProfile_().TMultipathPowerDelayProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetMultipathPowerDelayProfiles\<TMultipathPowerDelayProfile\>\(\)\.TMultipathPowerDelayProfile') objects if available; otherwise, `null`\.

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

The type of scattering object to retrieve, which must implement [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_().TScatteringObject 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringObjects\<TScatteringObject\>\(\)\.TScatteringObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of scattering objects of type [TScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringObjects_TScatteringObject_().TScatteringObject 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringObjects\<TScatteringObject\>\(\)\.TScatteringObject'), or `null` if the collection is empty or unavailable\.

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

The type of scattering profile to retrieve, which must implement [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')\.

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

The type of scattering profile to retrieve, which must implement [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')\.
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna involved in the propagation path\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The second antenna involved in the propagation path\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TScatteringProfile](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel.GetScatteringProfiles_TScatteringProfile_(DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).TScatteringProfile 'DiGi\.Communication\.Classes\.GeometricalPropagationModel\.GetScatteringProfiles\<TScatteringProfile\>\(DiGi\.Communication\.Interfaces\.IAntenna, DiGi\.Communication\.Interfaces\.IAntenna\)\.TScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of scattering profiles if both antennas are provided; otherwise, null\.

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile)'></a>

## GeometricalPropagationModel\.Update\(IAngularPowerDistributionProfile\) Method

Performs an update operation by adding a cloned angular power distribution profile to the communication relation cluster\.

```csharp
public bool Update(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile? angularPowerDistributionProfile);
```
#### Parameters

<a name='DiGi.Communication.Classes.GeometricalPropagationModel.Update(DiGi.Communication.Interfaces.IAngularPowerDistributionProfile).angularPowerDistributionProfile'></a>

`angularPowerDistributionProfile` [DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iangularpowerdistributionprofile 'DiGi\.Communication\.Interfaces\.IAngularPowerDistributionProfile')

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

`antenna` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

`multipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

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

`scatteringObject` [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject')

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

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to be used for the update\. Can be null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the update was successful; otherwise, `false`\.

<a name='DiGi.Communication.Classes.MaterialProperties'></a>

## MaterialProperties Class

Electrical material properties of a scattering object\.

```csharp
public class MaterialProperties : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → MaterialProperties

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.MaterialProperties.MaterialProperties(DiGi.Communication.Classes.MaterialProperties)'></a>

## MaterialProperties\(MaterialProperties\) Constructor

Initializes a new instance of the [MaterialProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MaterialProperties 'DiGi\.Communication\.Classes\.MaterialProperties') class by copying another material properties instance\.

```csharp
public MaterialProperties(DiGi.Communication.Classes.MaterialProperties? materialProperties);
```
#### Parameters

<a name='DiGi.Communication.Classes.MaterialProperties.MaterialProperties(DiGi.Communication.Classes.MaterialProperties).materialProperties'></a>

`materialProperties` [MaterialProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MaterialProperties 'DiGi\.Communication\.Classes\.MaterialProperties')

The source material properties to copy from\.

<a name='DiGi.Communication.Classes.MaterialProperties.MaterialProperties(double,double)'></a>

## MaterialProperties\(double, double\) Constructor

Initializes a new instance of the [MaterialProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MaterialProperties 'DiGi\.Communication\.Classes\.MaterialProperties') class\.

```csharp
public MaterialProperties(double relativePermittivity, double conductivity);
```
#### Parameters

<a name='DiGi.Communication.Classes.MaterialProperties.MaterialProperties(double,double).relativePermittivity'></a>

`relativePermittivity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Relative electrical permittivity of the object \[\-\]\.

<a name='DiGi.Communication.Classes.MaterialProperties.MaterialProperties(double,double).conductivity'></a>

`conductivity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Electrical conductivity of the object \[S/m\]\.

<a name='DiGi.Communication.Classes.MaterialProperties.MaterialProperties(System.Text.Json.Nodes.JsonObject)'></a>

## MaterialProperties\(JsonObject\) Constructor

Initializes a new instance of the [MaterialProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MaterialProperties 'DiGi\.Communication\.Classes\.MaterialProperties') class from a JsonObject\.

```csharp
public MaterialProperties(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.MaterialProperties.MaterialProperties(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Classes.MaterialProperties.conductivity'></a>

## MaterialProperties\.conductivity Field

Electrical conductivity sigma\_k of the object \[S/m\]\.

```csharp
private readonly double conductivity;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.MaterialProperties.relativePermittivity'></a>

## MaterialProperties\.relativePermittivity Field

Relative electrical permittivity epsilon\_wk of the object \[\-\]\.

```csharp
private readonly double relativePermittivity;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Properties

<a name='DiGi.Communication.Classes.MaterialProperties.Conductivity'></a>

## MaterialProperties\.Conductivity Property

Electrical conductivity sigma\_k of the object \[S/m\]\.

```csharp
public double Conductivity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.MaterialProperties.RelativePermittivity'></a>

## MaterialProperties\.RelativePermittivity Property

Relative electrical permittivity epsilon\_wk of the object \[\-\]\.

```csharp
public double RelativePermittivity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.MeshCell'></a>

## MeshCell Class

Triangular spatial cell of the scattering object mesh\. Coordinates are expressed in the model coordinate system: the transmitter is placed at the origin, the transmitter\-receiver direction determines the OX axis and the earth surface forms the XOY plane\.

```csharp
public class MeshCell : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → MeshCell

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.MeshCell.MeshCell(DiGi.Communication.Classes.MeshCell)'></a>

## MeshCell\(MeshCell\) Constructor

Initializes a new instance of the [MeshCell](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MeshCell 'DiGi\.Communication\.Classes\.MeshCell') class by copying another mesh cell\.

```csharp
public MeshCell(DiGi.Communication.Classes.MeshCell? meshCell);
```
#### Parameters

<a name='DiGi.Communication.Classes.MeshCell.MeshCell(DiGi.Communication.Classes.MeshCell).meshCell'></a>

`meshCell` [MeshCell](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MeshCell 'DiGi\.Communication\.Classes\.MeshCell')

The source mesh cell to copy from\.

<a name='DiGi.Communication.Classes.MeshCell.MeshCell(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Communication.Classes.MaterialProperties)'></a>

## MeshCell\(Point3D, Vector3D, MaterialProperties\) Constructor

Initializes a new instance of the [MeshCell](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MeshCell 'DiGi\.Communication\.Classes\.MeshCell') class\.

```csharp
public MeshCell(DiGi.Geometry.Spatial.Classes.Point3D? center, DiGi.Geometry.Spatial.Classes.Vector3D? normal, DiGi.Communication.Classes.MaterialProperties? materialProperties);
```
#### Parameters

<a name='DiGi.Communication.Classes.MeshCell.MeshCell(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Communication.Classes.MaterialProperties).center'></a>

`center` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

Center of gravity of the triangular cell \[m\]\.

<a name='DiGi.Communication.Classes.MeshCell.MeshCell(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Communication.Classes.MaterialProperties).normal'></a>

`normal` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

Normal vector of the cell plane\.

<a name='DiGi.Communication.Classes.MeshCell.MeshCell(DiGi.Geometry.Spatial.Classes.Point3D,DiGi.Geometry.Spatial.Classes.Vector3D,DiGi.Communication.Classes.MaterialProperties).materialProperties'></a>

`materialProperties` [MaterialProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MaterialProperties 'DiGi\.Communication\.Classes\.MaterialProperties')

Electrical material properties of the cell\.

<a name='DiGi.Communication.Classes.MeshCell.MeshCell(System.Text.Json.Nodes.JsonObject)'></a>

## MeshCell\(JsonObject\) Constructor

Initializes a new instance of the [MeshCell](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MeshCell 'DiGi\.Communication\.Classes\.MeshCell') class from a JsonObject\.

```csharp
public MeshCell(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.MeshCell.MeshCell(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Classes.MeshCell.center'></a>

## MeshCell\.center Field

Center of gravity of the triangular cell \[m\]\.

```csharp
private readonly Point3D? center;
```

#### Field Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Classes.MeshCell.materialProperties'></a>

## MeshCell\.materialProperties Field

Electrical material properties of the cell\.

```csharp
private readonly MaterialProperties? materialProperties;
```

#### Field Value
[MaterialProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MaterialProperties 'DiGi\.Communication\.Classes\.MaterialProperties')

<a name='DiGi.Communication.Classes.MeshCell.normal'></a>

## MeshCell\.normal Field

Normal vector of the cell plane\.

```csharp
private readonly Vector3D? normal;
```

#### Field Value
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')
### Properties

<a name='DiGi.Communication.Classes.MeshCell.Center'></a>

## MeshCell\.Center Property

Center of gravity of the triangular cell \[m\]\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Center { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Classes.MeshCell.MaterialProperties'></a>

## MeshCell\.MaterialProperties Property

Electrical material properties of the cell\.

```csharp
public DiGi.Communication.Classes.MaterialProperties? MaterialProperties { get; }
```

#### Property Value
[MaterialProperties](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MaterialProperties 'DiGi\.Communication\.Classes\.MaterialProperties')

<a name='DiGi.Communication.Classes.MeshCell.Normal'></a>

## MeshCell\.Normal Property

Normal vector of the cell plane\.

```csharp
public DiGi.Geometry.Spatial.Classes.Vector3D? Normal { get; }
```

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation'></a>

## MultipathPowerDelayProfileAntennasRelation Class

Represents a bidirectional one\-to\-many relationship between a multipath power delay profile and its associated antennas\.

```csharp
public class MultipathPowerDelayProfileAntennasRelation : DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<DiGi.Communication.Interfaces.IMultipathPowerDelayProfile, DiGi.Communication.Interfaces.IAntenna>, DiGi.Communication.Interfaces.ICommunicationRelation, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanybidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\`2') → MultipathPowerDelayProfileAntennasRelation

Implements [DiGi\.Communication\.Interfaces\.ICommunicationRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationrelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
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

`multipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

The multipath power delay profile associated with this relation\.

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation.MultipathPowerDelayProfileAntennasRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna associated with this relation\.

<a name='DiGi.Communication.Classes.MultipathPowerDelayProfileAntennasRelation.MultipathPowerDelayProfileAntennasRelation(DiGi.Communication.Interfaces.IMultipathPowerDelayProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint'></a>

## PowerDelayProfilePoint Class

Single point of the normalized Power Delay Profile \(PDP\): a delay tau\_n and the normalized \(fractional\) power arriving with that delay\.

```csharp
public class PowerDelayProfilePoint : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → PowerDelayProfilePoint

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.PowerDelayProfilePoint(DiGi.Communication.Classes.PowerDelayProfilePoint)'></a>

## PowerDelayProfilePoint\(PowerDelayProfilePoint\) Constructor

Initializes a new instance of the [PowerDelayProfilePoint](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PowerDelayProfilePoint 'DiGi\.Communication\.Classes\.PowerDelayProfilePoint') class by copying another power delay profile point\.

```csharp
public PowerDelayProfilePoint(DiGi.Communication.Classes.PowerDelayProfilePoint? powerDelayProfilePoint);
```
#### Parameters

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.PowerDelayProfilePoint(DiGi.Communication.Classes.PowerDelayProfilePoint).powerDelayProfilePoint'></a>

`powerDelayProfilePoint` [PowerDelayProfilePoint](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PowerDelayProfilePoint 'DiGi\.Communication\.Classes\.PowerDelayProfilePoint')

The source power delay profile point to copy from\.

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.PowerDelayProfilePoint(double,double)'></a>

## PowerDelayProfilePoint\(double, double\) Constructor

Initializes a new instance of the [PowerDelayProfilePoint](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PowerDelayProfilePoint 'DiGi\.Communication\.Classes\.PowerDelayProfilePoint') class\.

```csharp
public PowerDelayProfilePoint(double delay, double fractionalPower);
```
#### Parameters

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.PowerDelayProfilePoint(double,double).delay'></a>

`delay` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Delay tau\_n \[s\]\.

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.PowerDelayProfilePoint(double,double).fractionalPower'></a>

`fractionalPower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Normalized \(fractional\) power p'\_n arriving with the given delay \[\-\]\.

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.PowerDelayProfilePoint(System.Text.Json.Nodes.JsonObject)'></a>

## PowerDelayProfilePoint\(JsonObject\) Constructor

Initializes a new instance of the [PowerDelayProfilePoint](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PowerDelayProfilePoint 'DiGi\.Communication\.Classes\.PowerDelayProfilePoint') class from a JsonObject\.

```csharp
public PowerDelayProfilePoint(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.PowerDelayProfilePoint(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.delay'></a>

## PowerDelayProfilePoint\.delay Field

Delay tau\_n \[s\]\.

```csharp
private readonly double delay;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.fractionalPower'></a>

## PowerDelayProfilePoint\.fractionalPower Field

Normalized \(fractional\) power p'\_n arriving with the given delay \[\-\]\.

```csharp
private readonly double fractionalPower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Properties

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.Delay'></a>

## PowerDelayProfilePoint\.Delay Property

Delay tau\_n \[s\]\.

```csharp
public double Delay { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.PowerDelayProfilePoint.FractionalPower'></a>

## PowerDelayProfilePoint\.FractionalPower Property

Normalized \(fractional\) power p'\_n arriving with the given delay \[\-\]\.

```csharp
public double FractionalPower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.PropagationModel'></a>

## PropagationModel Class

Input data of the multi\-ellipsoidal propagation model\. The model coordinate system places the transmitter \(Tx\) at the origin, the receiver \(Rx\) at \(Distance, 0, 0\) — the Tx\-Rx direction determines the OX axis — and the earth surface forms the XOY plane\.

```csharp
public class PropagationModel : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → PropagationModel

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(DiGi.Communication.Classes.PropagationModel)'></a>

## PropagationModel\(PropagationModel\) Constructor

Initializes a new instance of the [PropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PropagationModel 'DiGi\.Communication\.Classes\.PropagationModel') class by copying another propagation model\.

```csharp
public PropagationModel(DiGi.Communication.Classes.PropagationModel? propagationModel);
```
#### Parameters

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(DiGi.Communication.Classes.PropagationModel).propagationModel'></a>

`propagationModel` [PropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PropagationModel 'DiGi\.Communication\.Classes\.PropagationModel')

The source propagation model to copy from\.

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.MeshCell_,DiGi.Communication.Enums.Polarization,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.PowerDelayProfilePoint_,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic)'></a>

## PropagationModel\(double, double, IEnumerable\<MeshCell\>, Polarization, IEnumerable\<PowerDelayProfilePoint\>, AntennaCharacteristic, AntennaCharacteristic, AntennaCharacteristic, AntennaCharacteristic\) Constructor

Initializes a new instance of the [PropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PropagationModel 'DiGi\.Communication\.Classes\.PropagationModel') class\.

```csharp
public PropagationModel(double distance, double frequency, System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.MeshCell>? meshCells, DiGi.Communication.Enums.Polarization polarization, System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.PowerDelayProfilePoint>? powerDelayProfilePoints, DiGi.Communication.AntennaCharacteristic? receivingDirectionalCharacteristic, DiGi.Communication.AntennaCharacteristic? receivingOmnidirectionalCharacteristic, DiGi.Communication.AntennaCharacteristic? transmittingDirectionalCharacteristic, DiGi.Communication.AntennaCharacteristic? transmittingOmnidirectionalCharacteristic);
```
#### Parameters

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.MeshCell_,DiGi.Communication.Enums.Polarization,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.PowerDelayProfilePoint_,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Distance d between the transmitter and receiver \[m\]\.

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.MeshCell_,DiGi.Communication.Enums.Polarization,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.PowerDelayProfilePoint_,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic).frequency'></a>

`frequency` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Frequency f of the propagating electromagnetic wave \[MHz\]\.

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.MeshCell_,DiGi.Communication.Enums.Polarization,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.PowerDelayProfilePoint_,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic).meshCells'></a>

`meshCells` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[MeshCell](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MeshCell 'DiGi\.Communication\.Classes\.MeshCell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Triangular spatial cells representing the scattering objects\.

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.MeshCell_,DiGi.Communication.Enums.Polarization,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.PowerDelayProfilePoint_,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic).polarization'></a>

`polarization` [Polarization](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Polarization 'DiGi\.Communication\.Enums\.Polarization')

Polarization type of the propagating electromagnetic wave\.

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.MeshCell_,DiGi.Communication.Enums.Polarization,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.PowerDelayProfilePoint_,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic).powerDelayProfilePoints'></a>

`powerDelayProfilePoints` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[PowerDelayProfilePoint](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PowerDelayProfilePoint 'DiGi\.Communication\.Classes\.PowerDelayProfilePoint')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Normalized Power Delay Profile \(PDP\) points: delays tau\_n with the normalized \(fractional\) powers p'\_n\.

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.MeshCell_,DiGi.Communication.Enums.Polarization,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.PowerDelayProfilePoint_,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic).receivingDirectionalCharacteristic'></a>

`receivingDirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized reception characteristic g\(theta, phi\) of the directional receiving antenna\.

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.MeshCell_,DiGi.Communication.Enums.Polarization,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.PowerDelayProfilePoint_,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic).receivingOmnidirectionalCharacteristic'></a>

`receivingOmnidirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized reception characteristic g\_0\(theta, phi\) of the omnidirectional receiving antenna\.

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.MeshCell_,DiGi.Communication.Enums.Polarization,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.PowerDelayProfilePoint_,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic).transmittingDirectionalCharacteristic'></a>

`transmittingDirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized radiation characteristic g\_T\(theta, phi\) of the directional transmitting antenna\.

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(double,double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.MeshCell_,DiGi.Communication.Enums.Polarization,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.PowerDelayProfilePoint_,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic).transmittingOmnidirectionalCharacteristic'></a>

`transmittingOmnidirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized radiation characteristic g\_T0\(theta, phi\) of the omnidirectional transmitting antenna\.

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(System.Text.Json.Nodes.JsonObject)'></a>

## PropagationModel\(JsonObject\) Constructor

Initializes a new instance of the [PropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PropagationModel 'DiGi\.Communication\.Classes\.PropagationModel') class from a JsonObject\.

```csharp
public PropagationModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.PropagationModel.PropagationModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Classes.PropagationModel.distance'></a>

## PropagationModel\.distance Field

Distance d between the transmitter and receiver \[m\]\.

```csharp
private readonly double distance;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.PropagationModel.frequency'></a>

## PropagationModel\.frequency Field

Frequency f of the propagating electromagnetic wave \[MHz\]\.

```csharp
private readonly double frequency;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.PropagationModel.meshCells'></a>

## PropagationModel\.meshCells Field

Triangular spatial cells representing the scattering objects\.

```csharp
private readonly List<MeshCell>? meshCells;
```

#### Field Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[MeshCell](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MeshCell 'DiGi\.Communication\.Classes\.MeshCell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.PropagationModel.polarization'></a>

## PropagationModel\.polarization Field

Polarization type of the propagating electromagnetic wave\.

```csharp
private readonly Polarization polarization;
```

#### Field Value
[Polarization](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Polarization 'DiGi\.Communication\.Enums\.Polarization')

<a name='DiGi.Communication.Classes.PropagationModel.powerDelayProfilePoints'></a>

## PropagationModel\.powerDelayProfilePoints Field

Normalized Power Delay Profile \(PDP\) points: delays tau\_n with the normalized \(fractional\) powers p'\_n\. The fractional powers are expected to sum to 1\.

```csharp
private readonly List<PowerDelayProfilePoint>? powerDelayProfilePoints;
```

#### Field Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PowerDelayProfilePoint](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PowerDelayProfilePoint 'DiGi\.Communication\.Classes\.PowerDelayProfilePoint')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.PropagationModel.receivingDirectionalCharacteristic'></a>

## PropagationModel\.receivingDirectionalCharacteristic Field

Normalized reception characteristic g\(theta, phi\) of the directional receiving antenna\. Not serializable: excluded from JSON persistence and cloning restores a [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') reference\.

```csharp
private readonly AntennaCharacteristic? receivingDirectionalCharacteristic;
```

#### Field Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Classes.PropagationModel.receivingOmnidirectionalCharacteristic'></a>

## PropagationModel\.receivingOmnidirectionalCharacteristic Field

Normalized reception characteristic g\_0\(theta, phi\) of the omnidirectional receiving antenna\. Not serializable: excluded from JSON persistence and cloning restores a [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') reference\.

```csharp
private readonly AntennaCharacteristic? receivingOmnidirectionalCharacteristic;
```

#### Field Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Classes.PropagationModel.transmittingDirectionalCharacteristic'></a>

## PropagationModel\.transmittingDirectionalCharacteristic Field

Normalized radiation characteristic g\_T\(theta, phi\) of the directional transmitting antenna\. Reserved for the transmitting\-side comparison; not used by the receiving\-side comparative analysis\. Not serializable: excluded from JSON persistence and cloning restores a [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') reference\.

```csharp
private readonly AntennaCharacteristic? transmittingDirectionalCharacteristic;
```

#### Field Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Classes.PropagationModel.transmittingOmnidirectionalCharacteristic'></a>

## PropagationModel\.transmittingOmnidirectionalCharacteristic Field

Normalized radiation characteristic g\_T0\(theta, phi\) of the omnidirectional transmitting antenna\. Not serializable: excluded from JSON persistence and cloning restores a [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') reference\.

```csharp
private readonly AntennaCharacteristic? transmittingOmnidirectionalCharacteristic;
```

#### Field Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')
### Properties

<a name='DiGi.Communication.Classes.PropagationModel.Distance'></a>

## PropagationModel\.Distance Property

Distance d between the transmitter and receiver \[m\]\.

```csharp
public double Distance { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.PropagationModel.Frequency'></a>

## PropagationModel\.Frequency Property

Frequency f of the propagating electromagnetic wave \[MHz\]\.

```csharp
public double Frequency { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.PropagationModel.MeshCells'></a>

## PropagationModel\.MeshCells Property

Triangular spatial cells representing the scattering objects\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Classes.MeshCell>? MeshCells { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[MeshCell](DiGi.Communication.Classes.md#DiGi.Communication.Classes.MeshCell 'DiGi\.Communication\.Classes\.MeshCell')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.PropagationModel.Polarization'></a>

## PropagationModel\.Polarization Property

Polarization type of the propagating electromagnetic wave\.

```csharp
public DiGi.Communication.Enums.Polarization Polarization { get; }
```

#### Property Value
[Polarization](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Polarization 'DiGi\.Communication\.Enums\.Polarization')

<a name='DiGi.Communication.Classes.PropagationModel.PowerDelayProfilePoints'></a>

## PropagationModel\.PowerDelayProfilePoints Property

Normalized Power Delay Profile \(PDP\) points: delays tau\_n with the normalized \(fractional\) powers p'\_n\. The fractional powers are expected to sum to 1\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Classes.PowerDelayProfilePoint>? PowerDelayProfilePoints { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[PowerDelayProfilePoint](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PowerDelayProfilePoint 'DiGi\.Communication\.Classes\.PowerDelayProfilePoint')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.PropagationModel.ReceivingDirectionalCharacteristic'></a>

## PropagationModel\.ReceivingDirectionalCharacteristic Property

Normalized reception characteristic g\(theta, phi\) of the directional receiving antenna\.

```csharp
public DiGi.Communication.AntennaCharacteristic? ReceivingDirectionalCharacteristic { get; }
```

#### Property Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Classes.PropagationModel.ReceivingOmnidirectionalCharacteristic'></a>

## PropagationModel\.ReceivingOmnidirectionalCharacteristic Property

Normalized reception characteristic g\_0\(theta, phi\) of the omnidirectional receiving antenna\.

```csharp
public DiGi.Communication.AntennaCharacteristic? ReceivingOmnidirectionalCharacteristic { get; }
```

#### Property Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Classes.PropagationModel.TransmittingDirectionalCharacteristic'></a>

## PropagationModel\.TransmittingDirectionalCharacteristic Property

Normalized radiation characteristic g\_T\(theta, phi\) of the directional transmitting antenna\. Reserved for the transmitting\-side comparison; not used by the receiving\-side comparative analysis\.

```csharp
public DiGi.Communication.AntennaCharacteristic? TransmittingDirectionalCharacteristic { get; }
```

#### Property Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Classes.PropagationModel.TransmittingOmnidirectionalCharacteristic'></a>

## PropagationModel\.TransmittingOmnidirectionalCharacteristic Property

Normalized radiation characteristic g\_T0\(theta, phi\) of the omnidirectional transmitting antenna\.

```csharp
public DiGi.Communication.AntennaCharacteristic? TransmittingOmnidirectionalCharacteristic { get; }
```

#### Property Value
[AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

<a name='DiGi.Communication.Classes.PropagationResult'></a>

## PropagationResult Class

Result of the comparative multi\-ellipsoidal propagation analysis\.

```csharp
public class PropagationResult : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → PropagationResult

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.PropagationResult.PropagationResult(DiGi.Communication.Classes.PropagationResult)'></a>

## PropagationResult\(PropagationResult\) Constructor

Initializes a new instance of the [PropagationResult](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PropagationResult 'DiGi\.Communication\.Classes\.PropagationResult') class by copying another propagation result\.

```csharp
public PropagationResult(DiGi.Communication.Classes.PropagationResult? propagationResult);
```
#### Parameters

<a name='DiGi.Communication.Classes.PropagationResult.PropagationResult(DiGi.Communication.Classes.PropagationResult).propagationResult'></a>

`propagationResult` [PropagationResult](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PropagationResult 'DiGi\.Communication\.Classes\.PropagationResult')

The source propagation result to copy from\.

<a name='DiGi.Communication.Classes.PropagationResult.PropagationResult(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.EllipsoidComponent_,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.ArrivalRay_,double)'></a>

## PropagationResult\(double, IEnumerable\<EllipsoidComponent\>, IEnumerable\<ArrivalRay\>, double\) Constructor

Initializes a new instance of the [PropagationResult](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PropagationResult 'DiGi\.Communication\.Classes\.PropagationResult') class\.

```csharp
public PropagationResult(double directionalPower, System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.EllipsoidComponent>? ellipsoidComponents, System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.ArrivalRay>? rays, double totalPower);
```
#### Parameters

<a name='DiGi.Communication.Classes.PropagationResult.PropagationResult(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.EllipsoidComponent_,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.ArrivalRay_,double).directionalPower'></a>

`directionalPower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Total normalized power P\_0 reaching the receiving antenna after applying the directional reception characteristic \[\-\]\. The final result of the comparative analysis\.

<a name='DiGi.Communication.Classes.PropagationResult.PropagationResult(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.EllipsoidComponent_,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.ArrivalRay_,double).ellipsoidComponents'></a>

`ellipsoidComponents` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[EllipsoidComponent](DiGi.Communication.Classes.md#DiGi.Communication.Classes.EllipsoidComponent 'DiGi\.Communication\.Classes\.EllipsoidComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Ellipsoid components P\_n determined for the individual delays of the Power Delay Profile\.

<a name='DiGi.Communication.Classes.PropagationResult.PropagationResult(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.EllipsoidComponent_,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.ArrivalRay_,double).rays'></a>

`rays` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ArrivalRay](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ArrivalRay 'DiGi\.Communication\.Classes\.ArrivalRay')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Rays arriving at the receiving antenna: arrival directions \(theta\_kl, phi\_kl\) with their assigned corrected powers p\_nkl\.

<a name='DiGi.Communication.Classes.PropagationResult.PropagationResult(double,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.EllipsoidComponent_,System.Collections.Generic.IEnumerable_DiGi.Communication.Classes.ArrivalRay_,double).totalPower'></a>

`totalPower` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Total received power P before applying the directional antenna characteristics \[\-\]\.

<a name='DiGi.Communication.Classes.PropagationResult.PropagationResult(System.Text.Json.Nodes.JsonObject)'></a>

## PropagationResult\(JsonObject\) Constructor

Initializes a new instance of the [PropagationResult](DiGi.Communication.Classes.md#DiGi.Communication.Classes.PropagationResult 'DiGi\.Communication\.Classes\.PropagationResult') class from a JsonObject\.

```csharp
public PropagationResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.PropagationResult.PropagationResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Classes.PropagationResult.directionalPower'></a>

## PropagationResult\.directionalPower Field

Total normalized power P\_0 reaching the receiving antenna after applying the directional reception characteristic \[\-\]\. The final result of the comparative analysis\.

```csharp
private readonly double directionalPower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.PropagationResult.ellipsoidComponents'></a>

## PropagationResult\.ellipsoidComponents Field

Ellipsoid components P\_n determined for the individual delays of the Power Delay Profile\.

```csharp
private readonly List<EllipsoidComponent>? ellipsoidComponents;
```

#### Field Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[EllipsoidComponent](DiGi.Communication.Classes.md#DiGi.Communication.Classes.EllipsoidComponent 'DiGi\.Communication\.Classes\.EllipsoidComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.PropagationResult.rays'></a>

## PropagationResult\.rays Field

Rays arriving at the receiving antenna: arrival directions \(theta\_kl, phi\_kl\) with their assigned corrected powers p\_nkl\. The powers sum to 1 for a normalized Power Delay Profile\.

```csharp
private readonly List<ArrivalRay>? rays;
```

#### Field Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ArrivalRay](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ArrivalRay 'DiGi\.Communication\.Classes\.ArrivalRay')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.PropagationResult.totalPower'></a>

## PropagationResult\.totalPower Field

Total received power P before applying the directional antenna characteristics \[\-\]\.

```csharp
private readonly double totalPower;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Properties

<a name='DiGi.Communication.Classes.PropagationResult.DirectionalPower'></a>

## PropagationResult\.DirectionalPower Property

Total normalized power P\_0 reaching the receiving antenna after applying the directional reception characteristic \[\-\]\. The final result of the comparative analysis\.

```csharp
public double DirectionalPower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.PropagationResult.EllipsoidComponents'></a>

## PropagationResult\.EllipsoidComponents Property

Ellipsoid components P\_n determined for the individual delays of the Power Delay Profile\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Classes.EllipsoidComponent>? EllipsoidComponents { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[EllipsoidComponent](DiGi.Communication.Classes.md#DiGi.Communication.Classes.EllipsoidComponent 'DiGi\.Communication\.Classes\.EllipsoidComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.PropagationResult.Rays'></a>

## PropagationResult\.Rays Property

Rays arriving at the receiving antenna: arrival directions \(theta\_kl, phi\_kl\) with their assigned corrected powers p\_nkl\. The powers sum to 1 for a normalized Power Delay Profile\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Classes.ArrivalRay>? Rays { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ArrivalRay](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ArrivalRay 'DiGi\.Communication\.Classes\.ArrivalRay')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.PropagationResult.TotalPower'></a>

## PropagationResult\.TotalPower Property

Total received power P before applying the directional antenna characteristics \[\-\]\.

```csharp
public double TotalPower { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.Ray'></a>

## Ray Class

Represents a geometric ray defined by an origin point and a direction vector, supporting serialization for communication purposes\.

```csharp
public class Ray : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Ray

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
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

<a name='DiGi.Communication.Classes.RayContribution'></a>

## RayContribution Class

Contribution of a single mesh cell \(cell l of subset k\) to an ellipsoid component: ray directions, antenna gains and reflection coefficients\.

```csharp
public class RayContribution : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → RayContribution

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
### Constructors

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(DiGi.Communication.Classes.RayContribution)'></a>

## RayContribution\(RayContribution\) Constructor

Initializes a new instance of the [RayContribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.RayContribution 'DiGi\.Communication\.Classes\.RayContribution') class by copying another ray contribution\.

```csharp
public RayContribution(DiGi.Communication.Classes.RayContribution? rayContribution);
```
#### Parameters

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(DiGi.Communication.Classes.RayContribution).rayContribution'></a>

`rayContribution` [RayContribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.RayContribution 'DiGi\.Communication\.Classes\.RayContribution')

The source ray contribution to copy from\.

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex)'></a>

## RayContribution\(double, double, double, double, Complex, double, double, double, Complex\) Constructor

Initializes a new instance of the [RayContribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.RayContribution 'DiGi\.Communication\.Classes\.RayContribution') class\.

```csharp
public RayContribution(double incidenceAngle, double phiReceiver, double phiTransmitter, double receivingGain, System.Numerics.Complex reflectionCoefficient, double thetaReceiver, double thetaTransmitter, double transmittingGain, System.Numerics.Complex weightedReflectionCoefficient);
```
#### Parameters

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).incidenceAngle'></a>

`incidenceAngle` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Angle of incidence gamma\_kl \[rad\] of the ray on the cell plane, measured from the plane \(grazing angle\)\.

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).phiReceiver'></a>

`phiReceiver` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Azimuth angle phi\_kl \[rad\] of the received ray, with origin at the receiver\.

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).phiTransmitter'></a>

`phiTransmitter` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Azimuth angle phi\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).receivingGain'></a>

`receivingGain` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Normalized reception characteristic value g\_0kl of the omnidirectional receiving antenna for the received ray direction \[\-\]\.

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).reflectionCoefficient'></a>

`reflectionCoefficient` [System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

Complex reflection coefficient Gamma\_kl of the cell \[\-\]\.

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).thetaReceiver'></a>

`thetaReceiver` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Polar angle theta\_kl \[rad\] of the received ray, with origin at the receiver\.

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).thetaTransmitter'></a>

`thetaTransmitter` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Polar angle theta\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).transmittingGain'></a>

`transmittingGain` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Normalized radiation characteristic value g\_T0kl of the omnidirectional transmitting antenna for the emitted ray direction \[\-\]\.

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(double,double,double,double,System.Numerics.Complex,double,double,double,System.Numerics.Complex).weightedReflectionCoefficient'></a>

`weightedReflectionCoefficient` [System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

Weighted complex reflection coefficient Gamma'\_kl = g\_T0kl \* g\_0kl \* Gamma\_kl \[\-\]\.

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(System.Text.Json.Nodes.JsonObject)'></a>

## RayContribution\(JsonObject\) Constructor

Initializes a new instance of the [RayContribution](DiGi.Communication.Classes.md#DiGi.Communication.Classes.RayContribution 'DiGi\.Communication\.Classes\.RayContribution') class from a JsonObject\.

```csharp
public RayContribution(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Communication.Classes.RayContribution.RayContribution(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing serializable data\.
### Fields

<a name='DiGi.Communication.Classes.RayContribution.incidenceAngle'></a>

## RayContribution\.incidenceAngle Field

Angle of incidence gamma\_kl \[rad\] of the ray on the cell plane, measured from the plane \(grazing angle\)\.

```csharp
private readonly double incidenceAngle;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.phiReceiver'></a>

## RayContribution\.phiReceiver Field

Azimuth angle phi\_kl \[rad\] of the received ray, with origin at the receiver\.

```csharp
private readonly double phiReceiver;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.phiTransmitter'></a>

## RayContribution\.phiTransmitter Field

Azimuth angle phi\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

```csharp
private readonly double phiTransmitter;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.receivingGain'></a>

## RayContribution\.receivingGain Field

Normalized reception characteristic value g\_0kl of the omnidirectional receiving antenna for the received ray direction \[\-\]\.

```csharp
private readonly double receivingGain;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.reflectionCoefficient'></a>

## RayContribution\.reflectionCoefficient Field

Complex reflection coefficient Gamma\_kl of the cell \[\-\]\.

```csharp
private readonly Complex reflectionCoefficient;
```

#### Field Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

<a name='DiGi.Communication.Classes.RayContribution.thetaReceiver'></a>

## RayContribution\.thetaReceiver Field

Polar angle theta\_kl \[rad\] of the received ray, with origin at the receiver\.

```csharp
private readonly double thetaReceiver;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.thetaTransmitter'></a>

## RayContribution\.thetaTransmitter Field

Polar angle theta\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

```csharp
private readonly double thetaTransmitter;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.transmittingGain'></a>

## RayContribution\.transmittingGain Field

Normalized radiation characteristic value g\_T0kl of the omnidirectional transmitting antenna for the emitted ray direction \[\-\]\.

```csharp
private readonly double transmittingGain;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.weightedReflectionCoefficient'></a>

## RayContribution\.weightedReflectionCoefficient Field

Weighted complex reflection coefficient Gamma'\_kl = g\_T0kl \* g\_0kl \* Gamma\_kl \[\-\]\.

```csharp
private readonly Complex weightedReflectionCoefficient;
```

#### Field Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')
### Properties

<a name='DiGi.Communication.Classes.RayContribution.IncidenceAngle'></a>

## RayContribution\.IncidenceAngle Property

Angle of incidence gamma\_kl \[rad\] of the ray on the cell plane, measured from the plane \(grazing angle\)\.

```csharp
public double IncidenceAngle { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.PhiReceiver'></a>

## RayContribution\.PhiReceiver Property

Azimuth angle phi\_kl \[rad\] of the received ray, with origin at the receiver\.

```csharp
public double PhiReceiver { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.PhiTransmitter'></a>

## RayContribution\.PhiTransmitter Property

Azimuth angle phi\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

```csharp
public double PhiTransmitter { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.ReceivingGain'></a>

## RayContribution\.ReceivingGain Property

Normalized reception characteristic value g\_0kl of the omnidirectional receiving antenna for the received ray direction \[\-\]\.

```csharp
public double ReceivingGain { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.ReflectionCoefficient'></a>

## RayContribution\.ReflectionCoefficient Property

Complex reflection coefficient Gamma\_kl of the cell \[\-\]\.

```csharp
public System.Numerics.Complex ReflectionCoefficient { get; }
```

#### Property Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

<a name='DiGi.Communication.Classes.RayContribution.ThetaReceiver'></a>

## RayContribution\.ThetaReceiver Property

Polar angle theta\_kl \[rad\] of the received ray, with origin at the receiver\.

```csharp
public double ThetaReceiver { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.ThetaTransmitter'></a>

## RayContribution\.ThetaTransmitter Property

Polar angle theta\_Tkl \[rad\] of the emitted ray, with origin at the transmitter\.

```csharp
public double ThetaTransmitter { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.TransmittingGain'></a>

## RayContribution\.TransmittingGain Property

Normalized radiation characteristic value g\_T0kl of the omnidirectional transmitting antenna for the emitted ray direction \[\-\]\.

```csharp
public double TransmittingGain { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.RayContribution.WeightedReflectionCoefficient'></a>

## RayContribution\.WeightedReflectionCoefficient Property

Weighted complex reflection coefficient Gamma'\_kl = g\_T0kl \* g\_0kl \* Gamma\_kl \[\-\]\.

```csharp
public System.Numerics.Complex WeightedReflectionCoefficient { get; }
```

#### Property Value
[System\.Numerics\.Complex](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex 'System\.Numerics\.Complex')

<a name='DiGi.Communication.Classes.Scattering'></a>

## Scattering Class

Represents the scattering properties within a communication system,
containing information about signal delay and associated scattering point groups\.

```csharp
public class Scattering : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.IScattering, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Scattering

Implements [DiGi\.Communication\.Interfaces\.IScattering](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscattering 'DiGi\.Communication\.Interfaces\.IScattering'), [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
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

Implements [Delay](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscattering.delay 'DiGi\.Communication\.Interfaces\.IScattering\.Delay')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.Scattering.ScatteringPointGroups'></a>

## Scattering\.ScatteringPointGroups Property

Gets the collection of scattering point groups, filtered to remove null entries and cloned for safety\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Classes.ScatteringPointGroup>? ScatteringPointGroups { get; }
```

Implements [ScatteringPointGroups](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscattering.scatteringpointgroups 'DiGi\.Communication\.Interfaces\.IScattering\.ScatteringPointGroups')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ScatteringPointGroup](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringPointGroup 'DiGi\.Communication\.Classes\.ScatteringPointGroup')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.Classes.ScatteringObject'></a>

## ScatteringObject Class

Represents an object that can be scattered within a scene, containing data such as the associated 3D mesh, a reference identifier, and the scattering coefficient\.

```csharp
public class ScatteringObject : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.IScatteringObject, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → ScatteringObject

Implements [DiGi\.Communication\.Interfaces\.IScatteringObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject 'DiGi\.Communication\.Interfaces\.IScatteringObject'), [DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
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

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(string,DiGi.Geometry.Spatial.Classes.Mesh3D,double)'></a>

## ScatteringObject\(string, Mesh3D, double\) Constructor

Initializes a new instance of the [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject') class\.

```csharp
public ScatteringObject(string? reference, DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, double scatteringCoefficient=1.0);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(string,DiGi.Geometry.Spatial.Classes.Mesh3D,double).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference identifier for the scattering object\. If null or whitespace, the unique identifier \(Guid\) is used instead\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(string,DiGi.Geometry.Spatial.Classes.Mesh3D,double).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The three\-dimensional mesh associated with the scattering object\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(string,DiGi.Geometry.Spatial.Classes.Mesh3D,double).scatteringCoefficient'></a>

`scatteringCoefficient` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The coefficient that determines the intensity of the scattering effect\. Defaults to 1\.0\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double)'></a>

## ScatteringObject\(Guid, string, Mesh3D, double\) Constructor

Initializes a new instance of the [ScatteringObject](DiGi.Communication.Classes.md#DiGi.Communication.Classes.ScatteringObject 'DiGi\.Communication\.Classes\.ScatteringObject') class\.

```csharp
public ScatteringObject(System.Guid guid, string? reference, DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, double scatteringCoefficient=1.0);
```
#### Parameters

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the scattering object\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional reference string; if null or whitespace, the GUID is used as the reference\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The three\-dimensional mesh associated with this scattering object\.

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringObject(System.Guid,string,DiGi.Geometry.Spatial.Classes.Mesh3D,double).scatteringCoefficient'></a>

`scatteringCoefficient` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The coefficient that determines the intensity of the scattering effect\. Defaults to 1\.0\.

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

<a name='DiGi.Communication.Classes.ScatteringObject.Mesh3D'></a>

## ScatteringObject\.Mesh3D Property

Gets a clone of the three\-dimensional mesh associated with this scattering object\.

```csharp
public DiGi.Geometry.Spatial.Classes.Mesh3D? Mesh3D { get; }
```

Implements [Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject.mesh3d 'DiGi\.Communication\.Interfaces\.IScatteringObject\.Mesh3D')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

<a name='DiGi.Communication.Classes.ScatteringObject.Reference'></a>

## ScatteringObject\.Reference Property

Gets the serializable reference object\.

```csharp
public string? Reference { get; }
```

Implements [Reference](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject.reference 'DiGi\.Communication\.Interfaces\.IScatteringObject\.Reference')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Communication.Classes.ScatteringObject.ScatteringCoefficient'></a>

## ScatteringObject\.ScatteringCoefficient Property

Gets the scattering coefficient of the object\.

```csharp
public double ScatteringCoefficient { get; }
```

Implements [ScatteringCoefficient](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringobject.scatteringcoefficient 'DiGi\.Communication\.Interfaces\.IScatteringObject\.ScatteringCoefficient')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Communication.Classes.ScatteringPointGroup'></a>

## ScatteringPointGroup Class

Represents a group of scattering points, associating a unique reference identifier with a collection of 3D point coordinates for serialization and communication purposes\.

```csharp
public class ScatteringPointGroup : DiGi.Core.Classes.SerializableObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ScatteringPointGroup

Implements [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject')
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

Implements [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile'), [DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
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

Implements [Location\_1](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile.location_1 'DiGi\.Communication\.Interfaces\.IScatteringProfile\.Location\_1')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Classes.ScatteringProfile.Location_2'></a>

## ScatteringProfile\.Location\_2 Property

Gets the second location associated with the scattering profile\.

```csharp
public DiGi.Geometry.Spatial.Classes.Point3D? Location_2 { get; }
```

Implements [Location\_2](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile.location_2 'DiGi\.Communication\.Interfaces\.IScatteringProfile\.Location\_2')

#### Property Value
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

<a name='DiGi.Communication.Classes.ScatteringProfile.Scatterings'></a>

## ScatteringProfile\.Scatterings Property

Gets the collection of scattering entries associated with this profile\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.Communication.Classes.Scattering>? Scatterings { get; private set; }
```

Implements [Scatterings](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile.scatterings 'DiGi\.Communication\.Interfaces\.IScatteringProfile\.Scatterings')

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Scattering](DiGi.Communication.Classes.md#DiGi.Communication.Classes.Scattering 'DiGi\.Communication\.Classes\.Scattering')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Communication.Classes.ScatteringProfile.Visible'></a>

## ScatteringProfile\.Visible Property

Gets a value indicating whether the scattering profile is visible\.

```csharp
public bool Visible { get; }
```

Implements [Visible](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile.visible 'DiGi\.Communication\.Interfaces\.IScatteringProfile\.Visible')

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation'></a>

## ScatteringProfileAntennasRelation Class

Represents a directional one\-to\-many relationship between a scattering profile and its associated antennas\.

```csharp
public class ScatteringProfileAntennasRelation : DiGi.Core.Relation.Classes.OneToManyDirectionalRelation<DiGi.Communication.Interfaces.IScatteringProfile, DiGi.Communication.Interfaces.IAntenna>, DiGi.Communication.Interfaces.ICommunicationRelation, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanyrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2')[DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetomanydirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\`2') → ScatteringProfileAntennasRelation

Implements [DiGi\.Communication\.Interfaces\.ICommunicationRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationrelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
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

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile associated with this relation\.

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation.ScatteringProfileAntennasRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_1'></a>

`antenna_1` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

The first antenna to be associated with the scattering profile\.

<a name='DiGi.Communication.Classes.ScatteringProfileAntennasRelation.ScatteringProfileAntennasRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IAntenna,DiGi.Communication.Interfaces.IAntenna).antenna_2'></a>

`antenna_2` [DiGi\.Communication\.Interfaces\.IAntenna](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iantenna 'DiGi\.Communication\.Interfaces\.IAntenna')

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

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Relation\.Classes\.Relation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2')[DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.relation-2 'DiGi\.Core\.Relation\.Classes\.Relation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2')[DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonerelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\`2') → [DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2')[DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.classes.onetoonebidirectionalrelation-2 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\`2') → ScatteringProfileMultipathPowerDelayProfileRelation

Implements [DiGi\.Communication\.Interfaces\.ICommunicationRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationrelation 'DiGi\.Communication\.Interfaces\.ICommunicationRelation'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.core.relation.interfaces.irelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
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

`scatteringProfile` [DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')

The scattering profile to be associated in the relation\.

<a name='DiGi.Communication.Classes.ScatteringProfileMultipathPowerDelayProfileRelation.ScatteringProfileMultipathPowerDelayProfileRelation(DiGi.Communication.Interfaces.IScatteringProfile,DiGi.Communication.Interfaces.IMultipathPowerDelayProfile).multipathPowerDelayProfile'></a>

`multipathPowerDelayProfile` [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile')

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

<a name='DiGi.Communication.Classes.SimpleMultipathPowerDelayProfile'></a>

## SimpleMultipathPowerDelayProfile Class

Represents a simple multipath power delay profile that maps specific time delays to their corresponding power levels\.

```csharp
public class SimpleMultipathPowerDelayProfile : DiGi.Core.Classes.GuidObject, DiGi.Communication.Interfaces.ISimpleMultipathPowerDelayProfile, DiGi.Communication.Interfaces.IMultipathPowerDelayProfile, DiGi.Communication.Interfaces.ICommunicationGuidObject, DiGi.Communication.Interfaces.ICommunicationSerializableObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → SimpleMultipathPowerDelayProfile

Implements [DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile'), [DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.imultipathpowerdelayprofile 'DiGi\.Communication\.Interfaces\.IMultipathPowerDelayProfile'), [DiGi\.Communication\.Interfaces\.ICommunicationGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationguidobject 'DiGi\.Communication\.Interfaces\.ICommunicationGuidObject'), [DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationserializableobject 'DiGi\.Communication\.Interfaces\.ICommunicationSerializableObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')
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

Implements [Delays](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile.delays 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile\.Delays')

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

Implements [GetPower\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.isimplemultipathpowerdelayprofile.getpower#digi-communication-interfaces-isimplemultipathpowerdelayprofile-getpower(system-double) 'DiGi\.Communication\.Interfaces\.ISimpleMultipathPowerDelayProfile\.GetPower\(System\.Double\)')

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The power value corresponding to the given delay, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the values are not initialized or the delay is not found\.