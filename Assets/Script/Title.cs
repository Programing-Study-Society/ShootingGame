using UnityEngine;
using UnityEngine.SceneManagement; // �V�[���Ǘ��̂��߂̖��O���

public class Title : MonoBehaviour
{
    // �^�C�g���V�[���ɖ߂郁�\�b�h
    public void ReturnToTitle()
    {
        SceneManager.LoadScene("StartScene"); // �^�C�g���V�[�������[�h
    }
}

