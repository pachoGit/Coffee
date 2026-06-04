namespace Api.Services.OverviewService
{
    public static class MeasurementUnitConverter
    {
        public const decimal QUINTAL_KG = 45.359237m;

        public static decimal ToKilograms(string code, string name)
        {
            var key = (code ?? string.Empty).Trim().ToUpperInvariant();
            var nameKey = (name ?? string.Empty).Trim().ToUpperInvariant();

            if (key == "KG" || nameKey.Contains("KILO")) return 1m;
            if (key == "QQ" || nameKey.Contains("QUINTAL")) return QUINTAL_KG;
            if (key == "AR" || nameKey.Contains("ARROBA")) return 12.5m;
            if (key == "LB" || nameKey.Contains("LIBRA") || nameKey.Contains("POUND")) return 0.45359237m;
            if (key == "GR" || nameKey.Contains("GRAMO")) return 0.001m;
            if (key == "T" || key == "TN" || nameKey.Contains("TONELADA")) return 1000m;
            if (key == "BULTO" || nameKey.Contains("BULTO") || nameKey.Contains("SACO"))
            {
                if (nameKey.Contains("CEREZA") || nameKey.Contains("UVA")) return 125m;
                if (nameKey.Contains("HUMEDO") || nameKey.Contains("HÚMEDO")) return 70m;
                return 60m;
            }
            return 1m;
        }
    }
}
