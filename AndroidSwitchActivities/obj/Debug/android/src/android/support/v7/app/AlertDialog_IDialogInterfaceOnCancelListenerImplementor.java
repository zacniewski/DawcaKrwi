package android.support.v7.app;


public class AlertDialog_IDialogInterfaceOnCancelListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.content.DialogInterface.OnCancelListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCancel:(Landroid/content/DialogInterface;)V:GetOnCancel_Landroid_content_DialogInterface_Handler:Android.Content.IDialogInterfaceOnCancelListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V7.App.AlertDialog+IDialogInterfaceOnCancelListenerImplementor, Xamarin.Android.Support.v7.AppCompat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=71f3e3261ac778b5", AlertDialog_IDialogInterfaceOnCancelListenerImplementor.class, __md_methods);
	}


	public AlertDialog_IDialogInterfaceOnCancelListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AlertDialog_IDialogInterfaceOnCancelListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V7.App.AlertDialog+IDialogInterfaceOnCancelListenerImplementor, Xamarin.Android.Support.v7.AppCompat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=71f3e3261ac778b5", "", this, new java.lang.Object[] {  });
	}


	public void onCancel (android.content.DialogInterface p0)
	{
		n_onCancel (p0);
	}

	private native void n_onCancel (android.content.DialogInterface p0);

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
