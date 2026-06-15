# Technical Design Document

## 1. Objetivo del documento

Este TDD define la arquitectura tecnica base de **Asly's Disorder** para guiar el prototipo M1 y servir como punto de referencia para los sistemas principales del juego.

El documento no pretende cerrar decisiones que todavia no estan disponibles. Cuando una decision siga abierta, queda marcada como pendiente en la seccion correspondiente.

## 2. Motor, version y pipeline

| Area | Decision |
| --- | --- |
| Motor | Unity |
| Version Unity | Pendiente de definir |
| Lenguaje | C# |
| Render pipeline | Universal Render Pipeline (URP) |
| Plataforma primaria | PC Windows |
| Plataformas secundarias | Pendiente de definir |

Dependencias confirmadas:

- TextMesh Pro para UI/dialogos.
- Git para control de versiones.

Dependencias pendientes:

- Sistema final de audio: Unity AudioSource/Audio Mixer o middleware.
- Librerias externas adicionales.
- Version exacta de Unity.

## 3. Principios de arquitectura

1. **Sistemas desacoplados por eventos.** Los sistemas principales no deben llamarse entre si de forma innecesariamente directa.
2. **Datos editables fuera del codigo.** Dialogos, eventos de cordura, puzzles, NPCs, items y niveles deben apoyarse en ScriptableObjects cuando sea practico.
3. **Estado persistente centralizado.** Decisiones, cordura, objetos, puzzles y estados de areas deben poder guardarse y restaurarse.
4. **Managers con responsabilidad limitada.** Un manager coordina su sistema, pero no debe absorber logica de otros dominios.
5. **Prototipo primero, extensible despues.** La arquitectura debe permitir el M1 sin sobredisenar sistemas que aun no tienen contenido cerrado.

## 4. Estructura del proyecto Unity

Todo el contenido propio del juego debe vivir dentro de:

```text
Assets/_Project/
```

Estructura base:

```text
Assets/_Project/
  Animations/
  Art/
  Audio/
  Materials/
  Prefabs/
  Scenes/
  Scripts/
  ScriptableObjects/
  Settings/
  Resources/
```

Carpetas externas:

```text
Assets/Plugins/
Assets/ThirdParty/
Assets/TextMesh Pro/
```

Regla principal: no mezclar assets propios con packages, plugins o dependencias de terceros.

Referencia: [Unity_Project_Structure.md](../Technical/Architecture/Unity_Project_Structure.md)

## 5. Escenas y flujo de carga

Escenas previstas:

| Escena/carpeta | Funcion |
| --- | --- |
| Boot | Inicializa managers persistentes. |
| MainMenu | Menu principal. |
| Levels/ | Niveles jugables. |
| TestScenes/ | Pruebas tecnicas aisladas. |
| Prototypes/ | Prototipos de mecanicas. |

Flujo base:

```text
Boot -> MainMenu -> Level
```

Managers persistentes cargados desde Boot:

- GameManager
- SaveManager
- AudioManager
- SanityManager
- EventManager

Decision pendiente:

- Si las zonas dentro de un nivel usaran escenas aditivas o prefabs/areas dentro de una unica escena.

Referencia: [Scene_Management.md](../Technical/Architecture/Scene_Management.md)

## 6. Arquitectura general de managers

### GameManager

Responsable del estado global del juego.

Estados:

```csharp
public enum GameState
{
    MainMenu,
    Playing,
    Paused,
    GameOver,
    Loading
}
```

Responsabilidades:

- Inicializar y coordinar managers.
- Mantener el estado global.
- Persistir entre escenas con `DontDestroyOnLoad`.
- Exponer referencias controladas a sistemas principales si es necesario.

Referencia: [Game_Manager.md](../Technical/Architecture/Game_Manager.md)

### EventManager

Sistema de comunicacion entre managers y sistemas de gameplay.

Eventos base:

