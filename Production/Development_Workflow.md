# Flujo de desarrollo — Asly's Disorder

## 1. Principio general

```
main
  → rama corta por issue
  → commit(s)
  → push
  → Pull Request
  → revisión
  → merge
  → cierre issue
```

- `main` = estado integrado y revisado.
- No trabajar directamente en `main` (salvo emergencia explícita autorizada por Iago).
- No `develop` permanente, no release branches complejas, no GitFlow tradicional, no ramas personales de larga duración.

---

## 2. Convención de ramas

Formato: `<tipo>/<issue>-<descripcion-corta>`

| Tipo      | Uso                        |
|-----------|----------------------------|
| `feat/`   | Funcionalidad nueva        |
| `fix/`    | Corrección                 |
| `docs/`   | Documentación              |
| `chore/`  | Config, tooling, mantenimiento |
| `art/`    | Arte (cuando aplique)      |
| `audio/`  | Audio (cuando aplique)     |

Ejemplos:
- `feat/47-technical-sandbox`
- `docs/49-development-workflow`
- `fix/123-dialogue-choice`
- `art/51-station-moodboard`

Reglas:
- 1 issue = 1 rama (salvo dependencia técnica justificada).
- Vida corta: integrar y borrar tras merge.
- No mezclar tareas no relacionadas.
- Actualizar con `main` cuando sea necesario (`git pull --rebase origin main` o merge).

---

## 3. Commits

Formato: `tipo(área): descripción`

Ejemplos:
- `docs(technical): define development workflow`
- `feat(player): add interaction placeholder`
- `fix(dialogue): prevent duplicate choice`

Reglas:
- Commits coherentes y atómicos.
- No mezclar trabajo no relacionado.
- Mensajes descriptivos (qué y por qué, no cómo).
- No `git add .` / `git add -A` como procedimiento habitual → staging explícito por archivo/ruta.
- No reescribir historial compartido.
- No force-push salvo situación excepcional acordada.

---

## 4. Definition of Ready (DoR) — General

Una tarea está **Ready** cuando cumple **todo** lo siguiente:

- [ ] Issue existe y es accesible.
- [ ] Objetivo entendible en una frase.
- [ ] Responsable identificado.
- [ ] Entregable esperado definido.
- [ ] Criterios de aceptación suficientemente claros.
- [ ] Dependencias conocidas y registradas.
- [ ] Bloqueos conocidos registrados en la issue.
- [ ] Documentación/contexto necesario accesible (enlaces a docs, diseños, referencias).

> Si falta una decisión que impide implementar correctamente → **NO está Ready**. No empezar "a ver qué sale".

---

## 5. DoR por tipo

### Código / Unity
- Comportamiento esperado definido.
- Escena/sistema afectado conocido.
- Dependencias técnicas conocidas.
- Versión Unity definida cuando aplique.
- No existe decisión crítica pendiente.

### Documentación
- Propósito conocido.
- Documento canónico/ruta identificada.
- Fuentes de verdad identificadas.
- Responsable de revisión conocido.

### Arte
- Objetivo del asset claro.
- Referencias aprobadas o suficientemente maduras.
- Formato/resolución/dimensiones conocidas cuando aplique.
- Ubicación/naming definidos (ver `Technical/Git_LFS.md` y `Technical/Architecture/Unity_Project_Structure.md`).
- LFS revisado para formatos binarios (`.psd`, `.fbx`, `.wav`, fuentes, etc.).

### Audio
- Uso/contexto conocido.
- Duración/loop/formato cuando aplique.
- Naming/ruta definidos.
- LFS aplicado cuando corresponda.

---

## 6. Definition of Done (DoD) — General

Una tarea está **Done** cuando:

