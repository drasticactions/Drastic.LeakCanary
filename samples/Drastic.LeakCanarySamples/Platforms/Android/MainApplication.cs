using Android.App;
using Android.Runtime;

namespace Drastic.LeakCanarySamples;

[Application]
public class MainApplication : MauiApplication
{
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override void OnCreate()
    {
        base.OnCreate();
        Leakcanary.AppWatcher.Instance.ManualInstall(this);
    }
}