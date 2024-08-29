using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardNumber : MonoBehaviour
{
    [SerializeField] private Button[] cardButtons; // ��ư �迭
    [SerializeField] private int[] CardNum1;
    [SerializeField] private int[] CardNum2;

    // Start is called before the first frame update
    void Start()
    {
        // �迭�� ���� Ȯ��
        if (CardNum1.Length != CardNum2.Length || cardButtons.Length != CardNum1.Length)
        {
            Debug.LogError("CardNum1, CardNum2, and cardButtons arrays must all be the same length.");
            return;
        }

        // ��ư�� ������ �ε��� ���� ����
        bool[] buttonsToDelete = new bool[cardButtons.Length];

        for (int i = 0; i < CardNum1.Length; i++)
        {
            for (int j = 0; j < CardNum2.Length; j++)
            {
                if (CardNum1[i] == CardNum2[j])
                {
                    // �ε��� i�� j�� ��ġ�ϸ� �ش� ��ư���� ���� ������� ǥ��
                    buttonsToDelete[i] = true;
                    buttonsToDelete[j] = true;
                    break; // ��ġ�ϴ� ���� ã�����Ƿ� ���� ���� ����
                }
            }
        }

        // ���� ǥ�õ� ��ư ����
        for (int i = 0; i < buttonsToDelete.Length; i++)
        {
            if (buttonsToDelete[i])
            {
                Destroy(cardButtons[i].gameObject); // ��ư ������Ʈ ����
            }
        }
    }
}