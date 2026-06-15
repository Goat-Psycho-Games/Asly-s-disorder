# Backlog de tareas

## Cómo usar este documento

Cada tarea tiene el siguiente formato:

| Campo | Descripción |
|-------|-------------|
| **ID** | Identificador único de la tarea (ej. DOC-001) |
| **Tarea** | Nombre de la tarea en español |
| **Descripción** | Qué hay que hacer y por qué |
| **Peso** | Esfuerzo estimado en story points: 1 · 2 · 3 · 5 · 8 · 13 |
| **Prioridad** | Crítica · Alta · Media · Baja |
| **Estado** | Pendiente · En progreso · Bloqueada · Completada |

### Referencia de pesos

| Puntos | Tiempo estimado |
|--------|----------------|
| 1 | Menos de 1 hora |
| 2 | 2–4 horas |
| 3 | Medio día (4–8 h) |
| 5 | 1–2 días |
| 8 | 3–5 días |
| 13 | 1–2 semanas |

---

## 📄 Documentación

| ID | Tarea | Descripción | Peso | Prioridad | Estado |
|----|-------|-------------|:----:|-----------|--------|
| DOC-001 | Completar resumen del juego en el GDD | Redactar la descripción principal del juego en `02_GDD_Game_Design_Document.md`: mecánicas núcleo, género, tono y ambientación. Es la referencia central del proyecto. | 3 | Crítica | Pendiente |
| DOC-002 | Completar perfil de la protagonista | Definir nombre definitivo, historia de fondo, motivaciones, apariencia y arco narrativo de Asly en `Narrative/Characters/Protagonist.md`. | 3 | Crítica | Pendiente |
| DOC-003 | Completar Narrative Bible | Ampliar `Documentation/05_Narrative_Bible.md` con tono narrativo, estilo de escritura, estructura de capítulos y reglas del mundo. | 3 | Alta | Pendiente |
| DOC-004 | Definir paleta de colores en Art Bible | Completar `Art_Bible/01_Color_Palette.md` con colores definitivos para mundo normal y mundo creepy, incluyendo valores hexadecimales. | 2 | Alta | Pendiente |
| DOC-005 | Completar perfil del antagonista | Definir identidad, motivaciones, historia y conexión con Asly en `Narrative/Characters/Villain.md`. | 3 | Alta | Pendiente |
| DOC-006 | Completar Level Design Document | Crear la estructura de niveles del Capítulo 1 en `Documentation/06_Level_Design_Document.md`: áreas, conexiones y objetos clave. | 5 | Media | Pendiente |
| DOC-007 | Completar UI Style Guide | Rellenar `Art_Bible/05_UI_Style.md` con criterios de diseño de interfaz: tipografía, botones, HUD, inventario. | 2 | Media | Pendiente |
| DOC-008 | Definir público objetivo | Investigar y documentar el público al que va dirigido el juego en `Documentation/01_Game_Concept.md` (edad, gustos, plataformas). | 1 | Media | Pendiente |
| DOC-009 | Completar Timeline del lore | Ordenar cronológicamente los eventos clave del mundo en `Narrative/Story/Timeline.md`. | 2 | Media | Pendiente |
| DOC-010 | Completar lista de decisiones del jugador | Documentar las decisiones principales del juego y sus consecuencias en `Narrative/Branches/Decisions_List.md`. | 3 | Media | Pendiente |
| DOC-011 | Completar lista de puzzles | Rellenar `Design/Puzzles/Puzzle_List.md` con al menos 5 puzzles planificados para el Capítulo 1. | 3 | Media | Pendiente |
| DOC-012 | Rellenar documentos de lore encontrables | Crear 5 documentos del mundo que el jugador puede leer in-game en `Narrative/Lore/Documents.md`. | 3 | Baja | Pendiente |
| DOC-013 | Documentar dependencias entre puzzles | Completar `Design/Puzzles/Puzzle_Dependencies.md` con el grafo de dependencias entre puzzles. | 2 | Baja | Pendiente |
| DOC-014 | Completar guía de estilo de diálogos | Ampliar `Narrative/Dialogues/Dialogue_Style_Guide.md` con ejemplos de diálogos buenos y malos. | 2 | Baja | Pendiente |

---

## ⚙️ Técnica

