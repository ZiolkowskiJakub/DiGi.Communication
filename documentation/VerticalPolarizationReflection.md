# Vertical Polarization Reflection Coefficient Calculator

## Overview
This document outlines the C# implementation for calculating the complex reflection coefficient for vertical polarization, based on the provided multi-ellipsoidal propagation model procedure. The implementation strictly uses `System.Numerics.Complex` for precise complex number arithmetic and avoids implicit typing (`var`) to adhere to our strict C# coding guidelines in Visual Studio 2026. This method is optimized for integration into engineering plugins (such as those for Revit, Rhino, or Dynamo).

## Mathematical Foundation
According to the procedure, the vertical polarization reflection coefficient ($\Gamma_{kl}$) is derived from the formula:

$$\Gamma_{kl}=rac{\epsilon_{k}^{\prime}\sin\gamma_{kl}-\sqrt{\epsilon_{k}^{\prime}-\cos^{2}\gamma_{kl}}}{\epsilon_{k}^{\prime}\sin\gamma_{kl}+\sqrt{\epsilon_{k}^{\prime}-\cos^{2}\gamma_{kl}}}$$

Where the relative complex electrical permittivity ($\epsilon_{k}^{\prime}$) is defined as:

$$\epsilon_{k}^{\prime}=\epsilon_{wk}-j60\lambda\sigma_{k}$$

## Input Parameters
The method accepts the following inputs, fully converting standard SI inputs to match the empirical formula requirements:
*   `frequencyHz` (double): The frequency of the propagating electromagnetic wave in Hertz (Hz). Note that the internal calculation converts this to MHz for the wavelength formula $\lambda = 300 / f[MHz]$.
*   `relativePermittivity` (double): The relative electrical permittivity ($\epsilon_{wk}$) of the object subset (dimensionless).
*   `conductivity` (double): The electrical conductivity ($\sigma_{k}$) of the object subset in Siemens per meter (S/m).
*   `incidenceAngleRadians` (double): The angle of incidence ($\gamma_{kl}$) of the ray on the cell plane, expressed in radians.

## C# Implementation

```csharp
using System;
using System.Numerics;

public static class PropagationCalculations
{
    /// <summary>
    /// Calculates the complex reflection coefficient for vertical polarization.
    /// </summary>
    /// <param name="frequencyHz">Frequency of the propagating electromagnetic wave in Hertz (Hz).</param>
    /// <param name="relativePermittivity">Relative electrical permittivity of the object subset (dimensionless).</param>
    /// <param name="conductivity">Electrical conductivity of the object subset in Siemens per meter (S/m).</param>
    /// <param name="incidenceAngleRadians">Angle of incidence of the ray on the cell plane in radians.</param>
    /// <returns>Complex reflection coefficient for vertical polarization.</returns>
    public static Complex CalculateVerticalPolarizationReflection(
        double frequencyHz, 
        double relativePermittivity, 
        double conductivity, 
        double incidenceAngleRadians)
    {
        // 1. Convert frequency from Hz to MHz to match the provided propagation formula.
        double frequencyMHz = frequencyHz / 1_000_000.0;
        
        // 2. Calculate wavelength (lambda) in meters.
        double wavelength = 300.0 / frequencyMHz;
        
        // 3. Calculate relative complex electrical permittivity (epsilon_k').
        // The formula is: epsilon_k' = epsilon_wk - j * 60 * lambda * sigma_k
        double imaginaryPart = -60.0 * wavelength * conductivity;
        Complex complexPermittivity = new Complex(relativePermittivity, imaginaryPart);
        
        // 4. Calculate trigonometric values for the incidence angle (gamma).
        double sinGamma = Math.Sin(incidenceAngleRadians);
        double cosGamma = Math.Cos(incidenceAngleRadians);
        
        // 5. Calculate the first main term: epsilon_k' * sin(gamma)
        Complex term1 = complexPermittivity * sinGamma;
        
        // 6. Calculate the second main term: sqrt(epsilon_k' - cos^2(gamma))
        double cosGammaSquared = Math.Pow(cosGamma, 2.0);
        Complex termUnderSqrt = complexPermittivity - cosGammaSquared;
        Complex term2 = Complex.Sqrt(termUnderSqrt);
        
        // 7. Calculate final vertical polarization reflection coefficient (Gamma_kl).
        // The formula is: (term1 - term2) / (term1 + term2)
        Complex numerator = term1 - term2;
        Complex denominator = term1 + term2;
        
        Complex reflectionCoefficient = numerator / denominator;
        
        return reflectionCoefficient;
    }
}
```
