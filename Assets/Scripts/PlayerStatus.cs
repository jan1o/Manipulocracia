using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    #region Singleton
    public static PlayerStatus instance;

    void Awake()
    {

        instance = this;
    }

    public void AnularInstance()
    {
        instance = null;
    }
    #endregion

    #region atributos correntes do jogador
    public int favoraveis;
    public int desfavoraveis;
    public int popularidade;
    public int hate;
    public int dinheiro;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        this.favoraveis = 5;
        this.desfavoraveis = 5;
        this.popularidade = 5;
        this.hate = 5;
        this.dinheiro = 5;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void AlterarAtributos(List<int> alteradores)
    {

    }

    public bool CalcularResultado()
    {
        //retorna true para vitoria e false para derrota
        return true;
    }


}
