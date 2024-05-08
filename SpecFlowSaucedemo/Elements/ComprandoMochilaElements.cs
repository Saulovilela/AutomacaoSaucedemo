using OpenQA.Selenium.DevTools.V122.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Elements
{
    public class ComprandoMochilaElements
    {
        public const string ImageMochila = "//*[@id=\"item_4_img_link\"]/img";
        public const string ValidaImagemMochila = "//*[@id=\"inventory_item_container\"]/div/div/div[1]/img";
        public const string AddtoCart = "add-to-cart";
        public const string BtnCart = "//*[@id=\"shopping_cart_container\"]/a";
        public const string BtnCheckout = "checkout";

        public const string FirstName = "first-name";
        public const string LastName = "last-name";
        public const string ZipCode = "postal-code";
        public const string BtnContinue = "continue";

        public const string BtnFinish = "finish";

        public const string ValidateXpath = "//*[@id=\"checkout_complete_container\"]/h2";
        
    }
}
