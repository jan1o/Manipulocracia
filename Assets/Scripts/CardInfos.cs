using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfos : MonoBehaviour
{
    public string nome;
    public int favoraveis;
    public int desfavoraveis;
    public int popularidade;
    public int hate;
    public int dinheiro;

    public Sprite imagem;

    public List<int> getAtributes()
    {
        List<int> atributes = new List<int>();
        atributes.Add(favoraveis); atributes.Add(desfavoraveis); atributes.Add(popularidade); atributes.Add(hate); atributes.Add(dinheiro);
        return atributes;
    }
}
