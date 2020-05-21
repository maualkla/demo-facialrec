using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace face_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Adminde!");
            // From your Face subscription in the Azure portal, get your subscription key and endpoint.
            // Set your environment variables using the names below. Close and reopen your project for changes to take effect.
            string SUBSCRIPTION_KEY = Environment.GetEnvironmentVariable("FACE_SUBSCRIPTION_KEY");
            string ENDPOINT = Environment.GetEnvironmentVariable("FACE_ENDPOINT");
        }
        /*
        *	AUTHENTICATE
        *	Uses subscription key and region to create a client.
        */
        public static IFaceClient Authenticate(string endpoint, string key)
        {
            return new FaceClient(new ApiKeyServiceClientCredentials(key)) { Endpoint = endpoint };
        }
    }
}
