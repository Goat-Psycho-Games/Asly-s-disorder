# Sistema de puzzles (técnico)

## Descripción

El sistema de puzzles gestiona el estado, las condiciones y las recompensas de cada puzzle del juego.

## Componentes

| Componente     | Descripción                                              |
| -------------- | -------------------------------------------------------- |
| PuzzleManager  | Gestiona el estado de todos los puzzles. Singleton.      |
| PuzzleBase     | Clase base para todos los puzzles.                       |
| PuzzleData     | ScriptableObject con los datos de un puzzle.             |
| PuzzleState    | Enum: Locked, Active, Solved, Unavailable.               |

## PuzzleBase

```csharp
public abstract class PuzzleBase : MonoBehaviour
{
    public PuzzleData Data;
    public PuzzleState State { get; protected set; }

    public abstract void Activate();
    public abstract void CheckSolution();
    protected virtual void OnSolved() { }
}
```

## Versiones de puzzle

Cada puzzle puede tener versiones Normal y Creepy. El `PuzzleManager` consulta al `SanityManager` para determinar qué versión activar.

## ScriptableObject PuzzleData

- ID del puzzle.
- Tipo de puzzle.
- Condiciones de activación.
- Recompensa.
- Efecto en cordura al resolver.

## Ver también

- [Puzzle_Overview.md](../../Design/Puzzles/Puzzle_Overview.md)
- [Puzzle_Template.md](../../Design/Puzzles/Puzzle_Template.md)
- [ScriptableObjects.md](../Data/ScriptableObjects.md)
