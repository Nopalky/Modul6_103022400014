using System.Diagnostics;

class SayaMusicTrack {
    private int id;
    public string title;
    private int playcount;

    public SayaMusicTrack(string title) { 
        this.title = title;

        Debug.Assert(title != null);
        Debug.Assert(title.Length <= 200);

        Random idPlay = new Random();
        this.id = idPlay.Next(10000, 100000);
        this.playcount = 0;
    }
    public void IncreasePlayCount(int count)
    {
        if (count > 25000000) {
           Console.WriteLine("Tidak boleh lebih dari 25000000 pemutaran!");
           Debug.Assert(false); 
        }

        if(count < 0)
        {
            Console.WriteLine("Jumlah Pemutaran tidak boleh negatif.");
            return;
        }

        int currentCount = this.playcount;
        currentCount += count;
        this.playcount = currentCount;
    }

    public void printTrackDetails()
    {
        Console.WriteLine($"Judul: {title}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Jumlah Memutar: {playcount}");
        Console.WriteLine("------------------------------");
    }

    public int getPlayCount()
    {
        return playcount; 
    }
}
class SayaMusicUser {
    private int id;
    public string username;
    private List<SayaMusicTrack> uploadedTracks;

    public SayaMusicUser(string username)
    {
        this.username = username;

        Debug.Assert(username != null);
        Debug.Assert(username.Length <= 100);

        Random idName = new Random();
        this.id = idName.Next(10000, 10000);

        this.uploadedTracks = new List<SayaMusicTrack>();
    }

    public int GetTotalPlayCount() { 
        int totalCount = 0;
        foreach (var track in this.uploadedTracks) {
            totalCount += track.getPlayCount();
        }
        return totalCount;
    }

    public void AddTrack(SayaMusicTrack track) { 
        if(track == null)
        {
            throw new ArgumentNullException("Tak tidak boleh null");
        }

        if(track == null)
        {
            throw new ArgumentException("playcount melebihi batas maksimum");
        }

        uploadedTracks.Add(track);
    }

    public void PrintAllTracks()
    {
        int number = 0;
        Console.WriteLine($"Username: {username}");
        foreach (var item in uploadedTracks)
        {
            Console.WriteLine("================================");
            Console.WriteLine($"Track ke-{number + 1} Judul: {item.title}");
        }

    }
}

class main {
    public static void Main(string[] args)
    {
        SayaMusicTrack track1 = new SayaMusicTrack("Supernatural by Newjeans");
        SayaMusicUser user1 = new SayaMusicUser("Nopal");
        user1.AddTrack(track1);
        Console.WriteLine($"Review judul: {track1.title} oleh {user1.username}");
        track1.IncreasePlayCount(10);
        user1.PrintAllTracks();


        SayaMusicTrack track2 = new SayaMusicTrack("Chase by Heart2Heart");
        user1.AddTrack(track2);

        track2.IncreasePlayCount(10);
        track2.printTrackDetails();

        SayaMusicTrack track3 = new SayaMusicTrack("Bubblegum By Newjeans");

        track3.IncreasePlayCount(10);
        track3.printTrackDetails(); 
        
        SayaMusicTrack track4 = new SayaMusicTrack("Opalite by Taylor Swift");
        track4.IncreasePlayCount(10);
        track4.printTrackDetails();

        SayaMusicTrack track5 = new SayaMusicTrack("Fate of Ophelia by Taylow Swift");
        track5.IncreasePlayCount(10);
        track5.printTrackDetails();

        SayaMusicTrack track6 = new SayaMusicTrack("Harvey by Her's");
        track6.IncreasePlayCount(10);
        track6.printTrackDetails();

        SayaMusicTrack track7 = new SayaMusicTrack("Drag Prah by Twenty Pilots");
        track7.IncreasePlayCount(10);
        track7.printTrackDetails();

        SayaMusicTrack track8 = new SayaMusicTrack("Rude by Heart2Heart");
        track8.IncreasePlayCount(10);
        track8.printTrackDetails();

        SayaMusicTrack track9 = new SayaMusicTrack("DIVE by IVE");
        track9.IncreasePlayCount(10);
        track9.printTrackDetails();

        SayaMusicTrack track10= new SayaMusicTrack("Ditto by Newjeans");
        track10.IncreasePlayCount(10);
        track10.printTrackDetails();
    }
}