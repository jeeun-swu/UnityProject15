using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // �̱��� ����
    public static GameManager gm;
    // ���� ���� UI ������Ʈ ����
    public GameObject gameLabel;
    // ���� ���� UI �ؽ�Ʈ ������Ʈ ����
    Text gameText;


    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
    }
    // ���� ���� ���
    public enum GameState
    {
        Ready,
        Run,
        GameOver
    }
    // ������ ���� ���� ����
    public GameState gState;
    // PlayerMove Ŭ���� ����
    PlayerMove player;


    void Start()
    {
        gState = GameState.Ready;
        gameText = gameLabel.GetComponent<Text>();
        // ���� �ؽ�Ʈ�� ������ ��Ready...���� �Ѵ�.
        gameText.text = "Ready...";
        // ���� �ؽ�Ʈ�� ������ ��Ȳ������ �Ѵ�.
        gameText.color = new Color32(255, 185, 0, 255);
        // ���� �غ�-> ������ ���·� ��ȯ�ϱ�
        StartCoroutine(ReadyToStart());
        // �÷��̾� ������Ʈ�� ã�� �� �÷��̾��� PlayerMove ������Ʈ �޾ƿ���
        player = GameObject.Find("Player").GetComponent<PlayerMove>();
    }
    IEnumerator ReadyToStart()
    {
        // 2�ʰ� ����Ѵ�.
        yield return new WaitForSeconds(2f);
        // ���� �ؽ�Ʈ�� ������ ��Go!���� �Ѵ�.
        gameText.text = "Go!";
        // 0.5�ʰ� ����Ѵ�.
        yield return new WaitForSeconds(0.5f);
        // ���� �ؽ�Ʈ�� ��Ȱ��ȭ�Ѵ�.
        gameLabel.SetActive(false);
        // ���¸� �������ߡ� ���·� �����Ѵ�.
        gState = GameState.Run;
    }

    void Update()
    {
        // ���� ���°� ������ �ߡ� ������ ���� ������ �� �ְ� �Ѵ�.
        if (GameManager.gm.gState != GameManager.GameState.Run)
        {
            return;
        }
    }
}
