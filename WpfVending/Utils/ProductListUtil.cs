using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfVending.Models;

namespace WpfVending.Utils
{
    public static class ProductListUtil
    {
        public static List<Product> products = new List<Product>();

        public static void populateList()
        {
            products.Clear();

            products.Add(new Product(0, "Coke", "Coca Cola 330ml", 15, new List<string> { "Caramel" }, "https://www.checkers.co.za/medias/10640171EA-checkers515Wx515H?context=bWFzdGVyfGltYWdlc3wxMTg2NjR8aW1hZ2UvcG5nfGltYWdlcy9oZTcvaGMxLzk3NzQ5NjY4OTg3MTgucG5nfDg2ODM0MjFjMTk3ZTMwZGZlMDg4MDk2MGM1NjFkZDA4MDc3ZWZjM2QwMTVlZDMwMDdkMmQzODIwYjgzN2FjODI"));
            products.Add(new Product(1, "Sprite", "Sprite 330ml", 15, new List<string> { "Lemon" }, "https://www.checkers.co.za/medias/10640185EA-checkers515Wx515H?context=bWFzdGVyfGltYWdlc3wxMzg5NzZ8aW1hZ2UvcG5nfGltYWdlcy9oY2YvaDQxLzk3MjI3NDc3NDgzODIucG5nfDFlMTgyY2Q4Zjk5OWUyMzNiNGM2YTNlOWIwZWQ2ODU4ZTg1YjYyYjhhNjA2NGZhMmZiYTlmZWY0YmEzNzY2NTU"));
            products.Add(new Product(2, "Fanta", "Fanta 330ml", 15, new List<string> { "Citrus" }, "https://www.checkers.co.za/medias/10640177EA-checkers515Wx515H?context=bWFzdGVyfGltYWdlc3wxMDY1NjR8aW1hZ2UvcG5nfGltYWdlcy9oMGIvaGQyLzEwNDAzMjUyNDM3MDIyLnBuZ3xlZTc2ZjdkZTdmOWZiYzk3YWEyNzgwYTYyNDRlYmJhZTRjYTk1MjZiYzIzYmMwNjgwMjI0M2I5Mjg0ZDI0NTc3"));
            products.Add(new Product(3, "Kit-Kat", "Kit-Kat", 10, new List<string> { "Soya", "Milk" }, "https://www.checkers.co.za/medias/10614986EA-picker-checkers515Wx515H?context=bWFzdGVyfGltYWdlc3wxMTk5ODN8aW1hZ2UvcG5nfGltYWdlcy9oNTQvaDBmLzEwMTM5NTI4MTY3NDU0LnBuZ3w4NmJmNDY2Y2IzM2NjNTEwNGVmM2FjODc3ZTk3MDExY2JkNWFhNDA4MjhmOGVmY2I4MDYyMDFiMGZjYjkxZDMx"));
            products.Add(new Product(4, "Lunch Bar", "Lunch Bar", 15, new List<string> { "Nuts", "Soya", "Milk" }, "https://www.checkers.co.za/medias/10188828EA-checkers515Wx515H?context=bWFzdGVyfGltYWdlc3w5NzcyN3xpbWFnZS9wbmd8aW1hZ2VzL2gxYy9oNzQvOTk2MDAwNjU4MjMwMi5wbmd8NTRjYjNjNzMwZjlhM2I0ZDVlMmJhNWI1MDZlYWVkMTgzY2VlOWE5YWVmNzEyNzVkNTQzMmNmOWQ5M2EyOTc0Ng"));
            products.Add(new Product(5, "Lindt Red", "Small Lindt Bar", 20, new List<string> { "Milk" }, "https://www.checkers.co.za/medias/10473445EA-checkers515Wx515H?context=bWFzdGVyfGltYWdlc3w2MTQ2OXxpbWFnZS9wbmd8aW1hZ2VzL2g1OS9oYWUvMTAyMTE1MjU3NTQ5MTAucG5nfDJjYjdmNTc5Y2U4YzE3NTVhZmE1NWZlNzFiNDI2NzAxM2RiMDFhN2Y4ZmQwYmMwMGQwZmYzY2U2OWRjOGFjN2Y"));
            products.Add(new Product(6, "Smarties", "Smarties Box Small", 5, new List<string> { "Soya", "Milk" }, "https://www.checkers.co.za/medias/10460474EA-checkers515Wx515H?context=bWFzdGVyfGltYWdlc3wyMjU2NjZ8aW1hZ2UvcG5nfGltYWdlcy9oMzQvaDI0LzEwMDMzMzQ4MTE2NTEwLnBuZ3w3MjE4YzdiZTY4ZTE5ZDJlMjMwYjM5Yjg5ZjhjMTE5Y2Y3YzRjYTExYmUyNThmYzU3MTI5NmVlOGFiMGQwMjNm"));
            products.Add(new Product(7, "Jelly Tots", "Jelly Tots", 10, new List<string> {}, "https://www.checkers.co.za/medias/10130377EA-20190726-Media-checkers515Wx515H?context=bWFzdGVyfGltYWdlc3wyNDIwMjZ8aW1hZ2UvcG5nfGltYWdlcy9oM2YvaDJkLzg4NjA5NzQ0MTU5MDIucG5nfDQzOTU1YTE1MmUyMjUxOGI1YzA2NGMxZGIyYjE0YTc4NDIyOWE4MjE1MjgwMjYzMzgyNzk2ODMwOTlmYzM3MjM"));
            products.Add(new Product(8, "Peanuts and Raisins", "Peanuts and Raisins", 12, new List<string> { "Nuts" }, "https://www.checkers.co.za/medias/10240755EA-checkers515Wx515H?context=bWFzdGVyfGltYWdlc3wzMTkzNzF8aW1hZ2UvcG5nfGltYWdlcy9oMjEvaDZiLzk4MzU1MjY1MjA4NjIucG5nfGU5ZDJhYmI2MWI3YjIyNDlkYzQ2YWE1YmE0MzQ4YzFlNGJlZTkxMjEwYzJlZmFiMmRjNjZjZmQ2MWI5MmMxYjM"));
        }
    }
}
