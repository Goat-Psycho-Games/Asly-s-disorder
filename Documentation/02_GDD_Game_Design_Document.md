# Game Design Document

## 1. Resumen del juego

**Asly's Disorder** es una aventura narrativa 2D de scroll lateral con puzzles, exploracion pausada y terror psicologico. El jugador controla a Asly, una nina de 8 anos internada en un manicomio infantil que percibe dos capas del mismo lugar: el mundo normal y un mundo creepy deteriorado, simbolico y hostil.

La experiencia se construye alrededor de tres fuerzas conectadas:

- Las decisiones del jugador y sus consecuencias diferidas.
- La cordura oculta de Asly, entendida como su capacidad de confiar en lo que percibe.
- La transformacion de areas, puzzles, dialogos y personajes segun el estado mental y narrativo.

El objetivo del juego no es solo escapar fisicamente del manicomio. La pregunta principal es si Asly conservara su identidad, sus vinculos y su confianza en si misma cuando llegue al final.

## 2. Pilares de diseno

1. **Decisiones con consecuencias.** Cada eleccion relevante debe afectar dialogos, NPCs, eventos, cordura, rutas o finales. El juego evita respuestas claramente buenas o malas.
2. **Cordura oculta.** La cordura no se muestra como barra tradicional. El jugador la entiende por cambios de entorno, sonido, dialogo, UI, eventos y accesibilidad de rutas.
3. **Dos mundos conectados.** El mundo normal y el mundo creepy son estados de una misma area. No son niveles separados: comparten espacio, historia y consecuencias.
4. **Puzzles adaptativos.** Los puzzles pueden cambiar por cordura, mundo, decisiones, objetos o informacion descubierta.
5. **Vinculos como resistencia.** Las relaciones con otros ninos no son coleccionables narrativos; alteran la forma en que Asly atraviesa el manicomio.
6. **Rejugabilidad significativa.** Nuevos eventos, variantes de dialogo, finales y soluciones deben justificar volver a jugar sin depender de contenido arbitrario.

## 3. Camara y perspectiva

- Scroll lateral 2D.
- Movimiento horizontal.
- Sin salto.
- Sin correr.
- Exploracion pausada, con ritmo agil en desplazamientos cortos.
- La camara puede distorsionarse o temblar por eventos de cordura, pero no debe dificultar el control basico de forma injusta.

## 4. Loop jugable principal

1. Explorar una zona del manicomio.
2. Observar cambios, pistas, objetos y comportamientos de NPCs.
3. Interactuar con objetos, documentos, puertas y personajes.
4. Tomar decisiones explicitas o pasivas.
5. Resolver puzzles o desbloquear rutas.
6. Alterar el estado de cordura, area, NPCs o mundo.
7. Descubrir nueva informacion narrativa.
8. Avanzar hacia una nueva zona, variante o consecuencia.

El loop debe mantener una tension constante entre curiosidad y duda: explorar revela respuestas, pero tambien puede deteriorar la estabilidad de Asly o activar eventos indeseados.

## 5. Mecanicas principales

### Movimiento

Asly se mueve lateralmente por areas 2D. El control debe ser simple, deliberado y legible:

- Caminar izquierda/derecha.
- Girar hacia la direccion de movimiento.
- Detenerse con respuesta inmediata.
- Sin salto y sin carrera.
- Animaciones expresivas pero no invasivas.

La baja cordura puede alterar camara, sonido, luz o animacion, pero no debe cambiar la velocidad base del personaje salvo en eventos muy controlados.

Referencia tecnica: [Player_Controller.md](../Technical/Systems/Player_Controller.md)

### Interaccion

El jugador interactua con objetos, puertas, documentos, puzzles y NPCs cuando Asly esta en rango. Cada interactuable debe comunicar de forma clara si se puede usar, mirar, recoger, hablar o activar.

Reglas:

