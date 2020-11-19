using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assignment1.Controllers
{
    public class BookController : Controller
    {
        static readonly HttpClient client = new HttpClient();
        static string books = "";
        
        static JsonElement booksArray;
        static async Task getBooks()
        {
            try
            {
                string responseBody = await client.GetStringAsync("https://www.googleapis.com/books/v1/volumes?q=harry+potter");

                booksArray = JsonSerializer.Deserialize<JsonElement>(responseBody);
                
                books = responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        [Authorize]
        public async Task<ActionResult> Index()
        {  
            await getBooks();
            ViewBag.books = books;
            return View();
        }
        [Authorize]
        public IActionResult bookInfo(int id)
        {
            var book = booksArray.GetProperty("items")[id].GetProperty("volumeInfo");
            int key;
         
            Console.WriteLine(book);
            Console.WriteLine(book.GetProperty("title"));
            

            // Grabs property of key "type" whose value is equal to ISBN_10
            if (book.GetProperty("industryIdentifiers")[0].GetProperty("type").ValueEquals("ISBN_10")) {
                key = 0;
            } else {
                key = 1;
            }


            ViewBag.bookTitle = book.GetProperty("title");
            ViewBag.authors = book.GetProperty("authors");
            ViewBag.length = book.GetProperty("authors").GetArrayLength();
            ViewBag.publisher = book.GetProperty("publisher");
            ViewBag.publishDate = book.GetProperty("publishedDate");
            ViewBag.description = book.GetProperty("description");
            ViewBag.thumbnail = book.GetProperty("imageLinks").GetProperty("smallThumbnail");
            ViewBag.isbn = book.GetProperty("industryIdentifiers")[key].GetProperty("identifier");
            return View();
        }
    }

}