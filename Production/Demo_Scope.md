# Alcance de producto — Demo, Capítulo 1 y Vertical Slice

**Issue:** [#40 PROD-010](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/40)
**Fecha:** 2026-08-18
**Estado:** Borrador de planificación. La frontera narrativa exacta de la demo **requiere revisión de Kai**.

Este documento es la referencia de alcance de producto. No sustituye al GDD ni a la Narrative Bible. No borra el contenido del manicomio.

---

## 1. Propósito

Existen tres capas de alcance que la documentación histórica mezcla:

| Capa | Función |
| --- | --- |
| **Demo de la estación** | Entrega actual de los primeros sprints: preproducción y prototipo jugable acotado. |
| **Capítulo 1 / manicomio** | Núcleo creativo del juego completo. Sigue existiendo. No se implementa como bloque en el Sprint 1. |
| **Vertical Slice** | Hito posterior de calidad y representatividad. No es “otra demo” ni el Sprint 1. |

Sin esta separación, el equipo puede tratar el manicomio del GDD como trabajo inmediato, o tratar la demo como si fuera ya la Vertical Slice.

---

## 2. Demo de la estación

### Objetivo

Validar el loop mínimo y el tono de *Asly's Disorder* en un recorte jugable centrado en la **estación de tren**, para poder prototipar en Sprint 2 sin reabrir el alcance cada semana.

### Función dentro del desarrollo

Es el **foco de producción actual** (Sprint 1 preproducción + Sprint 2 prototipo). No es el Capítulo 1 completo ni la Vertical Slice.

### Entorno principal

La estación de tren. El GDD y `Narrative/Story/Main_Story.md` describen el juego en el manicomio; esa ambientación **no se borra**. La estación es el recorte de demo acordado en planificación ([#36](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/36), [#37](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/37), [#40](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/40)).

### Experiencia mínima (sin inventar beats)

Hasta que [#41](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/41) cierre el alcance narrativo, solo se da por planificado lo ya escrito en issues de demo:

- Un recorrido de estación ([#19](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/19)).
- Puzzle de la máquina expendedora ([#17](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/17)).
- Eventos de cordura de demo ([#18](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/18)).
- Encuentro con padres y cinemática inicial, a nivel de desglose ([#50](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/50), [#51](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/51)).
- Audio de estación en preparación, no master final ([#36](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/36)).

Comentario de Kai en #41 (2026-08-07), **aún no cerrado como spec**:

> la demo pilla un poco del manicomio. La estación sería el tutorial (muestra parte de las mecánicas principales y el primer diálogo con toma de decisiones)

Eso se trata como **hipótesis creativa a confirmar**, no como lista de beats aprobados. Ver sección 3 y `REQUIERE_REVISIÓN_KAI`.

### Sistemas mínimos

Los que el prototipo de demo necesita, no el juego completo:

- Movimiento lateral (ya existe en `Prototype_M1`; Sandbox en [#47](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/47)).
- Input de demo ([#45](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/45)).
- Interacción y diálogo de decisión (Sprint 2; el primer diálogo con decisión está señalado por Kai, detalle en #41/#43).
- Cordura y puzzle placeholder de estación ([#18](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/18), [#17](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/17)).
- Hook de audio ([#56](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/56), [#57](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/57)).
- UI mínima de demo ([#58](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/58)), no la épica completa de interfaces ([#34](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/34)).

Arquitectura de ese stack: [#3](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/3).

### Incluido

- Preproducción creativa de la estación (storyboard, beats, layout, moodboard, dirección de Asly para demo).
- Base técnica de Fase 0 ([#39](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/39)).
- Prototipo de la estación en Sprint 2.

### Excluido

- Desarrollo completo del Capítulo 1 / manicomio.
- Diálogos del Capítulo 1 ([#25](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/25)).
- Historia completa del Capítulo 1 ([#22](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/22)).
- Interfaces completas ([#34](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/34)).
- Producción completa de monstruos ([#35](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/35); el inventario de amenazas de demo es [#48](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/48)).
- Arte final, audio masterizado, Vertical Slice completa.

### Relación con Sprint 1

Sprint 1 (07/08/2026–27/08/2026): cierra preproducción y base técnica para que la demo pueda prototiparse. **No** implementa la estación final ni sistemas de juego del Sprint 2 salvo lo que una issue de Sprint 1 pida de forma explícita.

### Relación con Sprint 2

Sprint 2 prototipa la demo de la estación (input, interacción, diálogo, cordura, puzzle placeholder, audio hook) sobre el alcance que dejen #41 y este documento.

---

## 3. Capítulo 1 / manicomio

### Forma parte del proyecto

Sí. El GDD, la Narrative Bible y `Narrative/Story/Main_Story.md` sitúan el juego en un **manicomio infantil** (Acto 1: el ala de niños). Ese material **sigue siendo válido**.

### No se elimina

No se borra ni se reescribe la historia del manicomio para “hacer sitio” a la estación. Issues y documentos de Capítulo 1 permanecen como trabajo futuro.

### Fuera del Sprint 1 como bloque de desarrollo

El Sprint 1 no cierra la historia del Capítulo 1, no escribe sus diálogos y no construye el layout/arte/sistemas del manicomio como zona de producción activa.

Confirmado expresamente fuera del Sprint 1:

- [#22](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/22) NAR-001 — historia principal del Capítulo 1.
- [#25](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/25) NAR-004 — diálogos del Capítulo 1 (reclasificada a backlog / Cap.1 manicomio).

Documentación que se conserva (no se reescribe en #40):

- [GDD](../Documentation/02_GDD_Game_Design_Document.md)
- [Historia principal](../Narrative/Story/Main_Story.md)
- [Diálogos Capítulo 01](../Narrative/Dialogues/Chapter_01_Dialogues.md) (plantilla; contenido TBD)
- Fichas de personajes y lore del manicomio bajo `Narrative/`

### Transición / contexto en la demo — `REQUIERE_REVISIÓN_KAI`

Hay **contradicción abierta** entre planificación e hipótesis narrativa:

| Fuente | Afirmación |
| --- | --- |
| Cuerpo de #40 | Los primeros sprints trabajan la demo de la estación. El manicomio y el Capítulo 1 del GDD quedan fuera del Sprint 1. |
| Kai en #41 (2026-08-07) | La demo “pilla un poco del manicomio”. La estación sería el tutorial (mecánicas principales + primer diálogo con decisiones). |

Hasta que Kai cierre #41, este documento **no** afirma “manicomio totalmente fuera de la demo”. Distingue:

1. **Posible contenido de transición/contexto en la demo** — un fragmento aún no especificado. Detalle: #41 (y #43 cuando exista beat sheet). `REQUIERE_REVISIÓN_KAI`.
2. **Desarrollo completo del Capítulo 1 / manicomio** — aplazado. No es trabajo de implementación del Sprint 1.

No se inventa qué habitaciones, NPCs o beats del manicomio entran en esa fracción.

### Qué se pospone

Implementación y cierre creativo del Capítulo 1 como zona: layout del manicomio, diálogos de capítulo, historia de capítulo, arte de esa zona, sistemas asociados al ala más allá de lo que #41 autorice explícitamente para la demo.

---

## 4. Vertical Slice

En este proyecto la Vertical Slice **no** es la demo inicial de la estación.

La demo prueba que el recorte se puede prototipar. La Vertical Slice debe **representar el juego** con un nivel de fidelidad y pulido que permita decidir si el tono, el loop y la producción aguantan.

Definición operativa (sin inventar features no documentadas):

| Dimensión | Qué implica aquí |
| --- | --- |
| Alcance | Una zona completa jugable, no un stub técnico ni solo la preproducción de estación. |
| Fidelidad visual | Placeholder coherente con dirección artística, no arte final de release. |
| Fidelidad sonora | Música y ambience básicos de la zona, no master de todo el juego. |
| Pulido | Loop cerrado, readable y presentable internamente. |
| Representatividad | Debe sentir *Asly's Disorder* (exploración, tono, cordura, decisión), no un prototipo genérico 2D. |
| Sistemas | Varios sistemas del loop conectados (cordura con varios eventos, puzzles, diálogos con consecuencia), según [M2](03_Milestones.md) / [roadmap](01_Roadmap.md). |
| Objetivo de validación | ¿Se puede seguir produciendo el juego así? No: “¿abre Unity?” (eso ya es #38/#42). |

Los documentos de Production actuales describen M2 / Fase 2 / Q4 2026 como Vertical Slice con “una zona completa (normal + creepy)” e incluso “historia del capítulo 1 narrada” en [03_Milestones.md](03_Milestones.md). Esa formulación **mezcla VS y Capítulo 1**. No se reescribe aquí el pack de milestones (#6). Queda señalado:

`REQUIERE_REVISIÓN_KAI` + alineación en [#6](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/6): ¿la Vertical Slice es la estación pulida, la primera zona completa del manicomio, u otra zona?

No hay issues de GitHub etiquetadas de forma inequívoca como “solo Vertical Slice”. Ese backlog se planificará después de la demo.

---

## 5. Comparativa

| Aspecto | Demo estación | Capítulo 1 / manicomio | Vertical Slice |
| --- | --- | --- | --- |
| Objetivo | Prototipar un recorte jugable y el tono | Contar y jugar el primer capítulo del juego | Validar calidad y representatividad de producción |
| Contenido | Estación (+ posible fracción de manicomio, TBD Kai) | Ala / manicomio del GDD y narrativa | Zona completa representativa (definición de zona TBD) |
| Calidad | Placeholder / proto | Contenido de capítulo, no arte final de release | Placeholder coherente, loop pulido internamente |
| Alcance | Recorte de demo | Capítulo 1 completo | Una zona, varios sistemas conectados |
| Estado | Foco Sprint 1–2 | Conservado y aplazado | Posterior a la demo inicial |
| Fase | Preproducción (S1) + prototipo (S2) | Post-demo / planificación futura | Históricamente M2 / Fase 2; fechas a actualizar en #6 |
| Propósito | Desbloquear prototipo sin rehacer fundamentos | Núcleo narrativo del juego | Decidir si el juego “es esto” a nivel de producción |

---

## 6. Impacto sobre Sprint 1

El Sprint 1:

- Prepara la **demo de la estación** (alcance, beats, layout, audio, base técnica).
- Cierra preproducción creativa mínima y Fase 0 técnica ([#39](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/39)).
- **No** implementa el Capítulo 1 completo.
- **No** produce la Vertical Slice completa.
- **No** reescribe GDD ni narrativa del manicomio.

El pack de fechas, estado y riesgos se actualiza en [#6](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/6), no en esta issue.

---

## 7. Issues relacionadas

Clasificación solo con evidencia en GitHub (título, comentario de reclasificación o etiqueta `sprint-1`). Si no está claro, va a TBD.

### Demo / Sprint 1

**Fase 0 / producción y técnica**

- [#39](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/39) EPIC-001
- [#38](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/38) TECH-010 — Done (PR #60)
- [#40](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/40) PROD-010 — este documento
- [#42](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/42) TECH-011
- [#45](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/45) TECH-012
- [#46](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/46) TECH-013
- [#47](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/47) TECH-014
- [#49](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/49) TECH-015
- [#3](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/3) DOC-002
- [#5](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/5) DOC-004
- [#6](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/6) PROD-001
- [#59](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/59) PROD-012

**Preproducción demo estación / audio**

- [#37](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/37) EPIC-002
- [#36](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/36) EPIC-003
- [#41](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/41) NAR-010
- [#43](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/43) NAR-011
- [#44](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/44) ART-010
- [#28](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/28) ART-002
- [#19](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/19) DES-004
- [#17](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/17) DES-002
- [#18](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/18) DES-003
- [#48](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/48) DES-010
- [#50](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/50) NAR-012
- [#51](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/51) NAR-013
- [#52](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/52) DES-011
- [#53](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/53) ANIM-010
- [#54](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/54) AUD-010
- [#55](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/55) AUD-011
- [#56](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/56) AUD-012
- [#57](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/57) AUD-013
- [#58](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/58) DES-012

### Capítulo 1 / posterior

- [#22](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/22) NAR-001 — historia del Capítulo 1 (retirada del Project del Sprint 1).
- [#25](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/25) NAR-004 — diálogos del Capítulo 1 (backlog Cap.1 manicomio).

### Vertical Slice / posterior

Ninguna issue encontrada cuya clasificación inequívoca sea “solo Vertical Slice”. El hito histórico está en [03_Milestones.md](03_Milestones.md) (M2) y [01_Roadmap.md](01_Roadmap.md) (Q4 2026). El desglose en issues queda para planificación posterior / #6.

### Pendientes de clasificación

No se asignan a Cap.1 solo por haber salido del Project del Sprint 1:

- [#2](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/2) DOC-001 — GDD global; fuera del Sprint 1, no es Cap.1.
- [#23](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/23) NAR-002 — perfil amplio de Asly; #28 es el recorte de demo.
- [#29](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/29) ART-003 — “primer escenario”; el moodboard de estación es #44. ¿Manicomio, VS u otro? TBD.
- [#34](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/34) — épica de interfaces; UI de demo es #58.
- [#35](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/35) — diseño completo de monstruos; inventario de demo es #48.

---

## Referencias

- [#40](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/40), [#41](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/41), [#36](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/36), [#37](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/37)
- [Estado del proyecto](00_Project_Status.md)
- [Auditoría Unity Sprint 1](../Technical/Audits/Unity_Sprint1_Audit.md)
