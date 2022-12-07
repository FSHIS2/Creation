namespace CreationMethods.Tests {
    public class ProductPackageShould
    {
        [Fact]
        public void CreateAProductPackageWithOnlyInternet()
        {
            var internetLabel = "100MB";
            var productPackage = ProductPackage.CreateProductPackage(internetLabel);

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVoip());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndVoip()
        {
            var productPackage = new ProductPackage("100MB", 91233788);

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVoip());
            Assert.False(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetAndTv()
        {
            var productPackage = new ProductPackage("100MB", new[] {"LaLiga", "Estrenos"});

            Assert.True(productPackage.HasInternet());
            Assert.False(productPackage.HasVoip());
            Assert.True(productPackage.HasTv());
        }

        [Fact]
        public void CreateWithInternetVoipAndTv()
        {
            var productPackage = new ProductPackage("100MB", 91233788, new[] {"LaLiga", "Estrenos"});

            Assert.True(productPackage.HasInternet());
            Assert.True(productPackage.HasVoip());
            Assert.True(productPackage.HasTv());
        }
    }
}