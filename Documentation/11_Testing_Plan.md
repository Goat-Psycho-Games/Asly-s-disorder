# Testing Plan

## Objetivos del testing

- Verificar que el sistema de cordura funciona correctamente.
- Verificar que los puzzles son solucionables en todos sus estados.
- Verificar que las transiciones de mundo son coherentes.
- Verificar que las decisiones tienen consecuencias correctas.
- Verificar que no hay bloqueos de progresión.

## Tipos de testing

| Tipo             | Descripción                                                |
| ---------------- | ---------------------------------------------------------- |
| Funcional        | Que cada mecánica funciona como se documentó.              |
| De regresión     | Que los cambios no rompen lo que funcionaba.               |
| De jugabilidad   | Que el juego es comprensible y satisfactorio.              |
| De narrativa     | Que la historia tiene coherencia en todas las ramas.       |
| De cordura       | Que los eventos de cordura se disparan correctamente.      |
| De puzzles       | Que todos los puzzles son solucionables.                   |

## Checklist mínimo por build

- [ ] El jugador puede moverse correctamente.
- [ ] La interacción funciona en todos los objetos marcados.
- [ ] Los diálogos se muestran correctamente.
- [ ] El sistema de cordura sube/baja según las acciones.
- [ ] Al menos un evento de cordura se dispara correctamente.
- [ ] Los puzzles son solucionables.
- [ ] El guardado y carga funcionan.
- [ ] No hay errores en consola de Unity.

## TBD

- Plantilla de informe de bug.
- Proceso de reporte interno.
