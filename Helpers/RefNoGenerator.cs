namespace lablink.app.Helpers
{
    public static class RefNoGenerator
    {
        public static string ResultRefNoGen()
        {
            string dateNow = DateTime.UtcNow.ToString("yyyyMMdd");
            string uniqueString = Guid.NewGuid().ToString("N").ToUpper();
            string secureCluster = uniqueString.Substring(0, 8);

            return $"LAB-{dateNow}-{secureCluster}";
        }
    }
}
