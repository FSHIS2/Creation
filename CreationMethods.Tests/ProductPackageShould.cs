namespace CreationMethods.Tests {
    public class ProductPackageShould
    {
        [Fact]
        public void CreateAProductPackageWithOnlyInternet()
        {
            var productPackage = ProductPackage.CreateProductPackage("100MB");

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVoip());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndVoip()
        {
            var productPackage = ProductPackage.CreateProductPackage("100MB", 91233788);

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVoip());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndTv()
        {
            var internetLabel = "100MB";
            var tvChannels = new[] {"LaLiga", "Estrenos"};
            var productPackage = ProductPackage.CreateProductPackage(internetLabel, tvChannels);

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVoip());
            Assert.True(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetVoipAndTv()
        {
            var productPackage = ProductPackage.CreateProductPackage("100MB", 91233788, new[] {"LaLiga", "Estrenos"});

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVoip());
            Assert.True(productPackage.HasTv());
        }

    }
}