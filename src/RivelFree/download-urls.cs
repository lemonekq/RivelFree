namespace RivelFree
{
    internal class download_urls
    {
        // easy update download links
        public static string update_url = "https://raw.githubusercontent.com/lemonekq/RivelFree/main/res/static.txt"; // get update info

        // scripts and regs from github
        public static string cpu_pow = "https://raw.githubusercontent.com/lemonekq/RivelFree/main/reg/performance/cpu.pow"; // power plan
        public static string cpu_pow_filename = cpu_pow.Substring(cpu_pow.LastIndexOf('/') + 1);

        public static string cleaner_cache = "https://github.com/lemonekq/RivelFree/blob/main/reg/cleaner/cachecleaner.bat"; // cache cleaner
        public static string cleaner_cache_filename = cleaner_cache.Substring(cleaner_cache.LastIndexOf('/') + 1);

        public static string cleaner_log = "https://github.com/lemonekq/RivelFree/blob/main/reg/cleaner/logcleaner.bat"; // log cleaner
        public static string cleaner_log_filename = cleaner_log.Substring(cleaner_log.LastIndexOf('/') + 1);

        public static string cleaner_temp = "https://github.com/lemonekq/RivelFree/blob/main/reg/cleaner/tempcleaner.bat"; // temp cleaner
        public static string cleaner_temp_filename = cleaner_temp.Substring(cleaner_temp.LastIndexOf('/') + 1);
    }
}
