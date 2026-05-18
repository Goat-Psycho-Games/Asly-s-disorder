# Sistema de diálogos

## Descripción

Los diálogos permiten al jugador interactuar con NPCs, obtener información, tomar decisiones y avanzar en la narrativa.

## Características principales

- Diálogos lineales y con ramificación.
- Opciones de respuesta del jugador.
- Las opciones pueden afectar a la cordura, NPCs y eventos futuros.
- Los diálogos pueden variar según la cordura actual.
- Los diálogos pueden variar según el estado del mundo.
- Posibilidad de diálogos con "sin respuesta" (el protagonista no dice nada).

## Flujo de diálogo

```
NPC habla
  → Texto aparece en pantalla
  → [Opciones del jugador si las hay]
    → Opción elegida
      → Consecuencia (cordura, evento, estado NPC)
      → NPC responde
      → Continúa o termina
```

## Condiciones de variación

- Estado de cordura.
- Objetos en el inventario.
- Eventos vistos previamente.
- Estado del mundo (normal/creepy).
- Decisiones previas con ese NPC.

## Ver también

- [Dialogue_System técnico](../../Technical/Systems/Dialogue_System.md)
- [Dialogue_Template.md](../../Narrative/Dialogues/Dialogue_Template.md)
- [Dialogue_Style_Guide.md](../../Narrative/Dialogues/Dialogue_Style_Guide.md)
