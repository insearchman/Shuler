using UnityEngine;

public class onStart : MonoBehaviour
{
    [SerializeField] GameObject startButton, optionsButton;

    //private const string banner = "ca-app-pub-5732715895750268~2225745262";
    //private const string banner = "ca-app-pub-5732715895750268/6624155273";

    void Start ()
    {
        startButton.GetComponent<MoveButtons>().cardAng.z = 358f;
        startButton.GetComponent<MoveButtons>().isVisible = true;
        optionsButton.GetComponent<MoveButtons>().cardAng.z = 371f;
        optionsButton.GetComponent<MoveButtons>().isVisible = true;

        //BannerView bannerV = new BannerView(banner, AdSize.Banner, AdPosition.Bottom);
        //AdRequest request = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator).AddTestDevice("3FFDC168A88B369A").Build();
        ////AdRequest request = new AdRequest.Builder().Build();
        //bannerV.LoadAd(request);
    }
}
