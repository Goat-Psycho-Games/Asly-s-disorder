# Estructura del proyecto Unity

## Descripción

Todo el código, arte y assets del proyecto van dentro de `Assets/_Project/`. Esto evita mezclar archivos propios con plugins y packages de Unity.

## Estructura de Assets/_Project/

```
Assets/
│
├── _Project/
│   ├── Animations/
│   │   ├── Characters/
│   │   ├── NPCs/
│   │   ├── Monsters/
│   │   ├── Environment/
│   │   └── UI/
│   ├── Art/
│   │   ├── Characters/
│   │   ├── NPCs/
│   │   ├── Monsters/
│   │   ├── Backgrounds/
│   │   ├── Props/
│   │   ├── Tilesets/
│   │   ├── UI/
│   │   └── VFX/
│   ├── Audio/
│   │   ├── Music/
│   │   ├── SFX/
│   │   ├── Ambience/
│   │   └── Voices/
│   ├── Materials/
│   ├── Prefabs/
│   │   ├── Player/
│   │   ├── NPCs/
│   │   ├── Monsters/
│   │   ├── Interactables/
│   │   ├── PuzzleObjects/
│   │   ├── UI/
│   │   └── Managers/
│   ├── Scenes/
│   │   ├── Boot/
│   │   ├── MainMenu/
│   │   ├── Levels/
│   │   ├── TestScenes/
│   │   └── Prototypes/
│   ├── Scripts/
│   │   ├── Core/
│   │   ├── Player/
│   │   ├── Interaction/
│   │   ├── Dialogue/
│   │   ├── SanitySystem/
│   │   ├── WorldSwitching/
│   │   ├── PuzzleSystem/
│   │   ├── NPCs/
│   │   ├── Monsters/
│   │   ├── Inventory/
│   │   ├── UI/
│   │   ├── SaveSystem/
│   │   └── Utilities/
│   ├── ScriptableObjects/
│   │   ├── Dialogues/
│   │   ├── Items/
│   │   ├── Puzzles/
│   │   ├── SanityEvents/
│   │   ├── NPCs/
│   │   └── Levels/
│   ├── Settings/
│   └── Resources/
│
├── Plugins/
├── ThirdParty/
└── TextMesh Pro/
```

## Regla principal

Todo lo del proyecto va en `_Project/`. Los plugins y packages de Unity van en `Plugins/` o `ThirdParty/`.
