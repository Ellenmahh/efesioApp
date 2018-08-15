package md5eeaef4ce0380e775a176e4724145d751;


public class PlanetAdapter_ViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EfesioApp.Droid.PlanetAdapter+ViewHolder, EfesioApp.Android", PlanetAdapter_ViewHolder.class, __md_methods);
	}


	public PlanetAdapter_ViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == PlanetAdapter_ViewHolder.class)
			mono.android.TypeManager.Activate ("EfesioApp.Droid.PlanetAdapter+ViewHolder, EfesioApp.Android", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
