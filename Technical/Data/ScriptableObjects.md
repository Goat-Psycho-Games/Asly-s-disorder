# ScriptableObjects

## Descripción

Los ScriptableObjects se usan para almacenar datos de juego de forma desacoplada del código.

## Tipos de ScriptableObjects del proyecto

| Tipo              | Carpeta                              | Descripción                          |
| ----------------- | ------------------------------------ | ------------------------------------ |
| DialogueData      | `ScriptableObjects/Dialogues/`       | Datos de un diálogo.                 |
| ItemData          | `ScriptableObjects/Items/`           | Datos de un objeto del inventario.   |
| PuzzleData        | `ScriptableObjects/Puzzles/`         | Datos de un puzzle.                  |
| SanityEventData   | `ScriptableObjects/SanityEvents/`    | Condiciones y efectos de un evento.  |
| NPCData           | `ScriptableObjects/NPCs/`            | Datos de un NPC.                     |
| LevelData         | `ScriptableObjects/Levels/`          | Datos de un nivel/área.              |

## Ventajas de este enfoque

- Los datos se pueden editar desde el Inspector de Unity sin modificar código.
- Fácil de crear nuevos contenidos (nuevos puzzles, NPCs, eventos) sin programar.
- Permite balanceo rápido.

## Ejemplo: SanityEventData

```
SanityEventData:
- id: "SAN_EVENT_001"
- eventName: "Aparición en el pasillo"
- minSanity: 20
- maxSanity: 40
- triggerProbability: 0.35
- requiredFlags: [...]
- sanityEffect: -5
- isRepeatable: false
- narrativeImportance: Medium
```
