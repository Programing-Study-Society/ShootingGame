using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class canClick : MonoBehaviour
{
    public List<Button> buttonList; // �S�Ẵ{�^���������ɒǉ�
    
    private int activeButtonIndex = -1; // ���݃A�N�e�B�u�ȃ{�^���̃C���f�b�N�X

    public void OnButton(int buttonIndex)
    {
        // ���݂̃{�^����������Ă���ꍇ
        if (activeButtonIndex == buttonIndex)
        {
            // Image���\���ɂ��āA�S�{�^�����ēx�L��������
            SetButtonsInteractable(true);
            activeButtonIndex = -1; // �A�N�e�B�u�ȃ{�^���Ȃ��ɖ߂�
        }
        else
        {
            // ���ׂẴ{�^���𖳌������A�����ꂽ�{�^����Image�̂ݕ\��
            SetButtonsInteractable(false);
            buttonList[buttonIndex].interactable = true; // ���݂̃{�^�������L���ɂ��Ă���
            activeButtonIndex = buttonIndex; // �A�N�e�B�u�ȃ{�^�����X�V
        }
    }

    // �S�{�^�����ꊇ�ŗL��/�����ɂ���
    private void SetButtonsInteractable(bool interactable)
    {
        foreach (var button in buttonList)
        {
            button.interactable = interactable;
        }
    }
}

