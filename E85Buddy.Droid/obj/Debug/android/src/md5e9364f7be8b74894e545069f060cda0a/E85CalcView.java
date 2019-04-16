package md5e9364f7be8b74894e545069f060cda0a;


public class E85CalcView
	extends md5231beb04e46a1dc811e36737109a7a02.MvxActivity_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("E85Buddy.Droid.Views.E85CalcView, E85Buddy.Droid", E85CalcView.class, __md_methods);
	}


	public E85CalcView ()
	{
		super ();
		if (getClass () == E85CalcView.class)
			mono.android.TypeManager.Activate ("E85Buddy.Droid.Views.E85CalcView, E85Buddy.Droid", "", this, new java.lang.Object[] {  });
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
