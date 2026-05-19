# Sistema de diálogo

## Descripción

El sistema de diálogo gestiona la presentación y lógica de las conversaciones del juego.

## Componentes

| Componente        | Descripción                                              |
| ----------------- | -------------------------------------------------------- |
| DialogueManager   | Gestiona el flujo de diálogos. Singleton.                |
| DialogueData      | ScriptableObject con los datos de un diálogo.            |
| DialogueUI        | Gestiona la presentación visual del diálogo.             |
| DialogueParser    | Parsea y procesa la lógica de ramificación.              |

## Flujo de ejecución

```
NPC.Interact()
  → DialogueManager.StartDialogue(DialogueData)
    → DialogueUI.ShowText()
    → [Si hay opciones] DialogueUI.ShowOptions()
      → Jugador elige opción
        → ConsequenceManager.Apply()
        → Continúa o termina
```

## Datos de diálogo

Los diálogos se almacenan como ScriptableObjects en:
`Assets/_Project/ScriptableObjects/Dialogues/`

## Condiciones de variación

El sistema consulta al `SanityManager` y al `GameStateManager` para determinar qué variante de diálogo mostrar.

## Ver también

- [Dialogue_System.md](../../Design/Mechanics/Dialogue_System.md)
- [Dialogue_Template.md](../../Narrative/Dialogues/Dialogue_Template.md)
- [ScriptableObjects.md](../Data/ScriptableObjects.md)
