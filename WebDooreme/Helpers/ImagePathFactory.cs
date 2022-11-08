namespace WebDooreme.Helpers
{
    public static class ImagePathFactory
    {
        public static string GetImagePathName(ImagePaths imagePaths)
        {
            switch (imagePaths)
            {
                case ImagePaths.Upload:
                    return "upload";
                case ImagePaths.ProductL:
                    return "ProductImages/ProductL";
                case ImagePaths.ProductS:
                    return "ProductImages/ProductS";
            }
            return null;
        }
    }
}