- [ ] Criterios de aceptación cumplidos.
- [ ] Entregable creado y accesible.
- [ ] Trabajo revisado (por responsable o Iago según §10).
- [ ] Evidencia verificable disponible (capturas, build, link a PR, demo).
- [ ] No hay cambios ajenos mezclados en el diff.
- [ ] Documentación actualizada si el cambio lo requiere.
- [ ] PR integrado (si hay cambio de repo).
- [ ] Issue actualizada/cerrada correctamente.
- [ ] Pendientes reales convertidos en issue/TBD explícito (no ocultos).

---

## 7. DoD por tipo

### Código / Unity
- Compila sin errores (Unity Console limpio).
- No introduce errores nuevos conocidos.
- Prueba mínima realizada (manual en escena afectada).
- Escenas relevantes verificadas cuando aplique.
- No rompe escenas/sistemas existentes relevantes.
- Revisión de Iago cuando afecta arquitectura/integración (§10).
- No se exige CI que actualmente no exista.

### Documentación
- Coherente con fuentes canónicas.
- Enlaces comprobados (no rotos).
- Sin contradicciones conocidas sin marcar.
- Revisada por responsable adecuado.

### Arte / Audio
- Archivo fuente/export correspondiente correctamente ubicado.
- Naming correcto.
- LFS cuando aplique.
- Revisión del responsable.
- No reemplaza assets aprobados sin coordinación.

---

## 8. Pull Requests

Mínimo requerido en la PR:

- Título claro (`tipo(área): descripción`).
- Resumen de qué cambia y por qué.
- Issue relacionada (`Closes #XX` para cierre automático).
- Cómo se validó (pasos, capturas, build).
- Pendientes/TBD explícitos si existen.

La revisión debe comprobar:
- Scope correcto (no work fuera de la issue).
- Diff sin archivos accidentales (`.meta` no tocados, sin basura).
- Criterios de aceptación cumplidos.
- Ausencia de conflictos relevantes con `main`.

---

## 9. Revisiones de Iago (obligatorias)

Iago revisa **obligatoriamente** cuando el cambio afecta:

- Arquitectura técnica (sistemas compartidos, managers, bootstrapping).
- Código que afecta sistemas transversales (SanitySystem, WorldSwitching, EventSystem, SaveSystem, DialogueSystem, PuzzleSystem, PlayerController).
- Configuración del repositorio (`.gitignore`, `.gitattributes`, workflows y otras configs técnicas compartidas).
- ProjectSettings / Packages / URP / Input System.
- Integración entre disciplinas (arte → Unity, narrativa → implementación, audio → integración).
- Cambios de scope/producción (roadmap, hitos, Demo_Scope).
- Merge de trabajo crítico (vertical slice, demo, build de entrega).
- Excepciones a las reglas de este workflow.

**Para cambios pequeños puramente internos de una disciplina** (ej. ajuste de diálogo, tweak de asset, fix de bug localizado sin impacto transversal): permite revisión del responsable correspondiente cuando no exista impacto técnico/producción.

> Objetivo: no convertir a Iago en cuello de botella para absolutamente todo.

---

## 10. Protocolo de bloqueos

### ¿Cuándo es bloqueo?
- No se puede continuar sin decisión.
- Dependencia externa pendiente.
- Conflicto técnico (merge, arquitectura, asset).
- Asset/documentación necesaria inexistente.
- Permisos/acceso faltantes.
- Decisión entre disciplinas (arte vs código, narrativa vs diseño).
- Problema que puede provocar retrabajo importante si se avanza a ciegas.

### NO es bloqueo
- Duda menor resoluble localmente.
- Preferencia personal sin impacto en criterios de aceptación.

---

## 11. Formato de bloqueo (plantilla)

Copiar en la issue correspondiente:

```markdown
### BLOQUEO

**Issue:** #XX
**Responsable:** Nombre
**Desde:** AAAA-MM-DD
**Impacto:** Bajo / Medio / Alto / Crítico

**Problema**
Descripción breve.

**Qué impide**
Qué trabajo no puede continuar.

**Necesito de**
Persona/disciplina que debe responder.

**Opciones**
- A:
- B:

**Fecha necesaria**
AAAA-MM-DD o "sin fecha crítica"
```

