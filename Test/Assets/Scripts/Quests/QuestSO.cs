using UnityEngine;

[CreateAssetMenu(fileName = "NewQuestData", menuName = "Quests/Quest data")]
public class QuestSO : ScriptableObject
{
    // Какое количество чего сделать/принести
    public int Goal = 1; 
    // Название квеста
    public string QuestName;
    // Описание квеста
    public string QuestDescription;
    // Награда (например, XP)
    public int Reward = 0;
    // ID квеста
    public int QuestId;

    // Уведомление о начале квеста; если перезашли на сцену - вызвать ещё раз  
    public bool NeedRestartEvent = false;
    // Для выезда панельки с инфой о начале/завершении квеста
    public bool HasStartAnimation = true;
    public bool HasFinishAnimation = true;

}