- `OnSanityChanged`
- `OnWorldStateChanged`
- `OnDecisionMade`
- `OnItemPickedUp`
- `OnDialogueStarted`
- `OnDialogueEnded`
- `OnPuzzleSolved`
- `OnSanityEventTriggered`
- `OnSceneLoaded`

Decision recomendada para M1:

- Usar eventos C# / delegates centralizados o eventos estaticos tipados.

Decision pendiente:

- Evaluar si conviene migrar a ScriptableObject-based events cuando haya mas contenido y herramientas de autor.

Referencia: [Event_System.md](../Technical/Architecture/Event_System.md)

## 7. Sistemas principales

### Player Controller

Sistema responsable del movimiento lateral de Asly y de comunicar acciones fisicas al sistema de interaccion.

Responsabilidades:

- Leer input de movimiento.
- Aplicar desplazamiento horizontal.
- Actualizar direccion del personaje.
- Comunicar interaccion con `PlayerInteraction` o `InteractionDetector`.

Restricciones:

- Sin salto.
- Sin correr.
- La cordura baja puede afectar camara/feedback, no la velocidad base salvo evento controlado.

Referencia: [Player_Controller.md](../Technical/Systems/Player_Controller.md)

### Interaction System

Permite interactuar con objetos y NPCs en rango.

Componentes:

- `InteractionDetector`
- `IInteractable`
- `InteractableBase`

Contrato base:

```csharp
public interface IInteractable
{
    void Interact(PlayerController player);
    bool CanInteract();
}
```

Referencia: [Interaction_System.md](../Technical/Systems/Interaction_System.md)

### Dialogue System

Gestiona conversaciones, texto, opciones y consecuencias.

Componentes:

- `DialogueManager`
- `DialogueData`
- `DialogueUI`
- `DialogueParser`

Flujo:

```text
NPC.Interact()
  -> DialogueManager.StartDialogue(DialogueData)
  -> DialogueUI.ShowText()
  -> DialogueUI.ShowOptions()
  -> ConsequenceManager.Apply()
```

El sistema debe consultar:

- SanityManager para variantes de cordura.
- GameState/Decision data para condiciones narrativas.

Referencia: [Dialogue_System.md](../Technical/Systems/Dialogue_System.md)

### Sanity System

Gestiona valor de cordura, estado mental y eventos asociados.

Componentes:

- `SanityManager`
- `SanityEventManager`
- `ScreenDistortionController`
- `WorldStateManager` o integracion con `AreaStateManager`

Contrato base:

```csharp
public class SanityManager : MonoBehaviour
{
    public float CurrentSanity { get; private set; }
    public SanityState CurrentState { get; private set; }

    public void ModifySanity(float amount) { }
    public SanityState GetCurrentState() { }
}
```

Estados:

```csharp
public enum SanityState
{
    Stable,
    Uneasy,
    Distorted,
    Broken,
    OtherWorld
}
```

Referencia: [Sanity_System.md](../Technical/Systems/Sanity_System.md)

### World Switching System

Gestiona estados de area y transiciones entre mundo normal, distorted y creepy.

Componentes:

- `AreaStateManager`
- `WorldTransitionManager`
- `AreaController`

Estados de area previstos:

```csharp
public enum AreaState
{
    Normal,
    Distorted,
    Creepy,
    Locked,
    Completed
}
```

Cada `AreaController` debe controlar referencias a las versiones visuales y jugables del area:

- `normalVersion`
- `distortedProps`
- `creepyVersion`
- `puzzleNormal`
- `puzzleCreepy`
- `monsters`

Referencia: [World_Switching_System.md](../Technical/Systems/World_Switching_System.md)

### Puzzle System

Gestiona estado, condiciones y resolucion de puzzles.

Componentes:

- `PuzzleManager`
- `PuzzleBase`
- `PuzzleData`
- `PuzzleState`

Contrato base:

```csharp
public abstract class PuzzleBase : MonoBehaviour
{
    public PuzzleData Data;
    public PuzzleState State { get; protected set; }

    public abstract void Activate();
    public abstract void CheckSolution();
    protected virtual void OnSolved() { }
}
```

