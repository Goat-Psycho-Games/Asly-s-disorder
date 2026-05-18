# Movimiento

## Descripción

El protagonista se mueve en scroll lateral, sin salto ni carrera.

## Especificaciones

| Parámetro         | Valor   | Notas                          |
| ----------------- | ------- | ------------------------------ |
| Velocidad         | TBD     | En unidades Unity por segundo. |
| Dirección         | Lateral | Solo izquierda/derecha.        |
| Salto             | No      | Decisión de diseño DEC-001.    |
| Correr            | No      | Decisión de diseño DEC-002.    |
| Colisiones        | TBD     | TBD                            |

## Restricciones de movimiento

- El jugador no puede atravesar paredes u objetos sólidos.
- Ciertas zonas pueden estar bloqueadas según el estado del juego.
- El movimiento puede verse afectado visualmente en estados de cordura baja.

## Efectos de cordura sobre el movimiento

- Cordura alta: movimiento normal.
- Cordura baja: posibles efectos visuales (temblor de cámara, etc.). El movimiento en sí no cambia.

## Ver también

- [Player_Controller.md](../../Technical/Systems/Player_Controller.md)
- [DEC-001](../../Production/05_Decision_Log.md)
