# Git LFS

Guía breve para incorporar arte y audio al repositorio **Goat-Psycho-Games/Asly-s-disorder** sin inflar el historial.

Issue: [#46 TECH-013](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/46)

La fuente de las reglas es [`.gitattributes`](../.gitattributes). No se migra historial existente.

## Instalación inicial

Una vez por máquina, **en este repositorio**:

```powershell
git lfs install --local
```

Comprobar:

```powershell
git lfs version
```

Hace falta Git LFS 3.x (en la auditoría de Sprint 1 se usó `git-lfs/3.7.1`).

## Clonar o actualizar el repo

Tras `git clone` o `git pull`:

```powershell
git lfs pull
```

Sin ese paso, los archivos LFS pueden verse como punteros de texto (`version https://git-lfs.github.com/spec/v1`) en lugar del binario real.

## Qué va a LFS y qué no

| Va a Git LFS | Se queda en Git normal |
| --- | --- |
| Fuentes de arte: `.psd`, `.psb`, `.kra`, `.clip`, `.aseprite`, `.blend` | Código, Markdown, YAML |
| Audio: `.wav`, `.flac`, `.aiff`, `.ogg`, `.mp3` | Escenas `.unity`, prefabs, `.asset`, `.meta`, `.mat`, `.anim`, `.controller` |
| Vídeo: `.mp4`, `.mov`, `.webm` | Sprites PNG/JPG **dentro de** `UnityProject/Assets/` |
| Modelos: `.fbx`, `.glb` | |
| PNG/JPG de **referencia** en `References/`, `Art_Bible/References/`, `Marketing/` | |

Un PNG pequeño de sprite de Unity **no** usa LFS. Las referencias y moodboards grandes **sí**, si se guardan en las carpetas de referencia.

Si un texture de Unity supera ~2 MB, no lo subas “porque sí”: habla con Iago y se añade una regla de ruta concreta.

## Saber qué está bajo LFS

Listar patrones del repo:

```powershell
git lfs track
```

Comprobar un archivo o extensión (aunque el archivo aún no exista):

```powershell
git check-attr filter -- ruta/al/archivo.wav
git check-attr filter -- UnityProject/Assets/_Project/Art/Characters/PrototypePlayer.png
```

Si aplica LFS, `filter` debe ser `lfs`. Si no aplica, será `unspecified`.

Listar archivos ya pointer-izados:

```powershell
git lfs ls-files
```

Hoy el historial no tiene binarios LFS; la lista puede estar vacía y es correcto.

## Añadir un tipo nuevo

`git lfs track "*.ext"` **modifica** `.gitattributes`.

1. Propón el cambio a Iago.
2. Revisa el diff de `.gitattributes`.
3. Haz commit de `.gitattributes` en una rama de issue.
4. No edites `.gitattributes` a mano en `main`.

## Añadir assets

1. Confirma la carpeta correcta (runtime Unity vs `References/` / audio).
2. `git check-attr filter -- tu-archivo`.
3. `git add -- ruta/concreta` (nunca `git add .` ni `git add -A`).
4. `git status` y `git diff --cached --stat`.
5. Commit en la rama de la issue.

Los `.meta` de Unity se commitean **junto** al asset cuando el archivo vive en `UnityProject/Assets/`.

## Verificar antes de push

```powershell
git lfs ls-files
git check-attr filter -- ruta/del/binario
```

Si el binario aparece entero en `git diff` como texto corrupto o como archivo enorme en Git normal, **no hagas push**. Revisa las reglas.

## Qué evitar

- Subir binarios grandes sin `git check-attr`.
- Editar `.gitattributes` sin revisión.
- Migrar historial (`git lfs migrate`) por iniciativa propia.
- Usar `git add .` / `git add -A` (incluye Library, `_Recovery` y paquetes locales).
- Borrar o reescribir a mano los punteros LFS (`oid sha256:...`).
- Meter en Git: `Library/`, `Temp/`, `Logs/`, `_Recovery/`.

No hace falta reescribir el historial actual: el archivo binario trackeado más grande del producto es un YAML de ~26 KB. El PNG de placeholder pesa 216 bytes.

### Para arte (Toku)

- Fuentes (PSD, Krita, Clip Studio, Aseprite): al repo con LFS, no solo el export.
- Moodboards y referencias: `References/` o `Art_Bible/References/` (PNG/JPG ahí van a LFS).
- Sprites que Unity usa en runtime: `UnityProject/Assets/_Project/Art/` como PNG/JPG normales de Git, salvo que sean muy pesados.
- No subas packs ZIP de referencias.

### Para audio (Kris / Niru)

- `.wav` / `.flac` / `.ogg` / `.mp3` van a LFS.
- Colócalos en `UnityProject/Assets/_Project/Audio/` (`Music/`, `SFX/`, `Ambience/`, `Voices/`) cuando sean assets de Unity, con su `.meta`.
- Maquetas y refs que no entran al juego: `References/` (sigue aplicando LFS por extensión de audio).
- El naming de librería es [#55](https://github.com/Goat-Psycho-Games/Asly-s-disorder/issues/55); esta guía no lo sustituye.
- No subas el master final de la demo hasta que esa issue lo pida.

## Primer uso en una máquina nueva

```powershell
git lfs install --local
git lfs pull
git lfs track
```
