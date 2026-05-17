# Guía de estilo de diálogos

## Tono general

- Los diálogos deben sentirse reales y humanos, no teatrales.
- El protagonista habla poco. Sus palabras tienen peso.
- Los NPCs pueden tener diálogos que cambian según la cordura del jugador.
- Evitar exposición innecesaria ("como sabes, tú y yo somos...").

## Reglas de escritura

- Frases cortas y directas.
- Sin relleno ni verbosidad.
- El subtexto importa más que el texto explícito.
- Cada línea de diálogo debe tener un propósito.

## Variantes de diálogo

Los NPCs pueden tener variantes según:
- Estado de cordura del jugador.
- Decisiones previas tomadas.
- Objetos en el inventario.
- Estado del mundo (normal/creepy).
- Si el jugador ha hablado con ellos antes.

## Formato de diálogo en documento

```md
## [ID_Diálogo]: [Nombre de la conversación]

**NPC:** [Nombre del NPC]  
**Zona:** [Área]  
**Condición de activación:** TBD  

### Variante A (cordura > 60)

> NPC: "..."
> Protagonista: "..."

### Variante B (cordura 20-60)

> NPC: "..."
> Protagonista: "..."

### Variante C (mundo creepy)

> NPC: "..."
```
