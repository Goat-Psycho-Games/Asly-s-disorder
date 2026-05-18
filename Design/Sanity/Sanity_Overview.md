# Sistema de cordura — Visión general

## Descripción

El sistema de cordura es el corazón del juego. Es un valor interno (0-100) que el jugador no ve directamente pero que afecta a todo el juego.

## Principios

- La cordura no se muestra. Se siente.
- Los cambios deben ser perceptibles pero no siempre previsibles.
- El sistema debe generar tensión, no frustración.
- Debe recompensar la atención y la exploración.

## Componentes del sistema

1. **SanityManager**: gestiona el valor de cordura.
2. **SanityEventManager**: gestiona los eventos que se disparan según rangos.
3. **ScreenDistortionController**: gestiona los efectos visuales.
4. **WorldStateManager**: gestiona el estado del mundo según la cordura.

## Integración con otros sistemas

- Sistema de decisiones: las decisiones afectan a la cordura.
- Sistema de diálogos: los diálogos cambian según la cordura.
- Sistema de puzzles: los puzzles tienen versiones según la cordura.
- Sistema de mundo: la cordura crítica activa el mundo creepy.

## Ver también

- [Sanity_Ranges.md](Sanity_Ranges.md)
- [Sanity_Events.md](Sanity_Events.md)
- [Sanity_Actions.md](Sanity_Actions.md)
- [Sanity_Balancing.md](Sanity_Balancing.md)
- [08_Sanity_System_Document.md](../../Documentation/08_Sanity_System_Document.md)
