# Gestión de escenas

## Descripción

El juego gestiona múltiples escenas de Unity de forma organizada.

## Escenas principales

| Escena      | Descripción                                           |
| ----------- | ----------------------------------------------------- |
| Boot        | Escena inicial. Carga los managers y la escena de inicio. |
| MainMenu    | Menú principal.                                       |
| Levels/     | Escenas de los niveles del juego.                     |
| TestScenes/ | Escenas de prueba durante el desarrollo.              |
| Prototypes/ | Escenas de prototipado de mecánicas.                  |

## Flujo de carga

```
Boot → MainMenu → [Nivel 1] → [Nivel 2] → ...
```

## Managers persistentes

Los siguientes managers se cargan en Boot y persisten entre escenas:
- GameManager
- SaveManager
- AudioManager
- SanityManager
- EventManager

## Carga aditiva

Usar carga aditiva para cargar zonas dentro de un nivel si es necesario.

TBD

## Ver también

- [Game_Manager.md](Game_Manager.md)
- [SceneLoader en Scripts/Core](../../../UnityProject/Assets/_Project/Scripts/Core/)
