# Sistema de interacción

## Descripción

El sistema de interacción permite al jugador interactuar con objetos y NPCs del entorno.

## Funcionamiento

1. El jugador entra en el rango de un objeto interactuable.
2. El `InteractionDetector` detecta el objeto.
3. Al pulsar el botón de interacción, se ejecuta `Interact()` en el objeto.
4. Cada objeto implementa su propia lógica de interacción.

## Componentes

| Componente           | Descripción                                        |
| -------------------- | -------------------------------------------------- |
| InteractionDetector  | Detecta objetos interactuables en rango.           |
| IInteractable        | Interfaz que implementan los objetos interactuables. |
| InteractableBase     | Clase base con funcionalidad común.                |

## Interfaz IInteractable

```csharp
public interface IInteractable
{
    void Interact(PlayerController player);
    bool CanInteract();
}
```

## Ver también

- [Interaction.md](../../Design/Mechanics/Interaction.md)
- [Player_Controller.md](Player_Controller.md)
