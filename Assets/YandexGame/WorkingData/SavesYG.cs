
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

        public float money = 1000;
        public float price_inprovement_quanity_tree = 10;
        public float price_inprovement_speed_tree = 10;
        public float quantity_tree = 0;
        public float amount_of_mined_tree = 1;
        public float required_time_tree = 10f;

        public float price_inprovement_quanity_board = 20;
        public float price_inprovement_speed_board = 20;
        public float quantity_board = 0;
        public float amount_of_mined_board = 1;
        public float amount_of_consumed_resources = 6;
        public float required_time_board = 20f;
        
        public SavesYG()
        {
            
        
        }
       
    }
}