---

## 12. Canal de bloqueos

| Propósito        | Canal                          |
|------------------|--------------------------------|
| Registro persistente, decisión final | **GitHub Issue** (la issue de la tarea) |
| Aviso rápido     | Discord del equipo, en el canal operativo utilizado para coordinar la tarea |

**Principio:** Discord = aviso inmediato. GitHub = registro persistente, estado y decisión final.

**Nombre de canal canónico:** TBD / pendiente de acordar.

---

## 13. Escalado

| Nivel            | Cuándo                                         | Acción                                |
|------------------|------------------------------------------------|---------------------------------------|
| **Inmediato**    | Bloqueo crítico: afecta `main`, impide a varias personas, riesgo pérdida/corrupción, exige decisión ya | Avisar a Iago ya (Discord + issue)    |
| **Mismo día**    | Bloqueo que impide avanzar la tarea actual     | Registrar en issue, buscar respuesta  |
| **Máx. 1 día laborable** | Sigue sin respuesta/solución             | Actualizar issue, escalar a Iago, decidir: workaround / reasignación / aplazamiento |

> No dejar una tarea bloqueada varios días sin registrar.

---

## 14. Estados de issue (conceptuales)

- `Ready` — cumple DoR, puede empezarse.
- `In Progress` — trabajo activo.
- `Blocked` — hay bloqueo registrado (§11).
- `Review` — PR abierto, en revisión.
- `Done` — mergeado, criterios cumplidos, issue cerrada.

> Si GitHub Project usa nombres distintos, documentar equivalencia aquí (no modificar Project automáticamente).

---

## 15. Handoff entre disciplinas

Cuando una tarea desbloquea a otra persona, dejar en la issue:

- **Qué está listo** (entregable concreto).
- **Ubicación** (ruta en repo, escena, ScriptableObject, asset).
- **Cómo validarlo** (pasos mínimos).
- **Limitaciones / TBD** conocidos.
- **Siguiente responsable**.

Casos típicos:
- Programación → Diseño (sistema listo para configurar datos).
- Arte → Unity (asset exportado, en ruta correcta, naming OK).
- Narrativa → Implementación (diálogos/lorem aprobados, en formato acordado).
- Audio → Integración (archivos en LFS, naming, loop points documentados).

---

## 16. Referencias rápidas

- Estructura Unity: `Technical/Architecture/Unity_Project_Structure.md`
- Estándares código: `Technical/Coding_Standards.md`
- Git LFS: `Technical/Git_LFS.md`
- Demo Scope: `Production/Demo_Scope.md`
- Decision Log: `Production/05_Decision_Log.md`

---

## 17. Comunicación al equipo (mensaje para Discord)

> **Nueva guía: Flujo de desarrollo (issue #49)**
>
> He publicado `Production/Development_Workflow.md` con el procedimiento para trabajar en el repo.
>
> Puntos clave:
> - **No trabajar directo en `main`** → una rama por issue (`feat/`, `fix/`, `docs/`, `chore/`, `art/`, `audio/`).
> - **Pull Request obligatorio** antes de merge.
> - **Definition of Ready / Done** por tipo (código, docs, arte, audio).
> - **Bloqueos**: plantilla en la issue + aviso en Discord (canal TBD). Escalado a 1 día máx.
> - **Revisiones de Iago**: obligatorias en arquitectura, sistemas compartidos, config repo, ProjectSettings, integración entre disciplinas. Cambios internos pequeños → responsable de la disciplina.
> - **Handoff**: dejar en la issue qué está listo, dónde, cómo validar, limitaciones, siguiente responsable.
>
> Leer el doc completo en: `Production/Development_Workflow.md`
>
> Dudas → aquí o en la issue #49.