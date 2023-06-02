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

// BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, containerName);
// await foreach (BlobItem blobItem in blobContainerClient.GetBlobsAsync())
// {
//     System.Console.WriteLine("The Blob Name is {0}", blobItem.Name);
//     System.Console.WriteLine("The Blob Size is {0}", blobItem.Properties.ContentLength);
// }

/*  Set Blob MetaData */

// await SetBlobMetaData();

// async Task SetBlobMetaData()
// {
//     BlobClient blobClient = new BlobClient(connectionString, containerName, blobName);
//     IDictionary<string, string> metaData = new Dictionary<string, string>();
//     metaData.Add("Department", "Logistics");
//     metaData.Add("Application", "AppA");

//     System.Console.WriteLine("Metadata added. ");
// }

/*  Get Blob MetaData */

await GetBlobMetadata();

async Task GetBlobMetadata()
{
    BlobClient blobClient = new BlobClient(connectionString, containerName, blobName);
    BlobProperties blobProperties = await blobClient.GetPropertiesAsync();

    foreach (var metaData in blobProperties.Metadata)
    {
        System.Console.WriteLine("The Key is {0} ", metaData.Key);
        System.Console.WriteLine("The Value is {0} ", metaData.Value);
    }
}