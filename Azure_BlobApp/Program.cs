using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "";
string containerName = "";
string blobName = "";
string filePath = "";

/* Create Container */

//BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
//await blobServiceClient.CreateBlobContainerAsync(containerName);
//Console.WriteLine("Container Created... ");


/* Create Container and Managing the access */

//BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
//await blobServiceClient.CreateBlobContainerAsync(containerName, PublicAccessType.Blob);
//Console.WriteLine("Container Created and managing access ... ");


/* Uploading a Blob */

// BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, containerName);
// BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);
// await blobClient.UploadAsync(filePath);
// Console.WriteLine("Uploaded the Blob");

/*  List of Blobs */

BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, containerName);
await foreach (BlobItem blobItem in blobContainerClient.GetBlobsAsync())
{
    System.Console.WriteLine("The Blob Name is {0}", blobItem.Name);
    System.Console.WriteLine("The Blob Size is {0}", blobItem.Properties.ContentLength);
}