| ID | Tarea | Descripción | Peso | Prioridad | Estado |
|----|-------|-------------|:----:|-----------|--------|
| TEC-001 | Crear y configurar proyecto Unity | Crear proyecto Unity con versión LTS, configurar URP, aplicar la estructura de carpetas definida en `Technical/Architecture/Unity_Project_Structure.md`. | 3 | Crítica | Pendiente |
| TEC-002 | Implementar GameManager | Crear `GameManager` como singleton que controla el estado global de la partida (menú, juego, pausa, game over). Ver `Technical/Architecture/Game_Manager.md`. | 2 | Crítica | Pendiente |
| TEC-003 | Implementar EventManager | Sistema de eventos global desacoplado para comunicación entre sistemas. Ver `Technical/Architecture/Event_System.md`. | 3 | Alta | Pendiente |
| TEC-004 | Implementar PlayerController | Movimiento lateral básico: desplazamiento izquierda/derecha, animaciones idle y walk, colisiones. Ver `Technical/Systems/Player_Controller.md`. | 5 | Alta | Pendiente |
| TEC-005 | Implementar sistema de interacción | Detectar objetos interactuables en radio del jugador y ejecutar la acción correspondiente. Ver `Technical/Systems/Interaction_System.md`. | 3 | Alta | Pendiente |
| TEC-006 | Implementar SceneLoader | Transiciones entre salas/escenas con fade y gestión de carga asíncrona. Ver `Technical/Architecture/Scene_Management.md`. | 3 | Alta | Pendiente |
| TEC-007 | Implementar SanityManager | Variable de cordura interna (0–100), métodos para modificarla y sistema de notificación de cambios de rango. Ver `Technical/Systems/Sanity_System.md`. | 3 | Alta | Pendiente |
| TEC-008 | Implementar DialogueManager | Sistema de diálogos con TextMeshPro: mostrar texto, avanzar con input, soporte para decisiones. Ver `Technical/Systems/Dialogue_System.md`. | 5 | Alta | Pendiente |
| TEC-009 | Implementar primer evento de cordura | Evento visual o sonoro simple (ej. parpadeo de luz, sonido ambiente) que cambia según el valor de cordura. Valida el flujo completo del `SanityManager`. | 3 | Alta | Pendiente |
| TEC-010 | Implementar SaveSystem | Guardar y cargar datos del juego en JSON local. Ver `Technical/Systems/Save_System.md` y `Technical/Data/Save_Data_Format.md`. | 5 | Media | Pendiente |
| TEC-011 | Implementar DecisionManager | Registrar las decisiones del jugador y exponer el historial a otros sistemas. Ver `Design/Mechanics/Decision_System.md`. | 5 | Media | Pendiente |
| TEC-012 | Implementar WorldTransitionManager | Cambio visual y lógico entre mundo normal y mundo creepy, con transición animada. Ver `Technical/Systems/World_Switching_System.md`. | 5 | Media | Pendiente |
| TEC-013 | Implementar PuzzleManager | Sistema base para registrar puzzles, sus estados y sus condiciones de resolución. Ver `Technical/Systems/Puzzle_System.md`. | 5 | Media | Pendiente |
| TEC-014 | Implementar AudioManager | Sistema básico de audio: música de fondo, efectos de sonido, y control de volumen. Ver `Technical/Systems/Audio_System.md`. | 3 | Media | Pendiente |
| TEC-015 | Implementar sistema de inventario | Inventario básico del jugador: recoger objetos, listarlos y usarlos. Ver `Design/Mechanics/Inventory.md`. | 3 | Media | Pendiente |
| TEC-016 | Configurar estándares de código del equipo | Aplicar y documentar las convenciones de código de Unity/C# del equipo en `Technical/Coding_Standards.md`. | 1 | Baja | Pendiente |

---

## 🎨 Arte

| ID | Tarea | Descripción | Peso | Prioridad | Estado |
|----|-------|-------------|:----:|-----------|--------|
| ART-001 | Definir paleta de colores definitiva | Elegir colores para mundo normal (cálido/neutro) y mundo creepy (desaturado/frío) y añadirlos a `Art_Bible/01_Color_Palette.md`. | 2 | Alta | Pendiente |
| ART-002 | Concept art del protagonista | Al menos 2 vistas del personaje (frente y lado) mostrando apariencia, ropa y expresión base. Guardar en `Art_Bible/References/Characters/`. | 5 | Alta | Pendiente |
| ART-003 | Concept art del primer escenario | Boceto del primer escenario del Capítulo 1 en versión normal. Guardar en `Art_Bible/References/Environments/`. | 5 | Media | Pendiente |
| ART-004 | Concept art de NPCs principales | Bocetos de apariencia para Gris, Helen y Johan. Guardar en `Art_Bible/References/Characters/`. | 5 | Media | Pendiente |
| ART-005 | Concept art versión creepy del primer escenario | Concept del mismo escenario en versión distorsionada/creepy. Seguir las pautas de `Art_Bible/07_Normal_vs_Creepy_World.md`. | 3 | Media | Pendiente |
| ART-006 | Definir guía de animación base | Completar `Art_Bible/06_Animation_Guide.md` con los estados de animación del protagonista y sus transiciones. | 3 | Media | Pendiente |
| ART-007 | Diseñar iconografía UI básica | Iconos para inventario, interacción y menú principal. Seguir las pautas de `Art_Bible/05_UI_Style.md`. | 3 | Baja | Pendiente |
| ART-008 | Concept art de primer monstruo | Boceto de apariencia de al menos un monstruo, con versión normal y creepy. Ver `Art_Bible/04_Monster_Design.md`. | 5 | Baja | Pendiente |

