
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        public float money = 9999999;
        public float price_inprovement_quanity_tree = 10;
        public float price_inprovement_speed_tree = 10;
        public float quantity_tree = 0;
        public float amount_of_mined_tree = 1;
        public float required_time_tree = 10f;

        public float price_inprovement_quanity_board = 20;
        public float price_inprovement_speed_board = 20;
        public float quantity_board = 100;
        public float amount_of_mined_board = 1;
        public float amount_of_consumed_board = 6;
        public float required_time_board = 40f;
        public bool start_board = false;

        public float price_inprovement_quanity_furniture = 50;
        public float price_inprovement_speed_furniture = 50;
        public float quantity_furniture = 0;
        public float amount_of_mined_furniture = 1;
        public float amount_of_consumed_furniture = 10;
        public float required_time_furniture = 60f;
        public bool start_furniture = false;
        
        public SavesYG()
        {
            
        
        }
       
    }
}