- La interaccion debe priorizar lectura y contexto narrativo.
- Un mismo objeto puede tener respuestas distintas segun cordura, mundo, decisiones u objetos.
- Mirar un objeto y usarlo pueden ser acciones distintas si el diseno lo requiere.
- Ignorar un objeto/NPC tambien puede ser registrado como decision pasiva.

Referencia tecnica: [Interaction_System.md](../Technical/Systems/Interaction_System.md)

### Dialogos

Los dialogos sirven para historia, pistas, decisiones, estado emocional y variaciones de cordura.

Requisitos de diseno:

- Los NPCs deben reaccionar a decisiones previas y estado de cordura.
- Algunas opciones de dialogo pueden no estar disponibles segun vinculo, informacion u objeto.
- Las respuestas no deben revelar siempre la consecuencia exacta.
- Los dialogos deben poder ramificarse y aplicar consecuencias.

Referencia tecnica: [Dialogue_System.md](../Technical/Systems/Dialogue_System.md)

### Decisiones

El juego registra decisiones explicitas y pasivas:

- Elegir una opcion de dialogo.
- Ayudar, ignorar o traicionar a un NPC.
- Usar un objeto en un momento concreto.
- Resolver un puzzle por una ruta normal o creepy.
- Explorar o evitar una zona.
- Leer o no leer informacion perturbadora.

Las consecuencias pueden ser inmediatas, diferidas o acumulativas. El jugador no debe sentir que el juego le castiga al azar: las consecuencias deben poder entenderse en retrospectiva.

Referencia: [Decision_System.md](../Design/Mechanics/Decision_System.md)

### Puzzles

Los puzzles deben estar integrados en la narrativa y en el espacio. Cada puzzle importante debe tener proposito dramatico, no solo funcionar como cerradura.

Tipos previstos:

- Objetos combinables.
- Observacion del entorno.
- Secuencias.
- Dialogos con NPCs.
- Manipulacion de entorno.
- Puzzles dependientes de cordura o mundo.

Reglas:

- Ningun puzzle debe bloquear el progreso de forma injusta.
- Las pistas pueden alterarse, pero siempre debe existir una solucion deducible.
- Un puzzle puede tener version normal, version alterada y version creepy.
- La solucion elegida puede afectar cordura, vinculos o rutas.

Referencia: [07_Puzzle_Design_Document.md](07_Puzzle_Design_Document.md)

### Cordura

La cordura es una variable oculta que representa la confianza de Asly en su percepcion y su resistencia frente a la presion del manicomio. No mide simplemente "locura".

Rangos base:

| Rango | Estado | Funcion jugable |
| --- | --- | --- |
| 80-100 | Stable | Mundo normal, dialogos fiables, puzzles logicos. |
| 60-79 | Uneasy | Cambios sutiles, sonidos, pequenas variaciones. |
| 40-59 | Distorted | NPCs raros, pistas dudosas, distorsiones leves. |
| 20-39 | Broken | Apariciones, puzzles alterados, rutas inestables. |
| 0-19 | OtherWorld | Mundo creepy activo, zonas y personajes transformados. |

La cordura baja por eventos traumaticos, decisiones violentas o egoistas, fallos concretos, zonas oscuras, documentos perturbadores o contacto con objetos creepy. Puede estabilizarse mediante vinculos, recuerdos, decisiones empaticas y resolucion coherente de puzzles.

Referencia: [08_Sanity_System_Document.md](08_Sanity_System_Document.md)

### Cambio de mundo

El mundo normal, distorted y creepy son estados de area. Las transiciones pueden activarse por cordura critica, decisiones narrativas, eventos predefinidos o resolucion de puzzles.

Principios:

- La transicion debe sentirse como consecuencia, no como teleport mecanico.
- Algunas transiciones son temporales.
- Algunas son permanentes para esa partida.
- El mundo creepy puede abrir rutas nuevas, cerrar rutas normales o cambiar el significado de un puzzle.

