package md5eeaef4ce0380e775a176e4724145d751;


public class NavigationDrawerActivity_MyActionBarDrawerToggle
	extends android.support.v4.app.ActionBarDrawerToggle
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDrawerClosed:(Landroid/view/View;)V:GetOnDrawerClosed_Landroid_view_View_Handler\n" +
			"n_onDrawerOpened:(Landroid/view/View;)V:GetOnDrawerOpened_Landroid_view_View_Handler\n" +
			"";
		mono.android.Runtime.register ("EfesioApp.Droid.NavigationDrawerActivity+MyActionBarDrawerToggle, EfesioApp.Android", NavigationDrawerActivity_MyActionBarDrawerToggle.class, __md_methods);
	}


	public NavigationDrawerActivity_MyActionBarDrawerToggle (android.app.Activity p0, android.support.v4.widget.DrawerLayout p1, boolean p2, int p3, int p4, int p5)
	{
		super (p0, p1, p2, p3, p4, p5);
		if (getClass () == NavigationDrawerActivity_MyActionBarDrawerToggle.class)
			mono.android.TypeManager.Activate ("EfesioApp.Droid.NavigationDrawerActivity+MyActionBarDrawerToggle, EfesioApp.Android", "Android.App.Activity, Mono.Android:Android.Support.V4.Widget.DrawerLayout, Xamarin.Android.Support.Core.UI:System.Boolean, mscorlib:System.Int32, mscorlib:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3, p4, p5 });
	}


	public NavigationDrawerActivity_MyActionBarDrawerToggle (android.app.Activity p0, android.support.v4.widget.DrawerLayout p1, int p2, int p3, int p4)
	{
		super (p0, p1, p2, p3, p4);
		if (getClass () == NavigationDrawerActivity_MyActionBarDrawerToggle.class)
			mono.android.TypeManager.Activate ("EfesioApp.Droid.NavigationDrawerActivity+MyActionBarDrawerToggle, EfesioApp.Android", "Android.App.Activity, Mono.Android:Android.Support.V4.Widget.DrawerLayout, Xamarin.Android.Support.Core.UI:System.Int32, mscorlib:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3, p4 });
	}


	public void onDrawerClosed (android.view.View p0)
	{
		n_onDrawerClosed (p0);
	}

	private native void n_onDrawerClosed (android.view.View p0);


	public void onDrawerOpened (android.view.View p0)
	{
		n_onDrawerOpened (p0);
	}

	private native void n_onDrawerOpened (android.view.View p0);

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
