

class Prgram
{
    private static void Main(string[] args)
    {

        Prgram p = new Prgram();
        var fileList = p.GetFiles(@"d:\onedrive\pictures");

        foreach (var file in fileList)
        {
            Console.WriteLine(file);
           // File.Delete(file.FullName);
        }

        Console.WriteLine("Press aby key to continue ...");
        Console.ReadKey();
    }

    

    private FileInfo[] GetFiles(string path)
    {
        var info = new DirectoryInfo(path);

        IEnumerable<FileInfo> fileList1 = info.GetFiles("*.xmp",
            SearchOption.AllDirectories);


        IEnumerable<FileInfo> _fileQuery1 =
            from file in fileList1
            where file.Length > 0
            orderby file.Name
            select file;

        FileInfo[] fileQuery1 = _fileQuery1.ToArray();

        return fileQuery1;

    }

}