Estados:

```csharp
public enum PuzzleState
{
    Locked,
    Active,
    Solved,
    Unavailable
}
```

Referencia: [Puzzle_System.md](../Technical/Systems/Puzzle_System.md)

### Save System

Persiste el estado de partida en JSON.

Datos guardados:

- Cordura.
- Area actual.
- Posicion del jugador.
- Decisiones tomadas.
- Objetos recogidos.
- NPCs hablados.
- Eventos activados.
- Estados de areas.
- Puzzles resueltos.
- Tiempo de juego.

Ruta:

```csharp
Application.persistentDataPath + "/save_slot_X.json"
```

Decision pendiente:

- Numero de slots.
- Guardado manual, automatico o mixto.

Referencias:

- [Save_System.md](../Technical/Systems/Save_System.md)
- [Save_Data_Format.md](../Technical/Data/Save_Data_Format.md)

### Audio System

Gestiona musica, SFX, ambience y voces/vocalizaciones.

Componentes previstos:

- `AudioManager`
- `MusicLayer`

Categorias:

- Music
- SFX
- Ambience
- Voices

El audio debe reaccionar al estado de cordura:

- Stable: capa normal.
- Uneasy: tension sutil.
- Distorted: filtrado o desajuste.
- Broken: ruido y perturbacion.
- OtherWorld: capa creepy.

Decision pendiente:

- Implementacion con AudioSource, Unity Audio Mixer o middleware.

Referencia: [Audio_System.md](../Technical/Systems/Audio_System.md)

### Inventory System

Sistema pendiente de documentar tecnicamente.

Requisitos esperados para M1:

- Registrar objetos recogidos.
- Consultar si el jugador posee un objeto.
- Permitir que interacciones, dialogos y puzzles consulten objetos.
- Persistir objetos en el save.

Documento pendiente:

- `Technical/Systems/Inventory_System.md`

## 8. Datos y contenido

### ScriptableObjects

Los ScriptableObjects son el formato principal para datos editables desde Unity.

Tipos previstos:

| Tipo | Carpeta | Uso |
| --- | --- | --- |
| DialogueData | `ScriptableObjects/Dialogues/` | Conversaciones. |
| ItemData | `ScriptableObjects/Items/` | Objetos de inventario. |
| PuzzleData | `ScriptableObjects/Puzzles/` | Configuracion de puzzles. |
| SanityEventData | `ScriptableObjects/SanityEvents/` | Eventos de cordura. |
| NPCData | `ScriptableObjects/NPCs/` | Datos de NPCs. |
| LevelData | `ScriptableObjects/Levels/` | Areas/niveles. |

Referencia: [ScriptableObjects.md](../Technical/Data/ScriptableObjects.md)

### JSON

JSON queda reservado para:

- Saves.
- Datos extensos que se editen fuera de Unity.
- Posibles tablas importadas.

Decision pendiente:

- Formato final para dialogos extensos o tablas de eventos si se decide no usar solo ScriptableObjects.

Referencia: [JSON_Data.md](../Technical/Data/JSON_Data.md)

## 9. Flujo de datos entre sistemas

### Cambio de cordura

```text
Decision / Puzzle / Evento
  -> SanityManager.ModifySanity()
  -> EventManager.OnSanityChanged
  -> SanityEventManager evalua eventos
  -> World/Audio/UI reaccionan si corresponde
```

### Interaccion con NPC

```text
PlayerController
  -> InteractionDetector
  -> NPC.Interact()
  -> DialogueManager.StartDialogue()
  -> DialogueUI
  -> Decision/Consequence
  -> EventManager.OnDecisionMade
```

### Resolucion de puzzle

```text
Interactable / PuzzleBase
  -> PuzzleManager
  -> PuzzleBase.CheckSolution()
  -> PuzzleBase.OnSolved()
  -> Save flags / Sanity / AreaState / Events
```

### Cambio de mundo

```text
Sanity / Decision / Story event
  -> AreaStateManager.SetAreaState()
  -> EventManager.OnWorldStateChanged
  -> WorldTransitionManager
  -> AreaController.ApplyState()
```

