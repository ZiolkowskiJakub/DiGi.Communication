#### [DiGi\.Communication](DiGi.Communication.Overview.md 'DiGi\.Communication\.Overview')

## DiGi\.Communication\.Obselete\.Convert Namespace
### Classes

<a name='DiGi.Communication.Obselete.Convert.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_)'></a>

## Convert\.ToPropagation\_PropagationModel\(this GeometricalPropagationModel, double, Polarization, MaterialProperties, AntennaCharacteristic, AntennaCharacteristic, AntennaCharacteristic, AntennaCharacteristic, Dictionary\<string,MaterialProperties\>\) Method

Converts a geometrical propagation model into the input data of the multi\-ellipsoidal propagation model\.

The transmitter-receiver distance is taken from the locations of the transmitting and receiving antennas assigned to the first simple multipath power delay profile of the geometrical propagation model. The mesh cells of the scattering objects are expressed in the model coordinate system: the transmitter at the origin, the OX axis towards the receiver and the OZ axis as close to the world vertical as possible. The fractional powers of the power delay profile are normalized so they sum to 1.

The frequency, polarization, electrical material properties and antenna characteristics are not part of the geometrical propagation model and have to be provided separately.

```csharp
public static DiGi.Communication.Obselete.Classes.PropagationModel? ToPropagation_PropagationModel(this DiGi.Communication.Classes.GeometricalPropagationModel? geometricalPropagationModel, double frequency, DiGi.Communication.Enums.Polarization polarization, DiGi.Communication.Obselete.Classes.MaterialProperties? materialProperties, DiGi.Communication.AntennaCharacteristic? receivingDirectionalCharacteristic, DiGi.Communication.AntennaCharacteristic? receivingOmnidirectionalCharacteristic, DiGi.Communication.AntennaCharacteristic? transmittingDirectionalCharacteristic, DiGi.Communication.AntennaCharacteristic? transmittingOmnidirectionalCharacteristic, System.Collections.Generic.Dictionary<string,DiGi.Communication.Obselete.Classes.MaterialProperties>? materialPropertiesDictionary=null);
```
#### Parameters

<a name='DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).geometricalPropagationModel'></a>

`geometricalPropagationModel` [GeometricalPropagationModel](DiGi.Communication.Classes.md#DiGi.Communication.Classes.GeometricalPropagationModel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

Geometrical propagation model holding the antennas, the scattering objects and the multipath power delay profile\.

<a name='DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).frequency'></a>

`frequency` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Frequency f of the propagating electromagnetic wave \[MHz\]\.

<a name='DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).polarization'></a>

`polarization` [Polarization](DiGi.Communication.Enums.md#DiGi.Communication.Enums.Polarization 'DiGi\.Communication\.Enums\.Polarization')

Polarization type of the propagating electromagnetic wave\.

<a name='DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).materialProperties'></a>

`materialProperties` [MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')

Default electrical material properties applied to the mesh cells of the scattering objects\.

<a name='DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).receivingDirectionalCharacteristic'></a>

`receivingDirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized reception characteristic g\(theta, phi\) of the directional receiving antenna\.

<a name='DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).receivingOmnidirectionalCharacteristic'></a>

`receivingOmnidirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized reception characteristic g\_0\(theta, phi\) of the omnidirectional receiving antenna\.

<a name='DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).transmittingDirectionalCharacteristic'></a>

`transmittingDirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized radiation characteristic g\_T\(theta, phi\) of the directional transmitting antenna\.

<a name='DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).transmittingOmnidirectionalCharacteristic'></a>

`transmittingOmnidirectionalCharacteristic` [AntennaCharacteristic\(double, double\)](DiGi.Communication.md#DiGi.Communication.AntennaCharacteristic(double,double) 'DiGi\.Communication\.AntennaCharacteristic\(double, double\)')

Normalized radiation characteristic g\_T0\(theta, phi\) of the omnidirectional transmitting antenna\.

<a name='DiGi.Communication.Obselete.Convert.Convert.ToPropagation_PropagationModel(thisDiGi.Communication.Classes.GeometricalPropagationModel,double,DiGi.Communication.Enums.Polarization,DiGi.Communication.Obselete.Classes.MaterialProperties,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,DiGi.Communication.AntennaCharacteristic,System.Collections.Generic.Dictionary_string,DiGi.Communication.Obselete.Classes.MaterialProperties_).materialPropertiesDictionary'></a>

`materialPropertiesDictionary` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[MaterialProperties](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.MaterialProperties 'DiGi\.Communication\.Obselete\.Classes\.MaterialProperties')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

Optional electrical material properties per scattering object keyed by the scattering object reference\. Scattering objects without an entry use the default material properties\.

#### Returns
[PropagationModel](DiGi.Communication.Obselete.Classes.md#DiGi.Communication.Obselete.Classes.PropagationModel 'DiGi\.Communication\.Obselete\.Classes\.PropagationModel')  
Input data of the multi\-ellipsoidal propagation model or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') for invalid input\.