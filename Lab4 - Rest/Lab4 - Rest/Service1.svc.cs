using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Xml.Linq;

namespace Lab4___Rest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IRestService
    {
        static List<Book> books = new List<Book>()
        {
            new Book()
            {
                id_element = 1,
                name = "name 1",
                author = "author 1"
            },
            new Book()
            {
                id_element = 2,
                name = "name 2",
                author = "author 2"
            },
            new Book()
            {
                id_element =3,
                name = "name 3",
                author = "author 3"
            },
        };

        string IRestService.addJson(Book item)
        {
            if (item == null)
            {
                throw new WebFaultException<string>("400: BadRequest", HttpStatusCode.BadRequest);
            }

            int idx = books.FindIndex(b => b.id_element == item.id_element);
            if (idx == -1)
            {
                books.Add(item);
                return "Added item with ID=" + item.id_element;
            }
            else
            {

                throw new WebFaultException<string>("409: Conflict",
                HttpStatusCode.Conflict);
            }
        }

        string IRestService.addXml(Book item)
        {
            if (item == null)
            {
                throw new WebFaultException<string>("400: BadRequest", HttpStatusCode.BadRequest);
            }

            int idx = books.FindIndex(b => b.id_element == item.id_element);
            if (idx == -1)
            {
                books.Add(item);
                return "Added item with ID=" + item.id_element;
            }
            else
                {

                    throw new WebFaultException<string>("409: Conflict",
                    HttpStatusCode.Conflict);
                }
        }

        string IRestService.deleteJson(string Id)
        {
            int id = int.Parse(Id);

            Book bookToDelete = books.Find(b => b.id_element == id);

            if (bookToDelete != null)
            {
                books.Remove(bookToDelete);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
                throw new WebFaultException<string>("Not found", HttpStatusCode.NotFound);
            }

            return "Deleted item with ID=" + bookToDelete.id_element;
        }

        string IRestService.deleteXml(string Id)
        {
            int id = int.Parse(Id);

            Book bookToDelete = books.Find(b => b.id_element == id);

            if (bookToDelete != null)
            {
                books.Remove(bookToDelete);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
                throw new WebFaultException<string>("Not found", HttpStatusCode.NotFound);
            }

            return "Deleted item with ID=" + bookToDelete.id_element;
        }

        List<Book> IRestService.getAllJson()
        {
            return books;
        }

        List<Book> IRestService.getAllXml()
        {
            return books;
        }

        Book IRestService.getByIdJson(string Id)
        {
            int intId = int.Parse(Id);
            int idx = books.FindIndex(b => b.id_element == intId);
            if (idx == -1)
            {
                throw new WebFaultException<string>("Not found", HttpStatusCode.NotFound);
            }

            return books.ElementAt(idx);
        }

        Book IRestService.getByIdXml(string Id)
        {
            int intId = int.Parse(Id);
            int idx = books.FindIndex(b => b.id_element == intId);
            if(idx == -1)
            {
                throw new WebFaultException<string>("Not found", HttpStatusCode.NotFound);
            }

            return books.ElementAt(idx);
        }
    }
}
