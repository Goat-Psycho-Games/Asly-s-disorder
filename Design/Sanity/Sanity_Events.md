# Eventos de cordura

## Descripción

Los eventos de cordura son ocurrencias que se disparan cuando se cumplen ciertas condiciones. Son la forma en que el sistema de cordura se manifiesta en el juego.

## Plantilla de evento

```md
## [ID]: [Nombre del evento]

**ID:** SAN_EVENT_XXX
**Zona:** [Área — Sub-zona]

### Condiciones
- Cordura entre X y Y.
- [Condición narrativa].
- [Condición de objeto/NPC].
- No haber visto este evento antes (si aplica).
- Probabilidad: XX%

### Efecto
- [Efecto visual].
- [Efecto sonoro].
- [Efecto en cordura: +X / -X].
- [Efecto narrativo].

### Repetible
Sí / No.

### Importancia narrativa
Alta / Media / Baja.
```

---

## SAN_EVENT_001: Aparición en el pasillo

**Zona:** TBD

### Condiciones
- Cordura entre 20 y 40.
- Haber hablado con al menos un NPC.
- No haber visto este evento antes.
- Probabilidad: 35%.

### Efecto
- Aparece una silueta durante 3 segundos.
- Se reproduce sonido de respiración.
- Baja la cordura 5 puntos.
- Desbloquea una variante de diálogo.

### Repetible
No.

### Importancia narrativa
Media.

---

## Ver también

- [Sanity_Ranges.md](Sanity_Ranges.md)
- [Sanity_Balancing.md](Sanity_Balancing.md)
- [SanityEventManager](../../Technical/Systems/Sanity_System.md)
