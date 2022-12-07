namespace CreationMethods {
    public class ProductPackage
    {
        private readonly string internetLabel;
        private readonly int? telephoneNumber;
        private readonly string[] tvChannels;

        public ProductPackage(string internetLabel, string[] tvChannels)
        {
            this.internetLabel = internetLabel;
            this.tvChannels = tvChannels;
        }

        public ProductPackage(string internetLabel, int telephoneNumber, string[] tvChannels)
        {
            this.internetLabel = internetLabel;
            this.telephoneNumber = telephoneNumber;
            this.tvChannels = tvChannels;
        }

        public bool HasInternet()
        {
            return internetLabel != null;
        }


        public bool HasVoip()
        {
            return telephoneNumber != null;
        }

        public bool HasTv()
        {
            return tvChannels != null;
        }

        public static ProductPackage CreateProductPackage(string internetLabel) {
            var productPackage = new ProductPackage(internetLabel, null);
            return productPackage;
        }

        public static ProductPackage CreateProductPackage(string internetLabel, int telephoneNumber) {
            var productPackage = new ProductPackage(internetLabel, telephoneNumber, null);
            return productPackage;
        }

        public ProductPackage CreateProductPackage(string internetLabel, string[] tvChannels) {
            var productPackage = new ProductPackage(internetLabel, tvChannels);
            return productPackage;
        }

        public static ProductPackage CreateProductPackage(string internetLabel, int telephoneNumber, string[] tvChannels) {
            var productPackage = new ProductPackage(internetLabel, telephoneNumber, tvChannels);
            return productPackage;
        }

    }
}