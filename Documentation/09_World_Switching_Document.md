# World Switching Document

## Objetivo del sistema

Crear dos versiones del mundo que coexistan y se conecten mediante la cordura del protagonista y sus decisiones. El jugador no debe percibir el cambio como una mecánica artificial sino como una consecuencia natural de sus acciones.

## Estados del mundo

| Estado    | Descripción                                                  |
| --------- | ------------------------------------------------------------ |
| Normal    | El mundo real. Iluminación natural, NPCs presentes.          |
| Distorted | Transición. Cambios sutiles pero perceptibles.               |
| Creepy    | Mundo alternativo completamente activo.                      |

## Condiciones de transición

- Cordura crítica (0-19).
- Decisiones específicas con peso narrativo alto.
- Eventos narrativos predefinidos.
- Puzzles completados en cierto orden.

## Reversibilidad

- Algunas transiciones son temporales.
- Algunas transiciones son permanentes para esa partida.
- El mundo creepy no siempre se puede abandonar.

## Implementación en Unity

No son dos juegos separados. Es un sistema de **estados de área**.

```
Area: Hospital_Pasillo_01

Estados posibles:
- Normal
- Distorted
- Creepy
- Locked
- Completed
```

Cada área puede cambiar dependiendo de:

- Cordura actual.
- Decisiones tomadas.
- NPCs vivos/desaparecidos.
- Puzzles completados.
- Objetos recogidos.
- Eventos vistos.

## Estructura de objetos en Unity

```
Hospital_Pasillo_01/
├── Normal_Version
├── Distorted_Props
├── Creepy_Version
├── Puzzle_Normal
├── Puzzle_Creepy
└── Monsters
```

## Ver también

- [Area_States](../Design/World/Area_States.md)
- [World_Transition](../Design/World/World_Transition.md)
- [Normal_World](../Design/World/Normal_World.md)
- [Creepy_World](../Design/World/Creepy_World.md)
- [World_Switching_System técnico](../Technical/Systems/World_Switching_System.md)
- [Normal_vs_Creepy_World — Arte](../Art_Bible/07_Normal_vs_Creepy_World.md)
