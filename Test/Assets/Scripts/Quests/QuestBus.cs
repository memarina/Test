using System;
using UnityEngine.UI;

public class QuestBus
{   
    // синглтон
    private static QuestBus instance;
    public static QuestBus GetInstance()
    {
        if (instance == null)
        {
            instance = new QuestBus();
        }
        return instance;
    }

    // счётчик прогресса: id + сам счётчик
    public Action<int, int> OnUpdateCounter;
    // для view: обновление состояния в интерфейсе
    public Action OnUpdateData;
    // начало квеста: id квеста 
    public Action<int> OnStart;
    // для цвета уведомления по квесту 
    public Action<QuestData, Image> OnHighlighted;
    // выделение квеста по кнопке
    public Action<QuestData> OnSelect;
    // прерывание квеста
    public Action<QuestData> OnInterrupt;
}
