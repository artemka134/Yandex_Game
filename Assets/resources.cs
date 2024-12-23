using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class resources : MonoBehaviour
{
    public TextMeshProUGUI money_text;
    public Animator anim_money;
    public TextMeshProUGUI anim_money_text;
    
    // создание объектов класса resources
    public static resources_class tree = new resources_class(0.5f, false, 5, true, "<sprite=0>");
    public Image indicator_tree_img;
    public TextMeshProUGUI text_quanity_tree;
    public TextMeshProUGUI amount_of_mined_tree_text;
    public TextMeshProUGUI required_time_tree_text;
    public TextMeshProUGUI info_inprovoment_speed_text_tree;
    public TextMeshProUGUI info_inprovoment_quanity_text_tree;
    public TextMeshProUGUI text_sale_tree;
    public Animator anim_tree;
    public InputField enter_qualityl_tree;
    public GameObject Improvet_quantity_button_tree; public GameObject Improvet_speed_button_tree;


    public static resources_class board = new resources_class(30, true, 4, false, "<sprite=1>", "<sprite=0>", 40);
    public Image indicator_board_img;
    public TextMeshProUGUI text_quanity_board;
    public TextMeshProUGUI amount_of_mined_board_text;
    public TextMeshProUGUI consumed_text_board;
    public TextMeshProUGUI required_time_board_text;
    public TextMeshProUGUI info_inprovoment_speed_text_board;
    public TextMeshProUGUI info_inprovoment_quanity_text_board;
    public TextMeshProUGUI text_sale_board;
    public Animator anim_board;
    public InputField enter_qualityl_board;
    public GameObject Improvet_quantity_button_board; public GameObject Improvet_speed_button_board; public GameObject button_start_board;
    public GameObject panel_board;
    public GameObject text_board_obj;
    public GameObject sale_panel_board;
    public GameObject button_sale_board;


    public static resources_class furniture = new resources_class(5000, true, 2, false, "<sprite=2>", "<sprite=1>", 80000);
    public Image indicator_furniture_img;
    public TextMeshProUGUI text_quanity_furniture;
    public TextMeshProUGUI amount_of_mined_furniture_text;
    public TextMeshProUGUI consumed_text_furniture;
    public TextMeshProUGUI required_time_furniture_text;
    public TextMeshProUGUI info_inprovoment_speed_text_furniture;
    public TextMeshProUGUI info_inprovoment_quanity_text_furniture;
    public TextMeshProUGUI text_sale_furniture;
    public Animator anim_furniture;
    public InputField enter_qualityl_furniture;
    public GameObject Improvet_quantity_button_furniture; public GameObject Improvet_speed_button_furniture; public GameObject button_start_furniture;
    public GameObject panel_furniture;
    public GameObject text_furniture_obj;
    public GameObject sale_panel_furniture;
    public GameObject buttton_sale_furniture;


    public static resources_class[] obj = new resources_class[] {tree, board, furniture}; 
    void Start()
    {
        //YandexGame.ResetSaveProgress();

        tree.price_inprovement_quanity = YandexGame.savesData.price_inprovement_quanity_tree;
        tree.price_inprovement_speed = YandexGame.savesData.price_inprovement_speed_tree;
        tree.quantity_resources = YandexGame.savesData.quantity_tree;
        tree.amount_of_mined_resources = YandexGame.savesData.amount_of_mined_tree;
        tree.required_time = YandexGame.savesData.required_time_tree;


        board.price_inprovement_quanity = YandexGame.savesData.price_inprovement_quanity_board;
        board.price_inprovement_speed = YandexGame.savesData.price_inprovement_speed_board;
        board.quantity_resources = YandexGame.savesData.quantity_board;
        board.amount_of_mined_resources = YandexGame.savesData.amount_of_mined_board;
        board.consumed = YandexGame.savesData.amount_of_consumed_board;
        board.required_time = YandexGame.savesData.required_time_board;
        board.start_resources = YandexGame.savesData.start_board;


        furniture.price_inprovement_quanity = YandexGame.savesData.price_inprovement_quanity_furniture;
        furniture.price_inprovement_speed = YandexGame.savesData.price_inprovement_speed_furniture;
        furniture.quantity_resources = YandexGame.savesData.quantity_furniture;
        furniture.amount_of_mined_resources = YandexGame.savesData.amount_of_mined_furniture;
        furniture.consumed = YandexGame.savesData.amount_of_consumed_furniture;
        furniture.required_time = YandexGame.savesData.required_time_furniture;
        furniture.start_resources = YandexGame.savesData.start_furniture;



        tree.indicator = indicator_tree_img;
        tree.text_quanity = text_quanity_tree;
        tree.anin = anim_tree;
        tree.amount_of_mined_resources_text = amount_of_mined_tree_text;
        tree.required_time_text = required_time_tree_text;
        tree.info_inprovoment_quanity_text = info_inprovoment_quanity_text_tree;
        tree.info_inprovoment_speed_text = info_inprovoment_speed_text_tree;
        tree.enter_qualityl = enter_qualityl_tree;
        tree.text_sale = text_sale_tree;
        tree.Improvet_quantity_button = Improvet_quantity_button_tree;
        tree.Improvet_speed_button = Improvet_speed_button_tree;
        


        board.indicator = indicator_board_img;
        board.text_quanity = text_quanity_board;
        board.anin = anim_board;
        board.amount_of_mined_resources_text = amount_of_mined_board_text;
        board.consumed_text = consumed_text_board;
        board.required_time_text = required_time_board_text;
        board.info_inprovoment_quanity_text = info_inprovoment_quanity_text_board;
        board.info_inprovoment_speed_text = info_inprovoment_speed_text_board;
        board.enter_qualityl = enter_qualityl_board;
        board.text_sale = text_sale_board;
        board.Improvet_quantity_button = Improvet_quantity_button_board;
        board.Improvet_speed_button = Improvet_speed_button_board;
        board.button_start_resoursec = button_start_board;
        board.panel_resources = panel_board;
        board.text_resources_obj = text_board_obj;
        board.panel_sale = sale_panel_board;
        if (YandexGame.savesData.start_board == true)
		{
            panel_board.SetActive(true);
            sale_panel_board.SetActive(true);
            button_sale_board.SetActive(false);
            text_board_obj.SetActive(true);
		}


        furniture.indicator = indicator_furniture_img;
        furniture.text_quanity = text_quanity_furniture;
        furniture.anin = anim_furniture;
        furniture.amount_of_mined_resources_text = amount_of_mined_furniture_text;
        furniture.consumed_text = consumed_text_furniture;
        furniture.required_time_text = required_time_furniture_text;
        furniture.info_inprovoment_quanity_text = info_inprovoment_quanity_text_furniture;
        furniture.info_inprovoment_speed_text = info_inprovoment_speed_text_furniture;
        furniture.enter_qualityl = enter_qualityl_furniture;
        furniture.text_sale = text_sale_furniture;
        furniture.Improvet_quantity_button = Improvet_quantity_button_furniture;
        furniture.Improvet_speed_button = Improvet_speed_button_furniture;
        furniture.button_start_resoursec = button_start_furniture;
        furniture.panel_resources = panel_furniture;
        furniture.text_resources_obj = text_furniture_obj;
        furniture.panel_sale = sale_panel_furniture;
        if (YandexGame.savesData.start_furniture == true)
        {
            panel_furniture.SetActive(true);
            sale_panel_furniture.SetActive(true);
            buttton_sale_furniture.SetActive(false);
            text_furniture_obj.SetActive(true);
        }

        tree.anim_money = anim_money;
        tree.anim_money_text = anim_money_text;
        board.anim_money = anim_money;
        board.anim_money_text = anim_money_text;
        furniture.anim_money_text = anim_money_text;
        furniture.anim_money = anim_money;
        tree.check_text();
        tree.check_textur_button();
    }
    void Update()
    {
        tree.calculation_time(ref tree.quantity_resources);
        board.calculation_time(ref tree.quantity_resources);
        furniture.calculation_time(ref board.quantity_resources);
        money_text.text = YandexGame.savesData.money.ToString("0.0") + " " + "<sprite=3>";


        if (YandexGame.savesData.money >= board.price_start_resources)
        {
            button_start_board.GetComponent<UnityEngine.UI.Image>().color = Color.green;
        }
        if (YandexGame.savesData.money < board.price_start_resources)
        {
            button_start_board.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
        if (YandexGame.savesData.money >= furniture.price_start_resources)
        {
            button_start_furniture.GetComponent<UnityEngine.UI.Image>().color = Color.green;
        }
        if (YandexGame.savesData.money < furniture.price_start_resources)
        {
            button_start_furniture.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
    }
    public void boost_tree(){tree.boost();}
    public void boost_board(){board.boost();}
    public void boost_furniture(){furniture.boost();}

    public void inprover_quanity_tree(){tree.Improvet_quantity();}
    public void inprover_quanity_board(){board.Improvet_quantity();}
    public void inprover_quanity_furniture(){furniture.Improvet_quantity();}

    public void inprover_speed_tree(){tree.inprover_speed();}
    public void inprover_speed_board(){board.inprover_speed();}
    public void inprover_speed_furniture(){furniture.inprover_speed();}

    public void quantity_sold_resources_check_tree(){tree.quantity_sold_resources_check();}
    public void quantity_sold_resources_check_board(){board.quantity_sold_resources_check();}
    public void quantity_sold_resources_check_furniture(){furniture.quantity_sold_resources_check();}
    
    public void quantity_sold_resources_maximum(){tree.quantity_sold_resources_maximum();}
    public void quantity_sold_resources_maximum_board(){board.quantity_sold_resources_maximum();}
    public void quantity_sold_resources_maximum_furniture(){furniture.quantity_sold_resources_maximum();}

    public void sales_resources_tree(){tree.sales_resources();}
    public void sales_resources_board(){board.sales_resources();}
    public void sales_resources_furniture(){furniture.sales_resources();}

    public void buy_start_board(){board.buy_start_resoursec();}
    public void buy_start_furniture(){furniture.buy_start_resoursec();}


    public static void Save()
    {
        YandexGame.savesData.price_inprovement_quanity_tree = tree.price_inprovement_quanity;
        YandexGame.savesData.price_inprovement_speed_tree = tree.price_inprovement_speed;
        YandexGame.savesData.quantity_tree = tree.quantity_resources;
        YandexGame.savesData.amount_of_mined_tree = tree.amount_of_mined_resources;
        YandexGame.savesData.required_time_tree = tree.required_time;

        YandexGame.savesData.price_inprovement_quanity_board = board.price_inprovement_quanity;
        YandexGame.savesData.price_inprovement_speed_board = board.price_inprovement_speed;
        YandexGame.savesData.quantity_board = board.quantity_resources;
        YandexGame.savesData.amount_of_mined_board = board.amount_of_mined_resources;
        YandexGame.savesData.amount_of_consumed_board = board.consumed;
        YandexGame.savesData.required_time_board = board.required_time;
        YandexGame.savesData.start_board = board.start_resources;

        YandexGame.savesData.price_inprovement_quanity_furniture = furniture.price_inprovement_quanity;
        YandexGame.savesData.price_inprovement_speed_furniture = furniture.price_inprovement_speed;
        YandexGame.savesData.quantity_furniture = furniture.quantity_resources;
        YandexGame.savesData.amount_of_mined_furniture = furniture.amount_of_mined_resources;
        YandexGame.savesData.amount_of_consumed_furniture = furniture.consumed;
        YandexGame.savesData.required_time_furniture = furniture.required_time;
        YandexGame.savesData.start_furniture = furniture.start_resources;

        YandexGame.savesData.start_board = board.start_resources;
        YandexGame.savesData.start_furniture = furniture.start_resources;
        YandexGame.SaveProgress();
    }




    public class resources_class
    {
        public bool start_resources;
        public resources_class(float price_resources_in, bool other_resources_in, float acceler_rate, bool start_res, string e, string e1 = "", float price_start = 0)
        {
            price_resources = price_resources_in;
            other_resources = other_resources_in;
            acceleration_rate = acceler_rate;
            start_resources = start_res;
            price_start_resources = price_start;
            emj = e;
            emj1 = e1;
        }
        public bool other_resources;
        public bool getting_resource = true;
        public Image indicator;
        public TextMeshProUGUI text_quanity;
        public TextMeshProUGUI required_time_text;
        public TextMeshProUGUI amount_of_mined_resources_text;
        public TextMeshProUGUI consumed_text;
        public TextMeshProUGUI info_inprovoment_speed_text;
        public TextMeshProUGUI info_inprovoment_quanity_text;
        public TextMeshProUGUI text_sale;
        public TextMeshProUGUI anim_money_text;
        public Animator anin;
        public Animator anim_money;
        public InputField enter_qualityl;
        public GameObject Improvet_quantity_button; public GameObject Improvet_speed_button; public GameObject button_start_resoursec;
        public GameObject panel_resources;
        public GameObject text_resources_obj;
        public GameObject panel_sale;
        public float price_resources;
        public float end_time = 0;
        public float required_time;
        public float quantity_resources = 0;
        public float amount_of_mined_resources;
        public float price_inprovement_quanity;
        public float price_inprovement_speed;
        public float quantity_sold_resources;
        public float consumed;
        public float acceleration_rate;
        public float price_start_resources;
        public string emj;
        public string emj1;

        public void calculation_time(ref float used_resources)
        {
            // расчёт времени до окончания производства
            if (start_resources == true)
            {
                indicator.fillAmount = end_time / 100;
                if (getting_resource == true || other_resources == false)
                {
                    end_time += 100 / required_time * Time.deltaTime;
                }
                if (end_time >= 100)
                {
                    end_time = 0;
                    getting_resource = false;
                    quantity_resources += amount_of_mined_resources;
                    quantity_resources = Convert.ToSingle(Math.Round(quantity_resources, 0));
                    anin.SetBool("a", true);
                    anin.Play("New Animation", 0, 0.0f);
                    Save();
                    check_text();
                }
                if (getting_resource == false && used_resources >= consumed)
                {
                    used_resources -= consumed;
                    getting_resource = true;

                    check_text();
                    Save();
                }
            }
        }
        public void check_text()
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] != null)
                {
                    obj[i].check_text_void();
                }
            }
        }
        public void check_text_void()
        {
            text_quanity.text = quantity_resources.ToString("0") + " " + emj; 
            required_time_text.text = required_time.ToString("0.0") + "сек";
            amount_of_mined_resources_text.text = "+" + amount_of_mined_resources.ToString("0") + " " + emj;
            if (other_resources == true)
            {
                consumed_text.text = "-" + consumed.ToString("0") + " " + emj1;
            }
            info_inprovoment_quanity_text.text = "Улучшить производство за " + price_inprovement_quanity.ToString("0.0") + " " + "<sprite=3>";
            if (required_time > 1)
            {
                info_inprovoment_speed_text.text = "Улучшить скорость за " + price_inprovement_speed.ToString("0.0") + " " + "<sprite=3>";
            }
            else
            {
                info_inprovoment_speed_text.text = "Максимум";
            }
        }
        public void check_textur_button()
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] != null)
                {
                    obj[i].check_textur_button_void();
                }
            }
        }
        public void check_textur_button_void()
        {
            // проверка текстуры кнопок покупки
            if (YandexGame.savesData.money >= price_inprovement_quanity)
            {
                Improvet_quantity_button.GetComponent<UnityEngine.UI.Image>().color = Color.green;
            }
            else
            {
                Improvet_quantity_button.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
            }
            if (YandexGame.savesData.money >= price_inprovement_speed && required_time > 1)
            {
                Improvet_speed_button.GetComponent<UnityEngine.UI.Image>().color = Color.green;
            }
            else
            {
                Improvet_speed_button.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
            }
			
		}
        // улучшение колличества производства
        public void Improvet_quantity()
        {
            if (YandexGame.savesData.money >= price_inprovement_quanity)
            {
                anim_money.SetBool("a", true);
                anim_money.Play("anim_money", 0, 0.0f);
                anim_money_text.text = "-" + price_inprovement_quanity.ToString("0") + " " + "<sprite=3>";
                YandexGame.savesData.money -= price_inprovement_quanity;
                price_inprovement_quanity += price_inprovement_quanity * 0.1f;
                if (amount_of_mined_resources < 10)
                {
                    amount_of_mined_resources++;
                }
                else if (amount_of_mined_resources >= 10)
                {
					amount_of_mined_resources += Convert.ToSingle(Math.Truncate(amount_of_mined_resources * 0.1f));
				}
                if (other_resources == true)
                {
                    consumed += consumed * 0.8f;
                }
                Save();
                check_text();
                check_textur_button();
            }
        }
        // улучшение скорости производства
        public void inprover_speed()
        {
            if (YandexGame.savesData.money >= price_inprovement_speed && required_time > 1)
            {
                anim_money.SetBool("a", true);
                anim_money.Play("anim_money", 0, 0.0f);
                anim_money_text.text = "-" + price_inprovement_speed.ToString("0") + " " + "<sprite=3>";
                YandexGame.savesData.money -= price_inprovement_speed;
                price_inprovement_speed += price_inprovement_speed * 4f;
                required_time -= Convert.ToSingle(Math.Ceiling(required_time * 0.1f));
                Save();
                check_text();
                check_textur_button();
            }
        }
        public void quantity_sold_resources_check()
        {
			amount_of_mined_resources = Convert.ToSingle(Math.Truncate(amount_of_mined_resources));
			if (enter_qualityl.text == "")
            {
                enter_qualityl.text = "0";
            }
            if (Convert.ToSingle(enter_qualityl.text) > quantity_resources)
            {
                quantity_sold_resources_maximum();
            }
            else
            {
                quantity_sold_resources = Convert.ToSingle(enter_qualityl.text);
                enter_qualityl.text = quantity_sold_resources.ToString();
                check_text_sales();
            }
        }
        public void quantity_sold_resources_maximum()
        {
            enter_qualityl.text = quantity_resources.ToString("0");
            check_text_sales();
        }
        // продажа ресурсов
        public void sales_resources()
        {
            if (quantity_sold_resources * price_resources > 0)
            {
                anim_money.SetBool("a", true);
                anim_money.Play("anim_money", 0, 0.0f);
                anim_money_text.text = "+" + (quantity_sold_resources * price_resources) + " " + "<sprite=3>";
                YandexGame.savesData.money += quantity_sold_resources * price_resources;
                quantity_resources -= quantity_sold_resources;
                quantity_sold_resources_check();
                check_text();
                check_textur_button();
                Save();
            }
        }
        public void check_text_sales()
        {
            text_sale.text = "Продать за " + (quantity_sold_resources * price_resources) + " " + "<sprite=3>";
        }
        // ускорение производства
        public void boost()
        {
            if (getting_resource == true)
            {
                end_time += acceleration_rate;
            }
        }
        public void buy_start_resoursec()
		{
            if (YandexGame.savesData.money > price_start_resources)
			{
                start_resources = true;
                YandexGame.savesData.money -= price_start_resources;
                button_start_resoursec.SetActive(false);
                panel_resources.SetActive(true);
                text_resources_obj.SetActive(true);
                panel_sale.SetActive(true);
                tree.check_textur_button();
			}
		}
    }
}
