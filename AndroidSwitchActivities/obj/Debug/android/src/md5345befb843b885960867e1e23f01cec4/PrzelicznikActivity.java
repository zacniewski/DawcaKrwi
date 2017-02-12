package md5345befb843b885960867e1e23f01cec4;


public class PrzelicznikActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AndroidSwitchActivities.PrzelicznikActivity, AndroidSwitchActivities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PrzelicznikActivity.class, __md_methods);
	}


	public PrzelicznikActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PrzelicznikActivity.class)
			mono.android.TypeManager.Activate ("AndroidSwitchActivities.PrzelicznikActivity, AndroidSwitchActivities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
