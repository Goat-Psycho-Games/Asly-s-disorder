# Sistema de cordura (técnico)

## Descripción

El SanityManager gestiona el valor de cordura interno y coordina los efectos y eventos relacionados.

## Componentes

| Componente                | Descripción                                               |
| ------------------------- | --------------------------------------------------------- |
| SanityManager             | Gestiona el valor de cordura. Singleton.                  |
| SanityEventManager        | Evalúa y dispara eventos de cordura según condiciones.    |
| ScreenDistortionController| Aplica efectos visuales según el rango de cordura.        |
| WorldStateManager         | Coordina el estado del mundo según la cordura.            |

## SanityManager

```csharp
public class SanityManager : MonoBehaviour
{
    public float CurrentSanity { get; private set; } // 0-100
    public SanityState CurrentState { get; private set; }

    public void ModifySanity(float amount) { }
    public SanityState GetCurrentState() { }
}

public enum SanityState
{
    Stable,    // 80-100
    Uneasy,    // 60-79
    Distorted, // 40-59
    Broken,    // 20-39
    OtherWorld // 0-19
}
```

## SanityEventManager

Evalúa periódicamente o en eventos clave si se cumplen las condiciones de cada SanityEvent ScriptableObject y los dispara si corresponde.

## ScreenDistortionController

Aplica post-processing o shaders según el rango de cordura.

## Ver también

- [08_Sanity_System_Document.md](../../Documentation/08_Sanity_System_Document.md)
- [Sanity_Overview.md](../../Design/Sanity/Sanity_Overview.md)
- [Event_System.md](../Architecture/Event_System.md)
- [ScriptableObjects.md](../Data/ScriptableObjects.md)
