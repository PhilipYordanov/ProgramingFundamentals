using System;

class Thea_The_Photographer
{
    public static void Main()
    {
        int allTakenPictures = int.Parse(Console.ReadLine());
        int filterPictureTime = int.Parse(Console.ReadLine());
        double percentGoodPhotos = double.Parse(Console.ReadLine());
        int uploadTime = int.Parse(Console.ReadLine());

        double percentBadPhotos = percentGoodPhotos / 100.0;
        int GoodPictures = (int)Math.Ceiling(allTakenPictures * percentBadPhotos);
        long goodPictureUpload = GoodPictures * (long)uploadTime;
        long allPictureFilter = allTakenPictures * (long)filterPictureTime;
        long TotalTimeToComplete = goodPictureUpload + allPictureFilter;

        TimeSpan result = TimeSpan.FromSeconds(TotalTimeToComplete);
        string fromTimeString = result.ToString(@"d\:hh\:mm\:ss");
        Console.WriteLine(fromTimeString);
    }
}