Referencia: [09_World_Switching_Document.md](09_World_Switching_Document.md)

## 6. Protagonista

Asly es una nina de 8 anos internada tras anos describiendo "el otro lado" de la realidad. Es curiosa, observadora y todavia no ha sido quebrada por la institucion.

Su vulnerabilidad principal es la duda: si todo el entorno insiste en que lo que ve no es real, la pregunta es cuanto tiempo puede seguir creyendose a si misma. Su arco no se centra solo en escapar, sino en decidir que conservar de si misma y de sus vinculos.

Referencia: [Protagonist.md](../Narrative/Characters/Protagonist.md)

## 7. NPCs

Los NPCs principales son otros ninos del ala. Cada vinculo debe funcionar como:

- Fuente de informacion narrativa.
- Variacion de dialogos y escenas.
- Posible modificador de cordura.
- Condicion para eventos, rutas o finales.
- Reflejo tematico de la institucion y sus danos.

NPCs principales documentados:

| NPC | Funcion narrativa inicial |
| --- | --- |
| Nirdos | Presencia silenciosa, paciencia, comunicacion no verbal. |
| Jhona | Orgullo, fantasia de princesa, defensa contra el abandono. |
| Johan | Relacion con munecas, cuidado, incomodidad adulta. |
| Gris | Historias, imaginacion, libreta, tics. |
| Helen | Miedo a ser observada, fragilidad, confianza gradual. |

Referencia: [NPC_List.md](../Narrative/Characters/NPC_List.md)

## 8. Monstruos y amenazas

Los monstruos no deben ser enemigos genericos. Deben representar presiones del manicomio, recuerdos, sintomas institucionalizados o deformaciones del mundo normal.

Funciones posibles:

- Presencia ambiental.
- Evento de cordura.
- Obstaculo de ruta.
- Manifestacion de un personaje o decision.
- Elemento de puzzle.

El juego no se define por combate. Si hay amenaza directa, debe resolverse por evasion, lectura del entorno, decision, objeto o puzzle.

## 9. Progresion

La progresion combina avance espacial, informacion narrativa y estado sistemico.

Capas de progresion:

- Zonas desbloqueadas.
- Objetos recogidos.
- Puzzles resueltos.
- NPCs conocidos o ayudados.
- Decisiones registradas.
- Eventos de cordura vistos.
- Estados de area cambiados.
- Informacion sobre Asly, el manicomio y el mundo creepy.

Estructura narrativa base:

1. **Acto 1: El ala de ninos.** Presentacion de Asly, NPCs, rutinas y primeras anomalias.
2. **Acto 2: Lo que esta debajo.** Vinculos mas profundos, historia fragmentada del manicomio y mayor presion institucional.
3. **Acto 3: El momento de elegir.** Resolucion segun cordura, decisiones, vinculos e informacion descubierta.

Referencia: [Main_Story.md](../Narrative/Story/Main_Story.md)

## 10. Rejugabilidad

La rejugabilidad debe surgir de sistemas conectados, no de contenido aleatorio sin contexto.

Factores rejugables:

- Diferentes estados de cordura al llegar a escenas clave.
- NPCs ayudados, ignorados o afectados.
- Puzzles resueltos en version normal o creepy.
- Eventos de cordura vistos o evitados.
- Dialogos alternativos.
- Rutas bloqueadas o abiertas por decisiones.
- Finales determinados por acumulacion de decisiones, cordura y vinculos.

Referencia: [Endings.md](../Design/Replayability/Endings.md)

## 11. Condiciones de victoria y derrota

### Victoria

El juego se completa al alcanzar un desenlace coherente con la partida. No debe existir un unico final "correcto" evidente.

Condiciones que influyen en el final:

- Cordura acumulada.
- Decisiones clave.
- NPCs ayudados o ignorados.
- Eventos vistos.
- Informacion descubierta.
- Puzzles resueltos por rutas normales o creepy.

### Derrota

