using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{


    #region 선언
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
    // 게임 오버 판넬
    public GameObject gameoverPanel;

    bool bloqueo = false;
    #endregion
    private void Start()
    {
        InvokeRepeating("MirarAqua", 1, 0.5f);
    }

    #region 키보드 조작1 (구버전)
    //public void LeftClick()
    //{
    //    Laterales(1); // 왼쪽
    //}
    //public void RightClick()
    //{
    //    Laterales(-1); // 오른쪽
    //}
    //public void ForwardClick() // 앞키
    //{
    //    Avanzar();
    //}

    //public void BackClick()
    //{
    //    Retroceder(); // 뒤키
    //}
    #endregion

    #region 키보드 조작2
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
    #endregion

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

    #region 앞으로 1칸
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
    }
    #endregion

    #region 뒤로 1칸
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
    }
    #endregion

    #region 왼쪽/오른쪽으로 1칸
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

    #region 교통사고
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("carro"))
        {
            animations.SetTrigger("car");
            vivo = false;
            Debug.Log("교통사고");
            StartCoroutine(FreezeTime());
        }
    }
    #endregion

    #region 익사
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
                Debug.Log("익사");
                StartCoroutine(FreezeTime());
            }

        }
    }


    #endregion

    #region 게임 오버
    IEnumerator FreezeTime()
    {
        // 충돌 후 1초를 기다립니다
        yield return new WaitForSeconds(1f);

        // 게임오버 판넬 보이기
        // gameoverPanel.SetActive(true);

        Debug.Log("게임 오버 ");
        Debug.Log("게임 세상이 정지됩니다.");
        Time.timeScale = 0;

        // 게임오버 판넬 보이기
        gameoverPanel.SetActive(true);
        // 점수 Top 5 시작점
        ScoreManager.abc = 1;

        // 전면광고
        // AdmobAds.def = 1;

        // 게임오버 씬으로 갑니다.
        // SceneManager.LoadScene("GameOverScene");
    }
}
#endregion