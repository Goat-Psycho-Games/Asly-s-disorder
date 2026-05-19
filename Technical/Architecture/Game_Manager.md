# GameManager

## Descripción

El GameManager es el manager central del juego. Coordina el estado general y la comunicación entre sistemas.

## Responsabilidades

- Mantener el estado global del juego (en menú, jugando, pausa, game over).
- Coordinar la inicialización de otros managers.
- Proveer punto de acceso a otros sistemas (Singleton).

## Estados del juego

```
GameState:
- MainMenu
- Playing
- Paused
- GameOver
- Loading
```

## Acceso a otros managers

- `GameManager.Instance.SanityManager`
- `GameManager.Instance.SaveManager`
- `GameManager.Instance.AudioManager`
- `GameManager.Instance.EventManager`

## Notas de implementación

- Usar patrón Singleton.
- No destruir al cambiar escena (DontDestroyOnLoad).
- Evitar que GameManager tenga demasiadas responsabilidades.

## Ver también

- [Event_System.md](Event_System.md)
- [Scene_Management.md](Scene_Management.md)
