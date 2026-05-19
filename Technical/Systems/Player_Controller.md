# Player Controller

## Descripción

El PlayerController gestiona el movimiento y las acciones físicas del protagonista.

## Responsabilidades

- Gestionar la entrada del jugador.
- Aplicar el movimiento lateral.
- Comunicar con el sistema de interacción.

## Parámetros

| Parámetro       | Tipo    | Descripción                        |
| --------------- | ------- | ---------------------------------- |
| moveSpeed       | float   | Velocidad de movimiento.           |
| facingDirection | int     | 1 (derecha) / -1 (izquierda).      |

## Dependencias

- `PlayerInteraction`
- `Animator` (para animaciones)
- `Rigidbody2D` o `CharacterController2D`

## Notas

- Sin salto.
- Sin correr.
- El movimiento puede tener efectos visuales en cordura baja (temblor de cámara), pero la velocidad no cambia.

## Ver también

- [Movement.md](../../Design/Mechanics/Movement.md)
- [Interaction_System.md](Interaction_System.md)