## 10. Rendimiento y optimizacion

Objetivos iniciales:

- Mantener escenas ligeras y separadas por funcion.
- Evitar busquedas globales en runtime (`FindObjectOfType`).
- Preferir referencias serializadas o registradas en managers.
- Evitar logica pesada en `Update()`.
- Activar/desactivar objetos de area por estado en lugar de instanciar/destruir constantemente.
- Usar pooling solo si el prototipo demuestra necesidad.

Pendiente:

- Definir target de FPS, resolucion base y presupuesto por plataforma.

## 11. Control de versiones

Sistema: Git.

Repositorio:

```text
https://github.com/Goat-Psycho-Games/Asly-s-disorder
```

Rama principal:

```text
main
```

Flujo recomendado:

- `main` debe mantenerse estable.
- Cambios de documentacion pueden ir directos si son pequenos.
- Cambios de Unity/sistemas deberian ir en ramas por feature.
- Commits pequenos y descriptivos.

Formato recomendado de commit:

```text
[Sistema] Descripcion breve
```

Ejemplo:

```text
[SanitySystem] Add range evaluation
```

Referencia: [Coding_Standards.md](../Technical/Coding_Standards.md)

## 12. Estandares de codigo

Convenciones:

| Elemento | Convencion | Ejemplo |
| --- | --- | --- |
| Clases | PascalCase | `SanityManager` |
| Metodos | PascalCase | `ModifySanity()` |
| Variables privadas | _camelCase | `_currentSanity` |
| Variables publicas | camelCase | `moveSpeed` |
| Propiedades | PascalCase | `CurrentSanity` |
| Constantes | UPPER_SNAKE_CASE | `MAX_SANITY` |
| Interfaces | I + PascalCase | `IInteractable` |
| Enums | PascalCase | `SanityState` |
| ScriptableObjects | PascalCase + Data | `SanityEventData` |

Reglas:

- Un script = una responsabilidad.
- Evitar logica de juego en `Update()` cuando pueda resolverse por eventos.
- No usar `FindObjectOfType` en runtime.
- Preferir eventos/callbacks sobre polling.
- Validar referencias dinamicas con null checks.

## 13. Alcance tecnico M1

El primer prototipo tecnico debe implementar:

- Boot scene con managers persistentes minimos.
- PlayerController con movimiento lateral.
- InteractionDetector + IInteractable.
- Un objeto interactuable funcional.
- DialogueManager y DialogueUI basicos.
- SanityManager con valor 0-100 y rangos.
- Un SanityEventData o equivalente de prueba.
- AreaController con dos estados visibles.
- WorldTransitionManager basico.
- PuzzleBase/PuzzleManager para un puzzle simple.
- SaveData serializable o mock inicial de save.

## 14. Riesgos tecnicos

| Riesgo | Impacto | Mitigacion |
| --- | --- | --- |
| Sobrecargar GameManager | Alto | Mantener managers por dominio y usar eventos. |
| Datos demasiado hardcodeados | Alto | Priorizar ScriptableObjects para contenido. |
| Sistema de cordura acoplado a todo | Alto | Comunicar cambios por eventos. |
| Cambio de mundo caro o fragil | Medio | Usar AreaController por area y estados claros. |
| Dialogos con ramificacion compleja demasiado pronto | Medio | Empezar con DialogueData simple y condiciones minimas. |
| Guardado incompleto | Alto | Definir SaveData temprano y actualizarlo por sistema. |

## 15. Pendientes tecnicos

- Definir version exacta de Unity.
- Confirmar plataforma secundaria o descartar para M1.
- Decidir sistema final de audio.
- Documentar Inventory System.
- Decidir namespaces del proyecto.
- Definir target de rendimiento.
- Decidir carga aditiva o areas dentro de escena.
- Cerrar numero y reglas de slots de guardado.
- Definir formato final para dialogos largos si ScriptableObjects no son suficientes.
