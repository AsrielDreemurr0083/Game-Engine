using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardNumber : MonoBehaviour
{
    [SerializeField] private Button[] cardButtons; // 버튼 배열
    [SerializeField] private int[] CardNum1;
    [SerializeField] private int[] CardNum2;

    // Start is called before the first frame update
    void Start()
    {
        // 배열의 길이 확인
        if (CardNum1.Length != CardNum2.Length || cardButtons.Length != CardNum1.Length)
        {
            Debug.LogError("CardNum1, CardNum2, and cardButtons arrays must all be the same length.");
            return;
        }

        // 버튼을 삭제할 인덱스 쌍을 추적
        bool[] buttonsToDelete = new bool[cardButtons.Length];

        for (int i = 0; i < CardNum1.Length; i++)
        {
            for (int j = 0; j < CardNum2.Length; j++)
            {
                if (CardNum1[i] == CardNum2[j])
                {
                    // 인덱스 i와 j가 일치하면 해당 버튼들을 삭제 대상으로 표시
                    buttonsToDelete[i] = true;
                    buttonsToDelete[j] = true;
                    break; // 일치하는 쌍을 찾았으므로 내부 루프 종료
                }
            }
        }

        // 삭제 표시된 버튼 삭제
        for (int i = 0; i < buttonsToDelete.Length; i++)
        {
            if (buttonsToDelete[i])
            {
                Destroy(cardButtons[i].gameObject); // 버튼 오브젝트 삭제
            }
        }
    }
}