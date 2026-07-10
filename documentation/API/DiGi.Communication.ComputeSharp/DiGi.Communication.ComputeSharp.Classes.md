#### [DiGi\.Communication\.ComputeSharp](DiGi.Communication.ComputeSharp.Overview.md 'DiGi\.Communication\.ComputeSharp\.Overview')

## DiGi\.Communication\.ComputeSharp\.Classes Namespace
### Classes

<a name='DiGi.Communication.ComputeSharp.Classes.ScatteringSolver'></a>

## ScatteringSolver Class

Provides functionality to solve scattering calculations within a communication system,
integrating geometrical propagation models and various scattering profiles\.

```csharp
public class ScatteringSolver : DiGi.Communication.Interfaces.ICommunicationObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ScatteringSolver

Implements [DiGi\.Communication\.Interfaces\.ICommunicationObject](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.icommunicationobject 'DiGi\.Communication\.Interfaces\.ICommunicationObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISolver](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver 'DiGi\.Core\.Interfaces\.ISolver'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Properties

<a name='DiGi.Communication.ComputeSharp.Classes.ScatteringSolver.GeometricalPropagationModel'></a>

## ScatteringSolver\.GeometricalPropagationModel Property

Gets or sets the geometrical propagation model used by the scattering solver\.

```csharp
public DiGi.Communication.Classes.GeometricalPropagationModel? GeometricalPropagationModel { get; set; }
```

#### Property Value
[DiGi\.Communication\.Classes\.GeometricalPropagationModel](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.geometricalpropagationmodel 'DiGi\.Communication\.Classes\.GeometricalPropagationModel')

<a name='DiGi.Communication.ComputeSharp.Classes.ScatteringSolver.ScatteringProfiles'></a>

## ScatteringSolver\.ScatteringProfiles Property

Gets a cloned list of scattering profiles, filtering out any null entries\.

```csharp
public System.Collections.Generic.List<DiGi.Communication.Interfaces.IScatteringProfile>? ScatteringProfiles { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Communication\.Interfaces\.IScatteringProfile](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.interfaces.iscatteringprofile 'DiGi\.Communication\.Interfaces\.IScatteringProfile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Communication.ComputeSharp.Classes.ScatteringSolver.ScatteringSolverOptions'></a>

## ScatteringSolver\.ScatteringSolverOptions Property

Gets or sets the configuration options for the scattering solver\.

```csharp
public DiGi.Communication.Classes.ScatteringSolverOptions? ScatteringSolverOptions { get; set; }
```

#### Property Value
[DiGi\.Communication\.Classes\.ScatteringSolverOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.communication.classes.scatteringsolveroptions 'DiGi\.Communication\.Classes\.ScatteringSolverOptions')
### Methods

<a name='DiGi.Communication.ComputeSharp.Classes.ScatteringSolver.Solve()'></a>

## ScatteringSolver\.Solve\(\) Method

Executes the solving operation\.

```csharp
public bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the solver successfully executed; otherwise, `false`\.