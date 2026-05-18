# Sistema de cordura

## Objetivo del sistema

Crear un sistema oculto que modifique la experiencia del jugador sin ser una barra visible tradicional. La cordura debe influir en eventos, diálogos, aparición de monstruos, distorsiones visuales, comportamiento de NPCs, puzzles y cambios de mundo.

## Reglas principales

- La cordura no se muestra directamente al jugador.
- El jugador debe notar sus efectos por el entorno.
- No debe sentirse aleatorio injusto.
- Debe generar tensión, no frustración.
- Debe afectar a la historia y a la rejugabilidad.

## Rangos de cordura

| Rango  | Estado      | Efectos                                                        |
| ------ | ----------- | -------------------------------------------------------------- |
| 80-100 | Estable     | Mundo normal, eventos normales.                                |
| 60-79  | Inquietud   | Pequeños sonidos, cambios sutiles.                             |
| 40-59  | Alteración  | Distorsiones leves, NPCs raros, pistas falsas.                 |
| 20-39  | Ruptura     | Apariciones, puzzles alterados, pantalla distorsionada.        |
| 0-19   | Colapso     | Cambio al mundo creepy.                                        |

## Categorías de estado mental

```
Stable
Uneasy
Distorted
Broken
OtherWorld
```

## Eventos posibles por rango

### Cordura alta (80-100)

- Diálogos normales.
- Puzzles en versión lógica.
- NPCs ayudan o dan pistas fiables.

### Cordura media (40-79)

- Pequeños cambios visuales.
- Sonidos fuera de lugar.
- Frases diferentes de NPCs.
- Objetos que parecen moverse.

### Cordura baja (20-39)

- Monstruos o sombras.
- Pistas contradictorias.
- Puzzles con solución alternativa.
- Cambios de habitación.
- Distorsión de cámara o UI.

### Cordura crítica (0-19)

- Transición al mundo creepy.
- Zonas bloqueadas o alteradas.
- NPCs transformados o ausentes.
- Nuevas rutas.
- Puzzles adaptados al mundo alternativo.

## Acciones que afectan a la cordura

### Bajan cordura

- Presenciar eventos traumáticos.
- Tomar decisiones egoístas o violentas.
- Fallar ciertos puzzles.
- Ignorar a ciertos NPCs.
- Entrar en zonas oscuras.
- Usar objetos relacionados con el mundo creepy.
- Leer documentos perturbadores.

### Suben o estabilizan cordura

- Ayudar a NPCs.
- Resolver puzzles de forma empática.
- Encontrar recuerdos importantes.
- Usar ciertos objetos de calma.
- Elegir opciones coherentes con la personalidad del protagonista.

## Sistema de eventos de cordura

Ejemplo de evento:

```
Evento: Aparición en el pasillo
Condiciones:
- Cordura entre 20 y 40
- El jugador ya habló con NPC_A
- No ha recogido el objeto "Foto rota"
- Está en la zona "Colegio"
- Probabilidad: 35%
```

## Plantilla de evento de cordura

```md
# Evento de cordura: [Nombre]

## ID
SAN_EVENT_XXX

## Nombre
[Nombre del evento]

## Zona
[Área — Sub-zona]

## Condiciones
- Cordura entre X y Y.
- [Condición narrativa].
- [Condición de objeto o NPC].
- No haber visto este evento antes.

## Efecto
- [Efecto visual/sonoro].
- [Efecto en cordura].
- [Efecto narrativo].

## Repetible
Sí / No.

## Importancia narrativa
Alta / Media / Baja.
```

## Ver también

- [Sanity_Overview](../Design/Sanity/Sanity_Overview.md)
- [Sanity_Ranges](../Design/Sanity/Sanity_Ranges.md)
- [Sanity_Events](../Design/Sanity/Sanity_Events.md)
- [Sanity_Actions](../Design/Sanity/Sanity_Actions.md)
- [Sanity_System técnico](../Technical/Systems/Sanity_System.md)
