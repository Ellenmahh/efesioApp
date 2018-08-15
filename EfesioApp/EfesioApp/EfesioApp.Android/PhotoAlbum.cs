using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;
namespace EfesioApp.Droid
{
    public class Photo
    {
        public int mPhotoID { get; set; }
        public string mCaption { get; set; }
    }
    public class PhotoAlbum
    {
           
        static Photo[] listPhoto =
        {
            new Photo() {mPhotoID = Resource.Drawable.thor, mCaption = "Ahsan 1"},
            new Photo() {mPhotoID = Resource.Drawable.thanos, mCaption = "Ahsan 2"},
            
        };
        private Photo[] photos;
        Random random;
        public PhotoAlbum()
        {
            this.photos = listPhoto;
            random = new Random();
        }
        public int numPhoto
        {
            get
            {
                return photos.Length;
            }
        }
        public Photo this[int i]
        {
            get { return photos[i]; }
        }
    }
    public class PhotoViewHolder : RecyclerView.ViewHolder
    {
        public ImageView Image { get; set; }
        public TextView Caption { get; set; }
        public PhotoViewHolder(View itemview, Action<int> listener) : base(itemview)
        {
            Image = itemview.FindViewById<ImageView>(Resource.Id.image);
            Caption = itemview.FindViewById<TextView>(Resource.Id.textView);
            itemview.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }

}