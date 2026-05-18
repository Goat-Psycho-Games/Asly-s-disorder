# Sistema de decisiones

## Descripción

El jugador toma decisiones a lo largo del juego que afectan a la narrativa, NPCs, eventos, cordura y finales.

## Principios de diseño

- Las decisiones nunca deben tener un resultado "obvio".
- El jugador no debe saber de antemano todas las consecuencias.
- Algunas decisiones tienen efecto inmediato, otras diferido.
- El sistema de decisiones está conectado con el sistema de cordura.

## Tipos de decisiones

| Tipo          | Descripción                                          |
| ------------- | ---------------------------------------------------- |
| Diálogo       | Elegir una opción en una conversación.               |
| Acción        | Interactuar o ignorar un objeto/NPC.                 |
| Objeto        | Usar o no usar un objeto en un momento específico.   |
| Pasiva        | No hacer nada también es una decisión.               |

## Registro de decisiones

El sistema debe guardar un registro de las decisiones tomadas para poder aplicar consecuencias diferidas.

## Ver también

- [Decisions_List.md](../../Narrative/Branches/Decisions_List.md)
- [Consequences.md](../../Narrative/Branches/Consequences.md)
- [Decision_Consequences.md](../Replayability/Decision_Consequences.md)
