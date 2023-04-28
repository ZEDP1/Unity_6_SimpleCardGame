using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    [SerializeField]
    public GameObject goal;
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;

    SpriteRenderer card1_renderer;
    SpriteRenderer card2_renderer;
    SpriteRenderer card3_renderer;
    SpriteRenderer card4_renderer;
    SpriteRenderer card5_renderer;

    public Sprite[] my_sprites;

    List<string> card_list = new List<string>();
    List<int> card_list_numonly = new List<int>();
    List<string> card_list_shapeonly = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < card_array.Length; i++)
        {
            sr_array[i] = card_array[i].GetComponent<SpriteRenderer>();
            sr_array[i] =
        }

        Debug.Log(card_list[0] + " " + card_list[1] + " " + card_list[2] + " "
                   + card_list[3] + " " + card_list[4]);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
