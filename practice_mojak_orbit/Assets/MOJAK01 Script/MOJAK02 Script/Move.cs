using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    #region ����

    // �״� �Ҹ�
    public AudioSource deadVoice;
    public AudioSource Jump;
    public AudioSource Music1BGM;
    public AudioSource Music2BGM;

    // ���Ҹ�
    public AudioSource ChumBeong;

    public int x = 0;

    public int carril;
    public int lateral;
    int positionX = -3;
    public Vector3 posPlayer;
    public float velocidad;
    public Map mundo;
    public Transform grafico;
    public LayerMask capaObstaculos;
    public LayerMask capaAqua;
    public float distanciaVista = 1;
    public bool vivo = true;
    public float speed;
    public Animator animations;
    public AnimationCurve curve;
    public Attack attack;
    // ���� ���� �ǳ�
    public GameObject gameoverPanel;
    public GameObject ingamePanel;

    // ����
    public GameObject Police;

    bool bloqueo = false;
    #endregion
    private void Start()
    {
        InvokeRepeating("MirarAqua", 1, 0.5f);
    }

    
    void Update()
    {
        ActualizarPosition();

        if (Input.GetKeyDown(KeyCode.W))
        {
            Avanzar();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Retroceder();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Laterales(-1);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Laterales(1);
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(grafico.position + Vector3.up * 0.5f, grafico.position + Vector3.up * 0.5f + grafico.right * distanciaVista);
    }

    public void ActualizarPosition()
    {
        if (!vivo)
        {
            return;
        }
    }

    public IEnumerator CambiarPosition()
    {
        bloqueo = true;
        posPlayer = new Vector3(positionX, 1, lateral);
        Vector3 posActual = transform.position;

        for(int i = 1; i < 11; i++)
        {
            transform.position = Vector3.Lerp(posActual, posPlayer, i * 0.1f); //+ Vector3.up * curve.Evaluate(i * 0.1f);
            yield return new WaitForSeconds(1f / velocidad);
        }
        bloqueo = false;
    }

    #region ������ 1ĭ
    public void Avanzar()
    {
        if (!vivo || bloqueo)
        {
            return;
        }
        grafico.eulerAngles = Vector3.zero;
        if (MirarAdelante())
        {
            return;
        }

        positionX++;
        //animations.SetTrigger("run");
        if (positionX > carril)
        {
            carril = positionX;
            mundo.CrearPiso();
        }
        StartCoroutine(CambiarPosition());
        Jump.Play();
    }
    #endregion

    #region �ڷ� 1ĭ
    public void Retroceder()
    {
        if (!vivo || bloqueo)
        {
            return;
        }
        grafico.eulerAngles = new Vector3(0, 180, 0);
        if (MirarAdelante())
        {
            return;
        }
        if (positionX > carril - 3)
        {
            positionX--;
            //animations.SetTrigger("run");
        }
        StartCoroutine(CambiarPosition());
        Jump.Play();
    }
    #endregion

    #region ����/���������� 1ĭ
    public void Laterales(int count)
    {
        if (!vivo)
        {
            return;
        }
        grafico.eulerAngles = new Vector3(0, -90*count, 0);
        if (MirarAdelante())
        {
            return;
        }
        lateral += count;
        //animations.SetTrigger("run");
        lateral = Mathf.Clamp(lateral, -10, 10);
        StartCoroutine(CambiarPosition());
        Jump.Play();
    }
    #endregion

    public bool MirarAdelante()
    {
        RaycastHit hit;
        Ray rayo = new Ray(grafico.position + Vector3.up * 0.5f, grafico.right);

        if (Physics.Raycast(rayo, out hit, distanciaVista, capaObstaculos))
        {
            return true;
        }
        return false;
    }

    #region ������
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("carro"))
        {
            animations.SetTrigger("car");
            vivo = false;
            Debug.Log("������");
            StartCoroutine(FreezeTime());

            if (x < 1)
            {
                deadVoice.Play();
                Music1BGM.Stop();
                Music2BGM.Stop();
                x = 1;
            }

        }
    }
    #endregion

    #region �ͻ�
    public void MirarAqua()
    {
        RaycastHit hit;
        Ray rayo = new Ray(transform.position + Vector3.up, Vector3.down);

        if (Physics.Raycast(rayo, out hit, 3, capaAqua))
        {
             if (hit.collider.CompareTag("Aqua"))
             {
                vivo = false;
                animations.SetTrigger("aqua");
                Debug.Log("�ͻ�");
                StartCoroutine(FreezeTime());

                if (x < 1)
                {
                    ChumBeong.Play();
                    // deadVoice.Play();
                    Music1BGM.Stop();
                    Music2BGM.Stop();
                    x = 1;
                } 
             }

        }
    }


    #endregion

    #region ���� ����
    IEnumerator FreezeTime()
    {
        // �浹 �� 1�ʸ� ��ٸ��ϴ�
        yield return new WaitForSeconds(1f);

        // ���ӿ��� �ǳ� ���̱�
        // gameoverPanel.SetActive(true);

        Debug.Log("���� ����");
        

        // ���ӿ��� �ǳ� ���̱�
        gameoverPanel.SetActive(true);
        ingamePanel.SetActive(false);

        // Time.timeScale = 0;
        // ���� Top 5 ������
        ScoreManager.abc = 1;

        // ���鱤��
        // AdmobAds.def = 1;

        // ���ӿ��� ������ ���ϴ�.
        // SceneManager.LoadScene("GameOverScene");

        Police.SetActive(false);
    }
}
#endregion