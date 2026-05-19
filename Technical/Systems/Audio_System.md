# Sistema de audio

## Descripción

El AudioManager gestiona la reproducción de música, efectos de sonido, ambience y voces.

## Componentes

| Componente    | Descripción                                          |
| ------------- | ---------------------------------------------------- |
| AudioManager  | Gestiona toda la reproducción de audio. Singleton.   |
| MusicLayer    | Gestiona capas de música adaptativa.                 |

## Categorías de audio

| Categoría | Carpeta                        |
| --------- | ------------------------------ |
| Música    | `Audio/Music/`                 |
| SFX       | `Audio/SFX/`                   |
| Ambience  | `Audio/Ambience/`              |
| Voces     | `Audio/Voices/`                |

## Audio adaptativo por cordura

La música y el ambience deben cambiar según el estado de cordura:

- Stable: música normal del área.
- Uneasy: capa adicional de tensión.
- Distorted: música alterada o filtrada.
- Broken: sonidos perturbadores, ruido.
- OtherWorld: música del mundo creepy.

## Implementación

TBD — Decidir entre:
- AudioSource estático.
- FMOD.
- Unity Audio Mixer con parámetros.

## Ver también

- [Event_System.md](../Architecture/Event_System.md)
- [Sanity_System.md](Sanity_System.md)