---

## 🎭 Diseño

| ID | Tarea | Descripción | Peso | Prioridad | Estado |
|----|-------|-------------|:----:|-----------|--------|
| DES-001 | Diseñar primer puzzle del Capítulo 1 | Crear ficha completa del primer puzzle usando `Design/Puzzles/Puzzle_Template.md`. Debe incluir versión normal y versión creepy. | 3 | Alta | Pendiente |
| DES-002 | Diseñar 3 eventos de cordura iniciales | Definir comportamiento detallado de 3 eventos que reaccionen al nivel de cordura en `Design/Sanity/Sanity_Events.md`. | 3 | Alta | Pendiente |
| DES-003 | Diseñar layout de la primera zona | Definir habitaciones, conexiones, objetos y puntos de interés de la primera zona en `Documentation/06_Level_Design_Document.md`. | 5 | Media | Pendiente |
| DES-004 | Diseñar versión creepy de la primera zona | Documentar las diferencias visuales y de gameplay de la primera zona en modo creepy. Ver `Design/World/Creepy_World.md`. | 3 | Media | Pendiente |
| DES-005 | Diseñar segundo y tercer puzzle | Crear fichas completas para los puzzles 2 y 3 del Capítulo 1 usando la plantilla. | 5 | Media | Pendiente |
| DES-006 | Completar balanceo del sistema de cordura | Definir los valores de pérdida y ganancia de cordura por acción en `Design/Sanity/Sanity_Balancing.md`. | 3 | Media | Pendiente |
| DES-007 | Documentar estados de área | Rellenar `Design/World/Area_States.md` con los estados posibles de cada área según la cordura del jugador. | 3 | Baja | Pendiente |
| DES-008 | Diseñar sistema de rejugabilidad del Capítulo 1 | Definir qué cambia en una segunda partida en `Design/Replayability/Branching_Events.md`. | 5 | Baja | Pendiente |

---

## 📖 Narrativa

| ID | Tarea | Descripción | Peso | Prioridad | Estado |
|----|-------|-------------|:----:|-----------|--------|
| NAR-001 | Definir estructura de capítulos | Decidir cuántos capítulos hay y qué ocurre en cada uno a alto nivel en `Narrative/Story/Main_Story.md`. | 3 | Alta | Pendiente |
| NAR-002 | Completar backstory de Asly | Ampliar la historia de fondo de la protagonista con detalles coherentes y consistentes con el lore en `Narrative/Story/Backstory.md`. | 3 | Alta | Pendiente |
| NAR-003 | Escribir diálogos del Capítulo 1 | Redactar diálogos principales del primer capítulo usando la plantilla de `Narrative/Dialogues/Dialogue_Template.md`. | 8 | Media | Pendiente |
| NAR-004 | Documentar reacciones de NPCs a decisiones | Cómo reaccionan Gris, Helen y Johan a las decisiones clave del jugador en `Narrative/Branches/NPC_Reactions.md`. | 3 | Media | Pendiente |
| NAR-005 | Completar Timeline del lore | Ordenar cronológicamente los eventos clave del mundo y la historia en `Narrative/Story/Timeline.md`. | 2 | Media | Pendiente |
| NAR-006 | Documentar finales alternativos | Describir los finales posibles del juego y sus condiciones de desbloqueo en `Narrative/Story/Endings.md`. | 3 | Baja | Pendiente |
| NAR-007 | Escribir pistas ocultas del lore | Crear 5 pistas ocultas que el jugador puede descubrir opcionalemente en `Narrative/Lore/Hidden_Clues.md`. | 3 | Baja | Pendiente |

---

## 📦 Producción

| ID | Tarea | Descripción | Peso | Prioridad | Estado |
|----|-------|-------------|:----:|-----------|--------|
| PRO-001 | Establecer flujo de trabajo del equipo | Definir cómo se trabaja: ramas de Git, revisión de código, gestión de tareas. Ver `CONTRIBUTING.md`. | 2 | Alta | Pendiente |
| PRO-002 | Definir fechas objetivo de los milestones | Asignar fechas tentativas a M1 (Prototipo técnico) y M2 (Vertical Slice) en `Production/03_Milestones.md`. | 1 | Alta | Pendiente |
| PRO-003 | Completar créditos del equipo | Rellenar la tabla del equipo en `Production/07_Credits.md` con nombres, roles y contacto. | 1 | Media | Pendiente |
| PRO-004 | Documentar herramientas del equipo | Listar y acordar herramientas de trabajo (Unity, comunicación, diseño) en `Production/07_Credits.md`. | 1 | Media | Pendiente |
| PRO-005 | Registrar primera reunión formal | Completar las actas de reunión con decisiones y asignaciones en `Production/04_Meeting_Notes.md`. | 1 | Baja | Pendiente |
