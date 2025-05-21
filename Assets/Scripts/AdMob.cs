using UnityEngine;
using GoogleMobileAds.Api;

public class AdMob : MonoBehaviour {

    public const string adID = "ca-app-pub-5732715895750268/6624155273";
    public const string adID2 = "ca-app-pub-5732715895750268/3891557443";

    void Start()
    {
        MobileAds.Initialize("ca-app-pub-5732715895750268~2225745262");
        ShowBannerAd();
    }

    private void ShowBannerAd()
    {
        AdRequest request = new AdRequest.Builder()
            .AddTestDevice(AdRequest.TestDeviceSimulator)
            //.AddTestDevice("3FFDC168A88B369A")
            .AddTestDevice("305B5A0F5BE788B9")
            .Build();
        //AdRequest request = new AdRequest.Builder().Build();
        BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Center);
        bannerAd.LoadAd(request);
        bannerAd.Show();
        Debug.Log(request.TestDevices);
    }
    private void ShowBannerAd2()
    {
        InterstitialAd interstitial = new InterstitialAd(adID2);
        AdRequest request = new AdRequest.Builder().AddTestDevice("3FFDC168A88B369A").Build();
        interstitial.LoadAd(request);
        if (interstitial.IsLoaded())
        {
            Debug.Log("11");
            interstitial.Show();
        }
    }
}
