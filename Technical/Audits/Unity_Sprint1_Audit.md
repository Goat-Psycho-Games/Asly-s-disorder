# Auditoría técnica Unity — Sprint 1

## Contexto

| Campo | Valor |
| --- | --- |
| Issue | [#38 TECH-010](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/38) |
| Fecha de auditoría | 2026-08-18 |
| Responsable | Iago (`IagoPL`) |
| Commit auditado | `8ebfc6a` (`feat: add basic side movement prototype`) |
| Épica | [#39 EPIC-001](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/39) |

Objetivo: registrar el estado real de apertura, dependencias y escenas base del proyecto Unity antes de Git LFS (#46), Sandbox (#47) e investigación de Input System (#45). Esta auditoría documenta el estado actual; no corrige defectos del prototipo.

## Entorno

| Campo | Valor |
| --- | --- |
| Editor | Unity `6000.3.15f1` |
| Revision | `c1aa84e375f6` |
| Proyecto | `UnityProject/` (`C:/Users/Iago/Documents/proyectos/Asly-s-disorder/UnityProject`) |
| Producto | Asly's Disorder / Goat Psycho Games |
| Compilación | OK |

La versión queda fijada en `UnityProject/ProjectSettings/ProjectVersion.txt`. No se actualiza Unity ni paquetes en esta issue.

## Dependencias oficiales

Fuente: `UnityProject/Packages/manifest.json` en el commit auditado (`8ebfc6a`). No se usa ninguna copia local modificada del Editor.

### Paquetes relevantes

| Paquete | Versión | Notas |
| --- | --- | --- |
| `com.unity.render-pipelines.universal` | 17.3.0 | URP. El proyecto usa renderer 2D (`AslysDisorder_URP` / `AslysDisorder_2DRenderer`). |
| `com.unity.2d.sprite` | 1.0.0 | Sprites 2D. |
| `com.unity.2d.tilemap` | 1.0.0 | Tilemaps 2D. |
| `com.unity.textmeshpro` | 5.0.0 | Texto. |
| `com.unity.ugui` | 2.0.0 | UI. |
| `com.unity.multiplayer.center` | 1.0.1 | Presente en el manifest (plantilla Unity 6). No hay sistemas multijugador en el prototipo. |

Módulos built-in presentes (entre otros): `physics2d`, `physics`, `audio`, `animation`, `ui`, `uielements`, `director`, `particlesystem`, `tilemap`.

### Ausentes en el producto

- `com.unity.inputsystem` **no** está en el manifest oficial.
- `com.unity.ai.assistant` **no** forma parte de las dependencias oficiales del producto. Si aparece en una máquina local, es una herramienta de diagnóstico del Editor y no debe instalarse ni documentarse como requisito del proyecto.

## Input actual

Estado del producto en `8ebfc6a`:

| Aspecto | Estado | Validación |
| --- | --- | --- |
| Active Input Handling | Input Manager (Old) (`activeInputHandler: 0`) | Configurado |
| API en código | `Input.GetAxisRaw` en `PlayerSideMovement` | Configurado |
| Eje | `Horizontal` | Configurado |
| Bindings del eje | `A` / `D` y flechas izquierda / derecha en `InputManager.asset` | Configurado |
| Input System (paquete nuevo) | Ausente | Configurado |
| Pulsación real de A/D/flechas en Play Mode | No forma parte de esta auditoría | No validado manualmente |

El movimiento lateral está **configurado** sobre Input Manager legacy. Esta auditoría **no** afirma que las teclas se hayan validado manualmente en Game view.

La excepción de `facingRoot` (INC-02) ocurre en `Awake` al aplicar orientación. No debe interpretarse como un fallo del Input Manager ni como resultado de la investigación de #45.

## Estructura observada

El código y los assets de juego viven en `UnityProject/Assets/_Project/`, alineado con [Unity_Project_Structure.md](../Architecture/Unity_Project_Structure.md).

Escenas en disco y en Build Settings (las tres habilitadas):

1. `Assets/_Project/Scenes/Boot/Boot.unity`
2. `Assets/_Project/Scenes/MainMenu/MainMenu.unity`
3. `Assets/_Project/Scenes/Prototypes/Prototype_M1.unity`

No existe escena Sandbox. El prototipo jugable actual es `Prototype_M1` (player prefab `PrototypePlayer`, script `AslysDisorder.Player.PlayerSideMovement`).

## Escenas

| Escena | Abre | Play Mode | Compila | Resultado |
| --- | --- | --- | --- | --- |
| Boot | Sí | Sí | OK | PASS — stub (`Boot_Root` sin cámara ni lógica). |
| MainMenu | Sí | Sí | OK | PASS — stub (`MainMenu_Root` + `Main Camera`, sin UI). |
| Prototype_M1 | Sí | Sí (entra) | OK | FAIL_WITH_ISSUES — ver INC-01, INC-02 e INC-03. |

`Prototype_M1` abre y entra en Play Mode. No se declara funcionalmente correcto: el jugador y el suelo no son visibles en Game view, y Play Mode lanza una excepción de orientación.

## Incidencias

### INC-01 — Alta — PrototypePlayer sin Sprite

| Campo | Detalle |
| --- | --- |
| Descripción | El jugador existe en Hierarchy pero no se renderiza. |
| Causa | `SpriteRenderer.sprite` está vacío. `Assets/_Project/Art/Characters/PrototypePlayer.png` existe como Texture Type Sprite, Sprite Mode Multiple, sin slices; Unity no genera subasset `Sprite`. El prefab guarda `m_Sprite: {fileID: 0}`. |
| Efecto | Jugador invisible en Game view. |
| Evidencia | `PrototypePlayer` activo en `(0, 0, 0)` con `SpriteRenderer` enabled, alpha 1, sorting order 10, sprite = None. |
| Impacto | No bloquea #46. #47 no debe reutilizar este placeholder a ciegas. No bloquea #45. |
| Tarea relacionada | Resolver visibilidad del placeholder en #47 (Sandbox). Fuera de alcance de #38. |

### INC-02 — Alta — `facingRoot` sin asignar

| Campo | Detalle |
| --- | --- |
| Descripción | Play Mode lanza `UnassignedReferenceException` al inicializar el jugador. |
| Causa | `PlayerSideMovement.facingRoot` está vacío en el prefab. `facingRoot ??= transform` no cubre el fake-null de Unity. `ApplyFacing()` lee `facingRoot.localScale` desde `Awake()`. |
| Efecto | Excepción en `Awake`. La orientación del jugador no es funcional con el prefab/código actuales. |
| Evidencia | Console: `UnassignedReferenceException` en `PlayerSideMovement.ApplyFacing()` ← `Awake()` (`PlayerSideMovement.cs`). Campo serializado `facingRoot` = None. |
| Impacto | No bloquea #46. #47 necesita un placeholder que entre en Play Mode sin este error. No bloquea la investigación de #45; no es un fallo del eje `Horizontal`. |
| Tarea relacionada | Placeholder funcional en #47. Fuera de alcance de #38. |

### INC-03 — Media — PrototypeGround sin representación visual

| Campo | Detalle |
| --- | --- |
| Descripción | El suelo existe como collider, no como objeto visible. |
| Causa | `PrototypeGround` solo tiene `Transform` + `BoxCollider2D`. Sin `SpriteRenderer` ni `MeshRenderer`. |
| Efecto | Suelo invisible en Game view. Junto con INC-01, la escena parece vacía pese a tener objetos en Hierarchy. |
| Evidencia | Posición `(0, -0.15, 0)`, escala `(9, 0.2, 1)`. Cámara ortográfica presente y enmarcada al origen (`Main Camera`, size 4, fondo sólido oscuro). |
| Impacto | #47 debe incluir referencias visuales mínimas de suelo/zona. No bloquea #46 ni #45. |
| Tarea relacionada | #47 Sandbox. Fuera de alcance de #38. |

### INC-04 — Informativa — escena dirty / `_Recovery`

| Campo | Detalle |
| --- | --- |
| Descripción | Tras Play Mode, `Prototype_M1` puede quedar dirty en memoria. El Editor puede generar `UnityProject/Assets/_Recovery/`. |
| Causa | Recuperación local del Editor. No es contenido de producto. |
| Efecto | Riesgo de commit accidental de recovery o de guardar la escena sin cambios intencionados. |
| Evidencia | `_Recovery/` no está trackeado. `Prototype_M1.unity` no aparece modificado en git. |
| Impacto | Ninguno sobre LFS, Sandbox o Input si no se commitea. |
| Tarea relacionada | No incluir `_Recovery/` en commits. Valorar un patrón de ignore en una tarea posterior de higiene del repo. No se modifica `.gitignore` en #38. |

## Impacto sobre Sprint 1

### #46 Git LFS

**DESBLOQUEADA.**

La auditoría no ha encontrado ningún impedimento técnico para configurar Git LFS y las reglas de assets binarios. El PNG de placeholder existe y es pequeño; no obliga a una migración de historial.

### #47 Sandbox

**DESBLOQUEADA CON INCIDENCIAS CONOCIDAS.**

Se puede crear una escena Sandbox. No debe reutilizarse ciegamente `PrototypePlayer` / `Prototype_M1` como placeholder:

- el sprite no está asignado (INC-01);
- `facingRoot` provoca excepción en `Awake` (INC-02);
- el suelo no tiene referencia visual (INC-03).

Sandbox necesita un placeholder visible, movimiento sin error de facing y marcadores visuales mínimos de suelo/zona. Esas correcciones **no** se hacen en #38.

### #45 Input System

**DESBLOQUEADA PARA INVESTIGACIÓN.**

Hay input legacy configurado (`Input.GetAxisRaw("Horizontal")`, eje con A/D y flechas). El paquete Input System no está en el producto. INC-02 es un fallo de referencia de orientación, no del Input Manager.

## Resultado

**AUDITORÍA COMPLETADA CON INCIDENCIAS NO BLOQUEANTES PARA CONTINUAR EL SPRINT**

- El proyecto abre con Unity `6000.3.15f1`.
- Compila.
- Boot y MainMenu abren y ejecutan Play Mode.
- `Prototype_M1` abre y entra en Play Mode, con problemas conocidos de visibilidad y orientación. **No** se declara que el prototipo funcione correctamente.
- Las incidencias se abordan en las tareas correspondientes (#47 para placeholder/Sandbox; #45 para la decisión de input; #42 para el segundo entorno).

## Pendientes externos

- [#42](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/42) — validación de apertura en la máquina de Mateo.
- [#45](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/45) — investigar y preparar Input System (Mateo; revisión de Iago).
- [#47](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/47) — escena Sandbox con placeholder visible y sin el error de `facingRoot`.
