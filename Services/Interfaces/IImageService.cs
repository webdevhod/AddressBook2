namespace AddressBook2.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> convertIFormFileToByteArray(IFormFile file);
        public String getImageAsString(byte[] fileData, String extension);
    }
}
