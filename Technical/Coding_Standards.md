# Estándares de código

## Lenguaje

C# con Unity.

## Convenciones de nombres

| Elemento            | Convención         | Ejemplo                     |
| ------------------- | ------------------ | --------------------------- |
| Clases              | PascalCase         | `SanityManager`             |
| Métodos             | PascalCase         | `ModifySanity()`            |
| Variables privadas  | _camelCase         | `_currentSanity`            |
| Variables públicas  | camelCase          | `moveSpeed`                 |
| Propiedades         | PascalCase         | `CurrentSanity`             |
| Constantes          | UPPER_SNAKE_CASE   | `MAX_SANITY`                |
| Interfaces          | I + PascalCase     | `IInteractable`             |
| Enums               | PascalCase         | `SanityState`               |
| ScriptableObjects   | PascalCase + Data  | `SanityEventData`           |

## Estructura de un script

```csharp
// 1. Usings
using UnityEngine;

// 2. Namespace (opcional, TBD)
namespace PsychoGames.Systems { }

// 3. Clase
public class ExampleClass : MonoBehaviour
{
    // 4. Constantes
    // 5. Variables serializadas (Inspector)
    // 6. Variables privadas
    // 7. Propiedades
    // 8. Unity callbacks (Awake, Start, Update...)
    // 9. Métodos públicos
    // 10. Métodos privados
}
```

## Reglas generales

- Un script = una responsabilidad.
- Evitar lógica de juego en Update(). Usar eventos.
- No usar `FindObjectOfType` en tiempo de ejecución. Usar referencias o inyección.
- Preferir eventos/callbacks sobre polling.
- Null checks en referencias obtenidas dinámicamente.

## Control de versiones

- Commits pequeños y descriptivos.
- Formato de commit: `[Sistema] Descripción breve`
- Ejemplo: `[SanitySystem] Añadir evaluación de eventos por rango`

## Ver también

- [Architecture/](Architecture/)
- [Systems/](Systems/)
