# Estados de área

## Descripción

Cada área del juego puede tener múltiples estados que determinan qué está activo en ella.

## Estados posibles

| Estado    | Descripción                                                        |
| --------- | ------------------------------------------------------------------ |
| Normal    | Estado base. Mundo real, NPCs presentes.                           |
| Distorted | Cambios sutiles. Transición al mundo creepy en curso.              |
| Creepy    | Mundo alternativo activo en esta área.                             |
| Locked    | Área bloqueada. No se puede acceder.                               |
| Completed | Área completada. Sin más eventos activos.                          |

## Condiciones de cambio de estado

El estado de un área puede cambiar por:
- Rango de cordura.
- Decisiones tomadas.
- NPCs vivos/desaparecidos.
- Puzzles completados.
- Objetos recogidos.
- Eventos vistos.

## Estructura en Unity

```
Nombre_Area/
├── Normal_Version    (activo por defecto)
├── Distorted_Props   (activo en Distorted y Creepy)
├── Creepy_Version    (activo en Creepy)
├── Puzzle_Normal     (activo en Normal y Distorted)
├── Puzzle_Creepy     (activo en Creepy)
└── Monsters          (activo según condiciones de cordura)
```

## Lista de áreas y estados

TBD

## Ver también

- [World_Transition.md](World_Transition.md)
- [AreaStateManager](../../Technical/Systems/World_Switching_System.md)