La derrota tradicional debe usarse con cautela. El juego puede incluir fallos temporales, bloqueos narrativos o consecuencias duras, pero no debe depender de morir repetidamente.

Posibles estados de fallo:

- Perder acceso a una ruta o informacion.
- Provocar una consecuencia irreversible.
- Activar un evento peligroso.
- Alcanzar un final desfavorable por acumulacion de decisiones.

## 12. Guardado

El guardado debe persistir todo lo necesario para reconstruir la partida:

- Cordura.
- Area actual.
- Posicion del jugador.
- Decisiones tomadas.
- Objetos recogidos.
- NPCs hablados o afectados.
- Eventos activados.
- Estados de areas.
- Puzzles resueltos.
- Tiempo de juego.

Decision pendiente: numero de slots y reglas de guardado manual/automatico.

Referencia tecnica: [Save_System.md](../Technical/Systems/Save_System.md)

## 13. UI/UX

La UI debe ser discreta, legible y coherente con el tono. No debe convertir la cordura en una barra numerica directa.

Elementos previstos:

- Indicador contextual de interaccion.
- Caja de dialogo.
- Opciones de dialogo.
- Inventario simple o menu de objetos.
- Menu de pausa.
- Feedback visual/sonoro de decisiones y eventos.
- Distorsiones puntuales por cordura.

Reglas:

- Priorizar claridad sobre decoracion.
- Evitar explicar todos los sistemas al jugador.
- Usar la UI como parte de la atmosfera cuando la cordura baja.
- Mantener accesibilidad basica: lectura clara, ritmo controlable en dialogos y confirmaciones para acciones importantes.

## 14. Estilo visual

El juego usa estetica 2D dibujada a mano. El mundo normal debe sentirse gastado, triste y cotidiano; el mundo creepy debe ser una deformacion psicologica y simbolica de ese mismo espacio.

Principios:

- Lineas irregulares y expresivas.
- Textura organica: papel, acuarela, lapiz.
- Animacion fluida pero no hiperrealista.
- Contraste fuerte entre normal y creepy sin depender solo de oscurecer la imagen.
- Monstruos y escenarios relacionados con historia y personajes.

Referencias:

- [04_Art_Bible.md](04_Art_Bible.md)
- [00_Art_Direction.md](../Art_Bible/00_Art_Direction.md)
- [07_Normal_vs_Creepy_World.md](../Art_Bible/07_Normal_vs_Creepy_World.md)

## 15. Sonido y musica

El audio debe reforzar cordura, mundo y tension institucional.

Categorias:

- Musica.
- SFX.
- Ambience.
- Voces o vocalizaciones.

La musica y el ambience deben variar por estado mental:

- Stable: capa normal del area.
- Uneasy: tension sutil.
- Distorted: filtrado, ruido o desajuste.
- Broken: sonidos perturbadores y presencia.
- OtherWorld: identidad sonora del mundo creepy.

Decision pendiente: implementacion final con AudioSource, Unity Audio Mixer o middleware.

Referencia tecnica: [Audio_System.md](../Technical/Systems/Audio_System.md)

## 16. Alcance del prototipo M1

El primer prototipo funcional debe demostrar el loop minimo:

- Movimiento lateral basico.
- Interaccion con al menos un objeto.
- Dialogo simple con un NPC.
- Variable de cordura funcional.
- Un evento de cordura observable.
- Cambio entre dos espacios o estados de area.
- Un puzzle pequeno o interaccion con solucion.

Este alcance debe validar sensacion de control, lectura del tono y conexion entre cordura, interaccion y mundo.

## 17. Pendientes de diseno

- Definir publico objetivo final.
- Definir plataformas adicionales a PC Windows.
- Estimar duracion objetivo.
- Cerrar lista de finales.
- Cerrar numero de slots y reglas de guardado.
- Completar lista de monstruos/amenazas.
- Completar primer puzzle implementable.
- Completar estructura de capitulos y zonas.
