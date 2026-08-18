# Alcance de producto — Demo, Capítulo 1 y Vertical Slice

**Issue:** [#40 PROD-010](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/40)
**Fecha:** 2026-08-18
**Estado:** Alcance actualizado tras revisión creativa de Kai.

| Campo | Valor |
| --- | --- |
| `KAI_REVIEW_RECEIVED` | YES |
| Fecha de revisión | 2026-08-18 |
| Resultado | Estación/tutorial confirmada. Recorte de manicomio de demo aclarado. Relación Demo ⊂ inicio del manicomio / Capítulo 1 = expansión. Contenido concreto de Vertical Slice pendiente. |

Este documento es la referencia de **alcance de producto**. No sustituye al GDD, a la Narrative Bible ni al beat sheet ([#41](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/41), [#43](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/43)). No borra el contenido del manicomio.

---

## 1. Propósito

Hay tres capas de alcance. No son intercambiables.

| Capa | Función |
| --- | --- |
| **Demo** | Recorte jugable de los primeros sprints: tutorial en la estación **más** una sección limitada del manicomio (`MANICOMIO_DEMO`). |
| **Capítulo 1 / manicomio completo** | Expansión y desarrollo de esa parte narrativa. El contenido del GDD se conserva. |
| **Vertical Slice** | Hito posterior de representatividad y pulido. **No** es la demo. El fragmento concreto es `TBD`. |

La interpretación anterior (“el manicomio solo como transición/contexto, fuera de la demo”) **ya no es correcta**.

---

## 2. Demo

### Objetivo

Entregar un recorte corto y representativo que:

- presenta a Asly y su situación;
- enseña controles e interacción;
- muestra decisiones con consecuencia;
- entra en el manicomio de forma jugable pero **limitada**;
- termina antes del Capítulo 1 completo.

Sprint 1: preproducción y base técnica. Sprint 2: prototipo de este recorte. La demo **no** es la Vertical Slice.

### Composición

```
DEMO = ESTACIÓN (tutorial) + MANICOMIO_DEMO (sección jugable limitada)
```

### Mecánicas que la demo pretende representar

- Interacción.
- Decisiones y consecuencias.
- Misiones.
- Documentos.
- Exploración.
- Personajes principales (en el recorte, no el elenco completo).
- Mundo Locura mediante menciones/apariciones (sin gameplay completo de ese mundo).
- Componente emocional/narrativo.
- Música asociada al estado emocional / mental de Asly.

Puzzles: **solo si** se aprueba una propuesta concreta. No hay sistema de puzzle cerrado en #40.

### Relación con el juego final

La **estación se mantiene completa** en el juego final. No es contenido desechable de prototipo. Entre demo y juego deberían cambiar sobre todo **pulido y ajustes**, no la estructura narrativa principal de esa secuencia.

Eso **no** implica `ESTACIÓN = VERTICAL SLICE`.

---

## 3. Estación — tutorial de la demo

`ESTACIÓN = TUTORIAL DE LA DEMO` (Kai, 2026-08-18). Debe ser **relativamente corta**.

Introduce, de forma confirmada a nivel de alcance:

- Asly y su situación.
- Cinemática relacionada con el abandono de sus padres.
- Explicación inicial de controles mediante diálogo.
- Primeros objetos interactivos.
- Un primer objeto de misión.
- Primer diálogo con decisiones y consecuencias.
- NPC **Edd**.
- Consecuencia visible de esas decisiones **al subir al tren**:
  - Asly sola;
  - separados;
  - sentados juntos.
- Música que acompaña emociones y estado mental de Asly.

Propuesta de Toku (minipuzzle de máquina expendedora: recuperar una pieza que falta para introducir que existirán puzzles): **`TBD / propuesta pendiente de validación`**. No está confirmada. Existe la issue [#17](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/17); no equivale a aprobación creativa.

El detalle de beats, textos y layout de estación corresponde a [#41](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/41), [#43](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/43), [#50](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/50), [#51](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/51) y [#19](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/19).

---

## 4. Manicomio de demo vs Capítulo 1

Hay que distinguir:

| Código | Significado |
| --- | --- |
| `MANICOMIO_DEMO` | Sección **jugable limitada** del manicomio **dentro de la demo**. |
| `CAPITULO_1_COMPLETO` | Desarrollo completo de esa parte narrativa y de sus espacios. |

Relación:

```
DEMO ⊂ parte inicial del contenido del manicomio
CAPÍTULO 1 = expansión / desarrollo completo de esa parte
```

El Capítulo 1 **no** empieza “después de abandonar toda la demo del manicomio” como si fueran mundos distintos. La demo enseña una versión limitada del entorno, personajes y sistemas.

### 4.1 Recorte `MANICOMIO_DEMO` (alcance, no beat sheet)

**Llegada (confirmada a nivel conceptual)**

Cinemática del tren / llegada. Preparación de Asly para la estancia:

- corte de pelo;
- entrega de ropa;
- retirada de mochila;
- Asly esconde su osito.

El osito es importante narrativamente.

**Entrada**

Diálogo corto con una enfermera durante el registro: Kai lo considera posible. **`TBD`**. No está decidido.

**Inicio jugable (confirmado a nivel conceptual)**

El gameplay del manicomio empieza con Asly en su habitación. Debe cambiarse de ropa. Aparece el **doctor Klaus**: se muestra amable, busca generar confianza, detecta el osito y se lo retira (Asly no puede tenerlo). Eso establece la misión principal de **recuperar el osito**.

**Primer bloque social**

Otro niño informa a Asly de que el osito probablemente está en el despacho y que solo podrá intentar llegar de noche. El nombre **no** está cerrado. Kai mencionó “Johann”; la documentación canónica usa **Johan** ([NPC_Johan.md](../Narrative/Characters/NPC_Johan.md)). No se consolida “Johann” como nombre definitivo. `TBD` de identidad.

**Tiempo libre / día**

Puede contener interacción con pacientes y personal, documentos, misiones secundarias, introducción de NPCs (sobre todo niños) y aparición de “manchitas”. Las misiones concretas: **`TBD`**.

**Espacios (mínimo aproximado, no layout cerrado)**

Kai plantea como mínimo del orden de: habitación de Asly, habitación de niños, habitación de adolescentes, baño, pasillo. Puede haber más. El mapa lo cierra diseño/layout ([#19](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/19) no cubre el manicomio; el layout de esta zona es trabajo posterior).

**Opción de dormir**

El jugador puede saltarse parte del tiempo libre e ir a dormir.

**Noche (planteada, no cada beat cerrado)**

La falta del peluche y/o haber dormido de día justifica que Asly siga despierta. De noche se amplían zonas accesibles. Kai **plantea** (posibilidades, no diseño final): habitación de niños, baño, pasillo adicional hacia despacho, zona de médicos/vestuarios, referencias a Sammy, posible movimiento de un cuadro, visión del doctor entrando en zona de adolescentes.

**Cierre de demo (confirmado a nivel conceptual)**

El objetivo general lleva hacia la zona del despacho. La demo termina con una **introducción de Coraline**: pequeña cinemática, imagen in-game, texto sobre fondo negro, mención/introducción del Mundo Locura, **sin** gameplay completo de ese mundo.

### 4.2 Capítulo 1 completo

Se conserva. No se elimina. La demo no lo sustituye.

Puede ampliar, entre otras cosas aún no cerradas: planta infantil, enfermería, otras habitaciones, planta inferior, comedor, patio, consultas y espacios por diseñar. **Kai debe decidir el mapa definitivo.**

Pendiente narrativo, **fuera del alcance de #40**:

- Capítulo 1 largo centrado en el arco del doctor;
- o dividir ese arco en dos capítulos.

`TBD narrativo / fuera del alcance de #40`

Función narrativa general del Capítulo 1 (clara a alto nivel):

- introducir NPCs relevantes;
- mostrar progresivamente que algo no está bien;
- usar a Coraline como guía;
- permitir que jugador/Asly saquen conclusiones sobre Klaus y otros adultos;
- introducir progresivamente Mundo Locura y el universo.

Issues de Capítulo 1 que siguen fuera del Sprint 1 como cierre de capítulo:

- [#22](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/22) historia del Capítulo 1.
- [#25](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/25) diálogos del Capítulo 1.

---

## 5. Vertical Slice

`VERTICAL_SLICE_CONTENT=TBD`

Kai no ha seleccionado inequívocamente el fragmento. **No** se declara si será estación, estación + manicomio, una zona del manicomio u otro recorte.

Sí queda definida **conceptualmente**:

- hito posterior a la demo inicial;
- fragmento representativo;
- sistemas integrados;
- mayor fidelidad visual y sonora;
- mayor pulido;
- objetivo: demostrar cómo se sentirá el juego terminado.

No es “otra demo” ni “la estación a calidad final por el hecho de conservarse en el juego”.

La M2 histórica en [03_Milestones.md](03_Milestones.md) (“historia del capítulo 1 narrada”) **sigue mezclando** VS y Capítulo 1. Se resuelve en [#6](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/6). Este documento **no** reescribe milestones.

---

## 6. Comparativa

| Aspecto | Demo | Capítulo 1 / manicomio completo | Vertical Slice |
| --- | --- | --- | --- |
| Objetivo | Recorte corto: tutorial estación + `MANICOMIO_DEMO` | Expandir y completar esa narrativa | Validar calidad y “cómo se siente el juego” |
| Contenido | Estación (se conserva en el juego) + sección limitada del manicomio | Espacios y arcos ampliados; mapa TBD | `TBD` |
| Calidad | Placeholder / proto | Contenido de capítulo, no release final | Mayor fidelidad y pulido que la demo |
| Alcance | Limitado y cerrado como recorte | Capítulo (o más, si se divide el arco: TBD) | Un fragmento representativo |
| Estado | Foco Sprint 1–2 | Conservado; se desarrolla después de la demo | Posterior; contenido concreto abierto |
| Propósito | Prototipar loop, tono y recorte aprobado | Núcleo narrativo del tramo manicomio | Decisión de producción / representatividad |

---

## 7. Decisiones abiertas

No son requisitos de #40 mientras no se cierren:

- Minipuzzle de máquina expendedora (propuesta Toku / [#17](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/17)).
- Diálogo con enfermera en el registro.
- Misiones secundarias concretas del tiempo libre.
- Aparición explícita de monstruos en este recorte.
- Habitaciones adicionales y layout completo.
- Nombre definitivo del niño que informa sobre el despacho (no usar “Johann” como canónico).
- Alcance exacto de eventos nocturnos expresados como posibilidad (Sammy, cuadro, vestuarios, etc.).
- Mapa definitivo del Capítulo 1.
- Si el arco del doctor es un capítulo o dos (`TBD narrativo`).
- Qué contenido será la Vertical Slice.

Ideas formuladas como “puede”, “estoy dudando”, “tengo que decidir”, “no sé si” o “quizás” **no** se tratan como requisitos.

Pendiente de Kai (pregunta específica, no parte del cierre de las tres respuestas de alcance): **qué fragmento será la Vertical Slice**.

---

## 8. Impacto sobre Sprint 1

El Sprint 1:

- Prepara la **demo** (estación-tutorial + `MANICOMIO_DEMO`), no la Vertical Slice.
- Cierra preproducción y Fase 0 técnica ([#39](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/39)).
- **No** implementa el `CAPITULO_1_COMPLETO`.
- **No** produce la Vertical Slice.
- **No** reescribe GDD ni Narrative Bible; el detalle de beats va a #41/#43.

El pack de fechas, estado por área y riesgos: [#6](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/6).

---

## 9. Issues relacionadas

La clasificación de GitHub **no cambia** porque Kai haya aclarado alcance: las issues de Cap.1 completo (#22, #25) siguen fuera del Sprint 1 como cierre de capítulo. Las de demo/estación siguen siendo el trabajo activo. El recorte `MANICOMIO_DEMO` se desglosará en #41/#43 y tareas de diseño; no se inventan issues aquí.

### Demo / Sprint 1

**Fase 0 / producción y técnica:** [#39](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/39), [#38](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/38) (Done), [#40](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/40), [#42](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/42), [#45](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/45), [#46](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/46), [#47](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/47), [#49](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/49), [#3](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/3), [#5](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/5), [#6](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/6), [#59](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/59).

**Preproducción demo:** [#37](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/37), [#36](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/36), [#41](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/41), [#43](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/43), [#44](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/44), [#28](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/28), [#19](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/19), [#17](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/17) (propuesta, no confirmada), [#18](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/18), [#48](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/48), [#50](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/50), [#51](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/51), [#52](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/52), [#53](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/53), [#54](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/54), [#55](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/55), [#56](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/56), [#57](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/57), [#58](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/58).

### Capítulo 1 / posterior (cierre de capítulo, no el recorte de demo)

- [#22](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/22) NAR-001
- [#25](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/25) NAR-004

### Vertical Slice / posterior

Ninguna issue inequívocamente “solo VS”. Contenido: `TBD`. Hito histórico: M2 / Q4 2026.

### Pendientes de clasificación (sin cambio)

[#2](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/2), [#23](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/23), [#29](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/29), [#34](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/34), [#35](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/35).

---

## Referencias

- [#40](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/40), [#41](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/41), [#36](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/36), [#37](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/37)
- [Estado del proyecto](00_Project_Status.md)
- [Johan (canónico)](../Narrative/Characters/NPC_Johan.md)
- [Auditoría Unity Sprint 1](../Technical/Audits/Unity_Sprint1_Audit.md)
