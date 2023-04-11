using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lab4___Rest
{
    [ServiceContract]
    public interface IRestService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/books")]
        List<Book> getAllXml();

        [OperationContract]
        [WebGet(UriTemplate = "/books/{id}", ResponseFormat = WebMessageFormat.Xml)]
        Book getByIdXml(string Id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/book",
             Method = "POST",
             RequestFormat = WebMessageFormat.Xml)]
        string addXml(Book item);

        [OperationContract]
        [WebInvoke(UriTemplate = "/books/{id}", Method = "DELETE")]
        string deleteXml(string Id);



        [OperationContract]
        [WebGet(UriTemplate = "/json/books", ResponseFormat = WebMessageFormat.Json)]
        List<Book> getAllJson();

        [OperationContract]
        [WebGet(UriTemplate = "/json/books/{id}", ResponseFormat = WebMessageFormat.Json)]
        Book getByIdJson(string Id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/book",
             Method = "POST",
             RequestFormat = WebMessageFormat.Json)]
        string addJson(Book item);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/books/{id}", Method = "DELETE")]
        string deleteJson(string Id);
    }


    [DataContract]
    public class Book
    {
        [DataMember(Order = 0)]
        public int id_element { get; set; }
        [DataMember(Order = 1)]
        public string name { get; set; }
        [DataMember(Order = 2)]
        public string author { get; set; }
    }


}
