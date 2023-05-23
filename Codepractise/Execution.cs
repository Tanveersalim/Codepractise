using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;


namespace Codepractise
{
    [TestClass]
    public class Execution

    {
        //Initialize TestContext
        public TestContext instance;

        //Create Getter and Setter Method TestContext
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }


        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"PostivetestLogin.csv", "PostivetestLogin#csv", DataAccessMethod.Sequential)]
        [TestCategory("Login")]
        [TestCategory("Positive")]

        //Create Method
        public void LoginPositiveTestCase()
        {
            //Create Object of Login Class
            Login login = new Login();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();

            //pass attribute in method
            login.Positivecase(url, email, pass, message, locator);



        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"NegativetestLogin.csv", "NegativetestLogin#csv", DataAccessMethod.Sequential)]
        [TestCategory("Login")]
        [TestCategory("Negative")]


        //Create Method
        public void LoginNegativeTestCase()
        {
            //Create Object of Login Class
            Login login = new Login();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();

            //pass attribute in method
            login.NegativeCase(url, email, pass, message, locator);



        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"PositivetestRegister.csv", "PositivetestRegister#csv", DataAccessMethod.Sequential)]
        [TestCategory("Register")]
        [TestCategory("Positive")]


        //Create Method
        public void RegisterPositiveTestCase()
        {
            //Create Object of Register Class
            Register register = new Register();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string name = TestContext.DataRow["name"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            string confirmpass = TestContext.DataRow["confirmpass"].ToString();

            //pass attribute in method
            register.Positivecase(url, name, email, phone, pass, confirmpass);



        }

        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"NegativetestRegister.csv", "NegativetestRegister#csv", DataAccessMethod.Sequential)]
        [TestCategory("Register")]
        [TestCategory("Negative")]


        //Create Method
        public void RegisterNegativeTestCase()
        {
            //Create Object of Register Class
            Register register = new Register();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string name = TestContext.DataRow["name"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            string confirmpass = TestContext.DataRow["confirmpass"].ToString();

            //pass attribute in method
            register.NegativeCase(url, name, email, phone, pass, confirmpass);

        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Search.csv", "Search#csv", DataAccessMethod.Sequential)]
        [TestCategory("Search")]

        //Create Method
        public void Searchproduct()
        {
            //Create Object of Search Class
            Search search = new Search();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string keywords = TestContext.DataRow["keywords"].ToString();

            //pass attribute in method
            search.Searchproduct(url, keywords);


        }

        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"orderplaceddetail.csv", "orderplaceddetail#csv", DataAccessMethod.Sequential)]
        [TestCategory("SingleProduct")]

        //Create Method
        public void SingleProductPurchase()
        {

            //Create Object of SingleProduct Class
            SingleOrderPlaced orderPlaced = new SingleOrderPlaced();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            string category = TestContext.DataRow["category"].ToString();
            string keywords = TestContext.DataRow["keywords"].ToString();
            string productselects = TestContext.DataRow["productselect"].ToString();
            string firstname = TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();
            string housenum = TestContext.DataRow["housenum"].ToString();
            string province = TestContext.DataRow["province"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string area = TestContext.DataRow["area"].ToString();
            string zipcode = TestContext.DataRow["zipcode"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();

            //pass attribute in method
            orderPlaced.SpecificProductpurchase(url, email, pass, category, keywords, productselects, firstname, lastname, housenum, province, city, area, zipcode, phone);

        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"orderplaceddetail2.csv", "orderplaceddetail2#csv", DataAccessMethod.Sequential)]
        [TestCategory("MultipleProduct")]

        //Create Method
        public void MultipleProductPurchase()
        {

            //Create Object of MultiProduct Class
            MultipleOrderPlaced orderPlaced = new MultipleOrderPlaced();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            string category = TestContext.DataRow["category"].ToString();
            string keywords = TestContext.DataRow["keywords"].ToString();
            string productselect1 = TestContext.DataRow["productselect1"].ToString();
            string productselect2 = TestContext.DataRow["productselect2"].ToString();
            string productselect3 = TestContext.DataRow["productselect3"].ToString();
            string firstname = TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();
            string housenum = TestContext.DataRow["housenum"].ToString();
            string province = TestContext.DataRow["province"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string area = TestContext.DataRow["area"].ToString();
            string zipcode = TestContext.DataRow["zipcode"].ToString();
            string phone = TestContext.DataRow["phone"].ToString();

            //pass attribute in method
            orderPlaced.MultiProductpurchase(url, email, pass, category, keywords, productselect1, productselect2, productselect3, firstname, lastname, housenum, province, city, area, zipcode, phone);

        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"TrackingOrder.csv", "TrackingOrder#csv", DataAccessMethod.Sequential)]
        [TestCategory("TrackOrder")]

        //Create Method
        public void TrackOrder()
        {
            //Create Object of TrackOrder Class
            TrackingOrder tracking = new TrackingOrder();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string orderid = TestContext.DataRow["orderid"].ToString();

            //pass attribute in method
            tracking.TrackOrder(url, orderid, email);


        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Contactus.csv", "Contactus#csv", DataAccessMethod.Sequential)]
        [TestCategory("Contact")]

        //Create Method
        public void Contactus()
        {
            //Create Object of Contactus Class
            Contactus contact = new Contactus();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string name = TestContext.DataRow["name"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string expectedmessage = TestContext.DataRow["expectedmessage"].ToString();

            //pass attribute in method
            contact.Contact(url, name, email, message, expectedmessage);


        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"Review.csv", "Review#csv", DataAccessMethod.Sequential)]
        [TestCategory("ProductRating")]

        //Create Method
        public void Reviews()
        {
            //Create Object of Product Review Class
            Productreview review = new Productreview();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            string keywords = TestContext.DataRow["keywords"].ToString();
            string productselects = TestContext.DataRow["productselect"].ToString();
            string rating = TestContext.DataRow["rating"].ToString();
            string reviewtitle = TestContext.DataRow["reviewtitle"].ToString();
            string comment = TestContext.DataRow["comment"].ToString();
            string editrating = TestContext.DataRow["editrating"].ToString();
            string editreviewtitle = TestContext.DataRow["editreviewtitle"].ToString();
            string editcomment = TestContext.DataRow["editcomment"].ToString();
            //string uploadimages = TestContext.DataRow["uploadimages"].ToString();

            //pass attribute in method
            review.Review(url, email, pass, keywords, productselects, rating, reviewtitle, comment, editrating, editreviewtitle, editcomment);

        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"wishlist.csv", "wishlist#csv", DataAccessMethod.Sequential)]
        [TestCategory("Wishlist")]

        //Create Method
        public void Wishlist()
        {
            //Create Object of Product Review Class
            Wishlist wishlist = new Wishlist();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            string category = TestContext.DataRow["category"].ToString();
            string keywords = TestContext.DataRow["keywords"].ToString();
            string productselect1 = TestContext.DataRow["productselect1"].ToString();
            string productselect2 = TestContext.DataRow["productselect2"].ToString();
            string productselect3 = TestContext.DataRow["productselect3"].ToString();
            string productselect4 = TestContext.DataRow["productselect4"].ToString();
            string productselect5 = TestContext.DataRow["productselect5"].ToString();

            //pass attribute in method
            wishlist.WishList(url, email, pass, category, keywords, productselect1, productselect2, productselect3, productselect4, productselect5);



        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"productsort.csv", "productsort#csv", DataAccessMethod.Sequential)]
        [TestCategory("ProductSort")]

        //Create Method
        public void Productsort()
        {
            //Create Object of Product Sort Class
            Productsort productsort = new Productsort();

            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string categoryselect = TestContext.DataRow["categoryselect"].ToString();
            string stockavailable = TestContext.DataRow["stock available"].ToString();
            string discountproduct = TestContext.DataRow["discount product"].ToString();
            string lowtohighprice = TestContext.DataRow["low to high price"].ToString();
            string hightolowprice = TestContext.DataRow["high to low price"].ToString();
            string lowestrank = TestContext.DataRow["lowest rank"].ToString();
            string highestrank = TestContext.DataRow["highest rank"].ToString();

            //pass attribute in method
            productsort.ProductSort(url, categoryselect, stockavailable, discountproduct, lowtohighprice, hightolowprice, lowestrank, highestrank);



        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"plentyproductsort.csv", "plentyproductsort#csv", DataAccessMethod.Sequential)]
        [TestCategory("PlentyProductSort")]

        //Create Method
        public void PlentyProductsort()
        {
            //Create Object of Plenty Product Sort Class
            PlentyProductsort plenty = new PlentyProductsort();


            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            string plentycategoryselect = TestContext.DataRow["plentymart categoryselect"].ToString();
            string stockavailable = TestContext.DataRow["stock available"].ToString();
            string discountproduct = TestContext.DataRow["discount product"].ToString();
            string lowtohighprice = TestContext.DataRow["low to high price"].ToString();
            string hightolowprice = TestContext.DataRow["high to low price"].ToString();
            string lowestrank = TestContext.DataRow["lowest rank"].ToString();
            string highestrank = TestContext.DataRow["highest rank"].ToString();

            //pass attribute in method
            plenty.PlentyProductSort(url, plentycategoryselect, stockavailable, discountproduct, lowtohighprice, hightolowprice, lowestrank, highestrank);
        }
        [TestMethod]

        //Apply Datasource.csv to grab the data
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"jmmy.csv", "jmmy#csv", DataAccessMethod.Sequential)]
        [TestCategory("JMMY")]

        //Create Method
        public void Jmmy()
        {
            //Create Object of Plenty Product Sort Class
            JMMYII JMMY = new JMMYII();


            //get the attribute in csv file
            string url = TestContext.DataRow["url"].ToString();
            /*string plentycategoryselect = TestContext.DataRow["plentymart categoryselect"].ToString();
            string stockavailable = TestContext.DataRow["stock available"].ToString();
            string discountproduct = TestContext.DataRow["discount product"].ToString();
            string lowtohighprice = TestContext.DataRow["low to high price"].ToString();
            string hightolowprice = TestContext.DataRow["high to low price"].ToString();
            string lowestrank = TestContext.DataRow["lowest rank"].ToString();
            string highestrank = TestContext.DataRow["highest rank"].ToString();*/

            //pass attribute in method
            JMMY.Jmmy(url);
        }
    }
}