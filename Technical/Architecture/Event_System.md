# Sistema de eventos

## Descripción

El sistema de eventos permite la comunicación entre sistemas sin acoplarlos directamente.

## Patrón recomendado

Usar un sistema de eventos basado en acciones de C# o ScriptableObjects.

## Eventos principales del juego

| Evento                  | Descripción                                           |
| ----------------------- | ----------------------------------------------------- |
| OnSanityChanged         | Se dispara cuando cambia el valor de cordura.         |
| OnWorldStateChanged     | Se dispara cuando el área cambia de estado.           |
| OnDecisionMade          | Se dispara cuando el jugador toma una decisión.       |
| OnItemPickedUp          | Se dispara cuando el jugador recoge un objeto.        |
| OnDialogueStarted       | Se dispara al iniciar un diálogo.                     |
| OnDialogueEnded         | Se dispara al terminar un diálogo.                    |
| OnPuzzleSolved          | Se dispara cuando se resuelve un puzzle.              |
| OnSanityEventTriggered  | Se dispara cuando se activa un evento de cordura.     |
| OnSceneLoaded           | Se dispara cuando se carga una escena.                |

## Implementación sugerida

TBD — Decidir entre:
- C# events / delegates.
- ScriptableObject-based event system.
- Unity Events.

## Ver también

- [Game_Manager.md](Game_Manager.md)
- [Sanity_System.md](../Systems/Sanity_System.md)
