using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "";
string containerName = "";

/* Create Container */
//BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
//await blobServiceClient.CreateBlobContainerAsync(containerName);
//Console.WriteLine("Container Created... ");

/* Create Container and Manageing the access */
//BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
//await blobServiceClient.CreateBlobContainerAsync(containerName, PublicAccessType.Blob);
//Console.WriteLine("Container Created and managing access ... ");