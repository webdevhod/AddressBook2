using AddressBook2.Services.Interfaces;

namespace AddressBook2.Services
{
    public class BasicImageService : IImageService
    {
        public async Task<byte[]> convertIFormFileToByteArray(IFormFile file)
        {
            using MemoryStream memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            return memoryStream.ToArray();
        }

        public string getImageAsString(byte[] fileData, string extension)
        {
            return $"data:{extension};base64;{Convert.ToBase64String(fileData)}";
        }
    }
}
