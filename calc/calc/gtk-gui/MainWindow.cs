
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.WidthRequest = 800;
		this.HeightRequest = 600;
		this.CanDefault = true;
		this.CanFocus = true;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("gcalc");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.DefaultWidth = 800;
		this.DefaultHeight = 800;
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.HasDefault = true;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
