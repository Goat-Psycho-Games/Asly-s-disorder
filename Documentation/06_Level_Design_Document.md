# Level Design Document

## Filosofía de diseño de niveles

- Scroll lateral sin salto.
- Exploración narrativa como motor del avance.
- Cada área puede cambiar según cordura, decisiones y estado del mundo.
- Los puzzles y eventos están integrados en el entorno.

## Áreas del juego

TBD

## Estados posibles de cada área

| Estado    | Descripción                                             |
| --------- | ------------------------------------------------------- |
| Normal    | Mundo real, iluminación natural, NPCs presentes.        |
| Distorted | Cambios sutiles, objetos fuera de lugar, sonidos raros. |
| Creepy    | Mundo alternativo activo, zona transformada.            |
| Locked    | Area bloqueada por decisiones o estado de cordura.      |
| Completed | Área completada, sin más eventos activos.               |

## Estructura de área en Unity

```
Area_Name/
├── Normal_Version
├── Distorted_Props
├── Creepy_Version
├── Puzzle_Normal
├── Puzzle_Creepy
└── Monsters
```

## Plantilla de área

**ID:** AREA_XXX  
**Nombre:** TBD  
**Zona:** TBD  
**Estados posibles:** Normal, Distorted, Creepy  
**Personajes presentes:** TBD  
**Puzzles:** TBD  
**Eventos de cordura:** TBD  
**Conexiones con otras áreas:** TBD  
**Música/ambience:** TBD  

## Ver también

- [Area_States](../Design/World/Area_States.md)
- [World_Transition](../Design/World/World_Transition.md)
- [Scene_Management](../Technical/Architecture/Scene_Management.md)
