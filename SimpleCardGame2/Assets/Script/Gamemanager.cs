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
        card1_renderer = card1.GetComponent<SpriteRenderer>();
        card1_renderer.sprite = my_sprites[0];
        card_list.Add(card1_renderer.sprite.name);

        card2_renderer = card2.GetComponent<SpriteRenderer>();
        card2_renderer.sprite = my_sprites[1];
        card_list.Add(card2_renderer.sprite.name);

        card3_renderer = card3.GetComponent<SpriteRenderer>();
        card3_renderer.sprite = my_sprites[2];
        card_list.Add(card3_renderer.sprite.name);

        card4_renderer = card4.GetComponent<SpriteRenderer>();
        card4_renderer.sprite = my_sprites[3];
        card_list.Add(card4_renderer.sprite.name);

        card5_renderer = card5.GetComponent<SpriteRenderer>();
        card5_renderer.sprite = my_sprites[4];
        card_list.Add(card5_renderer.sprite.name);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
