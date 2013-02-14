using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyProjects.Client.Test
{
    [TestClass]
    public class HttpNameValueCollectionTest
    {
        [TestMethod]
        public void EmptyCollection_ToEmptyString()
        {
            HttpNameValueCollection collection = new HttpNameValueCollection();
            string result = collection.ToString();

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void SingleValue_ToKeyEqValue()
        {
            HttpNameValueCollection collection = new HttpNameValueCollection();

            collection["a"] = "b";

            string result = collection.ToString();

            Assert.AreEqual("a=b", result);
        }

        [TestMethod]
        public void SingleValue_EncodesKey()
        {
            HttpNameValueCollection collection = new HttpNameValueCollection();

            collection[" "] = "b";

            string result = collection.ToString();

            Assert.AreEqual("%20=b", result);
        }

        [TestMethod]
        public void SingleValue_EncodesValue()
        {
            HttpNameValueCollection collection = new HttpNameValueCollection();

            collection["a"] = " ";

            string result = collection.ToString();

            Assert.AreEqual("a=%20", result);
        }

        [TestMethod]
        public void TwoValues_ToKeyEqValueAmpSeparated()
        {
            HttpNameValueCollection collection = new HttpNameValueCollection();

            collection["a"] = "b";
            collection["c"] = "d";

            string result = collection.ToString();

            Assert.AreEqual("a=b&c=d", result);
        }

        [TestMethod]
        public void ParseEmptyString()
        {
            HttpNameValueCollection collection = HttpNameValueCollection.Parse("");

            Assert.AreEqual(0, collection.Count);
        }

        [TestMethod]
        public void ParseAEqB_ToSingleValue()
        {
            HttpNameValueCollection collection = HttpNameValueCollection.Parse("a=b");

            Assert.AreEqual(1, collection.Count);
            Assert.AreEqual("b", collection["a"]);
        }

        [TestMethod]
        public void ParseTwoEq_ToTwoValues()
        {
            HttpNameValueCollection collection = HttpNameValueCollection.Parse("a=b&c=d");

            Assert.AreEqual(2, collection.Count);
            Assert.AreEqual("b", collection["a"]);
            Assert.AreEqual("d", collection["c"]);
        }

        [TestMethod]
        public void ParseEncodedString_DecodesKey()
        {
            HttpNameValueCollection collection = HttpNameValueCollection.Parse("%20=b");

            Assert.AreEqual(1, collection.Count);
            Assert.AreEqual("b", collection[" "]);
        }

        [TestMethod]
        public void ParseEncodedString_DecodesValue()
        {
            HttpNameValueCollection collection = HttpNameValueCollection.Parse("a=%20");

            Assert.AreEqual(1, collection.Count);
            Assert.AreEqual(" ", collection["a"]);
        }

        [TestMethod]
        public void ParseEncodedString_EncodesWithDataEncoding()
        {
            HttpNameValueCollection collection = new HttpNameValueCollection();

            collection["+"] = "+";

            string result = collection.ToString();

            Assert.AreEqual("%2B=%2B", result);
        }
    }
}
