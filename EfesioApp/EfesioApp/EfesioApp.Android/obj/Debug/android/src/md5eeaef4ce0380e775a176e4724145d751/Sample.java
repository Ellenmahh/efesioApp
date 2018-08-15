package md5eeaef4ce0380e775a176e4724145d751;


public class Sample
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EfesioApp.Droid.Sample, EfesioApp.Android", Sample.class, __md_methods);
	}


	public Sample ()
	{
		super ();
		if (getClass () == Sample.class)
			mono.android.TypeManager.Activate ("EfesioApp.Droid.Sample, EfesioApp.Android", "", this, new java.lang.Object[] {  });
	}

	public Sample (int p0, int p1, android.content.Intent p2)
	{
		super ();
		if (getClass () == Sample.class)
			mono.android.TypeManager.Activate ("EfesioApp.Droid.Sample, EfesioApp.Android", "System.Int32, mscorlib:System.Int32, mscorlib:Android.Content.Intent, Mono.Android", this, new java.lang.Object[] { p0, p1, p2 });
	}

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
