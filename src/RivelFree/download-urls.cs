namespace RivelFree
{
    internal class download_urls
    {
        // easy update download links
        public static string update_url = "https://raw.githubusercontent.com/lemonekq/RivelFree/main/res/static.txt"; // get update info

        public static string cpu_pow = "https://raw.githubusercontent.com/lemonekq/RivelFree/main/reg/performance/cpu.pow"; // power plan
        public static string cpu_pow_filename = cpu_pow.Substring(cpu_pow.LastIndexOf('-') + 1);

    }
}
