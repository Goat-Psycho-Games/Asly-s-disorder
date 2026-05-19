# Sistema de guardado (técnico)

## Descripción

El sistema de guardado persiste el estado del juego entre sesiones.

## Qué se guarda

```csharp
[Serializable]
public class SaveData
{
    public float sanity;
    public string currentArea;
    public Vector3 playerPosition;
    public Dictionary<string, bool> decisionsLog;
    public Dictionary<string, bool> itemsPickedUp;
    public Dictionary<string, bool> npcsTalkedTo;
    public Dictionary<string, bool> eventsTriggered;
    public Dictionary<string, string> areaStates;
    public Dictionary<string, bool> puzzlesSolved;
    public float playTime;
}
```

## Implementación

- Serialización: JSON (JsonUtility o Newtonsoft.Json).
- Ruta: `Application.persistentDataPath`.
- Slots: TBD.

## SaveManager

```csharp
public class SaveManager : MonoBehaviour
{
    public void Save(int slot) { }
    public SaveData Load(int slot) { }
    public bool HasSave(int slot) { }
    public void DeleteSave(int slot) { }
}
```

## Ver también

- [Save_System.md](../../Design/Mechanics/Save_System.md)
- [Save_Data_Format.md](../Data/Save_Data_Format.md)
