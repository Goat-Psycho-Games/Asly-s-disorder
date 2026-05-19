# Formato de datos de guardado

## Descripción

Define el formato del archivo de save del juego.

## Formato

JSON serializado desde la clase `SaveData`.

## Estructura del save

```json
{
  "sanity": 75.0,
  "currentArea": "AREA_001",
  "playerPosition": { "x": 10.5, "y": 0.0, "z": 0.0 },
  "decisionsLog": {
    "DEC_NAR_001_A": true,
    "DEC_NAR_002_B": true
  },
  "itemsPickedUp": {
    "ITEM_001": true,
    "ITEM_002": false
  },
  "npcsTalkedTo": {
    "NPC_001": true
  },
  "eventsTriggered": {
    "SAN_EVENT_001": true
  },
  "areaStates": {
    "AREA_001": "Normal",
    "AREA_002": "Creepy"
  },
  "puzzlesSolved": {
    "PUZ_001": true
  },
  "playTime": 3620.5
}
```

## Ruta del archivo

`Application.persistentDataPath + "/save_slot_X.json"`

## Ver también

- [Save_System.md](../Systems/Save_System.md)
