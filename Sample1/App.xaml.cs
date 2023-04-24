using Firebase.Database;
using Firebase.Storage;

namespace Sample1;

public partial class App : Application
{
    public static FirebaseClient client = new("https://irentmertdb-default-rtdb.asia-southeast1.firebasedatabase.app/");
    public static FirebaseStorage _firebaseStorage = new("irentmertdb.appspot.com");
    public static FileResult _mainimgResult, _img1Result, _img2Result, _img3Result,
        _img4Result, _img5Result, _img6Result;

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
