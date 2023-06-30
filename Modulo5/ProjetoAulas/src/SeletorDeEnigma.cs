using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeletorDeEnigma : MonoBehaviour
{
    [SerializeField] ListaDeEnigmas lista;
    [SerializeField] Text perguntaTexto;
    [SerializeField] Text botao1Texto;
    [SerializeField] Text botao2Texto;
    [SerializeField] Text botao3Texto;
    [SerializeField] Text botao4Texto;
    [SerializeField] Text scoreTexto;
    [SerializeField] Text recordTexto;
    int index;
    int score;
    int record;

    List<string> respostasPossiveis = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        scoreTexto.text = "Score " + score.ToString();
        record = PlayerPrefs.GetInt("record", 0);
        recordTexto.text = "Record " + record.ToString();
        index = Random.Range(0, lista.listaDeEnigmas.Count);

        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaCorreta);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada1);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada2);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada3);
        
        int indexRespostas = Random.Range(0, respostasPossiveis.Count);

        perguntaTexto.text = lista.listaDeEnigmas[index].pergunta;
        
        botao1Texto.text = respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, respostasPossiveis.Count);
        
        botao2Texto.text = respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, respostasPossiveis.Count);
        
        botao3Texto.text = respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, respostasPossiveis.Count);
        
        botao4Texto.text = respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
    }

    public void OnClick(Text TextoBotao)
    {
        if (TextoBotao.text == lista.listaDeEnigmas[index].respostaCorreta)
        {
            lista.listaDeEnigmas.Remove(lista.listaDeEnigmas[index]);
            score += 5;
            scoreTexto.text = "Score " + score.ToString();
            if (score > record)
            {
                record = score;
                recordTexto.text = "Record: " + record.ToString();
                PlayerPrefs.SetInt("record", record);
            }
            Start();
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
