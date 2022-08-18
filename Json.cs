using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using UnityEngine;
using UnityEngine.UI;

public class Json : MonoBehaviour
{

    public GameObject jogador;

    public void gravar()
    {

            Local positions = new Local();
            positions.posx = jogador.transform.position.x;
            positions.posy = jogador.transform.position.y;
            positions.posz = jogador.transform.position.z;
            positions.rotx = jogador.transform.localEulerAngles.x;
            positions.roty = jogador.transform.localEulerAngles.y;
            positions.rotz = jogador.transform.localEulerAngles.z;

            string json = "";
            string filePath = Path.Combine(Application.streamingAssetsPath, "save.json");

            if (!Directory.Exists(Application.streamingAssetsPath))
            {
                Directory.CreateDirectory(Application.streamingAssetsPath);
            }

            if (!File.Exists(filePath))
            {
                json = JsonUtility.ToJson(positions);
                StreamWriter file = new StreamWriter(filePath);
                file.WriteLine(json);
                file.Close();
            }
    }


    public void ler()
    {
            try
            {
                string json = File.ReadAllText(Application.streamingAssetsPath + "/save.json");
                Local positions = JsonUtility.FromJson<Local>(json);

                jogador.transform.position = new Vector3(positions.posx, positions.posy, positions.posz);
                jogador.transform.localEulerAngles = new Vector3(positions.rotx, positions.roty, positions.rotz);
            }
            catch
            {

            }
    }
}
