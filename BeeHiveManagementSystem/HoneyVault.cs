namespace BeeHiveManagementSystem
{
    static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = .19f;
        public const float LOW_LEVEL_WARNING = 10f;


        private static float honey = 25f;
        private static float nectar = 100f;


        public static void CollectNectar(float amount)
        {
            if (amount > 0f) nectar += amount;
        }

        public static void ConvertNectarToHoney(float amount)
        {

            float nectarToConvert = amount;
            if (nectarToConvert > nectar) nectarToConvert = nectar;
            nectar -= nectarToConvert;
            honey += nectarToConvert * NECTAR_CONVERSION_RATIO;

        }



        static public bool ConsumeHoney(float amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            else return false;
        }

        public static string StatusReport
        {
            get
            {
                string status = $"{honey:0.0} units of honey\n" +
                                $"{nectar:0.0} units of nectar";
                string warning = "";
                if (honey < LOW_LEVEL_WARNING) warning += "\n LOW HONEY - " +
                        "                       ADD A HONEY MANUFACTURER";
                if (nectar < LOW_LEVEL_WARNING) warning += "\n LOW NECTAR - " +
                               "                       ADD A NECTAR COLLECTOR";
                return status + warning;

            }
        }


    }
}
