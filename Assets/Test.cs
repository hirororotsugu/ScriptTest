using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    public int mp = 53; // mp
    public void Magic()
    {
        // ���@�p�̊֐�
        if(this.mp >= 5 )
        {
            // mp��5�ȏ�̏ꍇ
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else
        {
            // mp��5�����̏ꍇ
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}

public class Test : MonoBehaviour
{
    // Use this for initialization
    // Start is called before the first frame update
    void Start()
    {
        // �v�f�̌�5�̔z��array��錾���l��������
        int[] array = { 100, 200, 300, 400, 500};

        // for�����g���A�z��̗v�f(5��)�Ԃ񂾂���������
        for (int i =0; i < array.Length; i++)
        {
            // �z��̗v�f�����Ԃɕ\������
            Debug.Log(array[i]);
        }

        // for�����g���A�z��̏������t���ŏ���
        for (int i = array.Length -1; i >= 0; i--)
        {
            // �z��̗v�f��(�t)���ɕ\������
            Debug.Log(array[i]);
        }

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss boss = new Boss();
        // ���@�p�̊֐���11��Ăяo��
        for (int i = 1; i <= 11; i++)
        {
            boss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
