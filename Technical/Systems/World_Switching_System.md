# Sistema de cambio de mundo (técnico)

## Descripción

El sistema de cambio de mundo gestiona la activación y desactivación de los objetos de cada versión del área según el estado actual.

## Componentes

| Componente              | Descripción                                              |
| ----------------------- | -------------------------------------------------------- |
| AreaStateManager        | Gestiona el estado de cada área (Normal/Creepy/etc.).    |
| WorldTransitionManager  | Gestiona la transición visual entre estados.             |
| AreaController          | Componente por área que controla sus objetos activos.    |

## AreaController

Cada área tiene un `AreaController` con referencias a:
- `normalVersion` (GameObject)
- `distortedProps` (GameObject)
- `creepyVersion` (GameObject)
- `puzzleNormal` (GameObject)
- `puzzleCreepy` (GameObject)
- `monsters` (GameObject)

Activa/desactiva según el estado.

## WorldTransitionManager

Gestiona la transición gradual entre estados:
1. Fade/distorsión de entrada.
2. Intercambio de objetos activos.
3. Fade/distorsión de salida.

## AreaStateManager

Mantiene un diccionario `areaID -> AreaState` y persiste en el save.

## Ver también

- [09_World_Switching_Document.md](../../Documentation/09_World_Switching_Document.md)
- [Area_States.md](../../Design/World/Area_States.md)
- [Save_System.md](Save_System.md)
