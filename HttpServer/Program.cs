﻿using System;
using System.Net;
using HttpServer;

namespace SimpleWebServer
{

    class Program
    {
        static void Main(string[] args)
        {
            WebServer app = new WebServer(3001);

            app.get("/test/hello", (HttpListenerRequest request) =>
            {
                return "<XML><MESSAGE>It works!</MESSAGE></XML>";
            });

            app.post("/test/hello", (HttpListenerRequest request) =>
            {
                string param = request.QueryString["query"];
                return string.Format("<XML><MESSAGE>Your query is below.</MESSAGE><QUERY>{0}</QUERY></XML>", param);
            });
            
            app.Start();

            Console.WriteLine("A simple webserver. Press a key to quit.");
            Console.ReadKey();
            app.Stop();
        }

        //public static string SendResponse(HttpListenerRequest request)
        //{

        //    String param = request.QueryString["Username"]; 
        //    return string.Format("<HTML><BODY>My web page.<br>{0}</BODY></HTML>", DateTime.Now);
        //}

        //public static string SendResponse2(HttpListenerRequest request)
        //{

        //    String param = request.QueryString["Username"];
        //    return string.Format("<HTML><BODY>My web page.<br>{0}</BODY></HTML>", param);
        //}

        //public static string SendResponse3(HttpListenerRequest request)
        //{

        //    String param = request.QueryString["Username"];
        //    return string.Format("<HTML><BODY>My web page</BODY></HTML>", param);
        //}
    }
}

